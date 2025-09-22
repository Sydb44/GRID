---
title: "Class MyUtils.ClearRangeToken<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearRangeToken-1.html"
category: "Misc"
namespace: "VRage.Utils.MyUtils"
class: "ClearRangeToken-1"
---

# Class MyUtils.ClearRangeToken<T> | Space Engineers ModAPI

##### Inheritance

System.Object

MyUtils.ClearRangeToken<T>

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public sealed class ClearRangeToken<T> : ValueType, IDisposable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### ClearRangeToken(List<T>)

##### Declaration

```
public ClearRangeToken(List<T> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<T> | collection |     |

### Fields

#### Begin

##### Declaration

```
public readonly int Begin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Collection

##### Declaration

```
public readonly List<T> Collection
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<T> |     |

### Methods

#### Add(T)

##### Declaration

```
public void Add(T element)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | element |     |

#### Dispose()

##### Declaration

#### GetEnumerator()

##### Declaration

```
public MyUtils.ClearRangeToken<T>.OffsetEnumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyUtils.ClearRangeToken.OffsetEnumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearRangeToken-1.OffsetEnumerator.html)<> |     |