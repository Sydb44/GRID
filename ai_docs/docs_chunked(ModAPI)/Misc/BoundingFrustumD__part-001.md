---
title: "Class BoundingFrustumD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingFrustumD"
---

# Class BoundingFrustumD | Space Engineers ModAPI

Defines a frustum and helps determine whether forms intersect with it.

##### Inheritance

System.Object

BoundingFrustumD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class BoundingFrustumD : Object, IEquatable<BoundingFrustumD>
```

### Constructors

#### BoundingFrustumD()

##### Declaration

```
public BoundingFrustumD()
```

#### BoundingFrustumD(MatrixD)

Creates a new instance of BoundingFrustumD.

##### Declaration

```
public BoundingFrustumD(MatrixD value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | value | Combined matrix that usually takes view × projection matrix. |

### Fields

#### CornerCount

Specifies the total number of corners (8) in the BoundingFrustumD.

##### Declaration

```
public const int CornerCount = 8
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### Bottom

Gets the bottom plane of the BoundingFrustumD.

##### Declaration

```
public PlaneD Bottom { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) |     |

#### Far

Gets the far plane of the BoundingFrustumD.

##### Declaration

```
public PlaneD Far { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) |     |

#### Item\[Int32\]

##### Declaration

```
public PlaneD this[int index] { get; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

| Type | Description |
| --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) |     |

#### Left

Gets the left plane of the BoundingFrustumD.

##### Declaration

```
public PlaneD Left { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) |     |

#### Matrix

Gets or sets the Matrix that describes this bounding frustum.

##### Declaration

```
public MatrixD Matrix { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### Near

Gets the near plane of the BoundingFrustumD.

##### Declaration

```
public PlaneD Near { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) |     |

#### Right

Gets the right plane of the BoundingFrustumD.

##### Declaration

```
public PlaneD Right { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) |     |

#### Top

Gets the top plane of the BoundingFrustumD.

##### Declaration

```
public PlaneD Top { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) |     |

### Methods

#### Contains(BoundingBoxD)

Checks whether the current BoundingFrustumD contains the specified BoundingBoxD.

##### Declaration

```
public ContainmentType Contains(BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to check against the current BoundingFrustumD. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingBoxD, out ContainmentType)

Checks whether the current BoundingFrustumD contains the specified BoundingBoxD.

##### Declaration

```
public void Contains(ref BoundingBoxD box, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(BoundingFrustumD)

Checks whether the current BoundingFrustumD contains the specified BoundingFrustumD.

##### Declaration

```
public ContainmentType Contains(BoundingFrustumD frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum | The BoundingFrustumD to check against the current BoundingFrustumD. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(BoundingSphereD)

Checks whether the current BoundingFrustumD contains the specified BoundingSphere.

##### Declaration

```
public ContainmentType Contains(BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphere to check against the current BoundingFrustumD. |
