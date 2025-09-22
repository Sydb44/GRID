---
title: "Class MathHelperD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MathHelperD.html"
category: "Misc"
namespace: "VRageMath"
class: "MathHelperD"
---

# Class MathHelperD | Space Engineers ModAPI

Contains commonly used precalculated values.

##### Inheritance

System.Object

MathHelperD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public static class MathHelperD : Object
```

### Fields

#### E

Represents the mathematical constant e.

##### Declaration

```
public const double E = 2.7182818284590451
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### FourPi

Represents the value of pi times four.

##### Declaration

```
public const double FourPi = 12.566370614359172
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Pi

Represents the value of pi.

##### Declaration

```
public const double Pi = 3.1415926535897931
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### PiOver2

Represents the value of pi divided by two.

##### Declaration

```
public const double PiOver2 = 1.5707963267948966
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### PiOver4

Represents the value of pi divided by four.

##### Declaration

```
public const double PiOver4 = 0.78539816339744828
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### TwoPi

Represents the value of pi times two.

##### Declaration

```
public const double TwoPi = 6.2831853071795862
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

### Methods

#### Clamp(Double, Double, Double)

Restricts a value to be within a specified range. Reference page contains links to related code samples.

##### Declaration

```
public static double Clamp(double value, double min, double max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | value | The value to clamp. |
| System.Double | min | The minimum value. If value is less than min, min will be returned. |
| System.Double | max | The maximum value. If value is greater than max, max will be returned. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### Distance(Double, Double)

Calculates the absolute value of the difference of two values.

##### Declaration

```
public static double Distance(double value1, double value2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | value1 | Source value. |
| System.Double | value2 | Source value. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### Max(Double, Double)

Returns the greater of two values.

##### Declaration

```
public static double Max(double value1, double value2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | value1 | Source value. |
| System.Double | value2 | Source value. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### Min(Double, Double)

Returns the lesser of two values.

##### Declaration

```
public static double Min(double value1, double value2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | value1 | Source value. |
| System.Double | value2 | Source value. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### MonotonicAcos(Single)

##### Declaration

```
public static float MonotonicAcos(float cos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | cos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ToDegrees(Double)

Converts radians to degrees.

##### Declaration

```
public static double ToDegrees(double radians)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | radians | The angle in radians. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### ToRadians(Double)

Converts degrees to radians.

##### Declaration

```
public static double ToRadians(double degrees)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | degrees | The angle in degrees. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |