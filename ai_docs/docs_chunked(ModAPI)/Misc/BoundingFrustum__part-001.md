---
title: "Class BoundingFrustum"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingFrustum"
---

# Class BoundingFrustum | Space Engineers ModAPI

Defines a frustum and helps determine whether forms intersect with it.

##### Inheritance

System.Object

BoundingFrustum

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class BoundingFrustum : Object, IEquatable<BoundingFrustum>
```

### [](#constructors)Constructors

#### [](#VRageMath_BoundingFrustum__ctor)BoundingFrustum()

##### Declaration

#### [](#VRageMath_BoundingFrustum__ctor_VRageMath_Matrix_)BoundingFrustum(Matrix)

Creates a new instance of BoundingFrustum.

##### Declaration

```
public BoundingFrustum(Matrix value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | value | Combined matrix that usually takes view × projection matrix. |

### [](#fields)Fields

#### [](#VRageMath_BoundingFrustum_CornerCount)CornerCount

Specifies the total number of corners (8) in the BoundingFrustum.

##### Declaration

```
public const int CornerCount = 8
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#properties)Properties

#### [](#VRageMath_BoundingFrustum_Bottom)Bottom

Gets the bottom plane of the BoundingFrustum.

##### Declaration

```
public Plane Bottom { get; }
```

##### Property Value

#### [](#VRageMath_BoundingFrustum_Far)Far

Gets the far plane of the BoundingFrustum.

##### Declaration

```
public Plane Far { get; }
```

##### Property Value

#### [](#VRageMath_BoundingFrustum_Item_System_Int32_)Item\[Int32\]

##### Declaration

```
public Plane this[int index] { get; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

#### [](#VRageMath_BoundingFrustum_Left)Left

Gets the left plane of the BoundingFrustum.

##### Declaration

```
public Plane Left { get; }
```

##### Property Value

#### [](#VRageMath_BoundingFrustum_Matrix)Matrix

Gets or sets the Matrix that describes this bounding frustum.

##### Declaration

```
public Matrix Matrix { get; set; }
```

##### Property Value

#### [](#VRageMath_BoundingFrustum_Near)Near

Gets the near plane of the BoundingFrustum.

##### Declaration

```
public Plane Near { get; }
```

##### Property Value

#### [](#VRageMath_BoundingFrustum_Planes)Planes

##### Declaration

```
public Plane[] Planes { get; }
```

##### Property Value

#### [](#VRageMath_BoundingFrustum_Right)Right

Gets the right plane of the BoundingFrustum.

##### Declaration

```
public Plane Right { get; }
```

##### Property Value

#### [](#VRageMath_BoundingFrustum_Top)Top

Gets the top plane of the BoundingFrustum.

##### Declaration

```
public Plane Top { get; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRageMath_BoundingFrustum_Contains_VRageMath_BoundingBox__)Contains(ref BoundingBox)

Checks whether the current BoundingFrustum contains the specified BoundingBox.

##### Declaration

```
public ContainmentType Contains(ref BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check against the current BoundingFrustum. |

##### Returns

#### [](#VRageMath_BoundingFrustum_Contains_VRageMath_BoundingBox__VRageMath_ContainmentType__)Contains(ref BoundingBox, out ContainmentType)

Checks whether the current BoundingFrustum contains the specified BoundingBox.

##### Declaration

```
public void Contains(ref BoundingBox box, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### [](#VRageMath_BoundingFrustum_Contains_VRageMath_BoundingFrustum_)Contains(BoundingFrustum)

Checks whether the current BoundingFrustum contains the specified BoundingFrustum.

##### Declaration

```
public ContainmentType Contains(BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The BoundingFrustum to check against the current BoundingFrustum. |

##### Returns

#### [](#VRageMath_BoundingFrustum_Contains_VRageMath_BoundingSphere_)Contains(BoundingSphere)

Checks whether the current BoundingFrustum contains the specified BoundingSphere.

##### Declaration

```
public ContainmentType Contains(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check against the current BoundingFrustum. |

##### Returns

#### [](#VRageMath_BoundingFrustum_Contains_VRageMath_BoundingSphere__VRageMath_ContainmentType__)Contains(ref BoundingSphere, out ContainmentType)

Checks whether the current BoundingFrustum contains the specified BoundingSphere.

##### Declaration

```
public void Contains(ref BoundingSphere sphere, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |
