---
title: "Class MyBinaryStructHeap<TKey, TValue>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyBinaryStructHeap-2.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MyBinaryStructHeap-2"
---

# Class MyBinaryStructHeap<TKey, TValue> | Space Engineers ModAPI

##### Inheritance

System.Object

MyBinaryStructHeap<TKey, TValue>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MyBinaryStructHeap<TKey, TValue> : Object where TValue : struct, ValueType
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TKey |     |
| TValue |     |

### Constructors

#### MyBinaryStructHeap(Int32, IComparer<TKey>)

##### Declaration

```
public MyBinaryStructHeap(int initialCapacity = 128, IComparer<TKey> comparer = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | initialCapacity |     |
| System.Collections.Generic.IComparer<TKey> | comparer |     |

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

#### Insert(TValue, TKey)

##### Declaration

```
public void Insert(TValue value, TKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TValue | value |     |
| TKey | key |     |

#### Min()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| TValue |     |

#### MinKey()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| TKey |     |

#### Remove(TKey)

##### Declaration

```
public TValue Remove(TKey key)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |

##### Returns

| Type | Description |
| --- | --- |
| TValue |     |

#### Remove(TValue, IEqualityComparer<TValue>)

##### Declaration

```
public TValue Remove(TValue value, IEqualityComparer<TValue> comparer = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TValue | value |     |
| System.Collections.Generic.IEqualityComparer<TValue> | comparer |     |

##### Returns

| Type | Description |
| --- | --- |
| TValue |     |

#### RemoveMax()

##### Declaration

```
public TValue RemoveMax()
```

##### Returns

| Type | Description |
| --- | --- |
| TValue |     |

#### RemoveMin()

##### Declaration

```
public TValue RemoveMin()
```

##### Returns

| Type | Description |
| --- | --- |
| TValue |     |