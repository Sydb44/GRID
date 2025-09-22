---
title: "Class Quaternion"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html"
category: "Misc"
namespace: "VRageMath"
class: "Quaternion"
---

# Class Quaternion | Space Engineers ModAPI

Defines a four-dimensional vector (x,y,z,w), which is used to efficiently rotate an object about the (x, y, z) vector by the angle theta, where w = cos(theta/2).

##### Inheritance

System.Object

Quaternion

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Quaternion : ValueType, IEquatable<Quaternion>
```

### Constructors

#### Quaternion(Single, Single, Single, Single)

Initializes a new instance of Quaternion.

##### Declaration

```
public Quaternion(float x, float y, float z, float w)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | x   | The x-value of the quaternion. |
| System.Single | y   | The y-value of the quaternion. |
| System.Single | z   | The z-value of the quaternion. |
| System.Single | w   | The w-value of the quaternion. |

#### Quaternion(Vector3, Single)

Initializes a new instance of Quaternion.

##### Declaration

```
public Quaternion(Vector3 vectorPart, float scalarPart)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vectorPart | The vector component of the quaternion. |
| System.Single | scalarPart | The rotation component of the quaternion. |

### Fields

#### Identity

##### Declaration

```
public static Quaternion Identity
```

##### Field Value

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### W

Specifies the rotation component of the quaternion.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### X

Specifies the x-value of the vector component of the quaternion.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Y

Specifies the y-value of the vector component of the quaternion.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Z

Specifies the z-value of the vector component of the quaternion.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Zero

##### Declaration

```
public static Quaternion Zero
```

##### Field Value

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

### Properties

#### Forward

##### Declaration

```
public Vector3 Forward { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Right

##### Declaration

```
public Vector3 Right { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Up

##### Declaration

```
public Vector3 Up { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods

#### Add(Quaternion, Quaternion)

Adds two Quaternions.

##### Declaration

```
public static Quaternion Add(Quaternion quaternion1, Quaternion quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Quaternion to add. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Quaternion to add. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Add(ref Quaternion, ref Quaternion, out Quaternion)

Adds two Quaternions.

##### Declaration

```
public static void Add(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion1 | Quaternion to add. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | quaternion2 | Quaternion to add. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | result | \[OutAttribute\] Result of adding the Quaternions. |

#### Concatenate(Quaternion, Quaternion)

Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.

##### Declaration

```
public static Quaternion Concatenate(Quaternion value1, Quaternion value2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | value1 | The first Quaternion rotation in the series. |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) | value2 | The second Quaternion rotation in the series. |

##### Returns

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

#### Concatenate(ref Quaternion, ref Quaternion, out Quaternion)

Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.

##### Declaration

```
public static void Concatenate(ref Quaternion value1, ref Quaternion value2, out Quaternion result)
```
