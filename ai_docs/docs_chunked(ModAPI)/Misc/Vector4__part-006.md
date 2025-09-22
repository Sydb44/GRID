##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

vector

The source Vector4.

##### Returns

#### [](#VRageMath_Vector4_Normalize_VRageMath_Vector4__VRageMath_Vector4__)Normalize(ref Vector4, out Vector4)

Returns a normalized version of the specified vector.

##### Declaration

```
public static void Normalize(ref Vector4 vector, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

vector

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The normalized vector.

#### [](#VRageMath_Vector4_PackOrthoMatrix_VRageMath_Matrix__)PackOrthoMatrix(ref Matrix)

##### Declaration

```
public static Vector4 PackOrthoMatrix(ref Matrix matrix)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

##### Returns

#### [](#VRageMath_Vector4_PackOrthoMatrix_VRageMath_Vector3_VRageMath_Vector3_VRageMath_Vector3_)PackOrthoMatrix(Vector3, Vector3, Vector3)

##### Declaration

```
public static Vector4 PackOrthoMatrix(Vector3 position, Vector3 forward, Vector3 up)
```

##### Parameters

##### Returns

#### [](#VRageMath_Vector4_SmoothStep_VRageMath_Vector4_VRageMath_Vector4_System_Single_)SmoothStep(Vector4, Vector4, Single)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source value.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source value.

System.Single

amount

Weighting value.

##### Returns

#### [](#VRageMath_Vector4_SmoothStep_VRageMath_Vector4__VRageMath_Vector4__System_Single_VRageMath_Vector4__)SmoothStep(ref Vector4, ref Vector4, Single, out Vector4)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static void SmoothStep(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source vector.

System.Single

amount

Weighting factor.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The interpolated value.

#### [](#VRageMath_Vector4_Subtract_VRageMath_Vector4_VRageMath_Vector4_)Subtract(Vector4, Vector4)

Subtracts a vector from a vector.

##### Declaration

```
public static Vector4 Subtract(Vector4 value1, Vector4 value2)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source vector.

##### Returns

#### [](#VRageMath_Vector4_Subtract_VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__)Subtract(ref Vector4, ref Vector4, out Vector4)

Subtracts a vector from a vector.

##### Declaration

```
public static void Subtract(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The result of the subtraction.

#### [](#VRageMath_Vector4_ToString)ToString()

Retrieves a string representation of the current object.

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### [](#VRageMath_Vector4_Transform_VRageMath_Vector2_VRageMath_Matrix_)Transform(Vector2, Matrix)

Transforms a Vector2 by the given Matrix.

##### Declaration

```
public static Vector4 Transform(Vector2 position, Matrix matrix)
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

##### Returns

#### [](#VRageMath_Vector4_Transform_VRageMath_Vector2_VRageMath_Quaternion_)Transform(Vector2, Quaternion)

Transforms a Vector2 by a specified Quaternion into a Vector4.

##### Declaration

```
public static Vector4 Transform(Vector2 value, Quaternion rotation)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

The Vector2 to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

##### Returns

#### [](#VRageMath_Vector4_Transform_VRageMath_Vector2__VRageMath_Matrix__VRageMath_Vector4__)Transform(ref Vector2, ref Matrix, out Vector4)

Transforms a Vector2 by the given Matrix.

##### Declaration

```
public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result)
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

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] The Vector4 resulting from the transformation.
