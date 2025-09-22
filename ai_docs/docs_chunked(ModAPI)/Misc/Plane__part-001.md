---
title: "Class Plane"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Plane.html"
category: "Misc"
namespace: "VRageMath"
class: "Plane"
---

# Class Plane | Space Engineers ModAPI

Defines a plane.

##### Inheritance

System.Object

Plane

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Plane : ValueType, IEquatable<Plane>
```

### Constructors

#### Plane(Single, Single, Single, Single)

Creates a new instance of Plane.

##### Declaration

```
public Plane(float a, float b, float c, float d)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | a   | X component of the normal defining the Plane. |
| System.Single | b   | Y component of the normal defining the Plane. |
| System.Single | c   | Z component of the normal defining the Plane. |
| System.Single | d   | Distance of the origin from the plane along its normal. |

#### Plane(Vector3, Single)

Creates a new instance of Plane.

##### Declaration

```
public Plane(Vector3 normal, float d)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal | The normal vector to the Plane. |
| System.Single | d   | Distance of the origin from the plane along its normal. |

#### Plane(Vector3, Vector3)

Creates a new instance of Plane.

##### Declaration

```
public Plane(Vector3 position, Vector3 normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | position | A point that lies on the Plane |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal | The normal vector to the Plane. |

#### Plane(Vector3, Vector3, Vector3)

Creates a new instance of Plane.

##### Declaration

```
public Plane(Vector3 point1, Vector3 point2, Vector3 point3)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point1 | One point of a triangle defining the Plane. |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point2 | One point of a triangle defining the Plane. |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point3 | One point of a triangle defining the Plane. |

#### Plane(ref Vector3, ref Vector3, ref Vector3)

##### Declaration

```
public Plane(ref Vector3 point1, ref Vector3 point2, ref Vector3 point3)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point1 |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point2 |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point3 |     |

#### Plane(Vector4)

Creates a new instance of Plane.

##### Declaration

```
public Plane(Vector4 value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | value | Vector4 with X, Y, and Z components defining the normal of the Plane. The W component defines the distance of the origin from the plane along its normal. |

### Fields

#### D

The distance of the Plane along its normal from the origin. Note: Be careful! The distance is signed and is the opposite of what people usually expect. If you look closely at the plane equation: (n dot P) - D = 0, you'll realize that D = - (n dot P) (that is, negative instead of positive)

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Normal

The normal vector of the Plane.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods

#### Dot(Vector4)

Calculates the dot product of a specified Vector4 and this Plane.

##### Declaration

```
public float Dot(Vector4 value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | value | The Vector4 to multiply this Plane by. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Dot(ref Vector4, out Single)

Calculates the dot product of a specified Vector4 and this Plane.

##### Declaration

```
public void Dot(ref Vector4 value, out float result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | value | The Vector4 to multiply this Plane by. |
| System.Single | result | \[OutAttribute\] The dot product of the specified Vector4 and this Plane. |

#### DotCoordinate(Vector3)

Returns the dot product of a specified Vector3 and the Normal vector of this Plane plus the distance (D) value of the Plane.

##### Declaration

```
public float DotCoordinate(Vector3 value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | value | The Vector3 to multiply by. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### DotCoordinate(ref Vector3, out Single)

Returns the dot product of a specified Vector3 and the Normal vector of this Plane plus the distance (D) value of the Plane.

##### Declaration

```
public void DotCoordinate(ref Vector3 value, out float result)
```
