---
title: "Class MyBinaryHeap<K, V>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyBinaryHeap-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyBinaryHeap-2"
---

# Class MyBinaryHeap<K, V> | Space Engineers ModAPI

##### Inheritance

System.Object

MyBinaryHeap<K, V>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyBinaryHeap<K, V> : Object where V : HeapItem<K>
```

##### Type Parameters

| Name | Description |
| --- | --- |
| K   |     |
| V   |     |

### Constructors

#### MyBinaryHeap()

##### Declaration

#### MyBinaryHeap(Int32)

##### Declaration

```
public MyBinaryHeap(int initialCapacity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | initialCapacity |     |

#### MyBinaryHeap(Int32, IComparer<K>)

##### Declaration

```
public MyBinaryHeap(int initialCapacity, IComparer<K> comparer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | initialCapacity |     |
| System.Collections.Generic.IComparer<K> | comparer |     |

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

#### Full

##### Declaration

```
public bool Full { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Clear()

##### Declaration

#### GetItem(Int32)

##### Declaration

```
public V GetItem(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| V   |     |

#### Insert(V, K)

##### Declaration

```
public void Insert(V value, K key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | value |     |
| K   | key |     |

#### Min()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| V   |     |

#### Modify(V, K)

##### Declaration

```
public void Modify(V item, K newKey)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |
| K   | newKey |     |

#### ModifyDown(V, K)

##### Declaration

```
public void ModifyDown(V item, K newKey)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |
| K   | newKey |     |

#### ModifyUp(V, K)

##### Declaration

```
public void ModifyUp(V item, K newKey)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |
| K   | newKey |     |

#### QueryAll(List<V>)

##### Declaration

```
public void QueryAll(List<V> list)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<V> | list |     |

#### Remove(V)

##### Declaration

```
public void Remove(V item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |

#### RemoveMax()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| V   |     |

#### RemoveMin()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| V   |     |