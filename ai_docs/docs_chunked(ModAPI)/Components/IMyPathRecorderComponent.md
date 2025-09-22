---
title: "Interface IMyPathRecorderComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyPathRecorderComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyPathRecorderComponent"
---

# Interface IMyPathRecorderComponent | Space Engineers ModAPI

Ingame interfave for PB and mods

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyPathRecorderComponent
```

### Properties

#### BeaconDisplayText

Gets Beacon display text

##### Declaration

```
string BeaconDisplayText { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### BeaconEntityId

Entity of beacon in which the waypoints are in relation to

##### Declaration

```
Nullable<long> BeaconEntityId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### BeaconWorldPosition

Gets BeaconWorldPosition

##### Declaration

```
Vector3D BeaconWorldPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### IsPlaying

Gets bool if the PR block is playing

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRecording

Get bool if the PR block is recording

##### Declaration

```
bool IsRecording { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MinimalDistance

Gets/sets minimal distance between waypoints for automatic recording to record new waypoint

##### Declaration

```
float MinimalDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RecordInterval

Gets/sets record interval. Sets how often the block tries to records its position as a waypoint. Operates every 100 frames

##### Declaration

```
byte RecordInterval { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### RepeatPath

Repeat path toggle

##### Declaration

```
bool RepeatPath { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowPath

Gets/sets if block is showing path on clients screen

##### Declaration

```
bool ShowPath { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowSelectedPoints

Gets/sets if block is showing points, selected by client on his screen

##### Declaration

```
bool ShowSelectedPoints { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Play()

Starts playing current waypoints

##### Declaration

#### Record()

Starts recording

##### Declaration

#### RemoveBeacon()

Sets BeaconEntityId = 0

##### Declaration

#### StopPlay()

Stops playing current waypoints

##### Declaration

#### StopRecord()

Stops recording

##### Declaration