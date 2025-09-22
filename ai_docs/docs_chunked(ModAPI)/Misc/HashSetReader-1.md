---
title: "Class HashSetReader<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "HashSetReader-1"
---

# Class HashSetReader<T> | Space Engineers ModAPI

##### Inheritance

System.Object

HashSetReader<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class HashSetReader<T> : ValueType, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### HashSetReader(HashSet<T>)

##### Declaration

```
public HashSetReader(HashSet<T> set)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.HashSet<T> | set |     |

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

#### IsValid

##### Declaration

```
public bool IsValid { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

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

#### First()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

#### GetEnumerator()

##### Declaration

```
public HashSet<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet.Enumerator<> |     |

#### ToArray()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| T\[\] |     |

### Operators

#### Implicit(HashSet<T> to HashSetReader<T>)

##### Declaration

```
public static implicit operator HashSetReader<T>(HashSet<T> v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.HashSet<T> | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [HashSetReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html)<T> |     |