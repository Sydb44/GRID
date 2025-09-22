Get first entity that matching condition

##### Declaration

```
IMyEntity GetEntity(Func<IMyEntity, bool> match)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\> | match | When return true, this entity would be used as a return value |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | First matching condition entity |

#### GetEntityById(Int64)

Returns entity with provided entityId

##### Declaration

```
IMyEntity GetEntityById(long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId | EntityId |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Entity with provided id, or null |

#### GetEntityById(Nullable<Int64>)

Returns entity with provided entityId

##### Declaration

```
IMyEntity GetEntityById(Nullable<long> entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int64\> | entityId | [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Entity with provided id, or null |

#### GetEntityByName(String)

Returns entity with provided name

##### Declaration

```
IMyEntity GetEntityByName(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Entity with registered Name or null |

#### GetInflatedPlayerBoundingBox(ref BoundingBox, Single)

##### Declaration

```
void GetInflatedPlayerBoundingBox(ref BoundingBox playerBox, float inflation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | playerBox |     |
| System.Single | inflation |     |

#### GetInflatedPlayerBoundingBox(ref BoundingBoxD, Single)

Making playerBox include all connected players

##### Declaration

```
void GetInflatedPlayerBoundingBox(ref BoundingBoxD playerBox, float inflation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | playerBox | Box, that would contain all players |
| System.Single | inflation | Minimal distance between player, and border |

#### GetIntersectionWithSphere(ref BoundingSphereD)

Returns first found (not closest) entity that intersects with sphere

##### Declaration

```
IMyEntity GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | Sphere to test (in world coordinates) |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | First found entity |

#### GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity)

Returns first found (not closest) entity that intersects with sphere

##### Declaration

```
IMyEntity GetIntersectionWithSphere(ref BoundingSphereD sphere, IMyEntity ignoreEntity0, IMyEntity ignoreEntity1)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | Sphere to test (in world coordinates) |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity0 | Return value can't be this entity |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity1 | Return value can't be this entity |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | First found entity, or null |

#### GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity, Boolean, Boolean)

Returns list of entities that intersects with sphere

##### Declaration

```
List<IMyEntity> GetIntersectionWithSphere(ref BoundingSphereD sphere, IMyEntity ignoreEntity0, IMyEntity ignoreEntity1, bool ignoreVoxelMaps, bool volumetricTest)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | Sphere to test (in world coordinates) |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity0 | Returned list can't contain this entity |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity1 | Returned list can't contain this entity |
| System.Boolean | ignoreVoxelMaps | When true, voxels won't checked |
| System.Boolean | volumetricTest | When false physical shape checking used. It is much more accurate, but slower |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | List of entities inside of sphere |
