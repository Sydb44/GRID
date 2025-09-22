# GRID Implementation Guide - Complete Build Instructions

## Implementation Overview

This guide provides step-by-step instructions for implementing the complete GRID system from scratch, following the exact architecture and patterns used in the production-ready system. All implementations must follow C# 6.0 constraints and SE ModAPI requirements.

## Build Order and Dependencies

### **Phase 1: Foundation Infrastructure (C# 6 Only)**

**Step 1.1: Create SE Mod Structure**
```
GRID/
├── modinfo.sbm                           # SE mod registration
├── Data/
│   ├── SessionComponents.sbc             # Session component definition  
│   └── Scripts/GRID/                     # C# 6.0 implementation
│       └── GRIDSession.cs               # Main session component
```

**modinfo.sbm** (SE Mod Registration):
```xml
<?xml version="1.0" encoding="utf-8"?>
<ModInfo xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <SteamPublishedFileId>2896187154</SteamPublishedFileId>
  <Name>GRID - Intelligent Space Engineers Automation</Name>
  <Description>Advanced AI-powered automation system for Space Engineers</Description>
  <GameVersion>01206000</GameVersion>
</ModInfo>
```

**SessionComponents.sbc** (SE Session Component Definition):
```xml
<?xml version="1.0" encoding="utf-8"?>
<Definitions xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Definition xsi:type="MyObjectBuilder_SessionComponentDefinition">
    <Id>
      <TypeId>MyObjectBuilder_SessionComponentDefinition</TypeId>
      <SubtypeId>GRIDSession</SubtypeId>
    </Id>
    <SessionComponentType>GRID.GRIDSession</SessionComponentType>
    <UpdateOrder>AfterSimulation</UpdateOrder>
    <Priority>1000</Priority>
  </Definition>
</Definitions>
```

**Step 1.2: Implement Foundation Systems**
```
Foundation/
├── ErrorHandler.cs                      # Error recovery and component isolation
├── PerformanceMonitor.cs               # Frame budget management and monitoring
└── BridgeCommunication.cs              # External application communication
```

**Critical C# 6 Pattern for ErrorHandler.cs**:
```csharp
// C# 6 compatible error handling foundation
public static class ErrorHandler
{
    private static Dictionary<string, int> _componentErrorCounts = new Dictionary<string, int>();
    private static Dictionary<string, DateTime> _lastErrorTime = new Dictionary<string, DateTime>();
    
    public static void ReportError(string component, string message, Exception exception = null, ErrorSeverity severity = ErrorSeverity.Medium)
    {
        try
        {
            var errorInfo = new ErrorInfo
            {
                Component = component ?? "Unknown",
                Message = message ?? "No message",
                Exception = exception,
                Severity = severity,
                Timestamp = DateTime.UtcNow
            };
            
            ProcessError(errorInfo);
        }
        catch (Exception ex)
        {
            MyLog.Default.WriteLine($"GRID ErrorHandler Critical Failure: {ex}");
        }
    }
}
```

### **Phase 2: Core Session Component (C# 6 Only)**

**Step 2.1: Implement GRIDSession.cs Main Component**
```csharp
[MySessionComponentDescriptor(MyUpdateOrder.AfterSimulation)]
public class GRIDSession : MySessionComponentBase
{
    private const int INITIALIZATION_DELAY_TICKS = 60; // 1 second at 60 FPS
    private const int ENTITY_PROCESSING_PER_FRAME = 50; // Performance limit
    
    private bool _isInitialized = false;
    private InitializationState _currentState = InitializationState.NotStarted;
    private readonly Dictionary<string, IGridComponent> _registeredComponents = new Dictionary<string, IGridComponent>();
    
    public override void LoadData()
    {
        try
        {
            ErrorHandler.Initialize();
            PerformanceMonitor.Initialize();
            BridgeCommunication.Initialize();
            _currentState = InitializationState.LoadingCore;
        }
        catch (Exception ex)
        {
            ErrorHandler.ReportCritical("GRIDSession", "LoadData failure", ex);
            _currentState = InitializationState.Failed;
        }
    }
    
    public override void UpdateAfterSimulation()
    {
        if (_currentState == InitializationState.Failed) return;
        
        using (PerformanceMonitor.TrackComponent("GRIDSession.UpdateAfterSimulation"))
        {
            PerformanceMonitor.BeginFrame();
            
            if (!_isInitialized)
            {
                HandleInitialization();
            }
            else
            {
                ProcessComponents();
                ProcessFrameworkTasks();
            }
            
            PerformanceMonitor.EndFrame();
        }
    }
}
```

### **Phase 3: Spatial Intelligence System (C# 6 Only)**

**Step 3.1: Implement Spatial Intelligence Components**
```
SpatialIntelligence/
├── SpatialIntelligenceCoordinator.cs   # Main spatial coordinator
├── IncrementalShipScanner.cs           # Progressive scanning system
├── ZoneDetectionSystem.cs              # Zone pattern recognition
├── SpatialTargetResolver.cs            # Query resolution system
├── BlockSpatialData.cs                 # Spatial data structures
└── SpatialQueryOptimizer.cs            # Performance optimization
```

**Critical Performance Pattern for IncrementalShipScanner.cs**:
```csharp
public class IncrementalShipScanner : IGridComponent
{
    private const int MAX_BLOCKS_PER_FRAME = 50;
    private const double MAX_FRAME_TIME_MS = 2.0;
    
    public void Update()
    {
        try
        {
            using (PerformanceMonitor.TrackComponent("IncrementalShipScanner"))
            {
                _frameStopwatch.Restart();
                _blocksProcessedThisFrame = 0;

                // Strict frame budget enforcement
                while (_blocksProcessedThisFrame < MAX_BLOCKS_PER_FRAME && 
                       _frameStopwatch.Elapsed.TotalMilliseconds < MAX_FRAME_TIME_MS &&
                       _scanQueue.Count > 0)
                {
                    ProcessScanChunk();
                    _blocksProcessedThisFrame += 10; // Process in 10-block chunks
                }
            }
        }
        catch (Exception ex)
        {
            ErrorHandler.ReportError("IncrementalShipScanner", "Scan update error", ex);
        }
    }
}
```

### **Phase 4: Structured Command Processing System (C# 6 Only)**

**Step 4.1: Implement Structured Command Processing Pipeline**
```
Core/
├── CommandProcessor.cs                 # Structured command reception from ClaudeBridge
├── CommandExecutionEngine.cs          # Command execution coordination
├── PlanValidationEngine.cs            # Safety validation
└── NeuralCoreDetector.cs              # Installation trigger system
```

**Critical C# 6 Pattern for CommandProcessor.cs**:
```csharp
public class CommandProcessor
{
    private static readonly Dictionary<string, CommandSpecification> _loadedCommands = new Dictionary<string, CommandSpecification>();
    private static readonly Dictionary<string, string> _commandIdIndex = new Dictionary<string, string>();
    
    public static CommandProcessingResult ProcessStructuredCommand(StructuredCommand command, long gridId, Vector3D? referencePosition = null)
    {
        if (!_isInitialized)
        {
            return new CommandProcessingResult
            {
                Success = false,
                Message = "Command processor not initialized"
            };
        }

        var startTime = DateTime.UtcNow;
        
        try
        {
            // Process structured command from ClaudeBridge (C# 6 compatible)
            var commandSpec = LookupCommandSpecification(command.CommandId);
            if (commandSpec == null)
            {
                return CreateFailureResult("Unknown command ID", startTime);
            }

            // Apply spatial intelligence to resolve targets
            var spatialResult = ResolveSpatialTargets(command.Target, command.SpatialContext, gridId);
            
            // Validate execution plan
            var validationResult = ValidateCommandPlan(commandSpec, spatialResult, gridId);
            if (!validationResult.IsValid)
            {
                return CreateFailureResult($"Validation failed: {validationResult.Message}", startTime);
            }
            
            return ExecuteValidatedCommand(commandSpec, spatialResult, gridId, validationResult);
        }
        catch (Exception ex)
        {
            ErrorHandler.ReportError("CommandProcessor", "Command processing error", ex);
            return CreateFailureResult($"Processing error: {ex.Message}", startTime);
        }
    }
}
```

### **Phase 5: Controller Implementation (C# 6 Only)**

**Step 5.1: Implement Controller Hierarchy**
```
Controllers/
├── CategoryControllerBase.cs           # Base controller functionality
├── UniversalController.cs             # Universal commands (17 commands)
├── PowerManagementController.cs       # Power systems (25 commands)
├── LifeSupportController.cs           # Life support (15 commands - CRITICAL)
├── AutomationController.cs            # SE automation (19 commands)
├── [24 additional specialized controllers]
```

**Critical C# 6 Pattern for Controller Implementation**:
```csharp
public class PowerManagementController : CategoryControllerBase
{
    public override bool Initialize()
    {
        if (!base.Initialize()) return false;
        
        try
        {
            ErrorHandler.ReportError("PowerManagementController", "Power controller initializing", null);
            return true;
        }
        catch (Exception ex)
        {
            ErrorHandler.ReportError("PowerManagementController", "Initialization failed", ex);
            return false;
        }
    }
    
    public bool ExecuteSetBatteryAutoCommand(string target, out string result)
    {
        result = "";
        try
        {
            var blocks = ResolvePowerBlocks(target, typeof(IMyBatteryBlock));
            var successCount = 0;
            
            foreach (var block in blocks)
            {
                var battery = block as IMyBatteryBlock;
                if (battery != null && ValidateUserAuthority(battery))
                {
                    battery.ChargeMode = ChargeMode.Auto;
                    successCount++;
                }
            }
            
            result = $"Set {successCount} battery(s) to auto mode";
            return successCount > 0;
        }
        catch (Exception ex)
        {
            result = $"Battery auto command failed: {ex.Message}";
            ErrorHandler.ReportError("PowerManagementController", "Battery auto error", ex);
            return false;
        }
    }
}
```

### **Phase 6: AI Safety Systems (C# 6 Only)**

**Step 6.1: Implement AI Safety Architecture**
```
Controllers/AI_Safety/
├── AIBlockCoordinator.cs              # Central AI management
├── AISafetyMonitor.cs                 # Real-time safety monitoring
├── EmergencyProtocols.cs              # Emergency response systems
├── ManualOverride.cs                  # Human control priority
├── AIComplianceValidator.cs           # Compliance validation
└── AIPerformanceMonitor.cs           # Performance monitoring
```

**Critical C# 6 Safety Pattern**:
```csharp
public class LifeSupportController : CategoryControllerBase
{
    public bool ExecuteDepressurizeRoomCommand(string target, out string result)
    {
        result = "";
        try
        {
            // CRITICAL SAFETY: Crew survival validation
            if (!ValidateCrewSurvivalSafety("depressurize", target, out string safetyError))
            {
                result = $"SAFETY ABORT: {safetyError}";
                return false;
            }

            // CRITICAL SAFETY: Area occupancy check
            if (!ValidateAreaUnoccupied(target, out string occupancyError))
            {
                result = $"CREW SAFETY ABORT: {occupancyError}";
                return false;
            }

            var blocks = ResolveLifeSupportBlocks(target, typeof(IMyAirVent));
            foreach (var block in blocks)
            {
                var airVent = block as IMyAirVent;
                if (airVent != null && ValidateUserAuthority(airVent))
                {
                    airVent.Depressurize = true; // Execute only after all safety checks
                }
            }
            
            return true;
        }
        catch (Exception ex)
        {
            ErrorHandler.ReportCritical("LifeSupportController", "Depressurize error", ex);
            return false;
        }
    }
}
```

## ClaudeBridge Application Implementation

### **Phase 7: External Bridge Application (.NET Framework 4.8)**

**Step 7.1: Implement Bridge Application Structure**
```
ClaudeBridge/
├── Program.cs                         # Main application loop
├── API/ClaudeAPIClient.cs            # Claude API integration
├── NLP/                              # Natural language processing
│   ├── IntentClassifier.cs           # Intent recognition
│   ├── NLPProcessor.cs               # NLP coordination
│   └── ParameterExtractor.cs         # Parameter extraction
├── Core/                             # Core integration
│   ├── EnhancedClaudeIntegration.cs  # Claude integration
│   ├── SEKnowledgeLoader.cs          # Knowledge system access
│   └── DocumentationRetriever.cs     # Documentation access
└── Communication/                     # SE mod communication
    ├── FileCommProtocol.cs           # File-based protocol
    ├── ModCommunicationManager.cs    # Legacy compatibility
    └── ErrorRecovery.cs              # Error recovery
```

**Main Application Pattern (Program.cs)**:
```csharp
class Program
{
    private static ClaudeAPIClient _claudeClient;
    private static NLPProcessor _nlpProcessor;
    private static ModCommunicationManager _modComm;
    private static bool _isRunning = false;

    static async Task Main(string[] args)
    {
        try
        {
            await InitializeSystemAsync();
            await StartMainOperationLoopAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ STARTUP FAILED: {ex.Message}");
        }
        finally
        {
            await ShutdownSystemAsync();
        }
    }
    
    private static async Task ProcessUserCommandAsync(string userInput)
    {
        // Step 1: Intent classification
        var nlpResult = await _nlpProcessor.ProcessInputAsync(userInput);
        
        // Step 2: Enhanced spatial context
        var spatialContext = await GetEnhancedSpatialContextAsync();
        
        // Step 3: Claude API processing
        var claudeResponse = await _claudeClient.ProcessRequestAsync(claudeRequest);
        
        // Step 4: Command execution
        await ExecuteCommandsAsync(claudeResponse);
    }
}
```

## SE Knowledge System Implementation

### **Phase 8: Knowledge System Setup**

**Step 8.1: Create SE Knowledge Structure**
```
se_knowledge/
├── commands/                          # 393+ command specifications
│   ├── INDEX.json                     # System metadata
│   ├── core/                          # Universal commands
│   │   ├── essential.v1.jsonl         # Core commands
│   │   └── universal.v1.jsonl         # Extended commands
│   ├── ontology/                      # Command structure
│   │   ├── verbs.v1.jsonl            # Action verbs
│   │   └── selectors.v1.jsonl        # Targeting selectors
│   └── systems/                       # 25 category-specific commands
│       ├── life_support/             # Life support commands
│       ├── power_management/         # Power commands
│       └── [23 additional categories]
├── core/                             # Fundamental mechanics
│   ├── automation.v1.jsonl           # SE automation patterns
│   ├── fundamentals.v1.jsonl         # Basic SE mechanics
│   └── spatial.v1.jsonl              # Spatial analysis
├── systems/                          # Detailed documentation
└── integration/                      # Complex workflows
    ├── airlock_protocol.v1.jsonl     # Airlock automation
    └── [8 additional workflows]
```

**Command Specification Example (JSONL Format)**:
```json
{"id": "life_support.pressurize.airvent.v1", "title": "Pressurize air vent", "category": "life_support", "verb": "pressurize", "natural_language_triggers": ["pressurize", "fill with air", "add air"], "targets": {"allowed_types": ["Air Vent"], "allowed_selectors": ["by_name", "by_zone", "all"], "multi_target": true}, "se_implementation": {"modapi_calls": [{"interface": "IMyAirVent", "property": "Depressurize", "method": "set_Depressurize(false)"}], "group_compatible": true, "timer_compatible": true}, "safety_class": "safe", "idempotent": true, "reversible": true}
```

## Component Dependency Implementation

### **Dependency Injection Patterns**

**Standard Dependency Setup (C# 6 Compatible)**:
```csharp
// Component initialization order in GRIDSession.cs
private void InitializeP2AControllers(SpatialIntelligenceCoordinator spatialIntelligence)
{
    try
    {
        // Foundation controller
        _universalController = new UniversalController();
        _universalController.Initialize();
        _universalController.SetSpatialCoordinator(spatialIntelligence);

        // Power management controller
        _powerManagementController = new PowerManagementController();
        _powerManagementController.Initialize();
        _powerManagementController.SetDependencies(spatialIntelligence, _universalController);

        // Life support controller (depends on power)
        _lifeSupportController = new LifeSupportController();
        _lifeSupportController.Initialize();
        _lifeSupportController.SetDependencies(spatialIntelligence, _universalController, _powerManagementController);

        // Continue with remaining controllers...
    }
    catch (Exception ex)
    {
        ErrorHandler.ReportError("GRIDSession", "Controller initialization error", ex);
    }
}
```

**Controller Dependency Chain**:
```
Dependency Order:
1. ErrorHandler, PerformanceMonitor (Foundation)
2. SpatialIntelligenceCoordinator (Spatial foundation)
3. UniversalController (Universal operations)
4. PowerManagementController (Power systems)
5. LifeSupportController (Safety critical - depends on power)
6. AutomationController (SE automation - depends on spatial + universal)
7. DefenseController (Defense systems - depends on life support)
8. [Remaining specialized controllers]
9. AIBlockCoordinator (AI management - depends on all safety systems)
10. AI Safety Systems (Safety overlay - depends on AI coordinator)
```

## Testing Implementation

### **Phase 9: Testing Framework Setup**

**Step 9.1: Implement Testing Components**
```
Testing/
├── PerformanceTestFramework.cs       # Performance validation
├── SafetyTestFramework.cs           # Safety validation
├── LoadTesting.cs                   # Load and stress testing
└── [13 additional testing components]
```

**Performance Test Implementation**:
```csharp
public static class PerformanceTestFramework
{
    public static bool ExecuteFrameRateTest(int testDurationSeconds)
    {
        try
        {
            var frameViolations = 0;
            var totalFrames = 0;
            var testStart = DateTime.UtcNow;
            
            while ((DateTime.UtcNow - testStart).TotalSeconds < testDurationSeconds)
            {
                var frameStart = DateTime.UtcNow;
                ProcessTestFrame();
                var frameTime = (DateTime.UtcNow - frameStart).TotalMilliseconds;
                
                totalFrames++;
                if (frameTime > 16.67) frameViolations++;
            }
            
            var passed = frameViolations == 0; // Zero tolerance for frame violations
            RecordTestResult("FrameRateTest", passed, (double)frameViolations / totalFrames);
            return passed;
        }
        catch (Exception ex)
        {
            RecordTestFailure("FrameRateTest", ex.Message);
            return false;
        }
    }
}
```

## Configuration and Deployment

### **Phase 10: Deployment Setup**

**Step 10.1: SE Mod Deployment**
```
Space Engineers Mod Deployment:
1. Copy GRID/ folder to %AppData%/SpaceEngineers/Mods/
2. Verify modinfo.sbm registration
3. Test SE mod loading in game
4. Validate session component registration
5. Test Neural Core installation trigger
```

**Step 10.2: ClaudeBridge Application Deployment**
```
ClaudeBridge Application Setup:
1. Build ClaudeBridge.csproj (Release configuration)
2. Set Claude API key: CLAUDE_API_KEY environment variable
3. Configure communication directory paths
4. Test Claude API connectivity
5. Verify file protocol communication with SE mod
```

**API Configuration Pattern**:
```csharp
private static string GetClaudeAPIKey()
{
    var apiKey = Environment.GetEnvironmentVariable("CLAUDE_API_KEY") ??
                 ConfigurationManager.AppSettings["ClaudeAPIKey"];
                 
    if (string.IsNullOrEmpty(apiKey))
    {
        throw new Exception("Claude API key not configured. Set CLAUDE_API_KEY environment variable.");
    }
    
    return apiKey;
}
```

## Validation and Testing Procedures

### **Complete System Validation**

**Step 11.1: Execute Comprehensive Testing**
```csharp
public bool ValidateCompleteSystem()
{
    var validationSteps = new[]
    {
        ("SE Mod Loading", ValidateSEModLoading),
        ("Session Component", ValidateSessionComponentRegistration),
        ("Performance Compliance", ValidatePerformanceCompliance),
        ("Safety Systems", ValidateSafetySystemsIntegrity),
        ("Bridge Communication", ValidateBridgeCommunication),
        ("Claude Integration", ValidateClaudeIntegration),
        ("End-to-End", ValidateEndToEndOperation)
    };
    
    foreach (var step in validationSteps)
    {
        var stepName = step.Item1;
        var validator = step.Item2;
        
        var passed = validator();
        if (!passed)
        {
            RecordValidationFailure(stepName);
            return false;
        }
    }
    
    return true;
}
```

**Step 11.2: Safety Validation Protocol**
```csharp
public bool ExecuteComprehensiveSafetyValidation()
{
    var safetyTests = new[]
    {
        "zero_damage_guarantee_test",
        "life_support_protection_test", 
        "emergency_response_test",
        "manual_override_priority_test",
        "ai_safety_boundary_test"
    };
    
    foreach (var test in safetyTests)
    {
        var passed = ExecuteSafetyTest(test);
        if (!passed)
        {
            RecordCriticalSafetyFailure(test);
            return false; // ZERO TOLERANCE for safety failures
        }
    }
    
    return true;
}
```

## Installation and Usage Procedures

### **User Installation Process**

**Step 12.1: End-User Installation**
```
Installation Steps:
1. Subscribe to GRID mod on Steam Workshop OR copy mod files to Mods directory
2. Download and extract ClaudeBridge application
3. Configure Claude API key in environment variables
4. Launch Space Engineers and enable GRID mod
5. Launch ClaudeBridge application
6. In SE: rename any functional block to "Neural Core"
7. GRID system will automatically install and activate
8. Begin natural language ship control via ClaudeBridge
```

**Step 12.2: System Activation Verification**
```
Verification Checklist:
□ SE mod loads without errors (check SE logs)
□ Session component registers successfully
□ Neural Core detection triggers installation
□ Ship scanning completes (progress messages in SE)
□ ClaudeBridge connects and responds
□ Test command: "turn on hangar lights"
□ Verify spatial targeting works: "lights near cockpit"
□ Test automation: "setup airlock automation"
□ Validate AI integration: "deploy autonomous mining"
```

## Troubleshooting and Common Issues

### **Implementation Issues and Solutions**

**C# 6 Compatibility Issues**:
```
Common C# 6 Violations to Avoid:
❌ out var declarations → ✅ traditional out variables
❌ pattern matching (is Type var) → ✅ as casting with null checks
❌ tuple types → ✅ traditional classes and structs
❌ local functions → ✅ private class methods
❌ throw expressions → ✅ traditional if/throw statements
❌ switch expressions → ✅ traditional switch statements
```

**SE ModAPI Compliance Issues**:
```
Prohibited Operations:
❌ GC.Collect() → ✅ Let SE manage garbage collection
❌ File.ReadAllText() → ✅ MyAPIGateway.Utilities file methods
❌ Thread.Sleep() → ✅ Frame-distributed processing
❌ Reflection → ✅ Direct interface usage
❌ unsafe code → ✅ Safe managed code only
```

**Performance Issues**:
```
Performance Violation Solutions:
• Frame drops → Reduce blocks per frame, add throttling
• Memory leaks → Use object pooling, clear collections
• Slow commands → Optimize spatial queries, cache results
• Component overload → Add component isolation and throttling
• Large ship lag → Implement scale-independent processing
```

## Build Validation Checklist

### **Complete Implementation Validation**

```
Implementation Validation Checklist:
□ All code uses C# 6.0 syntax only
□ SE ModAPI constraints followed (no prohibited operations)
□ Frame budget enforced (≤50 blocks per frame)
□ Performance monitoring integrated throughout
□ Error handling implemented for all components
□ Safety validation implemented for all operations
□ Component dependencies properly configured
□ Testing framework validates all requirements
□ Bridge application communicates correctly
□ SE knowledge system loads completely
□ AI safety systems provide comprehensive oversight
□ Manual override works under all conditions
□ Zero damage guarantee validated through testing
□ Complete end-to-end system validation passes
```

This implementation guide provides the complete roadmap for building the GRID system from scratch while maintaining all safety standards, performance guarantees, and architectural patterns used in the production-ready implementation.
