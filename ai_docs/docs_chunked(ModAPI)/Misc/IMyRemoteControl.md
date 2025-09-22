---
title: "Interface IMyRemoteControl"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyRemoteControl.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyRemoteControl"
---

# Interface IMyRemoteControl | Space Engineers ModAPI

Describes remote control block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyRemoteControl : IMyShipController, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### CurrentWaypoint

Gets the current target waypoint

##### Declaration

```
MyWaypointInfo CurrentWaypoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html) |     |

#### Direction

Gets or sets the current flight direction

##### Declaration

```
Base6Directions.Direction Direction { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html) |     |

#### FlightMode

Gets or sets the current flight mode

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

#### SpeedLimit

Gets or sets the autopilot speed limit

##### Declaration

```
float SpeedLimit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WaitForFreeWay

if true, if collision avoidance is on, autopilot will wait until path is clear to move forward.

##### Declaration

```
bool WaitForFreeWay { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AddWaypoint(MyWaypointInfo)

Adds a new waypoint.

##### Declaration

```
void AddWaypoint(MyWaypointInfo coords)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html) | coords | Waypoint info |

#### AddWaypoint(Vector3D, String)

Adds a new waypoint.

##### Declaration

```
void AddWaypoint(Vector3D coords, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | coords | World position of waypoint |
| System.String | name | Name of waypoint |

#### ClearWaypoints()

Removes all existing waypoints.

##### Declaration

#### GetNearestPlayer(out Vector3D)

Gets the nearest player's position. Will only work if the remote control belongs to an NPC

##### Declaration

```
bool GetNearestPlayer(out Vector3D playerPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | playerPosition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if was able to get player position |

#### GetWaypointInfo(List<MyWaypointInfo>)

Gets basic information about the currently configured waypoints.

##### Declaration

```
void GetWaypointInfo(List<MyWaypointInfo> waypoints)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyWaypointInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyWaypointInfo.html)\> | waypoints | Buffer array, results would be added into it |

#### SetAutoPilotEnabled(Boolean)

Enables or disables the autopilot.

##### Declaration

```
void SetAutoPilotEnabled(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled | Should be autopilot enabled or not |

#### SetCollisionAvoidance(Boolean)

Enables or disables collision avoidance.

##### Declaration

```
void SetCollisionAvoidance(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled | Should be collision avoidance enabled or not |

#### SetDockingMode(Boolean)

Enables or disables docking mode.

##### Declaration

```
void SetDockingMode(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled | Should be docking mode enabled or not |

### Extension Methods