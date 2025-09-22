matrix

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

scale

#### Round(ref Matrix)

##### Declaration

```
public static Matrix Round(ref Matrix matrix)
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

#### SetDirectionVector(Base6Directions.Direction, Vector3)

Sets the base vector of the matrix, corresponding to the given direction

##### Declaration

```
public void SetDirectionVector(Base6Directions.Direction direction, Vector3 newValue)
```

##### Parameters

Type

Name

Description

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

direction

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

newValue

#### SetFrom(in MatrixD)

Set this ma

##### Declaration

```
public void SetFrom(in MatrixD m)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

m

#### SetRotationAndScale(in MatrixD)

##### Declaration

```
public void SetRotationAndScale(in MatrixD m)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

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

#### Slerp(Matrix, Matrix, Single)

Performs spherical linear interpolation of position and rotation.

##### Declaration

```
public static Matrix Slerp(Matrix matrix1, Matrix matrix2, float amount)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

System.Single

amount

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### Slerp(Matrix, Matrix, Single, out Matrix)

Performs spherical linear interpolation of position and rotation.

##### Declaration

```
public static void Slerp(Matrix matrix1, Matrix matrix2, float amount, out Matrix result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

System.Single

amount

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

#### Slerp(ref Matrix, ref Matrix, Single, out Matrix)

Performs spherical linear interpolation of position and rotation.

##### Declaration

```
public static void Slerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

System.Single

amount

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

#### SlerpScale(Matrix, Matrix, Single)

Performs spherical linear interpolation of position and rotation and scale.

##### Declaration

```
public static Matrix SlerpScale(Matrix matrix1, Matrix matrix2, float amount)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

System.Single

amount

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### SlerpScale(Matrix, Matrix, Single, out Matrix)

Performs spherical linear interpolation of position and rotation and scale.

##### Declaration

```
public static void SlerpScale(Matrix matrix1, Matrix matrix2, float amount, out Matrix result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

System.Single

amount

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

#### SlerpScale(ref Matrix, ref Matrix, Single, out Matrix)

Performs spherical linear interpolation of position and rotation and scale.

##### Declaration

```
public static void SlerpScale(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix1

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix2

System.Single

amount

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

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
