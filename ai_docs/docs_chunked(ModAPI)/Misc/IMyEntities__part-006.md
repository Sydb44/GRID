```
void RegisterForUpdate(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | That should have updates |

#### RemapObjectBuilder(MyObjectBuilder\_EntityBase)

Remaps this entity's [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) and [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) to a new values.

##### Declaration

```
void RemapObjectBuilder(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder | ObjectBuilder that should be remapped |

#### RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder\_EntityBase>)

Remaps this entity's [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) and [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) to a new values.

##### Declaration

```
void RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder_EntityBase> objectBuilders)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)\> | objectBuilders | ObjectBuilders that should be remapped |

#### RemoveEntity(IMyEntity)

Unregisters entity

##### Declaration

```
void RemoveEntity(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that should be unregistered |

#### RemoveFromClosedEntities(IMyEntity)

Remove entity from lists of closed entities

##### Declaration

```
void RemoveFromClosedEntities(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that should be removed |

#### RemoveName(IMyEntity)

Removes registered name from entity.

##### Declaration

```
void RemoveName(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity, that has name |

#### SetEntityName(IMyEntity, Boolean)

Apply [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) for entity

##### Declaration

```
void SetEntityName(IMyEntity IMyEntity, bool possibleRename = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | IMyEntity | Entity that should be named |
| System.Boolean | possibleRename | Allows renaming |

#### SetTypeHidden(Type, Boolean)

Entities that inherit that type would be visible/invisible.

##### Declaration

```
void SetTypeHidden(Type type, bool hidden)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type | Type that class should inherit to be invisible, ex: IMyCubeGrid |
| System.Boolean | hidden | Sets if inherited entities should be visible visible or not |

#### TryGetEntityById(Int64, out IMyEntity)

Returns entity with provided id

##### Declaration

```
bool TryGetEntityById(long id, out IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | id  | EntityId |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Found entity |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if entity is found |

#### TryGetEntityById(Nullable<Int64>, out IMyEntity)

Returns entity with provided id

##### Declaration

```
bool TryGetEntityById(Nullable<long> id, out IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int64\> | id  | [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Found entity |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if entity is found |

#### TryGetEntityByName(String, out IMyEntity)

Returns entity with provided name

##### Declaration

```
bool TryGetEntityByName(string name, out IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Found entity |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if entity is found |

#### UnhideAllTypes()

Revert all changes to default. Make all entities visible, that were hidden because of [SetTypeHidden(Type, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_SetTypeHidden_System_Type_System_Boolean_)

##### Declaration

#### UnregisterForDraw(IMyEntity)

Unregistering entity from PrepareForDraw events and it Render from Draw calls. Entity may still be rendered
