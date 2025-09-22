---
title: "Class Vector3S"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3S"
---

# Class Vector3S | Space Engineers ModAPI

##### Inheritance

System.Object

Vector3S

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector3S : ValueType
```

### Constructors

#### Vector3S(Int16, Int16, Int16)

##### Declaration

```
public Vector3S(short x, short y, short z)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int16 | x   |     |
| System.Int16 | y   |     |
| System.Int16 | z   |     |

#### Vector3S(Single, Single, Single)

##### Declaration

```
public Vector3S(float x, float y, float z)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | x   |     |
| System.Single | y   |     |
| System.Single | z   |     |

#### Vector3S(Vector3I)

##### Declaration

```
public Vector3S(Vector3I vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vec |     |

#### Vector3S(ref Vector3I)

##### Declaration

```
public Vector3S(ref Vector3I vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vec |     |

### Fields

#### Backward

##### Declaration

```
public static Vector3S Backward
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) |     |

#### Down

##### Declaration

```
public static Vector3S Down
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) |     |

#### Forward

##### Declaration

```
public static Vector3S Forward
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) |     |

#### Left

##### Declaration

```
public static Vector3S Left
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) |     |

#### Right

##### Declaration

```
public static Vector3S Right
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) |     |

#### Up

##### Declaration

```
public static Vector3S Up
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) |     |

#### X

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int16 |     |

#### Y

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int16 |     |

#### Z

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int16 |     |

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
public static Vector3S Round(Vector3 v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) |     |

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

#### Equality(Vector3S, Vector3S)

##### Declaration

```
public static bool operator ==(Vector3S v1, Vector3S v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) | v1  |     |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) | v2  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Implicit(Vector3S to Vector3I)

##### Declaration

```
public static implicit operator Vector3I(Vector3S me)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) | me  |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Inequality(Vector3S, Vector3S)

##### Declaration

```
public static bool operator !=(Vector3S v1, Vector3S v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) | v1  |     |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) | v2  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Multiply(Vector3, Vector3S)

##### Declaration

```
public static Vector3 operator *(Vector3 vector, Vector3S shortVector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vector |     |
| [Vector3S](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3S.html) | shortVector |     |
