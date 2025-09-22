---
title: "Class MyCommitQueue<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyCommitQueue-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyCommitQueue-1"
---

# Class MyCommitQueue<T> | Space Engineers ModAPI

Basic copy-on-commit implementation, later it will be faster by using one queue with 2 tails

##### Inheritance

System.Object

MyCommitQueue<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyCommitQueue<T> : Object
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyCommitQueue()

##### Declaration

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

#### UncommitedCount

##### Declaration

```
public int UncommitedCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Commit()

##### Declaration

#### Enqueue(T)

##### Declaration

```
public void Enqueue(T obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | obj |     |

#### TryDequeue(out T)

##### Declaration

```
public bool TryDequeue(out T obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |