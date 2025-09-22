---
title: "Class ConcurrentNormalAggregator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.ConcurrentNormalAggregator.html"
category: "Misc"
namespace: "VRage.Utils"
class: "ConcurrentNormalAggregator"
---

# Class ConcurrentNormalAggregator | Space Engineers ModAPI

##### Inheritance

System.Object

ConcurrentNormalAggregator

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class ConcurrentNormalAggregator : Object
```

### Constructors

#### ConcurrentNormalAggregator(Int32)

##### Declaration

```
public ConcurrentNormalAggregator(int averageWindowSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | averageWindowSize |     |

### Methods

#### Clear()

Allowed to be called only from one thread at the time! It's not safe to call [GetAvgNormal(out Vector3)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.ConcurrentNormalAggregator.html#VRage_Utils_ConcurrentNormalAggregator_GetAvgNormal_VRageMath_Vector3__) method in parallel!

##### Declaration

#### GetAvgNormal(out Vector3)

Consumption is allowed only from one thread at the time! It's not safe to call [Clear()](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.ConcurrentNormalAggregator.html#VRage_Utils_ConcurrentNormalAggregator_Clear) method in parallel!

##### Declaration

```
public bool GetAvgNormal(out Vector3 normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetAvgNormalCached(out Vector3)

##### Declaration

```
public bool GetAvgNormalCached(out Vector3 normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PushNext(ref Vector3)

Might be safely called from multiple threads at the same time.

##### Declaration

```
public void PushNext(ref Vector3 normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal |     |