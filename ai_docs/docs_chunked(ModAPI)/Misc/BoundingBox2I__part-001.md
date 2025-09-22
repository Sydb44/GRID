---
title: "Class BoundingBox2I"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingBox2I"
---

# Class BoundingBox2I | Space Engineers ModAPI

Defines an axis-aligned box-shaped 3D volume.

##### Inheritance

System.Object

BoundingBox2I

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class BoundingBox2I : ValueType, IEquatable<BoundingBox2I>
```

### Constructors

#### BoundingBox2I(Vector2I, Vector2I)

Creates an instance of BoundingBox2I.

##### Declaration

```
public BoundingBox2I(Vector2I min, Vector2I max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | min | The minimum point the BoundingBox2I includes. |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | max | The maximum point the BoundingBox2I includes. |

### Fields

#### Max

The maximum point the BoundingBox2I contains.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### Min

The minimum point the BoundingBox2I contains.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

### Properties

#### Center

Calculates center

##### Declaration

```
public Vector2I Center { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### Extents

##### Declaration

```
public Vector2I Extents { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### HalfExtents

##### Declaration

```
public Vector2I HalfExtents { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### Height

##### Declaration

```
public float Height { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Size

Size

##### Declaration

```
public Vector2I Size { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) |     |

#### Width

##### Declaration

```
public float Width { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Area()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Contains(BoundingBox2I)

Tests whether the BoundingBox2I contains another BoundingBox2I.

##### Declaration

```
public ContainmentType Contains(BoundingBox2I box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | box | The BoundingBox2I to test for overlap. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingBox2I, out ContainmentType)

Tests whether the BoundingBox2I contains a BoundingBox2I.

##### Declaration

```
public void Contains(ref BoundingBox2I box, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | box | The BoundingBox2I to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(Vector2I)

Tests whether the BoundingBox2I contains a point.

##### Declaration

```
public ContainmentType Contains(Vector2I point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | point | The point to test for overlap. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref Vector2I, out ContainmentType)

Tests whether the BoundingBox2I contains a point.

##### Declaration

```
public void Contains(ref Vector2I point, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | point | The point to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### CreateFromHalfExtent(Vector2I, Int32)

##### Declaration

```
public static BoundingBox2I CreateFromHalfExtent(Vector2I center, int halfExtent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | center |     |
| System.Int32 | halfExtent |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### CreateFromHalfExtent(Vector2I, Vector2I)
