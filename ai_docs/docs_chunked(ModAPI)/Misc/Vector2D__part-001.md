---
title: "Class Vector2D"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector2D"
---

# Class Vector2D | Space Engineers ModAPI

Defines a vector with two components.

##### Inheritance

System.Object

Vector2D

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector2D : ValueType, IEquatable<Vector2D>
```

### Constructors

#### Vector2D(Double)

Creates a new instance of Vector2D.

##### Declaration

```
public Vector2D(double value)
```

##### Parameters

Type

Name

Description

System.Double

value

Value to initialize both components to.

#### Vector2D(Double, Double)

Initializes a new instance of Vector2D.

##### Declaration

```
public Vector2D(double x, double y)
```

##### Parameters

Type

Name

Description

System.Double

x

Initial value for the x-component of the vector.

System.Double

y

Initial value for the y-component of the vector.

### Fields

#### One

##### Declaration

```
public static Vector2D One
```

##### Field Value

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### PositiveInfinity

##### Declaration

```
public static Vector2D PositiveInfinity
```

##### Field Value

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### UnitX

##### Declaration

```
public static Vector2D UnitX
```

##### Field Value

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### UnitY

##### Declaration

```
public static Vector2D UnitY
```

##### Field Value

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

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

#### Zero

##### Declaration

```
public static Vector2D Zero
```

##### Field Value

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

### Properties

#### Item\[Int32\]

##### Declaration

```
public double this[int index] { get; set; }
```

##### Parameters

Type

Name

Description

System.Int32

index

##### Property Value

Type

Description

System.Double

### Methods

#### Add(Vector2D, Vector2D)

Adds two vectors.

##### Declaration

```
public static Vector2D Add(Vector2D value1, Vector2D value2)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source vector.

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Add(ref Vector2D, ref Vector2D, out Vector2D)

Adds two vectors.

##### Declaration

```
public static void Add(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

Source vector.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] Sum of the source vectors.

#### AssertIsValid()

##### Declaration

```
public void AssertIsValid()
```

#### Barycentric(Vector2D, Vector2D, Vector2D, Double, Double)

Returns a Vector2D containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

##### Declaration

```
public static Vector2D Barycentric(Vector2D value1, Vector2D value2, Vector2D value3, double amount1, double amount2)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

A Vector2D containing the 2D Cartesian coordinates of vertex 1 of the triangle.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

A Vector2D containing the 2D Cartesian coordinates of vertex 2 of the triangle.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value3

A Vector2D containing the 2D Cartesian coordinates of vertex 3 of the triangle.

System.Double

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Double

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

##### Returns

Type

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

#### Barycentric(ref Vector2D, ref Vector2D, ref Vector2D, Double, Double, out Vector2D)

Returns a Vector2D containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

##### Declaration

```
public static void Barycentric(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, double amount1, double amount2, out Vector2D result)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value1

A Vector2D containing the 2D Cartesian coordinates of vertex 1 of the triangle.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value2

A Vector2D containing the 2D Cartesian coordinates of vertex 2 of the triangle.

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value3

A Vector2D containing the 2D Cartesian coordinates of vertex 3 of the triangle.

System.Double

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Double

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

result

\[OutAttribute\] The 2D Cartesian coordinates of the specified point are placed in this Vector2D on exit.
