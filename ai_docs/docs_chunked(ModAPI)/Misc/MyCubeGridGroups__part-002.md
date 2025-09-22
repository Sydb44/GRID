
| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |
| System.Int64 | linkId |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | parent |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | child |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CreateLink(GridLinkTypeEnum, Int64, MyCubeGrid, MyCubeGrid)

Creates link between parent and child. Parent is owner of constraint. LinkId must be unique only for parent, for grid it can be packed position of block which created constraint.

##### Declaration

```
public void CreateLink(GridLinkTypeEnum type, long linkId, MyCubeGrid parent, MyCubeGrid child)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |
| System.Int64 | linkId |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | parent |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | child |     |

#### FindConnection(GridLinkTypeEnum, IMyCubeGrid, Func<IMyCubeGrid, IMyCubeGrid, Int64, Boolean>)

Dijkstra search over grid-to-grid connections until searcher is return true NOTE: pretty expensive function on large grid-groups, don't call it often.

##### Declaration

```
public static List<KeyValuePair<long, IMyCubeGrid>> FindConnection(GridLinkTypeEnum linking, IMyCubeGrid from, Func<IMyCubeGrid, IMyCubeGrid, long, bool> searcher)
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

#### GetGridGroup(GridLinkTypeEnum, MyCubeGrid)

##### Declaration

```
public static IMyGridGroupData GetGridGroup(GridLinkTypeEnum linking, MyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | linking |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html) |     |

#### GetGridGroups<T>(GridLinkTypeEnum, T)

##### Declaration

```
public static T GetGridGroups<T>(GridLinkTypeEnum linking, T grids)
    where T : ICollection<IMyGridGroupData>
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | linking |     |
| T   | grids |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetGroups(GridLinkTypeEnum)

##### Declaration

```
public MyGroupsBase<MyCubeGrid> GetGroups(GridLinkTypeEnum type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.Groups.MyGroupsBase<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\> |     |

#### RemoveNode(GridLinkTypeEnum, MyCubeGrid)

##### Declaration

```
public void RemoveNode(GridLinkTypeEnum type, MyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |

#### UpdateDynamicState(MyCubeGrid)

##### Declaration

```
public void UpdateDynamicState(MyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | grid |     |

### Events

#### OnGridGroupCreated
