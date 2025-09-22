#### Include(BoundingSphere)

##### Declaration

```
public BoundingSphere Include(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### Include(ref BoundingSphere, ref BoundingSphere)

##### Declaration

```
public static void Include(ref BoundingSphere sphere, ref BoundingSphere otherSphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere |     |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | otherSphere |     |

#### IntersectRaySphere(Ray, out Single, out Single)

##### Declaration

```
public bool IntersectRaySphere(Ray ray, out float tmin, out float tmax)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray |     |
| System.Single | tmin |     |
| System.Single | tmax |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(BoundingBox)

Checks whether the current BoundingSphere intersects with a specified BoundingBox.

##### Declaration

```
public bool Intersects(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check for intersection with the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBox, out Boolean)

Checks whether the current BoundingSphere intersects a BoundingBox.

##### Declaration

```
public void Intersects(ref BoundingBox box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingSphere and BoundingBox intersect; false otherwise. |

#### Intersects(BoundingFrustum)

Checks whether the current BoundingSphere intersects with a specified BoundingFrustum.

##### Declaration

```
public bool Intersects(BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The BoundingFrustum to check for intersection with the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(BoundingSphere)

Checks whether the current BoundingSphere intersects with a specified BoundingSphere.

##### Declaration

```
public bool Intersects(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingSphere, out Boolean)

Checks whether the current BoundingSphere intersects another BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphere sphere, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingSphere instances intersect; false otherwise. |

#### Intersects(Plane)

Checks whether the current BoundingSphere intersects with a specified Plane.

##### Declaration

```
public PlaneIntersectionType Intersects(Plane plane)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The Plane to check for intersection with the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref Plane, out PlaneIntersectionType)

Checks whether the current BoundingSphere intersects a Plane.

##### Declaration

```
public void Intersects(ref Plane plane, out PlaneIntersectionType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The Plane to check for intersection with. |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) | result | \[OutAttribute\] An enumeration indicating whether the BoundingSphere intersects the Plane. |

#### Intersects(Ray)

Checks whether the current BoundingSphere intersects with a specified Ray.

##### Declaration

```
public Nullable<float> Intersects(Ray ray)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray | The Ray to check for intersection with the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Intersects(ref Ray, out Nullable<Single>)

Checks whether the current BoundingSphere intersects a Ray.
