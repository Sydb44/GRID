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

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T>(ref BoundingFrustum, List<T>, UInt32, Boolean)

##### Declaration

```
public void OverlapAllFrustum<T>(ref BoundingFrustum frustum, List<T> elementsList, uint requiredFlags, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.UInt32 | requiredFlags |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllFrustum<T, Op>(ref BoundingFrustum, ref Op)

##### Declaration

```
public void OverlapAllFrustum<T, Op>(ref BoundingFrustum frustum, ref Op add)
    where Op : struct, IAddOp<T>, ValueType
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |
| Op  | add |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |
| Op  |     |

#### OverlapAllFrustum<T, Op>(ref BoundingFrustum, Single, ref Op)

##### Declaration

```
public void OverlapAllFrustum<T, Op>(ref BoundingFrustum frustum, float tSqr, ref Op add)
    where Op : struct, IAddOp<T>, ValueType
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |
| System.Single | tSqr |     |
| Op  | add |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |
| Op  |     |

#### OverlapAllFrustumAny<T>(ref BoundingFrustum, List<T>, Boolean)

##### Declaration

```
public void OverlapAllFrustumAny<T>(ref BoundingFrustum frustum, List<T> elementsList, bool clear = true)
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

#### OverlapAllFrustumConservative<T>(ref BoundingFrustum, List<T>, UInt32, Boolean)

##### Declaration

```
public void OverlapAllFrustumConservative<T>(ref BoundingFrustum frustum, List<T> elementsList, uint requiredFlags, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingFrustum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingFrustum.html) | frustum |     |
| System.Collections.Generic.List<T> | elementsList |     |
| System.UInt32 | requiredFlags |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllLineSegment<T>(ref Line, List<MyLineSegmentOverlapResult<T>>)

##### Declaration

```
public void OverlapAllLineSegment<T>(ref Line line, List<MyLineSegmentOverlapResult<T>> elementsList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<T>> | elementsList |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapAllLineSegment<T>(ref Line, List<MyLineSegmentOverlapResult<T>>, UInt32)

##### Declaration

```
public void OverlapAllLineSegment<T>(ref Line line, List<MyLineSegmentOverlapResult<T>> elementsList, uint requiredFlags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<T>> | elementsList |     |
| System.UInt32 | requiredFlags |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapsAnyLeafBoundingBox(ref BoundingBox)

##### Declaration

```
public bool OverlapsAnyLeafBoundingBox(ref BoundingBox bbox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | bbox |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OverlapSizeableClusters(ref BoundingBox, List<BoundingBox>, Double)

##### Declaration

```
public void OverlapSizeableClusters(ref BoundingBox bbox, List<BoundingBox> boundList, double minSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | bbox |     |
| System.Collections.Generic.List<[BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html)\> | boundList |     |
| System.Double | minSize |     |

#### Query(Func<Int32, Boolean>, ref BoundingBox)

##### Declaration

```
public void Query(Func<int, bool> callback, ref BoundingBox aabb)
```
