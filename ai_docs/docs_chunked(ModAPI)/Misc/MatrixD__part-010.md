```

##### Returns

Type

Description

System.Int32

#### GetOrientation()

Gets the orientation.

##### Declaration

```
public MatrixD GetOrientation()
```

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### GetRow(Int32)

##### Declaration

```
public Vector4D GetRow(int row)
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

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

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

#### Invert(MatrixD)

Calculates the inverse of a matrix.

##### Declaration

```
public static MatrixD Invert(MatrixD matrix)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

Source matrix.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Invert(ref MatrixD)

##### Declaration

```
public static MatrixD Invert(ref MatrixD matrix)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Invert(ref MatrixD, out MatrixD)

Calculates the inverse of a matrix.

##### Declaration

```
public static void Invert(ref MatrixD matrix, out MatrixD result)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The source matrix.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

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

#### IsOrthogonal(Double)

##### Declaration

```
public bool IsOrthogonal(double epsilon)
```

##### Parameters

Type

Name

Description

System.Double

epsilon

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

#### Lerp(MatrixD, MatrixD, Double)

Linearly interpolates between the corresponding values of two matrices.

##### Declaration

```
public static MatrixD Lerp(MatrixD matrix1, MatrixD matrix2, double amount)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

Source matrix.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

Source matrix.

System.Double

amount

Interpolation value.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Lerp(ref MatrixD, ref MatrixD, Double, out MatrixD)

Linearly interpolates between the corresponding values of two matrices.

##### Declaration

```
public static void Lerp(ref MatrixD matrix1, ref MatrixD matrix2, double amount, out MatrixD result)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

Source matrix.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

Source matrix.

System.Double

amount

Interpolation value.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] Resulting matrix.

#### Multiply(ref Matrix, ref MatrixD, out MatrixD)

##### Declaration

```
public static void Multiply(ref Matrix matrix1, ref MatrixD matrix2, out MatrixD result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

#### Multiply(MatrixD, Double)

Multiplies a matrix by a scalar value.

##### Declaration

```
public static MatrixD Multiply(MatrixD matrix1, double scaleFactor)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

Source matrix.

System.Double

scaleFactor

Scalar value.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Multiply(MatrixD, Matrix)

Multiplies a matrix by another matrix.

##### Declaration

```
public static MatrixD Multiply(MatrixD matrix1, Matrix matrix2)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

Source matrix.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

Source matrix.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)
