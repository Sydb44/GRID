Checks whether the current BoundingFrustumD contains the specified BoundingSphere.

##### Declaration

```
public ContainmentType Contains(BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphere to check against the current BoundingFrustumD. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref BoundingSphereD, out ContainmentType)

Checks whether the current BoundingFrustumD contains the specified BoundingSphere.

##### Declaration

```
public void Contains(ref BoundingSphereD sphere, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | The BoundingSphere to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(Vector3D)

Checks whether the current BoundingFrustumD contains the specified point.

##### Declaration

```
public ContainmentType Contains(Vector3D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point | The point to check against the current BoundingFrustumD. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref Vector3D, out ContainmentType)

Checks whether the current BoundingFrustumD contains the specified point.

##### Declaration

```
public void Contains(ref Vector3D point, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point | The point to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Equals(Object)

Determines whether the specified Object is equal to the BoundingFrustumD.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current BoundingFrustumD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(BoundingFrustumD)

Determines whether the specified BoundingFrustumD is equal to the current BoundingFrustumD.

##### Declaration

```
public bool Equals(BoundingFrustumD other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | other | The BoundingFrustumD to compare with the current BoundingFrustumD. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCorners()

Gets an array of points that make up the corners of the BoundingFrustumD. ALLOCATION!

##### Declaration

```
public Vector3D[] GetCorners()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\] |     |

#### GetCorners(Vector3D\[\])

Gets an array of points that make up the corners of the BoundingFrustumD.

##### Declaration

```
public void GetCorners(Vector3D[] corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\] | corners | An existing array of at least 8 Vector3D points where the corners of the BoundingFrustumD are written. |

#### GetCornersUnsafe(Vector3D\*)

Gets the array of points that make up the corners of the BoundingBox.

##### Declaration

```
public void GetCornersUnsafe(Vector3D*corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\* | corners | An existing array of at least 8 Vector3 points where the corners of the BoundingBox are written. |

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

Checks whether the current BoundingFrustumD intersects the specified BoundingBoxD.

##### Declaration

```
public bool Intersects(BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBoxD, out Boolean)

Checks whether the current BoundingFrustumD intersects a BoundingBoxD.

##### Declaration

```
public void Intersects(ref BoundingBoxD box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingFrustumD and BoundingBoxD intersect; false otherwise. |

#### Intersects(BoundingFrustumD)

Checks whether the current BoundingFrustumD intersects the specified BoundingFrustumD.
