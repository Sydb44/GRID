---
title: "Class MyDeque<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyDeque-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyDeque-1"
---

# Class MyDeque<T> | Space Engineers ModAPI

##### Inheritance

System.Object

MyDeque<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyDeque<T> : Object
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyDeque(Int32)

##### Declaration

```
public MyDeque(int baseCapacity = 8)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | baseCapacity |     |

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

### Methods

#### Clear()

##### Declaration

#### DequeueBack()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### DequeueFront()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### EnqueueBack(T)

##### Declaration

```
public void EnqueueBack(T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | value |     |

#### EnqueueFront(T)

##### Declaration

```
public void EnqueueFront(T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | value |     |