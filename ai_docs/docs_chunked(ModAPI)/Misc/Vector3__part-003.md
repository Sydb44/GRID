Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Barycentric(Vector3, Vector3, Vector3, Vector3, out Single, out Single, out Single)

Compute barycentric coordinates (u, v, w) for point p with respect to triangle (a, b, c) From : Real-Time Collision Detection, Christer Ericson, CRC Press 3.4 Barycentric Coordinates

##### Declaration

```
public static void Barycentric(Vector3 p, Vector3 a, Vector3 b, Vector3 c, out float u, out float v, out float w)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

p

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

a

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

b

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

c

System.Single

u

System.Single

v

System.Single

w

#### Barycentric(ref Vector3, ref Vector3, ref Vector3, Single, Single, out Vector3)

Returns a Vector3 containing the 3D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 3D triangle.

##### Declaration

```
public static void Barycentric(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, float amount1, float amount2, out Vector3 result)
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

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] The 3D Cartesian coordinates of the specified point are placed in this Vector3 on exit.

#### CalculatePerpendicularVector(Vector3)

##### Declaration

```
public static Vector3 CalculatePerpendicularVector(Vector3 v)
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

#### CalculatePerpendicularVector(out Vector3)

##### Declaration

```
public void CalculatePerpendicularVector(out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

#### CatmullRom(Vector3, Vector3, Vector3, Vector3, Single)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static Vector3 CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, float amount)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

The first position in the interpolation.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

The second position in the interpolation.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value3

The third position in the interpolation.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value4

The fourth position in the interpolation.

System.Single

amount

Weighting factor.

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### CatmullRom(ref Vector3, ref Vector3, ref Vector3, ref Vector3, Single, out Vector3)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static void CatmullRom(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, ref Vector3 value4, float amount, out Vector3 result)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value1

The first position in the interpolation.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value2

The second position in the interpolation.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value3

The third position in the interpolation.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value4

The fourth position in the interpolation.

System.Single

amount

Weighting factor.

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

result

\[OutAttribute\] A vector that is the result of the Catmull-Rom interpolation.

#### Ceiling(Vector3)

##### Declaration

```
public static Vector3 Ceiling(Vector3 v)
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

#### Clamp(Vector3, Vector3, Vector3)

Restricts a value to be within a specified range.

##### Declaration

```
public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max)
```
