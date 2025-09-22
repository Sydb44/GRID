[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

Source matrix.

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Multiply(MatrixD, MatrixD)

Multiplies a matrix by another matrix.

##### Declaration

```
public static MatrixD Multiply(MatrixD matrix1, MatrixD matrix2)
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

#### Multiply(ref MatrixD, Double, out MatrixD)

Multiplies a matrix by a scalar value.

##### Declaration

```
public static void Multiply(ref MatrixD matrix1, double scaleFactor, out MatrixD result)
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

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The result of the multiplication.

#### Multiply(ref MatrixD, ref Matrix, out MatrixD)

Multiplies a matrix by another matrix.

##### Declaration

```
public static void Multiply(ref MatrixD matrix1, ref Matrix matrix2, out MatrixD result)
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

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] Result of the multiplication.

#### Multiply(ref MatrixD, ref MatrixD, out MatrixD)

Multiplies a matrix by another matrix.

##### Declaration

```
public static void Multiply(ref MatrixD matrix1, ref MatrixD matrix2, out MatrixD result)
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

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] Result of the multiplication.

#### Negate(MatrixD)

Negates individual elements of a matrix.

##### Declaration

```
public static MatrixD Negate(MatrixD matrix)
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

#### Negate(ref MatrixD, out MatrixD)

Negates individual elements of a matrix.

##### Declaration

```
public static void Negate(ref MatrixD matrix, out MatrixD result)
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

\[OutAttribute\] Negated matrix.

#### Normalize(MatrixD)

##### Declaration

```
public static MatrixD Normalize(MatrixD matrix)
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

#### Orthogonalize()

##### Declaration

```
public void Orthogonalize()
```

#### Orthogonalize(MatrixD)

##### Declaration

```
public static MatrixD Orthogonalize(MatrixD rotationMatrix)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

rotationMatrix

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Rescale(MatrixD, Double)

##### Declaration

```
public static MatrixD Rescale(MatrixD matrix, double scale)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

System.Double

scale

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Rescale(MatrixD, Vector3D)

##### Declaration

```
public static MatrixD Rescale(MatrixD matrix, Vector3D scale)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

scale

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Rescale(ref MatrixD, Double)

Same result as Matrix.CreateScale(scale) \* matrix, but much faster

##### Declaration

```
public static void Rescale(ref MatrixD matrix, double scale)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

System.Double

scale

#### Rescale(ref MatrixD, Single)

Same result as Matrix.CreateScale(scale) \* matrix, but much faster

##### Declaration

```
public static void Rescale(ref MatrixD matrix, float scale)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

System.Single

scale
