---
title: "Class MyConcurrentPool<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentPool-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentPool-1"
---

# Class MyConcurrentPool<T> | Space Engineers ModAPI

Simple thread-safe pool. Can store external objects by calling return. Creates new instances when empty.

##### Inheritance

System.Object

MyConcurrentPool<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentPool<T> : Object, IConcurrentPool where T : new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MyConcurrentPool(Int32, Action<T>, Int32, Func<T>, Action<T>)

##### Declaration

```
public MyConcurrentPool(int defaultCapacity = 0, Action<T> clear = null, int expectedAllocations = 10000, Func<T> activator = null, Action<T> deactivator = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | defaultCapacity |     |
| System.Action<T> | clear |     |
| System.Int32 | expectedAllocations |     |
| System.Func<T> | activator |     |
| System.Action<T> | deactivator |     |

### Properties

#### Allocated

##### Declaration

```
public int Allocated { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

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

#### Clean()

##### Declaration

#### Get()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### Return(T)

##### Declaration

```
public void Return(T instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |