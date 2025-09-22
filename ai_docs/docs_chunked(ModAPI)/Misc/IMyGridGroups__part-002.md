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

#### HasConnection(IMyCubeGrid, IMyCubeGrid, GridLinkTypeEnum)

Checks if two grids are connected by the given link type.

##### Declaration

```
bool HasConnection(IMyCubeGrid grid1, IMyCubeGrid grid2, GridLinkTypeEnum type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid1 | Grid 1 |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid2 | Grid 2 |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type | Type of connection |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True when 2 grids connected with specified grid linking |

### Events

#### OnGridGroupCreated

Called when new grid-group was created. Example 1: 1 large grid-group splitted into 2 parts. Example 2: new grid created

##### Declaration

```
event Action<IMyGridGroupData> OnGridGroupCreated
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html)\> |     |

#### OnGridGroupDestroyed

Called when grid-group was destroyed. Example 1: 2 small grids-groups joined into larger one. Example 2: grid, not connected to any other grid, was destroyed

##### Declaration

```
event Action<IMyGridGroupData> OnGridGroupDestroyed
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html)\> |     |