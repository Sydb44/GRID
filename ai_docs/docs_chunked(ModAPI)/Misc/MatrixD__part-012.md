Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

System.Single

scale

#### Rescale(ref MatrixD, ref Vector3D)

Same result as Matrix.CreateScale(scale) \* matrix, but much faster

##### Declaration

```
public static void Rescale(ref MatrixD matrix, ref Vector3D scale)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

scale

#### SetDirectionVector(Base6Directions.Direction, Vector3D)

Sets the base vector of the matrix, corresponding to the given direction

##### Declaration

```
public void SetDirectionVector(Base6Directions.Direction direction, Vector3D newValue)
```

##### Parameters

Type

Name

Description

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

direction

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

newValue

#### SetFrom(in Matrix)

##### Declaration

```
public void SetFrom(in Matrix m)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

m

#### SetRotationAndScale(in Matrix)

##### Declaration

```
public void SetRotationAndScale(in Matrix m)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

m

#### SetRow(Int32, Vector4)

##### Declaration

```
public void SetRow(int row, Vector4 value)
```

##### Parameters

Type

Name

Description

System.Int32

row

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value

#### Slerp(MatrixD, MatrixD, Double)

Performs spherical linear interpolation of position and rotation.

##### Declaration

```
public static MatrixD Slerp(MatrixD matrix1, MatrixD matrix2, double amount)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

System.Double

amount

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### Slerp(in MatrixD, in MatrixD, Double, out MatrixD)

Performs spherical linear interpolation of position and rotation.

##### Declaration

```
public static void Slerp(in MatrixD matrix1, in MatrixD matrix2, double amount, out MatrixD result)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

System.Double

amount

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

#### SlerpScale(MatrixD, MatrixD, Double)

Performs spherical linear interpolation of position and rotation and scale.

##### Declaration

```
public static MatrixD SlerpScale(MatrixD matrix1, MatrixD matrix2, double amount)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

System.Double

amount

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### SlerpScale(MatrixD, MatrixD, Double, out MatrixD)

Performs spherical linear interpolation of position and rotation and scale.

##### Declaration

```
public static void SlerpScale(MatrixD matrix1, MatrixD matrix2, double amount, out MatrixD result)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

System.Double

amount

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

#### SlerpScale(ref MatrixD, ref MatrixD, Double, out MatrixD)

Performs spherical linear interpolation of position and rotation and scale.

##### Declaration

```
public static void SlerpScale(ref MatrixD matrix1, ref MatrixD matrix2, double amount, out MatrixD result)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix1

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix2

System.Double

amount

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

#### Subtract(Matrix, Matrix)

Subtracts matrices.

##### Declaration

```
public static Matrix Subtract(Matrix matrix1, Matrix matrix2)
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

#### Subtract(ref MatrixD, ref MatrixD, out MatrixD)

Subtracts matrices.

##### Declaration

```
public static void Subtract(ref MatrixD matrix1, ref MatrixD matrix2, out MatrixD result)
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

\[OutAttribute\] Result of the subtraction.
