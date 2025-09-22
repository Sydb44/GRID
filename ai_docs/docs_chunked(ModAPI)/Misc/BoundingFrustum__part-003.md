```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The BoundingFrustum to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingFrustum_Intersects_VRageMath_BoundingSphere_)Intersects(BoundingSphere)

Checks whether the current BoundingFrustum intersects the specified BoundingSphere.

##### Declaration

```
public bool Intersects(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingFrustum_Intersects_VRageMath_BoundingSphere__System_Boolean__)Intersects(ref BoundingSphere, out Boolean)

Checks whether the current BoundingFrustum intersects a BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphere sphere, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingFrustum and BoundingSphere intersect; false otherwise. |

#### [](#VRageMath_BoundingFrustum_Intersects_VRageMath_Plane_)Intersects(Plane)

Checks whether the current BoundingFrustum intersects the specified Plane.

##### Declaration

```
public PlaneIntersectionType Intersects(Plane plane)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The Plane to check for intersection. |

##### Returns

#### [](#VRageMath_BoundingFrustum_Intersects_VRageMath_Plane__VRageMath_PlaneIntersectionType__)Intersects(ref Plane, out PlaneIntersectionType)

Checks whether the current BoundingFrustum intersects a Plane.

##### Declaration

```
public void Intersects(ref Plane plane, out PlaneIntersectionType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The Plane to check for intersection with. |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) | result | \[OutAttribute\] An enumeration indicating whether the BoundingFrustum intersects the Plane. |

#### [](#VRageMath_BoundingFrustum_Intersects_VRageMath_Ray_)Intersects(Ray)

Checks whether the current BoundingFrustum intersects the specified Ray.

##### Declaration

```
public Nullable<float> Intersects(Ray ray)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray | The Ray to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### [](#VRageMath_BoundingFrustum_Intersects_VRageMath_Ray__System_Nullable_System_Single___)Intersects(ref Ray, out Nullable<Single>)

Checks whether the current BoundingFrustum intersects a Ray.

##### Declaration

```
public void Intersects(ref Ray ray, out Nullable<float> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray | The Ray to check for intersection with. |
| System.Nullable<System.Single\> | result | \[OutAttribute\] Distance at which the ray intersects the BoundingFrustum or null if there is no intersection. |

#### [](#VRageMath_BoundingFrustum_ToString)ToString()

Returns a String that represents the current BoundingFrustum.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### [](#operators)Operators

#### [](#VRageMath_BoundingFrustum_op_Equality_VRageMath_BoundingFrustum_VRageMath_BoundingFrustum_)Equality(BoundingFrustum, BoundingFrustum)

Determines whether two instances of BoundingFrustum are equal.

##### Declaration

```
public static bool operator ==(BoundingFrustum a, BoundingFrustum b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | a   | The BoundingFrustum to the left of the equality operator. |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | b   | The BoundingFrustum to the right of the equality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingFrustum_op_Inequality_VRageMath_BoundingFrustum_VRageMath_BoundingFrustum_)Inequality(BoundingFrustum, BoundingFrustum)

Determines whether two instances of BoundingFrustum are not equal.

##### Declaration

```
public static bool operator !=(BoundingFrustum a, BoundingFrustum b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | a   | The BoundingFrustum to the left of the inequality operator. |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | b   | The BoundingFrustum to the right of the inequality operator. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#extensionmethods)Extension Methods