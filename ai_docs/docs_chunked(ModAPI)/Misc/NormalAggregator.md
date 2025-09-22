---
title: "Class NormalAggregator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.NormalAggregator.html"
category: "Misc"
namespace: "VRage.Utils"
class: "NormalAggregator"
---

# Class NormalAggregator | Space Engineers ModAPI

##### Inheritance

System.Object

NormalAggregator

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public class NormalAggregator : Object
```

### Constructors

#### NormalAggregator(Int32)

##### Declaration

```
public NormalAggregator(int averageWindowSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | averageWindowSize |     |

### Methods

#### Clear()

##### Declaration

#### GetAvgNormal(out Vector3)

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

#### PushNext(ref Vector3)

##### Declaration

```
public void PushNext(ref Vector3 normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal |     |