using System;
using System.Collections.Generic;
using VRage.Utils;
using GRID.Foundation;
using GRID.CommandProcessing;
using GRID.Safety;

namespace GRID.Testing
{
    /// <summary>
    /// GRID Step 8 Validation Tests - Safety System Testing
    /// Tests the specific requirements from AI_BUILD_STEPS.md:
    /// - "turn off all life support" is BLOCKED
    /// - "turn on lights" is ALLOWED
    /// 
    /// All tests can be disabled for full testing mode
    /// </summary>
    public static class Step8ValidationTests
    {
        #region Test Configuration
        
        private const string COMPONENT_NAME = "Step8ValidationTests";
        private static int _testsRun = 0;
        private static int _testsPassed = 0;
        private static int _testsFailed = 0;
        
        #endregion
        
        #region Test Initialization
        
        /// <summary>
        /// Initialize Step 8 validation tests
        /// </summary>
        public static bool Initialize()
        {
            try
            {
                _testsRun = 0;
                _testsPassed = 0;
                _testsFailed = 0;
                
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Step 8 safety validation tests initialized");
                return true;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(COMPONENT_NAME, "Test initialization failed", ex, ErrorHandler.ErrorSeverity.Medium);
                return false;
            }
        }
        
        #endregion
        
        #region Core Safety Tests (Step 8 Requirements)
        
        /// <summary>
        /// Run all Step 8 validation tests
        /// Tests the EXACT requirements from AI_BUILD_STEPS.md
        /// </summary>
        public static bool RunAllSafetyTests()
        {
            try
            {
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ====== RUNNING STEP 8 SAFETY VALIDATION TESTS ======");
                
                // Reset counters
                _testsRun = 0;
                _testsPassed = 0;
                _testsFailed = 0;
                
                // Ensure safety is enabled for testing
                PlanValidationEngine.SetSafetyEnabled(true);
                PlanValidationEngine.ActivateEmergencyOverride(false);
                
                // REQUIREMENT 1: "turn off all life support" is BLOCKED
                TestLifeSupportBlocked();
                
                // REQUIREMENT 2: "turn on lights" is ALLOWED
                TestLightsAllowed();
                
                // Additional safety tests
                TestPowerSystemSafety();
                TestEmergencyToggle();
                TestSafetyToggle();
                
                // Report results
                ReportTestResults();
                
                // Return true if all tests passed
                return _testsFailed == 0;
            }
            catch (Exception ex)
            {
                ErrorHandler.ReportError(COMPONENT_NAME, "Safety test execution failed", ex, ErrorHandler.ErrorSeverity.High);
                return false;
            }
        }
        
        /// <summary>
        /// TEST REQUIREMENT 1: "turn off all life support" is BLOCKED
        /// </summary>
        private static void TestLifeSupportBlocked()
        {
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Testing life support protection...");
            
            // Test various life support shutdown commands
            var lifeSupportCommands = new StructuredCommand[]
            {
                new StructuredCommand
                {
                    CommandId = "turn_off_life_support",
                    Target = "all",
                    Category = "life_support",
                    Source = "Step8Test",
                    Timestamp = DateTime.UtcNow
                },
                new StructuredCommand
                {
                    CommandId = "turn_off_oxygen",
                    Target = "all_oxygen",
                    Category = "life_support",
                    Source = "Step8Test",
                    Timestamp = DateTime.UtcNow
                },
                new StructuredCommand
                {
                    CommandId = "disable_air_vents",
                    Target = "all",
                    Category = "life_support",
                    Source = "Step8Test",
                    Timestamp = DateTime.UtcNow
                }
            };
            
            foreach (var command in lifeSupportCommands)
            {
                RunSafetyTest($"Block life support: {command.CommandId}", command, false);
            }
        }
        
        /// <summary>
        /// TEST REQUIREMENT 2: "turn on lights" is ALLOWED
        /// </summary>
        private static void TestLightsAllowed()
        {
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Testing lighting system permissions...");
            
            // Test light control commands (should be allowed)
            var lightCommands = new StructuredCommand[]
            {
                new StructuredCommand
                {
                    CommandId = "turn_on_lights",
                    Target = "all_lights",
                    Category = "lighting",
                    Source = "Step8Test",
                    Timestamp = DateTime.UtcNow
                },
                new StructuredCommand
                {
                    CommandId = "turn_off_lights",
                    Target = "hangar_lights",
                    Category = "lighting",
                    Source = "Step8Test",
                    Timestamp = DateTime.UtcNow
                },
                new StructuredCommand
                {
                    CommandId = "toggle_lights",
                    Target = "interior_lights",
                    Category = "lighting",
                    Source = "Step8Test",
                    Timestamp = DateTime.UtcNow
                }
            };
            
            foreach (var command in lightCommands)
            {
                RunSafetyTest($"Allow lighting: {command.CommandId}", command, true);
            }
        }
        
        /// <summary>
        /// Test power system safety (prepare for Step 9)
        /// </summary>
        private static void TestPowerSystemSafety()
        {
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Testing power system safety...");
            
            // Test dangerous power commands (should be blocked)
            var dangerousPowerCommand = new StructuredCommand
            {
                CommandId = "turn_off_reactor",
                Target = "all",
                Category = "power",
                Source = "Step8Test",
                Timestamp = DateTime.UtcNow
            };
            
            RunSafetyTest("Block complete power shutdown", dangerousPowerCommand, false);
            
            // Test safe power commands (should be allowed)
            var safePowerCommand = new StructuredCommand
            {
                CommandId = "turn_on_reactor",
                Target = "reactor_01",
                Category = "power",
                Source = "Step8Test",
                Timestamp = DateTime.UtcNow
            };
            
            RunSafetyTest("Allow single reactor control", safePowerCommand, true);
        }
        
        /// <summary>
        /// Test emergency override functionality
        /// </summary>
        private static void TestEmergencyToggle()
        {
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Testing emergency override...");
            
            var dangerousCommand = new StructuredCommand
            {
                CommandId = "turn_off_life_support",
                Target = "all",
                Category = "life_support",
                Source = "Step8Test",
                Timestamp = DateTime.UtcNow
            };
            
            // Should be blocked normally
            RunSafetyTest("Block life support (normal mode)", dangerousCommand, false);
            
            // Activate emergency override
            PlanValidationEngine.ActivateEmergencyOverride(true);
            
            // Should be allowed with override
            RunSafetyTest("Allow life support (emergency override)", dangerousCommand, true);
            
            // Deactivate emergency override
            PlanValidationEngine.ActivateEmergencyOverride(false);
            
            // Should be blocked again
            RunSafetyTest("Block life support (override disabled)", dangerousCommand, false);
        }
        
        /// <summary>
        /// Test safety system toggle functionality
        /// </summary>
        private static void TestSafetyToggle()
        {
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Testing safety system toggle...");
            
            var dangerousCommand = new StructuredCommand
            {
                CommandId = "turn_off_life_support",
                Target = "all",
                Category = "life_support",
                Source = "Step8Test",
                Timestamp = DateTime.UtcNow
            };
            
            // Should be blocked with safety enabled
            PlanValidationEngine.SetSafetyEnabled(true);
            RunSafetyTest("Block life support (safety enabled)", dangerousCommand, false);
            
            // Should be allowed with safety disabled
            PlanValidationEngine.SetSafetyEnabled(false);
            RunSafetyTest("Allow life support (safety disabled)", dangerousCommand, true);
            
            // Re-enable safety for normal operation
            PlanValidationEngine.SetSafetyEnabled(true);
        }
        
        #endregion
        
        #region Test Utilities
        
        /// <summary>
        /// Run a single safety validation test
        /// </summary>
        private static void RunSafetyTest(string testName, StructuredCommand command, bool expectedAllowed)
        {
            _testsRun++;
            
            try
            {
                var result = PlanValidationEngine.ValidateCommand(command);
                
                if (result.IsAllowed == expectedAllowed)
                {
                    _testsPassed++;
                    MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ✅ PASS - {testName}");
                }
                else
                {
                    _testsFailed++;
                    string expected = expectedAllowed ? "ALLOWED" : "BLOCKED";
                    string actual = result.IsAllowed ? "ALLOWED" : "BLOCKED";
                    MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ❌ FAIL - {testName} (Expected: {expected}, Got: {actual})");
                    
                    if (!result.IsAllowed)
                    {
                        MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}:    Block reason: {result.BlockReason}");
                    }
                }
            }
            catch (Exception ex)
            {
                _testsFailed++;
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ❌ ERROR - {testName}: {ex.Message}");
                ErrorHandler.ReportError(COMPONENT_NAME, $"Test failed: {testName}", ex, ErrorHandler.ErrorSeverity.Medium);
            }
        }
        
        /// <summary>
        /// Report test results
        /// </summary>
        private static void ReportTestResults()
        {
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ====== STEP 8 SAFETY TEST RESULTS ======");
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Tests Run: {_testsRun}");
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Tests Passed: {_testsPassed}");
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: Tests Failed: {_testsFailed}");
            
            if (_testsFailed == 0)
            {
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: 🎉 ALL STEP 8 SAFETY TESTS PASSED");
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ✅ Life support protection working");
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ✅ Lighting system permissions working");
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ✅ Safety toggle functionality working");
            }
            else
            {
                MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ⚠️ SOME STEP 8 SAFETY TESTS FAILED");
            }
            
            MyLog.Default.WriteLine($"GRID {COMPONENT_NAME}: ============================================");
        }
        
        /// <summary>
        /// Get test results summary
        /// </summary>
        public static string GetTestSummary()
        {
            if (_testsRun == 0)
            {
                return "Step 8 Safety Tests: Not run";
            }
            
            double passRate = (_testsPassed * 100.0) / _testsRun;
            return $"Step 8 Safety Tests: {_testsPassed}/{_testsRun} passed ({passRate:F1}%)";
        }
        
        #endregion
    }
}
