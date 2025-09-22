using Sandbox.ModAPI;
using System;
using System.Text;
using VRage.Utils;
using GRID.Foundation;
using GRID.CommandProcessing;

namespace GRID.Communication
{
    /// <summary>
    /// GRID Bridge File Communication
    /// Handles file-based communication with ClaudeBridge using SE ModAPI file I/O
    /// </summary>
    public static class BridgeFileComm
    {
        #region Configuration
        
        private const string COMMAND_FILE = "GRID_command.json";
        private const string RESPONSE_FILE = "GRID_response.json";
        private const int CHECK_INTERVAL_TICKS = 60; // 1 second at 60 FPS
        
        #endregion
        
        #region Communication Data Structures
        
        /// <summary>
        /// Simple command structure for JSON parsing
        /// </summary>
        public struct SimpleCommand
        {
            public string RequestId;
            public string CommandId;
            public string Target;
            public string Category;
            public string Source;
            public string Timestamp;
        }
        
        /// <summary>
        /// Simple response structure
        /// </summary>
        public struct SimpleResponse
        {
            public string RequestId;
            public bool Success;
            public string Message;
            public int AffectedBlocks;
            public double ExecutionTimeMs;
            public string Timestamp;
            public string ErrorDetails;
        }
        
        #endregion
        
        #region Private Fields
        
        private static bool _isInitialized = false;
        private static int _lastCheckTick = 0;
        private static int _commandsProcessed = 0;
        private static int _responsesWritten = 0;
        
        #endregion
        
        #region Initialization
        
        /// <summary>
        /// Initialize bridge file communication
        /// </summary>
        public static bool Initialize()
        {
            try
            {
                if (_isInitialized) return true;
                
                _lastCheckTick = 0;
                _commandsProcessed = 0;
                _responsesWritten = 0;
                
                _isInitialized = true;
                
                MyLog.Default.WriteLine("GRID BridgeFileComm: File communication with ClaudeBridge initialized");
                MyLog.Default.WriteLine($"GRID BridgeFileComm: Monitoring files: {COMMAND_FILE}, {RESPONSE_FILE}");
                
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportCritical("BridgeFileComm", "File communication initialization failed", ex);
                return false;
            }
        }
        
        #endregion
        
        #region Update Processing
        
        /// <summary>
        /// Update file communication - check for new commands
        /// </summary>
        public static void Update(int currentTick)
        {
            if (!_isInitialized) return;
            
            try
            {
                // Check for commands periodically
                if (currentTick - _lastCheckTick >= CHECK_INTERVAL_TICKS)
                {
                    _lastCheckTick = currentTick;
                    
                    using (PerformanceMonitor.TrackComponent("BridgeFileComm.Update"))
                    {
                        CheckForNewCommands();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("BridgeFileComm", "File communication update error", ex, ErrorHandler.ErrorSeverity.Medium);
            }
        }
        
        /// <summary>
        /// Check for new commands from ClaudeBridge
        /// </summary>
        private static void CheckForNewCommands()
        {
            try
            {
                // Debug: Always log what we're checking
                MyLog.Default.WriteLine($"GRID BridgeFileComm: Checking for {COMMAND_FILE}...");
                
                // Check if command file exists
                var fileExists = MyAPIGateway.Utilities.FileExistsInGlobalStorage(COMMAND_FILE);
                MyLog.Default.WriteLine($"GRID BridgeFileComm: File exists: {fileExists}");
                
                if (fileExists)
                {
                    MyLog.Default.WriteLine($"GRID BridgeFileComm: Found command file, reading...");
                    
                    // Read command file
                    var reader = MyAPIGateway.Utilities.ReadFileInGlobalStorage(COMMAND_FILE);
                    if (reader != null)
                    {
                        var commandJson = reader.ReadToEnd();
                        reader.Close();
                        
                        MyLog.Default.WriteLine($"GRID BridgeFileComm: Read {commandJson.Length} characters");
                        
                        if (!string.IsNullOrEmpty(commandJson))
                        {
                            ProcessCommandFromBridge(commandJson);
                            
                            // Delete command file after processing
                            try
                            {
                                MyAPIGateway.Utilities.DeleteFileInGlobalStorage(COMMAND_FILE);
                                MyLog.Default.WriteLine($"GRID BridgeFileComm: Command file deleted");
                            }
                            catch (Exception deleteEx)
                            {
                                MyLog.Default.WriteLine($"GRID BridgeFileComm: Warning - could not delete command file: {deleteEx.Message}");
                            }
                        }
                    }
                    else
                    {
                        MyLog.Default.WriteLine($"GRID BridgeFileComm: Could not read command file");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("BridgeFileComm", "Command checking error", ex, ErrorHandler.ErrorSeverity.Medium);
            }
        }
        
        #endregion
        
        #region Command Processing
        
        /// <summary>
        /// Process command received from ClaudeBridge
        /// </summary>
        private static void ProcessCommandFromBridge(string commandJson)
        {
            try
            {
                MyLog.Default.WriteLine($"GRID BridgeFileComm: Received command from ClaudeBridge");
                MyLog.Default.WriteLine($"GRID BridgeFileComm: Command JSON: {commandJson}");
                
                // Parse JSON command (simple parsing for now)
                var command = ParseSimpleCommand(commandJson);
                if (string.IsNullOrEmpty(command.CommandId))
                {
                    SendErrorResponse("", "Invalid command format", commandJson);
                    return;
                }
                
                // Convert to structured command
                var structuredCommand = new StructuredCommand
                {
                    CommandId = command.CommandId,
                    Target = command.Target,
                    Category = command.Category,
                    Parameters = new System.Collections.Generic.Dictionary<string, object>(),
                    SpatialContext = "",
                    Source = command.Source,
                    Timestamp = DateTime.UtcNow
                };
                
                // Process with CommandExecutionEngine
                var result = CommandExecutionEngine.ExecuteStructuredCommand(structuredCommand);
                
                // Send response back to ClaudeBridge
                SendResponse(command.RequestId, result);
                
                _commandsProcessed++;
                
                MyLog.Default.WriteLine($"GRID BridgeFileComm: Command processed - {result.Message}");
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("BridgeFileComm", "Command processing error", ex, ErrorHandler.ErrorSeverity.Medium);
                SendErrorResponse("", "Command processing error", ex.Message);
            }
        }
        
        /// <summary>
        /// Parse simple JSON command (basic parsing without external dependencies)
        /// </summary>
        private static SimpleCommand ParseSimpleCommand(string json)
        {
            var command = new SimpleCommand();
            
            try
            {
                // Simple JSON parsing - look for key patterns
                if (json.Contains("\"RequestId\""))
                {
                    command.RequestId = ExtractJsonValue(json, "RequestId");
                }
                
                if (json.Contains("\"CommandId\""))
                {
                    command.CommandId = ExtractJsonValue(json, "CommandId");
                }
                
                if (json.Contains("\"Target\""))
                {
                    command.Target = ExtractJsonValue(json, "Target");
                }
                
                if (json.Contains("\"Category\""))
                {
                    command.Category = ExtractJsonValue(json, "Category");
                }
                
                command.Source = "ClaudeBridge";
                command.Timestamp = DateTime.UtcNow.ToString();
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("BridgeFileComm", "Command parsing error", ex, ErrorHandler.ErrorSeverity.Low);
            }
            
            return command;
        }
        
        /// <summary>
        /// Extract JSON value (simple implementation)
        /// </summary>
        private static string ExtractJsonValue(string json, string key)
        {
            try
            {
                var pattern = $"\"{key}\":\\s*\"([^\"]+)\"";
                var startIndex = json.IndexOf($"\"{key}\":");
                if (startIndex == -1) return "";
                
                var valueStart = json.IndexOf("\"", startIndex + key.Length + 3) + 1;
                var valueEnd = json.IndexOf("\"", valueStart);
                
                if (valueStart > 0 && valueEnd > valueStart)
                {
                    return json.Substring(valueStart, valueEnd - valueStart);
                }
            }
            catch
            {
                // Ignore parsing errors
            }
            
            return "";
        }
        
        #endregion
        
        #region Response Sending
        
        /// <summary>
        /// Send response to ClaudeBridge
        /// </summary>
        private static void SendResponse(string requestId, CommandProcessingResult result)
        {
            try
            {
                var response = new SimpleResponse
                {
                    RequestId = requestId,
                    Success = result.Success,
                    Message = result.Message,
                    AffectedBlocks = result.AffectedBlocks,
                    ExecutionTimeMs = result.ProcessingDurationMs,
                    Timestamp = DateTime.UtcNow.ToString(),
                    ErrorDetails = result.ErrorDetails
                };
                
                // Convert to JSON (simple formatting)
                var responseJson = $@"{{
    ""RequestId"": ""{response.RequestId}"",
    ""Success"": {response.Success.ToString().ToLower()},
    ""Message"": ""{response.Message}"",
    ""AffectedBlocks"": {response.AffectedBlocks},
    ""ExecutionTimeMs"": {response.ExecutionTimeMs:F1},
    ""Timestamp"": ""{response.Timestamp}"",
    ""ErrorDetails"": ""{response.ErrorDetails}""
}}";
                
                // Write response file
                var writer = MyAPIGateway.Utilities.WriteFileInGlobalStorage(RESPONSE_FILE);
                writer.Write(responseJson);
                writer.Close();
                
                _responsesWritten++;
                
                MyLog.Default.WriteLine($"GRID BridgeFileComm: Response sent to ClaudeBridge");
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("BridgeFileComm", "Response sending error", ex, ErrorHandler.ErrorSeverity.Medium);
            }
        }
        
        /// <summary>
        /// Send error response
        /// </summary>
        private static void SendErrorResponse(string requestId, string errorMessage, string details)
        {
            try
            {
                var result = new CommandProcessingResult
                {
                    Success = false,
                    Message = errorMessage,
                    CommandId = "error",
                    Target = "",
                    ProcessingTime = DateTime.UtcNow,
                    ProcessingDurationMs = 0,
                    AffectedBlocks = 0,
                    ErrorDetails = details
                };
                
                SendResponse(requestId, result);
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("BridgeFileComm", "Error response sending failed", ex, ErrorHandler.ErrorSeverity.Low);
            }
        }
        
        #endregion
        
        #region Public Interface
        
        /// <summary>
        /// Get communication statistics
        /// </summary>
        public static string GetCommunicationStatus()
        {
            if (!_isInitialized)
            {
                return "BridgeFileComm: Not initialized";
            }
            
            return $"BridgeFileComm: {_commandsProcessed} commands processed, {_responsesWritten} responses sent";
        }
        
        #endregion
    }
}
