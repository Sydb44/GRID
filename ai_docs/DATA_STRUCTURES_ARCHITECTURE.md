# GRID Data Structures Architecture - Core System Data Models

## Overview

GRID implements comprehensive data structures supporting command processing, spatial intelligence, safety validation, and AI coordination. All structures follow C# 6.0 patterns and are optimized for Space Engineers ModAPI constraints and performance requirements.

## Command Processing Data Structures

### **Command Specification System**

**CommandSpecification - Complete Command Definition**:
```csharp
public class CommandSpecification
{
    public string Id { get; set; }                        // Unique command identifier
    public string Title { get; set; }                     // Human-readable title
    public string Category { get; set; }                  // SE system category
    public string Verb { get; set; }                      // Action verb
    public string[] NaturalLanguageTriggers { get; set; } // Recognition patterns
    public TargetSpecification Targets { get; set; }      // Targeting specification
    public ParameterSpecification[] Parameters { get; set; } // Parameter definitions
    public SEImplementation SeImplementation { get; set; } // SE ModAPI mapping
    public string[] Preconditions { get; set; }          // Pre-execution requirements
    public string[] Effects { get; set; }                // Operation effects
    public ConstraintSpecification Constraints { get; set; } // Execution constraints
    public string[] ValidationHooks { get; set; }        // Validation methods
    public ErrorCase[] ErrorCases { get; set; }          // Error handling
    public string SafetyClass { get; set; }              // Safety classification
    public bool Idempotent { get; set; }                 // Repeatability
    public bool Reversible { get; set; }                 // Undo capability
    public string[] Tags { get; set; }                   // Classification tags
}
```

**Target and Parameter Specifications**:
```csharp
public class TargetSpecification
{
    public string[] AllowedTypes { get; set; }           // SE block types
    public string[] AllowedSelectors { get; set; }      // Selection methods
    public string[] GridScope { get; set; }             // Grid scope options
    public bool MultiTarget { get; set; }               // Multiple target support
    public string TargetValidation { get; set; }        // Validation requirement
}

public class ParameterSpecification
{
    public string Name { get; set; }                    // Parameter name
    public string Type { get; set; }                    // Data type
    public bool Required { get; set; }                  // Required flag
    public object DefaultValue { get; set; }            // Default value
    public string[] AllowedValues { get; set; }         // Enum values
    public ValidationRule[] ValidationRules { get; set; } // Validation rules
}

public class SEImplementation
{
    public string[] ToolbarActions { get; set; }        // SE toolbar actions
    public string[] TerminalPath { get; set; }          // Terminal navigation
    public ModApiCall[] ModApiCalls { get; set; }       // Direct ModAPI calls
    public bool GroupCompatible { get; set; }           // SE Group support
    public bool TimerCompatible { get; set; }           // Timer Block support
    public bool EventControllerCompatible { get; set; } // Event Controller support
}
```

### **Command Processing Results**

**CommandProcessingResult - Complete Processing Outcome**:
```csharp
public class CommandProcessingResult
{
    public bool Success { get; set; }                    // Overall success
    public string Message { get; set; }                  // Result message
    public CommandSpecification[] MatchedCommands { get; set; } // Matched commands
    public SpatialQueryResult SpatialResult { get; set; } // Spatial resolution
    public ValidationResult ValidationResult { get; set; } // Safety validation
    public string[] Warnings { get; set; }              // Warning messages
    public double ProcessingTimeMs { get; set; }        // Processing time
    public CommandExecutionEngine.ExecutionResult[] ExecutionResults { get; set; } // Execution outcomes
}

public class ExecutionResult
{
    public string TaskId { get; set; }                  // Unique task identifier
    public bool Success { get; set; }                   // Execution success
    public string Message { get; set; }                 // Result message
    public DateTime ExecutionTime { get; set; }         // Execution timestamp
    public double ExecutionDurationMs { get; set; }     // Execution duration
    public string[] AffectedBlocks { get; set; }        // Affected blocks
    public string ErrorDetails { get; set; }            // Error information
}
```

## Spatial Intelligence Data Structures

### **Block Spatial Data System**

**BlockSpatialData - Comprehensive Block Information**:
```csharp
public class BlockSpatialData
{
    // Core identification
    public long EntityId { get; private set; }          // SE block entity ID
    public string BlockType { get; private set; }       // Block type name
    public string BlockSubtype { get; private set; }    // Block subtype ID
    public string DisplayName { get; private set; }     // SE display name
    public string CustomName { get; private set; }      // User-assigned name
    public IMyCubeBlock Block { get; private set; }     // SE block reference
    public IMyCubeGrid Grid { get; private set; }       // Parent grid reference

    // Spatial positioning
    public Vector3I GridPosition { get; private set; }  // SE grid coordinates
    public Vector3D WorldPosition { get; private set; } // World space coordinates
    public double DistanceFromGridCenter { get; private set; } // Distance from ship center

    // Spatial relationships
    public readonly HashSet<long> AdjacentBlockIds = new HashSet<long>(); // Touching blocks
    public readonly Dictionary<long, double> ProximityBlocks = new Dictionary<long, double>(); // Nearby blocks
    public readonly List<ZoneClassification> ZoneClassifications = new List<ZoneClassification>(); // Zone assignments
    public ZoneClassification PrimaryZone { get; private set; } // Primary zone assignment

    // Block capabilities
    public readonly HashSet<BlockCapability> Capabilities = new HashSet<BlockCapability>(); // Automation capabilities
    public bool IsAutomationCapable { get; private set; } // Automation support
    public bool IsControllable { get; private set; }    // Control capability
    public bool IsFunctional { get; private set; }      // Functional status
    public bool IsWorking { get; private set; }         // Working status
    public bool HasPower { get; private set; }          // Power status
}
```

**Zone Classification System**:
```csharp
public class ZoneClassification
{
    public ZoneType Type { get; set; }                  // Bridge, Engineering, Hangar, etc.
    public string ZoneName { get; set; }               // "Main Hangar", "Engine Room 1"
    public double Confidence { get; set; }             // 0.0-1.0 confidence score
    public Vector3I ZoneCenter { get; set; }           // Calculated zone center
    public BoundingBoxI ZoneBounds { get; set; }       // Zone spatial bounds
    public string[] Evidence { get; set; }             // Classification evidence
    public int BlocksInZone { get; set; }              // Total blocks in zone
    public DateTime LastUpdate { get; set; }           // Last classification update
}

public enum ZoneType
{
    Bridge,          // Command and control areas
    Engineering,     // Power generation systems
    Hangar,         // Docking and storage areas
    Cargo,          // Storage and logistics
    Airlock,        // Entry/exit chambers
    LifeSupport,    // Medical and oxygen systems
    Defense,        // Weapon platforms
    Production,     // Manufacturing areas
    Unknown         // Unclassified areas
}

public enum BlockCapability
{
    DoorControl,         // IMyDoor operations
    LightControl,        // IMyLightingBlock operations
    LifeSupport,         // IMyAirVent, oxygen systems
    PowerGeneration,     // IMyReactor, IMyBatteryBlock
    Propulsion,         // IMyThrust, IMyGyro
    FlightControl,      // Gyroscopes, autopilot
    Defense,            // Weapons, turrets
    Logistics,          // Conveyors, containers
    Production,         // Assemblers, refineries
    Construction,       // Welders, grinders, drills
    Mechanical,         // Pistons, rotors
    Information,        // LCD panels, displays
    Communication,      // Antennas, sensors
    AIControl,          // AI blocks
    EventControl        // Timers, event controllers
}
```

### **Spatial Query System**

**SpatialQueryResult - Query Resolution Results**:
```csharp
public class SpatialQueryResult
{
    public string OriginalQuery { get; set; }           // Original query string
    public SpatialQueryStatus Status { get; set; }      // Query execution status
    public string Message { get; set; }                 // Result message
    public BlockSpatialData[] ResolvedBlocks { get; set; } // Resolved target blocks
    public string[] AlternativeSuggestions { get; set; } // Alternative suggestions
    public double ProcessingTimeMs { get; set; }        // Query processing time
    public string QueryType { get; set; }               // Query classification
    public Vector3D? ReferencePosition { get; set; }    // Reference position used
    public ZoneAnalysisResult ZoneContext { get; set; } // Zone context
}

public enum SpatialQueryStatus
{
    Success,            // Query resolved successfully
    NoResults,          // No matching blocks found
    Ambiguous,          // Multiple interpretations possible
    InvalidQuery,       // Query format invalid
    GridNotFound,       // Target grid not found
    QueryError,         // Query processing error
    UnsupportedQuery    // Query type not supported
}
```

**Spatial Relationship Mapping**:
```csharp
public class SpatialRelationshipMap
{
    public long GridId { get; set; }                    // Grid identifier
    public Dictionary<long, List<long>> AdjacencyMap { get; set; } // Block → Adjacent blocks
    public Dictionary<long, Dictionary<long, double>> ProximityMap { get; set; } // Block → Distance map
    public Dictionary<string, ZoneConnectivity> ZoneConnections { get; set; } // Zone relationships
    public Dictionary<string, List<long>> ZoneBlocks { get; set; } // Zone → Contained blocks
    public List<SpatialCluster> Clusters { get; set; } // Block clusters
    public DateTime LastUpdate { get; set; }           // Last relationship update
    public int TotalRelationships { get; set; }        // Total relationship count
}

public class ZoneConnectivity
{
    public string ZoneName { get; set; }               // Zone name
    public List<string> ConnectedZones { get; set; }   // Connected zones
    public Dictionary<string, double> ConnectionDistances { get; set; } // Connection distances
    public List<Vector3I> ConnectionPoints { get; set; } // Physical connection points
    public bool IsAccessible { get; set; }             // Accessibility status
}
```

## Safety and Validation Data Structures

### **Plan Validation System**

**ValidationResult - Safety Validation Outcome**:
```csharp
public class ValidationResult
{
    public bool IsValid { get; set; }                   // Overall validation result
    public string Message { get; set; }                 // Validation message
    public string[] Warnings { get; set; }              // Warning messages
    public string ValidationLevel { get; set; }         // Validation thoroughness
    public double ValidationTimeMs { get; set; }        // Validation processing time
    public string[] FailedChecks { get; set; }          // Failed validation checks
    public ValidationSeverity HighestSeverity { get; set; } // Highest severity level
    public Dictionary<string, bool> ValidationChecks { get; set; } // Individual check results
}

public enum ValidationSeverity
{
    Info,              // Information only
    Warning,           // Proceed with caution
    Error,            // Operation failed
    Critical,         // High-priority failure
    SafetyBlocking    // NEVER execute - safety violation
}
```

**Grid Validation Context**:
```csharp
public class GridValidationContext
{
    public long GridId { get; set; }                    // Grid identifier
    public DateTime LastUpdate { get; set; }            // Last context update
    public List<IMyTerminalBlock> CriticalSystems { get; set; } // Critical blocks
    public List<IMyTerminalBlock> LifeSupportSystems { get; set; } // Life support blocks
    public List<IMyTerminalBlock> PowerSystems { get; set; } // Power generation blocks
    public double TotalPowerCapacityMW { get; set; }    // Total power capacity
    public double CurrentPowerUsageMW { get; set; }     // Current power usage
    public bool HasLifeSupport { get; set; }           // Life support availability
    public bool IsAirtightIntact { get; set; }         // Airtight integrity
    public Vector3D GridCenter { get; set; }           // Grid center position
    public BoundingBoxD GridBounds { get; set; }       // Grid bounding box
    public Dictionary<string, int> BlockCounts { get; set; } // Block type counts
}
```

## AI Safety Data Structures

### **AI Safety Monitoring System**

**AISafetyProfile - Comprehensive AI Safety Tracking**:
```csharp
public class AISafetyProfile
{
    public long AIBlockId;                              // AI block identifier
    public string AIBlockName;                          // AI block name
    public AIBlockType BlockType;                       // AI block type
    public AISafetyStatus SafetyStatus;                 // Current safety status
    public DateTime LastSafetyCheck;                    // Last safety validation
    public DateTime LastAnomalyDetection;               // Last anomaly check
    public List<SafetyViolation> ViolationHistory;     // Safety violation history
    public Dictionary<string, double> SafetyMetrics;   // Safety measurement metrics
    public AIBehaviorBaseline BehaviorBaseline;         // Normal behavior baseline
    public double SafetyScore;                          // 0.0-1.0 safety score
    public int ConsecutiveViolations;                   // Consecutive violation count
    public bool IsUnderSafetyReview;                    // Review status
    public DateTime SafetyProfileCreated;               // Profile creation time
}

public enum AISafetyStatus
{
    Safe,               // AI operating within all safety parameters
    Warning,            // Minor safety concerns detected
    Critical,           // Serious safety violations detected
    Emergency,          // Emergency intervention required
    Suspended           // AI operations suspended for safety
}

public class SafetyViolation
{
    public string ViolationId;                          // Unique violation identifier
    public long AIBlockId;                              // Affected AI block
    public AnomalyType ViolationType;                   // Type of violation
    public string Description;                          // Violation description
    public DateTime DetectionTime;                      // When detected
    public double SeverityLevel;                        // 0.0-1.0 severity
    public bool IsResolved;                            // Resolution status
    public string ResolutionAction;                    // Resolution taken
    public TimeSpan ResponseTime;                      // Response time
}
```

**AI Behavior Analysis**:
```csharp
public class AIBehaviorAnalysis
{
    public long AIBlockId;                              // AI block identifier
    public Queue<BehaviorSnapshot> BehaviorHistory;     // Behavior history queue
    public Dictionary<string, double> BehaviorMetrics; // Behavior measurements
    public AIBehaviorPattern CurrentPattern;            // Current behavior pattern
    public DateTime LastBehaviorUpdate;                 // Last behavior update
    public double BehaviorStability;                    // Behavior stability score
    public double DecisionQuality;                      // Decision quality score
    public double ResourceEfficiency;                   // Resource usage efficiency
    public List<BehaviorAnomaly> DetectedAnomalies;    // Detected anomalies
}

public class BehaviorSnapshot
{
    public DateTime Timestamp;                          // Snapshot timestamp
    public Vector3D Position;                          // AI block position
    public Vector3D Velocity;                          // AI block velocity
    public double PowerConsumption;                     // Power usage
    public string CurrentTask;                          // Current AI task
    public Dictionary<string, object> AIState;         // AI state data
    public double PerformanceMetric;                    // Performance measurement
    public bool WasDecisionMade;                       // Decision made flag
    public string DecisionContext;                      // Decision context
}
```

## Communication Data Structures

### **Bridge Communication Protocol**

**Command Request/Response System**:
```csharp
public class CommandRequest
{
    public string RequestId { get; set; }               // Unique request identifier
    public CommandType Type { get; set; }               // Command type
    public string Command { get; set; }                 // Command string
    public Dictionary<string, object> Parameters { get; set; } // Command parameters
    public DateTime Timestamp { get; set; }             // Request timestamp
    public string Source { get; set; }                  // Request source
    public int Priority { get; set; }                   // Request priority
}

public class CommandResponse
{
    public string RequestId { get; set; }               // Matching request identifier
    public bool Success { get; set; }                   // Execution success
    public Dictionary<string, object> Result { get; set; } // Execution results
    public ErrorType ErrorType { get; set; }            // Error classification
    public string ErrorMessage { get; set; }            // Error description
    public long ExecutionTimeMs { get; set; }           // Execution time
    public DateTime Timestamp { get; set; }             // Response timestamp
}

public enum CommandType
{
    DirectCommand,      // Simple direct block control
    BatchCommand,       // Multiple commands in batch
    AutomationPlan,     // SE automation setup
    AIDeployment,       // AI system deployment
    Emergency,          // Emergency operations
    Information         // Information requests
}

public enum ErrorType
{
    ValidationError,    // Command validation failed
    CommunicationError, // Communication failure
    TimeoutError,       // Operation timeout
    InternalError,      // Internal system error
    AuthorizationError  // Authorization failure
}
```

### **Spatial Data Transfer System**

**SpatialDataPacket - Complete Ship Information**:
```csharp
public class SpatialDataPacket
{
    public long GridId { get; set; }                    // Grid identifier
    public string GridName { get; set; }               // Grid name
    public Vector3D GridPosition { get; set; }         // Grid position
    public BoundingBoxD GridBounds { get; set; }       // Grid boundaries
    public BlockDataEntry[] Blocks { get; set; }        // Block information
    public ZoneDataEntry[] Zones { get; set; }          // Zone information
    public RelationshipDataEntry[] Relationships { get; set; } // Spatial relationships
    public DateTime ScanTimestamp { get; set; }        // Scan completion time
    public string ScanVersion { get; set; }            // Scan version
}

public class BlockDataEntry
{
    public long BlockId { get; set; }                  // Block identifier
    public string BlockName { get; set; }              // Block name
    public string BlockType { get; set; }              // Block type
    public Vector3I GridPosition { get; set; }         // Grid coordinates
    public Vector3D WorldPosition { get; set; }        // World coordinates
    public string Status { get; set; }                 // Block status
    public bool IsFunctional { get; set; }             // Functional status
    public bool IsWorking { get; set; }                // Working status
    public string Zone { get; set; }                   // Zone assignment
    public Dictionary<string, object> Properties { get; set; } // Block properties
}

public class ZoneDataEntry
{
    public string ZoneName { get; set; }               // Zone name
    public Vector3I CenterPosition { get; set; }       // Zone center
    public BoundingBoxI ZoneBounds { get; set; }       // Zone boundaries
    public int BlockCount { get; set; }                // Blocks in zone
    public string[] BlockTypes { get; set; }           // Block types present
    public double ConfidenceScore { get; set; }        // Classification confidence
    public string[] AutomationOpportunities { get; set; } // Automation possibilities
}
```

## Performance and Testing Data Structures

### **Performance Monitoring System**

**Performance Metrics Collection**:
```csharp
public struct ComponentPerformance
{
    public double TotalTime;                            // Total processing time
    public double WorstTime;                           // Worst case time
    public int CallCount;                              // Number of calls
    public double AverageTime;                         // Average processing time
    public DateTime LastUpdate;                        // Last update time
}

public class PerformanceStatistics
{
    public double AverageFrameTime;                    // Average frame time
    public double CurrentFPS;                          // Current FPS
    public double WorstFrameTime;                      // Worst frame time
    public int FramesOverBudget;                       // Frames exceeding budget
    public int ThrottleActivationCount;                // Throttling activations
    public Dictionary<string, ComponentPerformance> ComponentMetrics; // Component metrics
    public bool MeetsPerformanceTarget;                // Performance target met
    public DateTime LastUpdate;                        // Last statistics update
}
```

### **Testing Framework Data Structures**

**Test Result System**:
```csharp
public struct PerformanceTestResult
{
    public string TestName;                            // Test identifier
    public bool Passed;                                // Test result
    public DateTime StartTime;                         // Test start time
    public DateTime EndTime;                           // Test completion time
    public double AverageFPS;                          // Average FPS during test
    public double MinimumFPS;                          // Minimum FPS recorded
    public double MaximumFPS;                          // Maximum FPS recorded
    public double AverageFrameTime;                    // Average frame time
    public double WorstFrameTime;                      // Worst frame time
    public int TotalFrames;                            // Total frames processed
    public int FramesOverBudget;                       // Frames over budget
    public double MemoryUsageMB;                       // Memory usage
    public double MemoryLeakMB;                        // Memory leak detected
    public List<string> FailureReasons;                // Failure reasons
    public Dictionary<string, double> ComponentTiming; // Component timing
    public string TestCategory;                        // Test category
    public int BlockCount;                             // Blocks tested
}

public struct SafetyTestResult
{
    public string TestName;                            // Test identifier
    public SafetyTestType TestType;                    // Type of safety test
    public bool Passed;                                // Test result
    public List<string> SafetyViolations;              // Detected violations
    public List<string> DamageEvents;                  // Damage events
    public TimeSpan TestDuration;                      // Test duration
    public string FailureReason;                       // Failure reason
    public List<string> RecommendedActions;            // Recommended actions
    public bool EmergencyResponseTested;               // Emergency response validated
    public double ResponseTimeMs;                      // Emergency response time
}
```

## AI Coordination Data Structures

### **AI System Management**

**AI Block Profile System**:
```csharp
public class AIBlockProfile
{
    public long BlockId;                               // AI block identifier
    public AIBlockType BlockType;                      // Task, Move, Combat
    public IMyTerminalBlock Block;                     // SE block reference
    public bool IsAuthorized;                          // Authorization status
    public bool IsActive;                              // Activity status
    public DateTime RegistrationTime;                  // Registration timestamp
    public DateTime LastBehaviorCheck;                 // Last behavior validation
    public AISafetyStatus SafetyStatus;                // Safety status
    public Dictionary<string, object> BehaviorParams;  // Behavior parameters
    public string CurrentBehavior;                      // Current behavior
    public Vector3D OperatingPosition;                 // Operating position
    public double OperatingRadius;                     // Operating radius
    public List<string> AuthorizedOperations;          // Authorized operations
}

public enum AIBlockType
{
    Task,              // AI Basic, AI Recorder
    Move,              // AI Flight
    Combat,            // AI Defensive, AI Offensive
    Coordinator        // AI coordination systems
}
```

**AI Coordination Management**:
```csharp
public class AICoordinationGroup
{
    public string GroupId;                             // Coordination group identifier
    public string GroupName;                           // Group name
    public List<long> AIBlockIds;                      // AI blocks in group
    public AICoordinationStrategy Strategy;            // Coordination strategy
    public Dictionary<long, string> AIBlockRoles;     // Role assignments
    public DateTime CreationTime;                      // Group creation time
    public DateTime LastCoordination;                  // Last coordination update
    public bool IsActive;                              // Group activity status
    public Dictionary<string, object> CoordinationData; // Coordination parameters
}

public enum AICoordinationStrategy
{
    Independent,       // AI blocks operate independently
    Cooperative,       // AI blocks cooperate on tasks
    Hierarchical,      // AI blocks follow hierarchy
    Distributed,       // AI blocks distribute workload
    Synchronized       // AI blocks synchronize operations
}
```

## Bridge Application Data Structures

### **Natural Language Processing**

**Intent Classification System**:
```csharp
public class IntentClassificationResult
{
    public CommandIntent Intent;                        // Classified intent
    public float Confidence;                           // Classification confidence
    public List<ExtractedParameter> Parameters;        // Extracted parameters
    public ComplexityLevel ComplexityLevel;            // Operation complexity
    public bool RequiresClarification;                 // Clarification needed
    public string ClarificationMessage;                // Clarification message
    public List<string> RequiredCapabilities;          // Required capabilities
    public SpatialRequirements SpatialRequirements;    // Spatial requirements
}

public enum CommandIntent
{
    Unknown,          // Could not classify
    DirectControl,    // Simple block control
    SEAutomation,     // Complex SE automation
    AIDeployment,     // Autonomous operations
    Information,      // Status and information
    Construction,     // Building and repair
    Navigation,       // Movement and docking
    Combat,          // Weapons and defense
    Emergency        // Emergency operations
}

public class ExtractedParameter
{
    public string Name;                                // Parameter name
    public object Value;                               // Parameter value
    public ParameterType Type;                         // Parameter type
    public double Confidence;                          // Extraction confidence
    public string Source;                              // Source in input
}
```

### **Claude API Integration**

**Claude Request/Response System**:
```csharp
public class ClaudeRequest
{
    public string UserInput;                           // User input text
    public CommandIntent Intent;                       // Classified intent
    public List<ExtractedParameter> Parameters;        // Extracted parameters
    public SpatialContext SpatialContext;             // Ship spatial context
    public string SystemPrompt;                        // Dynamic system prompt
    public List<string> RequiredCapabilities;          // Required SE capabilities
}

public class ClaudeResponse
{
    public bool IsValid;                               // Response validity
    public string Type;                                // Response type
    public string Analysis;                            // Intent analysis
    public List<ClaudeCommand> Commands;               // Direct commands
    public List<ClaudePlanStep> Plan;                  // Automation plan
    public List<string> ValidationRequirements;       // Validation needs
    public List<string> SafetyConsiderations;         // Safety considerations
    public string EstimatedDuration;                   // Duration estimate
    public string ErrorMessage;                        // Error message
    public long ResponseTimeMs;                        // Response time
}

public class SpatialContext
{
    public string ShipName;                            // Ship name
    public int TotalBlocks;                            // Total block count
    public List<string> AvailableZones;               // Available zones
    public string PowerStatus;                         // Power system status
    public List<string> CriticalSystems;              // Critical systems
    public string SpatialIntelligence;                // Spatial information
    public List<string> AvailableGroups;              // Available SE groups
    public List<string> AvailableTimers;              // Available timer blocks
    public List<string> AvailableEventControllers;    // Available event controllers
    public List<string> AvailableAIBlocks;            // Available AI blocks
}
```

## Error Handling Data Structures

### **Comprehensive Error Management**

**Error Information System**:
```csharp
public struct ErrorInfo
{
    public string Component;                           // Component name
    public string Message;                             // Error message
    public Exception Exception;                        // Exception details
    public ErrorSeverity Severity;                     // Error severity
    public DateTime Timestamp;                         // Error timestamp
    public string RecoveryGuidance;                    // Recovery guidance
}

public enum ErrorSeverity
{
    Low,        // Non-critical, system continues normally
    Medium,     // Reduced functionality, user should be aware
    High,       // Significant impact, immediate attention needed
    Critical    // System integrity at risk, emergency measures
}

public enum ComponentState
{
    Normal,         // Operating normally
    Degraded,       // Reduced functionality due to errors
    Isolated,       // Component isolated due to excessive errors
    Recovery        // Attempting recovery
}
```

**Performance Monitoring Integration**:
```csharp
public class PerformanceIssue
{
    public PerformanceIssueType Type;                  // Issue type
    public string ComponentName;                       // Affected component
    public double Severity;                            // Issue severity
    public double MeasuredValue;                       // Measured performance value
    public double ExpectedValue;                       // Expected performance value
    public DateTime DetectionTime;                     // Issue detection time
    public string RecommendedAction;                   // Recommended action
    public bool RequiresImmediate;                     // Immediate action required
}

public enum PerformanceIssueType
{
    FrameTimeExceeded,      // Frame time over budget
    MemoryPressure,         // High memory usage
    ComponentOverload,      // Component overloaded
    QueryPerformance,       // Query performance degraded
    ThrottlingActive,       // Performance throttling active
    ResourceContention      // Resource contention detected
}
```

## State Management Data Structures

### **System State Tracking**

**Grid Scan State Management**:
```csharp
public class GridScanState
{
    public long GridId { get; set; }                   // Grid identifier
    public IMyCubeGrid Grid { get; set; }              // Grid reference
    public int TotalBlocks { get; set; }               // Total blocks to scan
    public int ProcessedBlocks { get; set; }           // Blocks processed
    public DateTime ScanStartTime { get; set; }        // Scan start time
    public List<BlockSpatialData> SpatialData { get; set; } // Spatial data
    public bool IsComplete => ProcessedBlocks >= TotalBlocks; // Completion status
    public double Progress => TotalBlocks > 0 ? (double)ProcessedBlocks / TotalBlocks : 0.0; // Progress percentage
}
```

**Component Registration System**:
```csharp
public interface IGridComponent
{
    bool Initialize();                                 // Initialize component
    void Update();                                     // Update component
    void Shutdown();                                   // Shutdown component
}

// C# 6 compatible component registry pattern
private readonly Dictionary<string, IGridComponent> _registeredComponents = new Dictionary<string, IGridComponent>();
private readonly List<string> _componentInitializationOrder = new List<string>();
private readonly Queue<IGridComponent> _componentsToInitialize = new Queue<IGridComponent>();
```

This data structure architecture provides comprehensive type safety, performance optimization, and clear data flow throughout the GRID system while maintaining C# 6.0 compatibility and SE ModAPI compliance.
