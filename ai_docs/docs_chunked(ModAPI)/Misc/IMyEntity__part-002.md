```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Model

Gets model of block

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [IMyModel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModel.html) |     |

#### ModelCollision

Gets collision model of block

##### Declaration

```
IMyModel ModelCollision { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyModel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModel.html) |     |

#### Name

Uniq name of entity. Can be used to find entity by name

##### Declaration

```
string Name { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### NearFlag

Gets or sets flag [Near](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html#VRage_ModAPI_EntityFlags_Near)

##### Declaration

```
bool NearFlag { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsDraw

##### Declaration

```
bool NeedsDraw { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsDrawFromParent

##### Declaration

```
bool NeedsDrawFromParent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsResolveCastShadow

##### Declaration

```
bool NeedsResolveCastShadow { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdate

Gets or sets how often the entity should be updated.

##### Declaration

```
MyEntityUpdateEnum NeedsUpdate { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntityUpdateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyEntityUpdateEnum.html) |     |

#### NeedsWorldMatrix

Gets or sets if [WorldMatrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_WorldMatrix) should be calculated when parent WorldMatrix is changed.

##### Declaration

```
bool NeedsWorldMatrix { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Parent

Gets parent of entity or null, if this entity doesn't have parent. Ex: character sitting in cockpit, has parent - cockpit, cockpit has parent - cube grid, connected grids also has main grid, which would be parent for other grids.

##### Declaration

```
IMyEntity Parent { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### PersistentFlags

Gets or sets persistent flags that are used in rendering.

##### Declaration

```
MyPersistentEntityFlags2 PersistentFlags { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPersistentEntityFlags2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyPersistentEntityFlags2.html) |     |

#### Physics

Gets or sets physics for object

##### Declaration

```
MyPhysicsComponentBase Physics { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html) |     |

#### PositionComp

Gets or sets position provider logic

##### Declaration

```
MyPositionComponentBase PositionComp { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPositionComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html) |     |

#### Render

Gets or sets render logic

##### Declaration

```
MyRenderComponentBase Render { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyRenderComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyRenderComponentBase.html) |     |

#### Save

Gets or sets [Save](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html#VRage_ModAPI_EntityFlags_Save). Entity won't be saved if [Save](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Save) is false

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShadowBoxLod

##### Declaration

```
bool ShadowBoxLod { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SkipIfTooSmall

##### Declaration

```
bool SkipIfTooSmall { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StopPhysicsActivation

##### Declaration

```
bool StopPhysicsActivation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Storage

Custom storage for mods. Shared with all mods.

##### Declaration

```
MyModStorageComponentBase Storage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyModStorageComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyModStorageComponentBase.html) |     |

#### Synchronized

Gets or sets if the entity should be synced.

##### Declaration

```
bool Synchronized { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SyncObject

Gets SyncObject used for synchronizing data over network with **VRage.Sync.Sync**

##### Declaration

```
MySyncComponentBase SyncObject { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MySyncComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySyncComponentBase.html) |     |
