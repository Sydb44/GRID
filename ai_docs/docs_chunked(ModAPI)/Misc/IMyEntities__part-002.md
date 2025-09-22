Returns if entity with provided name exists

##### Declaration

```
bool EntityExists(Nullable<long> entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int64\> | entityId | [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if entity exists |

#### EntityExists(String)

Returns if entity with provided name exists

##### Declaration

```
bool EntityExists(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if entity exists |

#### Exist(IMyEntity)

Checks if entity is registered entity

##### Declaration

```
bool Exist(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity to test |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if entity is registered |

#### FindFreePlace(Vector3D, Single, Int32, Int32, Single)

Use to find place that doesn't have any voxels, grids, or physical bodies. If original position can't fill check sphere, new position in some distance is picked. Distance grows each testsPerDistance attempts. Maximum distance from BasePos that can be used is calculated by formula: maxTestCount / testsPerDistance \* radius \* stepSize

##### Declaration

```
Nullable<Vector3D> FindFreePlace(Vector3D basePos, float radius, int maxTestCount = 20, int testsPerDistance = 5, float stepSize = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | basePos | Base position |
| System.Single | radius | Radius in which there should be nothing |
| System.Int32 | maxTestCount | How many tries should be done, to find free space |
| System.Int32 | testsPerDistance | Depends how often distance from original position grows |
| System.Single | stepSize | How distance grows |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | Position that can doesn't have voxels, grids and other HkBodies in provided radius |

#### GetElementsInBox(ref BoundingBoxD)

Returns list of entities that intersects with BoundingBox. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInBox(ref BoundingBoxD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_GetTopMostEntitiesInBox_VRageMath_BoundingBoxD__)

##### Declaration

```
List<IMyEntity> GetElementsInBox(ref BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox | Bounding box in world coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | New list of entities |

#### GetEntities(HashSet<IMyEntity>, Func<IMyEntity, Boolean>)

Get all entities matching condition

##### Declaration

```
void GetEntities(HashSet<IMyEntity> entities, Func<IMyEntity, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.HashSet<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | entities | This set would receive results. Can be null, but then collect function should always return false |
| System.Func<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\> | collect | When it is null or returns true, provided hashset adds entity |

#### GetEntitiesInAABB(ref BoundingBoxD)

Returns list of entities that intersects with BoundingBox. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInBox(ref BoundingBoxD)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html#VRage_ModAPI_IMyEntities_GetTopMostEntitiesInBox_VRageMath_BoundingBoxD__)

##### Declaration

```
List<IMyEntity> GetEntitiesInAABB(ref BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox | Bounding box in world coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | New list of entities |

#### GetEntitiesInSphere(ref BoundingSphereD)

##### Declaration

```
List<IMyEntity> GetEntitiesInSphere(ref BoundingSphereD boundingSphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | boundingSphere | Bounding sphere in world coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | New list of entities |

#### GetEntity(Func<IMyEntity, Boolean>)

Get first entity that matching condition

##### Declaration

```
IMyEntity GetEntity(Func<IMyEntity, bool> match)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\> | match | When return true, this entity would be used as a return value |
