rotation

The Quaternion rotation to apply.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] An existing Vector3 filled in with the results of the rotation.

#### Transform(Vector3D\[\], Int32, ref Matrix, Vector3D\[\], Int32, Int32)

Applies a specified transform Matrix to a specified range of an array of Vector3s and writes the results into a specified range of a destination array.

##### Declaration

```
public static void Transform(Vector3D[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3D[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

sourceArray

The source array.

System.Int32

sourceIndex

The index in the source array at which to start.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

destinationArray

The existing destination array.

System.Int32

destinationIndex

The index in the destination array at which to start.

System.Int32

length

The number of Vector3s to transform.

#### Transform(Vector3D\[\], Int32, ref Quaternion, Vector3D\[\], Int32, Int32)

Applies a specified Quaternion rotation to a specified range of an array of Vector3s and writes the results into a specified range of a destination array.

##### Declaration

```
public static void Transform(Vector3D[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector3D[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

sourceArray

The source array.

System.Int32

sourceIndex

The index in the source array at which to start.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

destinationArray

The existing destination array.

System.Int32

destinationIndex

The index in the destination array at which to start.

System.Int32

length

The number of Vector3s to transform.

#### Transform(Vector3D\[\], ref MatrixD, Vector3D\*)

Transforms a source array of Vector3s by a specified Matrix and writes the results to an existing destination array.

##### Declaration

```
public static void Transform(Vector3D[] sourceArray, ref MatrixD matrix, Vector3D*destinationArray)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

sourceArray

The source array.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transform Matrix to apply.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\*

destinationArray

An existing destination array into which the transformed Vector3s are written.

#### Transform(Vector3D\[\], ref MatrixD, Vector3D\[\])

Transforms a source array of Vector3s by a specified Matrix and writes the results to an existing destination array.

##### Declaration

```
public static void Transform(Vector3D[] sourceArray, ref MatrixD matrix, Vector3D[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

sourceArray

The source array.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transform Matrix to apply.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

destinationArray

An existing destination array into which the transformed Vector3s are written.

#### Transform(Vector3D\[\], ref Quaternion, Vector3D\[\])

Transforms a source array of Vector3s by a specified Quaternion rotation and writes the results to an existing destination array.

##### Declaration

```
public static void Transform(Vector3D[] sourceArray, ref Quaternion rotation, Vector3D[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

sourceArray

The source array.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\]

destinationArray

An existing destination array into which the transformed Vector3s are written.

#### TransformNoProjection(ref Vector3D, ref MatrixD, out Vector3D)

##### Declaration

```
public static void TransformNoProjection(ref Vector3D vector, ref MatrixD matrix, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

#### TransformNormal(Vector3, MatrixD)

Transforms a 3D vector normal by a matrix.

##### Declaration

```
public static Vector3D TransformNormal(Vector3 normal, MatrixD matrix)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

normal

The source vector.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)
