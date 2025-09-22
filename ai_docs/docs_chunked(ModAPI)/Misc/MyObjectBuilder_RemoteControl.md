---
title: "Class MyObjectBuilder\\_RemoteControl"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_RemoteControl.html"
category: "Misc"
namespace: "Sandbox.Common.ObjectBuilders"
class: "MyObjectBuilder_RemoteControl"
---

# Class MyObjectBuilder\_RemoteControl | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_RemoteControl

##### Inherited Members

###### **Namespace**: [Sandbox.Common.ObjectBuilders](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.html)

###### **Assembly**: SpaceEngineers.ObjectBuilders.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_RemoteControl : MyObjectBuilder_ShipController
```

### Constructors

#### MyObjectBuilder\_RemoteControl()

##### Declaration

```
public MyObjectBuilder_RemoteControl()
```

### Fields

#### AutomaticallyProlongJourney

##### Declaration

```
public bool AutomaticallyProlongJourney
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AutomaticBehaviour

##### Declaration

```
[Serialize]
public MyObjectBuilder_AutomaticBehaviour AutomaticBehaviour
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Game.ObjectBuilders.AI.MyObjectBuilder\_AutomaticBehaviour |     |

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

#### BindedCamera

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

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

#### FlightMode

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsMainRemoteControl

##### Declaration

```
public bool IsMainRemoteControl
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsUpdatedSave

##### Declaration

```
public bool IsUpdatedSave
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### PreviousControlledEntityId

##### Declaration

```
[Serialize]
public Nullable<long> PreviousControlledEntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

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

#### SetupForProjector()

##### Declaration

```
public override void SetupForProjector()
```

##### Overrides

### Extension Methods