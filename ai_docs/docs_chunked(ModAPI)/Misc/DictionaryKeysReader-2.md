---
title: "Class DictionaryKeysReader<K, V>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryKeysReader-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "DictionaryKeysReader-2"
---

# Class DictionaryKeysReader<K, V> | Space Engineers ModAPI

##### Inheritance

System.Object

DictionaryKeysReader<K, V>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public sealed class DictionaryKeysReader<K, V> : ValueType, IEnumerable<K>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| K   |     |
| V   |     |

### Constructors

#### DictionaryKeysReader(Dictionary<K, V>)

##### Declaration

```
public DictionaryKeysReader(Dictionary<K, V> collection)
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

### Methods

#### GetEnumerator()

##### Declaration

```
public Dictionary<K, V>.KeyCollection.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary.KeyCollection.Enumerator<> |     |