---
title: "Class MyConcurrentList<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentList-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentList-1"
---

# Class MyConcurrentList<T> | Space Engineers ModAPI

##### Inheritance

System.Object

MyConcurrentList<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentList<T> : Object, IMyQueue<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyConcurrentList()

##### Declaration

```
public MyConcurrentList()
```

#### MyConcurrentList(Int32)

##### Declaration

```
public MyConcurrentList(int reserve)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | reserve |     |

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

#### Empty

##### Declaration

```
public bool Empty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsReadOnly

##### Declaration

```
public bool IsReadOnly { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Item\[Int32\]

##### Declaration

```
public T this[int index] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

| Type | Description |
| --- | --- |
| T   |     |

#### List

Manage lock yourself when accesing the list!

##### Declaration

```
public List<T> List { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<T> |     |

#### ListUnsafe

Debug only!! Thread unsafe

##### Declaration

```
public ListReader<T> ListUnsafe { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<T> |     |

### Methods

#### Add(T)

Does NOT call sort

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | value |     |

#### AddRange(IEnumerable<T>)

Add a range of items to this list.

##### Declaration

```
public void AddRange(IEnumerable<T> value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<T> | value |     |

#### Clear()

##### Declaration

#### Contains(T)

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

#### CopyTo(T\[\], Int32)

##### Declaration

```
public void CopyTo(T[] array, int arrayIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T\[\] | array |     |
| System.Int32 | arrayIndex |     |

#### GetEnumerator()

##### Declaration

```
public ConcurrentEnumerator<FastResourceLockExtensions.MySharedLock, T, List<T>.Enumerator> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Library.Collections.ConcurrentEnumerator<VRage.FastResourceLockExtensions.MySharedLock, T, System.Collections.Generic.List.Enumerator<>> |     |

#### IndexOf(T)

##### Declaration

```
public int IndexOf(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Insert(Int32, T)

##### Declaration

```
public void Insert(int index, T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| T   | item |     |

#### Pop()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### Remove(T)

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

#### RemoveAll(Predicate<T>)

##### Declaration

```
public void RemoveAll(Predicate<T> callback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Predicate<T> | callback |     |

#### RemoveAt(Int32)

##### Declaration

```
public void RemoveAt(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

#### Sort(IComparer<T>)

##### Declaration

```
public void Sort(IComparer<T> comparer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IComparer<T> | comparer |     |

#### TryDequeueBack(out T)

##### Declaration

```
public bool TryDequeueBack(out T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryDequeueFront(out T)

##### Declaration

```
public bool TryDequeueFront(out T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |