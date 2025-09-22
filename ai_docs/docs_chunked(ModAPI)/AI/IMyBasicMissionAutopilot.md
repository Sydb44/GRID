---
title: "Interface IMyBasicMissionAutopilot"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyBasicMissionAutopilot.html"
category: "AI"
namespace: "Sandbox.ModAPI"
class: "IMyBasicMissionAutopilot"
---

# Interface IMyBasicMissionAutopilot | Space Engineers ModAPI

Describes autopilot mission for the Basic AI block

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyBasicMissionAutopilot : IMyBasicMissionComponent, IMyBasicMissionComponent
```

### Properties

#### Mode

Current FlightMode

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [FlightMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.FlightMode.html) |     |

### Methods

#### AddWaypoint(IMyAutopilotWaypoint)

Adds waypoint

##### Declaration

```
void AddWaypoint(IMyAutopilotWaypoint waypoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html) | waypoint |     |

#### AddWaypoint(IMyGps)

Adds waypoint from gps

##### Declaration

```
void AddWaypoint(IMyGps gps)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyGps](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html) | gps |     |

#### ClearWaypoints()

Removes all waypoints

##### Declaration

#### GetLastWaypoint()

Gets the last waypoint

##### Declaration

```
IMyAutopilotWaypoint GetLastWaypoint()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html) |     |

#### GetWaypoints(List<IMyAutopilotWaypoint>)

Gets list of waypoints in this component

##### Declaration

```
void GetWaypoints(List<IMyAutopilotWaypoint> points)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html)\> | points |     |

#### RemoveWaypoint(IMyAutopilotWaypoint)

Removes waypoint

##### Declaration

```
void RemoveWaypoint(IMyAutopilotWaypoint waypoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyAutopilotWaypoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAutopilotWaypoint.html) | waypoint | Waypoint to remove |

#### SetMode(FlightMode)

Sets current FlightMode

##### Declaration

```
void SetMode(FlightMode mode)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [FlightMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.FlightMode.html) | mode |     |