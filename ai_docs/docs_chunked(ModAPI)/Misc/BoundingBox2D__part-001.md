---
title: "Class BoundingBox2D"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingBox2D"
---

# Class BoundingBox2D | Space Engineers ModAPI

Defines an axis-aligned box-shaped 2D volume.

##### Inheritance

System.Object

BoundingBox2D

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class BoundingBox2D : ValueType, IEquatable<BoundingBox2D>
```

### [](#constructors)Constructors

#### [](#VRageMath_BoundingBox2D__ctor_VRageMath_Vector2D_VRageMath_Vector2D_)BoundingBox2D(Vector2D, Vector2D)

Creates an instance of BoundingBox2D.

##### Declaration

```
public BoundingBox2D(Vector2D min, Vector2D max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html) | min | The minimum point the BoundingBox2D includes. |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html) | max | The maximum point the BoundingBox2D includes. |

### [](#fields)Fields

#### [](#VRageMath_BoundingBox2D_CornerCount)CornerCount

Specifies the total number of corners (8) in the BoundingBox2D.

##### Declaration

```
public const int CornerCount = 8
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_BoundingBox2D_Max)Max

The maximum point the BoundingBox2D contains.

##### Declaration

##### Field Value

#### [](#VRageMath_BoundingBox2D_Min)Min

The minimum point the BoundingBox2D contains.

##### Declaration

##### Field Value

### [](#properties)Properties

#### [](#VRageMath_BoundingBox2D_Center)Center

Calculates center

##### Declaration

```
public Vector2D Center { get; }
```

##### Property Value

#### [](#VRageMath_BoundingBox2D_Extents)Extents

##### Declaration

```
public Vector2D Extents { get; }
```

##### Property Value

#### [](#VRageMath_BoundingBox2D_HalfExtents)HalfExtents

##### Declaration

```
public Vector2D HalfExtents { get; }
```

##### Property Value

#### [](#VRageMath_BoundingBox2D_Height)Height

##### Declaration

```
public double Height { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRageMath_BoundingBox2D_Size)Size

Size

##### Declaration

```
public Vector2D Size { get; }
```

##### Property Value

#### [](#VRageMath_BoundingBox2D_Width)Width

##### Declaration

```
public double Width { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

### [](#methods)Methods

#### [](#VRageMath_BoundingBox2D_Area)Area()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRageMath_BoundingBox2D_Contains_VRageMath_BoundingBox2D_)Contains(BoundingBox2D)

Tests whether the BoundingBox2D contains another BoundingBox2D.

##### Declaration

```
public ContainmentType Contains(BoundingBox2D box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | box | The BoundingBox2D to test for overlap. |

##### Returns

#### [](#VRageMath_BoundingBox2D_Contains_VRageMath_BoundingBox2D__VRageMath_ContainmentType__)Contains(ref BoundingBox2D, out ContainmentType)

Tests whether the BoundingBox2D contains a BoundingBox2D.

##### Declaration

```
public void Contains(ref BoundingBox2D box, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2D.html) | box | The BoundingBox2D to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### [](#VRageMath_BoundingBox2D_Contains_VRageMath_Vector2D_)Contains(Vector2D)

Tests whether the BoundingBox2D contains a point.

##### Declaration

```
public ContainmentType Contains(Vector2D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html) | point | The point to test for overlap. |

##### Returns

#### [](#VRageMath_BoundingBox2D_Contains_VRageMath_Vector2D__VRageMath_ContainmentType__)Contains(ref Vector2D, out ContainmentType)

Tests whether the BoundingBox2D contains a point.

##### Declaration

```
public void Contains(ref Vector2D point, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html) | point | The point to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### [](#VRageMath_BoundingBox2D_CreateFromHalfExtent_VRageMath_Vector2D_System_Double_)CreateFromHalfExtent(Vector2D, Double)

##### Declaration

```
public static BoundingBox2D CreateFromHalfExtent(Vector2D center, double halfExtent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2D.html) | center |     |
| System.Double | halfExtent |     |

##### Returns

#### [](#VRageMath_BoundingBox2D_CreateFromHalfExtent_VRageMath_Vector2D_VRageMath_Vector2D_)CreateFromHalfExtent(Vector2D, Vector2D)

##### Declaration

```
public static BoundingBox2D CreateFromHalfExtent(Vector2D center, Vector2D halfExtent)
```

##### Parameters

##### Returns

#### [](#VRageMath_BoundingBox2D_CreateFromPoints_System_Collections_Generic_IEnumerable_VRageMath_Vector2D__)CreateFromPoints(IEnumerable<Vector2D>)

Creates the smallest BoundingBox2D that will contain a group of points.
