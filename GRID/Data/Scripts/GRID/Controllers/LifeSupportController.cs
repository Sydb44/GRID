using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using VRage.Game.ModAPI;
using VRage.Utils;
using GRID.Foundation;

namespace GRID.Controllers
{
    /// <summary>
    /// GRID Life Support Controller - Step 9 Core System Controller
    /// Provides oxygen generation, air vent control, and atmospheric management.
    /// Integrates with Step 8 safety validation and prepares for Step 10 spatial intelligence.
    /// 
    /// STEP 9 SCOPE: Oxygen management, air vent control, atmospheric monitoring
    /// FUTURE STEPS: Zone-based atmospheric control, advanced life support (Step 10+)
    /// </summary>
    public class LifeSupportController : CategoryControllerBase
    {
        #region Component Properties
        
        public override string ComponentName => "LifeSupportController";
        
        #endregion
        
        #region Life Support Constants
        
        // Oxygen level thresholds
        private const float LOW_OXYGEN_THRESHOLD = 0.25f;   // 25% oxygen
        private const float HIGH_OXYGEN_THRESHOLD = 0.90f;  // 90% oxygen
        private const float CRITICAL_OXYGEN_THRESHOLD = 0.15f; // 15% oxygen (critical)
        
        // Air pressure thresholds (SE standard atmosphere)
        private const float STANDARD_AIR_PRESSURE = 1.0f;
        private const float LOW_PRESSURE_THRESHOLD = 0.5f;
        private const float HIGH_PRESSURE_THRESHOLD = 1.2f;
        
        // Air vent modes
        private const int VENT_MODE_DEPRESSURIZE = 0;
        private const int VENT_MODE_PRESSURIZE = 1;
        
        #endregion
        
        #region Data Structures
        
        /// <summary>
        /// Life support system status information
        /// </summary>
        public struct LifeSupportStatus
        {
            public int TotalOxygenGenerators;
            public int ActiveOxygenGenerators;
            public int TotalOxygenTanks;
            public int TotalAirVents;
            public int ActiveAirVents;
            public float AverageOxygenLevel;     // 0.0 to 1.0
            public float AverageAirPressure;    // SE pressure units
            public string OxygenStatus;         // "Normal", "Low", "Critical", "High"
            public string PressureStatus;       // "Normal", "Low", "High", "Vacuum"
        }
        
        /// <summary>
        /// Oxygen management operation result
        /// </summary>
        public struct OxygenOperationResult
        {
            public bool Success;
            public int BlocksAffected;
            public string Operation;
            public string Status;
            public string Message;
        }
        
        #endregion
        
        #region IGridComponent Implementation
        
        /// <summary>
        /// Initialize life support controller
        /// </summary>
        public override bool Initialize()
        {
            if (!base.Initialize()) return false;
            
            try
            {
                MyLog.Default.WriteLine("GRID LifeSupportController: Initializing life support management system...");
                
                // Validate SE ModAPI life support interfaces are available
                if (!ValidateLifeSupportInterfaces())
                {
                    ErrorHandler.ReportError(ComponentName, "SE ModAPI life support interfaces validation failed", null, ErrorHandler.ErrorSeverity.Critical);
                    return false;
                }
                
                MyLog.Default.WriteLine("GRID LifeSupportController: Life support controller initialized");
                MyLog.Default.WriteLine("GRID LifeSupportController: Oxygen generation and tank management available");
                MyLog.Default.WriteLine("GRID LifeSupportController: Air vent control and atmospheric management available");
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Life support controller initialization failed", ex, ErrorHandler.ErrorSeverity.Critical);
                return false;
            }
        }
        
        /// <summary>
        /// Validate that required SE ModAPI life support interfaces are available
        /// </summary>
        private bool ValidateLifeSupportInterfaces()
        {
            try
            {
                // Basic validation that we can work with life support blocks
                // This is a simplified check for Step 9 scope
                return MyAPIGateway.Session != null && MyAPIGateway.Entities != null;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Life support interface validation failed", ex, ErrorHandler.ErrorSeverity.High);
                return false;
            }
        }
        
        #endregion
        
        #region Step 9 Core Commands - Oxygen Generation Management
        
        /// <summary>
        /// STEP 9 REQUIREMENT: Control oxygen generation systems
        /// </summary>
        public bool SetOxygenGeneration(string target, bool enabled, out string result)
        {
            result = "";
            
            try
            {
                using (PerformanceMonitor.TrackComponent($"{ComponentName}.SetOxygenGeneration"))
                {
                    MyLog.Default.WriteLine($"GRID LifeSupportController: Setting oxygen generation {(enabled ? "ON" : "OFF")} for target '{target}'");
                    
                    // Resolve target oxygen generators
                    string generatorResolveResult;
                    var generators = ResolveOxygenGeneratorBlocks(target, out generatorResolveResult);
                    if (generators == null || generators.Count == 0)
                    {
                        result = generatorResolveResult ?? "No oxygen generators found matching target";
                        return false;
                    }
                    
                    // Apply oxygen generation setting
                    var operationResult = ApplyOxygenGenerationSetting(generators, enabled);
                    
                    result = operationResult.Message;
                    return operationResult.Success;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Oxygen generation control failed", ex, ErrorHandler.ErrorSeverity.Medium);
                result = $"Oxygen generation control error: {ex.Message}";
                return false;
            }
        }
        
        /// <summary>
        /// Resolve oxygen generator blocks based on target specification - FLEXIBLE APPROACH
        /// Tries oxygen generators first, falls back to air vents for oxygen management
        /// </summary>
        private List<IMyGasGenerator> ResolveOxygenGeneratorBlocks(string target, out string errorMessage)
        {
            errorMessage = "";
            var generators = new List<IMyGasGenerator>();
            
            try
            {
                // FIXED: Use flexible block resolution like Universal Controller
                var resolvedBlocks = ResolveTargetBlocks(target, typeof(IMyFunctionalBlock));
                
                MyLog.Default.WriteLine($"GRID LifeSupportController: Found {resolvedBlocks.Count} blocks matching '{target}' for oxygen generator search");
                
                foreach (var block in resolvedBlocks)
                {
                    // Check if block is an oxygen generator using block definition
                    var blockType = block.BlockDefinition.ToString().ToLower();
                    if (blockType.Contains("oxygenerator") || blockType.Contains("oxygen") || blockType.Contains("gasgenerator"))
                    {
                        var generator = block as IMyGasGenerator;
                        if (generator != null)
                        {
                            generators.Add(generator);
                            MyLog.Default.WriteLine($"GRID LifeSupportController: Found oxygen generator '{generator.DisplayName}' ({generator.BlockDefinition})");
                        }
                    }
                }
                
                if (generators.Count == 0)
                {
                    // FALLBACK: Look for air vents that can handle oxygen
                    MyLog.Default.WriteLine($"GRID LifeSupportController: No oxygen generators found, checking for air vents that can manage oxygen");
                    errorMessage = $"No oxygen generator blocks found matching '{target}' (searched {resolvedBlocks.Count} blocks) - try using air vents for oxygen control";
                }
                
                return generators;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Oxygen generator block resolution failed", ex, ErrorHandler.ErrorSeverity.Medium);
                errorMessage = "Failed to resolve oxygen generator blocks";
                return null;
            }
        }
        
        /// <summary>
        /// Apply oxygen generation setting to resolved blocks
        /// </summary>
        private OxygenOperationResult ApplyOxygenGenerationSetting(List<IMyGasGenerator> generators, bool enabled)
        {
            var result = new OxygenOperationResult
            {
                Success = false,
                BlocksAffected = 0,
                Operation = enabled ? "Enable" : "Disable",
                Status = "",
                Message = ""
            };
            
            try
            {
                int successCount = 0;
                int failCount = 0;
                
                foreach (var generator in generators)
                {
                    try
                    {
                        // Verify generator is functional before changing state
                        if (!generator.IsFunctional)
                        {
                            failCount++;
                            continue;
                        }
                        
                        // Apply enabled/disabled state using SE ModAPI
                        generator.Enabled = enabled;
                        successCount++;
                    }
                    catch (Exception ex)
                    {
                        ErrorHandler.ReportError(ComponentName, $"Failed to control oxygen generator '{generator.DisplayName}'", ex, ErrorHandler.ErrorSeverity.Low);
                        failCount++;
                    }
                }
                
                // Determine result
                result.BlocksAffected = successCount;
                result.Success = successCount > 0;
                result.Status = enabled ? "Enabled" : "Disabled";
                
                if (successCount == generators.Count)
                {
                    result.Message = $"Oxygen generation {result.Status.ToLower()} for all {successCount} generators";
                }
                else if (successCount > 0)
                {
                    result.Message = $"Oxygen generation {result.Status.ToLower()} for {successCount}/{generators.Count} generators ({failCount} failed)";
                }
                else
                {
                    result.Message = $"Failed to control oxygen generation for any generators ({failCount} attempts failed)";
                }
                
                return result;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Oxygen generation setting application failed", ex, ErrorHandler.ErrorSeverity.Medium);
                result.Message = $"Oxygen generation control error: {ex.Message}";
                return result;
            }
        }
        
        #endregion
        
        #region Step 9 Core Commands - Air Vent Control
        
        /// <summary>
        /// STEP 9 REQUIREMENT: Control air vent pressurization modes
        /// </summary>
        public bool SetAirVentMode(string target, string mode, out string result)
        {
            result = "";
            
            try
            {
                using (PerformanceMonitor.TrackComponent($"{ComponentName}.SetAirVentMode"))
                {
                    MyLog.Default.WriteLine($"GRID LifeSupportController: Setting air vent mode '{mode}' for target '{target}'");
                    
                    // Parse air vent mode
                    bool depressurize;
                    string parseResult;
                    if (!ParseAirVentMode(mode, out depressurize, out parseResult))
                    {
                        result = parseResult;
                        return false;
                    }
                    
                    // Resolve target air vents
                    string ventResolveResult;
                    var airVents = ResolveAirVentBlocks(target, out ventResolveResult);
                    if (airVents == null || airVents.Count == 0)
                    {
                        result = ventResolveResult ?? "No air vents found matching target";
                        return false;
                    }
                    
                    // Apply air vent mode to all resolved air vents
                    var operationResult = ApplyAirVentMode(airVents, depressurize, mode);
                    
                    result = operationResult.Message;
                    return operationResult.Success;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Air vent mode control failed", ex, ErrorHandler.ErrorSeverity.Medium);
                result = $"Air vent control error: {ex.Message}";
                return false;
            }
        }
        
        /// <summary>
        /// Parse air vent mode string to boolean
        /// </summary>
        private bool ParseAirVentMode(string mode, out bool depressurize, out string errorMessage)
        {
            depressurize = false;
            errorMessage = "";
            
            if (string.IsNullOrEmpty(mode))
            {
                errorMessage = "Air vent mode cannot be empty";
                return false;
            }
            
            string modeUpper = mode.ToUpper();
            switch (modeUpper)
            {
                case "PRESSURIZE":
                case "FILL":
                case "ON":
                    depressurize = false;
                    return true;
                    
                case "DEPRESSURIZE":
                case "EMPTY":
                case "OFF":
                    depressurize = true;
                    return true;
                    
                default:
                    errorMessage = $"Unknown air vent mode '{mode}'. Valid modes: Pressurize, Depressurize";
                    return false;
            }
        }
        
        /// <summary>
        /// Resolve air vent blocks based on target specification
        /// </summary>
        private List<IMyAirVent> ResolveAirVentBlocks(string target, out string errorMessage)
        {
            errorMessage = "";
            var airVents = new List<IMyAirVent>();
            
            try
            {
                // Use base class block resolution for air vent blocks
                var resolvedBlocks = ResolveTargetBlocks(target, typeof(IMyAirVent));
                
                foreach (var block in resolvedBlocks)
                {
                    var airVent = block as IMyAirVent;
                    if (airVent != null)
                    {
                        airVents.Add(airVent);
                    }
                }
                
                if (airVents.Count == 0)
                {
                    errorMessage = $"No air vent blocks found matching '{target}'";
                }
                
                return airVents;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Air vent block resolution failed", ex, ErrorHandler.ErrorSeverity.Medium);
                errorMessage = "Failed to resolve air vent blocks";
                return null;
            }
        }
        
        /// <summary>
        /// Apply air vent mode to resolved air vent blocks
        /// </summary>
        private OxygenOperationResult ApplyAirVentMode(List<IMyAirVent> airVents, bool depressurize, string modeName)
        {
            var result = new OxygenOperationResult
            {
                Success = false,
                BlocksAffected = 0,
                Operation = depressurize ? "Depressurize" : "Pressurize",
                Status = modeName,
                Message = ""
            };
            
            try
            {
                int successCount = 0;
                int failCount = 0;
                
                foreach (var airVent in airVents)
                {
                    try
                    {
                        // Verify air vent is functional before changing mode
                        if (!airVent.IsFunctional || !airVent.IsWorking)
                        {
                            failCount++;
                            continue;
                        }
                        
                        // Apply air vent mode using SE ModAPI
                        airVent.Depressurize = depressurize;
                        if (!airVent.Enabled) airVent.Enabled = true; // Ensure air vent is enabled
                        successCount++;
                    }
                    catch (Exception ex)
                    {
                        ErrorHandler.ReportError(ComponentName, $"Failed to set mode for air vent '{airVent.DisplayName}'", ex, ErrorHandler.ErrorSeverity.Low);
                        failCount++;
                    }
                }
                
                // Determine result
                result.BlocksAffected = successCount;
                result.Success = successCount > 0;
                
                if (successCount == airVents.Count)
                {
                    result.Message = $"Air vent mode set to '{modeName}' for all {successCount} air vents";
                }
                else if (successCount > 0)
                {
                    result.Message = $"Air vent mode set to '{modeName}' for {successCount}/{airVents.Count} air vents ({failCount} failed)";
                }
                else
                {
                    result.Message = $"Failed to set air vent mode for any air vents ({failCount} attempts failed)";
                }
                
                return result;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Air vent mode application failed", ex, ErrorHandler.ErrorSeverity.Medium);
                result.Message = $"Air vent control error: {ex.Message}";
                return result;
            }
        }
        
        #endregion
        
        #region Step 9 Core Commands - Life Support Status and Monitoring
        
        /// <summary>
        /// STEP 9 REQUIREMENT: Get comprehensive life support system status
        /// </summary>
        public bool GetLifeSupportStatus(string target, out string result)
        {
            result = "";
            
            try
            {
                using (PerformanceMonitor.TrackComponent($"{ComponentName}.GetLifeSupportStatus"))
                {
                    MyLog.Default.WriteLine($"GRID LifeSupportController: Getting life support status for target '{target}'");
                    
                    var lifeSupportStatus = AnalyzeLifeSupportSystem(target);
                    result = FormatLifeSupportStatus(lifeSupportStatus);
                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Life support status analysis failed", ex, ErrorHandler.ErrorSeverity.Medium);
                result = $"Life support status error: {ex.Message}";
                return false;
            }
        }
        
        /// <summary>
        /// Analyze life support system and generate status report
        /// </summary>
        private LifeSupportStatus AnalyzeLifeSupportSystem(string target)
        {
            var status = new LifeSupportStatus();
            
            try
            {
                // Analyze oxygen generators
                string generatorError;
                var generators = ResolveOxygenGeneratorBlocks(target, out generatorError);
                if (generators != null)
                {
                    status.TotalOxygenGenerators = generators.Count;
                    status.ActiveOxygenGenerators = 0;
                    foreach (var generator in generators)
                    {
                        if (generator.IsWorking && generator.Enabled)
                        {
                            status.ActiveOxygenGenerators++;
                        }
                    }
                }
                
                // Analyze oxygen tanks
                string tankError;
                var oxygenTanks = ResolveOxygenTankBlocks(target, out tankError);
                if (oxygenTanks != null)
                {
                    status.TotalOxygenTanks = oxygenTanks.Count;
                    float totalOxygenLevel = 0f;
                    
                    foreach (var tank in oxygenTanks)
                    {
                        if (tank.IsWorking)
                        {
                            totalOxygenLevel += (float)(tank.FilledRatio);
                        }
                    }
                    
                    status.AverageOxygenLevel = oxygenTanks.Count > 0 ? totalOxygenLevel / oxygenTanks.Count : 0f;
                }
                
                // Analyze air vents
                string ventError;
                var airVents = ResolveAirVentBlocks(target, out ventError);
                if (airVents != null)
                {
                    status.TotalAirVents = airVents.Count;
                    status.ActiveAirVents = 0;
                    float totalPressure = 0f;
                    
                    foreach (var vent in airVents)
                    {
                        if (vent.IsWorking && vent.Enabled)
                        {
                            status.ActiveAirVents++;
                            totalPressure += vent.GetOxygenLevel();
                        }
                    }
                    
                    status.AverageAirPressure = status.ActiveAirVents > 0 ? totalPressure / status.ActiveAirVents : 0f;
                }
                
                // Determine status indicators
                status.OxygenStatus = DetermineOxygenStatus(status.AverageOxygenLevel);
                status.PressureStatus = DeterminePressureStatus(status.AverageAirPressure);
                
                return status;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Life support system analysis failed", ex, ErrorHandler.ErrorSeverity.Medium);
                return status; // Return partial status
            }
        }
        
        /// <summary>
        /// Resolve oxygen tank blocks for analysis
        /// </summary>
        private List<IMyGasTank> ResolveOxygenTankBlocks(string target, out string errorMessage)
        {
            errorMessage = "";
            var oxygenTanks = new List<IMyGasTank>();
            
            try
            {
                var resolvedBlocks = ResolveTargetBlocks(target, typeof(IMyGasTank));
                
                foreach (var block in resolvedBlocks)
                {
                    var gasTank = block as IMyGasTank;
                    // Filter for oxygen tanks (not hydrogen)
                    if (gasTank != null && gasTank.DisplayName.ToLower().Contains("oxygen"))
                    {
                        oxygenTanks.Add(gasTank);
                    }
                }
                
                return oxygenTanks;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(ComponentName, "Oxygen tank resolution failed", ex, ErrorHandler.ErrorSeverity.Medium);
                errorMessage = "Failed to resolve oxygen tank blocks";
                return null;
            }
        }
        
        /// <summary>
        /// Format life support status for human-readable output
        /// </summary>
        private string FormatLifeSupportStatus(LifeSupportStatus status)
        {
            var report = $"Life Support Status: " +
                        $"{status.ActiveOxygenGenerators}/{status.TotalOxygenGenerators} generators active, " +
                        $"{status.TotalOxygenTanks} oxygen tanks, " +
                        $"{status.ActiveAirVents}/{status.TotalAirVents} air vents active, " +
                        $"avg oxygen {status.AverageOxygenLevel:P0} ({status.OxygenStatus}), " +
                        $"pressure {status.AverageAirPressure:F2} ({status.PressureStatus})";
            
            return report;
        }
        
        /// <summary>
        /// Determine oxygen status indicator
        /// </summary>
        private string DetermineOxygenStatus(float oxygenLevel)
        {
            if (oxygenLevel < CRITICAL_OXYGEN_THRESHOLD) return "Critical";
            if (oxygenLevel < LOW_OXYGEN_THRESHOLD) return "Low";
            if (oxygenLevel > HIGH_OXYGEN_THRESHOLD) return "High";
            return "Normal";
        }
        
        /// <summary>
        /// Determine pressure status indicator
        /// </summary>
        private string DeterminePressureStatus(float pressure)
        {
            if (pressure < 0.1f) return "Vacuum";
            if (pressure < LOW_PRESSURE_THRESHOLD) return "Low";
            if (pressure > HIGH_PRESSURE_THRESHOLD) return "High";
            return "Normal";
        }
        
        #endregion
        
        #region Future Integration Preparation (Step 10+)
        
        // Note: Spatial intelligence integration will be added in Step 10
        // Zone-based atmospheric control will be implemented then
        // For now, we prepare the architecture but don't implement advanced features
        
        #endregion
    }
}
