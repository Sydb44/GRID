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

System.Boolean

#### Inequality(Matrix, Matrix)

Tests a matrix for inequality with another matrix.

##### Declaration

```
public static bool operator !=(Matrix matrix1, Matrix matrix2)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

The matrix on the left of the equal sign.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

The matrix on the right of the equal sign.

##### Returns

Type

Description

System.Boolean

#### Multiply(Single, Matrix)

Multiplies a matrix by a scalar value.

##### Declaration

```
public static Matrix operator *(float scaleFactor, Matrix matrix)
```

##### Parameters

Type

Name

Description

System.Single

scaleFactor

Scalar value.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

Source matrix.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Multiply(Matrix, Single)

Multiplies a matrix by a scalar value.

##### Declaration

```
public static Matrix operator *(Matrix matrix, float scaleFactor)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

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

##### Declaration

```
public static Matrix operator *(Matrix matrix1, Matrix matrix2)
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

#### Subtraction(Matrix, Matrix)

Subtracts matrices.

##### Declaration

```
public static Matrix operator -(Matrix matrix1, Matrix matrix2)
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

#### UnaryNegation(Matrix)

Negates individual elements of a matrix.

##### Declaration

```
public static Matrix operator -(Matrix matrix1)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

Source matrix.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)