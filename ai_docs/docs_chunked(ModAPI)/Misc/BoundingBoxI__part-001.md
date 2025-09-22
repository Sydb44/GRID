---
title: "Class BoundingBoxI"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingBoxI"
---

# Class BoundingBoxI | Space Engineers ModAPI

Defines an axis-aligned box-shaped 3D volume.

##### Inheritance

System.Object

BoundingBoxI

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class BoundingBoxI : ValueType, IEquatable<BoundingBoxI>
```

### Constructors

#### BoundingBoxI(Int32, Int32)

Creates an instance of BoundingBoxI.

##### Declaration

```
public BoundingBoxI(int min, int max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | min | The minimum point the BoundingBoxI includes. |
| System.Int32 | max | The maximum point the BoundingBoxI includes. |

#### BoundingBoxI(BoundingBox)

Creates an instance of BoundingBoxI.

##### Declaration

```
public BoundingBoxI(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box |     |

#### BoundingBoxI(Vector3I, Vector3I)

Creates an instance of BoundingBoxI.

##### Declaration

```
public BoundingBoxI(Vector3I min, Vector3I max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | min | The minimum point the BoundingBoxI includes. |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | max | The maximum point the BoundingBoxI includes. |

### Fields

#### Max

The maximum point the BoundingBoxI contains.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Min

The minimum point the BoundingBoxI contains.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

### Properties

#### Center

Calculates center

##### Declaration

```
public Vector3I Center { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### HalfExtents

##### Declaration

```
public Vector3I HalfExtents { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### IsValid

##### Declaration

```
public bool IsValid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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
public Vector3I Size { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

### Methods

#### Contains(BoundingBoxI)

Tests whether the BoundingBoxI contains another BoundingBoxI.

##### Declaration

```
public ContainmentType Contains(BoundingBoxI box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box | The BoundingBoxI to test for overlap. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingBoxI, out ContainmentType)

Tests whether the BoundingBoxI contains a BoundingBoxI.

##### Declaration

```
public void Contains(ref BoundingBoxI box, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box | The BoundingBoxI to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(Vector3)

##### Declaration

```
public ContainmentType Contains(Vector3 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(Vector3I)

Tests whether the BoundingBoxI contains a point.

##### Declaration

```
public ContainmentType Contains(Vector3I point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | point | The point to test for overlap. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref Vector3I, out ContainmentType)

Tests whether the BoundingBoxI contains a point.

##### Declaration

```
public void Contains(ref Vector3I point, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | point | The point to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |
