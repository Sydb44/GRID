---
title: "Class MySwapQueue<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySwapQueue-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MySwapQueue-1"
---

# Class MySwapQueue<T> | Space Engineers ModAPI

Holds three objects in safe manner, use when Reader requires only last valid data. One object is used for reading, one for writing and third is used as buffer, so reader/writer don't have to wait on the other.

##### Inheritance

System.Object

MySwapQueue<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MySwapQueue<T> : Object where T : class
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### MySwapQueue(T, T, T)

##### Declaration

```
public MySwapQueue(T first, T second, T third)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | first |     |
| T   | second |     |
| T   | third |     |

#### MySwapQueue(Func<T>)

##### Declaration

```
public MySwapQueue(Func<T> factoryMethod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<T> | factoryMethod |     |

### Properties

#### Read

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| T   |     |

#### Write

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| T   |     |

### Methods

#### CommitWrite()

Commits Write and replaces write with new object ready for new writing

##### Declaration

```
public void CommitWrite()
```

#### RefreshRead()

Updates data for reading if there's something new Returns true when Read was updated, returns false when Read was not changed

##### Declaration

```
public bool RefreshRead()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |