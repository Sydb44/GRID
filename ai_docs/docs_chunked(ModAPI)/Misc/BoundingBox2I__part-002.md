
| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | center |     |
| System.Int32 | halfExtent |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### CreateFromHalfExtent(Vector2I, Vector2I)

##### Declaration

```
public static BoundingBox2I CreateFromHalfExtent(Vector2I center, Vector2I halfExtent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | center |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | halfExtent |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### CreateFromPoints(IEnumerable<Vector2I>)

Creates the smallest BoundingBox2I that will contain a group of points.

##### Declaration

```
public static BoundingBox2I CreateFromPoints(IEnumerable<Vector2I> points)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)\> | points | A list of points the BoundingBox2I should contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### CreateInvalid()

##### Declaration

```
public static BoundingBox2I CreateInvalid()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### CreateMerged(BoundingBox2I, BoundingBox2I)

Creates the smallest BoundingBox2I that contains the two specified BoundingBox2I instances.

##### Declaration

```
public static BoundingBox2I CreateMerged(BoundingBox2I original, BoundingBox2I additional)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | original | One of the BoundingBox2Is to contain. |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | additional | One of the BoundingBox2Is to contain. |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### CreateMerged(ref BoundingBox2I, ref BoundingBox2I, out BoundingBox2I)

Creates the smallest BoundingBox2I that contains the two specified BoundingBox2I instances.

##### Declaration

```
public static void CreateMerged(ref BoundingBox2I original, ref BoundingBox2I additional, out BoundingBox2I result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | original | One of the BoundingBox2I instances to contain. |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | additional | One of the BoundingBox2I instances to contain. |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | result | \[OutAttribute\] The created BoundingBox2I. |

#### Equals(Object)

Determines whether two instances of BoundingBox2I are equal.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The Object to compare with the current BoundingBox2I. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(BoundingBox2I)

Determines whether two instances of BoundingBox2I are equal.

##### Declaration

```
public bool Equals(BoundingBox2I other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | other | The BoundingBox2I to compare with the current BoundingBox2I. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCorners()

Gets an array of points that make up the corners of the BoundingBox2I.

##### Declaration

```
public Vector2I[] GetCorners()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)\[\] |     |

#### GetCorners(Vector2I\[\])

Gets the array of points that make up the corners of the BoundingBox2I.

##### Declaration

```
public void GetCorners(Vector2I[] corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)\[\] | corners | An existing array of at least 8 Vector2I points where the corners of the BoundingBox2I are written. |

#### GetCornersUnsafe(Vector2I\*)

Gets the array of points that make up the corners of the BoundingBox2I.

##### Declaration

```
public void GetCornersUnsafe(Vector2I*corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)\* | corners | An existing array of at least 8 Vector2I points where the corners of the BoundingBox2I are written. |

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

#### GetIncluded(Vector2I)

##### Declaration

```
public BoundingBox2I GetIncluded(Vector2I point)
```
