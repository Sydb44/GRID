---
title: "Class MyQueue<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyQueue-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyQueue-1"
---

# Class MyQueue<T> | Space Engineers ModAPI

Allows access to queue by index Otherwise implementation is similar to regular queue

##### Inheritance

System.Object

MyQueue<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyQueue<T> : Object, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyQueue()

##### Declaration

#### MyQueue(IEnumerable<T>)

##### Declaration

```
public MyQueue(IEnumerable<T> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<T> | collection |     |

#### MyQueue(Int32)

##### Declaration

```
public MyQueue(int capacity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | capacity |     |

### Fields

#### m\_array

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| T\[\] |     |

#### m\_head

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### m\_size

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### m\_tail

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

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

#### InternalArray

##### Declaration

```
public T[] InternalArray { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| T\[\] |     |

#### Item\[Int32\]

##### Declaration

```
public ref T this[int index] { get; }
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

#### Dequeue()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### Enqueue(T)

##### Declaration

```
public void Enqueue(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

#### GetEnumerator()

##### Declaration

```
public MyQueue<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyQueue.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyQueue-1.Enumerator.html)<> |     |

#### Last()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### Peek()

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

#### Remove(Int32)

##### Declaration

```
public void Remove(int idx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx |     |

#### RemoveWhere(Func<T, Boolean>, out T)

##### Declaration

```
public bool RemoveWhere(Func<T, bool> predicate, out T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<T, System.Boolean\> | predicate |     |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SetCapacity(Int32)

##### Declaration

```
protected void SetCapacity(int capacity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | capacity |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TrimExcess()

##### Declaration

#### TryDequeue(out T)

##### Declaration

```
public bool TryDequeue(out T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |