##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### CreateFromHalfExtent(Vector2, Vector2)

##### Declaration

```
public static BoundingBox2 CreateFromHalfExtent(Vector2 center, Vector2 halfExtent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | center |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | halfExtent |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### CreateFromPoints(IEnumerable<Vector2>)

Creates the smallest BoundingBox2 that will contain a group of points.

##### Declaration

```
public static BoundingBox2 CreateFromPoints(IEnumerable<Vector2> points)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\> | points | A list of points the BoundingBox2 should contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### CreateInvalid()

##### Declaration

```
public static BoundingBox2 CreateInvalid()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### CreateMerged(BoundingBox2, BoundingBox2)

Creates the smallest BoundingBox2 that contains the two specified BoundingBox2 instances.

##### Declaration

```
public static BoundingBox2 CreateMerged(BoundingBox2 original, BoundingBox2 additional)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | original | One of the BoundingBox2s to contain. |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | additional | One of the BoundingBox2s to contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### CreateMerged(ref BoundingBox2, ref BoundingBox2, out BoundingBox2)

Creates the smallest BoundingBox2 that contains the two specified BoundingBox2 instances.

##### Declaration

```
public static void CreateMerged(ref BoundingBox2 original, ref BoundingBox2 additional, out BoundingBox2 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | original | One of the BoundingBox2 instances to contain. |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | additional | One of the BoundingBox2 instances to contain. |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | result | \[OutAttribute\] The created BoundingBox2. |

#### Distance(Vector2)

##### Declaration

```
public float Distance(Vector2 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Equals(Object)

Determines whether two instances of BoundingBox2 are equal.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current BoundingBox2. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(BoundingBox2)

Determines whether two instances of BoundingBox2 are equal.

##### Declaration

```
public bool Equals(BoundingBox2 other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | other | The BoundingBox2 to compare with the current BoundingBox2. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCorners()

Gets an array of points that make up the corners of the BoundingBox2.

##### Declaration

```
public Vector2[] GetCorners()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\] |     |

#### GetCorners(Vector2\[\])

Gets the array of points that make up the corners of the BoundingBox2.

##### Declaration

```
public void GetCorners(Vector2[] corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\[\] | corners | An existing array of at least 8 Vector2 points where the corners of the BoundingBox2 are written. |

#### GetCornersUnsafe(Vector2\*)

Gets the array of points that make up the corners of the BoundingBox2.

##### Declaration

```
public void GetCornersUnsafe(Vector2*corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)\* | corners | An existing array of at least 8 Vector2 points where the corners of the BoundingBox2 are written. |

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
