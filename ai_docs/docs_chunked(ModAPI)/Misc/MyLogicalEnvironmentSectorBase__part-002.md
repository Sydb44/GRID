##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyLogicalEnvironmentSectorBase.ItemIterator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyLogicalEnvironmentSectorBase.ItemIterator.html) | action |     |

#### RaiseItemEvent<T>(Int32, ref MyDefinitionId, T, Boolean)

##### Declaration

```
public abstract void RaiseItemEvent<T>(int logicalItem, ref MyDefinitionId modDef, T eventData, bool fromClient)
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

#### RevalidateItem(Int32)

##### Declaration

```
public abstract void RevalidateItem(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

#### UpdateItemModel(Int32, Int16)

##### Declaration

```
public abstract void UpdateItemModel(int itemId, short modelId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |
| System.Int16 | modelId |     |

#### UpdateItemModelBatch(List<Int32>, Int16)

##### Declaration

```
public abstract void UpdateItemModelBatch(List<int> items, short newModelId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.Int32\> | items |     |
| System.Int16 | newModelId |     |

### Events

#### OnClose

##### Declaration

```
public event Action OnClose
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |