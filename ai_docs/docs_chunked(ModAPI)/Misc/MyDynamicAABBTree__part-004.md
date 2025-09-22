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

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<System.Int32, System.Boolean\> | callback |     |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | aabb |     |

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