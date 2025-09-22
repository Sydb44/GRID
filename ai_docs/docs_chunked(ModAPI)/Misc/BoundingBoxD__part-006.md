##### Parameters

Type

Name

Description

[RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html)

ray

The Ray to check for intersection with.

##### Returns

Type

Description

System.Nullable<System.Double\>

#### Intersects(ref RayD, out Nullable<Double>)

Checks whether the current BoundingBox intersects a Ray.

##### Declaration

```
public void Intersects(ref RayD ray, out Nullable<double> result)
```

##### Parameters

Type

Name

Description

[RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html)

ray

The Ray to check for intersection with.

System.Nullable<System.Double\>

result

\[OutAttribute\] Distance at which the ray intersects the BoundingBox, or null if there is no intersection.

#### IntersectsTriangle(Vector3D, Vector3D, Vector3D)

##### Declaration

```
public bool IntersectsTriangle(Vector3D v0, Vector3D v1, Vector3D v2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v0

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v1

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v2

##### Returns

Type

Description

System.Boolean

#### IntersectsTriangle(ref Vector3D, ref Vector3D, ref Vector3D)

##### Declaration

```
public bool IntersectsTriangle(ref Vector3D v0, ref Vector3D v1, ref Vector3D v2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v0

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v1

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v2

##### Returns

Type

Description

System.Boolean

#### ProjectedArea(Vector3D)

##### Declaration

```
public double ProjectedArea(Vector3D viewDir)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

viewDir

##### Returns

Type

Description

System.Double

#### Round()

##### Declaration

```
public BoundingBoxI Round()
```

##### Returns

Type

Description

[BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html)

#### Round(Int32)

##### Declaration

```
public BoundingBoxD Round(int decimals)
```

##### Parameters

Type

Name

Description

System.Int32

decimals

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### ToString()

Returns a String that represents the current BoundingBox.

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### TransformFast(MatrixD)

Transform this AABB by matrix. Matrix has to be only rotation and translation.

##### Declaration

```
public BoundingBoxD TransformFast(MatrixD m)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

m

transformation matrix

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

transformed aabb

#### TransformFast(ref MatrixD)

Transform this AABB by matrix. Matrix has to be only rotation and translation.

##### Declaration

```
public BoundingBoxD TransformFast(ref MatrixD m)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

m

transformation matrix

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

transformed aabb

#### TransformFast(ref MatrixD, ref BoundingBoxD)

Transform this AABB by matrix. Matrix has to be only rotation and translation.

##### Declaration

```
public void TransformFast(ref MatrixD m, ref BoundingBoxD bb)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

m

transformation matrix

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

bb

output transformed aabb

#### TransformSlow(MatrixD)

Transform this AABB by matrix.

##### Declaration

```
public BoundingBoxD TransformSlow(MatrixD m)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

m

transformation matrix

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

transformed aabb

#### TransformSlow(ref MatrixD)

Transform this AABB by matrix.

##### Declaration

```
public BoundingBoxD TransformSlow(ref MatrixD worldMatrix)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

transformation matrix

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

transformed aabb

#### Translate(MatrixD)

Translate

##### Declaration

```
public BoundingBoxD Translate(MatrixD worldMatrix)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

##### Returns

Type

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

#### Translate(Vector3D)

Translate

##### Declaration

```
public BoundingBoxD Translate(Vector3D vctTranlsation)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vctTranlsation
