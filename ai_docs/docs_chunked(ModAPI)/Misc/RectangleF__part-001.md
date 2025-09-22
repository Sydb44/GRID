---
title: "Class RectangleF"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RectangleF.html"
category: "Misc"
namespace: "VRageMath"
class: "RectangleF"
---

# Class RectangleF | Space Engineers ModAPI

Structure using the same layout than System.Drawing.RectangleF

##### Inheritance

System.Object

RectangleF

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class RectangleF : ValueType, IEquatable<RectangleF>
```

### [](#constructors)Constructors

#### [](#VRageMath_RectangleF__ctor_System_Single_System_Single_System_Single_System_Single_)RectangleF(Single, Single, Single, Single)

Initializes a new instance of the [RectangleF](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RectangleF.html) struct.

##### Declaration

```
public RectangleF(float x, float y, float width, float height)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | x   | The x. |
| System.Single | y   | The y. |
| System.Single | width | The width. |
| System.Single | height | The height. |

#### [](#VRageMath_RectangleF__ctor_VRageMath_Vector2_VRageMath_Vector2_)RectangleF(Vector2, Vector2)

Initializes a new instance of the [RectangleF](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RectangleF.html) struct.

##### Declaration

```
public RectangleF(Vector2 position, Vector2 size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | position | The x-y position of this rectangle. |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | size | The x-y size of this rectangle. |

### [](#fields)Fields

#### [](#VRageMath_RectangleF_Position)Position

The Position.

##### Declaration

##### Field Value

#### [](#VRageMath_RectangleF_Size)Size

The Size.

##### Declaration

##### Field Value

### [](#properties)Properties

#### [](#VRageMath_RectangleF_Bottom)Bottom

##### Declaration

```
public float Bottom { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_RectangleF_Center)Center

##### Declaration

```
public Vector2 Center { get; }
```

##### Property Value

#### [](#VRageMath_RectangleF_Height)Height

Height of this rectangle.

##### Declaration

```
public float Height { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_RectangleF_Right)Right

##### Declaration

```
public float Right { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_RectangleF_Width)Width

Width of this rectangle.

##### Declaration

```
public float Width { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_RectangleF_X)X

Left coordinate.

##### Declaration

```
public float X { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRageMath_RectangleF_Y)Y

Top coordinate.

##### Declaration

```
public float Y { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#methods)Methods

#### [](#VRageMath_RectangleF_Contains_System_Int32_System_Int32_)Contains(Int32, Int32)

##### Declaration

```
public bool Contains(int x, int y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   |     |
| System.Int32 | y   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_RectangleF_Contains_System_Single_System_Single_)Contains(Single, Single)

##### Declaration

```
public bool Contains(float x, float y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | x   |     |
| System.Single | y   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_RectangleF_Contains_VRageMath_Point_)Contains(Point)

##### Declaration

```
public bool Contains(Point point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_RectangleF_Contains_VRageMath_Vector2_)Contains(Vector2)

##### Declaration

```
public bool Contains(Vector2 vector2D)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | vector2D |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_RectangleF_Equals_System_Object_)Equals(Object)

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_RectangleF_Equals_VRageMath_RectangleF_)Equals(RectangleF)

Equals to other rectangle

##### Declaration

```
public bool Equals(RectangleF other)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRageMath_RectangleF_GetHashCode)GetHashCode()

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRageMath_RectangleF_Intersect_VRageMath_RectangleF__VRageMath_RectangleF__VRageMath_RectangleF__)Intersect(ref RectangleF, ref RectangleF, out RectangleF)

Creates a Rectangle defining the area where one rectangle overlaps with another rectangle.
