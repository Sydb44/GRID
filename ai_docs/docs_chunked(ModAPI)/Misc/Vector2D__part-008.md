The array of Vector2s to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The transform Matrix to use.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

destinationArray

An existing array into which the transformed Vector2s are written.

#### TransformNormal(Vector2D, Matrix)

Transforms a 2D vector normal by a matrix.

##### Declaration

```
public static Vector2D TransformNormal(Vector2D normal, Matrix matrix)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

normal

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### TransformNormal(ref Vector2D, ref Matrix, out Vector2D)

Transforms a vector normal by a matrix.

##### Declaration

```
public static void TransformNormal(ref Vector2D normal, ref Matrix matrix, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

normal

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation matrix.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The Vector2D resulting from the transformation.

#### TransformNormal(Vector2D\[\], Int32, ref Matrix, Vector2D\[\], Int32, Int32)

Transforms a specified range in an array of Vector2D vector normals by a specified Matrix and places the results in a specified range in a destination array.

##### Declaration

```
public static void TransformNormal(Vector2D[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2D[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

sourceArray

The source array.

System.Int32

sourceIndex

The index of the first Vector2D to transform in the source array.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The Matrix to apply.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

destinationArray

The destination array into which the resulting Vector2s are written.

System.Int32

destinationIndex

The index of the position in the destination array where the first result Vector2D should be written.

System.Int32

length

The number of vector normals to be transformed.

#### TransformNormal(Vector2D\[\], ref Matrix, Vector2D\[\])

Transforms an array of Vector2D vector normals by a specified Matrix.

##### Declaration

```
public static void TransformNormal(Vector2D[] sourceArray, ref Matrix matrix, Vector2D[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

sourceArray

The array of vector normals to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

destinationArray

An existing array into which the transformed vector normals are written.

### Operators

#### Addition(Vector2D, Double)

Adds double to each component of a vector.

##### Declaration

```
public static Vector2D operator +(Vector2D value1, double value2)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

System.Double

value2

Source double.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Addition(Vector2D, Vector2D)

Adds two vectors.

##### Declaration

```
public static Vector2D operator +(Vector2D value1, Vector2D value2)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source vector.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Division(Double, Vector2D)

Divides a scalar value by a vector.

##### Declaration

```
public static Vector2D operator /(double value1, Vector2D value2)
```

##### Parameters

Type

Name

Description

System.Double

value1

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Division(Vector2D, Double)

Divides a vector by a scalar value.

##### Declaration

```
public static Vector2D operator /(Vector2D value1, double divider)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

System.Double

divider

The divisor.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Division(Vector2D, Vector2D)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static Vector2D operator /(Vector2D value1, Vector2D value2)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Divisor vector.
