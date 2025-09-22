| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(BoundingBoxI)

Determines whether two instances of BoundingBoxI are equal.

##### Declaration

```
public bool Equals(BoundingBoxI other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | other | The BoundingBoxI to compare with the current BoundingBoxI. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCorners()

Gets an array of points that make up the corners of the BoundingBoxI.

##### Declaration

```
public Vector3I[] GetCorners()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\[\] |     |

#### GetCorners(Vector3I\[\])

Gets the array of points that make up the corners of the BoundingBoxI.

##### Declaration

```
public void GetCorners(Vector3I[] corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\[\] | corners | An existing array of at least 8 Vector3I points where the corners of the BoundingBoxI are written. |

#### GetCornersUnsafe(Vector3I\*)

Gets the array of points that make up the corners of the BoundingBoxI.

##### Declaration

```
public void GetCornersUnsafe(Vector3I*corners)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\* | corners | An existing array of at least 8 Vector3I points where the corners of the BoundingBoxI are written. |

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

#### GetIncluded(Vector3I)

##### Declaration

```
public BoundingBoxI GetIncluded(Vector3I point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Include(BoundingBoxI)

##### Declaration

```
public BoundingBoxI Include(BoundingBoxI box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Include(ref BoundingBoxI)

return expanded aabb (abb include point)

##### Declaration

```
public BoundingBoxI Include(ref BoundingBoxI box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Include(Vector3I)

##### Declaration

```
public BoundingBoxI Include(Vector3I point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Include(Vector3I, Vector3I, Vector3I)

##### Declaration

```
public BoundingBoxI Include(Vector3I p0, Vector3I p1, Vector3I p2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p0  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p1  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Include(ref Vector3I)

return expanded aabb (abb include point)

##### Declaration

```
public BoundingBoxI Include(ref Vector3I point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Include(ref Vector3I, ref Vector3I, ref Vector3I)

##### Declaration

```
public BoundingBoxI Include(ref Vector3I p0, ref Vector3I p1, ref Vector3I p2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p0  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p1  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | p2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Inflate(Int32)

##### Declaration

```
public void Inflate(int size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | size |     |

#### InflateToMinimum(Vector3I)
