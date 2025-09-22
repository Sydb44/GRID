destinationIndex

The starting index in the destination array.

System.Int32

length

The number of vectors to transform.

#### TransformNormal(Vector3\[\], ref Matrix, Vector3\[\])

Transforms an array of 3D vector normals by a specified Matrix.

##### Declaration

```
public static void TransformNormal(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

sourceArray

The array of Vector3 normals to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform matrix to apply.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\]

destinationArray

An existing Vector3 array into which the results of the transforms are written.

#### TransformNormal(Vector3D, Matrix)

Transforms a 3D vector normal by a matrix.

##### Declaration

```
public static Vector3 TransformNormal(Vector3D normal, Matrix matrix)
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

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### TransformProjection(ref Vector3, ref Matrix, out Vector3)

Transforms a Vector3 by the given projection matrix (both ortho and perspective are supported)

##### Declaration

```
public static void TransformProjection(ref Vector3 position, ref Matrix matrix, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

The source Vector3.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The projection Matrix.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The transformed vector.

#### TriangleArea(Vector3, Vector3, Vector3)

##### Declaration

```
public static float TriangleArea(Vector3 v1, Vector3 v2, Vector3 v3)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v1

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v2

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v3

##### Returns

Type

Description

System.Single

#### TriangleArea(ref Vector3, ref Vector3, ref Vector3)

##### Declaration

```
public static float TriangleArea(ref Vector3 v1, ref Vector3 v2, ref Vector3 v3)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v1

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v2

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v3

##### Returns

Type

Description

System.Single

#### VolumeInt(Single)

##### Declaration

```
public long VolumeInt(float multiplier)
```

##### Parameters

Type

Name

Description

System.Single

multiplier

##### Returns

Type

Description

System.Int64

### Operators

#### Addition(Vector3, Single)

##### Declaration

```
public static Vector3 operator +(Vector3 value1, float value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

System.Single

value2

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Addition(Vector3, Vector3)

Adds two vectors.

##### Declaration

```
public static Vector3 operator +(Vector3 value1, Vector3 value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Division(Single, Vector3)

##### Declaration

```
public static Vector3 operator /(float value, Vector3 divider)
```

##### Parameters

Type

Name

Description

System.Single

value

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

divider

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Division(Vector3, Single)

Divides a vector by a scalar value.

##### Declaration

```
public static Vector3 operator /(Vector3 value, float divider)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

Source vector.

System.Single

divider

The divisor.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Division(Vector3, Vector3)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static Vector3 operator /(Vector3 value1, Vector3 value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Divisor vector.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)
