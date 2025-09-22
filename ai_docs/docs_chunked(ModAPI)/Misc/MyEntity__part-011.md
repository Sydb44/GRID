##### Declaration

```
BoundingSphere IMyEntity.LocalVolume { get; set; }
```

##### Returns

Type

Description

[BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html)

#### IMyEntity.LocalVolumeOffset

##### Declaration

```
Vector3 IMyEntity.LocalVolumeOffset { get; set; }
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### IMyEntity.LocationForHudMarker

##### Declaration

```
Vector3D IMyEntity.LocationForHudMarker { get; }
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### IMyEntity.MarkedForClose

Checked if [Close()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Close) was called

##### Declaration

```
bool IMyEntity.MarkedForClose { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.MaxGlassDistSq

Not used in game anymore

##### Declaration

```
float IMyEntity.MaxGlassDistSq { get; }
```

##### Returns

Type

Description

System.Single

#### IMyEntity.Model

Gets model of block

##### Declaration

```
IMyModel IMyEntity.Model { get; }
```

##### Returns

Type

Description

[IMyModel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModel.html)

#### IMyEntity.ModelCollision

Gets collision model of block

##### Declaration

```
IMyModel IMyEntity.ModelCollision { get; }
```

##### Returns

Type

Description

[IMyModel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModel.html)

#### IMyEntity.Name

Uniq name of entity. Can be used to find entity by name

##### Declaration

```
string IMyEntity.Name { get; set; }
```

##### Returns

Type

Description

System.String

#### IMyEntity.NearFlag

Gets or sets flag [Near](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html#VRage_ModAPI_EntityFlags_Near)

##### Declaration

```
bool IMyEntity.NearFlag { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.NeedsDraw

##### Declaration

```
bool IMyEntity.NeedsDraw { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.NeedsDrawFromParent

##### Declaration

```
bool IMyEntity.NeedsDrawFromParent { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.NeedsResolveCastShadow

##### Declaration

```
bool IMyEntity.NeedsResolveCastShadow { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.NeedsUpdate

Gets or sets how often the entity should be updated.

##### Declaration

```
MyEntityUpdateEnum IMyEntity.NeedsUpdate { get; set; }
```

##### Returns

Type

Description

[MyEntityUpdateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyEntityUpdateEnum.html)

#### IMyEntity.OnClose

##### Declaration

```
event Action<IMyEntity> IMyEntity.OnClose
```

##### Returns

Type

Description

System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\>

#### IMyEntity.OnClosing

##### Declaration

```
event Action<IMyEntity> IMyEntity.OnClosing
```

##### Returns

Type

Description

System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\>

#### IMyEntity.OnMarkForClose

##### Declaration

```
event Action<IMyEntity> IMyEntity.OnMarkForClose
```

##### Returns

Type

Description

System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\>

#### IMyEntity.OnPhysicsChanged

Called when havok rigid body physics are changed: inited, closed, modified.

##### Declaration

```
event Action<IMyEntity> IMyEntity.OnPhysicsChanged
```

##### Returns

Type

Description

System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\>

#### IMyEntity.Parent

Gets parent of entity or null, if this entity doesn't have parent. Ex: character sitting in cockpit, has parent - cockpit, cockpit has parent - cube grid, connected grids also has main grid, which would be parent for other grids.

##### Declaration

```
IMyEntity IMyEntity.Parent { get; }
```

##### Returns

Type

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

#### IMyEntity.PersistentFlags

Gets or sets persistent flags that are used in rendering.

##### Declaration

```
MyPersistentEntityFlags2 IMyEntity.PersistentFlags { get; set; }
```

##### Returns

Type

Description

[MyPersistentEntityFlags2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyPersistentEntityFlags2.html)

#### IMyEntity.Physics

##### Declaration

```
MyPhysicsComponentBase IMyEntity.Physics { get; set; }
```

##### Returns

Type

Description

[MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html)

#### IMyEntity.Save

Gets or sets [Save](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html#VRage_ModAPI_EntityFlags_Save). Entity won't be saved if [Save](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Save) is false

##### Declaration

```
bool IMyEntity.Save { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.SetColorMaskForSubparts(Vector3)

Sets subparts custom col

##### Declaration

```
void IMyEntity.SetColorMaskForSubparts(Vector3 colorMaskHsv)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

colorMaskHsv

Color

#### IMyEntity.SetEmissiveParts(String, Color, Single)

Sets the emissive value of a specific emissive material on entity.
