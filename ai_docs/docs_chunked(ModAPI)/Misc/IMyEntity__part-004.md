| Type | Description |
| --- | --- |
| System.Boolean | True if intersects |

#### GetIntersectionWithLine(ref LineD, out Nullable<MyIntersectionResultLineTriangleEx>, IntersectionFlags)

Get intersection of model with provided line

##### Declaration

```
bool GetIntersectionWithLine(ref LineD line, out Nullable<MyIntersectionResultLineTriangleEx> tri, IntersectionFlags flags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line | Line that should intersect model |
| System.Nullable<VRage.Game.Models.MyIntersectionResultLineTriangleEx\> | tri | Returns model first triangle that intersects |
| [IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html) | flags | Mode of work |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True when line intersects models |

#### GetIntersectionWithLineAndBoundingSphere(ref LineD, Single)

Calculates intersection of line with any bounding sphere in this model instance. Center of the bounding sphere will be returned. It takes boundingSphereRadiusMultiplier argument which serves for extending the influence (radius) for interaction with line.

##### Declaration

```
Nullable<Vector3D> GetIntersectionWithLineAndBoundingSphere(ref LineD line, float boundingSphereRadiusMultiplier)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line | Line to check |
| System.Single | boundingSphereRadiusMultiplier | Bounding sphere radius would be multiplied by this value |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | Position of intersection if of line and bounding sphere |

#### GetIntersectionWithSphere(ref BoundingSphereD)

Return true if object intersects specified sphere.

##### Declaration

```
bool GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | Sphere to check |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if intersects |

#### GetInventory()

Simply get the MyInventoryBase component stored in this entity.

##### Declaration

```
IMyInventory GetInventory()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventory.html) | Null, or first inventory |

#### GetInventory(Int32)

Search for inventory component with matching index.

##### Declaration

```
IMyInventory GetInventory(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Index of inventory, starting from 0 |

##### Returns

| Type | Description |
| --- | --- |
| [IMyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyInventory.html) | Null, or inventory at matching index |

#### GetLargestDistanceBetweenCameraAndBoundingSphere()

Largest distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. It's actually distance between camera and opposite side of the sphere

##### Declaration

```
float GetLargestDistanceBetweenCameraAndBoundingSphere()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Distance in meters |

#### GetObjectBuilder(Boolean)

Returns object builder - object representing block state, and allows restore it. Used in game save, or syncing over network.

##### Declaration

```
MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy | When true, [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) won't be saved. Copy true comes only from MyGridClipboard/MyFloatingObjectClipboard/MyVoxelClipboard |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | Object builder |

#### GetSmallestDistanceBetweenCameraAndBoundingSphere()

Smallest distance between camera and bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere.

##### Declaration

```
float GetSmallestDistanceBetweenCameraAndBoundingSphere()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Distance in meters |

#### GetSubpart(String)

Gets subpart by subpart name

##### Declaration

```
MyEntitySubpart GetSubpart(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Name of subpart. Keep in mind that subpart names, should not start with `subpart_` |

##### Returns

| Type | Description |
| --- | --- |
| [MyEntitySubpart](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.html) | Subpart if it is found, or crashes if subpart not found |

#### GetTopMostParent(Type)

Gets top most [Parent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Parent) of specified type. Top most is entity that doesn't have parent (of specified type)

##### Declaration

```
IMyEntity GetTopMostParent(Type type = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | type | Type of parent. When type is null, type check disabled |

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Entity |
