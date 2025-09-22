---
title: "Class MyCellCoord"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyCellCoord.html"
category: "Misc"
namespace: "VRage.Voxels"
class: "MyCellCoord"
---

# Class MyCellCoord | Space Engineers ModAPI

##### Inheritance

System.Object

MyCellCoord

###### **Namespace**: [VRage.Voxels](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public sealed class MyCellCoord : ValueType, IComparable<MyCellCoord>, IEquatable<MyCellCoord>
```

### Constructors

#### MyCellCoord(Int32, Vector3I)

##### Declaration

```
public MyCellCoord(int lod, Vector3I coordInLod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | coordInLod |     |

#### MyCellCoord(Int32, ref Vector3I)

##### Declaration

```
public MyCellCoord(int lod, ref Vector3I coordInLod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | coordInLod |     |

#### MyCellCoord(UInt64)

##### Declaration

```
public MyCellCoord(ulong packedId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | packedId |     |

### Fields

#### Comparer

##### Declaration

```
public static readonly MyCellCoord.EqualityComparer Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCellCoord.EqualityComparer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyCellCoord.EqualityComparer.html) |     |

#### CoordInLod

##### Declaration

```
public Vector3I CoordInLod
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Lod

0 is the most detailed.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MAX\_LOD\_COUNT

##### Declaration

```
public const int MAX_LOD_COUNT = 16
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### CompareTo(MyCellCoord)

##### Declaration

```
public int CompareTo(MyCellCoord other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCellCoord](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyCellCoord.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(MyCellCoord)

##### Declaration

```
public bool Equals(MyCellCoord other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCellCoord](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyCellCoord.html) | other |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetClipmapCellHash(UInt32, UInt64)

##### Declaration

```
public static ulong GetClipmapCellHash(uint clipmap, ulong cellId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | clipmap |     |
| System.UInt64 | cellId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### GetClipmapCellHash(UInt32, MyCellCoord)

##### Declaration

```
public static ulong GetClipmapCellHash(uint clipmap, MyCellCoord cellId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | clipmap |     |
| [MyCellCoord](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyCellCoord.html) | cellId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### IsCoord64Valid()

##### Declaration

```
public bool IsCoord64Valid()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PackId32()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### PackId64()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### PackId64Static(Int32, Vector3I)

##### Declaration

```
public static ulong PackId64Static(int lod, Vector3I coordInLod)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | coordInLod |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### SetUnpack(UInt32)

##### Declaration

```
public void SetUnpack(uint id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | id  |     |

#### SetUnpack(UInt64)

##### Declaration

```
public void SetUnpack(ulong id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | id  |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### UnpackCoord(UInt64)

##### Declaration

```
public static Vector3I UnpackCoord(ulong id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### UnpackLod(UInt64)

##### Declaration

```
public static int UnpackLod(ulong id)
```
