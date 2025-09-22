
##### Declaration

```
public void Contains(ref Vector3I point, out ContainmentType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | point | The point to test for overlap. |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | result | \[OutAttribute\] Enumeration indicating the extent of overlap. |

#### CreateFromPoints(IEnumerable<Vector3I>)

Creates the smallest BoundingBoxI that will contain a group of points.

##### Declaration

```
public static BoundingBoxI CreateFromPoints(IEnumerable<Vector3I> points)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\> | points | A list of points the BoundingBoxI should contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### CreateFromSphere(BoundingSphere)

Creates the smallest BoundingBoxI that will contain the specified BoundingSphere.

##### Declaration

```
public static BoundingBoxI CreateFromSphere(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### CreateFromSphere(ref BoundingSphere, out BoundingBoxI)

Creates the smallest BoundingBoxI that will contain the specified BoundingSphere.

##### Declaration

```
public static void CreateFromSphere(ref BoundingSphere sphere, out BoundingBoxI result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to contain. |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | result | \[OutAttribute\] The created BoundingBoxI. |

#### CreateInvalid()

##### Declaration

```
public static BoundingBoxI CreateInvalid()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### CreateMerged(BoundingBoxI, BoundingBoxI)

Creates the smallest BoundingBoxI that contains the two specified BoundingBoxI instances.

##### Declaration

```
public static BoundingBoxI CreateMerged(BoundingBoxI original, BoundingBoxI additional)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | original | One of the BoundingBoxIs to contain. |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | additional | One of the BoundingBoxIs to contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### CreateMerged(ref BoundingBoxI, ref BoundingBoxI, out BoundingBoxI)

Creates the smallest BoundingBoxI that contains the two specified BoundingBoxI instances.

##### Declaration

```
public static void CreateMerged(ref BoundingBoxI original, ref BoundingBoxI additional, out BoundingBoxI result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | original | One of the BoundingBoxI instances to contain. |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | additional | One of the BoundingBoxI instances to contain. |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | result | \[OutAttribute\] The created BoundingBoxI. |

#### Distance(Vector3I)

##### Declaration

```
public float Distance(Vector3I point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### EnumeratePoints(BoundingBoxI)

Enumerate all values in a integer interval (a cuboid).

This method is an allocating version of the Vector3I\_RangeIterator. This once can be used in the foreach syntax though so it's more convenient for debug routines.

##### Declaration

```
public static IEnumerable<Vector3I> EnumeratePoints(BoundingBoxI rangeInclusive)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | rangeInclusive |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\> | An iterator for that range. |

#### Equals(Object)

Determines whether two instances of BoundingBoxI are equal.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current BoundingBoxI. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(BoundingBoxI)

Determines whether two instances of BoundingBoxI are equal.

##### Declaration

```
public bool Equals(BoundingBoxI other)
```
