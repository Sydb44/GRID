---
title: "Class Vector3I\\_RangeIterator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I_RangeIterator.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3I_RangeIterator"
---

# Class Vector3I\_RangeIterator | Space Engineers ModAPI

A class for simpler traversal of ranges of integer vectors

##### Inheritance

System.Object

Vector3I\_RangeIterator

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector3I_RangeIterator : ValueType
```

### Constructors

#### Vector3I\_RangeIterator(ref Vector3I, ref Vector3I)

Note: both start and end are inclusive

##### Declaration

```
public Vector3I_RangeIterator(ref Vector3I start, ref Vector3I end)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | start |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | end |     |

### Fields

#### Current

Do not modify, public only for optimization!

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

### Methods

#### GetNext(out Vector3I)

##### Declaration

```
public void GetNext(out Vector3I next)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | next |     |

#### IsValid()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MoveNext()

##### Declaration