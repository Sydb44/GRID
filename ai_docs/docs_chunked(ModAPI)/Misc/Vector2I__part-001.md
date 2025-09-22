---
title: "Class Vector2I"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector2I"
---

# Class Vector2I | Space Engineers ModAPI

##### Inheritance

System.Object

Vector2I

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector2I : ValueType
```

### Constructors

#### Vector2I(Int32)

##### Declaration

```
public Vector2I(int width)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | width |     |

#### Vector2I(Int32, Int32)

##### Declaration

```
public Vector2I(int x, int y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   |     |
| System.Int32 | y   |     |

#### Vector2I(Vector2)

##### Declaration

```
public Vector2I(Vector2 vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | vec |     |

#### Vector2I(Vector2D)

##### Declaration

```
public Vector2I(Vector2D vec)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html) | vec |     |

### Fields

#### Comparer

##### Declaration

```
public static readonly Vector2I.ComparerClass Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2I.ComparerClass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.ComparerClass.html) |     |

#### One

##### Declaration

```
public static Vector2I One
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### UnitX

##### Declaration

```
public static Vector2I UnitX
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### UnitY

##### Declaration

```
public static Vector2I UnitY
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### X

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Y

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Zero

##### Declaration

```
public static Vector2I Zero
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

### Methods

#### Between(ref Vector2I, ref Vector2I)

##### Declaration

```
public bool Between(ref Vector2I start, ref Vector2I end)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | start |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | end |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### Floor(Vector2)

##### Declaration

```
public static Vector2I Floor(Vector2 value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | value |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Max(Vector2I, Vector2I)

##### Declaration

```
public static Vector2I Max(Vector2I v1, Vector2I v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | v1  |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | v2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### Max(ref Vector2I, ref Vector2I, out Vector2I)

##### Declaration

```
public static void Max(ref Vector2I v1, ref Vector2I v2, out Vector2I max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | v1  |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | v2  |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | max |     |

#### Min(Vector2I, Vector2I)

##### Declaration

```
public static Vector2I Min(Vector2I v1, Vector2I v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | v1  |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | v2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### Min(ref Vector2I, ref Vector2I, out Vector2I)

##### Declaration

```
public static void Min(ref Vector2I v1, ref Vector2I v2, out Vector2I min)
```
