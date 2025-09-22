##### Declaration

```
bool IMyEntities.IsInsideVoxel(Vector3D pos, Vector3D hintPosition, out Vector3D lastOutsidePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | hintPosition |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | lastOutsidePos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.IsInsideWorld(Vector3D)

##### Declaration

```
bool IMyEntities.IsInsideWorld(Vector3D pos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.IsNameExists(IMyEntity, String)

##### Declaration

```
bool IMyEntities.IsNameExists(IMyEntity entity, string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.IsRaycastBlocked(Vector3D, Vector3D)

##### Declaration

```
bool IMyEntities.IsRaycastBlocked(Vector3D pos, Vector3D target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | target |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.IsSpherePenetrating(ref BoundingSphereD)

##### Declaration

```
bool IMyEntities.IsSpherePenetrating(ref BoundingSphereD bs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | bs  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.IsTypeHidden(Type)

##### Declaration

```
bool IMyEntities.IsTypeHidden(Type type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.IsVisible(IMyEntity)

##### Declaration

```
bool IMyEntities.IsVisible(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.IsWorldLimited()

##### Declaration

```
bool IMyEntities.IsWorldLimited()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.MarkForClose(IMyEntity)

##### Declaration

```
void IMyEntities.MarkForClose(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

#### IMyEntities.OnCloseAll

##### Declaration

```
event Action IMyEntities.OnCloseAll
```

##### Returns

| Type | Description |
| --- | --- |
| System.Action |     |

#### IMyEntities.OnEntityAdd

##### Declaration

```
event Action<IMyEntity> IMyEntities.OnEntityAdd
```

##### Returns

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### IMyEntities.OnEntityNameSet

##### Declaration

```
event Action<IMyEntity, string, string> IMyEntities.OnEntityNameSet
```

##### Returns

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.String, System.String\> |     |

#### IMyEntities.OnEntityRemove

##### Declaration

```
event Action<IMyEntity> IMyEntities.OnEntityRemove
```

##### Returns

| Type | Description |
| --- | --- |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### IMyEntities.RegisterForDraw(IMyEntity)

##### Declaration

```
void IMyEntities.RegisterForDraw(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

#### IMyEntities.RegisterForUpdate(IMyEntity)

##### Declaration

```
void IMyEntities.RegisterForUpdate(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

#### IMyEntities.RemapObjectBuilder(MyObjectBuilder\_EntityBase)

##### Declaration

```
void IMyEntities.RemapObjectBuilder(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

#### IMyEntities.RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder\_EntityBase>)

##### Declaration

```
void IMyEntities.RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder_EntityBase> objectBuilders)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)\> | objectBuilders |     |
