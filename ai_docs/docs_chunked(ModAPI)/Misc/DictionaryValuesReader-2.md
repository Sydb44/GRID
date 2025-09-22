---
title: "Class DictionaryValuesReader<K, V>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "DictionaryValuesReader-2"
---

# Class DictionaryValuesReader<K, V> | Space Engineers ModAPI

##### Inheritance

System.Object

DictionaryValuesReader<K, V>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class DictionaryValuesReader<K, V> : ValueType, IEnumerable<V>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| K   |     |
| V   |     |

### Constructors

#### DictionaryValuesReader(Dictionary<K, V>)

##### Declaration

```
public DictionaryValuesReader(Dictionary<K, V> collection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<K, V> | collection |     |

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
public Dictionary<K, V>.ValueCollection.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary.ValueCollection.Enumerator<> |     |

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

#### Implicit(Dictionary<K, V> to DictionaryValuesReader<K, V>)

##### Declaration

```
public static implicit operator DictionaryValuesReader<K, V>(Dictionary<K, V> v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.Dictionary<K, V> | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<K, V> |     |