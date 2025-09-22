---
title: "Interface IMyGridGroups"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroups.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGridGroups"
---

# Interface IMyGridGroups | Space Engineers ModAPI

ModAPI interface giving access to grid-groups

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGridGroups
```

### Methods

#### AddGridGroupLogic<T>(GridLinkTypeEnum, Func<IMyGridGroupData, T>)

##### Declaration

```
void AddGridGroupLogic<T>(GridLinkTypeEnum type, Func<IMyGridGroupData, T> creator)
    where T : MyGridGroupsDefaultEventHandler
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type | Type of linking |
| System.Func<[IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html), T> | creator | Function that creates grid group logic |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Type of grid group logic |

#### FindConnection(GridLinkTypeEnum, IMyCubeGrid, Func<IMyCubeGrid, IMyCubeGrid, Int64, Boolean>)

Dijkstra search over grid-to-grid connections until searcher is return true NOTE: pretty expensive function on large grid-groups, don't call it often.

##### Declaration

```
List<KeyValuePair<long, IMyCubeGrid>> FindConnection(GridLinkTypeEnum linking, IMyCubeGrid from, Func<IMyCubeGrid, IMyCubeGrid, long, bool> searcher)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | linking | Type of grid-group connection |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | from | Initial grid, from which search would start |
| System.Func<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html), [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html), System.Int64, System.Boolean\> | searcher | When this function returns true - search is stopped, and result is returned.<br><br>First arg - new grid<br><br>Second - previous grid<br><br>Last - block, that creates connection between those 2 grids. Note: There could be only one block per Grid-Grid connection<br><br>Note: first call would be called with (from, null, 0) |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int64, [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>> | Null if linking is `linking` is incorrect.<br><br>Null if `searcher` hasn't returned true.<br><br>Otherwise list of connections, where long is block entityId, and IMyCubeGrid - grid, where search is hopped<br><br>Note: first element would be always (from, 0) |

#### GetGridGroup(GridLinkTypeEnum, IMyCubeGrid)

Gets grid-group for provided grid

##### Declaration

```
IMyGridGroupData GetGridGroup(GridLinkTypeEnum linking, IMyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | linking | Type of linking |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid | One part of grid-group |

##### Returns

| Type | Description |
| --- | --- |
| [IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html) | Grid group interface |

#### GetGridGroups<T>(GridLinkTypeEnum, T)

Gets all grid groups, that exists in the world

##### Declaration

```
T GetGridGroups<T>(GridLinkTypeEnum linking, T grids)
    where T : ICollection<IMyGridGroupData>
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | linking | Type of linking |
| T   | grids | Collection would be filled with results |

##### Returns

| Type | Description |
| --- | --- |
| T   | Provided collection |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Type of collection |

#### GetGroup(IMyCubeGrid, GridLinkTypeEnum)

OBSOLETE: Use GetGroup with passing your own collection, it is better for simulation speed. Returns all grids connected to the given grid by the specified link type. Array always contains node.

##### Declaration

```
List<IMyCubeGrid> GetGroup(IMyCubeGrid node, GridLinkTypeEnum type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | node | One of grid group |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type | Type of linking |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\> | New list of connected grids |

#### GetGroup(IMyCubeGrid, GridLinkTypeEnum, ICollection<IMyCubeGrid>)

Returns all grids connected to the given grid by the specified link type. Array always contains node.

##### Declaration

```
void GetGroup(IMyCubeGrid node, GridLinkTypeEnum type, ICollection<IMyCubeGrid> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | node | One of grid |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type | Type of grid linking |
| System.Collections.Generic.ICollection<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\> | collection | Collection where connected grids would be added |
