The Vector4 to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

##### Returns

#### [](#VRageMath_Vector4D_Transform_VRageMath_Vector4D__VRageMath_MatrixD__VRageMath_Vector4D__)Transform(ref Vector4D, ref MatrixD, out Vector4D)

Transforms a Vector4 by the given Matrix.

##### Declaration

```
public static void Transform(ref Vector4D vector, ref MatrixD matrix, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

vector

The source Vector4.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transformation Matrix.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] The Vector4 resulting from the transformation.

#### [](#VRageMath_Vector4D_Transform_VRageMath_Vector4D__VRageMath_Quaternion__VRageMath_Vector4D__)Transform(ref Vector4D, ref Quaternion, out Vector4D)

Transforms a Vector4 by a specified Quaternion.

##### Declaration

```
public static void Transform(ref Vector4D value, ref Quaternion rotation, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value

The Vector4 to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] The Vector4 resulting from the transformation.

#### [](#VRageMath_Vector4D_Transform_VRageMath_Vector4D___System_Int32_VRageMath_MatrixD__VRageMath_Vector4D___System_Int32_System_Int32_)Transform(Vector4D\[\], Int32, ref MatrixD, Vector4D\[\], Int32, Int32)

Transforms a specified range in an array of Vector4s by a specified Matrix into a specified range in a destination array.

##### Declaration

```
public static void Transform(Vector4D[] sourceArray, int sourceIndex, ref MatrixD matrix, Vector4D[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)\[\]

sourceArray

The array of Vector4s containing the range to transform.

System.Int32

sourceIndex

The index in the source array of the first Vector4 to transform.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transform Matrix to apply.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)\[\]

destinationArray

The existing destination array of Vector4s into which to write the results.

System.Int32

destinationIndex

The index in the destination array of the first result Vector4 to write.

System.Int32

length

The number of Vector4s to transform.

#### [](#VRageMath_Vector4D_Transform_VRageMath_Vector4D___System_Int32_VRageMath_Quaternion__VRageMath_Vector4D___System_Int32_System_Int32_)Transform(Vector4D\[\], Int32, ref Quaternion, Vector4D\[\], Int32, Int32)

Transforms a specified range in an array of Vector4s by a specified Quaternion into a specified range in a destination array.

##### Declaration

```
public static void Transform(Vector4D[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4D[] destinationArray, int destinationIndex, int length)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)\[\]

sourceArray

The array of Vector4s containing the range to transform.

System.Int32

sourceIndex

The index in the source array of the first Vector4 to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)\[\]

destinationArray

The existing destination array of Vector4s into which to write the results.

System.Int32

destinationIndex

The index in the destination array of the first result Vector4 to write.

System.Int32

length

The number of Vector4s to transform.

#### [](#VRageMath_Vector4D_Transform_VRageMath_Vector4D___VRageMath_MatrixD__VRageMath_Vector4D___)Transform(Vector4D\[\], ref MatrixD, Vector4D\[\])

Transforms an array of Vector4s by a specified Matrix.

##### Declaration

```
public static void Transform(Vector4D[] sourceArray, ref MatrixD matrix, Vector4D[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)\[\]

sourceArray

The array of Vector4s to transform.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transform Matrix to apply.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)\[\]

destinationArray

The existing destination array into which the transformed Vector4s are written.

#### [](#VRageMath_Vector4D_Transform_VRageMath_Vector4D___VRageMath_Quaternion__VRageMath_Vector4D___)Transform(Vector4D\[\], ref Quaternion, Vector4D\[\])

Transforms an array of Vector4s by a specified Quaternion.

##### Declaration

```
public static void Transform(Vector4D[] sourceArray, ref Quaternion rotation, Vector4D[] destinationArray)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)\[\]

sourceArray

The array of Vector4s to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)\[\]

destinationArray

The existing destination array into which the transformed Vector4s are written.
