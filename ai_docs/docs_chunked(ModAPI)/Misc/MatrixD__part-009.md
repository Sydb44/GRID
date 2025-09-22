up

Upward direction of the object; usually \[0, 1, 0\].

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] The created world matrix.

#### Determinant()

Calculates the determinant of the matrix.

##### Declaration

```
public double Determinant()
```

##### Returns

Type

Description

System.Double

#### Divide(MatrixD, Double)

Divides the components of a matrix by a scalar.

##### Declaration

```
public static MatrixD Divide(MatrixD matrix1, double divider)
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

#### Divide(MatrixD, MatrixD)

Divides the components of a matrix by the corresponding components of another matrix.

##### Declaration

```
public static MatrixD Divide(MatrixD matrix1, MatrixD matrix2)
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

#### Divide(ref MatrixD, Double, out MatrixD)

Divides the components of a matrix by a scalar.

##### Declaration

```
public static void Divide(ref MatrixD matrix1, double divider, out MatrixD result)
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

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] Result of the division.

#### Divide(ref MatrixD, ref MatrixD, out MatrixD)

Divides the components of a matrix by the corresponding components of another matrix.

##### Declaration

```
public static void Divide(ref MatrixD matrix1, ref MatrixD matrix2, out MatrixD result)
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

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

result

\[OutAttribute\] Result of the division.

#### Equals(Object)

Returns a value that indicates whether the current instance is equal to a specified object.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

Type

Name

Description

System.Object

obj

Object with which to make the comparison.

##### Returns

Type

Description

System.Boolean

#### Equals(MatrixD)

Determines whether the specified Object is equal to the Matrix.

##### Declaration

```
public bool Equals(MatrixD other)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

other

The Object to compare with the current Matrix.

##### Returns

Type

Description

System.Boolean

#### EqualsFast(ref MatrixD, Double)

Compares just position, forward and up

##### Declaration

```
public bool EqualsFast(ref MatrixD other, double epsilon = 0.0001)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

other

System.Double

epsilon

##### Returns

Type

Description

System.Boolean

#### GetClosestDirection(Vector3D)

##### Declaration

```
public Base6Directions.Direction GetClosestDirection(Vector3D referenceVector)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

referenceVector

##### Returns

Type

Description

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

#### GetClosestDirection(ref Vector3D)

##### Declaration

```
public Base6Directions.Direction GetClosestDirection(ref Vector3D referenceVector)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

referenceVector

##### Returns

Type

Description

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

#### GetDirectionVector(Base6Directions.Direction)

Gets the base vector of the matrix, corresponding to the given direction

##### Declaration

```
public Vector3D GetDirectionVector(Base6Directions.Direction direction)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetEulerAnglesXYZ(ref MatrixD, out Vector3D)

##### Declaration

```
public static bool GetEulerAnglesXYZ(ref MatrixD mat, out Vector3D xyz)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

mat

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

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
