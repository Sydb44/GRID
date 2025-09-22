##### Declaration

```
public static Vector3D UnitY
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### UnitZ

##### Declaration

```
public static Vector3D UnitZ
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Up

##### Declaration

```
public static Vector3D Up
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### X

Gets or sets the x-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Double

#### Y

Gets or sets the y-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Double

#### Z

Gets or sets the z-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Double

#### Zero

##### Declaration

```
public static Vector3D Zero
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

### Properties

#### Sum

##### Declaration

```
public double Sum { get; }
```

##### Property Value

Type

Description

System.Double

#### Volume

##### Declaration

```
public double Volume { get; }
```

##### Property Value

Type

Description

System.Double

### Methods

#### Abs(Vector3D)

##### Declaration

```
public static Vector3D Abs(Vector3D value)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Abs(ref Vector3D, out Vector3D)

##### Declaration

```
public static void Abs(ref Vector3D vector3D, out Vector3D abs)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

vector3D

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

abs

#### AbsMax()

Returns the component of the vector, whose absolute value is largest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Double

#### AbsMaxComponent()

##### Declaration

```
public int AbsMaxComponent()
```

##### Returns

Type

Description

System.Int32

#### AbsMin()

Returns the component of the vector, whose absolute value is smallest of all the three components.

##### Declaration

##### Returns

Type

Description

System.Double

#### Add(Vector3D, Vector3D)

Adds two vectors.

##### Declaration

```
public static Vector3D Add(Vector3D value1, Vector3D value2)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Add(ref Vector3D, ref Vector3D, out Vector3D)

Adds two vectors.

##### Declaration

```
public static void Add(ref Vector3D value1, ref Vector3D value2, out Vector3D result)
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

\[OutAttribute\] Sum of the source vectors.

#### Angle(Vector3D, Vector3D)

Gets angle between 2 vectors in radians

##### Declaration

```
public static double Angle(Vector3D a, Vector3D b)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

a

Vector A

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

b

Vector B

##### Returns

Type

Description

System.Double

Angle in radians

#### ArePerpendicular(ref Vector3D, ref Vector3D)

##### Declaration

```
public static bool ArePerpendicular(ref Vector3D a, ref Vector3D b)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

a

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

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

#### Barycentric(Vector3D, Vector3D, Vector3D, Double, Double)

Returns a Vector3 containing the 3D Cartesian coordinates of a point specified in Barycentric coordinates relative to a 3D triangle.

##### Declaration

```
public static Vector3D Barycentric(Vector3D value1, Vector3D value2, Vector3D value3, double amount1, double amount2)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

A Vector3 containing the 3D Cartesian coordinates of vertex 1 of the triangle.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

A Vector3 containing the 3D Cartesian coordinates of vertex 2 of the triangle.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value3

A Vector3 containing the 3D Cartesian coordinates of vertex 3 of the triangle.

System.Double

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Double

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).
