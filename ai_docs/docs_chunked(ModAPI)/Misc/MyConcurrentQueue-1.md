---
title: "Class MyConcurrentQueue<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentQueue-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentQueue-1"
---

# Class MyConcurrentQueue<T> | Space Engineers ModAPI

Simple thread-safe queue. Uses spin-lock

##### Inheritance

System.Object

MyConcurrentQueue<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentQueue<T> : Object, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyConcurrentQueue()

##### Declaration

```
public MyConcurrentQueue()
```

#### MyConcurrentQueue(Int32)

##### Declaration

```
public MyConcurrentQueue(int capacity)
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

### Methods

#### Clear()

##### Declaration

#### Dequeue()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### Enqueue(T)

##### Declaration

```
public void Enqueue(T instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |

#### GetEnumerator()

##### Declaration

```
public ConcurrentEnumerator<SpinLockRef.Token, T, MyQueue<T>.Enumerator> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Library.Collections.ConcurrentEnumerator<VRage.Library.Threading.SpinLockRef.Token, T, [MyQueue.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyQueue-1.Enumerator.html)<>> |     |

#### Remove(T)

##### Declaration

```
public void Remove(T instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |

#### TryDequeue(out T)

##### Declaration

```
public bool TryDequeue(out T instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryPeek(out T)

##### Declaration

```
public bool TryPeek(out T instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |