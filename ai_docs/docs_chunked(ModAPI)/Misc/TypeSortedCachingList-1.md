---
title: "Class TypeSortedCachingList<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.TypeSortedCachingList-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "TypeSortedCachingList-1"
---

# Class TypeSortedCachingList<T> | Space Engineers ModAPI

List wrapper that allows for addition and removal even during enumeration. Done by caching changes and allowing explicit application using Apply\* methods.

##### Inheritance

System.Object

TypeSortedCachingList<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class TypeSortedCachingList<T> : Object, IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
```

##### Type Parameters

### [](#constructors)Constructors

#### [](#VRage_Collections_TypeSortedCachingList_1__ctor)TypeSortedCachingList()

##### Declaration

```
public TypeSortedCachingList()
```

#### [](#VRage_Collections_TypeSortedCachingList_1__ctor_System_Int32_)TypeSortedCachingList(Int32)

##### Declaration

```
public TypeSortedCachingList(int capacity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | capacity |     |

### [](#properties)Properties

#### [](#VRage_Collections_TypeSortedCachingList_1_Count)Count

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Collections_TypeSortedCachingList_1_HasChanges)HasChanges

##### Declaration

```
public bool HasChanges { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Collections_TypeSortedCachingList_1_Item_System_Int32_)Item\[Int32\]

##### Declaration

```
public T this[int index] { get; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

### [](#methods)Methods

#### [](#VRage_Collections_TypeSortedCachingList_1_Add__0_)Add(T)

##### Declaration

```
public void Add(T entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | entity |     |

#### [](#VRage_Collections_TypeSortedCachingList_1_ApplyAdditions)ApplyAdditions()

##### Declaration

```
public void ApplyAdditions()
```

#### [](#VRage_Collections_TypeSortedCachingList_1_ApplyChanges)ApplyChanges()

##### Declaration

```
public void ApplyChanges()
```

#### [](#VRage_Collections_TypeSortedCachingList_1_ApplyRemovals)ApplyRemovals()

##### Declaration

```
public void ApplyRemovals()
```

#### [](#VRage_Collections_TypeSortedCachingList_1_Clear)Clear()

##### Declaration

#### [](#VRage_Collections_TypeSortedCachingList_1_ClearImmediate)ClearImmediate()

##### Declaration

```
public void ClearImmediate()
```

#### [](#VRage_Collections_TypeSortedCachingList_1_CopyWithChanges)CopyWithChanges()

Create a copy of the internal list with changes applied.

##### Declaration

```
public List<T> CopyWithChanges()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<T> | A copy of the list with all changes applied. |

#### [](#VRage_Collections_TypeSortedCachingList_1_DebugCheckEmpty)DebugCheckEmpty()

##### Declaration

```
public void DebugCheckEmpty()
```

#### [](#VRage_Collections_TypeSortedCachingList_1_GetEnumerator)GetEnumerator()

##### Declaration

```
public List<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List.Enumerator<> |     |

#### [](#VRage_Collections_TypeSortedCachingList_1_Remove__0_System_Boolean_)Remove(T, Boolean)

##### Declaration

```
public void Remove(T entity, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | entity |     |
| System.Boolean | immediate |     |

#### [](#VRage_Collections_TypeSortedCachingList_1_RemoveAtImmediately_System_Int32_)RemoveAtImmediately(Int32)

Immediately removes an element at the specified index.

##### Declaration

```
public void RemoveAtImmediately(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | Index of the element to remove immediately. |

#### [](#VRage_Collections_TypeSortedCachingList_1_Sort_System_Collections_Generic_IComparer__0__)Sort(IComparer<T>)

##### Declaration

```
public void Sort(IComparer<T> comparer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IComparer<T> | comparer |     |

#### [](#VRage_Collections_TypeSortedCachingList_1_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |