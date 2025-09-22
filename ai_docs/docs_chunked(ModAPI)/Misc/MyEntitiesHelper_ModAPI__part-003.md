
| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | playerBox |     |
| System.Single | inflation |     |

#### IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD)

##### Declaration

```
IMyEntity IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity)

##### Declaration

```
IMyEntity IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD sphere, IMyEntity ignoreEntity0, IMyEntity ignoreEntity1)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity0 |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity1 |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity, Boolean, Boolean)

##### Declaration

```
List<IMyEntity> IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD sphere, IMyEntity ignoreEntity0, IMyEntity ignoreEntity1, bool ignoreVoxelMaps, bool volumetricTest)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity0 |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity1 |     |
| System.Boolean | ignoreVoxelMaps |     |
| System.Boolean | volumetricTest |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity, Boolean, Boolean, Boolean, Boolean, Boolean)

##### Declaration

```
IMyEntity IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD sphere, IMyEntity ignoreEntity0, IMyEntity ignoreEntity1, bool ignoreVoxelMaps, bool volumetricTest, bool excludeEntitiesWithDisabledPhysics, bool ignoreFloatingObjects, bool ignoreHandWeapons)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity0 |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ignoreEntity1 |     |
| System.Boolean | ignoreVoxelMaps |     |
| System.Boolean | volumetricTest |     |
| System.Boolean | excludeEntitiesWithDisabledPhysics |     |
| System.Boolean | ignoreFloatingObjects |     |
| System.Boolean | ignoreHandWeapons |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.GetTopMostEntitiesInBox(ref BoundingBoxD)

##### Declaration

```
List<IMyEntity> IMyEntities.GetTopMostEntitiesInBox(ref BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### IMyEntities.GetTopMostEntitiesInSphere(ref BoundingSphereD)

##### Declaration

```
List<IMyEntity> IMyEntities.GetTopMostEntitiesInSphere(ref BoundingSphereD boundingSphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | boundingSphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### IMyEntities.IsInsideVoxel(Vector3, Vector3, out Vector3)

##### Declaration

```
bool IMyEntities.IsInsideVoxel(Vector3 pos, Vector3 hintPosition, out Vector3 lastOutsidePos)
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

#### IMyEntities.IsInsideVoxel(Vector3D, Vector3D, out Vector3D)

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
