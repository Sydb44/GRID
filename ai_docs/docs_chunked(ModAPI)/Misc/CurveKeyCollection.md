---
title: "Class CurveKeyCollection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKeyCollection.html"
category: "Misc"
namespace: "VRageMath"
class: "CurveKeyCollection"
---

# Class CurveKeyCollection | Space Engineers ModAPI

Contains the CurveKeys making up a Curve.

##### Inheritance

System.Object

CurveKeyCollection

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class CurveKeyCollection : Object, ICollection<CurveKey>, IEnumerable<CurveKey>, IEnumerable
```

### Constructors

#### CurveKeyCollection()

##### Declaration

```
public CurveKeyCollection()
```

### Properties

#### Count

Gets the number of elements contained in the CurveKeyCollection.

##### Declaration

```
public int Count { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsReadOnly

Returns a value indicating whether the CurveKeyCollection is read-only.

##### Declaration

```
public bool IsReadOnly { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Item\[Int32\]

Gets or sets the element at the specified index.

##### Declaration

```
public CurveKey this[int index] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The array index of the element. |

##### Property Value

| Type | Description |
| --- | --- |
| [CurveKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html) |     |

### Methods

#### Add(Object)

##### Declaration

```
public void Add(object tmp)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | tmp |     |

#### Add(CurveKey)

Adds a CurveKey to the CurveKeyCollection.

##### Declaration

```
public void Add(CurveKey item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CurveKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html) | item | The CurveKey to add. |

#### Clear()

Removes all CurveKeys from the CurveKeyCollection.

##### Declaration

#### Clone()

Creates a copy of the CurveKeyCollection.

##### Declaration

```
public CurveKeyCollection Clone()
```

##### Returns

| Type | Description |
| --- | --- |
| [CurveKeyCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKeyCollection.html) |     |

#### Contains(CurveKey)

Determines whether the CurveKeyCollection contains a specific CurveKey.

##### Declaration

```
public bool Contains(CurveKey item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CurveKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html) | item | true if the CurveKey is found in the CurveKeyCollection; false otherwise. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CopyTo(CurveKey\[\], Int32)

Copies the CurveKeys of the CurveKeyCollection to an array, starting at the array index provided.

##### Declaration

```
public void CopyTo(CurveKey[] array, int arrayIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CurveKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html)\[\] | array | The destination of the CurveKeys copied from CurveKeyCollection. The array must have zero-based indexing. |
| System.Int32 | arrayIndex | The zero-based index in the array to start copying from. |

#### GetEnumerator()

Returns an enumerator that iterates through the CurveKeyCollection.

##### Declaration

```
public IEnumerator<CurveKey> GetEnumerator()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerator<[CurveKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html)\> |     |

#### IndexOf(CurveKey)

Determines the index of a CurveKey in the CurveKeyCollection.

##### Declaration

```
public int IndexOf(CurveKey item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CurveKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html) | item | CurveKey to locate in the CurveKeyCollection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Remove(CurveKey)

Removes the first occurrence of a specific CurveKey from the CurveKeyCollection.

##### Declaration

```
public bool Remove(CurveKey item)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CurveKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.CurveKey.html) | item | The CurveKey to remove from the CurveKeyCollection. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveAt(Int32)

Removes the CurveKey at the specified index.

##### Declaration

```
public void RemoveAt(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The zero-based index of the item to remove. |