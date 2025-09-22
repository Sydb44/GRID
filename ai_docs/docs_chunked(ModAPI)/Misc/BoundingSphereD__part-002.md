public void Contains(ref MyOrientedBoundingBoxD obox, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | obox | The MyOrientedBoundingBoxD to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### Contains(Vector3D)

Checks whether the current BoundingSphereD contains the specified point.

##### Declaration

```
public ContainmentType Contains(Vector3D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point | The point to check against the current BoundingSphereD. |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### Contains(ref Vector3D, out ContainmentType)

Checks whether the current BoundingSphereD contains the specified point.

##### Declaration

```
public void Contains(ref Vector3D point, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point | The point to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### CreateFromBoundingBox(BoundingBoxD)

Creates the smallest BoundingSphereD that can contain a specified BoundingBoxD.

##### Declaration

```
public static BoundingSphereD CreateFromBoundingBox(BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to create the BoundingSphereD from. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### CreateFromBoundingBox(ref BoundingBoxD, out BoundingSphereD)

Creates the smallest BoundingSphereD that can contain a specified BoundingBoxD.

##### Declaration

```
public static void CreateFromBoundingBox(ref BoundingBoxD box, out BoundingSphereD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box | The BoundingBoxD to create the BoundingSphereD from. |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | result | \[OutAttribute\] The created BoundingSphereD. |

#### CreateFromFrustum(BoundingFrustumD)

Creates the smallest BoundingSphereD that can contain a specified BoundingFrustum.

##### Declaration

```
public static BoundingSphereD CreateFromFrustum(BoundingFrustumD frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum | The BoundingFrustum to create the BoundingSphereD with. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### CreateFromPoints(Vector3D\[\])

Creates a BoundingSphereD that can contain a specified list of points.

##### Declaration

```
public static BoundingSphereD CreateFromPoints(Vector3D[] points)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\] | points | List of points the BoundingSphereD must contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### CreateInvalid()

##### Declaration

```
public static BoundingSphereD CreateInvalid()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### CreateMerged(BoundingSphereD, BoundingSphereD)

Creates a BoundingSphereD that contains the two specified BoundingSphereD instances.

##### Declaration

```
public static BoundingSphereD CreateMerged(BoundingSphereD original, BoundingSphereD additional)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | original | BoundingSphereD to be merged. |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | additional | BoundingSphereD to be merged. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### CreateMerged(ref BoundingSphereD, ref BoundingSphereD, out BoundingSphereD)

Creates a BoundingSphereD that contains the two specified BoundingSphereD instances.

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
