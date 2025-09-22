```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Thistle

Gets a system-defined color with the value R:216 G:191 B:216 A:255.

##### Declaration

```
public static Color Thistle { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Tomato

Gets a system-defined color with the value R:255 G:99 B:71 A:255.

##### Declaration

```
public static Color Tomato { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Transparent

Gets a system-defined color with the value R:0 G:0 B:0 A:0.

##### Declaration

```
public static Color Transparent { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Turquoise

Gets a system-defined color with the value R:64 G:224 B:208 A:255.

##### Declaration

```
public static Color Turquoise { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Violet

Gets a system-defined color with the value R:238 G:130 B:238 A:255.

##### Declaration

```
public static Color Violet { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Wheat

Gets a system-defined color with the value R:245 G:222 B:179 A:255.

##### Declaration

```
public static Color Wheat { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### White

Gets a system-defined color with the value R:255 G:255 B:255 A:255.

##### Declaration

```
public static Color White { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### WhiteSmoke

Gets a system-defined color with the value R:245 G:245 B:245 A:255.

##### Declaration

```
public static Color WhiteSmoke { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### X

Gets or sets the red component value of this Color.

##### Declaration

```
public byte X { get; set; }
```

##### Property Value

Type

Description

System.Byte

#### Y

Gets or sets the green component value of this Color.

##### Declaration

```
public byte Y { get; set; }
```

##### Property Value

Type

Description

System.Byte

#### Yellow

Gets a system-defined color with the value R:255 G:255 B:0 A:255.

##### Declaration

```
public static Color Yellow { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### YellowGreen

Gets a system-defined color with the value R:154 G:205 B:50 A:255.

##### Declaration

```
public static Color YellowGreen { get; }
```

##### Property Value

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Z

Gets or sets the blue component value of this Color.

##### Declaration

```
public byte Z { get; set; }
```

##### Property Value

Type

Description

System.Byte

### Methods

#### Darken(Color, Double)

##### Declaration

```
public static Color Darken(Color inColor, double inAmount)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

inColor

System.Double

inAmount

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### Equals(Object)

Test an instance of a color object to see if it is equal to this object.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

Type

Name

Description

System.Object

obj

A color object.

##### Returns

Type

Description

System.Boolean

#### Equals(Color)

Test a color to see if it is equal to the color in this instance.

##### Declaration

```
public bool Equals(Color other)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

other

A four-component color.

##### Returns

Type

Description

System.Boolean

#### FromNonPremultiplied(Int32, Int32, Int32, Int32)

Converts a non-premultipled alpha color to a color that contains premultiplied alpha.

##### Declaration

```
public static Color FromNonPremultiplied(int r, int g, int b, int a)
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

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### FromNonPremultiplied(Vector4)

Convert a non premultipled color into color data that contains alpha.

##### Declaration

```
public static Color FromNonPremultiplied(Vector4 vector)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

vector

A four-component color.

##### Returns

Type

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

#### GetHashCode()

Serves as a hash function for a particular type.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

Type

Description

System.Int32

#### Lerp(Color, Color, Single)

Linearly interpolate a color.

##### Declaration

```
public static Color Lerp(Color value1, Color value2, float amount)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

value1

A four-component color.

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

value2

A four-component color.

System.Single

amount

Interpolation factor.
