Type

Name

Description

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventoryItem.html)

item

VRage.MyFixedPoint

amount

##### Returns

Type

Description

System.Boolean

#### IMyInventory.CanPutItems

##### Declaration

```
bool IMyInventory.CanPutItems { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyInventory.FindItem(SerializableDefinitionId)

##### Declaration

```
IMyInventoryItem IMyInventory.FindItem(SerializableDefinitionId contentId)
```

##### Parameters

Type

Name

Description

[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)

contentId

##### Returns

Type

Description

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventoryItem.html)

#### IMyInventory.GetItemByID(UInt32)

##### Declaration

```
IMyInventoryItem IMyInventory.GetItemByID(uint id)
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

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventoryItem.html)

#### IMyInventory.GetItems()

##### Declaration

```
List<IMyInventoryItem> IMyInventory.GetItems()
```

##### Returns

Type

Description

System.Collections.Generic.List<[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventoryItem.html)\>

#### IMyInventory.Owner

##### Declaration

```
IMyEntity IMyInventory.Owner { get; }
```

##### Returns

Type

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

#### IMyInventory.RemoveItemAmount(IMyInventoryItem, MyFixedPoint)

##### Declaration

```
void IMyInventory.RemoveItemAmount(IMyInventoryItem item, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventoryItem.html)

item

VRage.MyFixedPoint

amount

#### IMyInventory.RemoveItems(UInt32, Nullable<MyFixedPoint>, Boolean, Boolean)

##### Declaration

```
void IMyInventory.RemoveItems(uint itemId, Nullable<MyFixedPoint> amount, bool sendEvent, bool spawn)
```

##### Parameters

Type

Name

Description

System.UInt32

itemId

System.Nullable<VRage.MyFixedPoint\>

amount

System.Boolean

sendEvent

System.Boolean

spawn

#### IMyInventory.RemoveItemsAt(Int32, Nullable<MyFixedPoint>, Boolean, Boolean)

##### Declaration

```
void IMyInventory.RemoveItemsAt(int itemIndex, Nullable<MyFixedPoint> amount, bool sendEvent, bool spawn)
```

##### Parameters

Type

Name

Description

System.Int32

itemIndex

System.Nullable<VRage.MyFixedPoint\>

amount

System.Boolean

sendEvent

System.Boolean

spawn

#### IMyInventory.RemoveItemsOfType(MyFixedPoint, MyObjectBuilder\_PhysicalObject, Boolean)

##### Declaration

```
void IMyInventory.RemoveItemsOfType(MyFixedPoint amount, MyObjectBuilder_PhysicalObject objectBuilder, bool spawn)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html)

objectBuilder

System.Boolean

spawn

#### IMyInventory.RemoveItemsOfType(MyFixedPoint, SerializableDefinitionId, MyItemFlags, Boolean)

##### Declaration

```
void IMyInventory.RemoveItemsOfType(MyFixedPoint amount, SerializableDefinitionId contentId, MyItemFlags flags, bool spawn)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)

contentId

[MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html)

flags

System.Boolean

spawn

#### IMyInventory.TransferItemFrom(IMyInventory, Int32, Nullable<Int32>, Nullable<Boolean>, Nullable<MyFixedPoint>, Boolean)

##### Declaration

```
bool IMyInventory.TransferItemFrom(IMyInventory sourceInventory, int sourceItemIndex, Nullable<int> targetItemIndex, Nullable<bool> stackIfPossible, Nullable<MyFixedPoint> amount, bool checkConnection)
```

##### Parameters

Type

Name

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventory.html)

sourceInventory

System.Int32

sourceItemIndex

System.Nullable<System.Int32\>

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

#### IMyInventory.TransferItemFrom(IMyInventory, IMyInventoryItem, MyFixedPoint)

##### Declaration

```
bool IMyInventory.TransferItemFrom(IMyInventory sourceInventory, IMyInventoryItem item, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventory.html)

sourceInventory

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventoryItem.html)

item

VRage.MyFixedPoint

amount

##### Returns

Type

Description

System.Boolean

#### IMyInventory.TransferItemTo(IMyInventory, Int32, Nullable<Int32>, Nullable<Boolean>, Nullable<MyFixedPoint>, Boolean)

##### Declaration

```
bool IMyInventory.TransferItemTo(IMyInventory dst, int sourceItemIndex, Nullable<int> targetItemIndex, Nullable<bool> stackIfPossible, Nullable<MyFixedPoint> amount, bool checkConnection)
```

##### Parameters

Type

Name

Description

[IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventory.html)

dst

System.Int32

sourceItemIndex

System.Nullable<System.Int32\>

targetItemIndex

System.Nullable<System.Boolean\>

stackIfPossible

System.Nullable<VRage.MyFixedPoint\>

amount

System.Boolean

checkConnection
