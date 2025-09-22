---
title: "Class MyObjectBuilder\\_DefensiveCombatBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_DefensiveCombatBlock.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_DefensiveCombatBlock"
---

# Class MyObjectBuilder\_DefensiveCombatBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_DefensiveCombatBlock

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_DefensiveCombatBlock : MyObjectBuilder_FunctionalBlock
```

### Constructors

#### MyObjectBuilder\_DefensiveCombatBlock()

##### Declaration

```
public MyObjectBuilder_DefensiveCombatBlock()
```

### Fields

#### CanTargetCharacters

##### Declaration

```
public bool CanTargetCharacters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CustomFleeCoordinates

##### Declaration

```
[Nullable]
public Vector3D CustomFleeCoordinates
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### EvasiveManeuverAngle

##### Declaration

```
public float EvasiveManeuverAngle
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EvasiveManeuverIntervalRange

##### Declaration

```
public float EvasiveManeuverIntervalRange
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EvasiveManeuvers

##### Declaration

```
public bool EvasiveManeuvers
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FleeDistance

##### Declaration

```
public float FleeDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FleeMinHeightOnPlanets

##### Declaration

```
public float FleeMinHeightOnPlanets
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FleeMode

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [FleeMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.FleeMode.html) |     |

#### FleeTrigger

##### Declaration

```
public FleeTrigger FleeTrigger
```

##### Field Value

| Type | Description |
| --- | --- |
| [FleeTrigger](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.FleeTrigger.html) |     |

#### FleeWaypoint

##### Declaration

```
[Nullable]
public MyObjectBuilder_AutopilotWaypoint FleeWaypoint
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotWaypoint.html) |     |

#### LastKnownEnemyPosition

##### Declaration

```
public Nullable<Vector3D> LastKnownEnemyPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### LockTarget

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PrevToolbarState

##### Declaration

```
[Nullable]
public Nullable<bool> PrevToolbarState
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |

#### SelectedBeaconEntityId

##### Declaration

```
public long SelectedBeaconEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### SelectedGpsHash

##### Declaration

```
[Nullable]
public Nullable<int> SelectedGpsHash
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### SelectedGpsHashNew

##### Declaration

```
[Nullable]
public Nullable<GpsInfo> SelectedGpsHashNew
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.Game.ObjectBuilders.AI.GpsInfo\> |     |

#### Toolbar

##### Declaration

```
[Nullable]
public MyObjectBuilder_Toolbar Toolbar
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Toolbar](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html) |     |

#### UseCustomFleeCoordinates

##### Declaration

```
[Nullable]
public bool UseCustomFleeCoordinates
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WaypointZoneSize

##### Declaration

```
public float WaypointZoneSize
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Remap(IMyRemapHelper)

##### Declaration

```
public override void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

##### Overrides

#### SetupForGridPaste()

##### Declaration

```
public override void SetupForGridPaste()
```

##### Overrides

#### SetupForProjector()

##### Declaration

```
public override void SetupForProjector()
```

##### Overrides

### Extension Methods