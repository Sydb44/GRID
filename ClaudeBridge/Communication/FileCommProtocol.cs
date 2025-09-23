using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClaudeBridge.Communication
{
    /// <summary>
    /// ClaudeBridge File Communication Protocol
    /// Handles file-based communication with GRID SE mod using JSON message exchange
    /// </summary>
    public static class FileCommProtocol
    {
        #region Configuration
        
        private const string COMMUNICATION_DIRECTORY = @"C:\Users\{0}\AppData\Roaming\SpaceEngineers\Storage";
        private const string COMMAND_FILE = "GRID_command.json";
        private const string RESPONSE_FILE = "GRID_response.json";
        private const int RESPONSE_TIMEOUT_MS = 5000; // 5 seconds
        private const int POLL_INTERVAL_MS = 100; // 100ms polling
        
        #endregion
        
        #region Communication Data Structures
        
        /// <summary>
        /// Command sent to SE mod
        /// </summary>
        public class CommandMessage
        {
            public string RequestId { get; set; } = Guid.NewGuid().ToString();
            public string CommandId { get; set; } = "";
            public string Target { get; set; } = "";
            public string Category { get; set; } = "";
            public object Parameters { get; set; } = new { };
            public string SpatialContext { get; set; } = "";
            public DateTime Timestamp { get; set; } = DateTime.UtcNow;
            public string Source { get; set; } = "ClaudeBridge";
        }
        
        /// <summary>
        /// Response from SE mod
        /// </summary>
        public class ResponseMessage
        {
            public string RequestId { get; set; } = "";
            public bool Success { get; set; } = false;
            public string Message { get; set; } = "";
            public int AffectedBlocks { get; set; } = 0;
            public double ExecutionTimeMs { get; set; } = 0;
            public DateTime Timestamp { get; set; } = DateTime.UtcNow;
            public string ErrorDetails { get; set; } = "";
        }
        
        #endregion
        
        #region Private Fields
        
        private static string _communicationPath = "";
        private static bool _isInitialized = false;
        
        #endregion
        
        #region Initialization
        
        /// <summary>
        /// Initialize file communication protocol
        /// </summary>
        public static bool Initialize()
        {
            try
            {
                // Get current user for path
                var userName = Environment.UserName;
                _communicationPath = string.Format(COMMUNICATION_DIRECTORY, userName);
                
                // Create communication directory if it doesn't exist
                if (!Directory.Exists(_communicationPath))
                {
                    Directory.CreateDirectory(_communicationPath);
                    Console.WriteLine($"✅ Created communication directory: {_communicationPath}");
                }
                
                // Clean up any existing files
                CleanupCommunicationFiles();
                
                _isInitialized = true;
                
                Console.WriteLine("✅ File communication protocol initialized");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ File communication initialization failed: {ex.Message}");
                return false;
            }
        }
        
        /// <summary>
        /// Clean up communication files
        /// </summary>
        private static void CleanupCommunicationFiles()
        {
            try
            {
                var commandPath = Path.Combine(_communicationPath, COMMAND_FILE);
                var responsePath = Path.Combine(_communicationPath, RESPONSE_FILE);
                
                if (File.Exists(commandPath))
                {
                    File.Delete(commandPath);
                }
                
                if (File.Exists(responsePath))
                {
                    File.Delete(responsePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️  Warning: Could not clean communication files: {ex.Message}");
            }
        }
        
        #endregion
        
        #region Command Sending
        
        /// <summary>
        /// Send command to SE mod and wait for response
        /// </summary>
        public static async Task<ResponseMessage> SendCommandAsync(string commandId, string target, string category = "")
        {
            if (!_isInitialized)
            {
                Initialize();
            }
            
            try
            {
                // Create command message
                var command = new CommandMessage
                {
                    CommandId = commandId,
                    Target = target,
                    Category = category
                };
                
                Console.WriteLine($"📤 Sending command: {commandId} → {target}");
                
                // Write command to file
                var commandPath = Path.Combine(_communicationPath, COMMAND_FILE);
                var commandJson = JsonConvert.SerializeObject(command, Formatting.Indented);
                
                await File.WriteAllTextAsync(commandPath, commandJson);
                Console.WriteLine($"   ✅ Command written to {commandPath}");
                
                // Wait for response
                var response = await WaitForResponseAsync(command.RequestId);
                
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Command sending failed: {ex.Message}");
                return new ResponseMessage
                {
                    Success = false,
                    Message = $"Communication error: {ex.Message}",
                    ErrorDetails = ex.ToString()
                };
            }
        }
        
        /// <summary>
        /// Wait for response from SE mod
        /// </summary>
        private static async Task<ResponseMessage> WaitForResponseAsync(string requestId)
        {
            try
            {
                var responsePath = Path.Combine(_communicationPath, RESPONSE_FILE);
                var startTime = DateTime.UtcNow;
                var timeout = TimeSpan.FromMilliseconds(RESPONSE_TIMEOUT_MS);
                
                Console.WriteLine($"   ⏳ Waiting for response (timeout: {RESPONSE_TIMEOUT_MS}ms)...");
                
                while ((DateTime.UtcNow - startTime) < timeout)
                {
                    if (File.Exists(responsePath))
                    {
                        try
                        {
                            var responseJson = await File.ReadAllTextAsync(responsePath);
                            var response = JsonConvert.DeserializeObject<ResponseMessage>(responseJson);
                            
                            if (response != null && response.RequestId == requestId)
                            {
                                Console.WriteLine($"   ✅ Response received in {(DateTime.UtcNow - startTime).TotalMilliseconds:F0}ms");
                                
                                // Clean up response file
                                File.Delete(responsePath);
                                
                                return response;
                            }
                        }
                        catch (Exception readEx)
                        {
                            Console.WriteLine($"   ⚠️  Response read error: {readEx.Message}");
                        }
                    }
                    
                    await Task.Delay(POLL_INTERVAL_MS);
                }
                
                Console.WriteLine($"   ⏰ Timeout waiting for response after {RESPONSE_TIMEOUT_MS}ms");
                return new ResponseMessage
                {
                    RequestId = requestId,
                    Success = false,
                    Message = "SE mod not responding - Please start Space Engineers and load your ship save with the GRID mod enabled",
                    ErrorDetails = $"No response received within {RESPONSE_TIMEOUT_MS}ms. Check that Space Engineers is running and the GRID mod is loaded."
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"   ❌ Response waiting error: {ex.Message}");
                return new ResponseMessage
                {
                    RequestId = requestId,
                    Success = false,
                    Message = $"Response waiting error: {ex.Message}",
                    ErrorDetails = ex.ToString()
                };
            }
        }
        
        #endregion
        
        #region Testing and Status
        
        /// <summary>
        /// Test file communication with SE mod
        /// </summary>
        public static async Task<bool> TestCommunicationAsync()
        {
            try
            {
                Console.WriteLine("🧪 Testing file communication with SE mod...");
                
                // Send test command
                var response = await SendCommandAsync("turn_on_reactor", "test_reactor", "power");
                
                if (response.Success)
                {
                    Console.WriteLine($"✅ Communication test successful: {response.Message}");
                    return true;
                }
                else
                {
                    Console.WriteLine($"❌ Communication test failed: {response.Message}");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Communication test error: {ex.Message}");
                return false;
            }
        }
        
        /// <summary>
        /// Get communication status
        /// </summary>
        public static string GetCommunicationStatus()
        {
            if (!_isInitialized)
            {
                return "File communication not initialized";
            }
            
            var commandPath = Path.Combine(_communicationPath, COMMAND_FILE);
            var responsePath = Path.Combine(_communicationPath, RESPONSE_FILE);
            
            var commandExists = File.Exists(commandPath);
            var responseExists = File.Exists(responsePath);
            
            return $"FileComm: Path={_communicationPath}, Command={commandExists}, Response={responseExists}";
        }
        
        #endregion
    }
}
