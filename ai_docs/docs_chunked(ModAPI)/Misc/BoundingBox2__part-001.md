---
title: "Class BoundingBox2"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingBox2"
---

# Class BoundingBox2 | Space Engineers ModAPI

Defines an axis-aligned box-shaped 3D volume.

##### Inheritance

System.Object

BoundingBox2

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class BoundingBox2 : ValueType, IEquatable<BoundingBox2>
```

### Constructors

#### BoundingBox2(Vector2, Vector2)

Creates an instance of BoundingBox2.

##### Declaration

```
public BoundingBox2(Vector2 min, Vector2 max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | min | The minimum point the BoundingBox2 includes. |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | max | The maximum point the BoundingBox2 includes. |

### Fields

#### Max

The maximum point the BoundingBox2 contains.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### Min

The minimum point the BoundingBox2 contains.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

### Properties

#### Center

Calculates center

##### Declaration

```
public Vector2 Center { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### Extents

##### Declaration

```
public Vector2 Extents { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### HalfExtents

##### Declaration

```
public Vector2 HalfExtents { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

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
public Vector2 Size { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

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

#### Contains(BoundingBox2)

Tests whether the BoundingBox2 contains another BoundingBox2.

##### Declaration

```
public ContainmentType Contains(BoundingBox2 box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | box | The BoundingBox2 to test for overlap. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingBox2, out ContainmentType)

Tests whether the BoundingBox2 contains a BoundingBox2.

##### Declaration

```
public void Contains(ref BoundingBox2 box, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | box | The BoundingBox2 to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(Vector2)

Tests whether the BoundingBox2 contains a point.

##### Declaration

```
public ContainmentType Contains(Vector2 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | point | The point to test for overlap. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref Vector2, out ContainmentType)

Tests whether the BoundingBox2 contains a point.

##### Declaration

```
public void Contains(ref Vector2 point, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | point | The point to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### CreateFromHalfExtent(Vector2, Single)

##### Declaration

```
public static BoundingBox2 CreateFromHalfExtent(Vector2 center, float halfExtent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | center |     |
| System.Single | halfExtent |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### CreateFromHalfExtent(Vector2, Vector2)

##### Declaration

```
public static BoundingBox2 CreateFromHalfExtent(Vector2 center, Vector2 halfExtent)
```
