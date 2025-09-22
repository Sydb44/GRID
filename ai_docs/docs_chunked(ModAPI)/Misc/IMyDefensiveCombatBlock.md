---
title: "Interface IMyDefensiveCombatBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyDefensiveCombatBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyDefensiveCombatBlock"
---

# Interface IMyDefensiveCombatBlock | Space Engineers ModAPI

Describes defensive combat block interface

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyDefensiveCombatBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### CustomFleeCoordinates

Gets or sets world position where it should flee. Has higher priority than [FleeBeaconEntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyDefensiveCombatBlock.html#Sandbox_ModAPI_Ingame_IMyDefensiveCombatBlock_FleeBeaconEntityId), [FleeGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyDefensiveCombatBlock.html#Sandbox_ModAPI_Ingame_IMyDefensiveCombatBlock_FleeGps)

##### Declaration

```
Nullable<Vector3D> CustomFleeCoordinates { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### FleeBeaconEntityId

Gets selected beacon entityId, used for flee coordinates

##### Declaration

```
Nullable<long> FleeBeaconEntityId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### FleeCoordinates

Gets flee coordinates

##### Declaration

```
Nullable<Vector3D> FleeCoordinates { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### FleeGps

Gets gps, used for flee coordinates

##### Declaration

```
Nullable<GpsInfo> FleeGps { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.Game.ObjectBuilders.AI.GpsInfo\> |     |

#### FleeTrigger

On what event block should flee

##### Declaration

```
FleeTrigger FleeTrigger { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [FleeTrigger](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.FleeTrigger.html) |     |

#### IsFleeing

Gets if block currently fleeing

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LockTarget

Gets or sets if block can target lock enemies

##### Declaration

```
bool LockTarget { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SearchEnemyComponent

Gets search enemy component

##### Declaration

```
IMySearchEnemyComponent SearchEnemyComponent { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMySearchEnemyComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMySearchEnemyComponent.html) |     |

#### WaypointZoneSize

Gets or sets waypoint zone size (meters)

##### Declaration

```
float WaypointZoneSize { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Flee()

Starts flee mechanic

##### Declaration

### Extension Methods