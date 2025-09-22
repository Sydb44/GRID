#### IMyEntities.RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder\_EntityBase>)

##### Declaration

```
void IMyEntities.RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder_EntityBase> objectBuilders)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)\> | objectBuilders |     |

#### IMyEntities.RemoveEntity(IMyEntity)

##### Declaration

```
void IMyEntities.RemoveEntity(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

#### IMyEntities.RemoveFromClosedEntities(IMyEntity)

##### Declaration

```
void IMyEntities.RemoveFromClosedEntities(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

#### IMyEntities.RemoveName(IMyEntity)

##### Declaration

```
void IMyEntities.RemoveName(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

#### IMyEntities.SetEntityName(IMyEntity, Boolean)

##### Declaration

```
void IMyEntities.SetEntityName(IMyEntity entity, bool possibleRename)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |
| System.Boolean | possibleRename |     |

#### IMyEntities.SetTypeHidden(Type, Boolean)

##### Declaration

```
void IMyEntities.SetTypeHidden(Type type, bool hidden)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |
| System.Boolean | hidden |     |

#### IMyEntities.TryGetEntityById(Int64, out IMyEntity)

##### Declaration

```
bool IMyEntities.TryGetEntityById(long id, out IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | id  |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.TryGetEntityById(Nullable<Int64>, out IMyEntity)

##### Declaration

```
bool IMyEntities.TryGetEntityById(Nullable<long> id, out IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int64\> | id  |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.TryGetEntityByName(String, out IMyEntity)

##### Declaration

```
bool IMyEntities.TryGetEntityByName(string name, out IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.UnhideAllTypes()

##### Declaration

```
void IMyEntities.UnhideAllTypes()
```

#### IMyEntities.UnregisterForDraw(IMyEntity)

##### Declaration

```
void IMyEntities.UnregisterForDraw(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

#### IMyEntities.UnregisterForUpdate(IMyEntity, Boolean)

##### Declaration

```
void IMyEntities.UnregisterForUpdate(IMyEntity entity, bool immediate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |
| System.Boolean | immediate |     |

#### IMyEntities.WorldHalfExtent()

##### Declaration

```
float IMyEntities.WorldHalfExtent()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### IMyEntities.WorldSafeHalfExtent()

##### Declaration

```
float IMyEntities.WorldSafeHalfExtent()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

### Implements