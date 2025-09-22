using System;
using System.Configuration;
using System.Threading.Tasks;
using ClaudeBridge.Communication;

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
                
                // SE knowledge system will be added in Step 25
                // NLP processing will be added in Step 27
                // Claude API client will be added in Step 28
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
        /// Process AI command - basic implementation for testing
        /// </summary>
        private static async Task ProcessAICommandAsync(string userInput)
        {
            try
            {
                Console.WriteLine($"🧠 Processing: '{userInput}'");
                
                // Basic command mapping for testing (Claude AI will do this in Step 28)
                var commandId = MapUserInputToCommandId(userInput);
                if (string.IsNullOrEmpty(commandId))
                {
                    Console.WriteLine("   📝 Analysis: Command not recognized");
                    Console.WriteLine("   💡 Try: 'reactor off', 'lights on', 'assembler on'");
                    return;
                }
                
                // Extract target
                var target = ExtractTarget(userInput);
                
                Console.WriteLine($"   🔍 Mapped to command: {commandId} → {target}");
                Console.WriteLine($"   📤 Sending to SE mod...");
                
                // Send command to SE mod
                var response = await FileCommProtocol.SendCommandAsync(commandId, target, "power");
                
                if (response.Success)
                {
                    Console.WriteLine($"   ✅ Success: {response.Message}");
                    if (response.AffectedBlocks > 0)
                    {
                        Console.WriteLine($"   🎯 Affected {response.AffectedBlocks} block(s)");
                    }
                }
                else
                {
                    Console.WriteLine($"   ❌ Failed: {response.Message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ AI command processing error: {ex.Message}");
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
                
                // Test 4: SE mod communication
                Console.WriteLine("Test 4: SE Mod Communication");
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
                
                // Test 5: Future systems
                Console.WriteLine("Test 5: Future Systems");
                Console.WriteLine("   ⏳ SE Knowledge System: Will be added in Step 25");
                Console.WriteLine("   ⏳ NLP Processing: Will be added in Step 27");
                Console.WriteLine("   ⏳ Claude API Integration: Will be added in Step 28");
                
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
                Console.WriteLine($"   Claude API: {(_claudeApiKey != null ? "Configured" : "Not Configured")}");
                Console.WriteLine($"   Framework: .NET Framework 4.8");
                Console.WriteLine();
                Console.WriteLine("🔄 Implementation Progress:");
                Console.WriteLine("   ✅ Step 24: Foundation (ClaudeBridge console app)");
                Console.WriteLine("   ⏳ Step 25: Core Systems (SE knowledge loading)");
                Console.WriteLine("   ⏳ Step 26: Communication (file protocol)");
                Console.WriteLine("   ⏳ Step 27: NLP Processing (intent classification)");
                Console.WriteLine("   ⏳ Step 28: Claude API Integration (AI conversation)");
                Console.WriteLine();
                Console.WriteLine("🎯 Current Capability: Basic console interface ready for AI integration");
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
                Console.WriteLine("AI Commands (Future):");
                Console.WriteLine("   Any natural language will be processed by Claude AI");
                Console.WriteLine("   Examples: 'turn on the reactor', 'show me ship status'");
                Console.WriteLine();
                Console.WriteLine("Current Status: Step 24 (Foundation) - Console interface working");
                Console.WriteLine("Next: Step 25 (SE Knowledge), Step 26 (Communication), Step 27 (NLP), Step 28 (Claude AI)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Help display error: {ex.Message}");
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
                
                // Future cleanup will be added in later steps
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
