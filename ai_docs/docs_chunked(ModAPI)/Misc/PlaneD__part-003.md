```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum | The BoundingFrustum to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref BoundingSphere, out PlaneIntersectionType)

Checks whether the current PlaneD intersects a BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphere sphere, out PlaneIntersectionType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with. |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) | result | \[OutAttribute\] An enumeration indicating whether the PlaneD intersects the BoundingSphere. |

#### Intersects(BoundingSphereD)

Checks whether the current PlaneD intersects a specified BoundingSphere.

##### Declaration

```
public PlaneIntersectionType Intersects(BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphere to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Normalize()

Changes the coefficients of the Normal vector of this PlaneD to make it of unit length.

##### Declaration

#### Normalize(PlaneD)

Changes the coefficients of the Normal vector of a PlaneD to make it of unit length.

##### Declaration

```
public static PlaneD Normalize(PlaneD value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | value | The PlaneD to normalize. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) |     |

#### Normalize(ref PlaneD, out PlaneD)

Changes the coefficients of the Normal vector of a PlaneD to make it of unit length.

##### Declaration

```
public static void Normalize(ref PlaneD value, out PlaneD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | value | The PlaneD to normalize. |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | result | \[OutAttribute\] An existing PlaneD PlaneD filled in with a normalized version of the specified PlaneD. |

#### ProjectPoint(ref Vector3D)

##### Declaration

```
public Vector3D ProjectPoint(ref Vector3D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### RandomPoint()

##### Declaration

```
public Vector3D RandomPoint()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### ToString()

Returns a String that represents the current PlaneD.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Transform(PlaneD, MatrixD)

Transforms a normalized plane by a Matrix.

##### Declaration

```
public static PlaneD Transform(PlaneD plane, MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | plane | The normalized plane to transform. This plane must already be normalized, so that its Normal vector is of unit length, before this method is called. |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix | The transform Matrix to apply to the plane. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) |     |

#### Transform(ref PlaneD, ref MatrixD, out PlaneD)

Transforms a normalized plane by a Matrix.

##### Declaration

```
public static void Transform(ref PlaneD plane, ref MatrixD matrix, out PlaneD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | plane | The normalized plane to transform. This plane must already be normalized, so that its Normal vector is of unit length, before this method is called. |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix | The transform Matrix to apply to the plane. |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | result | \[OutAttribute\] An existing PlaneD filled in with the results of applying the transform. |

### Operators

#### Equality(PlaneD, PlaneD)

Determines whether two instances of PlaneD are equal.

##### Declaration

```
public static bool operator ==(PlaneD lhs, PlaneD rhs)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | lhs | The object to the left of the equality operator. |
| [PlaneD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html) | rhs | The object to the right of the equality operator. |
