---
title: "Class SortedDictionaryValuesReader<K, V>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.SortedDictionaryValuesReader-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "SortedDictionaryValuesReader-2"
---

# Class SortedDictionaryValuesReader<K, V> | Space Engineers ModAPI

##### Inheritance

System.Object

SortedDictionaryValuesReader<K, V>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class SortedDictionaryValuesReader<K, V> : ValueType, IEnumerable<V>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| K   |     |
| V   |     |

### Constructors

#### SortedDictionaryValuesReader(SortedDictionary<K, V>)

##### Declaration

```
public SortedDictionaryValuesReader(SortedDictionary<K, V> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.SortedDictionary<K, V> | collection |     |

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

### Methods

#### GetEnumerator()

##### Declaration

```
public SortedDictionary<K, V>.ValueCollection.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.SortedDictionary.ValueCollection.Enumerator<> |     |

#### TryGetValue(K, out V)

##### Declaration

```
public bool TryGetValue(K key, out V result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| K   | key |     |
| V   | result |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Operators

#### Implicit(SortedDictionary<K, V> to SortedDictionaryValuesReader<K, V>)

##### Declaration

```
public static implicit operator SortedDictionaryValuesReader<K, V>(SortedDictionary<K, V> v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.SortedDictionary<K, V> | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [SortedDictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.SortedDictionaryValuesReader-2.html)<K, V> |     |