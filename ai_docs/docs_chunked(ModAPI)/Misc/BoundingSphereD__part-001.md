---
title: "Class BoundingSphereD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingSphereD"
---

# Class BoundingSphereD | Space Engineers ModAPI

Defines a sphere.

##### Inheritance

System.Object

BoundingSphereD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class BoundingSphereD : ValueType, IEquatable<BoundingSphereD>
```

### Constructors

#### BoundingSphereD(Vector3D, Double)

Creates a new instance of BoundingSphereD.

##### Declaration

```
public BoundingSphereD(Vector3D center, double radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | center | Center point of the sphere. |
| System.Double | radius | Radius of the sphere. |

### Fields

#### Center

The center point of the sphere.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Radius

The radius of the sphere.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

### Methods

#### Contains(BoundingBoxD)

Checks whether the current BoundingSphereD contains the specified BoundingBoxD.

##### Declaration

```
public ContainmentType Contains(BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to check against the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingBoxD, out ContainmentType)

Checks whether the current BoundingSphereD contains the specified BoundingBoxD.

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

Checks whether the current BoundingSphereD contains the specified BoundingFrustum.

##### Declaration

```
public ContainmentType Contains(BoundingFrustumD frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum | The BoundingFrustum to check against the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(BoundingSphereD)

Checks whether the current BoundingSphereD contains the specified BoundingSphereD.

##### Declaration

```
public ContainmentType Contains(BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphereD to check against the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingSphereD, out ContainmentType)

Checks whether the current BoundingSphereD contains the specified BoundingSphereD.

##### Declaration

```
public void Contains(ref BoundingSphereD sphere, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphereD to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(MyOrientedBoundingBoxD)

Checks whether the current BoundingSphereD contains the specified MyOrientedBoundingBoxD.

##### Declaration

```
public ContainmentType Contains(MyOrientedBoundingBoxD obox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | obox | The MyOrientedBoundingBoxD to check against the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref MyOrientedBoundingBoxD, out ContainmentType)

Checks whether the current BoundingSphereD contains the specified MyOrientedBoundingBoxD.

##### Declaration

```
public void Contains(ref MyOrientedBoundingBoxD obox, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | obox | The MyOrientedBoundingBoxD to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(Vector3D)

Checks whether the current BoundingSphereD contains the specified point.
