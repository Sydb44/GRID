---
title: "Class CachingList<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.CachingList-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "CachingList-1"
---

# Class CachingList<T> | Space Engineers ModAPI

List wrapper that allows for addition and removal even during enumeration. Done by caching changes and allowing explicit application using Apply\* methods.

##### Inheritance

System.Object

CachingList<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class CachingList<T> : Object, IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### CachingList()

##### Declaration

#### CachingList(Int32)

##### Declaration

```
public CachingList(int capacity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | capacity |     |

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

#### HasChanges

##### Declaration

```
public bool HasChanges { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

### Methods

#### Add(T)

##### Declaration

```
public void Add(T entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | entity |     |

#### ApplyAdditions()

##### Declaration

```
public void ApplyAdditions()
```

#### ApplyChanges()

##### Declaration

```
public void ApplyChanges()
```

#### ApplyRemovals()

##### Declaration

```
public void ApplyRemovals()
```

#### Clear()

##### Declaration

#### ClearImmediate()

##### Declaration

```
public void ClearImmediate()
```

#### CopyWithChanges()

Create a copy of the internal list with changes applied.

##### Declaration

```
public List<T> CopyWithChanges()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<T> | A copy of the list with all changes applied. |

#### DebugCheckEmpty()

##### Declaration

```
public void DebugCheckEmpty()
```

#### GetEnumerator()

##### Declaration

```
public List<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List.Enumerator<> |     |

#### Remove(T, Boolean)

##### Declaration

```
public void Remove(T entity, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | entity |     |
| System.Boolean | immediate |     |

#### RemoveAtImmediately(Int32)

Immediately removes an element at the specified index.

##### Declaration

```
public void RemoveAtImmediately(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Index of the element to remove immediately. |

#### Sort(IComparer<T>)

##### Declaration

```
public void Sort(IComparer<T> comparer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IComparer<T> | comparer |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |