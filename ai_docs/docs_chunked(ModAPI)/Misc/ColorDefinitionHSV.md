---
title: "Class ColorDefinitionHSV"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionHSV.html"
category: "Misc"
namespace: "VRage.Game"
class: "ColorDefinitionHSV"
---

# Class ColorDefinitionHSV | Space Engineers ModAPI

##### Inheritance

System.Object

ColorDefinitionHSV

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class ColorDefinitionHSV : ValueType
```

### [](#fields)Fields

#### [](#VRage_Game_ColorDefinitionHSV_H)H

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ColorDefinitionHSV_S)S

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ColorDefinitionHSV_V)V

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#properties)Properties

#### [](#VRage_Game_ColorDefinitionHSV_Hue)Hue

##### Declaration

```
public int Hue { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ColorDefinitionHSV_Saturation)Saturation

##### Declaration

```
public int Saturation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ColorDefinitionHSV_Value)Value

##### Declaration

```
public int Value { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#methods)Methods

#### [](#VRage_Game_ColorDefinitionHSV_IsValid)IsValid()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ColorDefinitionHSV_ShouldSerializeHue)ShouldSerializeHue()

##### Declaration

```
public bool ShouldSerializeHue()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ColorDefinitionHSV_ShouldSerializeSaturation)ShouldSerializeSaturation()

##### Declaration

```
public bool ShouldSerializeSaturation()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ColorDefinitionHSV_ShouldSerializeValue)ShouldSerializeValue()

##### Declaration

```
public bool ShouldSerializeValue()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ColorDefinitionHSV_ToString)ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### [](#operators)Operators

#### [](#VRage_Game_ColorDefinitionHSV_op_Implicit_VRage_Game_ColorDefinitionHSV__VRageMath_Vector3)Implicit(ColorDefinitionHSV to Vector3)

##### Declaration

```
public static implicit operator Vector3(ColorDefinitionHSV definition)
```

##### Parameters

##### Returns

#### [](#VRage_Game_ColorDefinitionHSV_op_Implicit_VRageMath_Vector3__VRage_Game_ColorDefinitionHSV)Implicit(Vector3 to ColorDefinitionHSV)

##### Declaration

```
public static implicit operator ColorDefinitionHSV(Vector3 vector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vector |     |

##### Returns