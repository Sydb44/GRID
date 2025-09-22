Scalar value.

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Multiply(Matrix, Matrix)

Multiplies a matrix by another matrix.

##### Declaration

```
public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
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

#### Multiply(ref Matrix, Single, out Matrix)

Multiplies a matrix by a scalar value.

##### Declaration

```
public static void Multiply(ref Matrix matrix1, float scaleFactor, out Matrix result)
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

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The result of the multiplication.

#### Multiply(ref Matrix, ref Matrix, out Matrix)

Multiplies a matrix by another matrix.

##### Declaration

```
public static void Multiply(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
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

\[OutAttribute\] Result of the multiplication.

#### MultiplyRotation(ref Matrix, ref Matrix, out Matrix)

Multiplies a matrix by another matrix, only rotation parts.

##### Declaration

```
public static void MultiplyRotation(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
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

\[OutAttribute\] Result of the multiplication.

#### Negate(Matrix)

Negates individual elements of a matrix.

##### Declaration

```
public static Matrix Negate(Matrix matrix)
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

#### Negate(ref Matrix, out Matrix)

Negates individual elements of a matrix.

##### Declaration

```
public static void Negate(ref Matrix matrix, out Matrix result)
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

\[OutAttribute\] Negated matrix.

#### Normalize(Matrix)

##### Declaration

```
public static Matrix Normalize(Matrix matrix)
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

#### Orthogonalize(Matrix)

##### Declaration

```
public static Matrix Orthogonalize(Matrix rotationMatrix)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

rotationMatrix

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Rescale(Matrix, Single)

##### Declaration

```
public static Matrix Rescale(Matrix matrix, float scale)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

System.Single

scale

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Rescale(Matrix, Vector3)

##### Declaration

```
public static Matrix Rescale(Matrix matrix, Vector3 scale)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

scale

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Rescale(ref Matrix, Single)

Same result as Matrix.CreateScale(scale) \* matrix, but much faster

##### Declaration

```
public static void Rescale(ref Matrix matrix, float scale)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

System.Single

scale

#### Rescale(ref Matrix, ref Vector3)

Same result as Matrix.CreateScale(scale) \* matrix, but much faster

##### Declaration

```
public static void Rescale(ref Matrix matrix, ref Vector3 scale)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

scale

#### Round(ref Matrix)

##### Declaration

```
public static Matrix Round(ref Matrix matrix)
```
