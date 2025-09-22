#### Intersects(ref BoundingSphereD)

##### Declaration

```
public bool Intersects(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

Checks whether the current BoundingBox intersects a Plane.

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

Checks whether the current BoundingBox intersects a Plane.

##### Declaration

```
public void Intersects(ref Plane plane, out PlaneIntersectionType result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane | The Plane to check for intersection with. |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) | result | \[OutAttribute\] An enumeration indicating whether the BoundingBox intersects the Plane. |

#### Intersects(Ray)

Checks whether the current BoundingBox intersects a Ray.

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

Checks whether the current BoundingBox intersects a Ray.

##### Declaration

```
public void Intersects(ref Ray ray, out Nullable<float> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray | The Ray to check for intersection with. |
| System.Nullable<System.Single\> | result | \[OutAttribute\] Distance at which the ray intersects the BoundingBox, or null if there is no intersection. |

#### IntersectsTriangle(Vector3, Vector3, Vector3)

##### Declaration

```
public bool IntersectsTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v0  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v1  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v2  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IntersectsTriangle(ref Vector3, ref Vector3, ref Vector3)

##### Declaration

```
public bool IntersectsTriangle(ref Vector3 v0, ref Vector3 v1, ref Vector3 v2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v0  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v1  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v2  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsBetween(Single, Single, Single)

##### Declaration

```
public static bool IsBetween(float number, float min, float max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | number |     |
| System.Single | min |     |
| System.Single | max |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ProjectedArea(Vector3)

##### Declaration

```
public float ProjectedArea(Vector3 viewDir)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | viewDir |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Round()

##### Declaration

```
public BoundingBoxI Round()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxI.html) |     |

#### Round(Int32)

##### Declaration

```
public BoundingBox Round(int decimals)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | decimals |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### Scale(Vector3)

##### Declaration

```
public void Scale(Vector3 scale)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | scale |     |

#### SurfaceArea()

##### Declaration

```
public float SurfaceArea()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |
