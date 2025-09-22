Description

VRage.MyFixedPoint

##### Overrides

#### ConsumeItem(MyDefinitionId, MyFixedPoint, Int64)

##### Declaration

```
public override void ConsumeItem(MyDefinitionId itemId, MyFixedPoint amount, long consumerEntityId = 0L)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

VRage.MyFixedPoint

amount

System.Int64

consumerEntityId

##### Overrides

#### ContainItems(Nullable<MyFixedPoint>, MyDefinitionId, MyItemFlags)

##### Declaration

```
public bool ContainItems(Nullable<MyFixedPoint> amount, MyDefinitionId contentId, MyItemFlags flags)
```

##### Parameters

Type

Name

Description

System.Nullable<VRage.MyFixedPoint\>

amount

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

[MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html)

flags

##### Returns

Type

Description

System.Boolean

#### ContainItems(MyFixedPoint, MyObjectBuilder\_PhysicalObject)

##### Declaration

```
public bool ContainItems(MyFixedPoint amount, MyObjectBuilder_PhysicalObject ob)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyObjectBuilder\_PhysicalObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalObject.html)

ob

##### Returns

Type

Description

System.Boolean

#### CountItems(Dictionary<MyDefinitionId, MyFixedPoint>)

##### Declaration

```
public override void CountItems(Dictionary<MyDefinitionId, MyFixedPoint> itemCounts)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.Dictionary<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), VRage.MyFixedPoint\>

itemCounts

##### Overrides

#### DebugAddItems(MyFixedPoint, MyObjectBuilder\_Base)

##### Declaration

```
public void DebugAddItems(MyFixedPoint amount, MyObjectBuilder_Base objectBuilder)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html)

objectBuilder

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html)

builder

##### Overrides

#### DropItem(Int32, MyFixedPoint)

##### Declaration

```
public void DropItem(int itemIndex, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

System.Int32

itemIndex

VRage.MyFixedPoint

amount

#### DropItemById(UInt32, MyFixedPoint)

##### Declaration

```
public void DropItemById(uint itemId, MyFixedPoint amount)
```

##### Parameters

Type

Name

Description

System.UInt32

itemId

VRage.MyFixedPoint

amount

#### Empty()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### FilterItemsUsingConstraint()

##### Declaration

```
public bool FilterItemsUsingConstraint()
```

##### Returns

Type

Description

System.Boolean

#### FindFreeSlotSpace(MyDefinitionId, IMyInventoryItemAdapter)

##### Declaration

```
public MyFixedPoint FindFreeSlotSpace(MyDefinitionId contentId, IMyInventoryItemAdapter adapter)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

Sandbox.Game.Entities.Interfaces.IMyInventoryItemAdapter

adapter

##### Returns

Type

Description

VRage.MyFixedPoint

#### FindItem(Func<MyPhysicalInventoryItem, Boolean>)

##### Declaration

```
public Nullable<MyPhysicalInventoryItem> FindItem(Func<MyPhysicalInventoryItem, bool> predicate)
```

##### Parameters

Type

Name

Description

System.Func<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html), System.Boolean\>

predicate

##### Returns

Type

Description

System.Nullable<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)\>

#### FindItem(MyDefinitionId)

##### Declaration

```
public Nullable<MyPhysicalInventoryItem> FindItem(MyDefinitionId contentId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

##### Returns

Type

Description

System.Nullable<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)\>

#### FindUsableItem(MyDefinitionId)

This will try to find the first item that can be use. This means, if durability is enabled on items, it will look for first item with durability HP > 0, if this is disabled, this will behave the same as FindItem method

##### Declaration

```
public Nullable<MyPhysicalInventoryItem> FindUsableItem(MyDefinitionId contentId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

definition id of the item

##### Returns

Type

Description

System.Nullable<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)\>

item that has durability > 0 if found

#### FixInventoryVolume(Single)

##### Declaration

```
public void FixInventoryVolume(float newValue)
```

##### Parameters

Type

Name

Description

System.Single

newValue

#### GenerateContent(MyContainerTypeDefinition)

##### Declaration

```
public void GenerateContent(MyContainerTypeDefinition containerDefinition)
```
