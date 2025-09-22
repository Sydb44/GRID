using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using VRage.Utils;
using GRID.Foundation;

namespace GRID.CommandProcessing
{
    /// <summary>
    /// GRID Command Processor - Structured Command Processing for Step 6
    /// Receives structured JSON commands from ClaudeBridge and processes them
    /// for execution by specialized controllers.
    /// </summary>
    public static class CommandProcessor
    {
        #region Basic Command Database
        
        private static readonly Dictionary<string, BasicCommandSpec> _basicCommands = new Dictionary<string, BasicCommandSpec>();
        private static readonly Dictionary<string, string> _triggerIndex = new Dictionary<string, string>();
        
        private static bool _isInitialized = false;
        
        #endregion
        
        #region Initialization
        
        /// <summary>
        /// Initialize command processor with basic commands
        /// </summary>
        public static void Initialize()
        {
            try
            {
                if (_isInitialized) return;
                
                // Clear previous data
                _basicCommands.Clear();
                _triggerIndex.Clear();
                
                // Register basic turn on/off commands for Step 6
                RegisterBasicCommands();
                
                _isInitialized = true;
                
                MyLog.Default.WriteLine("GRID CommandProcessor: Basic command processor initialized");
                MyLog.Default.WriteLine($"GRID CommandProcessor: {_basicCommands.Count} basic commands registered");
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportCritical("CommandProcessor", "Command processor initialization failed", ex);
            }
        }
        
        /// <summary>
        /// Register basic turn on/off commands
        /// </summary>
        private static void RegisterBasicCommands()
        {
            // Turn on commands
            RegisterCommand("turn_on_reactor", "turn on", "power", "Reactor", "Enabled", true, "Turn on reactor");
            RegisterCommand("turn_on_lights", "turn on", "lighting", "InteriorLight", "Enabled", true, "Turn on lights");
            RegisterCommand("turn_on_assembler", "turn on", "production", "Assembler", "Enabled", true, "Turn on assembler");
            RegisterCommand("turn_on_refinery", "turn on", "production", "Refinery", "Enabled", true, "Turn on refinery");
            RegisterCommand("turn_on_battery", "turn on", "power", "BatteryBlock", "Enabled", true, "Turn on battery");
            
            // Turn off commands  
            RegisterCommand("turn_off_reactor", "turn off", "power", "Reactor", "Enabled", false, "Turn off reactor");
            RegisterCommand("turn_off_lights", "turn off", "lighting", "InteriorLight", "Enabled", false, "Turn off lights");
            RegisterCommand("turn_off_assembler", "turn off", "production", "Assembler", "Enabled", false, "Turn off assembler");
            RegisterCommand("turn_off_refinery", "turn off", "production", "Refinery", "Enabled", false, "Turn off refinery");
            RegisterCommand("turn_off_battery", "turn off", "power", "BatteryBlock", "Enabled", false, "Turn off battery");
            
            // Enable/disable aliases
            RegisterTriggerAlias("enable", "turn on");
            RegisterTriggerAlias("disable", "turn off");
            RegisterTriggerAlias("activate", "turn on");
            RegisterTriggerAlias("deactivate", "turn off");
        }
        
        /// <summary>
        /// Register a basic command
        /// </summary>
        private static void RegisterCommand(string id, string trigger, string category, string targetType, 
            string seProperty, bool propertyValue, string description)
        {
            var command = new BasicCommandSpec
            {
                Id = id,
                Trigger = trigger,
                Category = category,
                TargetType = targetType,
                SeProperty = seProperty,
                PropertyValue = propertyValue,
                Description = description
            };
            
            _basicCommands[id] = command;
            
            // Add to trigger index
            if (!_triggerIndex.ContainsKey(trigger))
            {
                _triggerIndex[trigger] = id;
            }
        }
        
        /// <summary>
        /// Register trigger alias
        /// </summary>
        private static void RegisterTriggerAlias(string alias, string canonicalTrigger)
        {
            if (_triggerIndex.ContainsKey(canonicalTrigger))
            {
                _triggerIndex[alias] = _triggerIndex[canonicalTrigger];
            }
        }
        
        #endregion
        
        #region Structured Command Processing
        
        /// <summary>
        /// Process structured command from ClaudeBridge (Step 6 corrected requirement)
        /// </summary>
        public static CommandProcessingResult ProcessStructuredCommand(StructuredCommand command, long gridId = 0)
        {
            if (!_isInitialized)
            {
                Initialize();
            }
            
            var result = new CommandProcessingResult
            {
                ProcessingTime = DateTime.UtcNow,
                Success = false,
                Message = "Unknown error",
                CommandId = "",
                Target = "",
                AffectedBlocks = 0,
                ErrorDetails = ""
            };
            
            try
            {
                using (PerformanceMonitor.TrackComponent("CommandProcessor.ProcessStructuredCommand"))
                {
                    var startTime = DateTime.UtcNow;
                    
                    // Step 1: Validate structured command format
                    if (string.IsNullOrEmpty(command.CommandId))
                    {
                        result.Message = "Invalid command: CommandId is required";
                        result.ErrorDetails = "Structured command missing CommandId";
                        return result;
                    }
                    
                    // Step 2: Look up command specification
                    var commandSpec = LookupCommandById(command.CommandId);
                    if (commandSpec.Id == null)
                    {
                        result.Message = $"Unknown command ID: '{command.CommandId}'";
                        result.ErrorDetails = "Command ID not found in registered commands";
                        return result;
                    }
                    
                    // Step 3: Create successful result for execution
                    result.Success = true;
                    result.CommandId = command.CommandId;
                    result.Target = command.Target;
                    result.Message = $"Structured command '{command.CommandId}' ready for execution";
                    result.ProcessingDurationMs = (DateTime.UtcNow - startTime).TotalMilliseconds;
                    
                    return result;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandProcessor", "Command processing error", ex, ErrorHandler.ErrorSeverity.Medium);
                result.Message = $"Processing error: {ex.Message}";
                result.ErrorDetails = ex.ToString();
                return result;
            }
        }
        
        /// <summary>
        /// Look up command specification by ID
        /// </summary>
        private static BasicCommandSpec LookupCommandById(string commandId)
        {
            try
            {
                // Direct lookup by command ID
                if (_basicCommands.ContainsKey(commandId))
                {
                    return _basicCommands[commandId];
                }
                
                // Try pattern matching for similar command IDs
                foreach (var kvp in _basicCommands)
                {
                    if (kvp.Key.Contains(commandId) || commandId.Contains(kvp.Key))
                    {
                        return kvp.Value;
                    }
                }
                
                // Return empty if no match found
                return new BasicCommandSpec { Id = null };
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandProcessor", "Command lookup error", ex, ErrorHandler.ErrorSeverity.Low);
                return new BasicCommandSpec { Id = null };
            }
        }
        
        /// <summary>
        /// Create test structured command for Step 6 validation
        /// </summary>
        public static StructuredCommand CreateTestCommand(string commandId, string target)
        {
            return new StructuredCommand
            {
                CommandId = commandId,
                Target = target,
                Category = DetermineBasicCategory(target),
                Parameters = new Dictionary<string, object>(),
                SpatialContext = "",
                Source = "Testing",
                Timestamp = DateTime.UtcNow
            };
        }
        
        /// <summary>
        /// Determine basic category from target (helper method)
        /// </summary>
        private static string DetermineBasicCategory(string target)
        {
            if (target.Contains("reactor"))
                return "power";
            else if (target.Contains("light"))
                return "lighting";
            else if (target.Contains("assembler") || target.Contains("refinery"))
                return "production";
            else if (target.Contains("battery"))
                return "power";
            else
                return "unknown";
        }
        
        /// <summary>
        /// Get command IDs for testing
        /// </summary>
        public static string[] GetRegisteredCommandIds()
        {
            if (!_isInitialized)
            {
                Initialize();
            }
            
            var commandIds = new string[_basicCommands.Count];
            var index = 0;
            foreach (var kvp in _basicCommands)
            {
                commandIds[index] = kvp.Key;
                index++;
            }
            return commandIds;
        }
        
        #endregion
        
        #region Public Interface
        
        /// <summary>
        /// Get registered command count
        /// </summary>
        public static int GetRegisteredCommandCount()
        {
            return _isInitialized ? _basicCommands.Count : 0;
        }
        
        /// <summary>
        /// Get command processor status
        /// </summary>
        public static string GetProcessorStatus()
        {
            if (!_isInitialized)
            {
                return "CommandProcessor: Not initialized";
            }
            
            return $"CommandProcessor: {_basicCommands.Count} basic commands registered, {_triggerIndex.Count} triggers indexed";
        }
        
        /// <summary>
        /// Test structured command processing (for Step 6 validation)
        /// </summary>
        public static CommandProcessingResult TestStructuredCommand(string commandId, string target)
        {
            if (!_isInitialized)
            {
                Initialize();
            }
            
            var testCommand = CreateTestCommand(commandId, target);
            return ProcessStructuredCommand(testCommand);
        }
        
        #endregion
    }
}
