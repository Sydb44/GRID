Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### SmoothStep(ref Vector3, ref Vector3, Single, out Vector3)

Interpolates between two values using a cubic equation.

##### Declaration

```
public static void SmoothStep(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

System.Single

amount

Weighting value.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The interpolated value.

#### Step(Vector3)

##### Declaration

```
public static Vector3 Step(Vector3 value)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Subtract(Vector3, Vector3)

Subtracts a vector from a vector.

##### Declaration

```
public static Vector3 Subtract(Vector3 value1, Vector3 value2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Subtract(ref Vector3, ref Vector3, out Vector3)

Subtracts a vector from a vector.

##### Declaration

```
public static void Subtract(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The result of the subtraction.

#### SwapYZCoordinates(Vector3)

##### Declaration

```
public static Vector3 SwapYZCoordinates(Vector3 v)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

v

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

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

#### ToString(String)

##### Declaration

```
public string ToString(string format)
```

##### Parameters

Type

Name

Description

System.String

format

##### Returns

Type

Description

System.String

#### Transform(Vector3, Matrix)

Transforms a 3D vector by the given matrix.

##### Declaration

```
public static Vector3 Transform(Vector3 position, Matrix matrix)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

The source vector.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Transform(Vector3, ref Matrix)

##### Declaration

```
public static Vector3 Transform(Vector3 position, ref Matrix matrix)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Transform(Vector3, MatrixD)

Transforms a 3D vector by the given matrix.

##### Declaration

```
public static Vector3D Transform(Vector3 position, MatrixD matrix)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

The source vector.

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

matrix

The transformation matrix.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Transform(Vector3, Quaternion)

Transforms a Vector3 by a specified Quaternion rotation.

##### Declaration

```
public static Vector3 Transform(Vector3 value, Quaternion rotation)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

The Vector3 to rotate.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

The Quaternion rotation to apply.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Transform(ref Vector3, ref Matrix, out Vector3)

Transforms a Vector3 by the given Matrix.

##### Declaration

```
public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

The source Vector3.

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

matrix

The transformation Matrix.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The transformed vector.
