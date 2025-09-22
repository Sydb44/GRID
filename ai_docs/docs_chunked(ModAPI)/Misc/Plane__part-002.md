| Type | Description |
| --- | --- |
| System.Single |     |

#### DotCoordinate(ref Vector3, out Single)

Returns the dot product of a specified Vector3 and the Normal vector of this Plane plus the distance (D) value of the Plane.

##### Declaration

```
public void DotCoordinate(ref Vector3 value, out float result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | value | The Vector3 to multiply by. |
| System.Single | result | \[OutAttribute\] The resulting value. |

#### DotNormal(ref Vector3, out Single)

Returns the dot product of a specified Vector3 and the Normal vector of this Plane.

##### Declaration

```
public void DotNormal(ref Vector3 value, out float result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | value | The Vector3 to multiply by. |
| System.Single | result | \[OutAttribute\] The resulting dot product. |

#### DotNormal(Vector3D)

Returns the dot product of a specified Vector3 and the Normal vector of this Plane.

##### Declaration

```
public double DotNormal(Vector3D value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | value | The Vector3 to multiply by. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### Equals(Object)

Determines whether the specified Object is equal to the Plane.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current Plane. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(Plane)

Determines whether the specified Plane is equal to the Plane.

##### Declaration

```
public bool Equals(Plane other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | other | The Plane to compare with the current Plane. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

Gets the hash code for this object.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Intersection(ref Vector3D, ref Vector3D)

Gets intersection point in Plane.

##### Declaration

```
public Vector3D Intersection(ref Vector3D from, ref Vector3D direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | Starting point of a ray. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | direction | Ray direction. |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | Point of intersection. |

#### Intersects(BoundingBox)

Checks whether the current Plane intersects a specified BoundingBox.

##### Declaration

```
public PlaneIntersectionType Intersects(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to test for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref BoundingBox, out PlaneIntersectionType)

Checks whether the current Plane intersects a BoundingBox.

##### Declaration

```
public void Intersects(ref BoundingBox box, out PlaneIntersectionType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check for intersection with. |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) | result | \[OutAttribute\] An enumeration indicating whether the Plane intersects the BoundingBox. |

#### Intersects(BoundingFrustum)

Checks whether the current Plane intersects a specified BoundingFrustum.

##### Declaration

```
public PlaneIntersectionType Intersects(BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The BoundingFrustum to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(BoundingSphere)

Checks whether the current Plane intersects a specified BoundingSphere.

##### Declaration

```
public PlaneIntersectionType Intersects(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref BoundingSphere, out PlaneIntersectionType)

Checks whether the current Plane intersects a BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result)
```
