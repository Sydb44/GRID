---
title: "Class MyEntityList"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEntityList"
---

# Class MyEntityList | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityList

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyEntityList : Object
```

### Methods

#### GetDescriptionText(MyEntityList.MyEntityListInfoItem)

##### Declaration

```
public static string GetDescriptionText(MyEntityList.MyEntityListInfoItem item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityList.MyEntityListInfoItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntityListInfoItem.html) | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetEntityList(MyEntityList.MyEntityTypeEnum)

##### Declaration

```
public static List<MyEntityList.MyEntityListInfoItem> GetEntityList(MyEntityList.MyEntityTypeEnum selectedType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityList.MyEntityTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntityTypeEnum.html) | selectedType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyEntityList.MyEntityListInfoItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntityListInfoItem.html)\> |     |

#### GetEntityList(MyEntityList.MyEntityTypeEnum, IEnumerable<MyEntity>)

##### Declaration

```
public static List<MyEntityList.MyEntityListInfoItem> GetEntityList(MyEntityList.MyEntityTypeEnum selectedType, IEnumerable<MyEntity> entities)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityList.MyEntityTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntityTypeEnum.html) | selectedType |     |
| System.Collections.Generic.IEnumerable<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | entities |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyEntityList.MyEntityListInfoItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntityListInfoItem.html)\> |     |

#### GetFormattedDisplayName(MyEntityList.MyEntitySortOrder, MyEntityList.MyEntityListInfoItem)

##### Declaration

```
public static StringBuilder GetFormattedDisplayName(MyEntityList.MyEntitySortOrder selectedOrder, MyEntityList.MyEntityListInfoItem item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityList.MyEntitySortOrder](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntitySortOrder.html) | selectedOrder |     |
| [MyEntityList.MyEntityListInfoItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntityListInfoItem.html) | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

#### GetPlayersMinimalDistance(MyEntity, ICollection<MyPlayer>)

##### Declaration

```
public static float GetPlayersMinimalDistance(MyEntity entity, ICollection<MyPlayer> players)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Collections.Generic.ICollection<Sandbox.Game.World.MyPlayer\> | players |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProceedEntityAction(MyEntity, MyEntityList.EntityListAction)

##### Declaration

```
public static void ProceedEntityAction(MyEntity entity, MyEntityList.EntityListAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| [MyEntityList.EntityListAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.EntityListAction.html) | action |     |

#### SortEntityList(MyEntityList.MyEntitySortOrder, ref List<MyEntityList.MyEntityListInfoItem>, Boolean)

##### Declaration

```
public static void SortEntityList(MyEntityList.MyEntitySortOrder selectedOrder, ref List<MyEntityList.MyEntityListInfoItem> items, bool invertOrder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityList.MyEntitySortOrder](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntitySortOrder.html) | selectedOrder |     |
| System.Collections.Generic.List<[MyEntityList.MyEntityListInfoItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityList.MyEntityListInfoItem.html)\> | items |     |
| System.Boolean | invertOrder |     |