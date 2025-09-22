| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

##### Overrides

#### IterateItems(MyLogicalEnvironmentSectorBase.ItemIterator)

##### Declaration

```
public override void IterateItems(MyLogicalEnvironmentSectorBase.ItemIterator action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyLogicalEnvironmentSectorBase.ItemIterator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.ItemIterator.html) | action |     |

##### Overrides

#### RaiseItemEvent<TModule>(Int32, Object, Boolean)

Raise event from a storage module.

Can be either a client event to server (fromClient = true) or a broadcast of a server event to all clients with this logical sector (fromClient = false).

##### Declaration

```
public void RaiseItemEvent<TModule>(int logicalItem, object eventData, bool fromClient = false)
    where TModule : IMyEnvironmentModule
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | logicalItem | Logical item Id |
| System.Object | eventData | Data to send along with the event. |
| System.Boolean | fromClient | Weather this event comes from client to server or server to all clients. |

##### Type Parameters

| Name | Description |
| --- | --- |
| TModule | Type of the storage module to notify |

#### RaiseItemEvent<T>(Int32, ref MyDefinitionId, T, Boolean)

##### Declaration

```
public override void RaiseItemEvent<T>(int logicalItem, ref MyDefinitionId modDef, T eventData, bool fromClient)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | logicalItem |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | modDef |     |
| T   | eventData |     |
| System.Boolean | fromClient |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

##### Overrides

Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.RaiseItemEvent<T>(System.Int32, VRage.Game.MyDefinitionId, T, System.Boolean)

#### ReenableItem(Int32)

##### Declaration

```
public void ReenableItem(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

#### RemoveView(MyProceduralDataView)

##### Declaration

```
public void RemoveView(MyProceduralDataView view)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyProceduralDataView](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyProceduralDataView.html) | view |     |

#### RevalidateItem(Int32)

##### Declaration

```
public override void RevalidateItem(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

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

#### UpdateItemModel(Int32, Int16)

##### Declaration

```
public override void UpdateItemModel(int itemId, short modelId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |
| System.Int16 | modelId |     |

##### Overrides

#### UpdateItemModelBatch(List<Int32>, Int16)

##### Declaration

```
public override void UpdateItemModelBatch(List<int> itemIds, short newModelId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.Int32\> | itemIds |     |
| System.Int16 | newModelId |     |

##### Overrides

### Events

#### OnViewerEmpty

##### Declaration

```
public event Action<MyProceduralLogicalSector> OnViewerEmpty
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[MyProceduralLogicalSector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyProceduralLogicalSector.html)\> |     |