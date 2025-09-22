##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetLeafCount()

##### Declaration

```
public int GetLeafCount()
```

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

#### MoveProxy(Int32, ref BoundingBox, Vector3)

Move a proxy with a swepted BoundingBox. If the proxy has moved outside of its fattened BoundingBox, then the proxy is removed from the tree and re-inserted. Otherwise the function returns immediately.

##### Declaration

```
public bool MoveProxy(int proxyId, ref BoundingBox aabb, Vector3 displacement)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId | The proxy id. |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | aabb | The aabb. |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | displacement | The displacement. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if the proxy was re-inserted. |

#### OverlapAllBoundingBox<T>(ref BoundingBox, List<T>, UInt32, Boolean)

##### Declaration

```
public void OverlapAllBoundingBox<T>(ref BoundingBox bbox, List<T> elementsList, uint requiredFlags = 0U, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | bbox |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.UInt32 | requiredFlags |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllBoundingSphere<T>(ref BoundingSphere, List<T>, Boolean)

##### Declaration

```
public void OverlapAllBoundingSphere<T>(ref BoundingSphere sphere, List<T> overlapElementsList, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphere.html) | sphere |     |
| System.Collections.Generic.List<T> | overlapElementsList |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustum, Action<T, Boolean>)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, Action<T, bool> add)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |
| System.Action<T, System.Boolean\> | add |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustum, Action<T, Boolean>, Single)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, Action<T, bool> add, float tSqr)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |
| System.Action<T, System.Boolean\> | add |     |
| System.Single | tSqr |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustum, List<T>, Boolean)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, List<T> elementsList, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustum, List<T>, List<Boolean>, Boolean)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, List<T> elementsList, List<bool> isInsideList, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.Collections.Generic.List<System.Boolean\> | isInsideList |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustum, List<T>, List<Boolean>, Single, Boolean)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, List<T> elementsList, List<bool> isInsideList, float tSqr, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.Collections.Generic.List<System.Boolean\> | isInsideList |     |
| System.Single | tSqr |     |
| System.Boolean | clear |     |
