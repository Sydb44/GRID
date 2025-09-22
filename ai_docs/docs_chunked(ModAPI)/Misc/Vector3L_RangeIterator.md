---
title: "Class Vector3L\\_RangeIterator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L_RangeIterator.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3L_RangeIterator"
---

# Class Vector3L\_RangeIterator | Space Engineers ModAPI

A class for simpler traversal of ranges of long vectors

##### Inheritance

System.Object

Vector3L\_RangeIterator

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector3L_RangeIterator : ValueType
```

### Constructors

#### Vector3L\_RangeIterator(ref Vector3L, ref Vector3L)

Note: both start and end are inclusive

##### Declaration

```
public Vector3L_RangeIterator(ref Vector3L start, ref Vector3L end)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html) | start |     |
| [Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html) | end |     |

### Fields

#### Current

Do not modify, public only for optimization!

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html) |     |

### Methods

#### GetNext(out Vector3L)

##### Declaration

```
public void GetNext(out Vector3L next)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html) | next |     |

#### IsValid()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MoveNext()

##### Declaration