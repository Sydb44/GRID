using Sandbox.ModAPI;
using System;
using System.Collections.Generic;
using VRage.Utils;
using GRID.Foundation;
using GRID.CommandProcessing;

namespace GRID.Safety
{
    /// <summary>
    /// GRID Plan Validation Engine - Step 8 Safety System
    /// Validates command execution plans for safety before allowing execution.
    /// Provides zero damage guarantee and life support protection with toggle capability.
    /// 
    /// CRITICAL: This system can be completely disabled for testing purposes
    /// </summary>
    public static class PlanValidationEngine
    {
        #region Constants and Configuration
        
        private const string COMPONENT_NAME = "PlanValidationEngine";
        
        // Safety toggle - can be disabled completely for testing
        private static bool _safetyEnabled = true;
        private static bool _emergencyOverrideActive = false;
        
        // Safety categories that can be toggled individually
        private static readonly Dictionary<SafetyCategory, bool> _categoryToggles = new Dictionary<SafetyCategory, bool>
        {
            { SafetyCategory.LifeSupport, true },
            { SafetyCategory.PowerSystems, true },
            { SafetyCategory.StructuralIntegrity, true },
            { SafetyCategory.EmergencyProtocols, true }
        };
        
        #endregion
        
        #region Safety Categories
        
        /// <summary>
        /// Safety validation categories
        /// </summary>
        public enum SafetyCategory
        {
            LifeSupport,           // Oxygen, air vents, medical systems
            PowerSystems,          // Reactors, batteries, power critical systems  
            StructuralIntegrity,   // No self-destructive commands
            EmergencyProtocols     // Critical system protection
        }
        
        /// <summary>
        /// Safety validation result
        /// </summary>
        public struct SafetyValidationResult
        {
            public bool IsAllowed;
            public SafetyCategory ViolatedCategory;
            public string BlockReason;
            public string SafeAlternative;
            public bool CanOverride;
        }
        
        #endregion
        
        #region Initialization and Configuration
        
        /// <summary>
        /// Initialize the plan validation engine
        /// </summary>
        public static bool Initialize()
        {
            try
            {
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Initializing safety validation engine...");
                
                // Load safety configuration (defaults to enabled)
                _safetyEnabled = true;
                _emergencyOverrideActive = false;
                
                // Initialize all safety categories as enabled
                foreach (SafetyCategory category in Enum.GetValues(typeof(SafetyCategory)))
                {
                    if (!_categoryToggles.ContainsKey(category))
                    {
                        _categoryToggles[category] = true;
                    }
                }
                
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Safety validation engine initialized - Protection ENABLED");
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(COMPONENT_NAME, "Safety validation engine initialization failed", ex, ErrorHandler.ErrorSeverity.Critical);
                return false;
            }
        }
        
        /// <summary>
        /// TESTING: Toggle entire safety system on/off
        /// </summary>
        public static void SetSafetyEnabled(bool enabled)
        {
            _safetyEnabled = enabled;
            string status = enabled ? "ENABLED" : "DISABLED FOR TESTING";
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Safety system {status}");
            
            if (!enabled)
            {
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: WARNING - ALL SAFETY PROTECTIONS DISABLED");
            }
        }
        
        /// <summary>
        /// TESTING: Toggle individual safety category
        /// </summary>
        public static void SetCategoryEnabled(SafetyCategory category, bool enabled)
        {
            _categoryToggles[category] = enabled;
            string status = enabled ? "ENABLED" : "DISABLED";
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Safety category {category} {status}");
        }
        
        /// <summary>
        /// EMERGENCY: Activate emergency override (bypasses all safety for critical situations)
        /// </summary>
        public static void ActivateEmergencyOverride(bool active)
        {
            _emergencyOverrideActive = active;
            string status = active ? "ACTIVE - ALL SAFETY BYPASSED" : "INACTIVE";
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Emergency override {status}");
        }
        
        #endregion
        
        #region Core Safety Validation
        
        /// <summary>
        /// Validate a structured command for safety before execution
        /// CRITICAL: This is the main safety checkpoint for all commands
        /// </summary>
        public static SafetyValidationResult ValidateCommand(StructuredCommand command)
        {
            try
            {
                // If safety is completely disabled, allow everything
                if (!_safetyEnabled || _emergencyOverrideActive)
                {
                    return new SafetyValidationResult
                    {
                        IsAllowed = true,
                        BlockReason = _emergencyOverrideActive ? "Emergency override active" : "Safety disabled for testing",
                        CanOverride = false
                    };
                }
                
                // Validate against each safety category
                var result = ValidateLifeSupportSafety(command);
                if (!result.IsAllowed) return result;
                
                result = ValidatePowerSystemSafety(command);
                if (!result.IsAllowed) return result;
                
                result = ValidateStructuralIntegrity(command);
                if (!result.IsAllowed) return result;
                
                result = ValidateEmergencyProtocols(command);
                if (!result.IsAllowed) return result;
                
                // Command passed all safety checks
                return new SafetyValidationResult
                {
                    IsAllowed = true,
                    BlockReason = "",
                    CanOverride = false
                };
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(COMPONENT_NAME, $"Safety validation failed for command: {command.CommandId}", ex, ErrorHandler.ErrorSeverity.High);
                
                // On validation error, default to blocking for safety
                return new SafetyValidationResult
                {
                    IsAllowed = false,
                    ViolatedCategory = SafetyCategory.EmergencyProtocols,
                    BlockReason = "Safety validation system error - command blocked for safety",
                    CanOverride = true
                };
            }
        }
        
        #endregion
        
        #region Life Support Safety (Step 8 Requirement: Block "turn off all life support")
        
        /// <summary>
        /// Validate commands against life support safety rules
        /// REQUIREMENT: "turn off all life support" must be blocked
        /// </summary>
        private static SafetyValidationResult ValidateLifeSupportSafety(StructuredCommand command)
        {
            if (!_categoryToggles[SafetyCategory.LifeSupport])
            {
                return new SafetyValidationResult { IsAllowed = true };
            }
            
            string commandId = command.CommandId?.ToLower() ?? "";
            string target = command.Target?.ToLower() ?? "";
            
            // Block dangerous life support commands
            if (IsTurnOffCommand(commandId))
            {
                // Critical life support systems that should never be turned off completely
                if (target.Contains("oxygen") || target.Contains("air_vent") || target.Contains("life_support") ||
                    target.Contains("medical") || commandId.Contains("life_support"))
                {
                    return new SafetyValidationResult
                    {
                        IsAllowed = false,
                        ViolatedCategory = SafetyCategory.LifeSupport,
                        BlockReason = "Life support systems cannot be completely disabled - crew safety risk",
                        SafeAlternative = "Consider partial shutdown or individual block control",
                        CanOverride = true
                    };
                }
                
                // Special handling for "all" targets affecting life support
                if (target == "all" && (commandId.Contains("turn_off") || commandId.Contains("disable")))
                {
                    return new SafetyValidationResult
                    {
                        IsAllowed = false,
                        ViolatedCategory = SafetyCategory.LifeSupport,
                        BlockReason = "Mass system shutdown blocked - includes critical life support",
                        SafeAlternative = "Use specific system targeting instead of 'all'",
                        CanOverride = true
                    };
                }
            }
            
            return new SafetyValidationResult { IsAllowed = true };
        }
        
        #endregion
        
        #region Power System Safety (Future Step 9+ Integration Ready)
        
        /// <summary>
        /// Validate commands against power system safety rules
        /// Prepares for PowerManagementController integration (Step 9)
        /// </summary>
        private static SafetyValidationResult ValidatePowerSystemSafety(StructuredCommand command)
        {
            if (!_categoryToggles[SafetyCategory.PowerSystems])
            {
                return new SafetyValidationResult { IsAllowed = true };
            }
            
            string commandId = command.CommandId?.ToLower() ?? "";
            string target = command.Target?.ToLower() ?? "";
            
            // Block complete power system shutdown
            if (IsTurnOffCommand(commandId))
            {
                if ((target.Contains("reactor") && target.Contains("all")) ||
                    (target.Contains("battery") && target.Contains("all")) ||
                    (target == "all" && command.Category?.ToLower() == "power"))
                {
                    return new SafetyValidationResult
                    {
                        IsAllowed = false,
                        ViolatedCategory = SafetyCategory.PowerSystems,
                        BlockReason = "Complete power shutdown blocked - ship systems require power",
                        SafeAlternative = "Maintain at least one power source active",
                        CanOverride = true
                    };
                }
            }
            
            return new SafetyValidationResult { IsAllowed = true };
        }
        
        #endregion
        
        #region Structural Integrity Safety (Future Defense/Construction Controller Ready)
        
        /// <summary>
        /// Validate commands against structural integrity
        /// Prepares for DefenseController/ConstructionController integration (Steps 14+)
        /// </summary>
        private static SafetyValidationResult ValidateStructuralIntegrity(StructuredCommand command)
        {
            if (!_categoryToggles[SafetyCategory.StructuralIntegrity])
            {
                return new SafetyValidationResult { IsAllowed = true };
            }
            
            string commandId = command.CommandId?.ToLower() ?? "";
            
            // Block self-destructive commands
            if (commandId.Contains("detonate") || commandId.Contains("explode") || commandId.Contains("warhead"))
            {
                return new SafetyValidationResult
                {
                    IsAllowed = false,
                    ViolatedCategory = SafetyCategory.StructuralIntegrity,
                    BlockReason = "Destructive commands blocked for ship safety",
                    SafeAlternative = "Use emergency override if absolutely necessary",
                    CanOverride = true
                };
            }
            
            return new SafetyValidationResult { IsAllowed = true };
        }
        
        #endregion
        
        #region Emergency Protocols Safety
        
        /// <summary>
        /// Validate emergency protocol commands
        /// </summary>
        private static SafetyValidationResult ValidateEmergencyProtocols(StructuredCommand command)
        {
            if (!_categoryToggles[SafetyCategory.EmergencyProtocols])
            {
                return new SafetyValidationResult { IsAllowed = true };
            }
            
            // All emergency protocols validation passes for now
            // Future expansion for critical system protection
            return new SafetyValidationResult { IsAllowed = true };
        }
        
        #endregion
        
        #region Utility Methods
        
        /// <summary>
        /// Check if command is a turn-off/disable type command
        /// </summary>
        private static bool IsTurnOffCommand(string commandId)
        {
            if (string.IsNullOrEmpty(commandId)) return false;
            
            string cmd = commandId.ToLower();
            return cmd.Contains("turn_off") || cmd.Contains("disable") || cmd.Contains("shutdown") || 
                   cmd.Contains("stop") || cmd.Contains("deactivate");
        }
        
        /// <summary>
        /// Get current safety system status for debugging
        /// </summary>
        public static string GetSafetyStatus()
        {
            if (!_safetyEnabled)
                return "DISABLED FOR TESTING";
            
            if (_emergencyOverrideActive)
                return "EMERGENCY OVERRIDE ACTIVE";
            
            var enabledCategories = new List<string>();
            foreach (var kvp in _categoryToggles)
            {
                if (kvp.Value) enabledCategories.Add(kvp.Key.ToString());
            }
            
            return $"ACTIVE - Categories: {string.Join(", ", enabledCategories)}";
        }
        
        #endregion
    }
}
