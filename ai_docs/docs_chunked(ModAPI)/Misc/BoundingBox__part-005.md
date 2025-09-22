##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Include(ref Vector3, ref Vector3, ref Vector3)

##### Declaration

```
public BoundingBox Include(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2)
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

#### Inflate(Single)

##### Declaration

```
public void Inflate(float size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | size |     |

#### Inflate(Vector3)

##### Declaration

```
public void Inflate(Vector3 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | size |     |

#### InflateToMinimum(Vector3)

##### Declaration

```
public void InflateToMinimum(Vector3 minimumSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | minimumSize |     |

#### Intersect(BoundingBox)

Returns bounding box which is intersection of this and box  
Result is invalid box when there's no intersection (Min > Max)

##### Declaration

```
public BoundingBox Intersect(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Intersects(BoundingBox)

Checks whether the current BoundingBox intersects another BoundingBox.

##### Declaration

```
public bool Intersects(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBox)

##### Declaration

```
public bool Intersects(ref BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBox, out Boolean)

Checks whether the current BoundingBox intersects another BoundingBox.

##### Declaration

```
public void Intersects(ref BoundingBox box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | The BoundingBox to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingBox instances intersect; false otherwise. |

#### Intersects(BoundingFrustum)

Checks whether the current BoundingBox intersects a BoundingFrustum.

##### Declaration

```
public bool Intersects(BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum | The BoundingFrustum to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(BoundingSphere)

Checks whether the current BoundingBox intersects a BoundingSphere.

##### Declaration

```
public bool Intersects(BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingSphere)

##### Declaration

```
public bool Intersects(ref BoundingSphere sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingSphere, out Boolean)

Checks whether the current BoundingBox intersects a BoundingSphere.

##### Declaration

```
public void Intersects(ref BoundingSphere sphere, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere | The BoundingSphere to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingBox and BoundingSphere intersect; false otherwise. |

#### Intersects(ref BoundingSphereD)

##### Declaration

```
public bool Intersects(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
