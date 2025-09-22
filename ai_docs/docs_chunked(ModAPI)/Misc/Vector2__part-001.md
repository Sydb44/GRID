---
title: "Class Vector2"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector2"
---

# Class Vector2 | Space Engineers ModAPI

Defines a vector with two components.

##### Inheritance

System.Object

Vector2

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector2 : ValueType, IEquatable<Vector2>
```

### Constructors

#### Vector2(Single)

Creates a new instance of Vector2.

##### Declaration

```
public Vector2(float value)
```

##### Parameters

Type

Name

Description

System.Single

value

Value to initialize both components to.

#### Vector2(Single, Single)

Initializes a new instance of Vector2.

##### Declaration

```
public Vector2(float x, float y)
```

##### Parameters

Type

Name

Description

System.Single

x

Initial value for the x-component of the vector.

System.Single

y

Initial value for the y-component of the vector.

### Fields

#### One

##### Declaration

```
public static Vector2 One
```

##### Field Value

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### PositiveInfinity

##### Declaration

```
public static Vector2 PositiveInfinity
```

##### Field Value

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### UnitX

##### Declaration

```
public static Vector2 UnitX
```

##### Field Value

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### UnitY

##### Declaration

```
public static Vector2 UnitY
```

##### Field Value

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

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

#### Zero

##### Declaration

```
public static Vector2 Zero
```

##### Field Value

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

### Properties

#### Item\[Int32\]

##### Declaration

```
public float this[int index] { get; set; }
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

System.Single

### Methods

#### Add(Vector2, Vector2)

Adds two vectors.

##### Declaration

```
public static Vector2 Add(Vector2 value1, Vector2 value2)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source vector.

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Add(ref Vector2, ref Vector2, out Vector2)

Adds two vectors.

##### Declaration

```
public static void Add(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

Source vector.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] Sum of the source vectors.

#### AssertIsValid()

##### Declaration

```
public void AssertIsValid()
```

#### Barycentric(Vector2, Vector2, Vector2, Single, Single)

Returns a Vector2 containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

##### Declaration

```
public static Vector2 Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

A Vector2 containing the 2D Cartesian coordinates of vertex 1 of the triangle.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

A Vector2 containing the 2D Cartesian coordinates of vertex 2 of the triangle.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value3

A Vector2 containing the 2D Cartesian coordinates of vertex 3 of the triangle.

System.Single

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Single

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### Barycentric(ref Vector2, ref Vector2, ref Vector2, Single, Single, out Vector2)

Returns a Vector2 containing the 2D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 2D triangle.

##### Declaration

```
public static void Barycentric(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, float amount1, float amount2, out Vector2 result)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value1

A Vector2 containing the 2D Cartesian coordinates of vertex 1 of the triangle.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value2

A Vector2 containing the 2D Cartesian coordinates of vertex 2 of the triangle.

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value3

A Vector2 containing the 2D Cartesian coordinates of vertex 3 of the triangle.

System.Single

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Single

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

result

\[OutAttribute\] The 2D Cartesian coordinates of the specified point are placed in this Vector2 on exit.
