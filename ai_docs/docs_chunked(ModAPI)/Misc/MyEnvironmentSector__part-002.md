```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyPhysicalModelDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalModelDefinition.html) |     |

#### GetEnvironmentalItemDefinitionId(Int32)

##### Declaration

```
public string GetEnvironmentalItemDefinitionId(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetItemDefinitionId(Int32)

##### Declaration

```
public int GetItemDefinitionId(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetItemFromShapeKey(UInt32)

##### Declaration

```
public int GetItemFromShapeKey(uint shapekey)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | shapekey |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetItemInfo(Int32, out UInt32, out Int32)

##### Declaration

```
public void GetItemInfo(int itemId, out uint renderObjectId, out int instanceIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |
| System.UInt32 | renderObjectId |     |
| System.Int32 | instanceIndex |     |

#### GetModelIndex(Int32)

##### Declaration

```
public short GetModelIndex(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int16 |     |

#### GetModule(Type)

##### Declaration

```
public IMyEnvironmentModuleProxy GetModule(Type moduleType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | moduleType |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEnvironmentModuleProxy](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentModuleProxy.html) |     |

#### GetModule<T>()

##### Declaration

```
public T GetModule<T>()
    where T : class, IMyEnvironmentModuleProxy
```

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### GetModuleForDefinition<T>(MyRuntimeEnvironmentItemInfo)

##### Declaration

```
public T GetModuleForDefinition<T>(MyRuntimeEnvironmentItemInfo itemEnvDefinition)
    where T : class, IMyEnvironmentModuleProxy
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.WorldEnvironment.Definitions.MyRuntimeEnvironmentItemInfo | itemEnvDefinition |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Init(IMyEnvironmentOwner, ref MyEnvironmentSectorParameters)

##### Declaration

```
public void Init(IMyEnvironmentOwner owner, ref MyEnvironmentSectorParameters parameters)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEnvironmentOwner](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.IMyEnvironmentOwner.html) | owner |     |
| [MyEnvironmentSectorParameters](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.WorldEnvironment.MyEnvironmentSectorParameters.html) | parameters |     |

#### OnItemChange(Int32, Int16)

##### Declaration

```
public void OnItemChange(int index, short newModelIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| System.Int16 | newModelIndex |     |

#### OnItemsChange(Int32, List<Int32>, Int16)

##### Declaration

```
public void OnItemsChange(int sector, List<int> indices, short newModelIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | sector |     |
| System.Collections.Generic.List<System.Int32\> | indices |     |
| System.Int16 | newModelIndex |     |

#### RaiseItemEvent<TModule>(TModule, Int32, Boolean)

##### Declaration

```
public void RaiseItemEvent<TModule>(TModule module, int item, bool fromClient = false)
    where TModule : IMyEnvironmentModuleProxy
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TModule | module |     |
| System.Int32 | item |     |
| System.Boolean | fromClient |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TModule |     |

#### RaiseItemEvent<TModule, TArgument>(TModule, Int32, TArgument, Boolean)

##### Declaration

```
public void RaiseItemEvent<TModule, TArgument>(TModule module, int item, TArgument eventData, bool fromClient = false)
    where TModule : IMyEnvironmentModuleProxy
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TModule | module |     |
| System.Int32 | item |     |
| TArgument | eventData |     |
| System.Boolean | fromClient |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TModule |     |
| TArgument |     |

#### RaiseOnLodCommitEvent(Int32)

##### Declaration

```
public void RaiseOnLodCommitEvent(int lod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |

#### RaiseOnPhysicsCommitEvent(Boolean)

##### Declaration

```
public void RaiseOnPhysicsCommitEvent(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled |     |

#### ReEnableSectorItem(Int32)

##### Declaration

```
public void ReEnableSectorItem(int itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | itemId |     |
