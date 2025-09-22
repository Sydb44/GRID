[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### TransformNormal(ref Vector3, ref MatrixD, out Vector3D)

##### Declaration

```
public static void TransformNormal(ref Vector3 normal, ref MatrixD matrix, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

normal

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

#### TransformNormal(Vector3D, Matrix)

Transforms a 3D vector normal by a matrix.

##### Declaration

```
public static Vector3D TransformNormal(Vector3D normal, Matrix matrix)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normal

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### TransformNormal(Vector3D, MatrixD)

Transforms a 3D vector normal by a matrix.

##### Declaration

```
public static Vector3D TransformNormal(Vector3D normal, MatrixD matrix)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normal

The source vector.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### TransformNormal(Vector3D, ref MatrixD)

##### Declaration

```
public static Vector3D TransformNormal(Vector3D normal, ref MatrixD matrix)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normal

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### TransformNormal(Vector3D, MyBlockOrientation)

##### Declaration

```
public static Vector3D TransformNormal(Vector3D normal, MyBlockOrientation orientation)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normal

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientation

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### TransformNormal(ref Vector3D, ref MatrixD, out Vector3D)

Transforms a vector normal by a matrix.

##### Declaration

```
public static void TransformNormal(ref Vector3D normal, ref MatrixD matrix, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normal

The source vector.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transformation Matrix.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The Vector3 resulting from the transformation.

#### TransformNormal(ref Vector3D, ref MatrixI, out Vector3D)

##### Declaration

```
public static void TransformNormal(ref Vector3D normal, ref MatrixI matrix, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normal

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

matrix

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

#### TransformNormal(ref Vector3D, MyBlockOrientation, out Vector3D)

##### Declaration

```
public static void TransformNormal(ref Vector3D normal, MyBlockOrientation orientation, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

normal

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientation

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

#### TransformNormal(Vector3D\[\], Int32, ref Matrix, Vector3D\[\], Int32, Int32)

Transforms a specified range in an array of 3D vector normals by a specified Matrix and writes the results to a specified range in a destination array.

##### Declaration

```
public static void TransformNormal(Vector3D[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3D[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

sourceArray

The source array of Vector3 normals.

System.Int32

sourceIndex

The starting index in the source array.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

destinationArray

The destination Vector3 array.

System.Int32

destinationIndex

The starting index in the destination array.

System.Int32

length

The number of vectors to transform.
