matrix

The transformation Matrix.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The Vector4 resulting from the transformation.

#### [](#VRageMath_Vector4_Transform_VRageMath_Vector4__VRageMath_Quaternion__VRageMath_Vector4__)Transform(ref Vector4, ref Quaternion, out Vector4)

Transforms a Vector4 by a specified Quaternion.

##### Declaration

```
public static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value

The Vector4 to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The Vector4 resulting from the transformation.

#### [](#VRageMath_Vector4_Transform_VRageMath_Vector4___System_Int32_VRageMath_Matrix__VRageMath_Vector4___System_Int32_System_Int32_)Transform(Vector4\[\], Int32, ref Matrix, Vector4\[\], Int32, Int32)

Transforms a specified range in an array of Vector4s by a specified Matrix into a specified range in a destination array.

##### Declaration

```
public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Matrix matrix, Vector4[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\[\]

sourceArray

The array of Vector4s containing the range to transform.

System.Int32

sourceIndex

The index in the source array of the first Vector4 to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\[\]

destinationArray

The existing destination array of Vector4s into which to write the results.

System.Int32

destinationIndex

The index in the destination array of the first result Vector4 to write.

System.Int32

length

The number of Vector4s to transform.

#### [](#VRageMath_Vector4_Transform_VRageMath_Vector4___System_Int32_VRageMath_Quaternion__VRageMath_Vector4___System_Int32_System_Int32_)Transform(Vector4\[\], Int32, ref Quaternion, Vector4\[\], Int32, Int32)

Transforms a specified range in an array of Vector4s by a specified Quaternion into a specified range in a destination array.

##### Declaration

```
public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\[\]

sourceArray

The array of Vector4s containing the range to transform.

System.Int32

sourceIndex

The index in the source array of the first Vector4 to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\[\]

destinationArray

The existing destination array of Vector4s into which to write the results.

System.Int32

destinationIndex

The index in the destination array of the first result Vector4 to write.

System.Int32

length

The number of Vector4s to transform.

#### [](#VRageMath_Vector4_Transform_VRageMath_Vector4___VRageMath_Matrix__VRageMath_Vector4___)Transform(Vector4\[\], ref Matrix, Vector4\[\])

Transforms an array of Vector4s by a specified Matrix.

##### Declaration

```
public static void Transform(Vector4[] sourceArray, ref Matrix matrix, Vector4[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\[\]

sourceArray

The array of Vector4s to transform.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transform Matrix to apply.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\[\]

destinationArray

The existing destination array into which the transformed Vector4s are written.

#### [](#VRageMath_Vector4_Transform_VRageMath_Vector4___VRageMath_Quaternion__VRageMath_Vector4___)Transform(Vector4\[\], ref Quaternion, Vector4\[\])

Transforms an array of Vector4s by a specified Quaternion.

##### Declaration

```
public static void Transform(Vector4[] sourceArray, ref Quaternion rotation, Vector4[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\[\]

sourceArray

The array of Vector4s to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)\[\]

destinationArray

The existing destination array into which the transformed Vector4s are written.

#### [](#VRageMath_Vector4_UnpackOrthoMatrix_VRageMath_Vector4__)UnpackOrthoMatrix(ref Vector4)

##### Declaration

```
public static Matrix UnpackOrthoMatrix(ref Vector4 packed)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

packed

##### Returns

#### [](#VRageMath_Vector4_UnpackOrthoMatrix_VRageMath_Vector4__VRageMath_Matrix__)UnpackOrthoMatrix(ref Vector4, out Matrix)

##### Declaration

```
public static void UnpackOrthoMatrix(ref Vector4 packed, out Matrix matrix)
```

##### Parameters

### [](#operators)Operators
