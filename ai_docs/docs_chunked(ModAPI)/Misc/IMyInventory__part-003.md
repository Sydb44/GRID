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

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True in case item was successfully transferred, false otherwise |

#### TransferItemTo(IMyInventory, Int32, Nullable<Int32>, Nullable<Boolean>, Nullable<MyFixedPoint>)

Attempts to transfer item from one inventory to another.

##### Declaration

```
bool TransferItemTo(IMyInventory dst, int sourceItemIndex, Nullable<int> targetItemIndex = null, Nullable<bool> stackIfPossible = null, Nullable<MyFixedPoint> amount = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) | dst | Inventory to transfer item to |
| System.Int32 | sourceItemIndex | Zero-based index of inventory slot to transfer item from |
| System.Nullable<System.Int32\> | targetItemIndex | Zero-based index of inventory slot to transfer item to |
| System.Nullable<System.Boolean\> | stackIfPossible | If true, engine will attempt to stack items at destination inventory |
| System.Nullable<VRage.MyFixedPoint\> | amount | Amount that should be transferred. Kgs or count, based on item type |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True in case item was successfully transferred, false otherwise |

#### TransferItemTo(IMyInventory, MyInventoryItem, Nullable<MyFixedPoint>)

Attempts to transfer item from one inventory to another.

##### Declaration

```
bool TransferItemTo(IMyInventory dstInventory, MyInventoryItem item, Nullable<MyFixedPoint> amount = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html) | dstInventory | Inventory to transfer item to |
| [MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html) | item | Item to transfer |
| System.Nullable<VRage.MyFixedPoint\> | amount | Amount that should be transferred. Kgs or count, based on item type |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True in case item was successfully transferred, false otherwise |