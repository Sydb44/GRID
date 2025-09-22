Source vector.

System.Double

scaleFactor

Scalar value.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The result of the multiplication.

#### Multiply(ref Vector3D, ref Vector3D, out Vector3D)

Multiplies the components of two vectors by each other.

##### Declaration

```
public static void Multiply(ref Vector3D value1, ref Vector3D value2, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The result of the multiplication.

#### Negate(Vector3D)

Returns a vector pointing in the opposite direction.

##### Declaration

```
public static Vector3D Negate(Vector3D value)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

Source vector.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Negate(ref Vector3D, out Vector3D)

Returns a vector pointing in the opposite direction.

##### Declaration

```
public static void Negate(ref Vector3D value, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] Vector pointing in the opposite direction.

#### Normalize()

Turns the current vector into a unit vector. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public double Normalize()
```

##### Returns

Type

Description

System.Double

#### Normalize(Vector3D)

Creates a unit vector from the specified vector. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public static Vector3D Normalize(Vector3D value)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

The source Vector3.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Normalize(ref Vector3D, out Vector3D)

Creates a unit vector from the specified vector, writing the result to a user-specified variable. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public static void Normalize(ref Vector3D value, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The normalized vector.

#### Normalized()

Creates a unit vector from the specified vector. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public Vector3D Normalized()
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

Normalized vector

#### ProjectOnPlane(ref Vector3D, ref Vector3D)

Projects given vector on plane specified by it's normal.

##### Declaration

```
public static Vector3D ProjectOnPlane(ref Vector3D vec, ref Vector3D planeNormal)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vec

Vector which is to be projected

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

planeNormal

Plane normal (may or may not be normalized)

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

Vector projected on plane

#### ProjectOnVector(ref Vector3D, ref Vector3D)

Projects vector on another vector resulting in new vector in guided vector's direction with different length.

##### Declaration

```
public static Vector3D ProjectOnVector(ref Vector3D vec, ref Vector3D guideVector)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vec

Vector which is to be projected

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

guideVector

Guide vector (may or may not be normalized)

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

Vector projected on guide vector

#### RectangularDistance(Vector3D, Vector3D)

Calculates rectangular distance (a.k.a. Manhattan distance or Chessboard distace) between two vectors.

##### Declaration

```
public static double RectangularDistance(Vector3D value1, Vector3D value2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

Source vector.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

Source vector.

##### Returns

Type

Description

System.Double

#### RectangularDistance(ref Vector3D, ref Vector3D)

Calculates rectangular distance (a.k.a. Manhattan distance or Chessboard distace) between two vectors.

##### Declaration

```
public static double RectangularDistance(ref Vector3D value1, ref Vector3D value2)
```
