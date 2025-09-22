---
title: "Class MyConcurrentCollectionPool<TCollection, TItem>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentCollectionPool-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentCollectionPool-2"
---

# Class MyConcurrentCollectionPool<TCollection, TItem> | Space Engineers ModAPI

##### Inheritance

System.Object

MyConcurrentCollectionPool<TCollection, TItem>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentCollectionPool<TCollection, TItem> : Object, IConcurrentPool where TCollection : ICollection<TItem>, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TCollection |     |
| TItem |     |

### Constructors

#### MyConcurrentCollectionPool(Int32)

##### Declaration

```
public MyConcurrentCollectionPool(int defaultCapacity = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | defaultCapacity |     |

### Properties

#### Count

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Get()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| TCollection |     |

#### Return(TCollection)

##### Declaration

```
public void Return(TCollection instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TCollection | instance |     |