---
title: "Class Vector4D"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector4D"
---

# Class Vector4D | Space Engineers ModAPI

Defines a vector with four components.

##### Inheritance

System.Object

Vector4D

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector4D : ValueType, IEquatable<Vector4>
```

### [](#constructors)Constructors

#### [](#VRageMath_Vector4D__ctor_System_Double_)Vector4D(Double)

Creates a new instance of Vector4.

##### Declaration

```
public Vector4D(double value)
```

##### Parameters

Type

Name

Description

System.Double

value

Value to initialize each component to.

#### [](#VRageMath_Vector4D__ctor_System_Double_System_Double_System_Double_System_Double_)Vector4D(Double, Double, Double, Double)

Initializes a new instance of Vector4.

##### Declaration

```
public Vector4D(double x, double y, double z, double w)
```

##### Parameters

Type

Name

Description

System.Double

x

Initial value for the x-component of the vector.

System.Double

y

Initial value for the y-component of the vector.

System.Double

z

Initial value for the z-component of the vector.

System.Double

w

Initial value for the w-component of the vector.

#### [](#VRageMath_Vector4D__ctor_VRageMath_Vector2_System_Double_System_Double_)Vector4D(Vector2, Double, Double)

Initializes a new instance of Vector4.

##### Declaration

```
public Vector4D(Vector2 value, double z, double w)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

A vector containing the values to initialize x and y components with.

System.Double

z

Initial value for the z-component of the vector.

System.Double

w

Initial value for the w-component of the vector.

#### [](#VRageMath_Vector4D__ctor_VRageMath_Vector3D_System_Double_)Vector4D(Vector3D, Double)

Initializes a new instance of Vector4.

##### Declaration

```
public Vector4D(Vector3D value, double w)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

value

A vector containing the values to initialize x, y, and z components with.

System.Double

w

Initial value for the w-component of the vector.

### [](#fields)Fields

#### [](#VRageMath_Vector4D_One)One

##### Declaration

```
public static Vector4D One
```

##### Field Value

#### [](#VRageMath_Vector4D_UnitW)UnitW

##### Declaration

```
public static Vector4D UnitW
```

##### Field Value

#### [](#VRageMath_Vector4D_UnitX)UnitX

##### Declaration

```
public static Vector4D UnitX
```

##### Field Value

#### [](#VRageMath_Vector4D_UnitY)UnitY

##### Declaration

```
public static Vector4D UnitY
```

##### Field Value

#### [](#VRageMath_Vector4D_UnitZ)UnitZ

##### Declaration

```
public static Vector4D UnitZ
```

##### Field Value

#### [](#VRageMath_Vector4D_W)W

Gets or sets the w-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Double

#### [](#VRageMath_Vector4D_X)X

Gets or sets the x-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Double

#### [](#VRageMath_Vector4D_Y)Y

Gets or sets the y-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Double

#### [](#VRageMath_Vector4D_Z)Z

Gets or sets the z-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Double

#### [](#VRageMath_Vector4D_Zero)Zero

##### Declaration

```
public static Vector4D Zero
```

##### Field Value

### [](#methods)Methods

#### [](#VRageMath_Vector4D_Add_VRageMath_Vector4D_VRageMath_Vector4D_)Add(Vector4D, Vector4D)

Adds two vectors.

##### Declaration

```
public static Vector4D Add(Vector4D value1, Vector4D value2)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Source vector.

##### Returns

#### [](#VRageMath_Vector4D_Add_VRageMath_Vector4D__VRageMath_Vector4D__VRageMath_Vector4D__)Add(ref Vector4D, ref Vector4D, out Vector4D)

Adds two vectors.

##### Declaration

```
public static void Add(ref Vector4D value1, ref Vector4D value2, out Vector4D result)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

Source vector.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

result

\[OutAttribute\] Sum of the source vectors.

#### [](#VRageMath_Vector4D_Barycentric_VRageMath_Vector4D_VRageMath_Vector4D_VRageMath_Vector4D_System_Double_System_Double_)Barycentric(Vector4D, Vector4D, Vector4D, Double, Double)

Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 4D triangle.

##### Declaration

```
public static Vector4D Barycentric(Vector4D value1, Vector4D value2, Vector4D value3, double amount1, double amount2)
```

##### Parameters

Type

Name

Description

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value1

A Vector4 containing the 4D Cartesian coordinates of vertex 1 of the triangle.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value2

A Vector4 containing the 4D Cartesian coordinates of vertex 2 of the triangle.

[Vector4D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4D.html)

value3

A Vector4 containing the 4D Cartesian coordinates of vertex 3 of the triangle.

System.Double

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Double

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).
