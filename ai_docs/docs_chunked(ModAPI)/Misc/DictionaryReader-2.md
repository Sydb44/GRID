---
title: "Class DictionaryReader<K, V>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "DictionaryReader-2"
---

# Class DictionaryReader<K, V> | Space Engineers ModAPI

##### Inheritance

System.Object

DictionaryReader<K, V>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class DictionaryReader<K, V> : ValueType, IEnumerable<KeyValuePair<K, V>>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| K   |     |
| V   |     |

### Constructors

#### DictionaryReader(Dictionary<K, V>)

##### Declaration

```
public DictionaryReader(Dictionary<K, V> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<K, V> | collection |     |

### Fields

#### Empty

##### Declaration

```
public static readonly DictionaryReader<K, V> Empty
```

##### Field Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<K, V> |     |

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
public Dictionary<K, V>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary.Enumerator<> |     |

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

#### Implicit(Dictionary<K, V> to DictionaryReader<K, V>)

##### Declaration

```
public static implicit operator DictionaryReader<K, V>(Dictionary<K, V> v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<K, V> | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<K, V> |     |