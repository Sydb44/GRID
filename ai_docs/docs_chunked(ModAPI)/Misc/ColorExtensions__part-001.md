---
title: "Class ColorExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ColorExtensions.html"
category: "Misc"
namespace: "VRageMath"
class: "ColorExtensions"
---

# Class ColorExtensions | Space Engineers ModAPI

##### Inheritance

System.Object

ColorExtensions

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public static class ColorExtensions : Object
```

### Methods

#### Alpha(Color, Single)

##### Declaration

```
public static Color Alpha(this Color c, float a)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | c   |     |
| System.Single | a   |     |

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### ColorToHSV(Color)

##### Declaration

```
public static Vector3 ColorToHSV(this Color rgb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | rgb |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### ColorToHSVDX11(Color)

Use this for HSV in DX11 Renderer, X = Hue 0..1, Y = Saturation -1..1, Z = Value -1..1

##### Declaration

```
public static Vector3 ColorToHSVDX11(this Color rgb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | rgb |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### FromHtml(String)

##### Declaration

```
public static Nullable<Color> FromHtml(string htmlColor)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | htmlColor |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)\> |     |

#### HexToColor(String)

##### Declaration

```
public static Color HexToColor(string hex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | hex |     |

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### HexToVector4(String)

##### Declaration

```
public static Vector4 HexToVector4(string hex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | hex |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) |     |

#### HSVtoColor(Vector3)

##### Declaration

```
public static Color HSVtoColor(this Vector3 HSV)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | HSV |     |

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### HueDistance(Color, Single)

##### Declaration

```
public static float HueDistance(this Color color, float hue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.Single | hue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### HueDistance(Color, Color)

##### Declaration

```
public static float HueDistance(this Color color, Color otherColor)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | otherColor |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### PackHSVToUint(Vector3)

##### Declaration

```
public static uint PackHSVToUint(this Vector3 HSV)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | HSV |     |

##### Returns

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### PremultiplyColor(Vector4)

##### Declaration

```
public static Vector4 PremultiplyColor(this Vector4 c)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | c   |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) |     |

#### Shade(Color, Single)

##### Declaration

```
public static Color Shade(this Color c, float r)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | c   |     |
| System.Single | r   |     |

##### Returns

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### TemperatureToRGB(Single)

##### Declaration

```
public static Vector3 TemperatureToRGB(float temperature)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | temperature |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |
