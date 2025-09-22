Source matrix.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

Source matrix.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] Result of the subtraction.

#### SwapYZCoordinates(MatrixD)

##### Declaration

```
public static MatrixD SwapYZCoordinates(MatrixD m)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

m

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

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

#### Transform(MatrixD, Quaternion)

Transforms a Matrix by applying a Quaternion rotation.

##### Declaration

```
public static MatrixD Transform(MatrixD value, Quaternion rotation)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

value

The Matrix to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The rotation to apply, expressed as a Quaternion.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Transform(ref MatrixD, ref Quaternion, out MatrixD)

Transforms a Matrix by applying a Quaternion rotation.

##### Declaration

```
public static void Transform(ref MatrixD value, ref Quaternion rotation, out MatrixD result)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

value

The Matrix to transform.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The rotation to apply, expressed as a Quaternion.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] An existing Matrix filled in with the result of the transform.

#### Transpose(MatrixD)

Transposes the rows and columns of a matrix.

##### Declaration

```
public static MatrixD Transpose(MatrixD matrix)
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

#### Transpose(ref MatrixD, out MatrixD)

Transposes the rows and columns of a matrix.

##### Declaration

```
public static void Transpose(ref MatrixD matrix, out MatrixD result)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

Source matrix.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] Transposed matrix.

### Operators

#### Addition(MatrixD, MatrixD)

Adds a matrix to another matrix.

##### Declaration

```
public static MatrixD operator +(MatrixD matrix1, MatrixD matrix2)
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

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Division(MatrixD, Double)

Divides the components of a matrix by a scalar.

##### Declaration

```
public static MatrixD operator /(MatrixD matrix1, double divider)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

Source matrix.

System.Double

divider

The divisor.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Division(MatrixD, MatrixD)

Divides the components of a matrix by the corresponding components of another matrix.

##### Declaration

```
public static MatrixD operator /(MatrixD matrix1, MatrixD matrix2)
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

The divisor.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Equality(MatrixD, MatrixD)

Compares a matrix for equality with another matrix.

##### Declaration

```
public static bool operator ==(MatrixD matrix1, MatrixD matrix2)
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

##### Returns

Type

Description

System.Boolean

#### Implicit(in Matrix to MatrixD)

##### Declaration

```
public static implicit operator MatrixD(in Matrix m)
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

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Implicit(in MatrixD to Matrix)

##### Declaration

```
public static implicit operator Matrix(in MatrixD m)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

m
