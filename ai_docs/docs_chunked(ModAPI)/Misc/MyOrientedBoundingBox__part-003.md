
| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | boundingBox |     |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyOrientedBoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBox.html) |     |

#### CreateFromBoundingBox(BoundingBox)

##### Declaration

```
public static MyOrientedBoundingBox CreateFromBoundingBox(BoundingBox box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyOrientedBoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBox.html) |     |

#### Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(MyOrientedBoundingBox)

##### Declaration

```
public bool Equals(MyOrientedBoundingBox other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBox.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetAABB()

##### Declaration

```
public BoundingBox GetAABB()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### GetCorners(Vector3\[\], Int32)

##### Declaration

```
public void GetCorners(Vector3[] corners, int startIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] | corners |     |
| System.Int32 | startIndex |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetNormalBetweenEdges(Int32, Int32, Int32, out Vector3)

Returns normal between two cube edge of same direction

##### Declaration

```
public static bool GetNormalBetweenEdges(int axis, int edge0, int edge1, out Vector3 normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | axis | Edge direction axis (0 = X, 1 = Y, 2 = Z) |
| System.Int32 | edge0 |     |
| System.Int32 | edge1 |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | false if edges are not neighbors |

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

#### Intersects(BoundingFrustum)

##### Declaration

```
public bool Intersects(BoundingFrustum frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |

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

#### Intersects(ref Line)

##### Declaration

```
public Nullable<float> Intersects(ref Line line)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### Intersects(ref MyOrientedBoundingBox)

##### Declaration

```
public bool Intersects(ref MyOrientedBoundingBox other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBox.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(ref Plane)

##### Declaration

```
public PlaneIntersectionType Intersects(ref Plane plane)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Plane](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html) | plane |     |

##### Returns

| Type | Description |
| --- | --- |
| [PlaneIntersectionType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneIntersectionType.html) |     |

#### Intersects(ref Ray)

##### Declaration

```
public Nullable<float> Intersects(ref Ray ray)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |
