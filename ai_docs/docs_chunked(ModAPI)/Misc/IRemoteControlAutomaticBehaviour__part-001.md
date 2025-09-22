---
title: "Interface IRemoteControlAutomaticBehaviour"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IRemoteControlAutomaticBehaviour.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "IRemoteControlAutomaticBehaviour"
---

# Interface IRemoteControlAutomaticBehaviour | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IRemoteControlAutomaticBehaviour
```

### Properties

#### Ambushing

##### Declaration

```
bool Ambushing { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CollisionAvoidance

##### Declaration

```
bool CollisionAvoidance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CurrentBehavior

##### Declaration

```
string CurrentBehavior { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CurrentTarget

##### Declaration

```
MyEntity CurrentTarget { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### CycleWaypoints

##### Declaration

```
bool CycleWaypoints { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActive

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxPlayerDistance

##### Declaration

```
float MaxPlayerDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### NeedUpdate

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Operational

##### Declaration

```
bool Operational { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OriginPoint

##### Declaration

```
Vector3D OriginPoint { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### PlayerPriority

##### Declaration

```
int PlayerPriority { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### PlayerYAxisOffset

##### Declaration

```
float PlayerYAxisOffset { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PrioritizationStyle

##### Declaration

```
TargetPrioritization PrioritizationStyle { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.AI.TargetPrioritization |     |

#### ResetStuckDetection

##### Declaration

```
bool ResetStuckDetection { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RotateToTarget

##### Declaration

```
bool RotateToTarget { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SpeedLimit

##### Declaration

```
float SpeedLimit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TargetList

##### Declaration

```
List<DroneTarget> TargetList { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<Sandbox.Game.GameSystems.DroneTarget\> |     |

#### WaypointActive

##### Declaration

```
bool WaypointActive { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WaypointList

##### Declaration

```
List<MyEntity> WaypointList { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### WaypointThresholdDistance

##### Declaration

```
float WaypointThresholdDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### DebugDraw()

##### Declaration

#### GetObjectBuilder()

##### Declaration

```
MyObjectBuilder_AutomaticBehaviour GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.AI.MyObjectBuilder\_AutomaticBehaviour |     |

#### Load(MyObjectBuilder\_AutomaticBehaviour, MyRemoteControl)

##### Declaration

```
void Load(MyObjectBuilder_AutomaticBehaviour objectBuilder, MyRemoteControl remoteControl)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.ObjectBuilders.AI.MyObjectBuilder\_AutomaticBehaviour | objectBuilder |     |
| [MyRemoteControl](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyRemoteControl.html) | remoteControl |     |

#### StopWorking()

##### Declaration

#### TargetAdd(DroneTarget)

##### Declaration

```
void TargetAdd(DroneTarget target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.GameSystems.DroneTarget | target |     |

#### TargetClear()

##### Declaration

#### TargetLoseCurrent()

##### Declaration

#### TargetRemove(MyEntity)

##### Declaration

```
void TargetRemove(MyEntity target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | target |     |

#### Update()

##### Declaration

#### WaypointAdd(MyEntity)

##### Declaration

```
void WaypointAdd(MyEntity waypoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | waypoint |     |
