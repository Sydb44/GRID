---
title: "Class UniqueListReader<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.UniqueListReader-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "UniqueListReader-1"
---

# Class UniqueListReader<T> | Space Engineers ModAPI

##### Inheritance

System.Object

UniqueListReader<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class UniqueListReader<T> : ValueType, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### UniqueListReader(MyUniqueList<T>)

##### Declaration

```
public UniqueListReader(MyUniqueList<T> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyUniqueList](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyUniqueList-1.html)<T> | list |     |

### Fields

#### Empty

##### Declaration

```
public static UniqueListReader<T> Empty
```

##### Field Value

| Type | Description |
| --- | --- |
| [UniqueListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.UniqueListReader-1.html)<T> |     |

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
public List<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List.Enumerator<> |     |

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

#### Implicit(MyUniqueList<T> to UniqueListReader<T>)

##### Declaration

```
public static implicit operator UniqueListReader<T>(MyUniqueList<T> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyUniqueList](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyUniqueList-1.html)<T> | list |     |

##### Returns

| Type | Description |
| --- | --- |
| [UniqueListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.UniqueListReader-1.html)<T> |     |

#### Implicit(UniqueListReader<T> to ListReader<T>)

##### Declaration

```
public static implicit operator ListReader<T>(UniqueListReader<T> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [UniqueListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.UniqueListReader-1.html)<T> | list |     |

##### Returns

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<T> |     |