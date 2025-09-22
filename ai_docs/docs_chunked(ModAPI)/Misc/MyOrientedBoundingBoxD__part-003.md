##### Declaration

```
public static ContainmentType ContainsRelativeBox(ref Vector3D hA, ref Vector3D hB, ref MatrixD mB)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | hA  |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | hB  |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | mB  |     |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) |     |

#### ConvertToFrustum()

##### Declaration

```
public BoundingFrustumD ConvertToFrustum()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) |     |

#### Create(BoundingBoxD, MatrixD)

##### Declaration

```
public static MyOrientedBoundingBoxD Create(BoundingBoxD boundingBox, MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) |     |

#### CreateFromBoundingBox(BoundingBoxD)

##### Declaration

```
public static MyOrientedBoundingBoxD CreateFromBoundingBox(BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) |     |

#### Distance(RayD)

##### Declaration

```
public float Distance(RayD ray)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | ray |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

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

#### Equals(MyOrientedBoundingBoxD)

##### Declaration

```
public bool Equals(MyOrientedBoundingBoxD other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetAABB()

##### Declaration

```
public BoundingBoxD GetAABB()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### GetCorner(Int32)

Gets corner of the BB by index

##### Declaration

```
public Vector3D GetCorner(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | index of the corner |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | corner position |

#### GetCorners(Vector3D\[\], Int32)

##### Declaration

```
public void GetCorners(Vector3D[] corners, int startIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\] | corners |     |
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

#### Intersects(ref BoundingBoxD)

##### Declaration

```
public bool Intersects(ref BoundingBoxD box)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | box |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersects(BoundingFrustumD)

##### Declaration

```
public bool Intersects(BoundingFrustumD frustum)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |
