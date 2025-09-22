---
title: "Class Vector3D"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3D"
---

# Class Vector3D | Space Engineers ModAPI

Defines a vector with three components. Vector3 with double floating point precision

##### Inheritance

System.Object

Vector3D

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector3D : ValueType, IEquatable<Vector3D>
```

### Constructors

#### Vector3D(Double)

Creates a new instance of Vector3.

##### Declaration

```
public Vector3D(double value)
```

##### Parameters

Type

Name

Description

System.Double

value

Value to initialize each component to.

#### Vector3D(Double, Double, Double)

Initializes a new instance of Vector3.

##### Declaration

```
public Vector3D(double x, double y, double z)
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

System.Double

z

Initial value for the z-component of the vector.

#### Vector3D(Vector2, Double)

Initializes a new instance of Vector3.

##### Declaration

```
public Vector3D(Vector2 value, double z)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

A vector containing the values to initialize x and y components with.

System.Double

z

Initial value for the z-component of the vector.

#### Vector3D(Vector2D, Double)

##### Declaration

```
public Vector3D(Vector2D value, double z)
```

##### Parameters

Type

Name

Description

[Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html)

value

System.Double

z

#### Vector3D(Vector3)

##### Declaration

```
public Vector3D(Vector3 value)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

#### Vector3D(Vector3D)

##### Declaration

```
public Vector3D(Vector3D value)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

#### Vector3D(Vector3I)

##### Declaration

```
public Vector3D(Vector3I value)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

#### Vector3D(ref Vector3I)

##### Declaration

```
public Vector3D(ref Vector3I value)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

#### Vector3D(Vector4)

##### Declaration

```
public Vector3D(Vector4 xyz)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

xyz

#### Vector3D(Vector4D)

##### Declaration

```
public Vector3D(Vector4D xyz)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

xyz

### Fields

#### Backward

##### Declaration

```
public static Vector3D Backward
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Down

##### Declaration

```
public static Vector3D Down
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Forward

##### Declaration

```
public static Vector3D Forward
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Half

##### Declaration

```
public static Vector3D Half
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Left

##### Declaration

```
public static Vector3D Left
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### MaxValue

##### Declaration

```
public static Vector3D MaxValue
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### MinValue

##### Declaration

```
public static Vector3D MinValue
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### NegativeInfinity

##### Declaration

```
public static Vector3D NegativeInfinity
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### One

##### Declaration

```
public static Vector3D One
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### PositiveInfinity

##### Declaration

```
public static Vector3D PositiveInfinity
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### Right

##### Declaration

```
public static Vector3D Right
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### UnitX

##### Declaration

```
public static Vector3D UnitX
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### UnitY

##### Declaration

```
public static Vector3D UnitY
```

##### Field Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)
