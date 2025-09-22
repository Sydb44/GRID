---
title: "Class RayD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html"
category: "Misc"
namespace: "VRageMath"
class: "RayD"
---

# Class RayD | Space Engineers ModAPI

Defines a ray.

##### Inheritance

System.Object

RayD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class RayD : ValueType, IEquatable<RayD>
```

### Constructors

#### RayD(Vector3D, Vector3D)

Creates a new instance of Ray.

##### Declaration

```
public RayD(Vector3D position, Vector3D direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | The starting point of the Ray. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | direction | Unit vector describing the direction of the Ray. |

#### RayD(ref Vector3D, ref Vector3D)

##### Declaration

```
public RayD(ref Vector3D position, ref Vector3D direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | direction |     |

### Fields

#### Direction

Unit vector specifying the direction the Ray is pointing.

##### Declaration

```
public Vector3D Direction
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Position

Specifies the starting point of the Ray.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### Equals(Object)

Determines whether two instances of Ray are equal.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current Ray. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(RayD)

Determines whether the specified Ray is equal to the current Ray.

##### Declaration

```
public bool Equals(RayD other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | other | The Ray to compare with the current Ray. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

Gets the hash code for this instance.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Intersects(BoundingBoxD)

Checks whether the Ray intersects a specified BoundingBox.

##### Declaration

```
public Nullable<double> Intersects(BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBox to check for intersection with the Ray. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### Intersects(ref BoundingBoxD, out Nullable<Double>)

Checks whether the current Ray intersects a BoundingBox.

##### Declaration

```
public void Intersects(ref BoundingBoxD box, out Nullable<double> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBox to check for intersection with. |
| System.Nullable<System.Double\> | result | \[OutAttribute\] Distance at which the ray intersects the BoundingBox or null if there is no intersection. |

#### Intersects(BoundingFrustumD)

Checks whether the Ray intersects a specified BoundingFrustum.

##### Declaration

```
public Nullable<double> Intersects(BoundingFrustumD frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum | The BoundingFrustum to check for intersection with the Ray. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### Intersects(ref BoundingSphere, out Nullable<Double>)

Checks whether the current Ray intersects a BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphere sphere, out Nullable<double> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with. |
| System.Nullable<System.Double\> | result | \[OutAttribute\] Distance at which the ray intersects the BoundingSphere or null if there is no intersection. |

#### Intersects(BoundingSphereD)

Checks whether the Ray intersects a specified BoundingSphere.

##### Declaration

```
public Nullable<double> Intersects(BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphere to check for intersection with the Ray. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### Intersects(PlaneD)

Determines whether this Ray intersects a specified Plane.

##### Declaration

```
public Nullable<double> Intersects(PlaneD plane)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | plane | The Plane with which to calculate this Ray's intersection. |
