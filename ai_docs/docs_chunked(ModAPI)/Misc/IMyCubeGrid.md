---
title: "Interface IMyCubeGrid"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeGrid.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "IMyCubeGrid"
---

# Interface IMyCubeGrid | Space Engineers ModAPI

Grid interface

##### Inherited Members

###### **Namespace**: [VRage.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyCubeGrid : IMyEntity
```

### Properties

#### CustomName

Getter and setter for display name of the grid (as seen in Info terminal tab)

##### Declaration

```
string CustomName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### GridSize

Getter of grid size in meters

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GridSizeEnum

Getter for grid size enum

##### Declaration

```
MyCubeSize GridSizeEnum { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html) |     |

#### IsStatic

Determines if the grid is static (unmoveable)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LinearVelocity

Gets linear velocity of the grid

##### Declaration

```
Vector3 LinearVelocity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Max

Maximum coordinates of blocks in grid

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Min

Minimum coordinates of blocks in grid

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Speed

Gets speed of the grid calculated from Linear Velocity. Rounded to two decimal places.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### CubeExists(Vector3I)

Returns true if there is any block occupying given position

##### Declaration

```
bool CubeExists(Vector3I pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | pos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if block exists |

#### GetCubeBlock(Vector3I)

Get cube block at given position

##### Declaration

```
IMySlimBlock GetCubeBlock(Vector3I pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | pos | Block position |

##### Returns

| Type | Description |
| --- | --- |
| [IMySlimBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMySlimBlock.html) | Block or null if none is present at given position |

#### GridIntegerToWorld(Vector3I)

Converts grid coordinates to world space

##### Declaration

```
Vector3D GridIntegerToWorld(Vector3I gridCoords)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | gridCoords |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | Vector in world coordinates |

#### IsSameConstructAs(IMyCubeGrid)

Determines whether this grid is [Mechanical](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html#VRage_Game_ModAPI_GridLinkTypeEnum_Mechanical) connected to the other. This is any grid connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.

Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.

##### Declaration

```
bool IsSameConstructAs(IMyCubeGrid other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeGrid.html) | other | Other grid |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if grid connected with [Mechanical](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html#VRage_Game_ModAPI_GridLinkTypeEnum_Mechanical) linking |

#### WorldToGridInteger(Vector3D)

Converts world coordinates to grid space cell coordinates

##### Declaration

```
Vector3I WorldToGridInteger(Vector3D coords)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | coords |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | Vector in world grid coordinates |