##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllBoundingSphere<T>(ref BoundingSphereD, List<T>, Boolean)

##### Declaration

```
public void OverlapAllBoundingSphere<T>(ref BoundingSphereD sphere, List<T> overlapElementsList, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<T> | overlapElementsList |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustumD, T)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustumD frustum, T results)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |
| T   | results |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustumD, T, Single)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustumD frustum, T results, float tSqr)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |
| T   | results |     |
| System.Single | tSqr |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustumD, Action<T, Boolean>, Single)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustumD frustum, Action<T, bool> add, float tSqr)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |
| System.Action<T, System.Boolean\> | add |     |
| System.Single | tSqr |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustumD, List<T>, Boolean)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustumD frustum, List<T> elementsList, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustumD, List<T>, List<Boolean>)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustumD frustum, List<T> elementsList, List<bool> isInsideList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.Collections.Generic.List<System.Boolean\> | isInsideList |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustumD, List<T>, List<Boolean>, Single, Boolean)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustumD frustum, List<T> elementsList, List<bool> isInsideList, float tSqr, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.Collections.Generic.List<System.Boolean\> | isInsideList |     |
| System.Single | tSqr |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustumD, List<T>, UInt32, Boolean)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustumD frustum, List<T> elementsList, uint requiredFlags, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.UInt32 | requiredFlags |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustumAny<T>(ref BoundingFrustumD, List<T>, Boolean)

##### Declaration

```
public void OverlapAllFrustumAny<T>(ref BoundingFrustumD frustum, List<T> elementsList, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustumD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustumD.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllLineSegment<T>(ref LineD, List<MyLineSegmentOverlapResult<T>>, Boolean)

##### Declaration

```
public void OverlapAllLineSegment<T>(ref LineD line, List<MyLineSegmentOverlapResult<T>> elementsList, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<T>> | elementsList |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |
