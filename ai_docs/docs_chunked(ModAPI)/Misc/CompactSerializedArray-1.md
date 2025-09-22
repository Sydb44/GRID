---
title: "Class CompactSerializedArray<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.CompactSerializedArray-1.html"
category: "Misc"
namespace: "VRage.Game"
class: "CompactSerializedArray-1"
---

# Class CompactSerializedArray<T> | Space Engineers ModAPI

##### Inheritance

System.Object

CompactSerializedArray<T>

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class CompactSerializedArray<T> : ValueType
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Properties

#### SerializableData

##### Declaration

```
public byte[] SerializableData { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte\[\] |     |

### Operators

#### Implicit(in T\[\] to CompactSerializedArray<T>)

##### Declaration

```
public static implicit operator CompactSerializedArray<T>(in T[] array)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T\[\] | array |     |

##### Returns

| Type | Description |
| --- | --- |
| [CompactSerializedArray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.CompactSerializedArray-1.html)<T> |     |

#### Implicit(in CompactSerializedArray<T> to T\[\])

##### Declaration

```
public static implicit operator T[](in CompactSerializedArray<T> array)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [CompactSerializedArray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.CompactSerializedArray-1.html)<T> | array |     |

##### Returns

| Type | Description |
| --- | --- |
| T\[\] |     |