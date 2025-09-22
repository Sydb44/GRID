---
title: "Class MyGridTargeting"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyGridTargeting.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyGridTargeting"
---

# Class MyGridTargeting | Space Engineers ModAPI

##### Inheritance

System.Object

MyGridTargeting

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyGridTargeting : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyGridTargeting()

##### Declaration

### Fields

#### AllowScanning

##### Declaration

```
public bool AllowScanning
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RaycastGridGroupVisibilityConnection

##### Declaration

```
public const GridLinkTypeEnum RaycastGridGroupVisibilityConnection
```

##### Field Value

| Type | Description |
| --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) |     |

### Properties

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### ScanLock

##### Declaration

```
public FastResourceLock ScanLock { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.FastResourceLock |     |

#### TargetBlocks

##### Declaration

```
public MyListDictionary<MyCubeGrid, MyEntity> TargetBlocks { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.MyListDictionary<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

### Methods

#### GetTargetRoots(Boolean, Boolean, Boolean, List<MyEntity>)

##### Declaration

```
public void GetTargetRoots(bool enemies, bool neutrals, bool friends, List<MyEntity> buffer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enemies |     |
| System.Boolean | neutrals |     |
| System.Boolean | friends |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | buffer |     |

#### IsTargetLocked(MyEntity)

##### Declaration

```
public bool IsTargetLocked(MyEntity target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | target |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### PrepareGridGroups(Boolean, Boolean, Boolean, List<List<Int64>>, List<Int64>, Boolean)

Removing from ignore lists grids that can't be targeted

##### Declaration

```
public void PrepareGridGroups(bool enemies, bool neutrals, bool friends, List<List<long>> gridGroups, List<long> suggestedTargetGridGroup, bool canRescan = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enemies | Can target enemies |
| System.Boolean | neutrals | Can target neutrals |
| System.Boolean | friends | Can target friends |
| System.Collections.Generic.List<System.Collections.Generic.List<System.Int64\>> | gridGroups | Ignore lists |
| System.Collections.Generic.List<System.Int64\> | suggestedTargetGridGroup | Ignore list |
| System.Boolean | canRescan | Can start new scan |

#### RescanIfNeeded()

##### Declaration

```
public void RescanIfNeeded()
```

#### SetLockedGridsOrCharacters(ICollection<Int64>)

##### Declaration

```
public void SetLockedGridsOrCharacters(ICollection<long> lockedGrids)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.ICollection<System.Int64\> | lockedGrids |     |

#### UpdateGridConnections(List<List<Int64>>, List<Int64>, MyEntity)

##### Declaration

```
public void UpdateGridConnections(List<List<long>> gridGroups, List<long> gridsGroupsForSuggested, MyEntity suggestedEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.Collections.Generic.List<System.Int64\>> | gridGroups |     |
| System.Collections.Generic.List<System.Int64\> | gridsGroupsForSuggested |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | suggestedEntity |     |

### Extension Methods