##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyEntities.FindFreePlace(Vector3D, Single, Int32, Int32, Single)

##### Declaration

```
Nullable<Vector3D> IMyEntities.FindFreePlace(Vector3D basePos, float radius, int maxTestCount, int testsPerDistance, float stepSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | basePos |     |
| System.Single | radius |     |
| System.Int32 | maxTestCount |     |
| System.Int32 | testsPerDistance |     |
| System.Single | stepSize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### IMyEntities.GetElementsInBox(ref BoundingBoxD)

##### Declaration

```
List<IMyEntity> IMyEntities.GetElementsInBox(ref BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### IMyEntities.GetEntities(HashSet<IMyEntity>, Func<IMyEntity, Boolean>)

##### Declaration

```
void IMyEntities.GetEntities(HashSet<IMyEntity> entities, Func<IMyEntity, bool> collect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.HashSet<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> | entities |     |
| System.Func<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\> | collect |     |

#### IMyEntities.GetEntitiesInAABB(ref BoundingBoxD)

##### Declaration

```
List<IMyEntity> IMyEntities.GetEntitiesInAABB(ref BoundingBoxD boundingBox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### IMyEntities.GetEntitiesInSphere(ref BoundingSphereD)

##### Declaration

```
List<IMyEntity> IMyEntities.GetEntitiesInSphere(ref BoundingSphereD boundingSphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | boundingSphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)\> |     |

#### IMyEntities.GetEntity(Func<IMyEntity, Boolean>)

##### Declaration

```
IMyEntity IMyEntities.GetEntity(Func<IMyEntity, bool> match)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\> | match |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.GetEntityById(Int64)

##### Declaration

```
IMyEntity IMyEntities.GetEntityById(long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.GetEntityById(Nullable<Int64>)

##### Declaration

```
IMyEntity IMyEntities.GetEntityById(Nullable<long> entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<System.Int64\> | entityId |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.GetEntityByName(String)

##### Declaration

```
IMyEntity IMyEntities.GetEntityByName(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IMyEntities.GetInflatedPlayerBoundingBox(ref BoundingBox, Single)

##### Declaration

```
void IMyEntities.GetInflatedPlayerBoundingBox(ref BoundingBox playerBox, float inflation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | playerBox |     |
| System.Single | inflation |     |

#### IMyEntities.GetInflatedPlayerBoundingBox(ref BoundingBoxD, Single)

##### Declaration

```
void IMyEntities.GetInflatedPlayerBoundingBox(ref BoundingBoxD playerBox, float inflation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | playerBox |     |
| System.Single | inflation |     |

#### IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD)

##### Declaration

```
IMyEntity IMyEntities.GetIntersectionWithSphere(ref BoundingSphereD sphere)
```
