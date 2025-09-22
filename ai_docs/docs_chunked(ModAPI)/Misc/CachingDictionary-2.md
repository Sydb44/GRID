---
title: "Class CachingDictionary<K, V>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.CachingDictionary-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "CachingDictionary-2"
---

# Class CachingDictionary<K, V> | Space Engineers ModAPI

Dictionary wrapper that allows for addition and removal even during enumeration. Done by caching changes and allowing explicit application using Apply\* methods.

##### Inheritance

System.Object

CachingDictionary<K, V>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class CachingDictionary<K, V> : Object, IEnumerable<KeyValuePair<K, V>>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| K   |     |
| V   |     |

### Constructors

#### CachingDictionary()

##### Declaration

```
public CachingDictionary()
```

### Properties

#### Item\[K\]

##### Declaration

```
public V this[K key] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| K   | key |     |

##### Property Value

| Type | Description |
| --- | --- |
| V   |     |

#### Keys

##### Declaration

```
public Dictionary<K, V>.KeyCollection Keys { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary.KeyCollection<> |     |

#### Reader

##### Declaration

```
public DictionaryReader<K, V> Reader { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<K, V> |     |

#### Values

##### Declaration

```
public Dictionary<K, V>.ValueCollection Values { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary.ValueCollection<> |     |

### Methods

#### Add(K, V, Boolean)

##### Declaration

```
public void Add(K key, V value, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| K   | key |     |
| V   | value |     |
| System.Boolean | immediate |     |

#### ApplyAdditionsAndModifications()

##### Declaration

```
public void ApplyAdditionsAndModifications()
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

#### Clear()

##### Declaration

#### ContainsKey(K)

##### Declaration

```
public bool ContainsKey(K key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| K   | key |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetEnumerator()

##### Declaration

```
public Dictionary<K, V>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary.Enumerator<> |     |

#### HasChanges()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Remove(K, Boolean)

##### Declaration

```
public void Remove(K key, bool immediate = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| K   | key |     |
| System.Boolean | immediate |     |

#### TryGetValue(K, out V)

##### Declaration

```
public bool TryGetValue(K key, out V value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| K   | key |     |
| V   | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |