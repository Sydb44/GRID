---
title: "Class SortedDictionaryReader<K, V>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.SortedDictionaryReader-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "SortedDictionaryReader-2"
---

# Class SortedDictionaryReader<K, V> | Space Engineers ModAPI

##### Inheritance

System.Object

SortedDictionaryReader<K, V>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class SortedDictionaryReader<K, V> : ValueType, IEnumerable<KeyValuePair<K, V>>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| K   |     |
| V   |     |

### Constructors

#### SortedDictionaryReader(SortedDictionary<K, V>)

##### Declaration

```
public SortedDictionaryReader(SortedDictionary<K, V> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.SortedDictionary<K, V> | collection |     |

### Fields

#### Empty

##### Declaration

```
public static readonly SortedDictionaryReader<K, V> Empty
```

##### Field Value

| Type | Description |
| --- | --- |
| [SortedDictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.SortedDictionaryReader-2.html)<K, V> |     |

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

#### Item\[K\]

##### Declaration

```
public V this[K key] { get; }
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
public IEnumerable<K> Keys { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<K> |     |

#### Values

##### Declaration

```
public IEnumerable<V> Values { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<V> |     |

### Methods

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
public SortedDictionary<K, V>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.SortedDictionary.Enumerator<> |     |

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

### Operators

#### Implicit(SortedDictionary<K, V> to SortedDictionaryReader<K, V>)

##### Declaration

```
public static implicit operator SortedDictionaryReader<K, V>(SortedDictionary<K, V> v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.SortedDictionary<K, V> | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [SortedDictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.SortedDictionaryReader-2.html)<K, V> |     |