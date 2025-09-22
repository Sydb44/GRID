---
title: "Class Vector3UByte"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3UByte"
---

# Class Vector3UByte | Space Engineers ModAPI

##### Inheritance

System.Object

Vector3UByte

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector3UByte : ValueType
```

### Constructors

#### Vector3UByte(Byte, Byte, Byte)

##### Declaration

```
public Vector3UByte(byte x, byte y, byte z)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | x   |     |
| System.Byte | y   |     |
| System.Byte | z   |     |

#### Vector3UByte(Vector3I)

##### Declaration

```
public Vector3UByte(Vector3I vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vec |     |

### Fields

#### Comparer

##### Declaration

```
public static readonly Vector3UByte.EqualityComparer Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3UByte.EqualityComparer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.EqualityComparer.html) |     |

#### X

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Y

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Z

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Zero

##### Declaration

```
public static Vector3UByte Zero
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html) |     |

### Methods

#### Denormalize(Vector3UByte, Single)

Unpacks Vector3 from Vector3UByte, scales vector from (0, 255) to (-range, range)

##### Declaration

```
public static Vector3 Denormalize(Vector3UByte vec, float range)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html) | vec |     |
| System.Single | range |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

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

#### Floor(Vector3)

##### Declaration

```
public static Vector3UByte Floor(Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html) |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsMiddle(Vector3UByte)

Returns true when all components are 127

##### Declaration

```
public static bool IsMiddle(Vector3UByte vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LengthSquared()

##### Declaration

```
public int LengthSquared()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Normalize(Vector3, Single)

Normalizes Vector3 into Vector4UByte, scales vector from (-range, range) to (0, 255). Unsafe for values "range >= any\_vec\_value / 257";

##### Declaration

```
public static Vector3UByte Normalize(Vector3 vec, float range)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |
| System.Single | range |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html) |     |

#### Round(Vector3)

##### Declaration

```
public static Vector3UByte Round(Vector3 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html) |     |

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

#### Equality(Vector3UByte, Vector3UByte)

##### Declaration

```
public static bool operator ==(Vector3UByte a, Vector3UByte b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html) | a   |     |
| [Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html) | b   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Implicit(Vector3UByte to Vector3I)

##### Declaration

```
public static implicit operator Vector3I(Vector3UByte vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html) | vec |     |
