| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] |     |

#### GetCorners(Vector3\[\])

Gets the array of points that make up the corners of the BoundingBox.

##### Declaration

```
public void GetCorners(Vector3[] corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] | corners | An existing array of at least 8 Vector3 points where the corners of the BoundingBox are written. |

#### GetCornersUnsafe(Vector3\*)

Gets the array of points that make up the corners of the BoundingBox.

##### Declaration

```
public void GetCornersUnsafe(Vector3*corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\* | corners | An existing array of at least 8 Vector3 points where the corners of the BoundingBox are written. |

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

#### GetIncluded(Vector3)

##### Declaration

```
public BoundingBox GetIncluded(Vector3 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(BoundingBox)

##### Declaration

```
public BoundingBox Include(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(ref BoundingBox)

return expanded aabb (aabb include aabb)

##### Declaration

```
public BoundingBox Include(ref BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(ref BoundingFrustum)

##### Declaration

```
public BoundingBox Include(ref BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(BoundingSphere)

##### Declaration

```
public BoundingBox Include(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(ref BoundingSphere)

##### Declaration

```
public BoundingBox Include(ref BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(ref Line)

##### Declaration

```
public void Include(ref Line line)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line |     |

#### Include(Vector3)

##### Declaration

```
public BoundingBox Include(Vector3 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(Vector3, Vector3, Vector3)

##### Declaration

```
public BoundingBox Include(Vector3 p0, Vector3 p1, Vector3 p2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p0  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p1  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(ref Vector3)

return expanded aabb (aabb include point)

##### Declaration

```
public BoundingBox Include(ref Vector3 point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(ref Vector3, ref Vector3, ref Vector3)
