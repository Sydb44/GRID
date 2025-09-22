
##### Declaration

```
public void Dot(ref Vector4 value, out double result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | value | The Vector4 to multiply this PlaneD by. |
| System.Double | result | \[OutAttribute\] The dot product of the specified Vector4 and this PlaneD. |

#### DotCoordinate(Vector3D)

Returns the dot product of a specified Vector3D and the Normal vector of this PlaneD plus the distance (D) value of the PlaneD.

##### Declaration

```
public double DotCoordinate(Vector3D value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | value | The Vector3D to multiply by. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### DotCoordinate(ref Vector3D, out Double)

Returns the dot product of a specified Vector3D and the Normal vector of this PlaneD plus the distance (D) value of the PlaneD.

##### Declaration

```
public void DotCoordinate(ref Vector3D value, out double result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | value | The Vector3D to multiply by. |
| System.Double | result | \[OutAttribute\] The resulting value. |

#### DotNormal(Vector3D)

Returns the dot product of a specified Vector3D and the Normal vector of this PlaneD.

##### Declaration

```
public double DotNormal(Vector3D value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | value | The Vector3D to multiply by. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### DotNormal(ref Vector3D, out Double)

Returns the dot product of a specified Vector3D and the Normal vector of this PlaneD.

##### Declaration

```
public void DotNormal(ref Vector3D value, out double result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | value | The Vector3D to multiply by. |
| System.Double | result | \[OutAttribute\] The resulting dot product. |

#### Equals(Object)

Determines whether the specified Object is equal to the PlaneD.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current PlaneD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(PlaneD)

Determines whether the specified PlaneD is equal to the PlaneD.

##### Declaration

```
public bool Equals(PlaneD other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | other | The PlaneD to compare with the current PlaneD. |

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

#### Intersects(BoundingBoxD)

Checks whether the current PlaneD intersects a specified BoundingBox.

##### Declaration

```
public PlaneIntersectionType Intersects(BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBox to test for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref BoundingBoxD, out PlaneIntersectionType)

Checks whether the current PlaneD intersects a BoundingBox.

##### Declaration

```
public void Intersects(ref BoundingBoxD box, out PlaneIntersectionType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBox to check for intersection with. |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) | result | \[OutAttribute\] An enumeration indicating whether the PlaneD intersects the BoundingBox. |

#### Intersects(BoundingFrustumD)

Checks whether the current PlaneD intersects a specified BoundingFrustum.

##### Declaration

```
public PlaneIntersectionType Intersects(BoundingFrustumD frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum | The BoundingFrustum to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |
