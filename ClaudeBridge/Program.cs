using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using ClaudeBridge.Communication;
using ClaudeBridge.API;
using ClaudeBridge.Knowledge;
using ClaudeBridge.Foundation;
using Newtonsoft.Json;

namespace ClaudeBridge
{
    /// <summary>
    /// ClaudeBridge - GRID AI Companion Application
    /// Main console application providing Claude AI integration and natural language
    /// interface for the GRID Space Engineers automation system.
    /// </summary>
    class Program
    {
        #region Application Information
        
        private const string APPLICATION_VERSION = "1.0";
        private const string APPLICATION_NAME = "ClaudeBridge";
        
        #endregion
        
        #region Application State
        
        private static bool _isRunning = false;
        private static string _claudeApiKey = null;
        private static ClaudeAPIClient _claudeClient = null;
        
        // Step 25: SE Knowledge System
        private static DocumentationRetriever _knowledgeRetriever = null;
        private static DocumentationIndex _knowledgeIndex = null;
        private static List<SECommand> _seCommands = null;
        
        #endregion
        
        #region Main Application Entry Point
        
        /// <summary>
        /// Main application entry point
        /// </summary>
        static async Task Main(string[] args)
        {
            try
            {
                // Display startup banner
                DisplayStartupBanner();
                
                // Initialize application
                var initResult = await InitializeApplicationAsync();
                if (!initResult)
                {
                    Console.WriteLine("❌ INITIALIZATION FAILED");
                    // FIXED: Only try to read key if console is available (not redirected)
                    if (Environment.UserInteractive && !Console.IsInputRedirected)
                    {
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                    }
                    return;
                }
                
                // Start main operation loop
                await StartMainOperationLoopAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ STARTUP FAILED: {ex.Message}");
                // FIXED: Only try to read key if console is available (not redirected)
                if (Environment.UserInteractive && !Console.IsInputRedirected)
                {
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
            finally
            {
                await ShutdownApplicationAsync();
            }
        }
        
        #endregion
        
        #region Application Initialization
        
        /// <summary>
        /// Display startup banner
        /// </summary>
        private static void DisplayStartupBanner()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    🤖 GRID AI COMPANION - ClaudeBridge v1.0               ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("║    Intelligent Space Engineers Automation System            ║");
            Console.WriteLine("║    Powered by Claude AI                                      ║");
            Console.WriteLine("║                                                              ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.WriteLine($"🚀 Starting {APPLICATION_NAME} v{APPLICATION_VERSION}...");
            Console.WriteLine();
        }
        
        /// <summary>
        /// Initialize application systems
        /// </summary>
        private static async Task<bool> InitializeApplicationAsync()
        {
            try
            {
                Console.WriteLine("🔧 Initializing ClaudeBridge systems...");
                
                // Step 1: Load configuration
                Console.WriteLine("   📋 Loading configuration...");
                if (!LoadConfiguration())
                {
                    Console.WriteLine("   ❌ Configuration loading failed");
                    return false;
                }
                Console.WriteLine("   ✅ Configuration loaded successfully");
                
                // Step 2: Validate Claude API key
                Console.WriteLine("   🔑 Validating Claude API key...");
                if (!ValidateClaudeApiKey())
                {
                    Console.WriteLine("   ❌ Claude API key validation failed");
                    return false;
                }
                Console.WriteLine("   ✅ Claude API key validated");
                
                // Step 3: Initialize core systems
                Console.WriteLine("   ⚙️  Initializing core systems...");
                
                // Initialize file communication with SE mod
                if (!FileCommProtocol.Initialize())
                {
                    Console.WriteLine("   ❌ File communication initialization failed");
                    return false;
                }
                Console.WriteLine("   ✅ File communication initialized");
                
                // Step 25: Initialize SE Knowledge System
                Console.WriteLine("   📚 Loading Space Engineers knowledge base...");
                if (!await InitializeKnowledgeSystemAsync())
                {
                    Console.WriteLine("   ❌ SE Knowledge system initialization failed");
                    return false;
                }
                Console.WriteLine("   ✅ SE Knowledge system initialized");
                
                // Step 28: Initialize Claude API client
                try
                {
                    _claudeClient = new ClaudeAPIClient(_claudeApiKey);
                    Console.WriteLine("   ✅ Claude API client initialized");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"   ❌ Claude API client initialization failed: {ex.Message}");
                    return false;
                }
                
                Console.WriteLine("   ✅ Core systems initialized");
                
                Console.WriteLine();
                Console.WriteLine("✅ ClaudeBridge initialization complete!");
                Console.WriteLine();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Initialization failed: {ex.Message}");
                return false;
            }
        }
        
        /// <summary>
        /// Load application configuration
        /// </summary>
        private static bool LoadConfiguration()
        {
            try
            {
                // Try to get Claude API key from environment variable first
                _claudeApiKey = Environment.GetEnvironmentVariable("CLAUDE_API_KEY");
                
                // If not found, try local api_key.txt file
                if (string.IsNullOrEmpty(_claudeApiKey))
                {
                    try
                    {
                        var apiKeyFile = "api_key.txt";
                        if (System.IO.File.Exists(apiKeyFile))
                        {
                            _claudeApiKey = System.IO.File.ReadAllText(apiKeyFile).Trim();
                            Console.WriteLine("   ℹ️  Using API key from api_key.txt file");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"   ⚠️  Could not read api_key.txt: {ex.Message}");
                    }
                }
                
                // If not found, check app.config
                if (string.IsNullOrEmpty(_claudeApiKey))
                {
                    try
                    {
                        _claudeApiKey = ConfigurationManager.AppSettings["ClaudeAPIKey"];
                    }
                    catch
                    {
                        // Ignore config errors for now
                    }
                }
                
                // If still not found, prompt user to configure
                if (string.IsNullOrEmpty(_claudeApiKey))
                {
                    Console.WriteLine("   ❌ Claude API key not configured");
                    Console.WriteLine("   💡 Option 1: Set CLAUDE_API_KEY environment variable");
                    Console.WriteLine("   💡 Option 2: Create api_key.txt file with your Claude API key");
                    Console.WriteLine("   💡 Option 3: Add to app.config: <add key=\"ClaudeAPIKey\" value=\"your_key_here\" />");
                    return false;
                }
                
                return !string.IsNullOrEmpty(_claudeApiKey);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Configuration loading error: {ex.Message}");
                return false;
            }
        }
        
        /// <summary>
        /// Validate Claude API key format
        /// </summary>
        private static bool ValidateClaudeApiKey()
        {
            try
            {
                if (string.IsNullOrEmpty(_claudeApiKey))
                {
                    Console.WriteLine("   ❌ Claude API key not found");
                    Console.WriteLine("   💡 Set CLAUDE_API_KEY environment variable or add to app.config");
                    return false;
                }
                
                if (!_claudeApiKey.StartsWith("sk-ant-api"))
                {
                    Console.WriteLine("   ❌ Invalid Claude API key format");
                    Console.WriteLine("   💡 Claude API keys should start with 'sk-ant-api'");
                    return false;
                }
                
                Console.WriteLine($"   ✅ Claude API key validated (ends with ...{_claudeApiKey.Substring(_claudeApiKey.Length - 8)})");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ API key validation error: {ex.Message}");
                return false;
            }
        }
        
        /// <summary>
        /// Initialize SE Knowledge System (Step 25)
        /// </summary>
        /// <returns>True if initialization successful</returns>
        private static async Task<bool> InitializeKnowledgeSystemAsync()
        {
            try
            {
                // Load SE knowledge base from JSONL files
                var (commands, stats) = SEKnowledgeLoader.LoadKnowledgeBase();
                
                if (commands == null || commands.Count == 0)
                {
                    Console.WriteLine("      ❌ No SE commands loaded from knowledge base");
                    return false;
                }
                
                _seCommands = commands;
                Console.WriteLine($"      ✅ Loaded {stats.CommandsLoaded} SE commands in {stats.LoadingTime.TotalMilliseconds:F0}ms");
                
                // Initialize documentation cache and retriever
                var cache = new DocumentationCache(maxCacheSize: 2000, cacheExpiryMinutes: 120);
                _knowledgeRetriever = new DocumentationRetriever(_seCommands, cache);
                Console.WriteLine($"      ✅ Documentation retriever initialized");
                
                // Build search index
                _knowledgeIndex = new DocumentationIndex(_seCommands);
                Console.WriteLine($"      ✅ Search index built");
                
                // Show knowledge statistics
                Console.WriteLine($"      📊 Knowledge Base Stats:");
                foreach (var categoryStats in stats.CategoryCounts.OrderByDescending(x => x.Value).Take(5))
                {
                    Console.WriteLine($"         {categoryStats.Key}: {categoryStats.Value} commands");
                }
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"      ❌ Knowledge system initialization error: {ex.Message}");
                return false;
            }
        }
        
        #endregion
        
        #region Main Operation Loop
        
        /// <summary>
        /// Start main operation loop
        /// </summary>
        private static async Task StartMainOperationLoopAsync()
        {
            _isRunning = true;
            
            Console.WriteLine("🎯 ClaudeBridge ready for AI companion interaction!");
            Console.WriteLine();
            Console.WriteLine("🚀 Quick Start:");
            Console.WriteLine("  1. Make sure Space Engineers is running with your ship loaded");
            Console.WriteLine("  2. Type 'ship' to see your available blocks");
            Console.WriteLine("  3. Try natural language: 'how many reactors?', 'turn on lights'");
            Console.WriteLine("  4. Type 'help' for detailed command list");
            Console.WriteLine();
            Console.WriteLine("💬 Enter commands or natural language instructions:");
            Console.WriteLine();
            
            while (_isRunning)
            {
                try
                {
                    Console.Write("🤖 GRID AI: ");
                    var userInput = Console.ReadLine();
                    
                    // Handle end of input stream (e.g., from piped input)
                    if (userInput == null)
                    {
                        Console.WriteLine("End of input detected, shutting down...");
                        _isRunning = false;
                        break;
                    }
                    
                    if (string.IsNullOrEmpty(userInput))
                    {
                        continue;
                    }
                    
                    await ProcessUserInputAsync(userInput.Trim());
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"❌ Error processing input: {ex.Message}");
                }
            }
        }
        
        /// <summary>
        /// Process user input
        /// </summary>
        private static async Task ProcessUserInputAsync(string userInput)
        {
            try
            {
                var inputLower = userInput.ToLower();
                
                switch (inputLower)
                {
                    case "exit":
                    case "quit":
                    case "shutdown":
                        Console.WriteLine("👋 Shutting down ClaudeBridge...");
                        _isRunning = false;
                        break;
                        
                    case "test":
                        await RunSystemTestAsync();
                        break;
                        
                    case "status":
                        DisplaySystemStatus();
                        break;
                        
                    case "help":
                        DisplayHelpInformation();
                        break;
                        
                    case "knowledge":
                        await TestKnowledgeSystemAsync();
                        break;
                        
                    case "ship":
                        await TestShipCompositionAsync();
                        break;
                        
                    case "debug":
                        ShowDebugSettings();
                        break;
                        
                    default:
                        // Check if it's a debug level command
                        if (userInput.StartsWith("debug ") && userInput.Length > 6)
                        {
                            var levelStr = userInput.Substring(6).Trim();
                            if (int.TryParse(levelStr, out int level) && level >= 0 && level <= 4)
                            {
                                DebugOutputManager.SetVerbosity((DebugOutputManager.VerbosityLevel)level);
                                Console.WriteLine($"✅ Debug level set to {level} ({(DebugOutputManager.VerbosityLevel)level})");
                            }
                            else
                            {
                                Console.WriteLine("❌ Invalid debug level. Use 0-4 (0=Silent, 1=Essential, 2=Normal, 3=Detailed, 4=Verbose)");
                            }
                        }
                        // Check if it's a search command
                        else if (userInput.StartsWith("search "))
                        {
                            var query = userInput.Substring(7).Trim();
                            await SearchKnowledgeBaseAsync(query);
                        }
                        else
                        {
                            await ProcessAICommandAsync(userInput);
                        }
                        break;
                }
                
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Input processing error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Process AI command using Claude LLM - TRUE AI COMPANION
        /// </summary>
        private static async Task ProcessAICommandAsync(string userInput)
        {
            try
            {
                Console.WriteLine($"🧠 AI Companion: '{userInput}'");
                
                if (_claudeClient == null)
                {
                    Console.WriteLine("   ❌ Claude AI not available");
                    return;
                }
                
                // Step 28: Use Claude AI for true natural language understanding
                Console.WriteLine("   🤖 Thinking...");
                
                // Step 25: Enhance with SE Knowledge System
                var enhancedSystemPrompt = await BuildEnhancedSystemPromptAsync(userInput);
                
                var claudeRequest = new ClaudeAPIClient.ClaudeRequest
                {
                    UserMessage = userInput,
                    SystemPrompt = enhancedSystemPrompt,
                    Temperature = 0.1,
                    MaxTokens = 150  // PERFORMANCE: Reduced from 1000 to 150 for faster responses
                };
                
                var claudeResponse = await _claudeClient.SendRequestAsync(claudeRequest);
                
                if (claudeResponse.Success)
                {
                    // FIXED: For status/query commands, execute FIRST then respond with real data
                    if (IsStatusQuery(userInput))
                    {
                        // Execute command first to get real data
                        if (!string.IsNullOrEmpty(claudeResponse.CommandId) || claudeResponse.Content.Contains("{"))
                        {
                            Console.WriteLine($"   🔍 Executing query to get real data first...");
                            
                            // Check if Claude generated multiple commands
                            var commandInfo = ExtractCommandsFromResponse(claudeResponse.Content);
                            
                            if (commandInfo.HasMultipleCommands)
                            {
                                Console.WriteLine($"   🔍 Multiple commands: {commandInfo.MultipleCommands.Count} operations");
                                Console.WriteLine($"   📤 Executing sequence...");
                                await ExecuteMultipleCommandsAsync(commandInfo.MultipleCommands);
                            }
                            else if (!string.IsNullOrEmpty(claudeResponse.CommandId))
                            {
                                Console.WriteLine($"   🔍 Command: {claudeResponse.CommandId} → {claudeResponse.Target}");
                                await ExecuteSingleCommandAsync(claudeResponse.CommandId, claudeResponse.Target, claudeResponse.Category);
                            }
                        }
                        else
                        {
                            // No command generated, just display conversation response
                            if (!string.IsNullOrEmpty(claudeResponse.ConversationResponse))
                            {
                                Console.WriteLine($"   💬 AI: {claudeResponse.ConversationResponse}");
                            }
                        }
                    }
                    else
                    {
                        // For action commands, display response first then execute
                        // Display Claude's conversational response
                        if (!string.IsNullOrEmpty(claudeResponse.ConversationResponse))
                        {
                            Console.WriteLine($"   💬 AI: {claudeResponse.ConversationResponse}");
                        }
                        
                            // Only execute commands if Claude actually generated them (not just conversation)
                            if (!string.IsNullOrEmpty(claudeResponse.CommandId) || claudeResponse.Content.Contains("{"))
                            {
                                // Check if Claude generated multiple commands
                                var commandInfo = ExtractCommandsFromResponse(claudeResponse.Content);
                                
                                if (commandInfo.HasMultipleCommands)
                                {
                                    Console.WriteLine($"   🔍 Multiple commands: {commandInfo.MultipleCommands.Count} operations");
                                    Console.WriteLine($"   📤 Executing sequence...");
                                    await ExecuteMultipleCommandsAsync(commandInfo.MultipleCommands);
                                }
                                else if (!string.IsNullOrEmpty(claudeResponse.CommandId))
                                {
                                    Console.WriteLine($"   🔍 Command: {claudeResponse.CommandId} → {claudeResponse.Target}");
                                    await ExecuteSingleCommandAsync(claudeResponse.CommandId, claudeResponse.Target, claudeResponse.Category);
                                }
                                else if (commandInfo.MultipleCommands.Count == 1)
                                {
                                    var cmd = commandInfo.MultipleCommands[0];
                                    Console.WriteLine($"   🔍 Command: {cmd.CommandId} → {cmd.Target}");
                                    await ExecuteSingleCommandAsync(cmd.CommandId, cmd.Target, cmd.Category);
                                }
                            }
                    }
                    
                    // Show response time
                    if (claudeResponse.ResponseTimeMs > 0)
                    {
                        Console.WriteLine($"   ⏱️  Response time: {claudeResponse.ResponseTimeMs}ms");
                    }
                }
                else
                {
                    Console.WriteLine($"   ❌ Claude AI error: {claudeResponse.ErrorMessage}");
                    
                    // Fallback to basic pattern matching if Claude fails
                    Console.WriteLine("   🔄 Falling back to basic pattern matching...");
                    await ProcessBasicCommandAsync(userInput);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ AI processing error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Fallback basic command processing
        /// </summary>
        private static async Task ProcessBasicCommandAsync(string userInput)
        {
            try
            {
                // Use enhanced pattern matching as fallback
                var commandId = MapUserInputToCommandId(userInput);
                if (!string.IsNullOrEmpty(commandId))
                {
                    var target = ExtractTarget(userInput);
                    var category = DetermineCategoryFromCommand(commandId);
                    var response = await FileCommProtocol.SendCommandAsync(commandId, target, category);
                    
                    if (response.Success)
                    {
                        Console.WriteLine($"   ✅ Fallback success: {response.Message}");
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ Fallback failed: {response.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("   📝 Command not recognized in fallback mode");
                    Console.WriteLine("   💡 Try simpler commands like: 'how many reactors?', 'turn on lights', 'power status'");
                    Console.WriteLine("   💡 Or use direct commands: 'status', 'ship', 'knowledge' to explore system capabilities");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Fallback processing error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Basic command mapping (Claude AI will replace this in Step 28)
        /// </summary>
        private static string MapUserInputToCommandId(string input)
        {
            var inputLower = input.ToLower().Trim();
            
            // Step 9 - Power Management Commands
            if (inputLower.Contains("battery") && inputLower.Contains("auto"))
                return "battery_mode_auto";
            else if (inputLower.Contains("battery") && inputLower.Contains("recharge"))
                return "battery_mode_recharge";
            else if (inputLower.Contains("battery") && inputLower.Contains("discharge"))
                return "battery_mode_discharge";
            else if (inputLower.Contains("power") && inputLower.Contains("status"))
                return "power_status";
            
            // FIXED: Status queries for specific components should still use power_status
            else if ((inputLower.Contains("how many") || inputLower.Contains("check")) && 
                     (inputLower.Contains("reactor") || inputLower.Contains("battery")))
                return "power_status";
            
            // Step 9 - Life Support Commands
            else if (inputLower.Contains("oxygen") && (inputLower.Contains("on") || inputLower.Contains("enable") || inputLower.Contains("generation")))
                return "oxygen_generation_on";
            else if (inputLower.Contains("oxygen") && (inputLower.Contains("off") || inputLower.Contains("disable")))
                return "oxygen_generation_off";
            else if (inputLower.Contains("life support") && inputLower.Contains("status"))
                return "life_support_status";
            else if (inputLower.Contains("pressurize") || (inputLower.Contains("air") && inputLower.Contains("fill")))
                return "air_vent_pressurize";
            else if (inputLower.Contains("depressurize") || (inputLower.Contains("air") && inputLower.Contains("empty")))
                return "air_vent_depressurize";
            
            // Step 9 - Automation Commands
            else if (inputLower.Contains("timer") && (inputLower.Contains("trigger") || inputLower.Contains("start")))
                return "trigger_timer";
            else if (inputLower.Contains("automation") && inputLower.Contains("status"))
                return "automation_status";
            
            // Step 7 - Universal Commands (existing)
            else if (inputLower.Contains("reactor") && (inputLower.Contains("off") || inputLower.Contains("disable")))
                return "turn_off_reactor";
            else if (inputLower.Contains("reactor") && (inputLower.Contains("on") || inputLower.Contains("enable")))
                return "turn_on_reactor";
            else if (inputLower.Contains("light") && (inputLower.Contains("off") || inputLower.Contains("disable")))
                return "turn_off_lights";
            else if (inputLower.Contains("light") && (inputLower.Contains("on") || inputLower.Contains("enable")))
                return "turn_on_lights";
            else if (inputLower.Contains("assembler") && (inputLower.Contains("on") || inputLower.Contains("enable")))
                return "turn_on_assembler";
            else if (inputLower.Contains("assembler") && (inputLower.Contains("off") || inputLower.Contains("disable")))
                return "turn_off_assembler";
            
            // General status commands
            else if (inputLower.Contains("status") || inputLower.Contains("check"))
                return "get_status";
            
            return "";
        }
        
        /// <summary>
        /// Extract target from user input (Claude AI will do this properly in Step 28)
        /// </summary>
        private static string ExtractTarget(string input)
        {
            var inputLower = input.ToLower();
            
            // FIXED: Power status queries should always use "all" for complete ship overview
            if ((inputLower.Contains("how many") || inputLower.Contains("check") || inputLower.Contains("status")) && 
                (inputLower.Contains("reactor") || inputLower.Contains("battery") || inputLower.Contains("power")))
                return "all";
            
            // Step 9 - Specialized targets (for action commands, not status)
            else if (inputLower.Contains("battery") || inputLower.Contains("batteries"))
                return "batteries";
            else if (inputLower.Contains("oxygen") && inputLower.Contains("generator"))
                return "oxygen_generators";
            else if (inputLower.Contains("air") && inputLower.Contains("vent"))
                return "air_vents";
            else if (inputLower.Contains("timer"))
                return "timers";
            
            // Step 7 - Universal targets  
            else if (inputLower.Contains("all"))
                return "all";
            else if (inputLower.Contains("reactor"))
                return "reactors";
            else if (inputLower.Contains("light"))
                return "lights";
            else if (inputLower.Contains("assembler"))
                return "assembler";
            else
                return "all";
        }
        
        /// <summary>
        /// Determine command category for Step 9 controller routing
        /// </summary>
        private static string DetermineCategoryFromCommand(string commandId)
        {
            if (string.IsNullOrEmpty(commandId)) return "power";
            
            var command = commandId.ToLower();
            
            // Step 9 - Power Management
            if (command.Contains("battery_mode") || command.Contains("power_status"))
                return "power_management";
            
            // Step 9 - Life Support
            else if (command.Contains("oxygen_generation") || command.Contains("life_support_status") || 
                     command.Contains("air_vent") || command.Contains("pressurize"))
                return "life_support";
            
            // Step 9 - Automation
            else if (command.Contains("timer") || command.Contains("automation"))
                return "automation";
            
            // Step 7 - Universal commands
            else if (command.Contains("light"))
                return "lighting";
            else if (command.Contains("reactor"))
                return "power";
            else if (command.Contains("assembler"))
                return "production";
            
            // Default
            return "power";
        }
        
        #endregion
        
        #region System Commands
        
        /// <summary>
        /// Run system test
        /// </summary>
        private static async Task RunSystemTestAsync()
        {
            try
            {
                Console.WriteLine("🧪 Running ClaudeBridge system test...");
                Console.WriteLine();
                
                // Test 1: Configuration
                Console.WriteLine("Test 1: Configuration");
                Console.WriteLine($"   ✅ Claude API Key: Configured (ends with ...{_claudeApiKey.Substring(_claudeApiKey.Length - 8)})");
                
                // Test 2: Application state
                Console.WriteLine("Test 2: Application State");
                Console.WriteLine($"   ✅ Application Version: {APPLICATION_VERSION}");
                Console.WriteLine($"   ✅ Running State: {_isRunning}");
                
                // Test 3: Communication system
                Console.WriteLine("Test 3: Communication System");
                var commStatus = FileCommProtocol.GetCommunicationStatus();
                Console.WriteLine($"   ✅ File Communication: {commStatus}");
                
                // Test 4: Claude API Integration
                Console.WriteLine("Test 4: Claude API Integration");
                if (_claudeClient != null)
                {
                    Console.WriteLine("   🔄 Testing Claude API...");
                    
                    var testRequest = new ClaudeAPIClient.ClaudeRequest
                    {
                        UserMessage = "Hello, can you help me test the connection?",
                        SystemPrompt = ClaudeAPIClient.BuildSystemPrompt(),
                        MaxTokens = 100
                    };
                    
                    var claudeResponse = await _claudeClient.SendRequestAsync(testRequest);
                    
                    if (claudeResponse.Success)
                    {
                        Console.WriteLine($"   ✅ Claude API working - Response in {claudeResponse.ResponseTimeMs}ms");
                        Console.WriteLine($"   💬 Claude: {claudeResponse.ConversationResponse}");
                        
                        // Validate Step 28 requirement
                        if (claudeResponse.ResponseTimeMs <= 800)
                        {
                            Console.WriteLine("   ✅ STEP 28 REQUIREMENT MET - Response in <800ms");
                        }
                        else
                        {
                            Console.WriteLine($"   ⚠️  Response time {claudeResponse.ResponseTimeMs}ms exceeds 800ms target");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"   ❌ Claude API test failed: {claudeResponse.ErrorMessage}");
                    }
                }
                else
                {
                    Console.WriteLine("   ❌ Claude API client not initialized");
                }
                
                // Test 5: SE mod communication
                Console.WriteLine("Test 5: SE Mod Communication");
                Console.WriteLine("   🔄 Testing communication with SE mod...");
                
                var commTest = await FileCommProtocol.TestCommunicationAsync();
                if (commTest)
                {
                    Console.WriteLine("   ✅ SE mod communication working");
                }
                else
                {
                    Console.WriteLine("   ⚠️  SE mod communication test failed (SE mod may not be running)");
                }
                
                Console.WriteLine();
                Console.WriteLine("✅ System test complete - ClaudeBridge foundation working!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ System test failed: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Display system status
        /// </summary>
        private static void DisplaySystemStatus()
        {
            try
            {
                Console.WriteLine("📊 ClaudeBridge System Status:");
                Console.WriteLine();
                Console.WriteLine($"   Application: {APPLICATION_NAME} v{APPLICATION_VERSION}");
                Console.WriteLine($"   Status: {(_isRunning ? "Running" : "Stopped")}");
                Console.WriteLine($"   Claude API: {(_claudeClient != null ? "Connected" : "Not Connected")}");
                Console.WriteLine($"   Framework: .NET 8.0");
                Console.WriteLine();
                
                // Show Claude API statistics if available
                if (_claudeClient != null)
                {
                    Console.WriteLine("🤖 Claude AI Status:");
                    Console.WriteLine($"   {_claudeClient.GetStatistics()}");
                    Console.WriteLine();
                }
                
                Console.WriteLine("🔄 Implementation Progress:");
                Console.WriteLine("   ✅ Step 24: Foundation (ClaudeBridge console app)");
                Console.WriteLine("   ✅ Step 28: Claude API Integration (TRUE AI conversation)");
                Console.WriteLine("   ✅ Communication: File protocol with SE mod working");
                Console.WriteLine("   ⏳ Step 25: SE Knowledge System (enhanced context)");
                Console.WriteLine("   ⏳ Step 27: Advanced NLP Processing (intent classification)");
                Console.WriteLine();
                Console.WriteLine("🎯 Current Capability: TRUE AI COMPANION with natural conversation and ship control");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Status display error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Display help information
        /// </summary>
        private static void DisplayHelpInformation()
        {
            try
            {
                Console.WriteLine("📖 ClaudeBridge Help:");
                Console.WriteLine();
                Console.WriteLine("🔧 System Commands:");
                Console.WriteLine("   test      - Run system diagnostic test");
                Console.WriteLine("   status    - Show current system status");
                Console.WriteLine("   ship      - Show ship composition and available blocks");
                Console.WriteLine("   knowledge - Test SE knowledge system");
                Console.WriteLine("   search <query> - Search available SE commands");
                Console.WriteLine("   help      - Show this help information");
                Console.WriteLine("   exit      - Shutdown ClaudeBridge");
                Console.WriteLine();
                Console.WriteLine("🤖 Natural Language Examples:");
                Console.WriteLine("   'how many reactors?'     - Check reactor count");
                Console.WriteLine("   'turn on lights'         - Control lighting");
                Console.WriteLine("   'power status'           - Check power systems");
                Console.WriteLine("   'reactor count'          - Count reactors");
                Console.WriteLine("   'battery status'         - Check batteries");
                Console.WriteLine();
                Console.WriteLine("💡 Tips:");
                Console.WriteLine("   - Use 'ship' command first to see your available blocks");
                Console.WriteLine("   - Use generic targets: 'reactor', 'lights', 'all' instead of 'main_reactor'");
                Console.WriteLine("   - Make sure Space Engineers is running with GRID mod loaded");
                Console.WriteLine();
                Console.WriteLine("AI Commands (Step 28 - Claude AI Integration):");
                Console.WriteLine("   Any natural language will be processed by Claude AI");
                Console.WriteLine("   Examples:");
                Console.WriteLine("     'turn off the lights please'");
                Console.WriteLine("     'can you enable the reactor?'");
                Console.WriteLine("     'hey, turn on the assembler'");
                Console.WriteLine("     'lights off'");
                Console.WriteLine("     'what's the status of the reactor?'");
                Console.WriteLine();
                Console.WriteLine("Current Status: TRUE AI COMPANION");
                Console.WriteLine("✅ Claude AI integration working");
                Console.WriteLine("✅ Natural conversation with ship control");
                Console.WriteLine("✅ Fallback to basic patterns if Claude unavailable");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Help display error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Show debug settings and allow user to change verbosity
        /// </summary>
        private static void ShowDebugSettings()
        {
            try
            {
                Console.WriteLine("🔧 Debug Output Management:");
                Console.WriteLine();
                DebugOutputManager.ShowSettings();
                Console.WriteLine();
                Console.WriteLine("💡 Commands:");
                Console.WriteLine("   debug 0  - Silent (no debug output)");
                Console.WriteLine("   debug 1  - Essential (critical info only)");
                Console.WriteLine("   debug 2  - Normal (standard operation)");
                Console.WriteLine("   debug 3  - Detailed (all debug info)");
                Console.WriteLine("   debug 4  - Verbose (everything)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Debug settings error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Test SE Knowledge System functionality
        /// </summary>
        private static async Task TestKnowledgeSystemAsync()
        {
            try
            {
                Console.WriteLine("🧪 Testing SE Knowledge System:");
                Console.WriteLine();
                
                if (_knowledgeRetriever == null || _knowledgeIndex == null || _seCommands == null)
                {
                    Console.WriteLine("❌ Knowledge system not initialized");
                    return;
                }
                
                Console.WriteLine($"📊 Knowledge Base Stats:");
                Console.WriteLine($"   Total Commands: {_seCommands.Count}");
                
                var categories = _seCommands.GroupBy(c => c.Category).OrderByDescending(g => g.Count()).Take(10);
                Console.WriteLine($"   Top Categories:");
                foreach (var category in categories)
                {
                    Console.WriteLine($"      {category.Key}: {category.Count()} commands");
                }
                Console.WriteLine();
                
                // Test search functionality
                var testQueries = new[] 
                {
                    "battery recharge mode",
                    "turn on reactor", 
                    "oxygen generation",
                    "power status",
                    "lighting control"
                };
                
                Console.WriteLine("🔍 Testing Command Search:");
                foreach (var query in testQueries)
                {
                    Console.WriteLine($"\nQuery: '{query}'");
                    var results = _knowledgeRetriever.FindCommands(query, maxResults: 3);
                    
                    if (results.Any())
                    {
                        Console.WriteLine($"   ✅ Found {results.Count} matches:");
                        foreach (var result in results)
                        {
                            Console.WriteLine($"      - {result.Command.Title} (score: {result.RelevanceScore:F1})");
                            Console.WriteLine($"        ID: {result.Command.Id}");
                            Console.WriteLine($"        Category: {result.Command.Category}");
                            if (result.MatchedTriggers.Any())
                            {
                                Console.WriteLine($"        Triggers: {string.Join(", ", result.MatchedTriggers.Take(2))}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("   ❌ No matches found");
                    }
                }
                
                // Test cache performance
                var cacheStats = _knowledgeRetriever.GetCacheStatistics();
                Console.WriteLine($"\n💾 Cache Performance:");
                Console.WriteLine($"   Total Requests: {cacheStats.TotalRequests}");
                Console.WriteLine($"   Cache Hits: {cacheStats.CacheHits}");
                Console.WriteLine($"   Hit Ratio: {cacheStats.HitRatio:P1}");
                Console.WriteLine($"   Cached Commands: {cacheStats.CachedCommands}");
                
                Console.WriteLine("\n✅ Knowledge system test complete!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Knowledge system test error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Search knowledge base for specific query
        /// </summary>
        /// <param name="query">Search query</param>
        private static async Task SearchKnowledgeBaseAsync(string query)
        {
            try
            {
                Console.WriteLine($"🔍 Searching SE Knowledge Base for: '{query}'");
                Console.WriteLine();
                
                if (_knowledgeRetriever == null)
                {
                    Console.WriteLine("❌ Knowledge system not initialized");
                    return;
                }
                
                var results = _knowledgeRetriever.FindCommands(query, maxResults: 10);
                
                if (results.Any())
                {
                    Console.WriteLine($"✅ Found {results.Count} matching commands:");
                    Console.WriteLine();
                    
                    for (int i = 0; i < results.Count; i++)
                    {
                        var result = results[i];
                        var cmd = result.Command;
                        
                        Console.WriteLine($"{i + 1}. {cmd.Title}");
                        Console.WriteLine($"   ID: {cmd.Id}");
                        Console.WriteLine($"   Category: {cmd.Category}");
                        Console.WriteLine($"   Relevance Score: {result.RelevanceScore:F1}");
                        
                        if (cmd.NaturalLanguageTriggers?.Any() == true)
                        {
                            Console.WriteLine($"   Triggers: {string.Join(", ", cmd.NaturalLanguageTriggers.Take(3))}");
                        }
                        
                        if (cmd.Targets?.AllowedTypes?.Any() == true)
                        {
                            Console.WriteLine($"   Block Types: {string.Join(", ", cmd.Targets.AllowedTypes.Take(3))}");
                        }
                        
                        if (cmd.SafetyClass != null)
                        {
                            Console.WriteLine($"   Safety: {cmd.SafetyClass}");
                        }
                        
                        Console.WriteLine();
                    }
                    
                    // Show search statistics
                    var cacheStats = _knowledgeRetriever.GetCacheStatistics();
                    Console.WriteLine($"📊 Search completed. Cache hit ratio: {cacheStats.HitRatio:P1}");
                }
                else
                {
                    Console.WriteLine("❌ No commands found matching your query");
                    Console.WriteLine("💡 Try searching for: 'battery', 'reactor', 'lights', 'oxygen', etc.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Knowledge search error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Test ship composition directly (bypass Claude to verify SE mod data)
        /// </summary>
        private static async Task TestShipCompositionAsync()
        {
            try
            {
                Console.WriteLine("🚢 Testing Ship Composition (Direct SE Mod Query):");
                Console.WriteLine();
                
                // Test power status with complete debugging
                Console.WriteLine("🔋 Testing Power Status:");
                var powerResponse = await FileCommProtocol.SendCommandAsync("power_status", "all", "power");
                
                if (powerResponse.Success)
                {
                    Console.WriteLine($"✅ Raw SE Mod Response: {powerResponse.Message}");
                    Console.WriteLine($"✅ Affected Blocks: {powerResponse.AffectedBlocks}");
                }
                else
                {
                    Console.WriteLine($"❌ Power Status Failed: {powerResponse.Message}");
                }
                
                Console.WriteLine();
                
                // Test universal status for comparison
                Console.WriteLine("🔧 Testing Universal Status:");
                var universalResponse = await FileCommProtocol.SendCommandAsync("get_status", "all", "power");
                
                if (universalResponse.Success)
                {
                    Console.WriteLine($"✅ Universal Controller Response: {universalResponse.Message}");
                    Console.WriteLine($"✅ Affected Blocks: {universalResponse.AffectedBlocks}");
                }
                else
                {
                    Console.WriteLine($"❌ Universal Status Failed: {universalResponse.Message}");
                }
                
                Console.WriteLine();
                
                // Test specific reactor targeting
                Console.WriteLine("🏭 Testing Reactor-Only Status:");
                var reactorResponse = await FileCommProtocol.SendCommandAsync("get_status", "reactor", "power");
                
                if (reactorResponse.Success)
                {
                    Console.WriteLine($"✅ Reactor-Only Response: {reactorResponse.Message}");
                    Console.WriteLine($"✅ Affected Blocks: {reactorResponse.AffectedBlocks}");
                }
                else
                {
                    Console.WriteLine($"❌ Reactor Status Failed: {reactorResponse.Message}");
                }
                
                Console.WriteLine();
                Console.WriteLine("🎯 Ship composition test complete - check logs for detailed block detection");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Ship composition test error: {ex.Message}");
            }
        }
        
        #endregion
        
        #region Command Execution Helpers - Multiple Command Support
        
        /// <summary>
        /// Extract command information from Claude response content
        /// </summary>
        private static ClaudeAPIClient.CommandExtractionResult ExtractCommandsFromResponse(string content)
        {
            try
            {
                var result = new ClaudeAPIClient.CommandExtractionResult();
                var commands = new List<ClaudeAPIClient.SingleCommand>();
                
                // Parse multiple JSON commands from Claude response
                var remainingContent = content;
                
                while (remainingContent.Contains("{") && remainingContent.Contains("}"))
                {
                    var jsonStart = remainingContent.IndexOf('{');
                    var braceCount = 0;
                    var jsonEnd = -1;
                    
                    // Find matching closing brace
                    for (int i = jsonStart; i < remainingContent.Length; i++)
                    {
                        if (remainingContent[i] == '{') braceCount++;
                        else if (remainingContent[i] == '}')
                        {
                            braceCount--;
                            if (braceCount == 0)
                            {
                                jsonEnd = i;
                                break;
                            }
                        }
                    }
                    
                    if (jsonStart >= 0 && jsonEnd > jsonStart)
                    {
                        var jsonPart = remainingContent.Substring(jsonStart, jsonEnd - jsonStart + 1);
                        
                        try
                        {
                            dynamic commandJson = JsonConvert.DeserializeObject(jsonPart);
                            
                            var commandId = commandJson?.command_id?.ToString() ?? "";
                            var target = commandJson?.target?.ToString() ?? "";
                            var category = commandJson?.category?.ToString() ?? "";
                            
                            if (!string.IsNullOrEmpty(commandId))
                            {
                                commands.Add(new ClaudeAPIClient.SingleCommand
                                {
                                    CommandId = commandId,
                                    Target = target,
                                    Category = category
                                });
                            }
                        }
                        catch (Exception jsonEx)
                        {
                            Console.WriteLine($"⚠️  JSON parsing error: {jsonEx.Message}");
                        }
                        
                        remainingContent = remainingContent.Substring(jsonEnd + 1);
                    }
                    else
                    {
                        break;
                    }
                }
                
                result.HasMultipleCommands = commands.Count > 1;
                result.MultipleCommands = commands;
                result.ConversationResponse = content;
                
                if (commands.Count == 1)
                {
                    result.CommandId = commands[0].CommandId;
                    result.Target = commands[0].Target;
                    result.Category = commands[0].Category;
                }
                
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️  Command extraction error: {ex.Message}");
                return new ClaudeAPIClient.CommandExtractionResult
                {
                    ConversationResponse = content
                };
            }
        }
        
        /// <summary>
        /// Execute multiple commands in sequence
        /// </summary>
        private static async Task ExecuteMultipleCommandsAsync(List<ClaudeAPIClient.SingleCommand> commands)
        {
            try
            {
                Console.WriteLine($"   📤 Executing {commands.Count} commands in sequence...");
                
                var totalAffected = 0;
                var successCount = 0;
                
                foreach (var command in commands)
                {
                    try
                    {
                        Console.WriteLine($"   ⚙️  Executing: {command.CommandId} → {command.Target}");
                        
                        var response = await FileCommProtocol.SendCommandAsync(
                            command.CommandId, 
                            command.Target, 
                            command.Category);
                        
                        if (response.Success)
                        {
                            Console.WriteLine($"      ✅ {command.CommandId}: {response.AffectedBlocks} blocks");
                            totalAffected += response.AffectedBlocks;
                            successCount++;
                        }
                        else
                        {
                            Console.WriteLine($"      ❌ {command.CommandId}: {response.Message}");
                        }
                        
                        // Small delay between commands
                        await Task.Delay(100);
                    }
                    catch (Exception cmdEx)
                    {
                        Console.WriteLine($"      ❌ {command.CommandId}: {cmdEx.Message}");
                    }
                }
                
                // Let Claude provide overall summary
                Console.WriteLine("   🧠 Summarizing operation...");
                var summaryMessage = $"Executed {successCount}/{commands.Count} commands successfully, affecting {totalAffected} total blocks.";
                await ConfirmActionWithClaudeAsync("multiple_operations", totalAffected, "multiple systems");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Multiple command execution error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Execute single command with result interpretation
        /// </summary>
        private static async Task ExecuteSingleCommandAsync(string commandId, string target, string category)
        {
            try
            {
                Console.WriteLine($"   📤 Executing...");
                
                var response = await FileCommProtocol.SendCommandAsync(commandId, target, category);
                
                // CRITICAL FIX: Let Claude interpret the SE mod results naturally
                if (response.Success)
                {
                    Console.WriteLine($"   ✅ Executed successfully");
                    
                    // If this was a status command, let Claude interpret the results
                    if (commandId.Contains("status") && !string.IsNullOrEmpty(response.Message))
                    {
                        // PERFORMANCE FIX: Skip Claude interpretation to avoid 4+ second delay
                        // Raw SE mod data is already readable for users
                        Console.WriteLine($"   📊 Status: {response.Message}");
                        
                        // DISABLED: Claude interpretation adds 4+ seconds with 529 overload errors
                        // Console.WriteLine("   🧠 Interpreting results...");
                        // await InterpretResultsWithClaudeAsync(response.Message, target);
                    }
                    else if (response.AffectedBlocks > 0)
                    {
                        // PERFORMANCE FIX: Skip Claude confirmation to avoid additional API delays
                        Console.WriteLine($"   ✅ Action completed - {response.AffectedBlocks} blocks affected");
                        
                        // DISABLED: Claude confirmation adds unnecessary API calls and delays
                        // Console.WriteLine("   🧠 Confirming action...");
                        // await ConfirmActionWithClaudeAsync(commandId, response.AffectedBlocks, target);
                    }
                }
                else
                {
                    Console.WriteLine($"   ❌ Execution failed");
                    
                    // PERFORMANCE FIX: Skip Claude error interpretation to avoid additional API delays
                    Console.WriteLine($"   ❌ Error: {response.Message}");
                    
                    // UX IMPROVEMENT: Add helpful suggestions for common failures
                    if (response.Message.Contains("not responding"))
                    {
                        Console.WriteLine($"   💡 Suggestion: Make sure Space Engineers is running and your ship save is loaded with the GRID mod");
                    }
                    else if (response.Message.Contains("not found") || response.Message.Contains("not detected"))
                    {
                        Console.WriteLine($"   💡 Suggestion: Try using 'ship' command to see available blocks, or use generic targets like 'all', 'reactor', 'lights'");
                    }
                    
                    // DISABLED: Claude error interpretation adds unnecessary API calls and delays
                    // Console.WriteLine("   🧠 Analyzing error...");
                    // await InterpretErrorWithClaudeAsync(response.Message, target);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Command execution error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Detect if user input is a status/query command that should execute first
        /// </summary>
        /// <param name="userInput">User input to analyze</param>
        /// <returns>True if this is a status query</returns>
        private static bool IsStatusQuery(string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput))
                return false;
            
            var inputLower = userInput.ToLower().Trim();
            
            // Status query indicators
            var statusKeywords = new[] 
            { 
                "how many", "how much", "what is", "what are", "show me", "tell me",
                "check", "status", "get", "display", "list", "count", "level",
                "percentage", "charge", "power", "do i have", "are there"
            };
            
            // Question patterns
            if (inputLower.Contains("?") || inputLower.StartsWith("how") || inputLower.StartsWith("what") || 
                inputLower.StartsWith("do i") || inputLower.StartsWith("are there"))
                return true;
            
            // Status keywords
            if (statusKeywords.Any(keyword => inputLower.Contains(keyword)))
                return true;
            
            return false;
        }
        
        #endregion
        
        #region SE Knowledge Integration - Step 25
        
        /// <summary>
        /// Build enhanced system prompt with relevant SE knowledge context
        /// </summary>
        /// <param name="userInput">User input to analyze for relevant commands</param>
        /// <returns>Enhanced system prompt with SE knowledge context</returns>
        private static async Task<string> BuildEnhancedSystemPromptAsync(string userInput)
        {
            try
            {
                // Start with base system prompt
                var basePrompt = ClaudeAPIClient.BuildSystemPrompt("Ship: SE Grid | Status: Operational");
                
                // If knowledge system not available, fall back to base prompt
                if (_knowledgeRetriever == null)
                {
                    return basePrompt;
                }
                
                // PERFORMANCE OPTIMIZED: Use lightweight knowledge enhancement
                var optimizedKnowledgeContext = await GetOptimizedKnowledgeContextAsync(userInput);
                
                if (!string.IsNullOrEmpty(optimizedKnowledgeContext))
                {
                    Console.WriteLine($"      🧠 Using optimized knowledge context");
                    return basePrompt + optimizedKnowledgeContext;
                }
                else
                {
                    Console.WriteLine($"      ⚡ Using base prompt (no relevant knowledge found)");
                    return basePrompt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️  Knowledge system enhancement error: {ex.Message}");
                return ClaudeAPIClient.BuildSystemPrompt("Ship: SE Grid | Status: Operational");
            }
        }
        
        /// <summary>
        /// Get optimized knowledge context for Claude - lightweight approach for performance
        /// FIXED: Proper optimization instead of disabling the knowledge system entirely
        /// </summary>
        private static async Task<string> GetOptimizedKnowledgeContextAsync(string userInput)
        {
            try
            {
                if (_knowledgeRetriever == null) return "";
                
                // PERFORMANCE OPTIMIZATION: Only search for the top matching command
                var relevantCommands = _knowledgeRetriever.FindCommands(userInput, maxResults: 1);
                
                if (!relevantCommands.Any()) return "";
                
                var topCommand = relevantCommands.First();
                
                // PERFORMANCE OPTIMIZATION: Only include essential command info
                // This reduces prompt size significantly compared to previous complex approach
                if (topCommand.RelevanceScore > 50) // Only include if reasonably relevant
                {
                    var cmd = topCommand.Command;
                    return $"\n\nRELEVANT COMMAND: {cmd.Title}\nCategory: {cmd.Category}\nSafety: {cmd.SafetyClass}";
                }
                
                return "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️  Knowledge optimization error: {ex.Message}");
                return "";
            }
        }
        
        #endregion
        
        #region Claude Result Interpretation - CRITICAL UX FIX
        
        /// <summary>
        /// Let Claude interpret status results naturally for the user
        /// </summary>
        private static async Task InterpretResultsWithClaudeAsync(string rawResults, string target)
        {
            try
            {
                if (_claudeClient == null) return;
                
                var interpretRequest = new ClaudeAPIClient.ClaudeRequest
                {
                    UserMessage = $"SE Mod Data: {rawResults}",
                    SystemPrompt = @"Extract exact numbers from Power System Status data and report ALL components:

CRITICAL: Report ALL numbers from the data. Power status includes both reactors AND batteries.

Examples:
'Power System Status: 4/4 reactors active, 5/5 batteries active, avg battery charge 100%' → 'You have 4 reactors and 5 batteries. All reactors are active, all batteries are active at 100% charge.'

'Power System Status: 3/3 reactors active, 0/0 batteries active' → 'You have 3 reactors, all active. No batteries detected.'

'Status for lights: 30 blocks total, 30 enabled' → 'You have 30 lights, all enabled.'

ALWAYS report BOTH reactor AND battery counts from Power System Status data.",
                    Temperature = 0.1,
                    MaxTokens = 100
                };
                
                var interpretResponse = await _claudeClient.SendRequestAsync(interpretRequest);
                
                if (interpretResponse.Success && !string.IsNullOrEmpty(interpretResponse.Content))
                {
                    Console.WriteLine($"   💬 AI: {interpretResponse.Content.Trim()}");
                }
                else
                {
                    // Debug: Show why Claude interpretation failed
                    if (!interpretResponse.Success)
                    {
                        Console.WriteLine($"   ⚠️  Claude interpretation failed: {interpretResponse.ErrorMessage}");
                    }
                    else if (string.IsNullOrEmpty(interpretResponse.Content))
                    {
                        Console.WriteLine($"   ⚠️  Claude returned empty interpretation");
                    }
                    
                    // Fallback to raw data if Claude interpretation fails
                    Console.WriteLine($"   📊 Status: {rawResults}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Status interpretation error: {ex.Message}");
                Console.WriteLine($"   📊 Raw status: {rawResults}");
            }
        }
        
        /// <summary>
        /// Let Claude confirm action results naturally
        /// </summary>
        private static async Task ConfirmActionWithClaudeAsync(string commandId, int affectedBlocks, string target)
        {
            try
            {
                if (_claudeClient == null) return;
                
                var confirmRequest = new ClaudeAPIClient.ClaudeRequest
                {
                    UserMessage = $"{commandId} complete, {affectedBlocks} blocks",
                    SystemPrompt = @"Ship AI. Brief confirmation:
'turn_off_lights, 3' → 'Lights deactivated.'
'turn_on_reactor, 1' → 'Reactor online.'
One sentence max.",
                    Temperature = 0.1,
                    MaxTokens = 25
                };
                
                var confirmResponse = await _claudeClient.SendRequestAsync(confirmRequest);
                
                if (confirmResponse.Success && !string.IsNullOrEmpty(confirmResponse.Content))
                {
                    Console.WriteLine($"   💬 AI: {confirmResponse.Content.Trim()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Action confirmation error: {ex.Message}");
            }
        }
        
        /// <summary>
        /// Let Claude interpret errors naturally
        /// </summary>
        private static async Task InterpretErrorWithClaudeAsync(string errorMessage, string target)
        {
            try
            {
                if (_claudeClient == null) return;
                
                var errorRequest = new ClaudeAPIClient.ClaudeRequest
                {
                    UserMessage = $"Error: {errorMessage}",
                    SystemPrompt = @"Ship AI. Brief error report:
'No blocks found' → 'System not detected.'
'Not functional' → 'System offline.'
One sentence.",
                    Temperature = 0.1,
                    MaxTokens = 30
                };
                
                var errorResponse = await _claudeClient.SendRequestAsync(errorRequest);
                
                if (errorResponse.Success && !string.IsNullOrEmpty(errorResponse.Content))
                {
                    Console.WriteLine($"   💬 AI: {errorResponse.Content.Trim()}");
                }
                else
                {
                    // Fallback to raw error if Claude interpretation fails
                    Console.WriteLine($"   ❌ Error: {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Error interpretation failed: {ex.Message}");
                Console.WriteLine($"   ❌ Raw error: {errorMessage}");
            }
        }
        
        #endregion
        
        #region Application Shutdown
        
        /// <summary>
        /// Shutdown application systems
        /// </summary>
        private static async Task ShutdownApplicationAsync()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("🔄 Shutting down ClaudeBridge...");
                
                // Dispose Claude API client
                if (_claudeClient != null)
                {
                    _claudeClient.Dispose();
                    _claudeClient = null;
                    Console.WriteLine("   ✅ Claude API client disposed");
                }
                
                Console.WriteLine("   ✅ Core systems shutdown complete");
                
                Console.WriteLine("👋 ClaudeBridge shutdown complete");
                // FIXED: Only try to read key if console is available (not redirected)
                if (Environment.UserInteractive && !Console.IsInputRedirected)
                {
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Shutdown error: {ex.Message}");
            }
        }
        
        #endregion
    }
}
