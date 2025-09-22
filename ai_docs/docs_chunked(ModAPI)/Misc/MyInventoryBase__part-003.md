| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| VRage.MyFixedPoint | amount |     |

#### OnOwnerChanged()

##### Declaration

```
protected void OnOwnerChanged()
```

#### RaiseAfterModifyFinished()

##### Declaration

```
public void RaiseAfterModifyFinished()
```

#### RaiseBeforeContentsChanged()

##### Declaration

```
public void RaiseBeforeContentsChanged()
```

#### RaiseContentsAdded(MyPhysicalInventoryItem, MyFixedPoint)

##### Declaration

```
public void RaiseContentsAdded(MyPhysicalInventoryItem item, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| VRage.MyFixedPoint | amount |     |

#### RaiseContentsChanged()

##### Declaration

```
public void RaiseContentsChanged()
```

#### RaiseContentsRemoved(MyPhysicalInventoryItem, MyFixedPoint)

##### Declaration

```
public void RaiseContentsRemoved(MyPhysicalInventoryItem item, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| VRage.MyFixedPoint | amount |     |

#### RaiseInventoryContentChanged(MyPhysicalInventoryItem, MyFixedPoint)

##### Declaration

```
public void RaiseInventoryContentChanged(MyPhysicalInventoryItem item, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| VRage.MyFixedPoint | amount |     |

#### Remove(IMyInventoryItem, MyFixedPoint)

##### Declaration

```
public abstract bool Remove(IMyInventoryItem item, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyInventoryItem.html) | item |     |
| VRage.MyFixedPoint | amount |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveItemsOfType(MyFixedPoint, MyDefinitionId, MyItemFlags, Boolean)

Remove items of a given amount and definition

##### Declaration

```
public abstract MyFixedPoint RemoveItemsOfType(MyFixedPoint amount, MyDefinitionId contentId, MyItemFlags flags, bool spawn = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyFixedPoint | amount | amount ot remove |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | contentId | definition id of items to be removed |
| [MyItemFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyItemFlags.html) | flags |     |
| System.Boolean | spawn | Set tru to spawn object in the world, after it was removed |

##### Returns

| Type | Description |
| --- | --- |
| VRage.MyFixedPoint | Returns the actually removed amount |

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Events

#### AfterModifyFinished

##### Declaration

```
public event Action<MyInventoryBase> AfterModifyFinished
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)\> |     |

#### BeforeContentsChanged

##### Declaration

```
public event Action<MyInventoryBase> BeforeContentsChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)\> |     |

#### ContentsAdded

##### Declaration

```
public event Action<MyPhysicalInventoryItem, MyFixedPoint> ContentsAdded
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html), VRage.MyFixedPoint\> |     |

#### ContentsChanged

Called when items were added or removed, or their amount has changed

##### Declaration

```
public event Action<MyInventoryBase> ContentsChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)\> |     |

#### ContentsRemoved

##### Declaration

```
public event Action<MyPhysicalInventoryItem, MyFixedPoint> ContentsRemoved
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html), VRage.MyFixedPoint\> |     |

#### InventoryContentChanged

##### Declaration

```
public event Action<MyInventoryBase, MyPhysicalInventoryItem, MyFixedPoint> InventoryContentChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html), [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html), VRage.MyFixedPoint\> |     |
