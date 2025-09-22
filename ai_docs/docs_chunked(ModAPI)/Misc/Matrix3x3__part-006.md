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

#### [](#VRageMath_Matrix3x3_Negate_VRageMath_Matrix3x3__VRageMath_Matrix3x3__)Negate(ref Matrix3x3, out Matrix3x3)

Negates individual elements of a matrix.

##### Declaration

```
public static void Negate(ref Matrix3x3 matrix, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] Negated matrix. |

#### [](#VRageMath_Matrix3x3_Normalize_VRageMath_Matrix3x3_)Normalize(Matrix3x3)

##### Declaration

```
public static Matrix3x3 Normalize(Matrix3x3 matrix)
```

##### Parameters

##### Returns

#### [](#VRageMath_Matrix3x3_Orthogonalize_VRageMath_Matrix3x3_)Orthogonalize(Matrix3x3)

##### Declaration

```
public static Matrix3x3 Orthogonalize(Matrix3x3 rotationMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | rotationMatrix |     |

##### Returns

#### [](#VRageMath_Matrix3x3_Rescale_VRageMath_Matrix3x3_System_Single_)Rescale(Matrix3x3, Single)

##### Declaration

```
public static Matrix3x3 Rescale(Matrix3x3 matrix, float scale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix |     |
| System.Single | scale |     |

##### Returns

#### [](#VRageMath_Matrix3x3_Rescale_VRageMath_Matrix3x3_VRageMath_Vector3_)Rescale(Matrix3x3, Vector3)

##### Declaration

```
public static Matrix3x3 Rescale(Matrix3x3 matrix, Vector3 scale)
```

##### Parameters

##### Returns

#### [](#VRageMath_Matrix3x3_Rescale_VRageMath_Matrix3x3__System_Single_)Rescale(ref Matrix3x3, Single)

Same result as Matrix3x3.CreateScale(scale) \* matrix, but much faster

##### Declaration

```
public static void Rescale(ref Matrix3x3 matrix, float scale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix |     |
| System.Single | scale |     |

#### [](#VRageMath_Matrix3x3_Rescale_VRageMath_Matrix3x3__VRageMath_Vector3__)Rescale(ref Matrix3x3, ref Vector3)

Same result as Matrix3x3.CreateScale(scale) \* matrix, but much faster

##### Declaration

```
public static void Rescale(ref Matrix3x3 matrix, ref Vector3 scale)
```

##### Parameters

#### [](#VRageMath_Matrix3x3_Round_VRageMath_Matrix3x3__)Round(ref Matrix3x3)

##### Declaration

```
public static Matrix3x3 Round(ref Matrix3x3 matrix)
```

##### Parameters

##### Returns

#### [](#VRageMath_Matrix3x3_SetDirectionVector_VRageMath_Base6Directions_Direction_VRageMath_Vector3_)SetDirectionVector(Base6Directions.Direction, Vector3)

Sets the base vector of the matrix, corresponding to the given direction

##### Declaration

```
public void SetDirectionVector(Base6Directions.Direction direction, Vector3 newValue)
```

##### Parameters

#### [](#VRageMath_Matrix3x3_SetRow_System_Int32_VRageMath_Vector3_)SetRow(Int32, Vector3)

##### Declaration

```
public void SetRow(int row, Vector3 value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | row |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | value |     |

#### [](#VRageMath_Matrix3x3_Slerp_VRageMath_Matrix3x3__VRageMath_Matrix3x3__System_Single_VRageMath_Matrix3x3__)Slerp(ref Matrix3x3, ref Matrix3x3, Single, out Matrix3x3)

Performs spherical linear interpolation of position and rotation.

##### Declaration

```
public static void Slerp(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, float amount, out Matrix3x3 result)
```

##### Parameters

#### [](#VRageMath_Matrix3x3_SlerpScale_VRageMath_Matrix3x3__VRageMath_Matrix3x3__System_Single_VRageMath_Matrix3x3__)SlerpScale(ref Matrix3x3, ref Matrix3x3, Single, out Matrix3x3)

Performs spherical linear interpolation of position and rotation and scale.

##### Declaration

```
public static void SlerpScale(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, float amount, out Matrix3x3 result)
```

##### Parameters

#### [](#VRageMath_Matrix3x3_Subtract_VRageMath_Matrix3x3__VRageMath_Matrix3x3__VRageMath_Matrix3x3__)Subtract(ref Matrix3x3, ref Matrix3x3, out Matrix3x3)

Subtracts matrices.

##### Declaration

```
public static void Subtract(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix1 | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix2 | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] Result of the subtraction. |

#### [](#VRageMath_Matrix3x3_ToString)ToString()

Retrieves a string representation of the current object.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |
