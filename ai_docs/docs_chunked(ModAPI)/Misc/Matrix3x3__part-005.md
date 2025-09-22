
##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | other |     |
| System.Single | epsilon |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_Matrix3x3_GetClosestDirection_VRageMath_Vector3_)GetClosestDirection(Vector3)

##### Declaration

```
public Base6Directions.Direction GetClosestDirection(Vector3 referenceVector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | referenceVector |     |

##### Returns

#### [](#VRageMath_Matrix3x3_GetClosestDirection_VRageMath_Vector3__)GetClosestDirection(ref Vector3)

##### Declaration

```
public Base6Directions.Direction GetClosestDirection(ref Vector3 referenceVector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | referenceVector |     |

##### Returns

#### [](#VRageMath_Matrix3x3_GetDirectionVector_VRageMath_Base6Directions_Direction_)GetDirectionVector(Base6Directions.Direction)

Gets the base vector of the matrix, corresponding to the given direction

##### Declaration

```
public Vector3 GetDirectionVector(Base6Directions.Direction direction)
```

##### Parameters

##### Returns

#### [](#VRageMath_Matrix3x3_GetEulerAnglesXYZ_VRageMath_Matrix3x3__VRageMath_Vector3__)GetEulerAnglesXYZ(ref Matrix3x3, out Vector3)

##### Declaration

```
public static bool GetEulerAnglesXYZ(ref Matrix3x3 mat, out Vector3 xyz)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_Matrix3x3_GetHashCode)GetHashCode()

Gets the hash code of this object.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_Matrix3x3_GetOrientation)GetOrientation()

Gets the orientation.

##### Declaration

```
public Matrix3x3 GetOrientation()
```

##### Returns

#### [](#VRageMath_Matrix3x3_GetRow_System_Int32_)GetRow(Int32)

##### Declaration

```
public Vector3 GetRow(int row)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | row |     |

##### Returns

#### [](#VRageMath_Matrix3x3_Invert_VRageMath_Matrix3x3__VRageMath_Matrix3x3__)Invert(ref Matrix3x3, out Matrix3x3)

Calculates the inverse of a matrix.

##### Declaration

```
public static void Invert(ref Matrix3x3 matrix, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix | The source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The inverse of matrix. The same matrix can be used for both arguments. |

#### [](#VRageMath_Matrix3x3_IsMirrored)IsMirrored()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_Matrix3x3_IsNan)IsNan()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_Matrix3x3_IsOrthogonal)IsOrthogonal()

##### Declaration

```
public bool IsOrthogonal()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_Matrix3x3_IsRotation)IsRotation()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_Matrix3x3_IsValid)IsValid()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_Matrix3x3_Lerp_VRageMath_Matrix3x3__VRageMath_Matrix3x3__System_Single_VRageMath_Matrix3x3__)Lerp(ref Matrix3x3, ref Matrix3x3, Single, out Matrix3x3)

Linearly interpolates between the corresponding values of two matrices.

##### Declaration

```
public static void Lerp(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, float amount, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix1 | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix2 | Source matrix. |
| System.Single | amount | Interpolation value. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] Resulting matrix. |

#### [](#VRageMath_Matrix3x3_Multiply_VRageMath_Matrix3x3__System_Single_VRageMath_Matrix3x3__)Multiply(ref Matrix3x3, Single, out Matrix3x3)

Multiplies a matrix by a scalar value.

##### Declaration

```
public static void Multiply(ref Matrix3x3 matrix1, float scaleFactor, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix1 | Source matrix. |
| System.Single | scaleFactor | Scalar value. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The result of the multiplication. |

#### [](#VRageMath_Matrix3x3_Multiply_VRageMath_Matrix3x3__VRageMath_Matrix3x3__VRageMath_Matrix3x3__)Multiply(ref Matrix3x3, ref Matrix3x3, out Matrix3x3)

Multiplies a matrix by another matrix.

##### Declaration

```
public static void Multiply(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix1 | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix2 | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] Result of the multiplication. |
