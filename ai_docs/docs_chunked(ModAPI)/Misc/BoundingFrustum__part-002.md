
##### Declaration

```
public void Contains(ref BoundingSphere sphere, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### [](#VRageMath_BoundingFrustum_Contains_VRageMath_Vector3_)Contains(Vector3)

Checks whether the current BoundingFrustum contains the specified point.

##### Declaration

```
public ContainmentType Contains(Vector3 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point | The point to check against the current BoundingFrustum. |

##### Returns

#### [](#VRageMath_BoundingFrustum_Contains_VRageMath_Vector3__VRageMath_ContainmentType__)Contains(ref Vector3, out ContainmentType)

Checks whether the current BoundingFrustum contains the specified point.

##### Declaration

```
public void Contains(ref Vector3 point, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point | The point to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### [](#VRageMath_BoundingFrustum_Equals_System_Object_)Equals(Object)

Determines whether the specified Object is equal to the BoundingFrustum.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current BoundingFrustum. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingFrustum_Equals_VRageMath_BoundingFrustum_)Equals(BoundingFrustum)

Determines whether the specified BoundingFrustum is equal to the current BoundingFrustum.

##### Declaration

```
public bool Equals(BoundingFrustum other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | other | The BoundingFrustum to compare with the current BoundingFrustum. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingFrustum_GetCorners)GetCorners()

Gets an array of points that make up the corners of the BoundingFrustum. ALLOCATION!

##### Declaration

```
public Vector3[] GetCorners()
```

##### Returns

#### [](#VRageMath_BoundingFrustum_GetCorners_VRageMath_Vector3___)GetCorners(Vector3\[\])

Gets an array of points that make up the corners of the BoundingFrustum.

##### Declaration

```
public void GetCorners(Vector3[] corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] | corners | An existing array of at least 8 Vector3 points where the corners of the BoundingFrustum are written. |

#### [](#VRageMath_BoundingFrustum_GetCornersUnsafe_VRageMath_Vector3__)GetCornersUnsafe(Vector3\*)

Gets the array of points that make up the corners of the BoundingBox.

##### Declaration

```
public void GetCornersUnsafe(Vector3*corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\* | corners | An existing array of at least 8 Vector3 points where the corners of the BoundingBox are written. |

#### [](#VRageMath_BoundingFrustum_GetHashCode)GetHashCode()

Gets the hash code for this instance.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_BoundingFrustum_Intersects_VRageMath_BoundingBox_)Intersects(BoundingBox)

Checks whether the current BoundingFrustum intersects the specified BoundingBox.

##### Declaration

```
public bool Intersects(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_BoundingFrustum_Intersects_VRageMath_BoundingBox__System_Boolean__)Intersects(ref BoundingBox, out Boolean)

Checks whether the current BoundingFrustum intersects a BoundingBox.

##### Declaration

```
public void Intersects(ref BoundingBox box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingFrustum and BoundingBox intersect; false otherwise. |

#### [](#VRageMath_BoundingFrustum_Intersects_VRageMath_BoundingFrustum_)Intersects(BoundingFrustum)

Checks whether the current BoundingFrustum intersects the specified BoundingFrustum.

##### Declaration

```
public bool Intersects(BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The BoundingFrustum to check for intersection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
