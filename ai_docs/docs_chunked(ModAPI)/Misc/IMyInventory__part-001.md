---
title: "Interface IMyInventory"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Ingame"
class: "IMyInventory"
---

# Interface IMyInventory | Space Engineers ModAPI

Describes inventory interface (PB scripting interface)

###### **Namespace**: [VRage.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyInventory
```

### Properties

#### CanPutItems

Gets if inventory can receive items or not.

##### Declaration

```
bool CanPutItems { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CurrentMass

Returns total mass of items inside this inventory in Kg.

##### Declaration

```
MyFixedPoint CurrentMass { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### CurrentVolume

Returns total volume of items inside this inventory in m^3.

##### Declaration

```
MyFixedPoint CurrentVolume { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### IsFull

Determines if inventory is absolutely full.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ItemCount

Returns number of occupied inventory slots.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MaxVolume

Sets maximum volume of items this inventory can contain in m^3.

##### Declaration

```
MyFixedPoint MaxVolume { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### Owner

Returns entity this inventory belongs to.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyEntity.html) |     |

#### VolumeFillFactor

Gets the current volume fill factor of the inventory

##### Declaration

```
float VolumeFillFactor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### CanItemsBeAdded(MyFixedPoint, MyItemType)

Determines if given amount of items fits into this inventory on top of existing items.

##### Declaration

```
bool CanItemsBeAdded(MyFixedPoint amount, MyItemType itemType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyFixedPoint | amount | Amount of items being tested |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) | itemType | Type of items being tested |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if items can fit into this inventory on top of existing items, false otherwise |

#### CanTransferItemTo(IMyInventory, MyItemType)

Determines if there is working conveyor connection for item of give type to be transferred to other inventory.

##### Declaration

```
bool CanTransferItemTo(IMyInventory otherInventory, MyItemType itemType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) | otherInventory | Inventory to check the connection to |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) | itemType | Type of item to check the connection for |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if there is working conveyor connection between inventories so that item of give type can by transferred, false otherwise |

#### ContainItems(MyFixedPoint, MyItemType)

Determines if there is at least given amount of items of given type contained inside this inventory.

##### Declaration

```
bool ContainItems(MyFixedPoint amount, MyItemType itemType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyFixedPoint | amount | Threshold amount. Kg or count, based on item type |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) | itemType | Item type its amount is queried |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True in case there is sufficient amount of items present inside this inventory, false otherwise |

#### FindItem(MyItemType)

Tries to find an item of given type inside this inventory.

##### Declaration

```
Nullable<MyInventoryItem> FindItem(MyItemType itemType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) | itemType | Type of item being queried |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html)\> | Info about item found, null in case there is no item of given type inside this inventory |

#### GetAcceptedItems(List<MyItemType>, Func<MyItemType, Boolean>)

Returns all items this inventory accepts.

##### Declaration

```
void GetAcceptedItems(List<MyItemType> itemsTypes, Func<MyItemType, bool> filter = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html)\> | itemsTypes | Collection the item types info will be returned to |
| System.Func<[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html), System.Boolean\> | filter | Filter function you can use to decide whether to add item type into the itemsTypes collection or not |
