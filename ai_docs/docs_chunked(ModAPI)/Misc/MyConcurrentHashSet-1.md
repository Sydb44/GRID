---
title: "Class MyConcurrentHashSet<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentHashSet-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentHashSet-1"
---

# Class MyConcurrentHashSet<T> | Space Engineers ModAPI

Simple thread-safe queue. Uses spin-lock

##### Inheritance

System.Object

MyConcurrentHashSet<T>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentHashSet<T> : Object, IEnumerable<T>, IEnumerable
```

##### Type Parameters

### [](#constructors)Constructors

#### [](#VRage_Collections_MyConcurrentHashSet_1__ctor)MyConcurrentHashSet()

##### Declaration

```
public MyConcurrentHashSet()
```

#### [](#VRage_Collections_MyConcurrentHashSet_1__ctor_System_Collections_Generic_IEqualityComparer__0__)MyConcurrentHashSet(IEqualityComparer<T>)

##### Declaration

```
public MyConcurrentHashSet(IEqualityComparer<T> comparer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEqualityComparer<T> | comparer |     |

### [](#properties)Properties

#### [](#VRage_Collections_MyConcurrentHashSet_1_Count)Count

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#methods)Methods

#### [](#VRage_Collections_MyConcurrentHashSet_1_Add__0_)Add(T)

##### Declaration

```
public bool Add(T instance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | instance |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Collections_MyConcurrentHashSet_1_Clear)Clear()

##### Declaration

#### [](#VRage_Collections_MyConcurrentHashSet_1_Contains__0_)Contains(T)

##### Declaration

```
public bool Contains(T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Collections_MyConcurrentHashSet_1_GetEnumerator)GetEnumerator()

##### Declaration

```
public ConcurrentEnumerator<SpinLockRef.Token, T, HashSet<T>.Enumerator> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Library.Collections.ConcurrentEnumerator<VRage.Library.Threading.SpinLockRef.Token, T, System.Collections.Generic.HashSet.Enumerator<>> |     |

#### [](#VRage_Collections_MyConcurrentHashSet_1_Remove__0_)Remove(T)

##### Declaration

```
public bool Remove(T value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |