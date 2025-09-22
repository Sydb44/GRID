---
title: "Class QueueReader<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.QueueReader-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "QueueReader-1"
---

# Class QueueReader<T> | Space Engineers ModAPI

##### Inheritance

System.Object

QueueReader<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class QueueReader<T> : ValueType, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### QueueReader(Queue<T>)

##### Declaration

```
public QueueReader(Queue<T> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Queue<T> | collection |     |

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

#### GetEnumerator()

##### Declaration

```
public Queue<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Queue.Enumerator<> |     |