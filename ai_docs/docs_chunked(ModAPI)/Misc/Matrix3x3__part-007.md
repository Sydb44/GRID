Retrieves a string representation of the current object.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRageMath_Matrix3x3_Transform_VRageMath_Matrix3x3__VRageMath_Quaternion__VRageMath_Matrix3x3__)Transform(ref Matrix3x3, ref Quaternion, out Matrix3x3)

Transforms a Matrix3x3 by applying a Quaternion rotation.

##### Declaration

```
public static void Transform(ref Matrix3x3 value, ref Quaternion rotation, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | value | The Matrix3x3 to transform. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | rotation | The rotation to apply, expressed as a Quaternion. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] An existing Matrix3x3 filled in with the result of the transform. |

#### [](#VRageMath_Matrix3x3_Transpose)Transpose()

##### Declaration

#### [](#VRageMath_Matrix3x3_Transpose_VRageMath_Matrix3x3__VRageMath_Matrix3x3__)Transpose(ref Matrix3x3, out Matrix3x3)

Transposes the rows and columns of a matrix.

##### Declaration

```
public static void Transpose(ref Matrix3x3 matrix, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] Transposed matrix. |