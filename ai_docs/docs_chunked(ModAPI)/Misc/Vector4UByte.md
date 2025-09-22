---
title: "Class Vector4UByte"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4UByte.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector4UByte"
---

# Class Vector4UByte | Space Engineers ModAPI

##### Inheritance

System.Object

Vector4UByte

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector4UByte : ValueType
```

### [](#constructors)Constructors

#### [](#VRageMath_Vector4UByte__ctor_System_Byte_System_Byte_System_Byte_System_Byte_)Vector4UByte(Byte, Byte, Byte, Byte)

##### Declaration

```
public Vector4UByte(byte x, byte y, byte z, byte w)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | x   |     |
| System.Byte | y   |     |
| System.Byte | z   |     |
| System.Byte | w   |     |

### [](#fields)Fields

#### [](#VRageMath_Vector4UByte_W)W

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### [](#VRageMath_Vector4UByte_X)X

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### [](#VRageMath_Vector4UByte_Y)Y

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### [](#VRageMath_Vector4UByte_Z)Z

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

### [](#properties)Properties

#### [](#VRageMath_Vector4UByte_Item_System_Int32_)Item\[Int32\]

##### Declaration

```
public byte this[int index] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

### [](#methods)Methods

#### [](#VRageMath_Vector4UByte_Normalize_VRageMath_Vector3_System_Single_)Normalize(Vector3, Single)

Normalizes Vector3 into Vector4UByte, scales vector from (-range, range) to (0, 255)

##### Declaration

```
public static Vector4UByte Normalize(Vector3 vec, float range)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vec |     |
| System.Single | range |     |

##### Returns

#### [](#VRageMath_Vector4UByte_Round_VRageMath_Vector3_)Round(Vector3)

##### Declaration

```
public static Vector4UByte Round(Vector3 vec)
```

##### Parameters

##### Returns

#### [](#VRageMath_Vector4UByte_Round_VRageMath_Vector4_)Round(Vector4)

##### Declaration

```
public static Vector4UByte Round(Vector4 vec)
```

##### Parameters

##### Returns

#### [](#VRageMath_Vector4UByte_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |