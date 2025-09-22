---
title: "Interface IMyGps"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGps.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGps"
---

# Interface IMyGps | Space Engineers ModAPI

Describes GPS (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

### Properties

#### ContainerRemainingTime

Gets or sets gps text that would be displayed on HUD

##### Declaration

```
string ContainerRemainingTime { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Remarks

#### Coords

Gets or sets GPS coordinates

##### Declaration

```
Vector3D Coords { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Description

Gets or sets GPS description

##### Declaration

```
string Description { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DiscardAt

If it's null then the GPS is confirmed (does not expire automatically). Otherwise, time at which we should drop it from the list, relative to ElapsedPlayTime

##### Declaration

```
Nullable<TimeSpan> DiscardAt { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.TimeSpan\> |     |

#### GPSColor

Gets or sets GPS color

##### Declaration

```
Color GPSColor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### Hash

The GPS entry id hash which is generated using the GPS name and coordinates.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Name

Gets or sets GPS name

##### Declaration

```
string Name { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ShowOnHud

Gets or sets whether GPS should be visible on HUD

##### Declaration

```
bool ShowOnHud { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ToString()

Gets information about GPS

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.String | String, same that user gets on `Copy to clipboard` |

#### UpdateHash()

Updates the hash id if you've changed the name or the coordinates. NOTE: Do not use this if you plan on using this object to update existing GPS entries.

##### Declaration