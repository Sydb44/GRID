[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

Source matrix.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Subtract(ref Matrix, ref Matrix, out Matrix)

Subtracts matrices.

##### Declaration

```
public static void Subtract(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
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

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] Result of the subtraction.

#### SwapYZCoordinates(Matrix)

##### Declaration

```
public static Matrix SwapYZCoordinates(Matrix m)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

m

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### ToString()

Retrieves a string representation of the current object.

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

#### Transform(Matrix, Quaternion)

Transforms a Matrix by applying a Quaternion rotation.

##### Declaration

```
public static Matrix Transform(Matrix value, Quaternion rotation)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

value

The Matrix to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The rotation to apply, expressed as a Quaternion.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Transform(ref Matrix, ref Quaternion, out Matrix)

Transforms a Matrix by applying a Quaternion rotation.

##### Declaration

```
public static void Transform(ref Matrix value, ref Quaternion rotation, out Matrix result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

value

The Matrix to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The rotation to apply, expressed as a Quaternion.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] An existing Matrix filled in with the result of the transform.

#### Transpose(Matrix)

Transposes the rows and columns of a matrix.

##### Declaration

```
public static Matrix Transpose(Matrix matrix)
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

#### Transpose(ref Matrix, out Matrix)

Transposes the rows and columns of a matrix.

##### Declaration

```
public static void Transpose(ref Matrix matrix, out Matrix result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

Source matrix.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] Transposed matrix.

#### TransposeRotationInPlace()

Transposes the rows and columns of a matrix that is assumed to be rotation only in place.

##### Declaration

```
public void TransposeRotationInPlace()
```

### Operators

#### Addition(Matrix, Matrix)

Adds a matrix to another matrix.

##### Declaration

```
public static Matrix operator +(Matrix matrix1, Matrix matrix2)
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

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Division(Matrix, Single)

Divides the components of a matrix by a scalar.

##### Declaration

```
public static Matrix operator /(Matrix matrix1, float divider)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

Source matrix.

System.Single

divider

The divisor.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Division(Matrix, Matrix)

Divides the components of a matrix by the corresponding components of another matrix.

##### Declaration

```
public static Matrix operator /(Matrix matrix1, Matrix matrix2)
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

The divisor.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Equality(Matrix, Matrix)

Compares a matrix for equality with another matrix.

##### Declaration

```
public static bool operator ==(Matrix matrix1, Matrix matrix2)
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
