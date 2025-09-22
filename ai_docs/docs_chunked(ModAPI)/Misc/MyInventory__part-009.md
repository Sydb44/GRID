targetItemIndex

System.Nullable<System.Boolean\>

stackIfPossible

System.Nullable<VRage.MyFixedPoint\>

amount

System.Boolean

checkConnection

##### Returns

Type

Description

System.Boolean

#### IMyInventory.CanItemsBeAdded(MyFixedPoint, MyItemType)

##### Declaration

```
bool IMyInventory.CanItemsBeAdded(MyFixedPoint amount, MyItemType itemType)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html)

itemType

##### Returns

Type

Description

System.Boolean

#### IMyInventory.CanPutItems

##### Declaration

```
bool IMyInventory.CanPutItems { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyInventory.CanTransferItemTo(IMyInventory, MyItemType)

##### Declaration

```
bool IMyInventory.CanTransferItemTo(IMyInventory dst, MyItemType itemType)
```

##### Parameters

Type

Name

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html)

dst

[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html)

itemType

##### Returns

Type

Description

System.Boolean

#### IMyInventory.ContainItems(MyFixedPoint, MyItemType)

##### Declaration

```
bool IMyInventory.ContainItems(MyFixedPoint amount, MyItemType itemType)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html)

itemType

##### Returns

Type

Description

System.Boolean

#### IMyInventory.FindItem(MyItemType)

##### Declaration

```
Nullable<MyInventoryItem> IMyInventory.FindItem(MyItemType itemType)
```

##### Parameters

Type

Name

Description

[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html)

itemType

##### Returns

Type

Description

System.Nullable<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html)\>

#### IMyInventory.GetAcceptedItems(List<MyItemType>, Func<MyItemType, Boolean>)

##### Declaration

```
void IMyInventory.GetAcceptedItems(List<MyItemType> items, Func<MyItemType, bool> filter)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html)\>

items

System.Func<[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html), System.Boolean\>

filter

#### IMyInventory.GetItemAmount(MyItemType)

##### Declaration

```
MyFixedPoint IMyInventory.GetItemAmount(MyItemType contentId)
```

##### Parameters

Type

Name

Description

[MyItemType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyItemType.html)

contentId

##### Returns

Type

Description

VRage.MyFixedPoint

#### IMyInventory.GetItemByID(UInt32)

##### Declaration

```
Nullable<MyInventoryItem> IMyInventory.GetItemByID(uint id)
```

##### Parameters

Type

Name

Description

System.UInt32

id

##### Returns

Type

Description

System.Nullable<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html)\>

#### IMyInventory.GetItems(List<MyInventoryItem>, Func<MyInventoryItem, Boolean>)

##### Declaration

```
void IMyInventory.GetItems(List<MyInventoryItem> items, Func<MyInventoryItem, bool> filter)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html)\>

items

System.Func<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html), System.Boolean\>

filter

#### IMyInventory.IsConnectedTo(IMyInventory)

##### Declaration

```
bool IMyInventory.IsConnectedTo(IMyInventory dst)
```

##### Parameters

Type

Name

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html)

dst

##### Returns

Type

Description

System.Boolean

#### IMyInventory.Owner

##### Declaration

```
IMyEntity IMyInventory.Owner { get; }
```

##### Returns

Type

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyEntity.html)

#### IMyInventory.TransferItemFrom(IMyInventory, Int32, Nullable<Int32>, Nullable<Boolean>, Nullable<MyFixedPoint>)

##### Declaration

```
bool IMyInventory.TransferItemFrom(IMyInventory sourceInventory, int sourceItemIndex, Nullable<int> targetItemIndex, Nullable<bool> stackIfPossible, Nullable<MyFixedPoint> amount)
```

##### Parameters

Type

Name

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html)

sourceInventory

System.Int32

sourceItemIndex

System.Nullable<System.Int32\>

targetItemIndex

System.Nullable<System.Boolean\>

stackIfPossible

System.Nullable<VRage.MyFixedPoint\>

amount

##### Returns

Type

Description

System.Boolean

#### IMyInventory.TransferItemFrom(IMyInventory, MyInventoryItem, Nullable<MyFixedPoint>)

##### Declaration

```
bool IMyInventory.TransferItemFrom(IMyInventory sourceInventory, MyInventoryItem item, Nullable<MyFixedPoint> amount)
```

##### Parameters

Type

Name

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventory.html)

sourceInventory

[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html)

item

System.Nullable<VRage.MyFixedPoint\>

amount

##### Returns

Type

Description

System.Boolean

#### IMyInventory.TransferItemTo(IMyInventory, Int32, Nullable<Int32>, Nullable<Boolean>, Nullable<MyFixedPoint>)
