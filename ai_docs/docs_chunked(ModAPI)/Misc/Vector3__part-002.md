##### Declaration

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### X

Gets or sets the x-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Single

#### Y

Gets or sets the y-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Single

#### Z

Gets or sets the z-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Single

#### Zero

##### Declaration

```
public static Vector3 Zero
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

### Properties

#### Sum

##### Declaration

```
public float Sum { get; }
```

##### Property Value

Type

Description

System.Single

#### Volume

##### Declaration

```
public float Volume { get; }
```

##### Property Value

Type

Description

System.Single

### Methods

#### Abs(Vector3)

##### Declaration

```
public static Vector3 Abs(Vector3 value)
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

#### AbsMax()

Returns the component of the vector, whose absolute value is largest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Single

#### AbsMin()

Returns the component of the vector, whose absolute value is smallest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Single

#### Add(Vector3)

##### Declaration

```
public void Add(Vector3 other)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

other

#### Add(Vector3, Vector3)

Adds two vectors.

##### Declaration

```
public static Vector3 Add(Vector3 value1, Vector3 value2)
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

#### Add(ref Vector3, ref Vector3, out Vector3)

Adds two vectors.

##### Declaration

```
public static void Add(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
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

\[OutAttribute\] Sum of the source vectors.

#### Angle(Vector3, Vector3)

Gets angle between 2 vectors in radians

##### Declaration

```
public static double Angle(Vector3 a, Vector3 b)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

a

Vector A

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

b

Vector B

##### Returns

Type

Description

System.Double

Angle in radians

#### ArePerpendicular(Vector3, Vector3)

##### Declaration

```
public static bool ArePerpendicular(Vector3 a, Vector3 b)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

a

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

b

##### Returns

Type

Description

System.Boolean

#### ArePerpendicular(in Vector3, in Vector3)

##### Declaration

```
public static bool ArePerpendicular(in Vector3 a, in Vector3 b)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

a

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

b

##### Returns

Type

Description

System.Boolean

#### AssertIsValid()

##### Declaration

```
public void AssertIsValid()
```

#### Barycentric(Vector3, Vector3, Vector3, Single, Single)

Returns a Vector3 containing the 3D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 3D triangle.

##### Declaration

```
public static Vector3 Barycentric(Vector3 value1, Vector3 value2, Vector3 value3, float amount1, float amount2)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

A Vector3 containing the 3D Cartesian coordinates of vertex 1 of the triangle.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

A Vector3 containing the 3D Cartesian coordinates of vertex 2 of the triangle.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value3

A Vector3 containing the 3D Cartesian coordinates of vertex 3 of the triangle.

System.Single

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Single

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Barycentric(Vector3, Vector3, Vector3, Vector3, out Single, out Single, out Single)

Compute barycentric coordinates (u, v, w) for point p with respect to triangle (a, b, c) From : Real-Time Collision Detection, Christer Ericson, CRC Press 3.4 Barycentric Coordinates
