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

#### OverlapAllLineSegment<T>(ref LineD, List<MyLineSegmentOverlapResult<T>>, UInt32, Boolean)

##### Declaration

```
public void OverlapAllLineSegment<T>(ref LineD line, List<MyLineSegmentOverlapResult<T>> elementsList, uint requiredFlags, bool clear = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line |     |
| System.Collections.Generic.List<[MyLineSegmentOverlapResult](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyLineSegmentOverlapResult-1.html)<T>> | elementsList |     |
| System.UInt32 | requiredFlags |     |
| System.Boolean | clear |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### OverlapsAnyLeafBoundingBox(ref BoundingBoxD)

##### Declaration

```
public bool OverlapsAnyLeafBoundingBox(ref BoundingBoxD bbox)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | bbox |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Query(Func<Int32, Boolean>, ref BoundingBoxD)

##### Declaration

```
public void Query(Func<int, bool> callback, ref BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.Int32, System.Boolean\> | callback |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |

#### QueryPoint(Func<Int32, Boolean>, ref Vector3D)

##### Declaration

```
public void QueryPoint(Func<int, bool> callback, ref Vector3D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.Int32, System.Boolean\> | callback |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point |     |

#### RemoveProxy(Int32)

Destroy a proxy. This asserts if the id is invalid.

##### Declaration

```
public void RemoveProxy(int proxyId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | proxyId | The proxy id. |