using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using VRage.Game.ModAPI;
using VRage.Utils;
using GRID.Foundation;
using GRID.Controllers;
using GRID.SpatialIntelligence;

namespace GRID.CommandProcessing
{
    /// <summary>
    /// GRID Command Execution Engine - Basic Execution for Step 6
    /// Provides simple command execution using IMyFunctionalBlock.Enabled
    /// for basic "turn on/off" operations without complex controller routing.
    /// </summary>
    public static class CommandExecutionEngine
    {
        #region Private Fields
        
        private static bool _isInitialized = false;
        private static int _totalCommandsExecuted = 0;
        private static int _successfulCommands = 0;
        
        // Step 7: Universal Controller for real block control
        private static UniversalController _universalController = null;
        
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
                
                // Step 7: Initialize Universal Controller for real block control
                _universalController = new UniversalController();
                if (!_universalController.Initialize())
                {
                    ErrorHandler.ReportCritical("CommandExecutionEngine", "Universal controller initialization failed", null);
                    return;
                }
                
                _isInitialized = true;
                
                MyLog.Default.WriteLine("GRID CommandExecutionEngine: Command execution engine initialized with real block control");
                MyLog.Default.WriteLine("GRID CommandExecutionEngine: Universal controller ready for 17 universal commands");
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
                    
                    // Step 7: REAL execution using Universal Controller
                    var executionResult = ExecuteWithUniversalController(command);
                    
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
        /// Set spatial coordinator for Universal Controller
        /// </summary>
        public static void SetSpatialCoordinator(GRID.SpatialIntelligence.BasicSpatialCoordinator spatialCoordinator)
        {
            try
            {
                if (_universalController != null && spatialCoordinator != null)
                {
                    _universalController.SetSpatialCoordinator(spatialCoordinator);
                    MyLog.Default.WriteLine("GRID CommandExecutionEngine: Spatial coordinator dependency set for Universal Controller");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError("CommandExecutionEngine", "Spatial coordinator dependency error", ex, ErrorHandler.ErrorSeverity.Medium);
            }
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
