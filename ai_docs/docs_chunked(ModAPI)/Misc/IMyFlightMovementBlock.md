---
title: "Interface IMyFlightMovementBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyFlightMovementBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyFlightMovementBlock"
---

# Interface IMyFlightMovementBlock | Space Engineers ModAPI

Describes flight movement block interface

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyFlightMovementBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AlignToPGravity

Gets/sets bool if align to P gravity mode is on.

##### Declaration

```
bool AlignToPGravity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CollisionAvoidance

Gets/sets bool representing if collision avoidance is on.

##### Declaration

```
bool CollisionAvoidance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CurrentWaypoint

Gets current waypoint

##### Declaration

```
IMyAutopilotWaypoint CurrentWaypoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html) |     |

#### FlightMode

Gets/sets type of active flight mode

##### Declaration

```
FlightMode FlightMode { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [FlightMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.FlightMode.html) |     |

#### IsAutoPilotEnabled

Determines whether the autopilot is currently enabled.

##### Declaration

```
bool IsAutoPilotEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LookAtPosition

Gets/sets position where flight movement should look at

##### Declaration

```
Nullable<Vector3D> LookAtPosition { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### MinimalAltitude

Gets/sets minimal altitude above the planet surface

##### Declaration

```
float MinimalAltitude { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PrecisionMode

Gets/sets bool if precision mode is on.

##### Declaration

```
bool PrecisionMode { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SpeedLimit

Gets/sets speed limit.

##### Declaration

```
float SpeedLimit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetWaypoints(List<IMyAutopilotWaypoint>)

Gets current waypoints

##### Declaration

```
void GetWaypoints(List<IMyAutopilotWaypoint> points)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html)\> | points |     |

### Extension Methods