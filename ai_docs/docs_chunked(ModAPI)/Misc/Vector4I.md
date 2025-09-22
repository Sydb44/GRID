---
title: "Class Vector4I"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4I.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector4I"
---

# Class Vector4I | Space Engineers ModAPI

##### Inheritance

System.Object

Vector4I

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector4I : ValueType, IComparable<Vector4I>
```

### [](#constructors)Constructors

#### [](#VRageMath_Vector4I__ctor_System_Int32_System_Int32_System_Int32_System_Int32_)Vector4I(Int32, Int32, Int32, Int32)

##### Declaration

```
public Vector4I(int x, int y, int z, int w)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   |     |
| System.Int32 | y   |     |
| System.Int32 | z   |     |
| System.Int32 | w   |     |

#### [](#VRageMath_Vector4I__ctor_VRageMath_Vector3I_System_Int32_)Vector4I(Vector3I, Int32)

##### Declaration

```
public Vector4I(Vector3I xyz, int w)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | xyz |     |
| System.Int32 | w   |     |

### [](#fields)Fields

#### [](#VRageMath_Vector4I_Comparer)Comparer

##### Declaration

```
public static readonly Vector4I.EqualityComparer Comparer
```

##### Field Value

#### [](#VRageMath_Vector4I_W)W

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_Vector4I_X)X

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_Vector4I_Y)Y

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_Vector4I_Z)Z

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#properties)Properties

#### [](#VRageMath_Vector4I_Item_System_Int32_)Item\[Int32\]

##### Declaration

```
public int this[int index] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#methods)Methods

#### [](#VRageMath_Vector4I_CompareTo_VRageMath_Vector4I_)CompareTo(Vector4I)

##### Declaration

```
public int CompareTo(Vector4I other)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_Vector4I_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### [](#operators)Operators

#### [](#VRageMath_Vector4I_op_Explicit_VRageMath_Vector4I__VRageMath_PackedVector_Byte4)Explicit(Vector4I to Byte4)

##### Declaration

```
public static explicit operator Byte4(Vector4I xyzw)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| VRageMath.PackedVector.Byte4 |     |