Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Transform(Vector2D, Quaternion)

Transforms a single Vector2D, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

##### Declaration

```
public static Vector2D Transform(Vector2D value, Quaternion rotation)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value

The vector to rotate.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Transform(ref Vector2D, ref Matrix, out Vector2D)

Transforms a Vector2D by the given Matrix.

##### Declaration

```
public static void Transform(ref Vector2D position, ref Matrix matrix, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

position

The source Vector2D.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation Matrix.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The Vector2D resulting from the transformation.

#### Transform(ref Vector2D, ref Quaternion, out Vector2D)

Transforms a Vector2D, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

##### Declaration

```
public static void Transform(ref Vector2D value, ref Quaternion rotation, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value

The vector to rotate.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] An existing Vector2D filled in with the result of the rotation.

#### Transform(Vector2D\[\], Int32, ref Matrix, Vector2D\[\], Int32, Int32)

Transforms a specified range in an array of Vector2s by a specified Matrix and places the results in a specified range in a destination array.

##### Declaration

```
public static void Transform(Vector2D[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2D[] destinationArray, int destinationIndex, int length)
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

The Matrix to transform by.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

destinationArray

The destination array into which the resulting Vector2s will be written.

System.Int32

destinationIndex

The index of the position in the destination array where the first result Vector2D should be written.

System.Int32

length

The number of Vector2s to be transformed.

#### Transform(Vector2D\[\], Int32, ref Quaternion, Vector2D\[\], Int32, Int32)

Transforms a specified range in an array of Vector2s by a specified Quaternion and places the results in a specified range in a destination array.

##### Declaration

```
public static void Transform(Vector2D[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector2D[] destinationArray, int destinationIndex, int length)
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

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

destinationArray

The destination array into which the resulting Vector2s are written.

System.Int32

destinationIndex

The index of the position in the destination array where the first result Vector2D should be written.

System.Int32

length

The number of Vector2s to be transformed.

#### Transform(Vector2D\[\], ref Matrix, Vector2D\[\])

Transforms an array of Vector2s by a specified Matrix.

##### Declaration

```
public static void Transform(Vector2D[] sourceArray, ref Matrix matrix, Vector2D[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

sourceArray

The array of Vector2s to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

destinationArray

An existing array into which the transformed Vector2s are written.

#### Transform(Vector2D\[\], ref Quaternion, Vector2D\[\])

Transforms an array of Vector2s by a specified Quaternion.

##### Declaration

```
public static void Transform(Vector2D[] sourceArray, ref Quaternion rotation, Vector2D[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

sourceArray

The array of Vector2s to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The transform Matrix to use.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)\[\]

destinationArray

An existing array into which the transformed Vector2s are written.
