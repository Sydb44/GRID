---
title: "Class MyUtils.ClearCollectionToken<TCollection, TElement>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyUtils.ClearCollectionToken-2.html"
category: "Misc"
namespace: "VRage.Utils.MyUtils"
class: "ClearCollectionToken-2"
---

# Class MyUtils.ClearCollectionToken<TCollection, TElement> | Space Engineers ModAPI

##### Inheritance

System.Object

MyUtils.ClearCollectionToken<TCollection, TElement>

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public sealed class ClearCollectionToken<TCollection, TElement> : ValueType, IDisposable where TCollection : class, ICollection<TElement>, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TCollection |     |
| TElement |     |

### Constructors

#### ClearCollectionToken(TCollection)

##### Declaration

```
public ClearCollectionToken(TCollection collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TCollection | collection |     |

### Fields

#### Collection

##### Declaration

```
public readonly TCollection Collection
```

##### Field Value

| Type | Description |
| --- | --- |
| TCollection |     |

### Methods

#### Dispose()

##### Declaration