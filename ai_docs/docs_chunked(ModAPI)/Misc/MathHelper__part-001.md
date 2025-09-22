---
title: "Class MathHelper"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MathHelper.html"
category: "Misc"
namespace: "VRageMath"
class: "MathHelper"
---

# Class MathHelper | Space Engineers ModAPI

Contains commonly used precalculated values.

##### Inheritance

System.Object

MathHelper

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public static class MathHelper : Object
```

### Fields

#### E

Represents the mathematical constant e.

##### Declaration

```
public const float E = 2.718282F
```

##### Field Value

Type

Description

System.Single

#### EPSILON

##### Declaration

```
public const float EPSILON = 1E-05F
```

##### Field Value

Type

Description

System.Single

#### EPSILON10

##### Declaration

```
public const float EPSILON10 = 1E-06F
```

##### Field Value

Type

Description

System.Single

#### FourPi

Represents the value of pi times two.

##### Declaration

```
public const float FourPi = 12.566371F
```

##### Field Value

Type

Description

System.Single

#### Log10E

Represents the log base ten of e.

##### Declaration

```
public const float Log10E = 0.4342945F
```

##### Field Value

Type

Description

System.Single

#### Log2E

Represents the log base two of e.

##### Declaration

```
public const float Log2E = 1.442695F
```

##### Field Value

Type

Description

System.Single

#### Pi

Represents the value of pi.

##### Declaration

```
public const float Pi = 3.141593F
```

##### Field Value

Type

Description

System.Single

#### PiOver2

Represents the value of pi divided by two.

##### Declaration

```
public const float PiOver2 = 1.570796F
```

##### Field Value

Type

Description

System.Single

#### PiOver4

Represents the value of pi divided by four.

##### Declaration

```
public const float PiOver4 = 0.7853982F
```

##### Field Value

Type

Description

System.Single

#### RadiansPerSecondToRPM

60 / 2\*pi

##### Declaration

```
public const float RadiansPerSecondToRPM = 9.549296F
```

##### Field Value

Type

Description

System.Single

#### RPMToRadiansPerMillisec

2\*pi / 60000

##### Declaration

```
public const float RPMToRadiansPerMillisec = 0.000104719758F
```

##### Field Value

Type

Description

System.Single

#### RPMToRadiansPerSecond

2\*pi / 60

##### Declaration

```
public const float RPMToRadiansPerSecond = 0.104719758F
```

##### Field Value

Type

Description

System.Single

#### Sqrt2

Represents the value of the square root of two

##### Declaration

```
public const float Sqrt2 = 1.41421354F
```

##### Field Value

Type

Description

System.Single

#### Sqrt3

Represents the value of the square root of three

##### Declaration

```
public const float Sqrt3 = 1.73205078F
```

##### Field Value

Type

Description

System.Single

#### TwoPi

Represents the value of pi times two.

##### Declaration

```
public const float TwoPi = 6.28318548F
```

##### Field Value

Type

Description

System.Single

### Methods

#### Align(Int32, Int32)

##### Declaration

```
public static int Align(int value, int alignment)
```

##### Parameters

Type

Name

Description

System.Int32

value

System.Int32

alignment

##### Returns

Type

Description

System.Int32

#### Atan(Double)

Faster Atan implementation.

Good only in the \[-pi/2, pi/2\] range.

##### Declaration

```
public static double Atan(double x)
```

##### Parameters

Type

Name

Description

System.Double

x

##### Returns

Type

Description

System.Double

#### Atan(Single)

Faster Atan implementation.

Good only in the \[-pi/2, pi/2\] range.

##### Declaration

```
public static float Atan(float x)
```

##### Parameters

Type

Name

Description

System.Single

x

##### Returns

Type

Description

System.Single

#### Barycentric(Single, Single, Single, Single, Single)

Returns the Cartesian coordinate for one axis of a point that is defined by a given triangle and two normalized barycentric (areal) coordinates.

##### Declaration

```
public static float Barycentric(float value1, float value2, float value3, float amount1, float amount2)
```

##### Parameters

Type

Name

Description

System.Single

value1

The coordinate on one axis of vertex 1 of the defining triangle.

System.Single

value2

The coordinate on the same axis of vertex 2 of the defining triangle.

System.Single

value3

The coordinate on the same axis of vertex 3 of the defining triangle.

System.Single

amount1

The normalized barycentric (areal) coordinate b2, equal to the weighting factor for vertex 2, the coordinate of which is specified in value2.

System.Single

amount2

The normalized barycentric (areal) coordinate b3, equal to the weighting factor for vertex 3, the coordinate of which is specified in value3.

##### Returns

Type

Description

System.Single

#### CalculateBezierPoint(Double, Vector3D, Vector3D, Vector3D, Vector3D)

##### Declaration

```
public static Vector3D CalculateBezierPoint(double t, Vector3D p0, Vector3D p1, Vector3D p2, Vector3D p3)
```

##### Parameters

Type

Name

Description

System.Double

t

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p0

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p1

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p2

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

p3

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### CalculateVectorOnSphere(Vector3, Single, Single)

##### Declaration

```
public static Vector3 CalculateVectorOnSphere(Vector3 northPoleDir, float phi, float theta)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

northPoleDir

System.Single

phi

System.Single

theta
