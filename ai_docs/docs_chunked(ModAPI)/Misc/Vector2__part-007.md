Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The result of the subtraction.

#### ToString()

Retrieves a string representation of the current object.

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### Transform(Vector2, Matrix)

Transforms the vector (x, y, 0, 1) by the specified matrix.

##### Declaration

```
public static Vector2 Transform(Vector2 position, Matrix matrix)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

position

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Transform(Vector2, Quaternion)

Transforms a single Vector2, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

##### Declaration

```
public static Vector2 Transform(Vector2 value, Quaternion rotation)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

The vector to rotate.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Transform(ref Vector2, ref Matrix, out Vector2)

Transforms a Vector2 by the given Matrix.

##### Declaration

```
public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

position

The source Vector2.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation Matrix.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The Vector2 resulting from the transformation.

#### Transform(ref Vector2, ref Quaternion, out Vector2)

Transforms a Vector2, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

##### Declaration

```
public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

The vector to rotate.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] An existing Vector2 filled in with the result of the rotation.

#### Transform(Vector2\[\], Int32, ref Matrix, Vector2\[\], Int32, Int32)

Transforms a specified range in an array of Vector2s by a specified Matrix and places the results in a specified range in a destination array.

##### Declaration

```
public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
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

The Matrix to transform by.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

destinationArray

The destination array into which the resulting Vector2s will be written.

System.Int32

destinationIndex

The index of the position in the destination array where the first result Vector2 should be written.

System.Int32

length

The number of Vector2s to be transformed.

#### Transform(Vector2\[\], Int32, ref Quaternion, Vector2\[\], Int32, Int32)

Transforms a specified range in an array of Vector2s by a specified Quaternion and places the results in a specified range in a destination array.

##### Declaration

```
public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector2[] destinationArray, int destinationIndex, int length)
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

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

destinationArray

The destination array into which the resulting Vector2s are written.

System.Int32

destinationIndex

The index of the position in the destination array where the first result Vector2 should be written.

System.Int32

length

The number of Vector2s to be transformed.

#### Transform(Vector2\[\], ref Matrix, Vector2\[\])

Transforms an array of Vector2s by a specified Matrix.

##### Declaration

```
public static void Transform(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

sourceArray

The array of Vector2s to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\]

destinationArray

An existing array into which the transformed Vector2s are written.
