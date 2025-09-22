The array of Vector2s to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

destinationArray

An existing array into which the transformed Vector2s are written.

#### Transform(Vector2\[\], ref Quaternion, Vector2\[\])

Transforms an array of Vector2s by a specified Quaternion.

##### Declaration

```
public static void Transform(Vector2[] sourceArray, ref Quaternion rotation, Vector2[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

sourceArray

The array of Vector2s to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The transform Matrix to use.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

destinationArray

An existing array into which the transformed Vector2s are written.

#### TransformNormal(Vector2, Matrix)

Transforms a 2D vector normal by a matrix.

##### Declaration

```
public static Vector2 TransformNormal(Vector2 normal, Matrix matrix)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

normal

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### TransformNormal(ref Vector2, ref Matrix, out Vector2)

Transforms a vector normal by a matrix.

##### Declaration

```
public static void TransformNormal(ref Vector2 normal, ref Matrix matrix, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

normal

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation matrix.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The Vector2 resulting from the transformation.

#### TransformNormal(Vector2\[\], Int32, ref Matrix, Vector2\[\], Int32, Int32)

Transforms a specified range in an array of Vector2 vector normals by a specified Matrix and places the results in a specified range in a destination array.

##### Declaration

```
public static void TransformNormal(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

sourceArray

The source array.

System.Int32

sourceIndex

The index of the first Vector2 to transform in the source array.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The Matrix to apply.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

destinationArray

The destination array into which the resulting Vector2s are written.

System.Int32

destinationIndex

The index of the position in the destination array where the first result Vector2 should be written.

System.Int32

length

The number of vector normals to be transformed.

#### TransformNormal(Vector2\[\], ref Matrix, Vector2\[\])

Transforms an array of Vector2 vector normals by a specified Matrix.

##### Declaration

```
public static void TransformNormal(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

sourceArray

The array of vector normals to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

destinationArray

An existing array into which the transformed vector normals are written.

### Operators

#### Addition(Vector2, Single)

Adds float to each component of a vector.

##### Declaration

```
public static Vector2 operator +(Vector2 value1, float value2)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

System.Single

value2

Source float.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Addition(Vector2, Vector2)

Adds two vectors.

##### Declaration

```
public static Vector2 operator +(Vector2 value1, Vector2 value2)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source vector.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Division(Single, Vector2)

Divides a scalar value by a vector.

##### Declaration

```
public static Vector2 operator /(float value1, Vector2 value2)
```

##### Parameters

Type

Name

Description

System.Single

value1

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Division(Vector2, Single)

Divides a vector by a scalar value.
