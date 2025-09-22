##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetIncluded(Vector2I)

##### Declaration

```
public BoundingBox2I GetIncluded(Vector2I point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### Include(BoundingBox2I)

##### Declaration

```
public BoundingBox2I Include(BoundingBox2I box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### Include(ref BoundingBox2I)

return expanded aabb (abb include point)

##### Declaration

```
public BoundingBox2I Include(ref BoundingBox2I box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### Include(Vector2I)

##### Declaration

```
public BoundingBox2I Include(Vector2I point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### Include(Vector2I, Vector2I, Vector2I)

##### Declaration

```
public BoundingBox2I Include(Vector2I p0, Vector2I p1, Vector2I p2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | p0  |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | p1  |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | p2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### Include(ref Vector2I)

return expanded aabb (abb include point)

##### Declaration

```
public BoundingBox2I Include(ref Vector2I point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### Include(ref Vector2I, ref Vector2I, ref Vector2I)

##### Declaration

```
public BoundingBox2I Include(ref Vector2I p0, ref Vector2I p1, ref Vector2I p2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | p0  |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | p1  |     |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | p2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### Inflate(Int32)

##### Declaration

```
public void Inflate(int size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | size |     |

#### InflateToMinimum(Vector2I)

##### Declaration

```
public void InflateToMinimum(Vector2I minimumSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html) | minimumSize |     |

#### Intersect(BoundingBox2I)

Returns bounding box which is intersection of this and box It's called 'Prunik' Result is invalid box when there's no intersection (Min > Max)

##### Declaration

```
public BoundingBox2I Intersect(BoundingBox2I box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) |     |

#### Intersects(BoundingBox2I)

Checks whether the current BoundingBox2I intersects another BoundingBox2I.

##### Declaration

```
public bool Intersects(BoundingBox2I box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | box | The BoundingBox2I to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBox2I)

##### Declaration

```
public bool Intersects(ref BoundingBox2I box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2I.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBox2I, out Boolean)

Checks whether the current BoundingBox2I intersects another BoundingBox2I.
