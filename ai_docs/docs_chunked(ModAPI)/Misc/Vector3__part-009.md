value

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] Vector pointing in the opposite direction.

#### Normalize()

Turns the current vector into a unit vector. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

##### Returns

Type

Description

System.Single

#### Normalize(Vector3)

Creates a unit vector from the specified vector. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public static Vector3 Normalize(Vector3 value)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

The source Vector3.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Normalize(ref Vector3, out Vector3)

Creates a unit vector from the specified vector, writing the result to a user-specified variable. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public static void Normalize(ref Vector3 value, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The normalized vector.

#### Normalize(Vector3D)

##### Declaration

```
public static Vector3 Normalize(Vector3D value)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Normalized()

Creates a unit vector from the specified vector. The result is a vector one unit in length pointing in the same direction as the original vector.

##### Declaration

```
public Vector3 Normalized()
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

Normalized vector

#### ProjectOnPlane(ref Vector3, ref Vector3)

Projects given vector on plane specified by it's normal.

##### Declaration

```
public static Vector3 ProjectOnPlane(ref Vector3 vec, ref Vector3 planeNormal)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vec

Vector which is to be projected

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

planeNormal

Plane normal (may or may not be normalized)

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

Vector projected on plane

#### ProjectOnVector(ref Vector3, ref Vector3)

Projects vector on another vector resulting in new vector in guided vector's direction with different length.

##### Declaration

```
public static Vector3 ProjectOnVector(ref Vector3 vec, ref Vector3 guideVector)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vec

Vector which is to be projected

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

guideVector

Guide vector (may or may not be normalized)

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

Vector projected on guide vector

#### RectangularDistance(Vector3, Vector3)

Calculates rectangular distance (a.k.a. Manhattan distance or Chessboard distace) between two vectors.

##### Declaration

```
public static float RectangularDistance(Vector3 value1, Vector3 value2)
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

System.Single

#### RectangularDistance(ref Vector3, ref Vector3)

Calculates rectangular distance (a.k.a. Manhattan distance or Chessboard distace) between two vectors.

##### Declaration

```
public static float RectangularDistance(ref Vector3 value1, ref Vector3 value2)
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

System.Single

#### Reflect(Vector3, Vector3)

Returns the reflection of a vector off a surface that has the specified normal. Reference page contains code sample.

##### Declaration

```
public static Vector3 Reflect(Vector3 vector, Vector3 normal)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

normal

Normal of the surface.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Reflect(ref Vector3, ref Vector3, out Vector3)

Returns the reflection of a vector off a surface that has the specified normal. Reference page contains code sample.

##### Declaration

```
public static void Reflect(ref Vector3 vector, ref Vector3 normal, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector

Source vector.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

normal

Normal of the surface.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The reflected vector.
