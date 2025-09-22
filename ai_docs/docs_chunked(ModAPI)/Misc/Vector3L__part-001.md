---
title: "Class Vector3L"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3L"
---

# Class Vector3L | Space Engineers ModAPI

##### Inheritance

System.Object

Vector3L

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector3L : ValueType, IEquatable<Vector3L>, IComparable<Vector3L>
```

### Constructors

#### Vector3L(Int64)

##### Declaration

```
public Vector3L(long xyz)
```

##### Parameters

Type

Name

Description

System.Int64

xyz

#### Vector3L(Int64, Int64, Int64)

##### Declaration

```
public Vector3L(long x, long y, long z)
```

##### Parameters

Type

Name

Description

System.Int64

x

System.Int64

y

System.Int64

z

#### Vector3L(Single, Single, Single)

##### Declaration

```
public Vector3L(float x, float y, float z)
```

##### Parameters

Type

Name

Description

System.Single

x

System.Single

y

System.Single

z

#### Vector3L(Vector3)

##### Declaration

```
public Vector3L(Vector3 xyz)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

xyz

#### Vector3L(Vector3D)

##### Declaration

```
public Vector3L(Vector3D xyz)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

xyz

#### Vector3L(Vector3S)

##### Declaration

```
public Vector3L(Vector3S xyz)
```

##### Parameters

Type

Name

Description

[Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html)

xyz

### Fields

#### Backward

##### Declaration

```
public static Vector3L Backward
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Comparer

##### Declaration

```
public static readonly Vector3L.EqualityComparer Comparer
```

##### Field Value

Type

Description

[Vector3L.EqualityComparer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.EqualityComparer.html)

#### Down

##### Declaration

```
public static Vector3L Down
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Forward

##### Declaration

```
public static Vector3L Forward
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Left

##### Declaration

```
public static Vector3L Left
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### MaxValue

##### Declaration

```
public static Vector3L MaxValue
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### MinValue

##### Declaration

```
public static Vector3L MinValue
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### One

##### Declaration

```
public static Vector3L One
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Right

##### Declaration

```
public static Vector3L Right
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### UnitX

##### Declaration

```
public static Vector3L UnitX
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### UnitY

##### Declaration

```
public static Vector3L UnitY
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### UnitZ

##### Declaration

```
public static Vector3L UnitZ
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Up

##### Declaration

```
public static Vector3L Up
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### X

##### Declaration

##### Field Value

Type

Description

System.Int64

#### Y

##### Declaration

##### Field Value

Type

Description

System.Int64

#### Z

##### Declaration

##### Field Value

Type

Description

System.Int64

#### Zero

##### Declaration

```
public static Vector3L Zero
```

##### Field Value

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

### Properties

#### Item\[Int64\]

##### Declaration

```
public long this[long index] { get; set; }
```

##### Parameters

Type

Name

Description

System.Int64

index

##### Property Value

Type

Description

System.Int64

#### Size

How many cubes are in block with this size

##### Declaration

```
public long Size { get; }
```

##### Property Value

Type

Description

System.Int64

#### SizeLong

##### Declaration

```
public long SizeLong { get; }
```

##### Property Value

Type

Description

System.Int64

### Methods

#### Abs(Vector3L)

##### Declaration

```
public static Vector3L Abs(Vector3L value)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value

##### Returns

Type

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

#### Abs(ref Vector3L, out Vector3L)

##### Declaration

```
public static void Abs(ref Vector3L value, out Vector3L result)
```

##### Parameters

Type

Name

Description

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

value

[Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html)

result
