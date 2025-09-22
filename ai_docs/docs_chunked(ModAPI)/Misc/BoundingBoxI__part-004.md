##### Declaration

```
public void Inflate(int size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | size |     |

#### InflateToMinimum(Vector3I)

##### Declaration

```
public void InflateToMinimum(Vector3I minimumSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | minimumSize |     |

#### Intersect(BoundingBoxI)

Returns bounding box which is intersection of this and box  
Result is invalid box when there's no intersection (Min > Max)

##### Declaration

```
public BoundingBoxI Intersect(BoundingBoxI box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Intersects(BoundingBoxI)

Checks whether the current BoundingBoxI intersects another BoundingBoxI.

##### Declaration

```
public bool Intersects(BoundingBoxI box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box | The BoundingBoxI to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBoxI)

##### Declaration

```
public bool Intersects(ref BoundingBoxI box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref BoundingBoxI, out Boolean)

Checks whether the current BoundingBoxI intersects another BoundingBoxI.

##### Declaration

```
public void Intersects(ref BoundingBoxI box, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) | box | The BoundingBoxI to check for intersection with. |
| System.Boolean | result | \[OutAttribute\] true if the BoundingBoxI instances intersect; false otherwise. |

#### Intersects(Line, out Single)

##### Declaration

```
public bool Intersects(Line line, out float distance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line |     |
| System.Single | distance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(Plane)

Checks whether the current BoundingBoxI intersects a Plane.

##### Declaration

```
public PlaneIntersectionType Intersects(Plane plane)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The Plane to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref Plane, out PlaneIntersectionType)

Checks whether the current BoundingBoxI intersects a Plane.

##### Declaration

```
public void Intersects(ref Plane plane, out PlaneIntersectionType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The Plane to check for intersection with. |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) | result | \[OutAttribute\] An enumeration indicating whether the BoundingBoxI intersects the Plane. |

#### Intersects(Ray)

Checks whether the current BoundingBoxI intersects a Ray.

##### Declaration

```
public Nullable<float> Intersects(Ray ray)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray | The Ray to check for intersection with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Intersects(ref Ray, out Nullable<Single>)

Checks whether the current BoundingBoxI intersects a Ray.

##### Declaration

```
public void Intersects(ref Ray ray, out Nullable<float> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray | The Ray to check for intersection with. |
| System.Nullable<System.Single\> | result | \[OutAttribute\] Distance at which the ray intersects the BoundingBoxI, or null if there is no intersection. |

#### IntersectsTriangle(Vector3I, Vector3I, Vector3I)

##### Declaration

```
public bool IntersectsTriangle(Vector3I v0, Vector3I v1, Vector3I v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | v0  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | v1  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | v2  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IntersectsTriangle(ref Vector3I, ref Vector3I, ref Vector3I)

##### Declaration

```
public bool IntersectsTriangle(ref Vector3I v0, ref Vector3I v1, ref Vector3I v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | v0  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | v1  |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | v2  |     |
