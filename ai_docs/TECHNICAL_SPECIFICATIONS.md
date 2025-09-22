# GRID Technical Specifications - C# 6 and SE ModAPI Constraints

## CRITICAL: C# 6.0 Language Constraints

### **Mandatory Language Limitations**

**PROHIBITED C# 7+ Features (NEVER USE)**:
```csharp
// ❌ PROHIBITED - Out variable declarations
if (int.TryParse(input, out var number))  // ❌ C# 7+

// ✅ REQUIRED - Traditional out variables  
int number;
if (int.TryParse(input, out number))      // ✅ C# 6

// ❌ PROHIBITED - Pattern matching
if (block is IMyReactor reactor)          // ❌ C# 7+

// ✅ REQUIRED - Traditional casting
var reactor = block as IMyReactor;        // ✅ C# 6
if (reactor != null)

// ❌ PROHIBITED - Tuple types
(string name, int count) GetData()        // ❌ C# 7+

// ✅ REQUIRED - Traditional classes/structs
public class ResultData                   // ✅ C# 6
{
    public string Name { get; set; }
    public int Count { get; set; }
}

// ❌ PROHIBITED - Local functions
void Method()
{
    void LocalFunction() { }              // ❌ C# 7+
}

// ✅ REQUIRED - Private class methods
private void HelperMethod() { }           // ✅ C# 6

// ❌ PROHIBITED - Throw expressions
var result = value ?? throw new Exception(); // ❌ C# 7+

// ✅ REQUIRED - Traditional throw statements
if (value == null)                        // ✅ C# 6
    throw new Exception();
var result = value;
```

### **Mandatory C# 6 Patterns Used Throughout GRID**

**Safe LINQ Operations**:
```csharp
// ✅ C# 6 Safe LINQ patterns used in GRID
var results = blocks.Where(b => b.IsWorking)
                   .Select(b => b.EntityId)
                   .First();

var filteredBlocks = allBlocks
    .Where(block => block.BlockType == "Reactor")
    .ToList();

// Basic enumeration patterns
foreach (var block in blocks)
{
    if (block is IMyFunctionalBlock)
    {
        var functionalBlock = block as IMyFunctionalBlock;
        functionalBlock.Enabled = true;
    }
}
```

**Traditional Control Flow**:
```csharp
// ✅ Traditional switch statements (not switch expressions)
switch (command.Category.ToLowerInvariant())
{
    case "universal":
        return ExecuteUniversalCommand(command, spatialResult, gridId, taskId, startTime);
    case "life_support":
        return ExecuteLifeSupportCommand(command, spatialResult, gridId, taskId, startTime);
    default:
        return ExecuteGenericCommand(command, spatialResult, gridId, taskId, startTime);
}

// ✅ Traditional if statements with explicit conditions
if (string.IsNullOrEmpty(target))
{
    result = "Target cannot be empty";
    return false;
}
```

**Safe Type Declarations**:
```csharp
// ✅ Explicit type declarations
Dictionary<string, CommandSpecification> loadedCommands = new Dictionary<string, CommandSpecification>();
List<IMyTerminalBlock> blocks = new List<IMyTerminalBlock>();

// ✅ Traditional nullable handling
Vector3D? referencePosition = null;
if (referencePosition.HasValue)
{
    var position = referencePosition.Value;
}
```

## Space Engineers ModAPI Constraints

### **PROHIBITED Operations (NEVER USE)**

**Garbage Collection Control**:
```csharp
// ❌ PROHIBITED
GC.Collect();
GC.WaitForPendingFinalizers();
GC.SuppressFinalize(this);
```

**File System Access**:
```csharp
// ❌ PROHIBITED  
File.ReadAllText(path);
File.WriteAllText(path, content);
Directory.GetFiles(path);

// ✅ REQUIRED - SE ModAPI file access only
MyAPIGateway.Utilities.ReadFileInLocalStorage(fileName, typeof(GRIDSession));
MyAPIGateway.Utilities.WriteFileInLocalStorage(fileName, content, typeof(GRIDSession));
```

**Reflection Operations**:
```csharp
// ❌ PROHIBITED
Type.GetType(typeName);
PropertyInfo.GetValue(obj);
MethodInfo.Invoke(obj, parameters);

// ✅ REQUIRED - Direct interface usage
var functionalBlock = block as IMyFunctionalBlock;
if (functionalBlock != null)
{
    functionalBlock.Enabled = true;
}
```

**Threading and Tasks**:
```csharp
// ❌ PROHIBITED
Thread.Sleep(1000);
Task.Run(() => DoWork());
async Task Method();
ThreadPool.QueueUserWorkItem(callback);

// ✅ REQUIRED - Frame-distributed processing
private void ProcessInFrames()
{
    var processedThisFrame = 0;
    while (processedThisFrame < MAX_PER_FRAME && queue.Count > 0)
    {
        ProcessSingleItem(queue.Dequeue());
        processedThisFrame++;
    }
}
```

**Environment Access**:
```csharp
// ❌ PROHIBITED
Environment.CurrentDirectory;
Environment.GetFolderPath(specialFolder);
Process.Start(fileName);
```

### **SE ModAPI Safe Patterns Used in GRID**

**Entity Access**:
```csharp
// ✅ SE ModAPI entity patterns
MyAPIGateway.Entities.GetEntitiesOfType<IMyCubeGrid>(grids);
MyAPIGateway.Entities.GetEntityById(entityId);

// Block enumeration
var blocks = new HashSet<IMySlimBlock>();
grid.GetBlocks(blocks, (block) => block.CubeBlock is IMyTerminalBlock);
```

**User Interface Integration**:
```csharp
// ✅ SE ModAPI UI patterns  
MyAPIGateway.Utilities.ShowMessage("GRID", "System ready");
MyAPIGateway.Utilities.ShowMessageToUsersInRange(500, "GRID", "Fleet operation active");

// Logging
MyLog.Default.WriteLine($"GRID: {message}");
ErrorHandler.ReportError(component, message, ex, severity);
```

**Block Control Patterns**:
```csharp
// ✅ SE ModAPI block control
var functionalBlock = block as IMyFunctionalBlock;
if (functionalBlock != null)
{
    functionalBlock.Enabled = true;
}

var battery = block as IMyBatteryBlock;
if (battery != null)
{
    battery.ChargeMode = Sandbox.ModAPI.Ingame.ChargeMode.Auto;
}

var airVent = block as IMyAirVent;
if (airVent != null)
{
    airVent.Depressurize = false; // Pressurize mode
}
```

## Performance Requirements

### **Frame Budget Constraints**

**Absolute Performance Limits**:
```csharp
// MANDATORY: 50 blocks per frame maximum
private const int MAX_BLOCKS_PER_FRAME = 50;
private const double MAX_FRAME_TIME_MS = 16.67; // 60 FPS target
private const int ENTITY_PROCESSING_PER_FRAME = 50;

// Frame budget enforcement pattern used throughout GRID
private void ProcessWithFrameBudget()
{
    var processedThisFrame = 0;
    var frameStopwatch = System.Diagnostics.Stopwatch.StartNew();
    
    while (processedThisFrame < MAX_BLOCKS_PER_FRAME && 
           frameStopwatch.Elapsed.TotalMilliseconds < 2.0 &&
           queue.Count > 0)
    {
        ProcessSingleBlock(queue.Dequeue());
        processedThisFrame++;
    }
}
```

**Memory Management Patterns**:
```csharp
// ✅ SE-safe memory patterns used in GRID
private readonly Dictionary<long, GridScanState> _activeScans = new Dictionary<long, GridScanState>();
private readonly Queue<CommandRequest> _commandQueue = new Queue<CommandRequest>();
private readonly HashSet<long> _trackedEntities = new HashSet<long>();

// Object reuse patterns
private readonly StringBuilder _stringBuilder = new StringBuilder(); // Reused for string building
private readonly List<IMyTerminalBlock> _reusableBlockList = new List<IMyTerminalBlock>(); // Cleared and reused
```

### **SE Session Component Requirements**

**Registration Pattern**:
```csharp
// ✅ Correct SE session component pattern
[MySessionComponentDescriptor(MyUpdateOrder.AfterSimulation)]
public class GRIDSession : MySessionComponentBase
{
    public override void LoadData() { }
    public override void Init(MyObjectBuilder_SessionComponent sessionComponent) { }
    public override void UpdateAfterSimulation() { }
    protected override void UnloadData() { }
}
```

**File Structure Requirements**:
```
GRID/
├── modinfo.sbm                           # SE mod registration
├── Data/
│   ├── SessionComponents.sbc             # Session component definition
│   └── Scripts/GRID/                     # C# 6 implementation files
│       ├── GRIDSession.cs               # Main session component
│       └── [All other .cs files]        # C# 6.0 syntax only
```

## Authority and Safety Validation

### **User Authority Patterns**

**Authority Validation Used Throughout GRID**:
```csharp
// ✅ SE-safe authority checking pattern
protected bool ValidateUserAuthority(IMyTerminalBlock block)
{
    try
    {
        if (MyAPIGateway.Session?.Player != null)
        {
            var playerId = MyAPIGateway.Session.Player.IdentityId;
            
            if (block.OwnerId == 0 || block.OwnerId == playerId)
                return true;

            var relation = block.GetPlayerRelationToOwner();
            return relation == MyRelationsBetweenPlayerAndBlock.Owner ||
                   relation == MyRelationsBetweenPlayerAndBlock.FactionShare;
        }

        return true;
    }
    catch (Exception ex)
    {
        ErrorHandler.ReportError(ComponentName, "Authority validation error", ex);
        return false; // Fail-safe: deny on error
    }
}
```

### **Safety Validation Requirements**

**GRID Safety Patterns**:
```csharp
// ✅ Life support safety validation (most critical)
public bool ExecuteDepressurizeRoomCommand(string target, out string result)
{
    result = "";
    
    // CRITICAL SAFETY: Pre-operation crew survival check
    if (!ValidateCrewSurvivalSafety("depressurize", target, out string safetyError))
    {
        result = $"SAFETY ABORT: {safetyError}";
        return false;
    }

    // CRITICAL SAFETY: Never allow depressurization of occupied areas
    if (!ValidateAreaUnoccupied(target, out string occupancyError))
    {
        result = $"CREW SAFETY ABORT: {occupancyError}";
        return false;
    }

    // Only execute after ALL safety checks pass
    airVent.Depressurize = true;
}
```

## SE ModAPI Interface Coverage

### **Block Interface Patterns**

**All GRID Controllers Use These C# 6 Patterns**:
```csharp
// ✅ Basic functional block control
var functionalBlock = block as IMyFunctionalBlock;
if (functionalBlock != null)
{
    functionalBlock.Enabled = true;
}

// ✅ Specialized block interfaces
var battery = block as IMyBatteryBlock;
if (battery != null)
{
    battery.ChargeMode = Sandbox.ModAPI.Ingame.ChargeMode.Auto;
}

var reactor = block as IMyReactor;
if (reactor != null)
{
    reactor.GetProperty("PowerOutput").AsFloat().SetValue(0.8f);
}

var airVent = block as IMyAirVent;
if (airVent != null)
{
    airVent.Depressurize = false;
}

var thruster = block as IMyThrust;
if (thruster != null)
{
    thruster.ThrustOverridePercentage = 0.75f;
}
```

### **Group and Automation Integration**

**SE Automation Patterns**:
```csharp
// ✅ SE Group management (C# 6 safe)
var gridTerminalSystem = blocks[0].CubeGrid.GridTerminalSystem;
var newGroup = gridTerminalSystem.CreateGroup(groupName);
foreach (var block in blocksToGroup)
{
    newGroup.AddBlock(block);
}

// ✅ Timer Block sequences
var timer = block as IMyTimerBlock;
if (timer != null)
{
    timer.TriggerDelay = delaySeconds;
    timer.Start();
}

// ✅ Event Controller setup
var eventController = block as IMyEventControllerBlock;
if (eventController != null)
{
    eventController.IsLogicRunning = true;
}
```

## Performance Standards

### **Response Time Requirements**

**Guaranteed Performance Targets**:
- **Simple Commands**: <1.0s total response time
- **Complex Commands**: <1.2s total response time  
- **Spatial Queries**: <100ms proximity analysis
- **Plan Validation**: <200ms constraint checking
- **Installation Scanning**: 50 blocks per frame maximum

### **Frame Rate Guarantees**

**Zero Freeze Architecture**:
```csharp
// ✅ Frame budget enforcement pattern used throughout GRID
public void UpdateAfterSimulation()
{
    using (PerformanceMonitor.TrackComponent("GRIDSession.UpdateAfterSimulation"))
    {
        PerformanceMonitor.BeginFrame();
        
        // Distributed processing - never exceed frame budget
        ProcessEntityEvents();          // ≤25 entities per frame
        ProcessComponents();           // Distributed component updates
        ProcessFrameworkTasks();       // Background maintenance
        
        PerformanceMonitor.EndFrame();
        
        // Emergency throttling if needed
        if (PerformanceMonitor.IsThrottlingRequired())
        {
            HandlePerformanceThrottling();
        }
    }
}
```

**Memory Management Requirements**:
```csharp
// ✅ SE-safe memory patterns used in GRID
private readonly StringBuilder _reusableStringBuilder = new StringBuilder();
private readonly List<IMyTerminalBlock> _reusableBlockList = new List<IMyTerminalBlock>();

// Cleanup patterns
public void PerformCleanup()
{
    _reusableBlockList.Clear();
    _reusableStringBuilder.Clear();
    
    // Remove expired cache entries
    var expiredKeys = _cache.Where(kvp => kvp.Value.IsExpired).Select(kvp => kvp.Key).ToList();
    foreach (var key in expiredKeys)
    {
        _cache.Remove(key);
    }
}
```

## Safety Standards

### **Zero Damage Guarantee**

**Comprehensive Safety Validation**:
```csharp
// ✅ Safety validation pattern used in all GRID controllers
public bool ValidateOperationSafety(IMyTerminalBlock block, string operation)
{
    // 1. Block state validation
    if (block.CubeGrid?.Physics == null || !block.IsWorking)
    {
        return false; // Block damaged or non-functional
    }
    
    // 2. Power availability check
    var functionalBlock = block as IMyFunctionalBlock;
    if (functionalBlock != null && !functionalBlock.IsPowered)
    {
        return false; // Block has no power
    }
    
    // 3. Critical system protection
    if (IsCriticalBlock(block) && operation == "disable")
    {
        return false; // Never disable critical systems
    }
    
    return true;
}
```

### **Life Support Priority System**

**Critical Safety Implementation**:
```csharp
// ✅ Life support safety pattern used in LifeSupportController
private bool ValidateCrewSurvivalSafety(string operation, string target, out string safetyError)
{
    safetyError = "";
    
    // CRITICAL: Never compromise crew survival
    if (operation == "depressurize")
    {
        // Multiple safety checks before allowing depressurization
        if (!CheckForCrewInArea(target))
        {
            safetyError = "Crew detected in target area";
            return false;
        }
        
        if (!CheckAlternativeLifeSupport(target))
        {
            safetyError = "No alternative life support available";
            return false;
        }
    }
    
    return true;
}
```

## SE ModAPI Integration Requirements

### **Session Component Lifecycle**

**Mandatory SE Patterns**:
```csharp
// ✅ Correct SE session component lifecycle
public override void LoadData()
{
    // Initialize foundation systems only
    ErrorHandler.Initialize();
    PerformanceMonitor.Initialize();
    BridgeCommunication.Initialize();
}

public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
{
    // SE environment validation and event registration
    if (!ValidateSEEnvironment()) return;
    
    MyAPIGateway.Entities.OnEntityAdd += OnEntityAdded;
    MyAPIGateway.Entities.OnEntityRemove += OnEntityRemoved;
}

public override void UpdateAfterSimulation()
{
    // Main processing loop with frame budget enforcement
    if (_isShuttingDown) return;
    
    // Process with strict performance limits
}

protected override void UnloadData()
{
    // Clean shutdown in reverse order
    ShutdownComponents();
    MyAPIGateway.Entities.OnEntityAdd -= OnEntityAdded;
    MyAPIGateway.Entities.OnEntityRemove -= OnEntityRemoved;
}
```

### **Block Interface Requirements**

**385+ ModAPI Interfaces Covered**:
```csharp
// ✅ Complete interface coverage patterns used in GRID
IMyFunctionalBlock      // Universal enable/disable
IMyTerminalBlock        // Name, ownership, properties
IMyAirVent             // Life support - pressurize/depressurize  
IMyBatteryBlock        // Power - charge modes
IMyReactor             // Power - output control
IMyThrust              // Propulsion - thrust override
IMyGyroscope           // Flight - gyro override
IMyDoor                // Access - open/close
IMyLightingBlock       // Lighting - intensity control
IMyConveyor            // Logistics - conveyor control
IMyCargoContainer      // Storage - inventory access
IMyAssembler           // Production - manufacturing
IMyRefinery            // Production - ore processing
IMyShipWelder          // Construction - automated building
IMyShipGrinder         // Construction - automated demolition
IMyShipDrill           // Mining - automated drilling
IMyTimerBlock          // Automation - timer sequences
IMyEventControllerBlock // Automation - conditional logic
IMyBlockGroup          // Automation - group operations
// [370+ additional interfaces systematically implemented]
```

## Component Architecture Standards

### **IGridComponent Interface Pattern**

**Standard Component Implementation**:
```csharp
// ✅ Pattern used by all 28+ GRID components
public interface IGridComponent
{
    bool Initialize();
    void Update();
    void Shutdown();
}

// ✅ Standard controller implementation pattern
public class ExampleController : CategoryControllerBase
{
    public override string ComponentName => "ExampleController";
    
    public override bool Initialize()
    {
        if (!base.Initialize()) return false;
        
        try
        {
            // Component-specific initialization
            return true;
        }
        catch (Exception ex)
        {
            ErrorHandler.ReportError(ComponentName, "Initialization failed", ex);
            return false;
        }
    }
    
    public override void Update()
    {
        if (!IsInitialized || !IsEnabled) return;
        
        base.Update();
        // Component-specific update logic
    }
}
```

### **Dependency Injection Pattern**

**Controller Dependency Management**:
```csharp
// ✅ Dependency injection pattern used throughout GRID
public void SetDependencies(SpatialIntelligenceCoordinator spatialCoordinator, 
                           UniversalController universalController)
{
    SpatialCoordinator = spatialCoordinator ?? throw new ArgumentNullException(nameof(spatialCoordinator));
    UniversalController = universalController ?? throw new ArgumentNullException(nameof(universalController));
}

// Enhanced dependencies for specialized controllers
public void SetDependencies(SpatialIntelligenceCoordinator spatialCoordinator, 
                           UniversalController universalController, 
                           PowerManagementController powerController)
{
    SetDependencies(spatialCoordinator, universalController);
    PowerController = powerController ?? throw new ArgumentNullException(nameof(powerController));
}
```

## Error Handling Standards

### **Comprehensive Error Recovery**

**Error Handling Pattern Used Throughout GRID**:
```csharp
// ✅ Standard error handling pattern
public bool ExecuteOperation(string target, out string result)
{
    result = "";
    try
    {
        // Operation implementation
        var success = DoOperation();
        if (success)
        {
            result = "Operation completed successfully";
            return true;
        }
        else
        {
            result = "Operation failed";
            return false;
        }
    }
    catch (Exception ex)
    {
        result = $"Operation failed: {ex.Message}";
        ErrorHandler.ReportError(ComponentName, "Operation error", ex, ErrorHandler.ErrorSeverity.Medium);
        return false;
    }
}
```

**Component Isolation Pattern**:
```csharp
// ✅ Component isolation used in GRIDSession
foreach (var component in _registeredComponents.Values)
{
    if (!ErrorHandler.IsComponentIsolated(component.GetType().Name))
    {
        try
        {
            component.Update();
        }
        catch (Exception ex)
        {
            ErrorHandler.ReportError("GRIDSession", 
                $"Component {component.GetType().Name} update failed", ex);
            // Component isolated but system continues
        }
    }
}
```

## Validation Standards

### **Pre-Execution Validation**

**Complete Validation Chain**:
```csharp
// ✅ Validation chain used in CommandExecutionEngine
public static ExecutionResult ExecuteCommand(CommandSpecification command, 
    SpatialQueryResult spatialResult, long gridId, ValidationResult validationResult)
{
    // 1. Verify validation passed
    if (!validationResult.IsValid)
    {
        return CreateFailureResult("Command failed validation - execution blocked");
    }
    
    // 2. Authority validation
    if (!ValidateUserAuthority(block))
    {
        return CreateFailureResult("Insufficient authority");
    }
    
    // 3. Block state validation  
    if (!ValidateBlockState(block))
    {
        return CreateFailureResult("Block not operational");
    }
    
    // 4. Safety validation
    if (!ValidateOperationSafety(block, command))
    {
        return CreateFailureResult("Safety validation failed");
    }
    
    // 5. Execute only after all validations pass
    return ExecuteValidatedOperation(command, spatialResult);
}
```

This technical specification ensures that any rebuild of the GRID system follows the exact same C# 6.0 and SE ModAPI constraints that the current production-ready implementation uses, maintaining compatibility and safety standards.
