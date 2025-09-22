| Type | Description |
| --- | --- |
| System.Boolean | True if entity is found |

#### UnhideAllTypes()

Revert all changes to default. Make all entities visible, that were hidden because of [SetTypeHidden(Type, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_SetTypeHidden_System_Type_System_Boolean_)

##### Declaration

#### UnregisterForDraw(IMyEntity)

Unregistering entity from PrepareForDraw events and it Render from Draw calls. Entity may still be rendered

##### Declaration

```
void UnregisterForDraw(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that should stop receive draw calls |

#### UnregisterForUpdate(IMyEntity, Boolean)

Unregistering entity from following updates: UpdateBeforeSimulation, UpdateBefore10Simulation, UpdateBefore100Simulation, UpdateAfterSimulation, UpdateAfter10Simulation, UpdateAfter100Simulation, Simulate, UpdateBeforeNextFrame Physics are still simulated

##### Declaration

```
void UnregisterForUpdate(IMyEntity entity, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that should not receive updates anymore |
| System.Boolean | immediate | When true, updates removed immediately, but may cause crashes |

#### WorldHalfExtent()

Returns shortest distance (i.e. axis-aligned) to the world border from the world center. Will be 0 if world is borderless

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### WorldSafeHalfExtent()

Returns shortest distance (i.e. axis-aligned) to the world border from the world center, minus 600m to make spawning somewhat safer. Will be 0 if world is borderless

##### Declaration

```
float WorldSafeHalfExtent()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

### Events

#### OnCloseAll

Called when session unloads, before grids are closed

##### Declaration

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnEntityAdd

##### Declaration

```
event Action<IMyEntity> OnEntityAdd
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### OnEntityNameSet

Called when entity gets [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name). First string - old name, Second - new name

##### Declaration

```
event Action<IMyEntity, string, string> OnEntityNameSet
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.String, System.String\> |     |

#### OnEntityRemove

##### Declaration

```
event Action<IMyEntity> OnEntityRemove
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

### See Also