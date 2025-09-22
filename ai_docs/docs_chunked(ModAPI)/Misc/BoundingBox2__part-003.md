Gets the hash code for this instance.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetIncluded(Vector2)

##### Declaration

```
public BoundingBox2 GetIncluded(Vector2 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### Include(BoundingBox2)

##### Declaration

```
public BoundingBox2 Include(BoundingBox2 box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### Include(ref BoundingBox2)

return expanded aabb (abb include point)

##### Declaration

```
public BoundingBox2 Include(ref BoundingBox2 box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### Include(Vector2)

##### Declaration

```
public BoundingBox2 Include(Vector2 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### Include(Vector2, Vector2, Vector2)

##### Declaration

```
public BoundingBox2 Include(Vector2 p0, Vector2 p1, Vector2 p2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | p0  |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | p1  |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | p2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### Include(ref Vector2)

return expanded aabb (abb include point)

##### Declaration

```
public BoundingBox2 Include(ref Vector2 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### Include(ref Vector2, ref Vector2, ref Vector2)

##### Declaration

```
public BoundingBox2 Include(ref Vector2 p0, ref Vector2 p1, ref Vector2 p2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | p0  |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | p1  |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | p2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### Inflate(Single)

##### Declaration

```
public void Inflate(float size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | size |     |

#### InflateToMinimum(Vector2)

##### Declaration

```
public void InflateToMinimum(Vector2 minimumSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | minimumSize |     |

#### Intersect(BoundingBox2)

Returns bounding box which is intersection of this and box  
Result is invalid box when there's no intersection (Min > Max)

##### Declaration

```
public BoundingBox2 Intersect(BoundingBox2 box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) |     |

#### Intersects(BoundingBox2)

Checks whether the current BoundingBox2 intersects another BoundingBox2.

##### Declaration

```
public bool Intersects(BoundingBox2 box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | box | The BoundingBox2 to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBox2)

##### Declaration

```
public bool Intersects(ref BoundingBox2 box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox2.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBox2, out Boolean)

Checks whether the current BoundingBox2 intersects another BoundingBox2.
