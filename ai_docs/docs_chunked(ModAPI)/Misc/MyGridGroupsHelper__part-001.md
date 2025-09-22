---
title: "Class MyGridGroupsHelper"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGridGroupsHelper.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyGridGroupsHelper"
---

# Class MyGridGroupsHelper | Space Engineers ModAPI

##### Inheritance

System.Object

MyGridGroupsHelper

##### Implements

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyGridGroupsHelper : Object, IMyGridGroups
```

### Constructors

#### MyGridGroupsHelper()

##### Declaration

```
public MyGridGroupsHelper()
```

### Methods

#### AddGridGroupLogic<T>(GridLinkTypeEnum, Func<IMyGridGroupData, T>)

##### Declaration

```
public void AddGridGroupLogic<T>(GridLinkTypeEnum type, Func<IMyGridGroupData, T> creator)
    where T : MyGridGroupsDefaultEventHandler
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |
| System.Func<[IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html), T> | creator |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### FindConnection(GridLinkTypeEnum, IMyCubeGrid, Func<IMyCubeGrid, IMyCubeGrid, Int64, Boolean>)

##### Declaration

```
public List<KeyValuePair<long, IMyCubeGrid>> FindConnection(GridLinkTypeEnum linking, IMyCubeGrid from, Func<IMyCubeGrid, IMyCubeGrid, long, bool> searcher)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | linking |     |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | from |     |
| System.Func<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html), [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html), System.Int64, System.Boolean\> | searcher |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Int64, [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\>> |     |

#### GetGridGroup(GridLinkTypeEnum, IMyCubeGrid)

##### Declaration

```
public IMyGridGroupData GetGridGroup(GridLinkTypeEnum linking, IMyCubeGrid grid)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | linking |     |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html) |     |

#### GetGridGroups<T>(GridLinkTypeEnum, T)

##### Declaration

```
public T GetGridGroups<T>(GridLinkTypeEnum linking, T grids)
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

#### GetGroup(IMyCubeGrid, GridLinkTypeEnum)

##### Declaration

```
public List<IMyCubeGrid> GetGroup(IMyCubeGrid node, GridLinkTypeEnum type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | node |     |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\> |     |

#### GetGroup(IMyCubeGrid, GridLinkTypeEnum, ICollection<IMyCubeGrid>)

##### Declaration

```
public void GetGroup(IMyCubeGrid node, GridLinkTypeEnum type, ICollection<IMyCubeGrid> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | node |     |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |
| System.Collections.Generic.ICollection<[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)\> | collection |     |

#### HasConnection(IMyCubeGrid, IMyCubeGrid, GridLinkTypeEnum)

##### Declaration

```
public bool HasConnection(IMyCubeGrid grid1, IMyCubeGrid grid2, GridLinkTypeEnum type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid1 |     |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | grid2 |     |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Events

#### OnGridGroupCreated

##### Declaration

```
public event Action<IMyGridGroupData> OnGridGroupCreated
```
