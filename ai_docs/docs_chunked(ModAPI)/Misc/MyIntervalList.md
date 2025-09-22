---
title: "Class MyIntervalList"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyIntervalList.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyIntervalList"
---

# Class MyIntervalList | Space Engineers ModAPI

A set of integer numbers optimized for sets with long consecutive runs. Each interval is stored as two values in m\_list: the lower and the upper bound.

For example, the set of numbers 2, 3, 4, 5, 7, 9, 10, 11, 12, 13 (or alternatively in the interval notation <2, 5> U <7, 7> U <9, 13>) is saved as a list { 2, 5, 7, 7, 9, 13 }

##### Inheritance

System.Object

MyIntervalList

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyIntervalList : Object
```

### Constructors

#### MyIntervalList()

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

#### IntervalCount

##### Declaration

```
public int IntervalCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Item\[Int32\]

##### Declaration

```
public int this[int index] { get; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Add(Int32)

Add a value to the list

##### Declaration

```
public void Add(int value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | value |     |

#### Clear()

##### Declaration

#### Contains(Int32)

##### Declaration

```
public bool Contains(int value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCopy()

##### Declaration

```
public MyIntervalList GetCopy()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyIntervalList](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyIntervalList.html) |     |

#### GetEnumerator()

##### Declaration

```
public MyIntervalList.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyIntervalList.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyIntervalList.Enumerator.html) |     |

#### IndexOf(Int32)

##### Declaration

```
public int IndexOf(int value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |