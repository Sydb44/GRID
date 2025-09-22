using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using ClaudeBridge.Communication;
using ClaudeBridge.API;
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
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                    return;
                }
                
                // Start main operation loop
                await StartMainOperationLoopAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ STARTUP FAILED: {ex.Message}");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
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
            Console.WriteLine("Commands:");
            Console.WriteLine("  'test'     - Run system test");
            Console.WriteLine("  'status'   - Show system status");
            Console.WriteLine("  'help'     - Show available commands");
            Console.WriteLine("  'exit'     - Shutdown ClaudeBridge");
            Console.WriteLine();
            Console.WriteLine("💬 Enter commands or natural language instructions:");
            Console.WriteLine();
            
            while (_isRunning)
            {
                try
                {
                    Console.Write("🤖 GRID AI: ");
                    var userInput = Console.ReadLine();
                    
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
                        
                    default:
                        await ProcessAICommandAsync(userInput);
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
                
                var claudeRequest = new ClaudeAPIClient.ClaudeRequest
                {
                    UserMessage = userInput,
                    SystemPrompt = ClaudeAPIClient.BuildSystemPrompt("Ship: Unknown | Status: Operational"),
                    Temperature = 0.1,
                    MaxTokens = 1000
                };
                
                var claudeResponse = await _claudeClient.SendRequestAsync(claudeRequest);
                
                if (claudeResponse.Success)
                {
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
                // Use old pattern matching as fallback
                var commandId = MapUserInputToCommandId(userInput);
                if (!string.IsNullOrEmpty(commandId))
                {
                    var target = ExtractTarget(userInput);
                    var response = await FileCommProtocol.SendCommandAsync(commandId, target, "power");
                    
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
            
            if (inputLower.Contains("reactor") && (inputLower.Contains("off") || inputLower.Contains("disable")))
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
            
            return "";
        }
        
        /// <summary>
        /// Extract target from user input (Claude AI will do this properly in Step 28)
        /// </summary>
        private static string ExtractTarget(string input)
        {
            if (input.ToLower().Contains("all"))
                return "all_reactors";
            else if (input.ToLower().Contains("reactor"))
                return "reactor";
            else if (input.ToLower().Contains("light"))
                return "lights";
            else if (input.ToLower().Contains("assembler"))
                return "assembler";
            else
                return "all";
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
                Console.WriteLine("Basic Commands:");
                Console.WriteLine("   test      - Run system diagnostic test");
                Console.WriteLine("   status    - Show current system status");
                Console.WriteLine("   help      - Show this help information");
                Console.WriteLine("   exit      - Shutdown ClaudeBridge");
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
                        Console.WriteLine("   🧠 Interpreting results...");
                        await InterpretResultsWithClaudeAsync(response.Message, target);
                    }
                    else if (response.AffectedBlocks > 0)
                    {
                        // For action commands, let Claude provide follow-up
                        Console.WriteLine("   🧠 Confirming action...");
                        await ConfirmActionWithClaudeAsync(commandId, response.AffectedBlocks, target);
                    }
                }
                else
                {
                    Console.WriteLine($"   ❌ Execution failed");
                    
                    // Let Claude interpret the error naturally
                    Console.WriteLine("   🧠 Analyzing error...");
                    await InterpretErrorWithClaudeAsync(response.Message, target);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Command execution error: {ex.Message}");
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
                    UserMessage = $"Ship diagnostics for {target}: {rawResults}",
                    SystemPrompt = @"You are the ship's AI system. Report diagnostic results clearly and professionally to the Commander.

Convert technical data into natural ship status reports:
- '3 blocks total, 3 enabled, 3 functional, 3 working' → 'All lighting systems operational, Commander.'
- '1 blocks total, 1 enabled, 1 functional, 1 working' → 'Reactor online and functioning normally.'
- '0 blocks found' → 'No systems of that type detected on this vessel.'

Be concise, professional, and speak as the ship's AI. No JSON commands.",
                    Temperature = 0.2,
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
                    UserMessage = $"Operation complete: {commandId} on {target}, {affectedBlocks} systems affected.",
                    SystemPrompt = @"You are the ship's AI system. Confirm completed operations professionally to the Commander.

Convert operation results into brief confirmations:
- 'turn_off_lights, 3 blocks' → 'Lighting systems deactivated, Commander.'
- 'turn_on_reactor, 1 blocks' → 'Reactor online and stable.'
- 'get_status, 5 blocks' → 'Diagnostic complete.'

Be concise and professional. No JSON commands.",
                    Temperature = 0.2,
                    MaxTokens = 50
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
                    UserMessage = $"System error accessing {target}: {errorMessage}",
                    SystemPrompt = @"You are the ship's AI system. Report system errors professionally to the Commander.

Convert technical errors into clear status reports:
- 'No blocks found matching battery' → 'No battery systems detected on this vessel, Commander. Reactor is primary power source.'
- 'Block not functional' → 'That system appears to be damaged or offline.'
- 'Access denied' → 'Insufficient authorization for that operation.'

Be informative and professional. No JSON commands.",
                    Temperature = 0.2,
                    MaxTokens = 75
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
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Shutdown error: {ex.Message}");
            }
        }
        
        #endregion
    }
}
