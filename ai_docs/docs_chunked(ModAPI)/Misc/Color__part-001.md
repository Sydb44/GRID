---
title: "Class Color"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html"
category: "Misc"
namespace: "VRageMath"
class: "Color"
---

# Class Color | Space Engineers ModAPI

Represents a four-component color using red, green, blue, and alpha data.

##### Inheritance

System.Object

Color

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Color : ValueType, IPackedVector<uint>, IPackedVector, IEquatable<Color>
```

### Constructors

#### Color(Int32, Int32, Int32)

Creates a new instance of the class.

##### Declaration

```
public Color(int r, int g, int b)
```

##### Parameters

Type

Name

Description

System.Int32

r

Red component.

System.Int32

g

Green component.

System.Int32

b

Blue component.

#### Color(Int32, Int32, Int32, Int32)

Creates a new instance of the class.

##### Declaration

```
public Color(int r, int g, int b, int a)
```

##### Parameters

Type

Name

Description

System.Int32

r

Red component.

System.Int32

g

Green component.

System.Int32

b

Blue component.

System.Int32

a

Alpha component.

#### Color(Single)

##### Declaration

##### Parameters

Type

Name

Description

System.Single

rgb

#### Color(Single, Single, Single)

Creates a new instance of the class.

##### Declaration

```
public Color(float r, float g, float b)
```

##### Parameters

Type

Name

Description

System.Single

r

Red component.

System.Single

g

Green component.

System.Single

b

Blue component.

#### Color(Single, Single, Single, Single)

Creates a new instance of the class.

##### Declaration

```
public Color(float r, float g, float b, float a)
```

##### Parameters

Type

Name

Description

System.Single

r

Red component.

System.Single

g

Green component.

System.Single

b

Blue component.

System.Single

a

Alpha component.

#### Color(UInt32)

##### Declaration

```
public Color(uint packedValue)
```

##### Parameters

Type

Name

Description

System.UInt32

packedValue

#### Color(Color, Single)

##### Declaration

```
public Color(Color color, float a)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

System.Single

a

#### Color(Vector3)

Creates a new instance of the class.

##### Declaration

```
public Color(Vector3 vector)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

vector

A three-component color.

#### Color(Vector4)

Creates a new instance of the class.

##### Declaration

```
public Color(Vector4 vector)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

vector

A four-component color.

### Fields

#### PackedValue

Gets the current color as a packed value.

##### Declaration

##### Field Value

Type

Description

System.UInt32

### Properties

#### A

Gets or sets the alpha component value.

##### Declaration

```
public byte A { get; set; }
```

##### Property Value

Type

Description

System.Byte

#### AliceBlue

Gets a system-defined color with the value R:240 G:248 B:255 A:255.

##### Declaration

```
public static Color AliceBlue { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### AntiqueWhite

Gets a system-defined color with the value R:250 G:235 B:215 A:255.

##### Declaration

```
public static Color AntiqueWhite { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Aqua

Gets a system-defined color with the value R:0 G:255 B:255 A:255.

##### Declaration

```
public static Color Aqua { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Aquamarine

Gets a system-defined color with the value R:127 G:255 B:212 A:255.

##### Declaration

```
public static Color Aquamarine { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Azure

Gets a system-defined color with the value R:240 G:255 B:255 A:255.

##### Declaration

```
public static Color Azure { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### B

Gets or sets the blue component value of this Color.

##### Declaration

```
public byte B { get; set; }
```

##### Property Value

Type

Description

System.Byte

#### Beige

Gets a system-defined color with the value R:245 G:245 B:220 A:255.

##### Declaration

```
public static Color Beige { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Bisque

Gets a system-defined color with the value R:255 G:228 B:196 A:255.

##### Declaration

```
public static Color Bisque { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Black

Gets a system-defined color with the value R:0 G:0 B:0 A:255.

##### Declaration

```
public static Color Black { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### BlanchedAlmond

Gets a system-defined color with the value R:255 G:235 B:205 A:255.

##### Declaration

```
public static Color BlanchedAlmond { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Blue

Gets a system-defined color with the value R:0 G:0 B:255 A:255.
