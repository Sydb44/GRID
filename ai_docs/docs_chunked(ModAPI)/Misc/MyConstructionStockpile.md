---
title: "Class MyConstructionStockpile"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyConstructionStockpile.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyConstructionStockpile"
---

# Class MyConstructionStockpile | Space Engineers ModAPI

##### Inheritance

System.Object

MyConstructionStockpile

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyConstructionStockpile : Object
```

### Constructors

#### MyConstructionStockpile()

##### Declaration

```
public MyConstructionStockpile()
```

### Properties

#### LastChangeStamp

##### Declaration

```
public int LastChangeStamp { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### AddItems(Int32, MyDefinitionId, MyItemFlags)

##### Declaration

```
public bool AddItems(int count, MyDefinitionId contentId, MyItemFlags flags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | count |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | contentId |     |
| [MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html) | flags |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AddItems(Int32, MyObjectBuilder\_PhysicalObject)

##### Declaration

```
public bool AddItems(int count, MyObjectBuilder_PhysicalObject physicalObject)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | count |     |
| [MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html) | physicalObject |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ClearSyncList()

##### Declaration

```
public void ClearSyncList()
```

#### GetItemAmount(MyDefinitionId, MyItemFlags)

##### Declaration

```
public int GetItemAmount(MyDefinitionId contentId, MyItemFlags flags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | contentId |     |
| [MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html) | flags |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetItems()

##### Declaration

```
public List<MyStockpileItem> GetItems()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyStockpileItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyStockpileItem.html)\> |     |

#### GetObjectBuilder()

##### Declaration

```
public MyObjectBuilder_ConstructionStockpile GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ConstructionStockpile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ConstructionStockpile.html) |     |

#### GetSyncList()

##### Declaration

```
public List<MyStockpileItem> GetSyncList()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyStockpileItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyStockpileItem.html)\> |     |

#### Init(MyObjectBuilder\_ConstructionStockpile)

##### Declaration

```
public void Init(MyObjectBuilder_ConstructionStockpile objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ConstructionStockpile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ConstructionStockpile.html) | objectBuilder |     |

#### Init(MyObjectBuilder\_Inventory)

##### Declaration

```
public void Init(MyObjectBuilder_Inventory objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html) | objectBuilder |     |

#### IsEmpty()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveItems(Int32, MyDefinitionId, MyItemFlags)

##### Declaration

```
public bool RemoveItems(int count, MyDefinitionId id, MyItemFlags flags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | count |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | id  |     |
| [MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html) | flags |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveItems(Int32, MyObjectBuilder\_PhysicalObject)

##### Declaration

```
public bool RemoveItems(int count, MyObjectBuilder_PhysicalObject physicalObject)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | count |     |
| [MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html) | physicalObject |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |