---
title: "Class MyObjectBuilder\\_AutopilotComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotComponent.html"
category: "Components"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_AutopilotComponent"
---

# Class MyObjectBuilder\_AutopilotComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_AutopilotComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_AutopilotComponent : MyObjectBuilder_ComponentBase
```

### Constructors

#### MyObjectBuilder\_AutopilotComponent()

##### Declaration

```
public MyObjectBuilder_AutopilotComponent()
```

### Fields

#### AlignToGravity

##### Declaration

```
public bool AlignToGravity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AUTOPILOT\_MAX\_SPEED

##### Declaration

```
public const float AUTOPILOT_MAX_SPEED = 100F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### AutoPilotEnabled

##### Declaration

```
public bool AutoPilotEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AutopilotSpeedLimit

##### Declaration

```
public float AutopilotSpeedLimit
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### AutoPilotToolbar

Obsolete. Use Waypoints instead.

##### Declaration

```
[Serialize]
public MyObjectBuilder_Toolbar AutoPilotToolbar
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Toolbar](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Toolbar.html) |     |

#### CollisionAvoidance

##### Declaration

```
public bool CollisionAvoidance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Coords

Obsolete. Use Waypoints instead.

##### Declaration

```
[Serialize]
public List<Vector3D> Coords
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### CurrentWaypointIndex

##### Declaration

```
public int CurrentWaypointIndex
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### DEFAULT\_AUTOPILOT\_SPEED\_LIMIT

##### Declaration

```
public const float DEFAULT_AUTOPILOT_SPEED_LIMIT = 10F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Direction

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### DockingModeEnabled

##### Declaration

```
public bool DockingModeEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FacingDirection

##### Declaration

```
public Base6Directions.DirectionFlags FacingDirection
```

##### Field Value

| Type | Description |
| --- | --- |
| [Base6Directions.DirectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.DirectionFlags.html) |     |

#### FlightMode

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsWorkAreaReturningToStart

##### Declaration

```
public bool IsWorkAreaReturningToStart
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LookAtPosition

##### Declaration

```
[Serialize]
public Nullable<Vector3D> LookAtPosition
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### MinHeightAboveTerrain

##### Declaration

```
public float MinHeightAboveTerrain
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Names

Obsolete. Use Waypoints instead.

##### Declaration

```
[Serialize]
public List<string> Names
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### PitchAngle

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RollAngle

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WaitForFreeWay

##### Declaration

```
public bool WaitForFreeWay
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Waypoints

##### Declaration

```
[Serialize]
[DynamicNullableObjectBuilderItem(false)]
public List<MyObjectBuilder_AutopilotWaypoint> Waypoints
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_AutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotWaypoint.html)\> |     |

#### WaypointThresholdDistance

##### Declaration

```
public float WaypointThresholdDistance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WorkAreaStartForward

##### Declaration

```
public Vector3D WorkAreaStartForward
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

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

### Extension Methods