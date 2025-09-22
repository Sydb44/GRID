---
title: "Interface IMyGridGroupData"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGridGroupData"
---

# Interface IMyGridGroupData | Space Engineers ModAPI

A class that presenting connection between grids WARNING: you must not keep link to instance or you have to remove link when event OnReleased is fired Use Get/SetVariable to store data in GridGroups. Variables are cleared after OnRelease is fired

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGridGroupData
```

### Properties

#### LinkType

Get connection type

##### Declaration

```
GridLinkTypeEnum LinkType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) |     |

### Methods

#### GetGrids<T>(T)

Gets grids in this grid-group

##### Declaration

```
T GetGrids<T>(T grids)
    where T : ICollection<IMyCubeGrid>
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | grids | Collection, that would receive grids |

##### Returns

| Type | Description |
| --- | --- |
| T   | Grids stored in provided collection |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Generic type of collection |

#### GetVariable<T>(Guid)

Gets memory-stored variable

##### Declaration

```
T GetVariable<T>(Guid key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | key | Key to access variable in dictionary |

##### Returns

| Type | Description |
| --- | --- |
| T   | Variable that stored by key, or default value for type T (null) |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Type of stored value |

#### RemoveVariable(Guid)

Removes stored variable

##### Declaration

```
bool RemoveVariable(Guid key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | key | Key to access variable in dictionary |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True, if removed |

#### SetVariable(Guid, Object)

Sets memory-stored variable

##### Declaration

```
void SetVariable(Guid key, object data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | key | Key to access variable in dictionary |
| System.Object | data | Stored variable |

#### TryGetVariable<T>(Guid, out T)

Gets memory-stored variable

##### Declaration

```
bool TryGetVariable<T>(Guid key, out T variable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Guid | key | Key to access variable in dictionary |
| T   | variable | Variable that stored by key, or default value for type T (null) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True, when variable found, false when not |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Type of stored value |

### Events

#### OnGridAdded

First MyGridGroupData(this) - where grid would be added Second MyGridGroupData(Nullable) - previous grid group of grid

##### Declaration

```
event Action<IMyGridGroupData, IMyCubeGrid, IMyGridGroupData> OnGridAdded
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html), [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html), [IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html)\> |     |

#### OnGridRemoved

First MyGridGroupData(this) - from where grid was removed Second MyGridGroupData(Nullable) - where grid group would be added

Called after Keen OnAdded logic, like MyGridLogicalGroupData.OnNodeAdded

##### Declaration

```
event Action<IMyGridGroupData, IMyCubeGrid, IMyGridGroupData> OnGridRemoved
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html), [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html), [IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html)\> |     |

#### OnReleased

You must clean your subscriptions here. Instances of IMyGridGroupData are re-used in ObjectPool. At the time event is called it has no grids attached to it.

##### Declaration

```
event Action<IMyGridGroupData> OnReleased
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyGridGroupData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridGroupData.html)\> |     |