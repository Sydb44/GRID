---
title: "Class Ray"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html"
category: "Misc"
namespace: "VRageMath"
class: "Ray"
---

# Class Ray | Space Engineers ModAPI

Defines a ray.

##### Inheritance

System.Object

Ray

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Ray : ValueType, IEquatable<Ray>
```

### Constructors

#### Ray(Vector3, Vector3)

Creates a new instance of Ray.

##### Declaration

```
public Ray(Vector3 position, Vector3 direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | position | The starting point of the Ray. |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | direction | Unit vector describing the direction of the Ray. |

### Fields

#### Direction

Unit vector specifying the direction the Ray is pointing.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Position

Specifies the starting point of the Ray.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

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

#### Equals(Ray)

Determines whether the specified Ray is equal to the current Ray.

##### Declaration

```
public bool Equals(Ray other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | other | The Ray to compare with the current Ray. |

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

#### Intersects(BoundingBox)

Checks whether the Ray intersects a specified BoundingBox.

##### Declaration

```
public Nullable<float> Intersects(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check for intersection with the Ray. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Intersects(ref BoundingBox, out Nullable<Single>)

Checks whether the current Ray intersects a BoundingBox.

##### Declaration

```
public void Intersects(ref BoundingBox box, out Nullable<float> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check for intersection with. |
| System.Nullable<System.Single\> | result | \[OutAttribute\] Distance at which the ray intersects the BoundingBox or null if there is no intersection. |

#### Intersects(BoundingFrustum)

Checks whether the Ray intersects a specified BoundingFrustum.

##### Declaration

```
public Nullable<float> Intersects(BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The BoundingFrustum to check for intersection with the Ray. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Intersects(BoundingSphere)

Checks whether the Ray intersects a specified BoundingSphere.

##### Declaration

```
public Nullable<float> Intersects(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with the Ray. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Intersects(ref BoundingSphere, out Nullable<Single>)

Checks whether the current Ray intersects a BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphere sphere, out Nullable<float> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with. |
| System.Nullable<System.Single\> | result | \[OutAttribute\] Distance at which the ray intersects the BoundingSphere or null if there is no intersection. |

#### Intersects(Plane)

Determines whether this Ray intersects a specified Plane.

##### Declaration

```
public Nullable<float> Intersects(Plane plane)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The Plane with which to calculate this Ray's intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Intersects(ref Plane, out Nullable<Single>)

Determines whether this Ray intersects a specified Plane.

##### Declaration

```
public void Intersects(ref Plane plane, out Nullable<float> result)
```
