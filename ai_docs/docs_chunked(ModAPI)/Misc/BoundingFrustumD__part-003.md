public void Intersects(ref BoundingBoxD box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingFrustumD and BoundingBoxD intersect; false otherwise. |

#### Intersects(BoundingFrustumD)

Checks whether the current BoundingFrustumD intersects the specified BoundingFrustumD.

##### Declaration

```
public bool Intersects(BoundingFrustumD frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum | The BoundingFrustumD to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(BoundingSphereD)

Checks whether the current BoundingFrustumD intersects the specified BoundingSphere.

##### Declaration

```
public bool Intersects(BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphere to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingSphereD, out Boolean)

Checks whether the current BoundingFrustumD intersects a BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphereD sphere, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphere to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingFrustumD and BoundingSphere intersect; false otherwise. |

#### Intersects(PlaneD)

Checks whether the current BoundingFrustumD intersects the specified Plane.

##### Declaration

```
public PlaneIntersectionType Intersects(PlaneD plane)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | plane | The Plane to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref PlaneD, out PlaneIntersectionType)

Checks whether the current BoundingFrustumD intersects a Plane.

##### Declaration

```
public void Intersects(ref PlaneD plane, out PlaneIntersectionType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | plane | The Plane to check for intersection with. |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) | result | \[OutAttribute\] An enumeration indicating whether the BoundingFrustumD intersects the Plane. |

#### Intersects(RayD)

Checks whether the current BoundingFrustumD intersects the specified Ray.

##### Declaration

```
public Nullable<double> Intersects(RayD ray)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | ray | The Ray to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### Intersects(ref RayD, out Nullable<Double>)

Checks whether the current BoundingFrustumD intersects a Ray.

##### Declaration

```
public void Intersects(ref RayD ray, out Nullable<double> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | ray | The Ray to check for intersection with. |
| System.Nullable<System.Double\> | result | \[OutAttribute\] Distance at which the ray intersects the BoundingFrustumD or null if there is no intersection. |

#### ToString()

Returns a String that represents the current BoundingFrustumD.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Equality(BoundingFrustumD, BoundingFrustumD)

Determines whether two instances of BoundingFrustumD are equal.

##### Declaration

```
public static bool operator ==(BoundingFrustumD a, BoundingFrustumD b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | a   | The BoundingFrustumD to the left of the equality operator. |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | b   | The BoundingFrustumD to the right of the equality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(BoundingFrustumD, BoundingFrustumD)

Determines whether two instances of BoundingFrustumD are not equal.

##### Declaration

```
public static bool operator !=(BoundingFrustumD a, BoundingFrustumD b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | a   | The BoundingFrustumD to the left of the inequality operator. |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | b   | The BoundingFrustumD to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |