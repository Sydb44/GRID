using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using VRage.Game.ModAPI;
using VRage.Utils;
using GRID.Foundation;
using GRID.Controllers;
using GRID.SpatialIntelligence;
using GRID.Safety;

namespace GRID.CommandProcessing
{
    /// <summary>
    /// GRID Command Execution Engine - Basic Execution for Step 6
    /// Provides simple command execution using IMyFunctionalBlock.Enabled
    /// for basic "turn on/off" operations without complex controller routing.
    /// </summary>
    public static class CommandExecutionEngine
    {
        #region Private Fields and Constants
        
        private static bool _isInitialized = false;
        private static int _totalCommandsExecuted = 0;
        private static int _successfulCommands = 0;
        
        // Step 9: Constants for specialized controller parameters
        private const float DEFAULT_TIMER_DELAY = 1.0f; // 1 second default for automation
        
        // Step 7: Universal Controller for real block control
        private static UniversalController _universalController = null;
        
        // Step 9: Specialized Controllers for core systems
        private static PowerManagementController _powerController = null;
        private static LifeSupportController _lifeSupportController = null;
        private static AutomationController _automationController = null;
        
        #endregion
        
        #region Initialization
        
        /// <summary>
        /// Initialize command execution engine
        /// </summary>
        public static void Initialize()
        {
            try
            {
                if (_isInitialized) return;
                
                _totalCommandsExecuted = 0;
                _successfulCommands = 0;
                
                // Step 8: Initialize Safety Validation Engine FIRST
                if (!PlanValidationEngine.Initialize())
                {
                    ErrorHandler.ReportCritical("CommandExecutionEngine", "Safety validation engine initialization failed", null);
                    return;
                }
                
                // Step 7: Initialize Universal Controller for real block control
                _universalController = new UniversalController();
                if (!_universalController.Initialize())
                {
                    ErrorHandler.ReportCritical("CommandExecutionEngine", "Universal controller initialization failed", null);
                    return;
                }
                
                // Step 9: Initialize Core System Controllers
                _powerController = new PowerManagementController();
                if (!_powerController.Initialize())
                {
                    ErrorHandler.ReportCritical("CommandExecutionEngine", "Power management controller initialization failed", null);
                    return;
                }
                
                _lifeSupportController = new LifeSupportController();
                if (!_lifeSupportController.Initialize())
                {
                    ErrorHandler.ReportCritical("CommandExecutionEngine", "Life support controller initialization failed", null);
                    return;
                }
                
                _automationController = new AutomationController();
                if (!_automationController.Initialize())
                {
                    ErrorHandler.ReportCritical("CommandExecutionEngine", "Automation controller initialization failed", null);
                    return;
                }
                
                _isInitialized = true;
                
                MyLog.Default.WriteLine("GRID CommandExecutionEngine: Command execution engine initialized with safety validation and specialized controllers");
                MyLog.Default.WriteLine("GRID CommandExecutionEngine: Safety system active - life support and power protection enabled");
                MyLog.Default.WriteLine("GRID CommandExecutionEngine: Universal controller ready for 17 universal commands");
                MyLog.Default.WriteLine("GRID CommandExecutionEngine: Step 9 controllers initialized - Power, Life Support, Automation");
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportCritical("CommandExecutionEngine", "Execution engine initialization failed", ex);
            }
        }
        
        #endregion
        
        #region Basic Command Execution
        
        /// <summary>
        /// Execute structured command (Step 6 corrected requirement)
        /// </summary>
        public static CommandProcessingResult ExecuteStructuredCommand(StructuredCommand command, long gridId = 0)
        {
            if (!_isInitialized)
            {
                Initialize();
            }
            
            var result = new CommandProcessingResult
            {
                ProcessingTime = DateTime.UtcNow,
                Success = false,
                Message = "Execution failed",
                CommandId = command.CommandId,
                Target = command.Target,
                AffectedBlocks = 0,
                ErrorDetails = ""
            };
            
            try
            {
                using (PerformanceMonitor.TrackComponent("CommandExecutionEngine.ExecuteBasicCommand"))
                {
                    var startTime = DateTime.UtcNow;
                    _totalCommandsExecuted++;
                    
                    // Step 8: SAFETY VALIDATION - Check command before execution
                    var safetyResult = PlanValidationEngine.ValidateCommand(command);
                    
                    if (!safetyResult.IsAllowed)
                    {
                        // Command blocked by safety system
                        result.Success = false;
                        result.Message = $"BLOCKED: {safetyResult.BlockReason}";
                        result.ErrorDetails = safetyResult.SafeAlternative ?? "";
                        result.ProcessingDurationMs = (DateTime.UtcNow - startTime).TotalMilliseconds;
                        
                        MyLog.Default.WriteLine($"GRID CommandExecutionEngine: 🛡️ SAFETY BLOCK - {command.CommandId} → {safetyResult.BlockReason}");
                        if (!string.IsNullOrEmpty(safetyResult.SafeAlternative))
                        {
                            MyLog.Default.WriteLine($"GRID CommandExecutionEngine:    Alternative: {safetyResult.SafeAlternative}");
                        }
                        
                        return result;
                    }
                    
                    // Step 9: Route command to appropriate controller (specialized or universal)
                    var executionResult = ExecuteWithSpecializedControllers(command);
                    
                    result.Success = executionResult.Success;
                    result.Message = executionResult.Message;
                    result.AffectedBlocks = executionResult.BlockCount;
                    result.ProcessingDurationMs = (DateTime.UtcNow - startTime).TotalMilliseconds;
                    
                    if (result.Success)
                    {
                        _successfulCommands++;
                    }
                    
                    LogExecutionResult(result);
                    
                    return result;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandExecutionEngine", "Command execution error", ex, ErrorHandler.ErrorSeverity.Medium);
                result.Message = $"Execution error: {ex.Message}";
                result.ErrorDetails = ex.ToString();
                return result;
            }
        }
        
        /// <summary>
        /// Execute structured command using specialized controllers (Step 9) or universal controller (Step 7)
        /// </summary>
        private static BasicExecutionResult ExecuteWithSpecializedControllers(StructuredCommand command)
        {
            try
            {
                MyLog.Default.WriteLine($"GRID CommandExecutionEngine: Routing command '{command.CommandId}' to appropriate controller");
                
                // Step 9: Route to specialized controllers based on command category or ID
                if (IsPowerManagementCommand(command))
                {
                    return ExecuteWithPowerController(command);
                }
                else if (IsLifeSupportCommand(command))
                {
                    return ExecuteWithLifeSupportController(command);
                }
                else if (IsAutomationCommand(command))
                {
                    return ExecuteWithAutomationController(command);
                }
                else
                {
                    // Step 7: Fall back to Universal Controller for general commands
                    return ExecuteWithUniversalController(command);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandExecutionEngine", "Specialized controller routing failed", ex, ErrorHandler.ErrorSeverity.Medium);
                return new BasicExecutionResult
                {
                    Success = false,
                    Message = $"Command routing error: {ex.Message}",
                    BlockCount = 0
                };
            }
        }
        
        /// <summary>
        /// Execute structured command using Universal Controller (Step 7 - REAL block control)
        /// </summary>
        private static BasicExecutionResult ExecuteWithUniversalController(StructuredCommand command)
        {
            try
            {
                if (_universalController == null)
                {
                    return new BasicExecutionResult
                    {
                        Success = false,
                        Message = "Universal controller not available",
                        BlockCount = 0
                    };
                }
                
                MyLog.Default.WriteLine($"GRID CommandExecutionEngine: Executing REAL command '{command.CommandId}' via UniversalController");
                
                // Execute using REAL Universal Controller
                string controllerResult;
                var success = _universalController.ExecuteUniversalCommand(command.CommandId, command.Target, out controllerResult);
                
                // Extract block count from result message (simple parsing)
                var blockCount = ExtractBlockCountFromResult(controllerResult);
                
                return new BasicExecutionResult
                {
                    Success = success,
                    Message = controllerResult,
                    BlockCount = blockCount
                };
            }
            catch (Exception ex)
            {
                return new BasicExecutionResult
                {
                    Success = false,
                    Message = $"Simulation error: {ex.Message}",
                    BlockCount = 0
                };
            }
        }
        
        #endregion
        
        #region Step 9 - Specialized Controller Execution
        
        /// <summary>
        /// Execute command using Power Management Controller
        /// </summary>
        private static BasicExecutionResult ExecuteWithPowerController(StructuredCommand command)
        {
            try
            {
                if (_powerController == null)
                {
                    return new BasicExecutionResult
                    {
                        Success = false,
                        Message = "Power management controller not available",
                        BlockCount = 0
                    };
                }
                
                MyLog.Default.WriteLine($"GRID CommandExecutionEngine: Executing power command '{command.CommandId}' via PowerManagementController");
                
                string result;
                bool success = false;
                int blockCount = 0;
                
                // Route to appropriate power management method
                if (command.CommandId.Contains("battery_mode") || command.CommandId.Contains("charge_mode"))
                {
                    // Extract mode from command parameters or target
                    string mode = ExtractModeFromCommand(command, "auto");
                    success = _powerController.SetBatteryMode(command.Target, mode, out result);
                    blockCount = ExtractBlockCountFromResult(result);
                }
                else if (command.CommandId.Contains("reactor_efficiency"))
                {
                    // Extract efficiency from command parameters (default 100%)
                    float efficiency = ExtractEfficiencyFromCommand(command, 1.0f);
                    success = _powerController.SetReactorEfficiency(command.Target, efficiency, out result);
                    blockCount = ExtractBlockCountFromResult(result);
                }
                else if (command.CommandId.Contains("power_status") || (command.CommandId.Contains("get_status") && command.Category == "power"))
                {
                    success = _powerController.GetPowerStatus(command.Target, out result);
                    blockCount = 1; // Status commands don't affect blocks
                }
                else
                {
                    // Fall back to universal controller for basic power commands
                    return ExecuteWithUniversalController(command);
                }
                
                return new BasicExecutionResult
                {
                    Success = success,
                    Message = result,
                    BlockCount = blockCount
                };
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandExecutionEngine", "Power controller execution failed", ex, ErrorHandler.ErrorSeverity.Medium);
                return new BasicExecutionResult
                {
                    Success = false,
                    Message = $"Power controller error: {ex.Message}",
                    BlockCount = 0
                };
            }
        }
        
        /// <summary>
        /// Execute command using Life Support Controller
        /// </summary>
        private static BasicExecutionResult ExecuteWithLifeSupportController(StructuredCommand command)
        {
            try
            {
                if (_lifeSupportController == null)
                {
                    return new BasicExecutionResult
                    {
                        Success = false,
                        Message = "Life support controller not available",
                        BlockCount = 0
                    };
                }
                
                MyLog.Default.WriteLine($"GRID CommandExecutionEngine: Executing life support command '{command.CommandId}' via LifeSupportController");
                
                string result;
                bool success = false;
                int blockCount = 0;
                
                // Route to appropriate life support method
                if (command.CommandId.Contains("oxygen_generation") || command.CommandId.Contains("oxygen_on") || command.CommandId.Contains("oxygen_off"))
                {
                    bool enable = !command.CommandId.Contains("off");
                    success = _lifeSupportController.SetOxygenGeneration(command.Target, enable, out result);
                    blockCount = ExtractBlockCountFromResult(result);
                }
                else if (command.CommandId.Contains("air_vent") || command.CommandId.Contains("pressurize") || command.CommandId.Contains("depressurize"))
                {
                    string mode = command.CommandId.Contains("depressurize") ? "depressurize" : "pressurize";
                    success = _lifeSupportController.SetAirVentMode(command.Target, mode, out result);
                    blockCount = ExtractBlockCountFromResult(result);
                }
                else if (command.CommandId.Contains("life_support_status") || (command.CommandId.Contains("get_status") && command.Category == "life_support"))
                {
                    success = _lifeSupportController.GetLifeSupportStatus(command.Target, out result);
                    blockCount = 1; // Status commands don't affect blocks
                }
                else
                {
                    // Fall back to universal controller for basic life support commands
                    return ExecuteWithUniversalController(command);
                }
                
                return new BasicExecutionResult
                {
                    Success = success,
                    Message = result,
                    BlockCount = blockCount
                };
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandExecutionEngine", "Life support controller execution failed", ex, ErrorHandler.ErrorSeverity.Medium);
                return new BasicExecutionResult
                {
                    Success = false,
                    Message = $"Life support controller error: {ex.Message}",
                    BlockCount = 0
                };
            }
        }
        
        /// <summary>
        /// Execute command using Automation Controller
        /// </summary>
        private static BasicExecutionResult ExecuteWithAutomationController(StructuredCommand command)
        {
            try
            {
                if (_automationController == null)
                {
                    return new BasicExecutionResult
                    {
                        Success = false,
                        Message = "Automation controller not available",
                        BlockCount = 0
                    };
                }
                
                MyLog.Default.WriteLine($"GRID CommandExecutionEngine: Executing automation command '{command.CommandId}' via AutomationController");
                
                string result;
                bool success = false;
                int blockCount = 0;
                
                // Route to appropriate automation method
                if (command.CommandId.Contains("timer_delay") || command.CommandId.Contains("set_timer"))
                {
                    float delay = ExtractDelayFromCommand(command, DEFAULT_TIMER_DELAY);
                    success = _automationController.SetTimerDelay(command.Target, delay, out result);
                    blockCount = ExtractBlockCountFromResult(result);
                }
                else if (command.CommandId.Contains("trigger_timer") || command.CommandId.Contains("start_timer"))
                {
                    success = _automationController.TriggerTimers(command.Target, out result);
                    blockCount = ExtractBlockCountFromResult(result);
                }
                else if (command.CommandId.Contains("automation_status") || (command.CommandId.Contains("get_status") && command.Category == "automation"))
                {
                    success = _automationController.GetAutomationStatus(command.Target, out result);
                    blockCount = 1; // Status commands don't affect blocks
                }
                else
                {
                    // Fall back to universal controller for basic automation commands
                    return ExecuteWithUniversalController(command);
                }
                
                return new BasicExecutionResult
                {
                    Success = success,
                    Message = result,
                    BlockCount = blockCount
                };
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandExecutionEngine", "Automation controller execution failed", ex, ErrorHandler.ErrorSeverity.Medium);
                return new BasicExecutionResult
                {
                    Success = false,
                    Message = $"Automation controller error: {ex.Message}",
                    BlockCount = 0
                };
            }
        }
        
        /// <summary>
        /// Check if command should be handled by Power Management Controller
        /// </summary>
        private static bool IsPowerManagementCommand(StructuredCommand command)
        {
            string commandId = command.CommandId?.ToLower() ?? "";
            string category = command.Category?.ToLower() ?? "";
            
            // Power management specific commands
            if (commandId.Contains("battery_mode") || commandId.Contains("charge_mode") ||
                commandId.Contains("reactor_efficiency") || commandId.Contains("power_status"))
            {
                return true;
            }
            
            // Category-based routing for advanced power commands
            if (category == "power_management" || category == "power_control")
            {
                return true;
            }
            
            return false;
        }
        
        /// <summary>
        /// Check if command should be handled by Life Support Controller
        /// </summary>
        private static bool IsLifeSupportCommand(StructuredCommand command)
        {
            string commandId = command.CommandId?.ToLower() ?? "";
            string category = command.Category?.ToLower() ?? "";
            
            // Life support specific commands
            if (commandId.Contains("oxygen_generation") || commandId.Contains("air_vent") ||
                commandId.Contains("pressurize") || commandId.Contains("depressurize") ||
                commandId.Contains("life_support_status"))
            {
                return true;
            }
            
            // Category-based routing for life support commands
            if (category == "life_support" || category == "atmospheric")
            {
                return true;
            }
            
            return false;
        }
        
        /// <summary>
        /// Check if command should be handled by Automation Controller
        /// </summary>
        private static bool IsAutomationCommand(StructuredCommand command)
        {
            string commandId = command.CommandId?.ToLower() ?? "";
            string category = command.Category?.ToLower() ?? "";
            
            // Automation specific commands
            if (commandId.Contains("timer_delay") || commandId.Contains("trigger_timer") ||
                commandId.Contains("automation_sequence") || commandId.Contains("automation_status"))
            {
                return true;
            }
            
            // Category-based routing for automation commands
            if (category == "automation" || category == "timer")
            {
                return true;
            }
            
            return false;
        }
        
        /// <summary>
        /// Extract mode parameter from command (for battery modes, etc.)
        /// </summary>
        private static string ExtractModeFromCommand(StructuredCommand command, string defaultMode)
        {
            try
            {
                // Check if mode is in the command ID itself
                string commandId = command.CommandId?.ToLower() ?? "";
                if (commandId.Contains("auto")) return "auto";
                if (commandId.Contains("recharge")) return "recharge";
                if (commandId.Contains("discharge")) return "discharge";
                
                // Check command parameters (future expansion)
                if (command.Parameters != null && command.Parameters.ContainsKey("mode"))
                {
                    return command.Parameters["mode"]?.ToString() ?? defaultMode;
                }
                
                return defaultMode;
            }
            catch
            {
                return defaultMode;
            }
        }
        
        /// <summary>
        /// Extract efficiency parameter from command
        /// </summary>
        private static float ExtractEfficiencyFromCommand(StructuredCommand command, float defaultEfficiency)
        {
            try
            {
                // Check command parameters (future expansion)
                if (command.Parameters != null && command.Parameters.ContainsKey("efficiency"))
                {
                    var efficiencyObj = command.Parameters["efficiency"];
                    if (efficiencyObj != null)
                    {
                        float efficiency;
                        if (float.TryParse(efficiencyObj.ToString(), out efficiency))
                        {
                            return Math.Max(0.1f, Math.Min(1.0f, efficiency));
                        }
                    }
                }
                
                return defaultEfficiency;
            }
            catch
            {
                return defaultEfficiency;
            }
        }
        
        /// <summary>
        /// Extract delay parameter from command
        /// </summary>
        private static float ExtractDelayFromCommand(StructuredCommand command, float defaultDelay)
        {
            try
            {
                // Check command parameters (future expansion)
                if (command.Parameters != null && command.Parameters.ContainsKey("delay"))
                {
                    var delayObj = command.Parameters["delay"];
                    if (delayObj != null)
                    {
                        float delay;
                        if (float.TryParse(delayObj.ToString(), out delay))
                        {
                            return Math.Max(0.1f, Math.Min(3600f, delay));
                        }
                    }
                }
                
                return defaultDelay;
            }
            catch
            {
                return defaultDelay;
            }
        }
        
        #endregion
        
        #region Legacy Methods (Step 6/7 compatibility)
        
        /// <summary>
        /// Simulate block lookup for testing
        /// </summary>
        private static int SimulateBlockLookup(string blockType, string target)
        {
            try
            {
                // Simulate finding blocks based on type and target
                // For Step 6, just return reasonable simulated counts
                
                if (target.Contains("all"))
                {
                    return SimulateAllBlocksOfType(blockType);
                }
                else if (target.Contains(GetTargetKeyword(blockType)))
                {
                    return SimulateSingleBlock(blockType);
                }
                else
                {
                    return 0; // No matching blocks
                }
            }
            catch
            {
                return 0;
            }
        }
        
        /// <summary>
        /// Simulate all blocks of type
        /// </summary>
        private static int SimulateAllBlocksOfType(string blockType)
        {
            // Return simulated block counts for different types
            switch (blockType)
            {
                case "Reactor": return 2;
                case "InteriorLight": return 8;
                case "Assembler": return 1;
                case "Refinery": return 1;
                case "BatteryBlock": return 4;
                default: return 1;
            }
        }
        
        /// <summary>
        /// Simulate single block
        /// </summary>
        private static int SimulateSingleBlock(string blockType)
        {
            return 1; // Single block found
        }
        
        /// <summary>
        /// Get target keyword
        /// </summary>
        private static string GetTargetKeyword(string blockType)
        {
            switch (blockType)
            {
                case "Reactor": return "reactor";
                case "InteriorLight": return "light";
                case "Assembler": return "assembler";
                case "Refinery": return "refinery";
                case "BatteryBlock": return "battery";
                default: return blockType.ToLower();
            }
        }
        
        #endregion
        
        #region Result Management
        
        /// <summary>
        /// Basic execution result
        /// </summary>
        private struct BasicExecutionResult
        {
            public bool Success;
            public string Message;
            public int BlockCount;
        }
        
        /// <summary>
        /// Log execution result
        /// </summary>
        private static void LogExecutionResult(CommandProcessingResult result)
        {
            try
            {
                var icon = result.Success ? "✅" : "❌";
                var timeInfo = $"({result.ProcessingDurationMs:F1}ms)";
                
                MyLog.Default.WriteLine($"GRID CommandExecutionEngine: {icon} {result.CommandId} {timeInfo} - {result.Message}");
                
                if (result.AffectedBlocks > 0)
                {
                    MyLog.Default.WriteLine($"GRID CommandExecutionEngine:    Affected blocks: {result.AffectedBlocks}");
                }
                
                if (!result.Success && !string.IsNullOrEmpty(result.ErrorDetails))
                {
                    MyLog.Default.WriteLine($"GRID CommandExecutionEngine:    Error: {result.ErrorDetails}");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandExecutionEngine", "Result logging error", ex, ErrorHandler.ErrorSeverity.Low);
            }
        }
        
        /// <summary>
        /// Determine block type from command ID
        /// </summary>
        private static string DetermineBlockTypeFromCommandId(string commandId)
        {
            if (commandId.Contains("reactor"))
                return "Reactor";
            else if (commandId.Contains("light"))
                return "InteriorLight";
            else if (commandId.Contains("assembler"))
                return "Assembler";
            else if (commandId.Contains("refinery"))
                return "Refinery";
            else if (commandId.Contains("battery"))
                return "BatteryBlock";
            else
                return "Unknown";
        }
        
        /// <summary>
        /// Determine action from command ID
        /// </summary>
        private static string DetermineActionFromCommandId(string commandId)
        {
            if (commandId.Contains("turn_on") || commandId.Contains("enable"))
                return "enabled";
            else if (commandId.Contains("turn_off") || commandId.Contains("disable"))
                return "disabled";
            else
                return "processed";
        }
        
        /// <summary>
        /// Extract block count from controller result message
        /// </summary>
        private static int ExtractBlockCountFromResult(string resultMessage)
        {
            try
            {
                if (string.IsNullOrEmpty(resultMessage)) return 0;
                
                // Look for patterns like "5/10 blocks" or "3 blocks affected"
                var words = resultMessage.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    int count;
                    if (int.TryParse(words[i], out count))
                    {
                        // Check if next word indicates this is a block count
                        if (i + 1 < words.Length && words[i + 1].ToLower().Contains("block"))
                        {
                            return count;
                        }
                        
                        // Check for "X/Y" pattern
                        if (words[i].Contains("/"))
                        {
                            var parts = words[i].Split('/');
                            int successCount;
                            if (parts.Length == 2 && int.TryParse(parts[0], out successCount))
                            {
                                return successCount;
                            }
                        }
                    }
                }
                
                return 0;
            }
            catch
            {
                return 0;
            }
        }
        
        #endregion
        
        #region Dependency Management
        
        /// <summary>
        /// Set spatial coordinator for all controllers (Step 7 + Step 9)
        /// </summary>
        public static void SetSpatialCoordinator(GRID.SpatialIntelligence.BasicSpatialCoordinator spatialCoordinator)
        {
            try
            {
                if (spatialCoordinator != null)
                {
                    // Step 7: Set for Universal Controller
                    if (_universalController != null)
                    {
                        _universalController.SetSpatialCoordinator(spatialCoordinator);
                        MyLog.Default.WriteLine("GRID CommandExecutionEngine: Spatial coordinator dependency set for Universal Controller");
                    }
                    
                    // Step 9: Set for specialized controllers (prepare for Step 10 spatial intelligence)
                    if (_powerController != null)
                    {
                        _powerController.SetSpatialCoordinator(spatialCoordinator);
                        MyLog.Default.WriteLine("GRID CommandExecutionEngine: Spatial coordinator dependency set for Power Controller");
                    }
                    
                    if (_lifeSupportController != null)
                    {
                        _lifeSupportController.SetSpatialCoordinator(spatialCoordinator);
                        MyLog.Default.WriteLine("GRID CommandExecutionEngine: Spatial coordinator dependency set for Life Support Controller");
                    }
                    
                    if (_automationController != null)
                    {
                        _automationController.SetSpatialCoordinator(spatialCoordinator);
                        MyLog.Default.WriteLine("GRID CommandExecutionEngine: Spatial coordinator dependency set for Automation Controller");
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandExecutionEngine", "Spatial coordinator dependency error", ex, ErrorHandler.ErrorSeverity.Medium);
            }
        }
        
        #endregion
        
        #region Safety Control Interface (Step 8)
        
        /// <summary>
        /// TESTING: Toggle safety system on/off completely
        /// </summary>
        public static void SetSafetyEnabled(bool enabled)
        {
            PlanValidationEngine.SetSafetyEnabled(enabled);
            MyLog.Default.WriteLine($"GRID CommandExecutionEngine: Safety system {(enabled ? "ENABLED" : "DISABLED FOR TESTING")}");
        }
        
        /// <summary>
        /// TESTING: Toggle specific safety category
        /// </summary>
        public static void SetSafetyCategoryEnabled(PlanValidationEngine.SafetyCategory category, bool enabled)
        {
            PlanValidationEngine.SetCategoryEnabled(category, enabled);
            MyLog.Default.WriteLine($"GRID CommandExecutionEngine: Safety category {category} {(enabled ? "ENABLED" : "DISABLED")}");
        }
        
        /// <summary>
        /// EMERGENCY: Activate emergency override (bypasses all safety)
        /// </summary>
        public static void ActivateEmergencyOverride(bool active)
        {
            PlanValidationEngine.ActivateEmergencyOverride(active);
            MyLog.Default.WriteLine($"GRID CommandExecutionEngine: Emergency override {(active ? "ACTIVATED - ALL SAFETY BYPASSED" : "DEACTIVATED")}");
        }
        
        /// <summary>
        /// Get current safety system status
        /// </summary>
        public static string GetSafetyStatus()
        {
            return PlanValidationEngine.GetSafetyStatus();
        }
        
        #endregion
        
        #region Public Interface
        
        /// <summary>
        /// Get execution engine status
        /// </summary>
        public static string GetExecutionEngineStatus()
        {
            if (!_isInitialized)
            {
                return "CommandExecutionEngine: Not initialized";
            }
            
            var successRate = _totalCommandsExecuted > 0 ? 
                            (_successfulCommands * 100.0 / _totalCommandsExecuted) : 0;
            
            return $"CommandExecutionEngine: {_successfulCommands}/{_totalCommandsExecuted} commands executed ({successRate:F1}% success)";
        }
        
        /// <summary>
        /// Get total commands executed
        /// </summary>
        public static int GetTotalCommandsExecuted()
        {
            return _totalCommandsExecuted;
        }
        
        #endregion
    }
}
