| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | bbox |     |
| System.Double | minSize |     |
| System.Collections.Generic.List<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | boundList |     |

#### GetAproximateClustersForAabbDebug(ref BoundingBoxD, Double, List<BoundingBoxD>, List<MyTuple<Boolean, Int32, Object>>)

##### Declaration

```
public void GetAproximateClustersForAabbDebug(ref BoundingBoxD bbox, double minSize, List<BoundingBoxD> boundList, List<MyTuple<bool, int, object>> nodeList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | bbox |     |
| System.Double | minSize |     |
| System.Collections.Generic.List<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | boundList |     |
| System.Collections.Generic.List<VRage.MyTuple<System.Boolean, System.Int32, System.Object\>> | nodeList |     |

#### GetChildren(Int32, out Int32, out Int32)

##### Declaration

```
public void GetChildren(int proxyId, out int left, out int right)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId |     |
| System.Int32 | left |     |
| System.Int32 | right |     |

#### GetFatAABB(Int32, out BoundingBoxD)

Get the fat BoundingBox for a proxy.

##### Declaration

```
public void GetFatAABB(int proxyId, out BoundingBoxD fatAABB)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId | The proxy id. |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | fatAABB | The fat BoundingBox. |

#### GetHeight()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetLeafCount(Int32)

##### Declaration

```
public int GetLeafCount(int proxyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetNodeLeaves(Int32, List<Int32>)

##### Declaration

```
public void GetNodeLeaves(int proxyId, List<int> children)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId |     |
| System.Collections.Generic.List<System.Int32\> | children |     |

#### GetRoot()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetUserData<T>(Int32)

Get proxy user data.

##### Declaration

```
public T GetUserData<T>(int proxyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId | The proxy id. |

##### Returns

| Type | Description |
| --- | --- |
| T   | the proxy user data or 0 if the id is invalid. |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### IsRootNull()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MoveProxy(Int32, ref BoundingBoxD, Vector3D)

Move a proxy with a swepted BoundingBox. If the proxy has moved outside of its fattened BoundingBox, then the proxy is removed from the tree and re-inserted. Otherwise the function returns immediately.

##### Declaration

```
public bool MoveProxy(int proxyId, ref BoundingBoxD aabb, Vector3D displacement)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId | The proxy id. |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb | The aabb. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | displacement | Predicted (expected) movement |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if the proxy was re-inserted. |

#### OverlapAllBoundingBox<T>(ref BoundingBoxD, List<T>, UInt32, Boolean)

##### Declaration

```
public void OverlapAllBoundingBox<T>(ref BoundingBoxD bbox, List<T> elementsList, uint requiredFlags = 0U, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | bbox |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.UInt32 | requiredFlags |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllBoundingBox<T>(ref MyOrientedBoundingBoxD, List<T>, UInt32, Boolean)

##### Declaration

```
public void OverlapAllBoundingBox<T>(ref MyOrientedBoundingBoxD obb, List<T> elementsList, uint requiredFlags = 0U, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyOrientedBoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyOrientedBoundingBoxD.html) | obb |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.UInt32 | requiredFlags |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllBoundingSphere<T>(ref BoundingSphereD, Action<T>)

##### Declaration

```
public void OverlapAllBoundingSphere<T>(ref BoundingSphereD sphere, Action<T> addAction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Action<T> | addAction |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllBoundingSphere<T>(ref BoundingSphereD, List<T>, Boolean)

##### Declaration

```
public void OverlapAllBoundingSphere<T>(ref BoundingSphereD sphere, List<T> overlapElementsList, bool clear = true)
```
