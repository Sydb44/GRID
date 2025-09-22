A Vector3 containing the 3D Cartesian coordinates of vertex 3 of the triangle.

System.Double

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Double

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Barycentric(Vector3D, Vector3D, Vector3D, Vector3D, out Double, out Double, out Double)

Compute barycentric coordinates (u, v, w) for point p with respect to triangle (a, b, c) From : Real-Time Collision Detection, Christer Ericson, CRC Press 3.4 Barycentric Coordinates

##### Declaration

```
public static void Barycentric(Vector3D p, Vector3D a, Vector3D b, Vector3D c, out double u, out double v, out double w)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

a

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

b

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

c

System.Double

u

System.Double

v

System.Double

w

#### Barycentric(ref Vector3D, ref Vector3D, ref Vector3D, Double, Double, out Vector3D)

Returns a Vector3 containing the 3D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 3D triangle.

##### Declaration

```
public static void Barycentric(ref Vector3D value1, ref Vector3D value2, ref Vector3D value3, double amount1, double amount2, out Vector3D result)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] The 3D Cartesian coordinates of the specified point are placed in this Vector3 on exit.

#### CalculatePerpendicularVector(Vector3D)

##### Declaration

```
public static Vector3D CalculatePerpendicularVector(Vector3D v)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

v

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### CalculatePerpendicularVector(out Vector3D)

##### Declaration

```
public void CalculatePerpendicularVector(out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

#### CatmullRom(Vector3D, Vector3D, Vector3D, Vector3D, Double)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static Vector3D CatmullRom(Vector3D value1, Vector3D value2, Vector3D value3, Vector3D value4, double amount)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

The first position in the interpolation.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

The second position in the interpolation.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value3

The third position in the interpolation.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value4

The fourth position in the interpolation.

System.Double

amount

Weighting factor.

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### CatmullRom(ref Vector3D, ref Vector3D, ref Vector3D, ref Vector3D, Double, out Vector3D)

Performs a Catmull-Rom interpolation using the specified positions.

##### Declaration

```
public static void CatmullRom(ref Vector3D value1, ref Vector3D value2, ref Vector3D value3, ref Vector3D value4, double amount, out Vector3D result)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value1

The first position in the interpolation.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value2

The second position in the interpolation.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value3

The third position in the interpolation.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value4

The fourth position in the interpolation.

System.Double

amount

Weighting factor.

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

result

\[OutAttribute\] A vector that is the result of the Catmull-Rom interpolation.

#### Clamp(Vector3D, Vector3D, Vector3D)

Restricts a value to be within a specified range.

##### Declaration

```
public static Vector3D Clamp(Vector3D value1, Vector3D min, Vector3D max)
```
