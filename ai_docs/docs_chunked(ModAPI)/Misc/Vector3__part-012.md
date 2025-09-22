The source Vector3.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation Matrix.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The transformed vector.

#### Transform(ref Vector3, ref MatrixI, out Vector3)

##### Declaration

```
public static void Transform(ref Vector3 position, ref MatrixI matrix, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

matrix

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

#### Transform(ref Vector3, ref Quaternion, out Vector3)

Transforms a Vector3 by a specified Quaternion rotation.

##### Declaration

```
public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

The Vector3 to rotate.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] An existing Vector3 filled in with the results of the rotation.

#### Transform(Vector3\[\], Int32, ref Matrix, Vector3\[\], Int32, Int32)

Applies a specified transform Matrix to a specified range of an array of Vector3s and writes the results into a specified range of a destination array.

##### Declaration

```
public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

sourceArray

The source array.

System.Int32

sourceIndex

The index in the source array at which to start.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

destinationArray

The existing destination array.

System.Int32

destinationIndex

The index in the destination array at which to start.

System.Int32

length

The number of Vector3s to transform.

#### Transform(Vector3\[\], Int32, ref Quaternion, Vector3\[\], Int32, Int32)

Applies a specified Quaternion rotation to a specified range of an array of Vector3s and writes the results into a specified range of a destination array.

##### Declaration

```
public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector3[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

sourceArray

The source array.

System.Int32

sourceIndex

The index in the source array at which to start.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

destinationArray

The existing destination array.

System.Int32

destinationIndex

The index in the destination array at which to start.

System.Int32

length

The number of Vector3s to transform.

#### Transform(Vector3\[\], ref Matrix, Vector3\[\])

Transforms a source array of Vector3s by a specified Matrix and writes the results to an existing destination array.

##### Declaration

```
public static void Transform(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

sourceArray

The source array.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

destinationArray

An existing destination array into which the transformed Vector3s are written.

#### Transform(Vector3\[\], ref Quaternion, Vector3\[\])

Transforms a source array of Vector3s by a specified Quaternion rotation and writes the results to an existing destination array.

##### Declaration

```
public static void Transform(Vector3[] sourceArray, ref Quaternion rotation, Vector3[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

sourceArray

The source array.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

destinationArray

An existing destination array into which the transformed Vector3s are written.

#### TransformNoProjection(ref Vector3, ref Matrix, out Vector3)

##### Declaration

```
public static void TransformNoProjection(ref Vector3 vector, ref Matrix matrix, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

#### TransformNormal(Vector3, Matrix)

Transforms a 3D vector normal by a matrix.
