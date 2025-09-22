
```
public static void CreateScale(float xScale, float yScale, float zScale, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | xScale | Value to scale by on the x-axis. |
| System.Single | yScale | Value to scale by on the y-axis. |
| System.Single | zScale | Value to scale by on the z-axis. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The created scaling Matrix3x3. |

#### [](#VRageMath_Matrix3x3_CreateScale_System_Single_VRageMath_Matrix3x3__)CreateScale(Single, out Matrix3x3)

Creates a scaling Matrix3x3.

##### Declaration

```
public static void CreateScale(float scale, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | scale | Value to scale by. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The created scaling Matrix3x3. |

#### [](#VRageMath_Matrix3x3_CreateScale_VRageMath_Vector3_)CreateScale(Vector3)

Creates a scaling Matrix3x3.

##### Declaration

```
public static Matrix3x3 CreateScale(Vector3 scales)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | scales | Amounts to scale by on the x, y, and z axes. |

##### Returns

#### [](#VRageMath_Matrix3x3_CreateScale_VRageMath_Vector3__VRageMath_Matrix3x3__)CreateScale(ref Vector3, out Matrix3x3)

Creates a scaling Matrix3x3.

##### Declaration

```
public static void CreateScale(ref Vector3 scales, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | scales | Amounts to scale by on the x, y, and z axes. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] The created scaling Matrix3x3. |

#### [](#VRageMath_Matrix3x3_CreateWorld_VRageMath_Vector3__VRageMath_Vector3__)CreateWorld(ref Vector3, ref Vector3)

Creates a world matrix with the specified parameters.

##### Declaration

```
public static Matrix3x3 CreateWorld(ref Vector3 forward, ref Vector3 up)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | forward | Forward direction of the object. |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | up  | Upward direction of the object; usually \[0, 1, 0\]. |

##### Returns

#### [](#VRageMath_Matrix3x3_Determinant)Determinant()

##### Declaration

```
public float Determinant()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_Matrix3x3_Divide_VRageMath_Matrix3x3__System_Single_VRageMath_Matrix3x3__)Divide(ref Matrix3x3, Single, out Matrix3x3)

Divides the components of a matrix by a scalar.

##### Declaration

```
public static void Divide(ref Matrix3x3 matrix1, float divider, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix1 | Source matrix. |
| System.Single | divider | The divisor. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] Result of the division. |

#### [](#VRageMath_Matrix3x3_Divide_VRageMath_Matrix3x3__VRageMath_Matrix3x3__VRageMath_Matrix3x3__)Divide(ref Matrix3x3, ref Matrix3x3, out Matrix3x3)

Divides the components of a matrix by the corresponding components of another matrix.

##### Declaration

```
public static void Divide(ref Matrix3x3 matrix1, ref Matrix3x3 matrix2, out Matrix3x3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix1 | Source matrix. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | matrix2 | The divisor. |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | result | \[OutAttribute\] Result of the division. |

#### [](#VRageMath_Matrix3x3_Equals_System_Object_)Equals(Object)

Returns a value that indicates whether the current instance is equal to a specified object.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | Object with which to make the comparison. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_Matrix3x3_Equals_VRageMath_Matrix3x3_)Equals(Matrix3x3)

Determines whether the specified Object is equal to the Matrix3x3.

##### Declaration

```
public bool Equals(Matrix3x3 other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | other | The Object to compare with the current Matrix3x3. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_Matrix3x3_EqualsFast_VRageMath_Matrix3x3__System_Single_)EqualsFast(ref Matrix3x3, Single)

Compares just position, forward and up

##### Declaration

```
public bool EqualsFast(ref Matrix3x3 other, float epsilon = 0.0001F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix3x3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix3x3.html) | other |     |
| System.Single | epsilon |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
