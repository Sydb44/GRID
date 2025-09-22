---
title: "Class MyConveyorConnector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConveyorConnector.html"
category: "Logistics"
namespace: "Sandbox.Game.Entities"
class: "MyConveyorConnector"
---

# Class MyConveyorConnector | Space Engineers ModAPI

##### Inheritance

System.Object

MyConveyorConnector

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyCubeBlockType]
public class MyConveyorConnector : MyCubeBlock, IMyComponentOwner<MyIDModule>, IMyUpgradableBlock, IMyUpgradableBlock, IMyConveyorSegmentBlock, IMyConveyorTube, IMyCubeBlock, IMyEntity, IMyConveyorTube, IMyCubeBlock, IMyEntity
```

### Constructors

#### MyConveyorConnector()

##### Declaration

```
public MyConveyorConnector()
```

### Properties

#### ConveyorSegment

##### Declaration

```
public MyConveyorSegment ConveyorSegment { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.GameSystems.Conveyors.MyConveyorSegment |     |

#### MaxGlassDistSq

##### Declaration

```
public override float MaxGlassDistSq { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

### Methods

#### Init(MyObjectBuilder\_CubeBlock, MyCubeGrid)

##### Declaration

```
public override void Init(MyObjectBuilder_CubeBlock builder, MyCubeGrid cubeGrid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html) | builder |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | cubeGrid |     |

##### Overrides

#### InitializeConveyorSegment()

##### Declaration

```
public void InitializeConveyorSegment()
```

#### OnLineWorkingStateUpdate(MyConveyorLine)

##### Declaration

```
public void OnLineWorkingStateUpdate(MyConveyorLine line)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.GameSystems.Conveyors.MyConveyorLine | line |     |

#### OnRemovedFromScene(Object)

##### Declaration

```
public override void OnRemovedFromScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

#### SetEmissiveStateDisabled()

##### Declaration

```
public override bool SetEmissiveStateDisabled()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### SetEmissiveStateWorking()

##### Declaration

```
public override bool SetEmissiveStateWorking()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

### Implements

### Extension Methods