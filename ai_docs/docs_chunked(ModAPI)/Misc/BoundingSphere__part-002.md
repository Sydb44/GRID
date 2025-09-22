Creates the smallest BoundingSphere that can contain a specified BoundingBox.

##### Declaration

```
public static BoundingSphere CreateFromBoundingBox(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to create the BoundingSphere from. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### CreateFromBoundingBox(ref BoundingBox, out BoundingSphere)

Creates the smallest BoundingSphere that can contain a specified BoundingBox.

##### Declaration

```
public static void CreateFromBoundingBox(ref BoundingBox box, out BoundingSphere result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to create the BoundingSphere from. |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | result | \[OutAttribute\] The created BoundingSphere. |

#### CreateFromFrustum(BoundingFrustum)

Creates the smallest BoundingSphere that can contain a specified BoundingFrustum.

##### Declaration

```
public static BoundingSphere CreateFromFrustum(BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The BoundingFrustum to create the BoundingSphere with. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### CreateFromPoints(IEnumerable<Vector3>)

Creates a BoundingSphere that can contain a specified list of points.

##### Declaration

```
public static BoundingSphere CreateFromPoints(IEnumerable<Vector3> points)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> | points | List of points the BoundingSphere must contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### CreateInvalid()

##### Declaration

```
public static BoundingSphere CreateInvalid()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### CreateMerged(BoundingSphere, BoundingSphere)

Creates a BoundingSphere that contains the two specified BoundingSphere instances.

##### Declaration

```
public static BoundingSphere CreateMerged(BoundingSphere original, BoundingSphere additional)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | original | BoundingSphere to be merged. |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | additional | BoundingSphere to be merged. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) |     |

#### CreateMerged(ref BoundingSphere, ref BoundingSphere, out BoundingSphere)

Creates a BoundingSphere that contains the two specified BoundingSphere instances.

##### Declaration

```
public static void CreateMerged(ref BoundingSphere original, ref BoundingSphere additional, out BoundingSphere result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | original | BoundingSphere to be merged. |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | additional | BoundingSphere to be merged. |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | result | \[OutAttribute\] The created BoundingSphere. |

#### Equals(Object)

Determines whether the specified Object is equal to the BoundingSphere.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(BoundingSphere)

Determines whether the specified BoundingSphere is equal to the current BoundingSphere.

##### Declaration

```
public bool Equals(BoundingSphere other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | other | The BoundingSphere to compare with the current BoundingSphere. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetBoundingBox()

##### Declaration

```
public BoundingBox GetBoundingBox()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

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

#### Include(BoundingSphere)

##### Declaration

```
public BoundingSphere Include(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere |     |
