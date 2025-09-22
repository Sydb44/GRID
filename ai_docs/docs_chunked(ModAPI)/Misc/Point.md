---
title: "Class Point"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html"
category: "Misc"
namespace: "VRageMath"
class: "Point"
---

# Class Point | Space Engineers ModAPI

Defines a point in 2D space.

##### Inheritance

System.Object

Point

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Point : ValueType, IEquatable<Point>
```

### Constructors

#### Point(Int32, Int32)

Initializes a new instance of Point.

##### Declaration

```
public Point(int x, int y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | x   | The x-coordinate of the Point. |
| System.Int32 | y   | The y-coordinate of the Point. |

### Fields

#### X

Specifies the x-coordinate of the Point.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Y

Specifies the y-coordinate of the Point.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### Zero

Returns the point (0,0).

##### Declaration

```
public static Point Zero { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) |     |

### Methods

#### Equals(Object)

Determines whether two Point instances are equal.

##### Declaration

```
public override bool Equals(object obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | obj | The object to compare this instance to. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Equals(Point)

Determines whether two Point instances are equal.

##### Declaration

```
public bool Equals(Point other)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) | other | The Point to compare this instance to. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode()

Gets the hash code for this object.

##### Declaration

```
public override int GetHashCode()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ToString()

Returns a String that represents the current Point.

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

### Operators

#### Equality(Point, Point)

Determines whether two Point instances are equal.

##### Declaration

```
public static bool operator ==(Point a, Point b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) | a   | Point on the left side of the equal sign. |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) | b   | Point on the right side of the equal sign. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Inequality(Point, Point)

Determines whether two Point instances are not equal.

##### Declaration

```
public static bool operator !=(Point a, Point b)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) | a   | The Point on the left side of the equal sign. |
| [Point](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Point.html) | b   | The Point on the right side of the equal sign. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |