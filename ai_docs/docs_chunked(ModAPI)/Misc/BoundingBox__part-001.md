---
title: "Class BoundingBox"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingBox"
---

# Class BoundingBox | Space Engineers ModAPI

Defines an axis-aligned box-shaped 3D volume.

##### Inheritance

System.Object

BoundingBox

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class BoundingBox : ValueType, IEquatable<BoundingBox>
```

### Constructors

#### BoundingBox(BoundingBoxD)

Creates an instance of BoundingBox from BoundingBoxD (helper for transformed BBs)

##### Declaration

```
public BoundingBox(BoundingBoxD bbd)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | bbd |     |

#### BoundingBox(BoundingBoxI)

Creates an instance of BoundingBox from BoundingBoxI

##### Declaration

```
public BoundingBox(BoundingBoxI bbd)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | bbd |     |

#### BoundingBox(Vector3, Vector3)

Creates an instance of BoundingBox.

##### Declaration

```
public BoundingBox(Vector3 min, Vector3 max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | min | The minimum point the BoundingBox includes. |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | max | The maximum point the BoundingBox includes. |

### Fields

#### Comparer

##### Declaration

```
public static readonly BoundingBox.ComparerType Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingBox.ComparerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.ComparerType.html) |     |

#### CornerCount

Specifies the total number of corners (8) in the BoundingBox.

##### Declaration

```
public const int CornerCount = 8
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Invalid

##### Declaration

```
public static readonly BoundingBox Invalid
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Max

The maximum point the BoundingBox contains.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Min

The minimum point the BoundingBox contains.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Properties

#### Center

Calculates center

##### Declaration

```
public Vector3 Center { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Corners

##### Declaration

```
public BoxCornerEnumerator Corners { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoxCornerEnumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoxCornerEnumerator.html) |     |

#### Depth

##### Declaration

```
public float Depth { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Extents

##### Declaration

```
public Vector3 Extents { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### HalfExtents

##### Declaration

```
public Vector3 HalfExtents { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Height

##### Declaration

```
public float Height { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Matrix

Matrix of AABB, respecting center and size

##### Declaration

```
public Matrix Matrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |

#### Perimeter

return perimeter of edges

##### Declaration

```
public float Perimeter { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Size

Size

##### Declaration

```
public Vector3 Size { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

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

#### Contains(BoundingBox)

Tests whether the BoundingBox contains another BoundingBox.

##### Declaration

```
public ContainmentType Contains(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to test for overlap. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingBox, out ContainmentType)

Tests whether the BoundingBox contains a BoundingBox.

##### Declaration

```
public void Contains(ref BoundingBox box, out ContainmentType result)
```
