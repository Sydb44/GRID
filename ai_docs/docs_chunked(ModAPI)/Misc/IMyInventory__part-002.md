
##### Declaration

```
void GetAcceptedItems(List<MyItemType> itemsTypes, Func<MyItemType, bool> filter = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html)\> | itemsTypes | Collection the item types info will be returned to |
| System.Func<[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html), System.Boolean\> | filter | Filter function you can use to decide whether to add item type into the itemsTypes collection or not |

#### GetItemAmount(MyItemType)

Sums up total amount of items of given type contained inside this inventory.

##### Declaration

```
MyFixedPoint GetItemAmount(MyItemType itemType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html) | itemType | Item type its amount is queried |

##### Returns

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint | Total amount of given item type contained inside this inventory. Kg or count, based on item type |

#### GetItemAt(Int32)

Returns info about item at give position.

##### Declaration

```
Nullable<MyInventoryItem> GetItemAt(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Zero-based index of queried inventory slot |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html)\> | Info about queried inventory slot, null in case there is no item at given slot |

#### GetItemByID(UInt32)

Returns info about item contained inside this inventory.

##### Declaration

```
Nullable<MyInventoryItem> GetItemByID(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  | Id of queried item |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html)\> | Info about queried item, null in case there is no item with given Id inside this inventory |

#### GetItems(List<MyInventoryItem>, Func<MyInventoryItem, Boolean>)

Collects all items present inside this inventory and returns snapshot of the current inventory state.

##### Declaration

```
void GetItems(List<MyInventoryItem> items, Func<MyInventoryItem, bool> filter = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html)\> | items | Collection the item info will be returned to |
| System.Func<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html), System.Boolean\> | filter | Filter function you can use to decide whether to add item into the items collection or not |

#### IsConnectedTo(IMyInventory)

Checks if two inventories are connected.

##### Declaration

```
bool IsConnectedTo(IMyInventory otherInventory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) | otherInventory | Inventory to check the connection to |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if there is working conveyor connection between inventories, false otherwise |

#### IsItemAt(Int32)

Determines if there is any item on given inventory slot.

##### Declaration

```
bool IsItemAt(int position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | position | Zero-based index of queried inventory slot |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True in case given inventory slot is occupied, false otherwise |

#### TransferItemFrom(IMyInventory, Int32, Nullable<Int32>, Nullable<Boolean>, Nullable<MyFixedPoint>)

Attempts to transfer item from one inventory to another.

##### Declaration

```
bool TransferItemFrom(IMyInventory sourceInventory, int sourceItemIndex, Nullable<int> targetItemIndex = null, Nullable<bool> stackIfPossible = null, Nullable<MyFixedPoint> amount = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) | sourceInventory | Inventory to transfer item from |
| System.Int32 | sourceItemIndex | Zero-based index of inventory slot to transfer item from |
| System.Nullable<System.Int32\> | targetItemIndex | Zero-based index of inventory slot to transfer item to |
| System.Nullable<System.Boolean\> | stackIfPossible | If true, engine will attempt to stack items at destination inventory |
| System.Nullable<VRage.MyFixedPoint\> | amount | Amount that should be transferred. Kgs or count, based on item type |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True in case item was successfully transferred, false otherwise |

#### TransferItemFrom(IMyInventory, MyInventoryItem, Nullable<MyFixedPoint>)

Attempts to transfer item from one inventory to another.

##### Declaration

```
bool TransferItemFrom(IMyInventory sourceInventory, MyInventoryItem item, Nullable<MyFixedPoint> amount = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) | sourceInventory | Inventory to transfer item from |
| [MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html) | item | Item to transfer |
| System.Nullable<VRage.MyFixedPoint\> | amount | Amount that should be transferred. Kgs or count, based on item type |
