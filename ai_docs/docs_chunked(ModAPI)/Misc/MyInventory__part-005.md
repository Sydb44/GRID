Type

Description

System.Boolean

##### Overrides

#### IterateInventory(Int32, Int32)

Search for inventory having given search index. Aggregate inventory: Iterates through aggregate inventory until simple inventory with matching index is found. Simple inventory: Returns itself if currentIndex == searchIndex.

Usage: searchIndex = index of inventory being searched, leave currentIndex = 0.

##### Declaration

```
public override MyInventoryBase IterateInventory(int searchIndex, int currentIndex = 0)
```

##### Parameters

Type

Name

Description

System.Int32

searchIndex

System.Int32

currentIndex

##### Returns

Type

Description

[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)

##### Overrides

#### ModifyContent(MyPhysicalInventoryItem, Action<MyObjectBuilder\_PhysicalObject>, Boolean)

##### Declaration

```
public void ModifyContent(MyPhysicalInventoryItem item, Action<MyObjectBuilder_PhysicalObject> action, bool cloneIsForRestOfStack = false)
```

##### Parameters

Type

Name

Description

[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)

item

System.Action<[MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html)\>

action

System.Boolean

cloneIsForRestOfStack

#### ModifyContentForRifle(MyPhysicalInventoryItem, Action<MyObjectBuilder\_PhysicalObject>, Boolean)

Other way of ModifyContent, it is created specifically for MyAutomaticRifleGun because of complexity of callbacks. Instead it would not force sync

##### Declaration

```
public void ModifyContentForRifle(MyPhysicalInventoryItem item, Action<MyObjectBuilder_PhysicalObject> action, bool cloneIsForRestOfStack = false)
```

##### Parameters

Type

Name

Description

[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)

item

System.Action<[MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html)\>

action

System.Boolean

cloneIsForRestOfStack

#### ModifyDatapad(Int32, UInt32, String, String)

##### Declaration

```
[Event(null, 2119)]
[Reliable]
[Server]
public void ModifyDatapad(int inventoryIndex, uint itemId, string name, string data)
```

##### Parameters

Type

Name

Description

System.Int32

inventoryIndex

System.UInt32

itemId

System.String

name

System.String

data

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeContentsChanged()

##### Declaration

```
public override void OnBeforeContentsChanged()
```

##### Overrides

#### OnContentsAdded(MyPhysicalInventoryItem, MyFixedPoint)

##### Declaration

```
public override void OnContentsAdded(MyPhysicalInventoryItem item, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)

item

VRage.MyFixedPoint

amount

##### Overrides

#### OnContentsChanged()

##### Declaration

```
public override void OnContentsChanged()
```

##### Overrides

#### OnContentsRemoved(MyPhysicalInventoryItem, MyFixedPoint)

##### Declaration

```
public override void OnContentsRemoved(MyPhysicalInventoryItem item, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)

item

VRage.MyFixedPoint

amount

##### Overrides

#### PickupItem(MyFloatingObject, MyFixedPoint)

##### Declaration

```
public void PickupItem(MyFloatingObject obj, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

[MyFloatingObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFloatingObject.html)

obj

VRage.MyFixedPoint

amount

#### RaiseConsumedEvent(MyFixedPoint, SerializableDefinitionId)

##### Declaration

```
[Event(null, 2441)]
[Reliable]
[Client]
public void RaiseConsumedEvent(MyFixedPoint amount, SerializableDefinitionId itemId)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)

itemId

#### Refresh()

##### Declaration

#### Remove(IMyInventoryItem, MyFixedPoint)

##### Declaration

```
public override bool Remove(IMyInventoryItem item, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html)

item

VRage.MyFixedPoint

amount

##### Returns

Type

Description

System.Boolean

##### Overrides

#### RemoveItemClient(UInt32)

##### Declaration

```
public void RemoveItemClient(uint itemId)
```

##### Parameters

Type

Name

Description

System.UInt32

itemId

#### RemoveItems(UInt32, Nullable<MyFixedPoint>, Boolean, Boolean, Nullable<MatrixD>, Action<MyDefinitionId, MyEntity>, Boolean)

##### Declaration

```
public void RemoveItems(uint itemId, Nullable<MyFixedPoint> amount = null, bool sendEvent = true, bool spawn = false, Nullable<MatrixD> spawnPos = null, Action<MyDefinitionId, MyEntity> itemSpawned = null, bool refreshVolumeAndMass = true)
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

System.Nullable<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\>

spawnPos

System.Action<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

itemSpawned

System.Boolean

refreshVolumeAndMass
