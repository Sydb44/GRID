##### Declaration

```
public static void CreateMerged(ref BoundingSphereD original, ref BoundingSphereD additional, out BoundingSphereD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | original | BoundingSphereD to be merged. |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | additional | BoundingSphereD to be merged. |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | result | \[OutAttribute\] The created BoundingSphereD. |

#### Equals(Object)

Determines whether the specified Object is equal to the BoundingSphereD.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(BoundingSphereD)

Determines whether the specified BoundingSphereD is equal to the current BoundingSphereD.

##### Declaration

```
public bool Equals(BoundingSphereD other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | other | The BoundingSphereD to compare with the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetBoundingBox()

##### Declaration

```
public BoundingBoxD GetBoundingBox()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

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

#### Include(BoundingSphereD)

##### Declaration

```
public BoundingSphereD Include(BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### Include(ref BoundingSphereD, ref BoundingSphereD)

##### Declaration

```
public static void Include(ref BoundingSphereD sphere, ref BoundingSphereD otherSphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | otherSphere |     |

#### IntersectRaySphere(RayD, out Double, out Double)

NOTE: This function doesn't calculate the normal because it's easily derived for a sphere (p - center).

##### Declaration

```
public bool IntersectRaySphere(RayD ray, out double tmin, out double tmax)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | ray |     |
| System.Double | tmin |     |
| System.Double | tmax |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(BoundingBoxD)

Checks whether the current BoundingSphereD intersects with a specified BoundingBoxD.

##### Declaration

```
public bool Intersects(BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to check for intersection with the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBoxD, out Boolean)

Checks whether the current BoundingSphereD intersects a BoundingBoxD.

##### Declaration

```
public void Intersects(ref BoundingBoxD box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingSphereD and BoundingBoxD intersect; false otherwise. |

#### Intersects(BoundingFrustumD)

Checks whether the current BoundingSphereD intersects with a specified BoundingFrustum.

##### Declaration

```
public bool Intersects(BoundingFrustumD frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum | The BoundingFrustum to check for intersection with the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(BoundingSphereD)

Checks whether the current BoundingSphereD intersects with a specified BoundingSphereD.

##### Declaration

```
public bool Intersects(BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphereD to check for intersection with the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingSphereD, out Boolean)

Checks whether the current BoundingSphereD intersects another BoundingSphereD.

##### Declaration

```
public void Intersects(ref BoundingSphereD sphere, out bool result)
```
