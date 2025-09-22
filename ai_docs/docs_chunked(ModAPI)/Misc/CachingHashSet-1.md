---
title: "Class CachingHashSet<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.CachingHashSet-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "CachingHashSet-1"
---

# Class CachingHashSet<T> | Space Engineers ModAPI

##### Inheritance

System.Object

CachingHashSet<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class CachingHashSet<T> : Object, IEnumerable<T>, IEnumerable
```

##### Type Parameters

### [](#constructors)Constructors

#### [](#VRage_Collections_CachingHashSet_1__ctor)CachingHashSet()

##### Declaration

### [](#properties)Properties

#### [](#VRage_Collections_CachingHashSet_1_Count)Count

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#methods)Methods

#### [](#VRage_Collections_CachingHashSet_1_Add__0_)Add(T)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Collections_CachingHashSet_1_ApplyAdditions)ApplyAdditions()

##### Declaration

```
public void ApplyAdditions()
```

#### [](#VRage_Collections_CachingHashSet_1_ApplyChanges)ApplyChanges()

##### Declaration

```
public void ApplyChanges()
```

#### [](#VRage_Collections_CachingHashSet_1_ApplyRemovals)ApplyRemovals()

##### Declaration

```
public void ApplyRemovals()
```

#### [](#VRage_Collections_CachingHashSet_1_Clear)Clear()

##### Declaration

#### [](#VRage_Collections_CachingHashSet_1_Contains__0_)Contains(T)

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

#### [](#VRage_Collections_CachingHashSet_1_GetEnumerator)GetEnumerator()

##### Declaration

```
public HashSet<T>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet.Enumerator<> |     |

#### [](#VRage_Collections_CachingHashSet_1_Remove__0_System_Boolean_)Remove(T, Boolean)

##### Declaration

```
public void Remove(T item, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | item |     |
| System.Boolean | immediate |     |

#### [](#VRage_Collections_CachingHashSet_1_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |