---
title: "Class MyUniqueList<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyUniqueList-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyUniqueList-1"
---

# Class MyUniqueList<T> | Space Engineers ModAPI

##### Inheritance

System.Object

MyUniqueList<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyUniqueList<T> : Object
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyUniqueList()

##### Declaration

### Properties

#### Count

O(1)

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Item\[Int32\]

O(1)

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

#### ItemList

##### Declaration

```
public ListReader<T> ItemList { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<T> |     |

#### Items

##### Declaration

```
public UniqueListReader<T> Items { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [UniqueListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.UniqueListReader-1.html)<T> |     |

### Methods

#### Add(T)

O(1)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Clear()

##### Declaration

#### Contains(T)

O(1)

##### Declaration

```
public bool Contains(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetEnumerator()

##### Declaration

```
public List<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List.Enumerator<> |     |

#### Insert(Int32, T)

O(n)

##### Declaration

```
public bool Insert(int index, T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Remove(T)

O(n)

##### Declaration

```
public bool Remove(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |