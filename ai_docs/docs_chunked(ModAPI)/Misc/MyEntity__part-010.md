##### Parameters

Type

Name

Description

System.Boolean

copy

When true, [Name](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Name) won't be saved. Copy true comes only from MyGridClipboard/MyFloatingObjectClipboard/MyVoxelClipboard

##### Returns

Type

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

Object builder

#### IMyEntity.GetSmallestDistanceBetweenCameraAndBoundingSphere()

Smallest distance between camera and bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere.

##### Declaration

```
float IMyEntity.GetSmallestDistanceBetweenCameraAndBoundingSphere()
```

##### Returns

Type

Description

System.Single

Distance in meters

#### IMyEntity.GetTopMostParent(Type)

Gets top most [Parent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_Parent) of specified type. Top most is entity that doesn't have parent (of specified type)

##### Declaration

```
IMyEntity IMyEntity.GetTopMostParent(Type type)
```

##### Parameters

Type

Name

Description

System.Type

type

Type of parent. When type is null, type check disabled

##### Returns

Type

Description

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

Entity

#### IMyEntity.GetTrianglesIntersectingSphere(ref BoundingSphere, Nullable<Vector3>, Nullable<Single>, List<MyTriangle\_Vertex\_Normals>, Int32)

Return list of triangles intersecting specified sphere. Angle between every triangleVertexes normal vector and 'referenceNormalVector' is calculated, and if more than 'maxAngle', we ignore such triangleVertexes. Triangles are returned in 'retTriangles', and this list must be preallocated! IMPORTANT: Sphere must be in model space, so don't transform it!

##### Declaration

```
void IMyEntity.GetTrianglesIntersectingSphere(ref BoundingSphere sphere, Nullable<Vector3> referenceNormalVector, Nullable<float> maxAngle, List<MyTriangle_Vertex_Normals> retTriangles, int maxNeighbourTriangles)
```

##### Parameters

Type

Name

Description

[BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html)

sphere

Sphere to check

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

referenceNormalVector

Used in filtering triangles

System.Nullable<System.Single\>

maxAngle

Max angle between referenceNormalVector and every triangleVertex of model

System.Collections.Generic.List<[MyTriangle\_Vertex\_Normals](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTriangle_Vertex_Normals.html)\>

retTriangles

Triangles would be added here

System.Int32

maxNeighbourTriangles

Limit of added triangles

#### IMyEntity.GetViewMatrix()

##### Declaration

```
MatrixD IMyEntity.GetViewMatrix()
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

Matrix

#### IMyEntity.GetWorldMatrixNormalizedInv()

##### Declaration

```
MatrixD IMyEntity.GetWorldMatrixNormalizedInv()
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

Matrix

#### IMyEntity.Hierarchy

##### Declaration

```
MyHierarchyComponentBase IMyEntity.Hierarchy { get; set; }
```

##### Returns

Type

Description

[MyHierarchyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyHierarchyComponentBase.html)

#### IMyEntity.InScene

Gets or set if grid is InScene. Objects that are not in scene are not updated and drawn.

##### Declaration

```
bool IMyEntity.InScene { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.InvalidateOnMove

Gets if entity is invalidated on move When visual look of entity depends on position - then InvalidateOnMove should be true

##### Declaration

```
bool IMyEntity.InvalidateOnMove { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.IsCCDForProjectiles

##### Declaration

```
bool IMyEntity.IsCCDForProjectiles { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.IsVisible()

##### Declaration

```
bool IMyEntity.IsVisible()
```

##### Returns

Type

Description

System.Boolean

True if entity should be drawn

#### IMyEntity.IsVolumetric

Always returns false

##### Declaration

```
bool IMyEntity.IsVolumetric { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyEntity.LocalAABB

##### Declaration

```
BoundingBox IMyEntity.LocalAABB { get; set; }
```

##### Returns

Type

Description

[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)

#### IMyEntity.LocalAABBHr

##### Declaration

```
BoundingBox IMyEntity.LocalAABBHr { get; }
```

##### Returns

Type

Description

[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)

#### IMyEntity.LocalMatrix

Gets or sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix

##### Declaration

```
Matrix IMyEntity.LocalMatrix { get; set; }
```

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### IMyEntity.LocalVolume

Gets or sets local volume. Same as [LocalVolume](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPositionComponentBase.html#VRage_Game_Components_MyPositionComponentBase_LocalVolume)

##### Declaration

```
BoundingSphere IMyEntity.LocalVolume { get; set; }
```

##### Returns

Type

Description

[BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html)
