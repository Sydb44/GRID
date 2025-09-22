The array of Vector4s to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)\[\]

destinationArray

The existing destination array into which the transformed Vector4s are written.

#### [](#VRageMath_Vector4D_UnpackOrthoMatrix_VRageMath_Vector4D__)UnpackOrthoMatrix(ref Vector4D)

##### Declaration

```
public static MatrixD UnpackOrthoMatrix(ref Vector4D packed)
```

##### Parameters

##### Returns

### [](#operators)Operators

#### [](#VRageMath_Vector4D_op_Addition_VRageMath_Vector4D_VRageMath_Vector4D_)Addition(Vector4D, Vector4D)

Adds two vectors.

##### Declaration

```
public static Vector4D operator +(Vector4D value1, Vector4D value2)
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

##### Returns

#### [](#VRageMath_Vector4D_op_Division_System_Double_VRageMath_Vector4D_)Division(Double, Vector4D)

Divides a vector by a scalar value.

##### Declaration

```
public static Vector4D operator /(double lhs, Vector4D rhs)
```

##### Parameters

Type

Name

Description

System.Double

lhs

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

rhs

The divisor.

##### Returns

#### [](#VRageMath_Vector4D_op_Division_VRageMath_Vector4D_System_Double_)Division(Vector4D, Double)

Divides a vector by a scalar value.

##### Declaration

```
public static Vector4D operator /(Vector4D value1, double divider)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source vector.

System.Double

divider

The divisor.

##### Returns

#### [](#VRageMath_Vector4D_op_Division_VRageMath_Vector4D_VRageMath_Vector4D_)Division(Vector4D, Vector4D)

Divides the components of a vector by the components of another vector.

##### Declaration

```
public static Vector4D operator /(Vector4D value1, Vector4D value2)
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

Divisor vector.

##### Returns

#### [](#VRageMath_Vector4D_op_Equality_VRageMath_Vector4D_VRageMath_Vector4D_)Equality(Vector4D, Vector4D)

Tests vectors for equality.

##### Declaration

```
public static bool operator ==(Vector4D value1, Vector4D value2)
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

##### Returns

Type

Description

System.Boolean

#### [](#VRageMath_Vector4D_op_Implicit_VRageMath_Vector4__VRageMath_Vector4D)Implicit(Vector4 to Vector4D)

##### Declaration

```
public static implicit operator Vector4D(Vector4 v)
```

##### Parameters

##### Returns

#### [](#VRageMath_Vector4D_op_Implicit_VRageMath_Vector4D__VRageMath_Vector4)Implicit(Vector4D to Vector4)

##### Declaration

```
public static implicit operator Vector4(Vector4D v)
```

##### Parameters

##### Returns

#### [](#VRageMath_Vector4D_op_Inequality_VRageMath_Vector4D_VRageMath_Vector4D_)Inequality(Vector4D, Vector4D)

Tests vectors for inequality.

##### Declaration

```
public static bool operator !=(Vector4D value1, Vector4D value2)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Vector to compare.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Vector to compare.

##### Returns

Type

Description

System.Boolean

#### [](#VRageMath_Vector4D_op_Multiply_System_Double_VRageMath_Vector4D_)Multiply(Double, Vector4D)

Multiplies a vector by a scalar.

##### Declaration

```
public static Vector4D operator *(double scaleFactor, Vector4D value1)
```

##### Parameters

Type

Name

Description

System.Double

scaleFactor

Scalar value.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source vector.

##### Returns

#### [](#VRageMath_Vector4D_op_Multiply_VRageMath_Vector4D_System_Double_)Multiply(Vector4D, Double)

Multiplies a vector by a scalar.

##### Declaration

```
public static Vector4D operator *(Vector4D value1, double scaleFactor)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source vector.

System.Double

scaleFactor

Scalar value.

##### Returns

#### [](#VRageMath_Vector4D_op_Multiply_VRageMath_Vector4D_VRageMath_Vector4D_)Multiply(Vector4D, Vector4D)

Multiplies the components of two vectors by each other.

##### Declaration

```
public static Vector4D operator *(Vector4D value1, Vector4D value2)
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

##### Returns

#### [](#VRageMath_Vector4D_op_Subtraction_VRageMath_Vector4D_VRageMath_Vector4D_)Subtraction(Vector4D, Vector4D)

Subtracts a vector from a vector.

##### Declaration

```
public static Vector4D operator -(Vector4D value1, Vector4D value2)
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
