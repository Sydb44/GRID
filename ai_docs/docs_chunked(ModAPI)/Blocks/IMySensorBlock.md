---
title: "Interface IMySensorBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMySensorBlock.html"
category: "Blocks"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMySensorBlock"
---

# Interface IMySensorBlock | Space Engineers ModAPI

Describes sensor block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySensorBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### BackExtend

Gets or sets the back range of the sensor.

##### Declaration

```
float BackExtend { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BottomExtend

Gets or sets the bottom range of the sensor.

##### Declaration

```
float BottomExtend { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DetectAsteroids

Gets or sets if the sensor should detect asteroids or planets.

##### Declaration

```
bool DetectAsteroids { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DetectEnemy

Gets or sets if the sensor should detect enemy players.

##### Declaration

```
bool DetectEnemy { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Remarks

#### DetectFloatingObjects

Gets or sets if the sensor should detect floating objects (components, rocks).

##### Declaration

```
bool DetectFloatingObjects { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DetectFriendly

Gets or sets if the sensor should detect friendly players.

##### Declaration

```
bool DetectFriendly { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Remarks

#### DetectLargeShips

Gets or sets if the sensor should detect large ships.

##### Declaration

```
bool DetectLargeShips { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DetectNeutral

Gets or sets if the sensor should detect neutral players.

##### Declaration

```
bool DetectNeutral { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Remarks

#### DetectOwner

Gets or sets if the sensor should detect the block owner.

##### Declaration

```
bool DetectOwner { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Remarks

#### DetectPlayers

Gets or sets if the sensor should detect players.

##### Declaration

```
bool DetectPlayers { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DetectSmallShips

Gets or sets if the sensor should detect small ships.

##### Declaration

```
bool DetectSmallShips { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DetectStations

Gets or sets if the sensor should detect large stations.

##### Declaration

```
bool DetectStations { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DetectSubgrids

Gets or sets if the sensor should detect subgrids (eg. connected by connector).

##### Declaration

```
bool DetectSubgrids { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FrontExtend

Gets or sets the front range of the sensor.

##### Declaration

```
float FrontExtend { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsActive

Gets if there is any entity currently being detected.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LastDetectedEntity

Gets the last detected entity

##### Declaration

```
MyDetectedEntityInfo LastDetectedEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) |     |

#### LeftExtend

Gets or sets the left range of the sensor.

##### Declaration

```
float LeftExtend { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxRange

Gets the maximum range of the sensor in any direction.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PlayProximitySound

Gets or sets if the proximity sound plays when an entity is detected.

##### Declaration

```
bool PlayProximitySound { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RightExtend

Gets or sets the right range of the sensor.

##### Declaration

```
float RightExtend { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TopExtend

Gets or sets the top range of the sensor.

##### Declaration

```
float TopExtend { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### DetectedEntities(List<MyDetectedEntityInfo>)

Gets the list of detected entities

##### Declaration

```
void DetectedEntities(List<MyDetectedEntityInfo> entities)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html)\> | entities | return list of entities |

### Extension Methods