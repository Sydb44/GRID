Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

aabb

##### Returns

Type

Description

System.Boolean

#### GetIntersectionWithLine(ref LineD, out Nullable<MyIntersectionResultLineTriangleEx>, IntersectionFlags)

##### Declaration

```
public virtual bool GetIntersectionWithLine(ref LineD line, out Nullable<MyIntersectionResultLineTriangleEx> t, IntersectionFlags flags)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Nullable<VRage.Game.Models.MyIntersectionResultLineTriangleEx\>

t

[IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html)

flags

##### Returns

Type

Description

System.Boolean

#### GetIntersectionWithLine(ref LineD, out Nullable<Vector3D>, Boolean, IntersectionFlags)

##### Declaration

```
public virtual bool GetIntersectionWithLine(ref LineD line, out Nullable<Vector3D> v, bool useCollisionModel = true, IntersectionFlags flags)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

v

System.Boolean

useCollisionModel

[IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html)

flags

##### Returns

Type

Description

System.Boolean

#### GetIntersectionWithLineAndBoundingSphere(ref LineD, Single)

##### Declaration

```
public virtual Nullable<Vector3D> GetIntersectionWithLineAndBoundingSphere(ref LineD line, float boundingSphereRadiusMultiplier)
```

##### Parameters

Type

Name

Description

[LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html)

line

System.Single

boundingSphereRadiusMultiplier

##### Returns

Type

Description

System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

#### GetIntersectionWithSphere(ref BoundingSphereD)

##### Declaration

```
public virtual bool GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

Type

Name

Description

[BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html)

sphere

##### Returns

Type

Description

System.Boolean

#### GetInventoryBase()

Simply get the MyInventoryBase component stored in this entity.

##### Declaration

```
public MyInventoryBase GetInventoryBase()
```

##### Returns

Type

Description

[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)

#### GetInventoryBase(Int32)

Search for inventory component with maching index.

##### Declaration

```
public virtual MyInventoryBase GetInventoryBase(int index)
```

##### Parameters

Type

Name

Description

System.Int32

index

##### Returns

Type

Description

[MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html)

#### GetLargestDistanceBetweenCameraAndBoundingSphere()

##### Declaration

```
public double GetLargestDistanceBetweenCameraAndBoundingSphere()
```

##### Returns

Type

Description

System.Double

#### GetObjectBuilder(Boolean)

Gets object builder from object.

##### Declaration

```
public virtual MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

Type

Name

Description

System.Boolean

copy

##### Returns

Type

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

#### GetSmallestDistanceBetweenCameraAndBoundingSphere()

##### Declaration

```
public double GetSmallestDistanceBetweenCameraAndBoundingSphere()
```

##### Returns

Type

Description

System.Double

#### GetSubpart(String)

##### Declaration

```
public MyEntitySubpart GetSubpart(string name)
```

##### Parameters

Type

Name

Description

System.String

name

##### Returns

Type

Description

[MyEntitySubpart](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntitySubpart.html)

#### GetTopMostParent(Type)

Return top most parent of this entity

##### Declaration

```
public MyEntity GetTopMostParent(Type type = null)
```

##### Parameters

Type

Name

Description

System.Type

type

##### Returns

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetTrianglesIntersectingSphere(ref BoundingSphere, Nullable<Vector3>, Nullable<Single>, List<MyTriangle\_Vertex\_Normals>, Int32)

##### Declaration

```
public void GetTrianglesIntersectingSphere(ref BoundingSphere sphere, Nullable<Vector3> referenceNormalVector, Nullable<float> maxAngle, List<MyTriangle_Vertex_Normals> retTriangles, int maxNeighbourTriangles)
```

##### Parameters

Type

Name

Description

[BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html)

sphere

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

referenceNormalVector

System.Nullable<System.Single\>

maxAngle

System.Collections.Generic.List<[MyTriangle\_Vertex\_Normals](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyTriangle_Vertex_Normals.html)\>

retTriangles

System.Int32

maxNeighbourTriangles

#### GetViewMatrix()

##### Declaration

```
public virtual MatrixD GetViewMatrix()
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Init(StringBuilder, String, MyEntity, Nullable<Single>, String)

##### Declaration

```
public virtual void Init(StringBuilder displayName, string model, MyEntity parentObject, Nullable<float> scale, string modelCollision = null)
```
