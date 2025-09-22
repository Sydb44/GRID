---
title: "Class ThreadSafeStore<TKey, TValue>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ThreadSafeStore-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "ThreadSafeStore-2"
---

# Class ThreadSafeStore<TKey, TValue> | Space Engineers ModAPI

##### Inheritance

System.Object

ThreadSafeStore<TKey, TValue>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class ThreadSafeStore<TKey, TValue> : Object
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TKey |     |
| TValue |     |

### [](#constructors)Constructors

#### [](#VRage_Collections_ThreadSafeStore_2__ctor_System_Func__0__1__)ThreadSafeStore(Func<TKey, TValue>)

##### Declaration

```
public ThreadSafeStore(Func<TKey, TValue> creator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<TKey, TValue> | creator |     |

### [](#methods)Methods

#### [](#VRage_Collections_ThreadSafeStore_2_Get__0_)Get(TKey)

##### Declaration

```
public TValue Get(TKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |

##### Returns

#### [](#VRage_Collections_ThreadSafeStore_2_Get__0_System_Func__0__1__)Get(TKey, Func<TKey, TValue>)

##### Declaration

```
public TValue Get(TKey key, Func<TKey, TValue> creator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |
| System.Func<TKey, TValue> | creator |     |

##### Returns