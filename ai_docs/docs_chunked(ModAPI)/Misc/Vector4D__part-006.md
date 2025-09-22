Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] Vector pointing in the opposite direction.

#### [](#VRageMath_Vector4D_Normalize)Normalize()

Turns the current vector into a unit vector.

##### Declaration

#### [](#VRageMath_Vector4D_Normalize_VRageMath_Vector4D_)Normalize(Vector4D)

Creates a unit vector from the specified vector.

##### Declaration

```
public static Vector4D Normalize(Vector4D vector)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

vector

The source Vector4.

##### Returns

#### [](#VRageMath_Vector4D_Normalize_VRageMath_Vector4D__VRageMath_Vector4D__)Normalize(ref Vector4D, out Vector4D)

Returns a normalized version of the specified vector.

##### Declaration

```
public static void Normalize(ref Vector4D vector, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

vector

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] The normalized vector.

#### [](#VRageMath_Vector4D_PackOrthoMatrix_VRageMath_MatrixD__)PackOrthoMatrix(ref MatrixD)

##### Declaration

```
public static Vector4D PackOrthoMatrix(ref MatrixD matrix)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

##### Returns

#### [](#VRageMath_Vector4D_PackOrthoMatrix_VRageMath_Vector3D_VRageMath_Vector3_VRageMath_Vector3_)PackOrthoMatrix(Vector3D, Vector3, Vector3)

##### Declaration

```
public static Vector4D PackOrthoMatrix(Vector3D position, Vector3 forward, Vector3 up)
```

##### Parameters

##### Returns

#### [](#VRageMath_Vector4D_SmoothStep_VRageMath_Vector4D_VRageMath_Vector4D_System_Double_)SmoothStep(Vector4D, Vector4D, Double)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static Vector4D SmoothStep(Vector4D value1, Vector4D value2, double amount)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source value.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Source value.

System.Double

amount

Weighting value.

##### Returns

#### [](#VRageMath_Vector4D_SmoothStep_VRageMath_Vector4D__VRageMath_Vector4D__System_Double_VRageMath_Vector4D__)SmoothStep(ref Vector4D, ref Vector4D, Double, out Vector4D)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static void SmoothStep(ref Vector4D value1, ref Vector4D value2, double amount, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Source vector.

System.Double

amount

Weighting factor.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] The interpolated value.

#### [](#VRageMath_Vector4D_Subtract_VRageMath_Vector4_VRageMath_Vector4_)Subtract(Vector4, Vector4)

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

#### [](#VRageMath_Vector4D_Subtract_VRageMath_Vector4D__VRageMath_Vector4D__VRageMath_Vector4D__)Subtract(ref Vector4D, ref Vector4D, out Vector4D)

Subtracts a vector from a vector.

##### Declaration

```
public static void Subtract(ref Vector4D value1, ref Vector4D value2, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] The result of the subtraction.

#### [](#VRageMath_Vector4D_ToString)ToString()

Retrieves a string representation of the current object.

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### [](#VRageMath_Vector4D_Transform_VRageMath_Vector2_VRageMath_MatrixD_)Transform(Vector2, MatrixD)

Transforms a Vector2 by the given Matrix.

##### Declaration

```
public static Vector4D Transform(Vector2 position, MatrixD matrix)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

position

The source Vector2.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transformation Matrix.

##### Returns

#### [](#VRageMath_Vector4D_Transform_VRageMath_Vector2_VRageMath_Quaternion_)Transform(Vector2, Quaternion)

Transforms a Vector2 by a specified Quaternion into a Vector4.

##### Declaration

```
public static Vector4D Transform(Vector2 value, Quaternion rotation)
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
