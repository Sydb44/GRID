referenceVector

##### Returns

Type

Description

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

#### GetDirectionVector(Base6Directions.Direction)

Gets the base vector of the matrix, corresponding to the given direction

##### Declaration

```
public Vector3 GetDirectionVector(Base6Directions.Direction direction)
```

##### Parameters

Type

Name

Description

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

direction

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetEulerAnglesXYZ(ref Matrix, out Vector3)

##### Declaration

```
public static bool GetEulerAnglesXYZ(ref Matrix mat, out Vector3 xyz)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

mat

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

xyz

##### Returns

Type

Description

System.Boolean

#### GetHashCode()

Gets the hash code of this object.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

Type

Description

System.Int32

#### GetOrientation()

Gets the orientation.

##### Declaration

```
public Matrix GetOrientation()
```

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### GetRow(Int32)

##### Declaration

```
public Vector4 GetRow(int row)
```

##### Parameters

Type

Name

Description

System.Int32

row

##### Returns

Type

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

#### HasNoTranslationOrPerspective()

Returns true if this matrix represents invertible (you can call Invert on it) linear (it does not contain translation or perspective transformation) transformation. Such matrix consist solely of rotations, shearing, mirroring and scaling. It can be orthogonalized to create an orthogonal rotation matrix.

##### Declaration

```
public bool HasNoTranslationOrPerspective()
```

##### Returns

Type

Description

System.Boolean

#### Invert(Matrix)

Calculates the inverse of a matrix.

##### Declaration

```
public static Matrix Invert(Matrix matrix)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

Source matrix.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Invert(ref Matrix)

##### Declaration

```
public static Matrix Invert(ref Matrix matrix)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Invert(ref Matrix, out Matrix)

Calculates the inverse of a matrix.

##### Declaration

```
public static void Invert(ref Matrix matrix, out Matrix result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The source matrix.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The inverse of matrix. The same matrix can be used for both arguments.

#### IsMirrored()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### IsNan()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### IsOrthogonal()

##### Declaration

```
public bool IsOrthogonal()
```

##### Returns

Type

Description

System.Boolean

#### IsRotation()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### IsValid()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### Lerp(Matrix, Matrix, Single)

Linearly interpolates between the corresponding values of two matrices.

##### Declaration

```
public static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

Source matrix.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

Source matrix.

System.Single

amount

Interpolation value.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Lerp(ref Matrix, ref Matrix, Single, out Matrix)

Linearly interpolates between the corresponding values of two matrices.

##### Declaration

```
public static void Lerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

Source matrix.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

Source matrix.

System.Single

amount

Interpolation value.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] Resulting matrix.

#### Multiply(Matrix, Single)

Multiplies a matrix by a scalar value.

##### Declaration

```
public static Matrix Multiply(Matrix matrix1, float scaleFactor)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

Source matrix.

System.Single

scaleFactor

Scalar value.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Multiply(Matrix, Matrix)

Multiplies a matrix by another matrix.
