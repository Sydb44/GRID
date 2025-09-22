---
title: "Interface IMyStoreItem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyStoreItem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyStoreItem"
---

# Interface IMyStoreItem | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyStoreItem
```

### Properties

#### Amount

The amount of the item that is available for purchase in the store

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Id

The entity id of the store item

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### IsActive

Determines if Amount is greater than 0

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsCustomStoreItem

Determines if the item should behave similar to how store items in Vanilla Economy Stations work (eg: doesn't require physical inventory). This is required when adding Gas / Grid items to a store.

##### Declaration

```
bool IsCustomStoreItem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Item

Definition Id of the item

##### Declaration

```
Nullable<SerializableDefinitionId> Item { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)\> |     |

#### ItemType

The type of item. eg: PhysicalItem, Grid, etc

##### Declaration

```
ItemTypes ItemType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ItemTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.ItemTypes.html) |     |

#### PrefabName

The name of the Prefab Definition SubtypeId if the item is a Grid

##### Declaration

```
string PrefabName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### PrefabTotalPcu

The PCU value of a Grid item

##### Declaration

```
int PrefabTotalPcu { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### PricePerUnit

The individual cost of a single item.

##### Declaration

```
int PricePerUnit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### PricePerUnitDiscount

This governs the tooltip that appears when you hover your cursor over the price in the store (eg: 0.5 for 50% discount). This doesn't actually affect the price, use Amount to adjust that.

##### Declaration

```
float PricePerUnitDiscount { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RemovedAmount

The amount that has been removed from the item through purchases (ie: Purchased Amount)

##### Declaration

```
int RemovedAmount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### StoreItemType

Defines whether the item is an Offer (store is selling to you) or an Order (store is buying from you)

##### Declaration

```
StoreItemTypes StoreItemType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [StoreItemTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.StoreItemTypes.html) |     |

### Events

#### OnCancel

When owner of store block cancels order/offer regarding this item

##### Declaration

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnTransaction

When player makes an transaction regarding this item

int - amount sold int - amount remaining int - price of transaction long - owner of block long - buyer/seller

##### Declaration

```
event Action<int, int, long, long, long> OnTransaction
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int32, System.Int32, System.Int64, System.Int64, System.Int64\> |     |