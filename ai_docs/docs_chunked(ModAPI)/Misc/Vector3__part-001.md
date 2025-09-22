---
title: "Class Vector3"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3"
---

# Class Vector3 | Space Engineers ModAPI

Defines a vector with three components.

##### Inheritance

System.Object

Vector3

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector3 : ValueType, IEquatable<Vector3>
```

### Constructors

#### Vector3(Double, Double, Double)

##### Declaration

```
public Vector3(double x, double y, double z)
```

##### Parameters

Type

Name

Description

System.Double

x

System.Double

y

System.Double

z

#### Vector3(Single)

Creates a new instance of Vector3.

##### Declaration

```
public Vector3(float value)
```

##### Parameters

Type

Name

Description

System.Single

value

Value to initialize each component to.

#### Vector3(Single, Single, Single)

Initializes a new instance of Vector3.

##### Declaration

```
public Vector3(float x, float y, float z)
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

System.Single

z

Initial value for the z-component of the vector.

#### Vector3(Vector2, Single)

Initializes a new instance of Vector3.

##### Declaration

```
public Vector3(Vector2 value, float z)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

A vector containing the values to initialize x and y components with.

System.Single

z

Initial value for the z-component of the vector.

#### Vector3(Vector3I)

##### Declaration

```
public Vector3(Vector3I value)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

#### Vector3(ref Vector3I)

##### Declaration

```
public Vector3(ref Vector3I value)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

value

#### Vector3(Vector4)

##### Declaration

```
public Vector3(Vector4 xyz)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

xyz

### Fields

#### Backward

##### Declaration

```
public static Vector3 Backward
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Down

##### Declaration

```
public static Vector3 Down
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Forward

##### Declaration

```
public static Vector3 Forward
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Half

##### Declaration

```
public static Vector3 Half
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Invalid

##### Declaration

```
public static Vector3 Invalid
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Left

##### Declaration

```
public static Vector3 Left
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### MaxValue

##### Declaration

```
public static Vector3 MaxValue
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### MinusOne

##### Declaration

```
public static Vector3 MinusOne
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### MinValue

##### Declaration

```
public static Vector3 MinValue
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### NegativeInfinity

##### Declaration

```
public static Vector3 NegativeInfinity
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### One

##### Declaration

```
public static Vector3 One
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### PositiveInfinity

##### Declaration

```
public static Vector3 PositiveInfinity
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Right

##### Declaration

```
public static Vector3 Right
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### UnitX

##### Declaration

```
public static Vector3 UnitX
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### UnitY

##### Declaration

```
public static Vector3 UnitY
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### UnitZ

##### Declaration

```
public static Vector3 UnitZ
```

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### Up

##### Declaration

##### Field Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### X

Gets or sets the x-component of the vector.
