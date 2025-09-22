# GRID Spatial Intelligence System - Complete Architecture

## Overview

The GRID spatial intelligence system provides real-time spatial analysis, zone detection, and intelligent block targeting for Space Engineers ships. The system maintains strict performance guarantees while delivering comprehensive spatial understanding for structured command processing from ClaudeBridge.

## Core Architecture

### **System Components**

```
SpatialIntelligenceCoordinator (Main Orchestrator)
├── IncrementalShipScanner - Progressive scanning with performance guarantees
├── ZoneDetectionSystem - Pattern-based zone classification  
├── SpatialTargetResolver - Advanced query resolution and targeting
├── SpatialQueryOptimizer - Performance optimization for complex queries
├── BlockSpatialData - Comprehensive spatial data structures
├── ZoneAccuracyValidator - Zone detection accuracy validation
└── SpatialIntegrationAPI - External system integration interface
```

### **Performance Guarantees**

**Strict Performance Limits**:
- **50 blocks per frame maximum** - Zero freeze guarantee
- **2ms frame time budget** - Maintains 60+ FPS
- **100ms spatial query response** - Sub-second targeting
- **Scale independence** - Same performance on 50-block or 5000-block ships

**Distributed Processing Architecture**:
- **Progressive scanning** - Work spread across multiple frames
- **Incremental updates** - Spatial data updated as needed
- **Performance monitoring** - Real-time frame budget tracking
- **Automatic throttling** - Degrades gracefully under load

## Incremental Ship Scanner

### **IncrementalShipScanner.cs - Progressive Scanning System**

**Performance Architecture**:
```csharp
public class IncrementalShipScanner : IGridComponent
{
    private const int MAX_BLOCKS_PER_FRAME = 50;
    private const double MAX_FRAME_TIME_MS = 2.0;
    private const int SCAN_PRIORITY_REFRESH_TICKS = 300; // 5 seconds
    
    // Strict frame budget enforcement
    private void ProcessScanningQueue()
    {
        _blocksProcessedThisFrame = 0;
        _frameStopwatch.Restart();
        
        while (_blocksProcessedThisFrame < MAX_BLOCKS_PER_FRAME && 
               _frameStopwatch.Elapsed.TotalMilliseconds < MAX_FRAME_TIME_MS)
        {
            ProcessGridChunk(scanState, remainingBlocks);
        }
    }
}
```

**Progressive Scanning Process**:
1. **Grid Detection**: New grids automatically queued for scanning
2. **Chunk Processing**: Blocks analyzed in 10-block chunks with frame budget monitoring
3. **Spatial Data Generation**: Complete spatial relationships calculated
4. **Event Notification**: Real-time updates to spatial coordinator and dependent systems

**Scanning State Management**:
```csharp
public class GridScanState
{
    public long GridId { get; set; }
    public IMyCubeGrid Grid { get; set; }
    public int TotalBlocks { get; set; }
    public int ProcessedBlocks { get; set; }
    public double Progress => TotalBlocks > 0 ? (double)ProcessedBlocks / TotalBlocks : 0.0;
    public bool IsComplete => ProcessedBlocks >= TotalBlocks;
    public DateTime ScanStartTime { get; set; }
    public List<BlockSpatialData> SpatialData { get; set; }
}
```

## Zone Detection System

### **ZoneDetectionSystem.cs - Pattern-Based Zone Classification**

**Zone Types and Patterns**:
```csharp
private static readonly Dictionary<ZoneType, ZonePatternDefinition> ZonePatterns = new Dictionary<ZoneType, ZonePatternDefinition>
{
    [ZoneType.Bridge] = new ZonePatternDefinition
    {
        Keywords = new[] { "bridge", "command", "cockpit", "pilot", "control" },
        BlockTypes = new[] { "Cockpit", "FlightSeat", "RemoteControl", "Antenna" },
        ProximityBonus = 0.3,
        Description = "Command and control areas"
    },
    
    [ZoneType.Engineering] = new ZonePatternDefinition
    {
        Keywords = new[] { "engineering", "engine", "reactor", "power", "energy" },
        BlockTypes = new[] { "Reactor", "BatteryBlock", "SolarPanel", "WindTurbine" },
        ProximityBonus = 0.4,
        Description = "Power generation and engineering systems"
    },
    
    [ZoneType.Hangar] = new ZonePatternDefinition
    {
        Keywords = new[] { "hangar", "bay", "dock", "landing", "garage" },
        BlockTypes = new[] { "Door", "HangarDoor", "LandingGear", "Connector" },
        ProximityBonus = 0.3,
        Description = "Docking and vehicle storage areas"
    }
    // Additional zone types: Cargo, Airlock, LifeSupport, Defense, Production
};
```

**Zone Confidence Calculation**:
```csharp
private double CalculateZoneConfidence(BlockSpatialData blockData, ZonePatternDefinition pattern, List<BlockSpatialData> allBlocks)
{
    double confidence = 0.0;
    
    // Name pattern matching (primary indicator - 60% weight)
    confidence += CalculateNameMatchScore(blockData, pattern) * 0.6;
    
    // Block type matching (strong indicator - 30% weight)
    confidence += CalculateBlockTypeMatchScore(blockData, pattern) * 0.3;
    
    // Proximity analysis (spatial clustering - 10% weight)
    confidence += CalculateProximityScore(blockData, pattern, allBlocks) * 0.1;
    
    return Math.Min(confidence, 1.0);
}
```

**Zone Detection Accuracy**:
- **>80% accuracy** - Validated pattern recognition
- **High confidence threshold**: 0.8 for definitive zone assignment
- **Minimum confidence**: 0.3 for zone consideration
- **Accuracy validation** - Continuous improvement through usage patterns

## Spatial Target Resolution

### **SpatialTargetResolver.cs - Advanced Query Resolution**

**Query Types and Patterns**:
```csharp
private static readonly Dictionary<string, QueryPattern> QueryPatterns = new Dictionary<string, QueryPattern>
{
    ["specific_name"] = new QueryPattern
    {
        Regex = new Regex(@"^(.+)$", RegexOptions.IgnoreCase),
        Type = QueryType.SpecificName,
        Priority = 10  // Highest priority
    },
    
    ["zone_blocks"] = new QueryPattern  
    {
        Regex = new Regex(@"^(\w+)\s+(lights?|doors?|vents?|reactors?|batteries|weapons?)$", RegexOptions.IgnoreCase),
        Type = QueryType.ZoneBlocks,
        Priority = 9
    },
    
    ["proximity_blocks"] = new QueryPattern
    {
        Regex = new Regex(@"^(lights?|doors?|vents?)\s+(?:near|around|close\s+to|within)\s+(.+)$", RegexOptions.IgnoreCase),
        Type = QueryType.ProximityBlocks,
        Priority = 8
    }
};
```

**Query Resolution Examples**:

**Specific Name Query**: `"Reactor 1"`
```csharp
private SpatialQueryResult ExecuteSpecificNameQuery(string blockName, GridSpatialContext context, string originalQuery)
{
    // Exact match first
    var exactMatches = context.AllBlocks.Where(b => 
        b.CustomName.Equals(blockName, StringComparison.OrdinalIgnoreCase) ||
        b.DisplayName.Equals(blockName, StringComparison.OrdinalIgnoreCase)).ToList();
    
    // Fuzzy matching if no exact match
    if (exactMatches.Count == 0)
    {
        exactMatches = context.AllBlocks.Where(b => 
            b.CustomName.Contains(blockName) || 
            b.DisplayName.Contains(blockName)).ToList();
    }
}
```

**Zone Blocks Query**: `"hangar lights"`
```csharp
private SpatialQueryResult ExecuteZoneBlocksQuery(string zoneName, string blockType, GridSpatialContext context, string originalQuery)
{
    var zoneBlocks = context.AllBlocks.Where(b => 
        b.ZoneClassifications.Any(z => z.ZoneName.Contains(zoneName, StringComparison.OrdinalIgnoreCase))).ToList();
    
    var filteredBlocks = zoneBlocks.Where(b => 
        BlockTypeMatches(b, blockType)).ToList();
}
```

**Proximity Blocks Query**: `"lights near cockpit"`
```csharp
private SpatialQueryResult ExecuteProximityBlocksQuery(string blockType, string referencePoint, GridSpatialContext context, Vector3D? referencePosition, string originalQuery)
{
    var refPos = ResolveReferencePosition(referencePoint, context, referencePosition);
    var proximityBlocks = context.AllBlocks.Where(b => 
        BlockTypeMatches(b, blockType) &&
        Vector3D.Distance(b.WorldPosition, refPos) <= DEFAULT_PROXIMITY_RADIUS).ToList();
}
```

## Spatial Data Structures

### **BlockSpatialData.cs - Comprehensive Block Information**

**Core Spatial Properties**:
```csharp
public class BlockSpatialData
{
    // Position data
    public Vector3I GridPosition { get; private set; }        // SE grid coordinates
    public Vector3D WorldPosition { get; private set; }       // World space coordinates
    public double DistanceFromGridCenter { get; private set; }
    
    // Relationships
    public readonly HashSet<long> AdjacentBlockIds = new HashSet<long>();
    public readonly Dictionary<long, double> ProximityBlocks = new Dictionary<long, double>();
    public readonly List<ZoneClassification> ZoneClassifications = new List<ZoneClassification>();
    
    // Block capabilities
    public readonly HashSet<BlockCapability> Capabilities = new HashSet<BlockCapability>();
    public bool IsAutomationCapable { get; private set; }
    public bool IsControllable { get; private set; }
}
```

**Zone Classification System**:
```csharp
public class ZoneClassification
{
    public ZoneType Type { get; set; }              // Bridge, Engineering, Hangar, etc.
    public string ZoneName { get; set; }            // "Main Hangar", "Engine Room 1"
    public double Confidence { get; set; }          // 0.0 - 1.0 confidence score
    public Vector3I ZoneCenter { get; set; }        // Calculated zone center
    public BoundingBoxI ZoneBounds { get; set; }    // Zone spatial bounds
    public string[] Evidence { get; set; }          // Classification evidence
}
```

**Block Capability Detection**:
```csharp
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

## Query Optimization System

### **SpatialQueryOptimizer.cs - Performance Optimization**

**Spatial Indexing**:
```csharp
// Large grid optimization using spatial indexing
private static List<BlockSpatialData> OptimizeWithSpatialIndex(
    List<BlockSpatialData> allBlocks,
    Vector3D referencePosition,
    double maxDistance)
{
    var spatialIndex = BuildSpatialIndex(allBlocks);
    var searchRadius = (int)Math.Ceiling(maxDistance / SPATIAL_INDEX_GRID_SIZE);
    var centerCell = WorldToSpatialGrid(referencePosition);
    
    // Search only relevant spatial grid cells
    for (int x = -searchRadius; x <= searchRadius; x++)
    {
        // Process nearby cells only, avoiding full grid scan
    }
}
```

**Performance Optimization Strategies**:
- **Spatial indexing** for grids >500 blocks
- **Squared distance calculations** - Avoid expensive sqrt operations
- **Early termination** - Stop when sufficient results found
- **Result caching** - Cache recent queries for 2 minutes
- **Grid context caching** - Spatial context cached per grid

## Spatial Relationship Mapping

### **SpatialIntelligenceCoordinator.cs - Relationship Calculation**

**Relationship Types**:
```csharp
private void CalculateGridSpatialRelationships(long gridId, List<BlockSpatialData> spatialData)
{
    var relationshipMap = new SpatialRelationshipMap(gridId);
    
    // Calculate adjacency relationships (touching blocks)
    CalculateAdjacencyRelationships(spatialData, relationshipMap);
    
    // Calculate proximity relationships (within 15 blocks)
    CalculateProximityRelationships(spatialData, relationshipMap);
    
    // Calculate zone connectivity (how zones connect)
    CalculateZoneConnectivity(zoneAnalysis, relationshipMap);
    
    // Calculate spatial clusters (grouped blocks)
    CalculateSpatialClusters(spatialData, relationshipMap);
}
```

**Spatial Relationship Map Structure**:
```csharp
public class SpatialRelationshipMap
{
    public long GridId { get; set; }
    public Dictionary<long, List<long>> AdjacencyMap { get; set; }          // Block → Adjacent blocks
    public Dictionary<long, Dictionary<long, double>> ProximityMap { get; set; } // Block → Nearby blocks with distances
    public Dictionary<string, ZoneConnectivity> ZoneConnections { get; set; }    // Zone → Connected zones
    public Dictionary<string, List<long>> ZoneBlocks { get; set; }              // Zone → Contained blocks
    public List<SpatialCluster> Clusters { get; set; }                        // Block clusters
    public int TotalRelationships => CalculateTotalRelationships();
}
```

## Zone Detection and Classification

### **Zone Pattern Recognition**

**Multi-Factor Zone Detection**:
1. **Name Pattern Analysis** (60% weight): Keywords in block names
2. **Block Type Analysis** (30% weight): Functional block types  
3. **Proximity Analysis** (10% weight): Spatial clustering of related blocks

**Zone Types Supported**:
- **Bridge**: Command and control areas (cockpits, remote controls, antennas)
- **Engineering**: Power systems (reactors, batteries, solar panels)
- **Hangar**: Docking areas (doors, landing gear, connectors)
- **Cargo**: Storage areas (containers, conveyors, sorters)
- **Airlock**: Entry/exit chambers (doors, air vents)
- **LifeSupport**: Medical and oxygen systems
- **Defense**: Weapon platforms (turrets, weapons, warheads)
- **Production**: Manufacturing (assemblers, refineries, welders)

**Zone Evidence Generation**:
```csharp
private string[] GenerateZoneEvidence(BlockSpatialData blockData, ZonePatternDefinition pattern, double confidence)
{
    var evidence = new List<string>();
    
    // Name-based evidence
    foreach (var keyword in pattern.Keywords)
    {
        if (blockData.CustomName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
        {
            evidence.Add($"Name contains '{keyword}'");
        }
    }
    
    // Type-based evidence
    if (pattern.BlockTypes.Contains(blockData.BlockType))
    {
        evidence.Add($"Block type '{blockData.BlockType}' matches zone pattern");
    }
    
    return evidence.ToArray();
}
```

## Advanced Spatial Targeting

### **Query Resolution System**

**Supported Query Patterns**:
```
Specific Name:      "Reactor 1" → Find exact block by name
Zone Blocks:        "hangar lights" → Find all lights in hangar zone  
Proximity Blocks:   "lights near cockpit" → Find lights within 10 blocks of cockpit
Type All:           "all reactors" → Find all reactor blocks
Numbered Closest:   "3 closest batteries to bridge" → Find 3 nearest batteries
Zone All:           "bridge zone" → Find all blocks in bridge area
```

**Query Execution Flow**:
```csharp
public SpatialQueryResult ResolveQuery(string query, long gridId, Vector3D? referencePosition)
{
    // 1. Check cache for recent queries
    var cacheKey = GenerateCacheKey(query, gridId, referencePosition);
    if (_queryCache.TryGetValue(cacheKey, out cachedResult))
        return cachedResult.Result;
    
    // 2. Get grid spatial context
    var gridContext = GetOrCreateGridContext(gridId);
    
    // 3. Parse query using pattern matching
    var result = ExecuteQuery(query, gridContext, referencePosition);
    
    // 4. Cache successful results
    if (result.Status == SpatialQueryStatus.Success)
    {
        _queryCache[cacheKey] = new CachedQueryResult(result, expiryTime);
    }
    
    return result;
}
```

**Error Recovery System**:
```csharp
// Fuzzy matching and error recovery
private SpatialQueryResult ExecuteFuzzyQuery(string query, GridSpatialContext context, Vector3D? referencePosition)
{
    // 1. Spelling correction attempts
    // 2. Partial matching with suggestions
    // 3. Alternative interpretations
    // 4. Context-based fallbacks
}
```

## Performance Optimization

### **Spatial Query Optimization**

**Optimization Strategies**:
```csharp
public static List<BlockSpatialData> OptimizeProximityQuery(
    List<BlockSpatialData> allBlocks, 
    Vector3D referencePosition, 
    double maxDistance)
{
    // Use spatial indexing for large grids (>500 blocks)
    if (allBlocks.Count > 500)
    {
        return OptimizeWithSpatialIndex(allBlocks, referencePosition, maxDistance);
    }
    else
    {
        return OptimizeWithDirectCalculation(allBlocks, referencePosition, maxDistance);
    }
}
```

**Spatial Indexing System**:
```csharp
private static Dictionary<Vector3I, List<BlockSpatialData>> BuildSpatialIndex(List<BlockSpatialData> blocks)
{
    var index = new Dictionary<Vector3I, List<BlockSpatialData>>();
    
    foreach (var block in blocks)
    {
        var gridCell = WorldToSpatialGrid(block.WorldPosition);
        if (!index.ContainsKey(gridCell))
        {
            index[gridCell] = new List<BlockSpatialData>();
        }
        index[gridCell].Add(block);
    }
    
    return index;
}
```

**Cache Management**:
- **Query Result Caching**: Recent queries cached for 2 minutes
- **Grid Context Caching**: Spatial context cached per grid
- **Performance Metrics Caching**: Statistics cached for analysis
- **Automatic Cleanup**: Expired cache entries removed periodically

## Integration Patterns

### **Event System Integration**

**Spatial Intelligence Events**:
```csharp
public class SpatialIntelligenceCoordinator
{
    public event Action<long, SpatialRelationshipMap> SpatialRelationshipsUpdated;
    public event Action<long, GridScanState> GridScanCompleted;
    public event Action<SpatialQueryResult> SpatialQueryExecuted;
    
    // Event handlers for system integration
    private void OnGridScanCompleted(long gridId, GridScanState scanState)
    {
        // Analyze zones for the completed grid
        var spatialData = scanState.GetAllSpatialData();
        var zoneAnalysis = _zoneDetection.AnalyzeGrid(gridId, spatialData);
        
        // Calculate spatial relationships
        CalculateGridSpatialRelationships(gridId, spatialData);
        
        // Fire completion event for other systems
        GridScanCompleted?.Invoke(gridId, scanState);
    }
}
```

### **Command Processor Integration**

**Spatial Context for Commands**:
```csharp
// CommandProcessor integration
public static CommandProcessingResult ProcessCommand(string input, long gridId, Vector3D? referencePosition)
{
    // Resolve spatial targets if needed
    if (parseResult.HasSpatialTarget)
    {
        spatialResult = _spatialCoordinator.ExecuteSpatialQuery(
            parseResult.Target, 
            gridId, 
            referencePosition
        );
        
        if (spatialResult.Status != SpatialQueryStatus.Success)
        {
            return CreateFailureResult($"Could not resolve target '{parseResult.Target}': {spatialResult.Message}");
        }
    }
}
```

### **Bridge Application Communication**

**Spatial Data Transfer**:
```csharp
public class SpatialDataPacket
{
    public long GridId { get; set; }
    public string GridName { get; set; }
    public Vector3D GridPosition { get; set; }
    public BoundingBoxD GridBounds { get; set; }
    public BlockDataEntry[] Blocks { get; set; }
    public ZoneDataEntry[] Zones { get; set; }
    public RelationshipDataEntry[] Relationships { get; set; }
}
```

## Statistics and Monitoring

### **Performance Metrics**
- **Total Queries Processed**: Real-time query processing statistics
- **Cache Hit Rate**: Query cache effectiveness metrics
- **Average Query Time**: Performance optimization tracking
- **Zone Detection Accuracy**: >80% accuracy validation
- **Scan Completion Rate**: Progressive scanning efficiency

### **System Diagnostics**
```csharp
public SpatialIntelligenceStatus GetDetailedStatus()
{
    return new SpatialIntelligenceStatus
    {
        GridsProcessed = _totalGridsProcessed,
        ScannerStatus = _scanner.GetScannerStatus(),
        ZoneDetectionAccuracy = _zoneDetection.GetAccuracyMetrics(),
        SpatialQueries = _totalSpatialQueries,
        RelationshipsCalculated = _totalRelationshipsCalculated,
        AverageQueryTime = _averageQueryTime
    };
}
```

This spatial intelligence architecture provides comprehensive spatial understanding with strict performance guarantees, enabling natural language targeting and intelligent automation deployment across Space Engineers ships of any size.
