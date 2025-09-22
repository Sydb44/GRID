---
title: "Class MyConcurrentDictionary<TKey, TValue>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentDictionary-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyConcurrentDictionary-2"
---

# Class MyConcurrentDictionary<TKey, TValue> | Space Engineers ModAPI

Simple thread-safe queue. Uses spin-lock

##### Inheritance

System.Object

MyConcurrentDictionary<TKey, TValue>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyConcurrentDictionary<TKey, TValue> : Object, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TKey |     |
| TValue |     |

### Constructors

#### MyConcurrentDictionary(IEqualityComparer<TKey>)

##### Declaration

```
public MyConcurrentDictionary(IEqualityComparer<TKey> comparer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEqualityComparer<TKey> | comparer |     |

#### MyConcurrentDictionary(Int32, IEqualityComparer<TKey>)

##### Declaration

```
public MyConcurrentDictionary(int capacity = 0, IEqualityComparer<TKey> comparer = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | capacity |     |
| System.Collections.Generic.IEqualityComparer<TKey> | comparer |     |

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

#### Item\[TKey\]

##### Declaration

```
public TValue this[TKey key] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |

##### Property Value

| Type | Description |
| --- | --- |
| TValue |     |

#### Keys

##### Declaration

```
public ConcurrentEnumerable<FastResourceLockExtensions.MySharedLock, TKey, Dictionary<TKey, TValue>.KeyCollection> Keys { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.ConcurrentEnumerable<VRage.FastResourceLockExtensions.MySharedLock, TKey, System.Collections.Generic.Dictionary.KeyCollection<>> |     |

#### Values

##### Declaration

```
public ConcurrentEnumerable<FastResourceLockExtensions.MySharedLock, TValue, Dictionary<TKey, TValue>.ValueCollection> Values { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Library.Collections.ConcurrentEnumerable<VRage.FastResourceLockExtensions.MySharedLock, TValue, System.Collections.Generic.Dictionary.ValueCollection<>> |     |

### Methods

#### Add(TKey, TValue)

##### Declaration

```
public void Add(TKey key, TValue value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |
| TValue | value |     |

#### AssignCopyTo(ref IReadOnlyDictionary<TKey, TValue>)

##### Declaration

```
public void AssignCopyTo(ref IReadOnlyDictionary<TKey, TValue> dest)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IReadOnlyDictionary<TKey, TValue> | dest |     |

#### ChangeKey(TKey, TKey)

##### Declaration

```
public TValue ChangeKey(TKey oldKey, TKey newKey)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | oldKey |     |
| TKey | newKey |     |

##### Returns

| Type | Description |
| --- | --- |
| TValue |     |

#### Clear()

##### Declaration

#### ContainsKey(TKey)

##### Declaration

```
public bool ContainsKey(TKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ContainsValue(TValue)

##### Declaration

```
public bool ContainsValue(TValue value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TValue | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FirstPair()

##### Declaration

```
public KeyValuePair<TKey, TValue> FirstPair()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.KeyValuePair<TKey, TValue> |     |

#### GetEnumerator()

##### Declaration

```
public ConcurrentEnumerator<FastResourceLockExtensions.MySharedLock, KeyValuePair<TKey, TValue>, Dictionary<TKey, TValue>.Enumerator> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Library.Collections.ConcurrentEnumerator<VRage.FastResourceLockExtensions.MySharedLock, System.Collections.Generic.KeyValuePair<TKey, TValue>, System.Collections.Generic.Dictionary.Enumerator<>> |     |

#### GetOrAdd(TKey, Func<TKey, TValue>)

##### Declaration

```
public TValue GetOrAdd(TKey key, Func<TKey, TValue> factory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |
| System.Func<TKey, TValue> | factory |     |

##### Returns

| Type | Description |
| --- | --- |
| TValue |     |

#### GetValueOrDefault(TKey, TValue)

##### Declaration

```
public TValue GetValueOrDefault(TKey key, TValue defaultValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |
| TValue | defaultValue |     |

##### Returns

| Type | Description |
| --- | --- |
| TValue |     |

#### GetValues(List<TValue>)

##### Declaration

```
public void GetValues(List<TValue> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<TValue> | result |     |

#### Remove(TKey)

##### Declaration

```
public bool Remove(TKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryAdd(TKey, TValue)

##### Declaration

```
public bool TryAdd(TKey key, TValue value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |
| TValue | value |     |
