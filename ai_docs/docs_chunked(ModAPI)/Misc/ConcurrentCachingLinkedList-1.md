---
title: "Class ConcurrentCachingLinkedList<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ConcurrentCachingLinkedList-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "ConcurrentCachingLinkedList-1"
---

# Class ConcurrentCachingLinkedList<T> | Space Engineers ModAPI

List wrapper that allows for addition and removal even during enumeration. Done by caching changes and allowing explicit application using Apply\* methods.

This version has individual locks for cached and non-cached versions, allowing each to be managed efficiently even across multiple threads

##### Inheritance

System.Object

ConcurrentCachingLinkedList<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class ConcurrentCachingLinkedList<T> : Object, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### ConcurrentCachingLinkedList(Action<T, LinkedListNode<T>>, Func<T, LinkedListNode<T>>)

##### Declaration

```
public ConcurrentCachingLinkedList(Action<T, LinkedListNode<T>> setter, Func<T, LinkedListNode<T>> getter)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<T, System.Collections.Generic.LinkedListNode<T>> | setter |     |
| System.Func<T, System.Collections.Generic.LinkedListNode<T>> | getter |     |

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

#### IsEmpty

##### Declaration

```
public bool IsEmpty { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### ClearImmediate()

##### Declaration

```
public void ClearImmediate()
```

#### ClearList()

##### Declaration

#### DebugCheckEmpty()

##### Declaration

```
public void DebugCheckEmpty()
```

#### GetEnumerator()

##### Declaration

```
public ConcurrentEnumerator<SpinLockRef.Token, T, LinkedList<T>.Enumerator> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Library.Collections.ConcurrentEnumerator<VRage.Library.Threading.SpinLockRef.Token, T, System.Collections.Generic.LinkedList.Enumerator<>> |     |

#### Invoke(Action)

##### Declaration

```
public void Invoke(Action action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action |     |

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

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |