---
title: "Class ColorDefinitionRGBA"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html"
category: "Misc"
namespace: "VRage.Game"
class: "ColorDefinitionRGBA"
---

# Class ColorDefinitionRGBA | Space Engineers ModAPI

##### Inheritance

System.Object

ColorDefinitionRGBA

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class ColorDefinitionRGBA : ValueType
```

### Constructors

#### ColorDefinitionRGBA(Byte, Byte, Byte, Byte)

##### Declaration

```
public ColorDefinitionRGBA(byte red, byte green, byte blue, byte alpha = 255)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | red |     |
| System.Byte | green |     |
| System.Byte | blue |     |
| System.Byte | alpha |     |

#### ColorDefinitionRGBA(String)

##### Declaration

```
public ColorDefinitionRGBA(string hex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | hex |     |

### Fields

#### A

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### B

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### G

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### R

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Byte |     |

### Properties

#### Alpha

##### Declaration

```
public byte Alpha { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Blue

##### Declaration

```
public byte Blue { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Green

##### Declaration

```
public byte Green { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### Hex

##### Declaration

```
public string Hex { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Red

##### Declaration

```
public byte Red { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

### Methods

#### ShouldSerializeAlpha()

##### Declaration

```
public bool ShouldSerializeAlpha()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeBlue()

##### Declaration

```
public bool ShouldSerializeBlue()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeGreen()

##### Declaration

```
public bool ShouldSerializeGreen()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeHex()

##### Declaration

```
public bool ShouldSerializeHex()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldSerializeRed()

##### Declaration

```
public bool ShouldSerializeRed()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Implicit(ColorDefinitionRGBA to Color)

##### Declaration

```
public static implicit operator Color(ColorDefinitionRGBA definitionRgba)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ColorDefinitionRGBA](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html) | definitionRgba |     |

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### Implicit(ColorDefinitionRGBA to Vector4)

##### Declaration

```
public static implicit operator Vector4(ColorDefinitionRGBA definitionRgba)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [ColorDefinitionRGBA](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html) | definitionRgba |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) |     |

#### Implicit(Color to ColorDefinitionRGBA)

##### Declaration

```
public static implicit operator ColorDefinitionRGBA(Color color)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |

##### Returns

| Type | Description |
| --- | --- |
| [ColorDefinitionRGBA](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html) |     |

#### Implicit(Vector4 to ColorDefinitionRGBA)

##### Declaration

```
public static implicit operator ColorDefinitionRGBA(Vector4 vector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | vector |     |

##### Returns

| Type | Description |
| --- | --- |
| [ColorDefinitionRGBA](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ColorDefinitionRGBA.html) |     |