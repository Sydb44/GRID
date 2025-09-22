---
title: "Class MyAutopilotComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyAutopilotComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyAutopilotComponent"
---

# Class MyAutopilotComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyAutopilotComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyAutopilotComponent : MyEventProxyEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyAutopilotComponent()

##### Declaration

```
public MyAutopilotComponent()
```

### Fields

#### AutoPilotEnabled

##### Declaration

```
public Sync<bool, SyncDirection.BothWays> AutoPilotEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Sync.Sync<System.Boolean, VRage.Sync.SyncDirection.BothWays\> |     |

#### WaypointsFromPathRecorder

##### Declaration

```
public bool WaypointsFromPathRecorder
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### AutomaticBehaviour

##### Declaration

```
public IRemoteControlAutomaticBehaviour AutomaticBehaviour { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IRemoteControlAutomaticBehaviour](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IRemoteControlAutomaticBehaviour.html) |     |

#### AutoPilotControlThrust

##### Declaration

```
public Vector3 AutoPilotControlThrust { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Clipboard

##### Declaration

```
public static MyObjectBuilder_AutopilotClipboard Clipboard { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AutopilotClipboard](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutopilotClipboard.html) |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### CurrentDestination

##### Declaration

```
public Vector3D CurrentDestination { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### CurrentDirection

##### Declaration

```
public Base6Directions.Direction CurrentDirection { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### CurrentFlightMode

##### Declaration

```
public FlightMode CurrentFlightMode { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [FlightMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.FlightMode.html) |     |

#### CurrentWaypoint

##### Declaration

```
public MyAutopilotWaypoint CurrentWaypoint { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyAutopilotWaypoint.html) |     |

#### CurrentWaypointIndex

##### Declaration

```
public int CurrentWaypointIndex { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CurrentWaypointName

##### Declaration

```
public string CurrentWaypointName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CustomLookAtPositionInterceptor

##### Declaration

```
public CustomLookAtInterceptor CustomLookAtPositionInterceptor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [CustomLookAtInterceptor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.CustomLookAtInterceptor.html) |     |

#### Definition

##### Declaration

```
public MyAutopilotComponentDefinition Definition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyAutopilotComponentDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyAutopilotComponentDefinition.html) |     |

#### DirectionNames

##### Declaration

```
public static Dictionary<Base6Directions.Direction, MyStringId> DirectionNames { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html), [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> |     |

#### FacingDirection

##### Declaration

```
public Base6Directions.DirectionFlags FacingDirection { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.DirectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.DirectionFlags.html) |     |

#### FlightMode

##### Declaration

```
public FlightMode FlightMode { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [FlightMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.FlightMode.html) |     |

#### ForceBehaviorUpdate

##### Declaration

```
public bool ForceBehaviorUpdate { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |
