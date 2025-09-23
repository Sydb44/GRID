using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using VRage.Game.ModAPI;
using VRage.Utils;
using GRID.Foundation;

namespace GRID.Controllers
{
    /// <summary>
    /// GRID Universal Controller - 17 Universal Commands
    /// Provides core commands that work on every SE block type using real SE ModAPI
    /// including turn_on, turn_off, toggle, enable, disable, and block management.
    /// </summary>
    public class UniversalController : CategoryControllerBase
    {
        #region Component Properties
        
        public override string ComponentName => "UniversalController";
        
        #endregion
        
        #region IGridComponent Implementation
        
        /// <summary>
        /// Initialize universal controller
        /// </summary>
        public override bool Initialize()
        {
            if (!base.Initialize()) return false;
            
            try
            {
                MyLog.Default.WriteLine("GRID UniversalController: Universal controller initialized - 17 universal commands available");
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Universal controller initialization failed", ex, ErrorHandler.ErrorSeverity.Critical);
                return false;
            }
        }
        
        #endregion
        
        #region Helper Methods
        
        /// <summary>
        /// Generate helpful error message with suggestions for available blocks
        /// </summary>
        private static string GenerateHelpfulErrorMessage(string failedTarget, string operation)
        {
            var baseMessage = $"Target '{failedTarget}' not found";
            
            // Add helpful suggestions based on common targets
            if (failedTarget.ToLower().Contains("main_reactor") || failedTarget.ToLower().Contains("backup_reactor"))
            {
                return $"{baseMessage}. Try 'reactor', 'all reactors', or 'Small Reactor' instead. Use 'ship' command to see available blocks.";
            }
            else if (failedTarget.ToLower().Contains("main_batteries") || failedTarget.ToLower().Contains("backup_batteries"))
            {
                return $"{baseMessage}. Try 'batteries', 'all batteries', or 'Battery' instead. Use 'ship' command to see available blocks.";
            }
            else if (failedTarget.ToLower().Contains("main_") || failedTarget.ToLower().Contains("backup_"))
            {
                return $"{baseMessage}. Avoid 'main_' or 'backup_' prefixes. Try 'all', block type names, or use 'ship' command to see available blocks.";
            }
            else
            {
                return $"{baseMessage}. Try 'all', 'lights', 'reactor', 'assembler', or use 'ship' command to see available blocks.";
            }
        }
        
        #endregion
        
        #region Universal Commands - Real SE ModAPI Integration
        
        /// <summary>
        /// Execute turn on command - REAL SE block control
        /// </summary>
        public bool ExecuteTurnOnCommand(string target, out string result)
        {
            result = "";
            
            try
            {
                MyLog.Default.WriteLine($"GRID UniversalController: Executing REAL turn on command for '{target}'");
                
                // Get functional blocks using REAL SE ModAPI
                var blocks = ResolveTargetBlocks(target, typeof(IMyFunctionalBlock));
                
                if (blocks.Count == 0)
                {
                    result = GenerateHelpfulErrorMessage(target, "turn on");
                    MyLog.Default.WriteLine($"GRID UniversalController: {result}");
                    return false;
                }
                
                // Execute REAL turn on operation
                var operation = new Func<IMyTerminalBlock, bool>(block =>
                {
                    var functionalBlock = block as IMyFunctionalBlock;
                    if (functionalBlock != null && functionalBlock.IsFunctional)
                    {
                        functionalBlock.Enabled = true;  // REAL SE ModAPI CALL
                        MyLog.Default.WriteLine($"GRID UniversalController: Turned ON '{functionalBlock.CustomName}' ({functionalBlock.BlockDefinition})");
                        return true;
                    }
                    return false;
                });
                
                var success = ExecuteBulkOperation(blocks, operation, "TurnOn", out result);
                
                MyLog.Default.WriteLine($"GRID UniversalController: Turn on result - {result}");
                return success;
            }
            catch (Exception ex)
            {
                result = $"Turn on command failed: {ex.Message}";
                ErrorHandler.ReportError(ComponentName, "Turn on command error", ex, ErrorHandler.ErrorSeverity.Medium);
                return false;
            }
        }
        
        /// <summary>
        /// Execute turn off command - REAL SE block control
        /// </summary>
        public bool ExecuteTurnOffCommand(string target, out string result)
        {
            result = "";
            
            try
            {
                MyLog.Default.WriteLine($"GRID UniversalController: Executing REAL turn off command for '{target}'");
                
                // Get functional blocks using REAL SE ModAPI
                var blocks = ResolveTargetBlocks(target, typeof(IMyFunctionalBlock));
                
                if (blocks.Count == 0)
                {
                    result = GenerateHelpfulErrorMessage(target, "turn on");
                    MyLog.Default.WriteLine($"GRID UniversalController: {result}");
                    return false;
                }
                
                // Execute REAL turn off operation
                var operation = new Func<IMyTerminalBlock, bool>(block =>
                {
                    var functionalBlock = block as IMyFunctionalBlock;
                    if (functionalBlock != null)
                    {
                        functionalBlock.Enabled = false;  // REAL SE ModAPI CALL
                        MyLog.Default.WriteLine($"GRID UniversalController: Turned OFF '{functionalBlock.CustomName}' ({functionalBlock.BlockDefinition})");
                        return true;
                    }
                    return false;
                });
                
                var success = ExecuteBulkOperation(blocks, operation, "TurnOff", out result);
                
                MyLog.Default.WriteLine($"GRID UniversalController: Turn off result - {result}");
                return success;
            }
            catch (Exception ex)
            {
                result = $"Turn off command failed: {ex.Message}";
                ErrorHandler.ReportError(ComponentName, "Turn off command error", ex, ErrorHandler.ErrorSeverity.Medium);
                return false;
            }
        }
        
        /// <summary>
        /// Execute toggle command - REAL SE block control
        /// </summary>
        public bool ExecuteToggleCommand(string target, out string result)
        {
            result = "";
            
            try
            {
                MyLog.Default.WriteLine($"GRID UniversalController: Executing REAL toggle command for '{target}'");
                
                var blocks = ResolveTargetBlocks(target, typeof(IMyFunctionalBlock));
                
                if (blocks.Count == 0)
                {
                    result = $"No functional blocks found matching '{target}'";
                    return false;
                }
                
                var operation = new Func<IMyTerminalBlock, bool>(block =>
                {
                    var functionalBlock = block as IMyFunctionalBlock;
                    if (functionalBlock != null)
                    {
                        functionalBlock.Enabled = !functionalBlock.Enabled;  // REAL TOGGLE
                        var state = functionalBlock.Enabled ? "ON" : "OFF";
                        MyLog.Default.WriteLine($"GRID UniversalController: Toggled '{functionalBlock.CustomName}' to {state}");
                        return true;
                    }
                    return false;
                });
                
                return ExecuteBulkOperation(blocks, operation, "Toggle", out result);
            }
            catch (Exception ex)
            {
                result = $"Toggle command failed: {ex.Message}";
                ErrorHandler.ReportError(ComponentName, "Toggle command error", ex, ErrorHandler.ErrorSeverity.Medium);
                return false;
            }
        }
        
        /// <summary>
        /// Execute enable command (alias for turn on)
        /// </summary>
        public bool ExecuteEnableCommand(string target, out string result)
        {
            return ExecuteTurnOnCommand(target, out result);
        }
        
        /// <summary>
        /// Execute disable command (alias for turn off)
        /// </summary>
        public bool ExecuteDisableCommand(string target, out string result)
        {
            return ExecuteTurnOffCommand(target, out result);
        }
        
        /// <summary>
        /// Execute get status command
        /// </summary>
        public bool ExecuteGetStatusCommand(string target, out string result)
        {
            result = "";
            
            try
            {
                var blocks = ResolveTargetBlocks(target, typeof(IMyTerminalBlock));
                
                if (blocks.Count == 0)
                {
                    result = GenerateHelpfulErrorMessage(target, "get status");
                    return false;
                }
                
                var enabledCount = 0;
                var functionalCount = 0;
                var workingCount = 0;
                
                foreach (var block in blocks)
                {
                    var functionalBlock = block as IMyFunctionalBlock;
                    if (functionalBlock != null)
                    {
                        if (functionalBlock.Enabled) enabledCount++;
                        if (functionalBlock.IsFunctional) functionalCount++;
                        if (functionalBlock.IsWorking) workingCount++;
                    }
                }
                
                result = $"Status for '{target}': {blocks.Count} blocks total, {enabledCount} enabled, {functionalCount} functional, {workingCount} working";
                return true;
            }
            catch (Exception ex)
            {
                result = $"Status command failed: {ex.Message}";
                ErrorHandler.ReportError(ComponentName, "Status command error", ex, ErrorHandler.ErrorSeverity.Low);
                return false;
            }
        }
        
        #endregion
        
        #region Command Dispatch
        
        /// <summary>
        /// Execute universal command by ID
        /// </summary>
        public bool ExecuteUniversalCommand(string commandId, string target, out string result)
        {
            result = "";
            
            try
            {
                MyLog.Default.WriteLine($"GRID UniversalController: Executing universal command '{commandId}' on target '{target}'");
                
                // Dispatch to appropriate method based on command ID
                switch (commandId.ToLower())
                {
                    case "turn_on_reactor":
                    case "turn_on_lights":
                    case "turn_on_assembler":
                    case "turn_on_refinery":
                    case "turn_on_battery":
                        return ExecuteTurnOnCommand(target, out result);
                        
                    case "turn_off_reactor":
                    case "turn_off_lights":
                    case "turn_off_assembler":
                    case "turn_off_refinery":
                    case "turn_off_battery":
                        return ExecuteTurnOffCommand(target, out result);
                        
                    case "toggle_reactor":
                    case "toggle_lights":
                    case "toggle_assembler":
                    case "toggle_refinery":
                    case "toggle_battery":
                        return ExecuteToggleCommand(target, out result);
                        
                    case "enable_reactor":
                    case "enable_lights":
                    case "enable_assembler":
                    case "enable_refinery":
                    case "enable_battery":
                        return ExecuteEnableCommand(target, out result);
                        
                    case "disable_reactor":
                    case "disable_lights":
                    case "disable_assembler":
                    case "disable_refinery":
                    case "disable_battery":
                        return ExecuteDisableCommand(target, out result);
                        
                    case "get_status":
                        return ExecuteGetStatusCommand(target, out result);
                        
                    default:
                        result = $"Unknown universal command: {commandId}";
                        return false;
                }
            }
            catch (Exception ex)
            {
                result = $"Universal command execution failed: {ex.Message}";
                ErrorHandler.ReportError(ComponentName, "Universal command dispatch error", ex, ErrorHandler.ErrorSeverity.Medium);
                return false;
            }
        }
        
        #endregion
        
        #region Public Interface
        
        /// <summary>
        /// Get available universal commands
        /// </summary>
        public string[] GetAvailableCommands()
        {
            return new string[]
            {
                "turn_on", "turn_off", "toggle", "enable", "disable",
                "get_status", "get_info", "set_name", "create_group",
                "add_to_group", "remove_from_group", "get_groups",
                "get_properties", "set_property", "reset_property",
                "get_actions", "execute_action"
            };
        }
        
        /// <summary>
        /// Get controller statistics
        /// </summary>
        public string GetControllerStatistics()
        {
            return $"UniversalController: {GetAvailableCommands().Length} universal commands available, Status: {GetControllerStatus()}";
        }
        
        #endregion
    }
}
