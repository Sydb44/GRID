```
public abstract void ConsumeItem(MyDefinitionId itemId, MyFixedPoint amount, long consumerEntityId = 0L)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | itemId |     |
| VRage.MyFixedPoint | amount |     |
| System.Int64 | consumerEntityId |     |

#### CountItems(Dictionary<MyDefinitionId, MyFixedPoint>)

##### Declaration

```
public abstract void CountItems(Dictionary<MyDefinitionId, MyFixedPoint> itemCounts)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), VRage.MyFixedPoint\> | itemCounts |     |

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### GetInventoryCount()

Returns number of embedded inventories - this inventory can be aggregation of other inventories.

##### Declaration

```
public abstract int GetInventoryCount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Return one for simple inventory, different number when this instance is an aggregation. |

#### GetItemAmount(MyDefinitionId, MyItemFlags, Boolean)

##### Declaration

```
public abstract MyFixedPoint GetItemAmount(MyDefinitionId contentId, MyItemFlags flags, bool substitute = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | contentId |     |
| [MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html) | flags |     |
| System.Boolean | substitute |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint |     |

#### GetItems()

##### Declaration

```
public abstract List<MyPhysicalInventoryItem> GetItems()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html)\> |     |

#### GetItemsCount()

Returns the number of items in the inventory. This needs to be overrided, otherwise it returns 0!

##### Declaration

```
public virtual int GetItemsCount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | int - number of items in inventory |

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### ItemsCanBeAdded(MyFixedPoint, IMyInventoryItem)

##### Declaration

```
public abstract bool ItemsCanBeAdded(MyFixedPoint amount, IMyInventoryItem item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyFixedPoint | amount |     |
| [IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html) | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ItemsCanBeRemoved(MyFixedPoint, IMyInventoryItem)

##### Declaration

```
public abstract bool ItemsCanBeRemoved(MyFixedPoint amount, IMyInventoryItem item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyFixedPoint | amount |     |
| [IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html) | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IterateInventory(Int32, Int32)

Search for inventory having given search index. Aggregate inventory: Iterates through aggregate inventory until simple inventory with matching index is found. Simple inventory: Returns itself if currentIndex == searchIndex.

Usage: searchIndex = index of inventory being searched, leave currentIndex = 0.

##### Declaration

```
public abstract MyInventoryBase IterateInventory(int searchIndex, int currentIndex = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | searchIndex |     |
| System.Int32 | currentIndex |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) |     |

#### OnBeforeContentsChanged()

##### Declaration

```
public abstract void OnBeforeContentsChanged()
```

#### OnContentsAdded(MyPhysicalInventoryItem, MyFixedPoint)

##### Declaration

```
public abstract void OnContentsAdded(MyPhysicalInventoryItem item, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| VRage.MyFixedPoint | amount |     |

#### OnContentsChanged()

##### Declaration

```
public abstract void OnContentsChanged()
```

#### OnContentsRemoved(MyPhysicalInventoryItem, MyFixedPoint)

##### Declaration

```
public abstract void OnContentsRemoved(MyPhysicalInventoryItem item, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| VRage.MyFixedPoint | amount |     |

#### OnOwnerChanged()

##### Declaration

```
protected void OnOwnerChanged()
```

#### RaiseAfterModifyFinished()
