---
title: "Class BoundingSphere"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html"
category: "Misc"
namespace: "VRageMath"
class: "BoundingSphere"
---

# Class BoundingSphere | Space Engineers ModAPI

Defines a sphere.

##### Inheritance

System.Object

BoundingSphere

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class BoundingSphere : ValueType, IEquatable<BoundingSphere>
```

### Constructors

#### BoundingSphere(Vector3, Single)

Creates a new instance of BoundingSphere.

##### Declaration

```
public BoundingSphere(Vector3 center, float radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | center | Center point of the sphere. |
| System.Single | radius | Radius of the sphere. |

### Fields

#### Center

The center point of the sphere.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Radius

The radius of the sphere.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Contains(BoundingBox)

Checks whether the current BoundingSphere contains the specified BoundingBox.

##### Declaration

```
public ContainmentType Contains(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check against the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingBox, out ContainmentType)

Checks whether the current BoundingSphere contains the specified BoundingBox.

##### Declaration

```
public void Contains(ref BoundingBox box, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(BoundingFrustum)

Checks whether the current BoundingSphere contains the specified BoundingFrustum.

##### Declaration

```
public ContainmentType Contains(BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The BoundingFrustum to check against the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(BoundingSphere)

Checks whether the current BoundingSphere contains the specified BoundingSphere.

##### Declaration

```
public ContainmentType Contains(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check against the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingSphere, out ContainmentType)

Checks whether the current BoundingSphere contains the specified BoundingSphere.

##### Declaration

```
public void Contains(ref BoundingSphere sphere, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(Vector3)

Checks whether the current BoundingSphere contains the specified point.

##### Declaration

```
public ContainmentType Contains(Vector3 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point | The point to check against the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref Vector3, out ContainmentType)

Checks whether the current BoundingSphere contains the specified point.

##### Declaration

```
public void Contains(ref Vector3 point, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point | The point to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### CreateFromBoundingBox(BoundingBox)

Creates the smallest BoundingSphere that can contain a specified BoundingBox.

##### Declaration

```
public static BoundingSphere CreateFromBoundingBox(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to create the BoundingSphere from. |
