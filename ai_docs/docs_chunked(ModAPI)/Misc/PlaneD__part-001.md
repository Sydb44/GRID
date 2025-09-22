---
title: "Class PlaneD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.PlaneD.html"
category: "Misc"
namespace: "VRageMath"
class: "PlaneD"
---

# Class PlaneD | Space Engineers ModAPI

Defines a PlaneD.

##### Inheritance

System.Object

PlaneD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class PlaneD : ValueType, IEquatable<PlaneD>
```

### Constructors

#### PlaneD(Double, Double, Double, Double)

Creates a new instance of PlaneD.

##### Declaration

```
public PlaneD(double a, double b, double c, double d)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | a   | X component of the normal defining the PlaneD. |
| System.Double | b   | Y component of the normal defining the PlaneD. |
| System.Double | c   | Z component of the normal defining the PlaneD. |
| System.Double | d   | Distance of the origin from the PlaneD along its normal. |

#### PlaneD(Vector3D, Double)

Creates a new instance of PlaneD.

##### Declaration

```
public PlaneD(Vector3D normal, double d)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | normal | The normal vector to the PlaneD. |
| System.Double | d   | The distance of the origin from the PlaneD along its normal. |

#### PlaneD(Vector3D, Vector3)

Creates a new instance of Plane.

##### Declaration

```
public PlaneD(Vector3D position, Vector3 normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | A point that lies on the Plane |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal | The normal vector to the Plane. |

#### PlaneD(Vector3D, Vector3D)

Creates a new instance of Plane.

##### Declaration

```
public PlaneD(Vector3D position, Vector3D normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | A point that lies on the Plane |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | normal | The normal vector to the Plane. |

#### PlaneD(Vector3D, Vector3D, Vector3D)

Creates a new instance of PlaneD.

##### Declaration

```
public PlaneD(Vector3D point1, Vector3D point2, Vector3D point3)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point1 | One point of a triangle defining the PlaneD. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point2 | One point of a triangle defining the PlaneD. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point3 | One point of a triangle defining the PlaneD. |

#### PlaneD(Vector4)

Creates a new instance of PlaneD.

##### Declaration

```
public PlaneD(Vector4 value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | value | Vector4 with X, Y, and Z components defining the normal of the PlaneD. The W component defines the distance of the origin from the PlaneD along its normal. |

### Fields

#### D

The distance of the PlaneD along its normal from the origin. Note: Be careful! The distance is signed and is the opposite of what people usually expect. If you look closely at the plane equation: (n dot P) + D = 0, you'll realize that D = - (n dot P) (that is, negative instead of positive)

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Normal

The normal vector of the PlaneD.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### DistanceToPoint(Vector3D)

##### Declaration

```
public double DistanceToPoint(Vector3D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### DistanceToPoint(ref Vector3D)

##### Declaration

```
public double DistanceToPoint(ref Vector3D point)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | point |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### Dot(Vector4)

Calculates the dot product of a specified Vector4 and this PlaneD.

##### Declaration

```
public double Dot(Vector4 value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | value | The Vector4 to multiply this PlaneD by. |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### Dot(ref Vector4, out Double)

Calculates the dot product of a specified Vector4 and this PlaneD.

##### Declaration

```
public void Dot(ref Vector4 value, out double result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | value | The Vector4 to multiply this PlaneD by. |
| System.Double | result | \[OutAttribute\] The dot product of the specified Vector4 and this PlaneD. |
