---
title: "Class Vector3B"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3B"
---

# Class Vector3B | Space Engineers ModAPI

##### Inheritance

System.Object

Vector3B

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector3B : ValueType
```

### Constructors

#### Vector3B(SByte, SByte, SByte)

##### Declaration

```
public Vector3B(sbyte x, sbyte y, sbyte z)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.SByte | x   |     |
| System.SByte | y   |     |
| System.SByte | z   |     |

#### Vector3B(Vector3I)

##### Declaration

```
public Vector3B(Vector3I vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vec |     |

### Fields

#### Backward

##### Declaration

```
public static Vector3B Backward
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) |     |

#### Down

##### Declaration

```
public static Vector3B Down
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) |     |

#### Forward

##### Declaration

```
public static Vector3B Forward
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) |     |

#### Left

##### Declaration

```
public static Vector3B Left
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) |     |

#### Right

##### Declaration

```
public static Vector3B Right
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) |     |

#### Up

##### Declaration

```
public static Vector3B Up
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) |     |

#### X

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.SByte |     |

#### Y

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.SByte |     |

#### Z

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.SByte |     |

#### Zero

##### Declaration

```
public static readonly Vector3B Zero
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) |     |

### Methods

#### Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Fit(Vector3, Single)

Puts Vector3 into Vector3B, value -127 represents -range, 128 represents range

##### Declaration

```
public static Vector3B Fit(Vector3 vec, float range)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |
| System.Single | range |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Round(Vector3)

##### Declaration

```
public static Vector3B Round(Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Equality(Vector3B, Vector3B)

##### Declaration

```
public static bool operator ==(Vector3B a, Vector3B b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) | a   |     |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Implicit(Vector3B to Vector3I)

##### Declaration

```
public static implicit operator Vector3I(Vector3B vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Inequality(Vector3B, Vector3B)

##### Declaration

```
public static bool operator !=(Vector3B a, Vector3B b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) | a   |     |
| [Vector3B](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3B.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
