Description

System.Single

newValue

#### GenerateContent(MyContainerTypeDefinition)

##### Declaration

```
public void GenerateContent(MyContainerTypeDefinition containerDefinition)
```

##### Parameters

Type

Name

Description

[MyContainerTypeDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContainerTypeDefinition.html)

containerDefinition

#### GetFlags()

##### Declaration

```
public MyInventoryFlags GetFlags()
```

##### Returns

Type

Description

[MyInventoryFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyInventoryFlags.html)

#### GetInventoryCount()

Returns number of embedded inventories - this inventory can be aggregation of other inventories.

##### Declaration

```
public override int GetInventoryCount()
```

##### Returns

Type

Description

System.Int32

Return one for simple inventory, different number when this instance is an aggregation.

##### Overrides

#### GetItemAmount(MyDefinitionId, MyItemFlags, Boolean)

##### Declaration

```
public override MyFixedPoint GetItemAmount(MyDefinitionId contentId, MyItemFlags flags, bool substitute = false)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

[MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html)

flags

System.Boolean

substitute

##### Returns

Type

Description

VRage.MyFixedPoint

##### Overrides

#### GetItemAt(Int32)

##### Declaration

```
public Nullable<MyInventoryItem> GetItemAt(int index)
```

##### Parameters

Type

Name

Description

System.Int32

index

##### Returns

Type

Description

System.Nullable<[MyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyInventoryItem.html)\>

#### GetItemByID(UInt32)

##### Declaration

```
public Nullable<MyPhysicalInventoryItem> GetItemByID(uint id)
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

System.Nullable<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)\>

#### GetItemByIndex(Int32)

##### Declaration

```
public Nullable<MyPhysicalInventoryItem> GetItemByIndex(int id)
```

##### Parameters

Type

Name

Description

System.Int32

id

##### Returns

Type

Description

System.Nullable<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)\>

#### GetItemIndexById(UInt32)

##### Declaration

```
public int GetItemIndexById(uint id)
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

System.Int32

#### GetItems()

##### Declaration

```
public override List<MyPhysicalInventoryItem> GetItems()
```

##### Returns

Type

Description

System.Collections.Generic.List<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)\>

##### Overrides

#### GetItemsCount()

##### Declaration

```
public override int GetItemsCount()
```

##### Returns

Type

Description

System.Int32

##### Overrides

#### GetItemVolumeAndMass(MyDefinitionId, out Single, out Single)

##### Declaration

```
public static void GetItemVolumeAndMass(MyDefinitionId contentId, out float itemMass, out float itemVolume)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

contentId

System.Single

itemMass

System.Single

itemVolume

#### GetObjectBuilder()

##### Declaration

```
public MyObjectBuilder_Inventory GetObjectBuilder()
```

##### Returns

Type

Description

[MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html)

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

Type

Name

Description

[MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html)

definition

##### Overrides

#### Init(MyObjectBuilder\_Inventory)

##### Declaration

```
public void Init(MyObjectBuilder_Inventory objectBuilder)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html)

objectBuilder

#### IsItemAt(Int32)

##### Declaration

```
public bool IsItemAt(int position)
```

##### Parameters

Type

Name

Description

System.Int32

position

##### Returns

Type

Description

System.Boolean

#### IsUniqueId(UInt32)

##### Declaration

```
public bool IsUniqueId(uint idToTest)
```

##### Parameters

Type

Name

Description

System.UInt32

idToTest

##### Returns

Type

Description

System.Boolean

#### ItemsCanBeAdded(MyFixedPoint, IMyInventoryItem)

##### Declaration

```
public override bool ItemsCanBeAdded(MyFixedPoint amount, IMyInventoryItem item)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html)

item

##### Returns

Type

Description

System.Boolean

##### Overrides

#### ItemsCanBeRemoved(MyFixedPoint, IMyInventoryItem)

##### Declaration

```
public override bool ItemsCanBeRemoved(MyFixedPoint amount, IMyInventoryItem item)
```

##### Parameters

Type

Name

Description

VRage.MyFixedPoint

amount

[IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html)

item

##### Returns

Type

Description

System.Boolean

##### Overrides

#### IterateInventory(Int32, Int32)

Search for inventory having given search index. Aggregate inventory: Iterates through aggregate inventory until simple inventory with matching index is found. Simple inventory: Returns itself if currentIndex == searchIndex.

Usage: searchIndex = index of inventory being searched, leave currentIndex = 0.
