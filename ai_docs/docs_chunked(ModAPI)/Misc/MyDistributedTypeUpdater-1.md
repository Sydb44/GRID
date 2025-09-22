---
title: "Class MyDistributedTypeUpdater<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDistributedTypeUpdater-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyDistributedTypeUpdater-1"
---

# Class MyDistributedTypeUpdater<T> | Space Engineers ModAPI

Class distributing updates on large amount of objects in configurable intervals. This updater does updates in linear manner in defined steps. Also takes into account type of the item.

##### Inheritance

System.Object

MyDistributedTypeUpdater<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyDistributedTypeUpdater<T> : Object, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyDistributedTypeUpdater(Int32)

##### Declaration

```
public MyDistributedTypeUpdater(int updateInterval)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | updateInterval |     |

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

#### Item\[Int32\]

##### Declaration

```
public T this[int index] { get; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

| Type | Description |
| --- | --- |
| T   |     |

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

#### Add(T)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

#### ApplyChanges()

##### Declaration

```
public void ApplyChanges()
```

#### Clear()

##### Declaration

#### GetEnumerator()

##### Declaration

```
public MyDistributedTypeUpdater<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyDistributedTypeUpdater.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDistributedTypeUpdater-1.Enumerator.html)<> |     |

#### Remove(T, Boolean)

##### Declaration

```
public void Remove(T item, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |
| System.Boolean | immediate |     |

#### Update()

##### Declaration