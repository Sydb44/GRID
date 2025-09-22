---
title: "Class Rectangle"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html"
category: "Misc"
namespace: "VRageMath"
class: "Rectangle"
---

# Class Rectangle | Space Engineers ModAPI

Defines a rectangle.

##### Inheritance

System.Object

Rectangle

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Rectangle : ValueType, IEquatable<Rectangle>
```

### Constructors

#### Rectangle(Int32, Int32, Int32, Int32)

Initializes a new instance of Rectangle.

##### Declaration

```
public Rectangle(int x, int y, int width, int height)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   | The x-coordinate of the rectangle. |
| System.Int32 | y   | The y-coordinate of the rectangle. |
| System.Int32 | width | Width of the rectangle. |
| System.Int32 | height | Height of the rectangle. |

### Fields

#### Height

Specifies the height of the rectangle.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Width

Specifies the width of the rectangle.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### X

Specifies the x-coordinate of the rectangle.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Y

Specifies the y-coordinate of the rectangle.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### Bottom

Returns the y-coordinate of the bottom of the rectangle.

##### Declaration

```
public int Bottom { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Center

Gets the Point that specifies the center of the rectangle.

##### Declaration

```
public Point Center { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) |     |

#### Left

Returns the x-coordinate of the left side of the rectangle.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Location

Gets or sets the upper-left value of the Rectangle.

##### Declaration

```
public Point Location { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) |     |

#### Right

Returns the x-coordinate of the right side of the rectangle.

##### Declaration

```
public int Right { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Top

Returns the y-coordinate of the top of the rectangle.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Contains(Int32, Int32)

Determines whether this Rectangle contains a specified point represented by its x- and y-coordinates.

##### Declaration

```
public bool Contains(int x, int y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   | The x-coordinate of the specified point. |
| System.Int32 | y   | The y-coordinate of the specified point. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Contains(Point)

Determines whether this Rectangle contains a specified Point.

##### Declaration

```
public bool Contains(Point value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) | value | The Point to evaluate. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Contains(ref Point, out Boolean)

Determines whether this Rectangle contains a specified Point.

##### Declaration

```
public void Contains(ref Point value, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) | value | The Point to evaluate. |
| System.Boolean | result | \[OutAttribute\] true if the specified Point is contained within this Rectangle; false otherwise. |

#### Contains(Rectangle)

Determines whether this Rectangle entirely contains a specified Rectangle.

##### Declaration

```
public bool Contains(Rectangle value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value | The Rectangle to evaluate. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Contains(ref Rectangle, out Boolean)

Determines whether this Rectangle entirely contains a specified Rectangle.

##### Declaration

```
public void Contains(ref Rectangle value, out bool result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | value | The Rectangle to evaluate. |
| System.Boolean | result | \[OutAttribute\] On exit, is true if this Rectangle entirely contains the specified Rectangle, or false if not. |

#### Equals(Object)

Returns a value that indicates whether the current instance is equal to a specified object.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | Object to make the comparison with. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(Rectangle)

Determines whether the specified Object is equal to the Rectangle.

##### Declaration

```
public bool Equals(Rectangle other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Rectangle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Rectangle.html) | other | The Object to compare with the current Rectangle. |
