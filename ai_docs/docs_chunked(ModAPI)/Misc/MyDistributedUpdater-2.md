---
title: "Class MyDistributedUpdater<TList, TElement>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDistributedUpdater-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyDistributedUpdater-2"
---

# Class MyDistributedUpdater<TList, TElement> | Space Engineers ModAPI

Class distributing updates on large amount of objects in configurable intervals.

##### Inheritance

System.Object

MyDistributedUpdater<TList, TElement>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyDistributedUpdater<TList, TElement> : Object, IEnumerable<TElement>, IEnumerable where TList : IReadOnlyList<TElement>, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TList |     |
| TElement |     |

### Constructors

#### MyDistributedUpdater(Int32)

##### Declaration

```
public MyDistributedUpdater(int updateInterval)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | updateInterval |     |

### Properties

#### List

##### Declaration

```
public TList List { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| TList |     |

#### UpdateInterval

##### Declaration

```
public int UpdateInterval { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### GetEnumerator()

##### Declaration

```
public MyDistributedUpdater<TList, TElement>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDistributedUpdater.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDistributedUpdater-2.Enumerator.html)<> |     |

#### Iterate(Action<TElement>)

##### Declaration

```
public void Iterate(Action<TElement> p)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<TElement> | p   |     |

#### Update()

##### Declaration