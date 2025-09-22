---
title: "Class ConcurrentCachingHashSet<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ConcurrentCachingHashSet-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "ConcurrentCachingHashSet-1"
---

# Class ConcurrentCachingHashSet<T> | Space Engineers ModAPI

##### Inheritance

System.Object

ConcurrentCachingHashSet<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class ConcurrentCachingHashSet<T> : Object, IEnumerable<T>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Constructors

#### ConcurrentCachingHashSet()

##### Declaration

```
public ConcurrentCachingHashSet()
```

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

#### Add(T)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

#### ApplyAdditions()

##### Declaration

```
public void ApplyAdditions()
```

#### ApplyChanges()

##### Declaration

```
public void ApplyChanges()
```

#### ApplyRemovals()

##### Declaration

```
public void ApplyRemovals()
```

#### Clear(Boolean)

##### Declaration

```
public void Clear(bool clearCache = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | clearCache |     |

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

#### GetEnumerator()

##### Declaration

```
public HashSet<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet.Enumerator<> |     |

#### Remove(T, Boolean)

##### Declaration

```
public void Remove(T item, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |
| System.Boolean | immediate |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |