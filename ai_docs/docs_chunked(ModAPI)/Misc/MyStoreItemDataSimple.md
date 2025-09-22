---
title: "Class MyStoreItemDataSimple"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyStoreItemDataSimple.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "MyStoreItemDataSimple"
---

# Class MyStoreItemDataSimple | Space Engineers ModAPI

##### Inheritance

System.Object

MyStoreItemDataSimple

###### **Namespace**: [VRage.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyStoreItemDataSimple : ValueType
```

### Constructors

#### MyStoreItemDataSimple(SerializableDefinitionId, Int32, Int32)

Store Item constructor

##### Declaration

```
public MyStoreItemDataSimple(SerializableDefinitionId itemId, int amount, int pricePerUnit)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) | itemId | definition id of the item |
| System.Int32 | amount | amount for buy/sell |
| System.Int32 | pricePerUnit | price per unit |

### Properties

#### Amount

Gets amount for buy/sell

##### Declaration

```
public int Amount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ItemId

Gets definition id of the item

##### Declaration

```
public MyItemType ItemId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) |     |

#### PricePerUnit

Gets price per unit

##### Declaration

```
public int PricePerUnit { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |