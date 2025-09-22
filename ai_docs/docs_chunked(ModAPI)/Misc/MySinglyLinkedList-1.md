---
title: "Class MySinglyLinkedList<V>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySinglyLinkedList-1.html"
category: "Misc"
namespace: "VRage.Collections"
class: "MySinglyLinkedList-1"
---

# Class MySinglyLinkedList<V> | Space Engineers ModAPI

##### Inheritance

System.Object

MySinglyLinkedList<V>

###### **Namespace**: [VRage.Collections](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.html)

###### **Assembly**: VRage.Library.dll

##### Syntax

```
public class MySinglyLinkedList<V> : Object, IList<V>, ICollection<V>, IEnumerable<V>, IEnumerable
```

##### Type Parameters

| Name | Description |
| --- | --- |
| V   |     |

### Constructors

#### MySinglyLinkedList()

##### Declaration

```
public MySinglyLinkedList()
```

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

#### IsReadOnly

##### Declaration

```
public bool IsReadOnly { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Item\[Int32\]

##### Declaration

```
public V this[int index] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

| Type | Description |
| --- | --- |
| V   |     |

### Methods

#### Add(V)

##### Declaration

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |

#### Append(V)

##### Declaration

```
public void Append(V item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |

#### Clear()

##### Declaration

#### Contains(V)

##### Declaration

```
public bool Contains(V item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CopyTo(V\[\], Int32)

##### Declaration

```
public void CopyTo(V[] array, int arrayIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V\[\] | array |     |
| System.Int32 | arrayIndex |     |

#### First()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| V   |     |

#### GetEnumerator()

##### Declaration

```
public MySinglyLinkedList<V>.Enumerator GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| [MySinglyLinkedList.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySinglyLinkedList-1.Enumerator.html)<> |     |

#### IndexOf(V)

##### Declaration

```
public int IndexOf(V item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Insert(Int32, V)

##### Declaration

```
public void Insert(int index, V item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |
| V   | item |     |

#### Last()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| V   |     |

#### Merge(MySinglyLinkedList<V>)

##### Declaration

```
public void Merge(MySinglyLinkedList<V> otherList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySinglyLinkedList](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySinglyLinkedList-1.html)<V> | otherList |     |

#### PopFirst()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| V   |     |

#### Prepend(V)

##### Declaration

```
public void Prepend(V item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |

#### Remove(V)

##### Declaration

```
public bool Remove(V item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| V   | item |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveAt(Int32)

##### Declaration

```
public void RemoveAt(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

#### Reverse()

##### Declaration

#### Split(MySinglyLinkedList<V>.Enumerator, Int32)

Splits the list into two. This list's end will be the node pointed by newLastPosition and the newly created list will begin with the next node.

##### Declaration

```
public MySinglyLinkedList<V> Split(MySinglyLinkedList<V>.Enumerator newLastPosition, int newCount = -1)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MySinglyLinkedList.Enumerator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySinglyLinkedList-1.Enumerator.html)<> | newLastPosition | Enumerator that points to the new last position in the list. |
| System.Int32 | newCount | New number of elements in this list. If set to -1, it is calculated automatically, but that would make the split an O(N) operation. Beware: If you set this parameter, be sure to always set the correct number, otherwise, you'd cause both lists (this one and the returned one) to return a wrong number of elements in the future. |

##### Returns

| Type | Description |
| --- | --- |
| [MySinglyLinkedList](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MySinglyLinkedList-1.html)<V> | The newly created list |

#### VerifyConsistency()

##### Declaration

```
public bool VerifyConsistency()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |