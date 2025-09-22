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

#### GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity, Boolean, Boolean, Boolean, Boolean, Boolean)

Returns first found (not closest) entity that intersects with sphere

##### Declaration

```
IMyEntity GetIntersectionWithSphere(ref BoundingSphereD sphere, IMyEntity ignoreEntity0, IMyEntity ignoreEntity1, bool ignoreVoxelMaps, bool volumetricTest, bool excludeEntitiesWithDisabledPhysics = false, bool ignoreFloatingObjects = true, bool ignoreHandWeapons = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | Sphere to test (in world coordinates) |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity0 | Return value can't be this entity |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity1 | Return value can't be this entity |
| System.Boolean | ignoreVoxelMaps | When true, voxels won't checked |
| System.Boolean | volumetricTest | When false physical shape checking used. It is much more accurate, but slower |
| System.Boolean | excludeEntitiesWithDisabledPhysics | When true, entities with disabled physics won't checked |
| System.Boolean | ignoreFloatingObjects | When true, floating objects won't checked |
| System.Boolean | ignoreHandWeapons | When true, hand weapons (tools) won't checked |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Found entity matching conditions |

#### GetTopMostEntitiesInBox(ref BoundingBoxD)

Returns list of `TopMost` entities that intersects with bounding box. This function won't return CubeBlocks. Use [GetElementsInBox(ref BoundingBoxD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_GetElementsInBox_VRageMath_BoundingBoxD__) to retrieve CubeBlocks also.

##### Declaration

```
List<IMyEntity> GetTopMostEntitiesInBox(ref BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox | Bounding box in world coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | New list of entities |

#### GetTopMostEntitiesInSphere(ref BoundingSphereD)

Returns list of `TopMost` entities that intersects with sphere. This function won't return CubeBlocks. Use [GetEntitiesInSphere(ref BoundingSphereD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_GetEntitiesInSphere_VRageMath_BoundingSphereD__) to retrieve CubeBlocks also.

##### Declaration

```
List<IMyEntity> GetTopMostEntitiesInSphere(ref BoundingSphereD boundingSphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | boundingSphere | Bounding sphere in world coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | New list of entities |

#### IsInsideVoxel(Vector3, Vector3, out Vector3)

##### Declaration

```
bool IsInsideVoxel(Vector3 pos, Vector3 hintPosition, out Vector3 lastOutsidePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | pos |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | hintPosition |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | lastOutsidePos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsInsideVoxel(Vector3D, Vector3D, out Vector3D)

Return true if line between pos and hintPosition doesn't intersect any voxel, or intersects it even number of times Does inside physical ray casting inside

##### Declaration

```
bool IsInsideVoxel(Vector3D pos, Vector3D hintPosition, out Vector3D lastOutsidePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | pos | Position of object |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | hintPosition | Position of object few frames back to test whether object entered voxel. Usually pos - LinearVelocity \* x, where x it time. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | lastOutsidePos | Last position that was outside of voxels |
