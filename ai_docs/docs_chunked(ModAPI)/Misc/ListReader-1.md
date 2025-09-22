---
title: "Class ListReader<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "ListReader-1"
---

# Class ListReader<T> | Space Engineers ModAPI

##### Inheritance

System.Object

ListReader<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class ListReader<T> : ValueType, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### ListReader(List<T>)

##### Declaration

```
public ListReader(List<T> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<T> | list |     |

### Fields

#### Empty

##### Declaration

```
public static ListReader<T> Empty
```

##### Field Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<T> |     |

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

#### Item\[Int32\]

##### Declaration

```
public T this[int index] { get; }
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

#### GetEnumerator()

##### Declaration

```
public List<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List.Enumerator<> |     |

#### IndexOf(T)

##### Declaration

```
public int IndexOf(T item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ItemAt(Int32)

##### Declaration

```
public T ItemAt(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

### Operators

#### Implicit(List<T> to ListReader<T>)

##### Declaration

```
public static implicit operator ListReader<T>(List<T> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<T> | list |     |

##### Returns

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<T> |     |