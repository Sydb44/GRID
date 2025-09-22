---
title: "Class MyStoreItemData"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyStoreItemData.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "MyStoreItemData"
---

# Class MyStoreItemData | Space Engineers ModAPI

Implements Store Item Data

##### Inheritance

System.Object

MyStoreItemData

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyStoreItemData : ValueType
```

### Constructors

#### MyStoreItemData(SerializableDefinitionId, Int32, Int32, Action<Int32, Int32, Int64, Int64, Int64>, Action)

Store Item constructor

##### Declaration

```
public MyStoreItemData(SerializableDefinitionId itemId, int amount, int pricePerUnit, Action<int, int, long, long, long> onTransactionCallback, Action onCancelCallback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) | itemId | definition id of the item |
| System.Int32 | amount | amount for buy/sell |
| System.Int32 | pricePerUnit | price per unit |
| System.Action<System.Int32, System.Int32, System.Int64, System.Int64, System.Int64\> | onTransactionCallback | on transaction callback |
| System.Action | onCancelCallback | on cancel callback |

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
public SerializableDefinitionId ItemId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html) |     |

#### OnCancel

When owner of store block cancels order/offer regarding this item

##### Declaration

```
public Action OnCancel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnTransaction

When player makes an transaction regarding this item

int - amount sold int - amount remaining int - price of transaction long - owner of block long - buyer/seller

##### Declaration

```
public Action<int, int, long, long, long> OnTransaction { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<System.Int32, System.Int32, System.Int64, System.Int64, System.Int64\> |     |

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