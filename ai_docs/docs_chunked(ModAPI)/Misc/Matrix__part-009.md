Position of the object. This value is used in translation operations.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

forward

Forward direction of the object.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

up

Upward direction of the object; usually \[0, 1, 0\].

##### Returns

Type

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

#### CreateWorld(ref Vector3, ref Vector3, ref Vector3, out Matrix)

Creates a world matrix with the specified parameters.

##### Declaration

```
public static void CreateWorld(ref Vector3 position, ref Vector3 forward, ref Vector3 up, out Matrix result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

Position of the object. This value is used in translation operations.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

forward

Forward direction of the object.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

up

Upward direction of the object; usually \[0, 1, 0\].

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] The created world matrix.

#### Determinant()

Calculates the determinant of the matrix.

##### Declaration

```
public float Determinant()
```

##### Returns

Type

Description

System.Single

#### Divide(Matrix, Single)

Divides the components of a matrix by a scalar.

##### Declaration

```
public static Matrix Divide(Matrix matrix1, float divider)
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

#### Divide(Matrix, Matrix)

Divides the components of a matrix by the corresponding components of another matrix.

##### Declaration

```
public static Matrix Divide(Matrix matrix1, Matrix matrix2)
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

#### Divide(ref Matrix, Single, out Matrix)

Divides the components of a matrix by a scalar.

##### Declaration

```
public static void Divide(ref Matrix matrix1, float divider, out Matrix result)
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

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

result

\[OutAttribute\] Result of the division.

#### Divide(ref Matrix, ref Matrix, out Matrix)

Divides the components of a matrix by the corresponding components of another matrix.

##### Declaration

```
public static void Divide(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
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

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

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

#### Equals(Matrix)

Determines whether the specified Object is equal to the Matrix.

##### Declaration

```
public bool Equals(Matrix other)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

other

The Object to compare with the current Matrix.

##### Returns

Type

Description

System.Boolean

#### EqualsFast(ref Matrix, Single)

Compares just position, forward and up

##### Declaration

```
public bool EqualsFast(ref Matrix other, float epsilon = 0.0001F)
```

##### Parameters

Type

Name

Description

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

other

System.Single

epsilon

##### Returns

Type

Description

System.Boolean

#### GetClosestDirection(Vector3)

##### Declaration

```
public Base6Directions.Direction GetClosestDirection(Vector3 referenceVector)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

referenceVector

##### Returns

Type

Description

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

#### GetClosestDirection(ref Vector3)

##### Declaration

```
public Base6Directions.Direction GetClosestDirection(ref Vector3 referenceVector)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

referenceVector

##### Returns

Type

Description

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

#### GetDirectionVector(Base6Directions.Direction)

Gets the base vector of the matrix, corresponding to the given direction
