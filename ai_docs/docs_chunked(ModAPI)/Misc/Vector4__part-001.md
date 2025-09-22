---
title: "Class Vector4"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector4"
---

# Class Vector4 | Space Engineers ModAPI

Defines a vector with four components.

##### Inheritance

System.Object

Vector4

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Vector4 : ValueType, IEquatable<Vector4>
```

### [](#constructors)Constructors

#### [](#VRageMath_Vector4__ctor_System_Single_)Vector4(Single)

Creates a new instance of Vector4.

##### Declaration

```
public Vector4(float value)
```

##### Parameters

Type

Name

Description

System.Single

value

Value to initialize each component to.

#### [](#VRageMath_Vector4__ctor_System_Single_System_Single_System_Single_System_Single_)Vector4(Single, Single, Single, Single)

Initializes a new instance of Vector4.

##### Declaration

```
public Vector4(float x, float y, float z, float w)
```

##### Parameters

Type

Name

Description

System.Single

x

Initial value for the x-component of the vector.

System.Single

y

Initial value for the y-component of the vector.

System.Single

z

Initial value for the z-component of the vector.

System.Single

w

Initial value for the w-component of the vector.

#### [](#VRageMath_Vector4__ctor_VRageMath_Vector2_System_Single_System_Single_)Vector4(Vector2, Single, Single)

Initializes a new instance of Vector4.

##### Declaration

```
public Vector4(Vector2 value, float z, float w)
```

##### Parameters

Type

Name

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

value

A vector containing the values to initialize x and y components with.

System.Single

z

Initial value for the z-component of the vector.

System.Single

w

Initial value for the w-component of the vector.

#### [](#VRageMath_Vector4__ctor_VRageMath_Vector3_System_Single_)Vector4(Vector3, Single)

Initializes a new instance of Vector4.

##### Declaration

```
public Vector4(Vector3 value, float w)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

value

A vector containing the values to initialize x, y, and z components with.

System.Single

w

Initial value for the w-component of the vector.

### [](#fields)Fields

#### [](#VRageMath_Vector4_One)One

##### Declaration

```
public static Vector4 One
```

##### Field Value

#### [](#VRageMath_Vector4_UnitW)UnitW

##### Declaration

```
public static Vector4 UnitW
```

##### Field Value

#### [](#VRageMath_Vector4_UnitX)UnitX

##### Declaration

```
public static Vector4 UnitX
```

##### Field Value

#### [](#VRageMath_Vector4_UnitY)UnitY

##### Declaration

```
public static Vector4 UnitY
```

##### Field Value

#### [](#VRageMath_Vector4_UnitZ)UnitZ

##### Declaration

```
public static Vector4 UnitZ
```

##### Field Value

#### [](#VRageMath_Vector4_W)W

Gets or sets the w-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Single

#### [](#VRageMath_Vector4_X)X

Gets or sets the x-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Single

#### [](#VRageMath_Vector4_Y)Y

Gets or sets the y-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Single

#### [](#VRageMath_Vector4_Z)Z

Gets or sets the z-component of the vector.

##### Declaration

##### Field Value

Type

Description

System.Single

#### [](#VRageMath_Vector4_Zero)Zero

##### Declaration

```
public static Vector4 Zero
```

##### Field Value

### [](#properties)Properties

#### [](#VRageMath_Vector4_Item_System_Int32_)Item\[Int32\]

##### Declaration

```
public float this[int index] { get; set; }
```

##### Parameters

Type

Name

Description

System.Int32

index

##### Property Value

Type

Description

System.Single

### [](#methods)Methods

#### [](#VRageMath_Vector4_Add_VRageMath_Vector4_VRageMath_Vector4_)Add(Vector4, Vector4)

Adds two vectors.

##### Declaration

```
public static Vector4 Add(Vector4 value1, Vector4 value2)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source vector.

##### Returns

#### [](#VRageMath_Vector4_Add_VRageMath_Vector4__VRageMath_Vector4__VRageMath_Vector4__)Add(ref Vector4, ref Vector4, out Vector4)

Adds two vectors.

##### Declaration

```
public static void Add(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

Source vector.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

result

\[OutAttribute\] Sum of the source vectors.

#### [](#VRageMath_Vector4_Barycentric_VRageMath_Vector4_VRageMath_Vector4_VRageMath_Vector4_System_Single_System_Single_)Barycentric(Vector4, Vector4, Vector4, Single, Single)

Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 4D triangle.

##### Declaration

```
public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2)
```

##### Parameters

Type

Name

Description

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value1

A Vector4 containing the 4D Cartesian coordinates of vertex 1 of the triangle.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value2

A Vector4 containing the 4D Cartesian coordinates of vertex 2 of the triangle.

[Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html)

value3

A Vector4 containing the 4D Cartesian coordinates of vertex 3 of the triangle.

System.Single

amount1

Barycentric coordinate b2, which expresses the weighting factor toward vertex 2 (specified in value2).

System.Single

amount2

Barycentric coordinate b3, which expresses the weighting factor toward vertex 3 (specified in value3).
