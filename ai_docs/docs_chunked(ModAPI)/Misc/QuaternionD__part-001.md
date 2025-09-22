---
title: "Class QuaternionD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html"
category: "Misc"
namespace: "VRageMath"
class: "QuaternionD"
---

# Class QuaternionD | Space Engineers ModAPI

Defines a four-dimensional vector (x,y,z,w), which is used to efficiently rotate an object about the (x, y, z) vector by the angle theta, where w = cos(theta/2). Uses double precision floating point numbers for calculation and storage

##### Inheritance

System.Object

QuaternionD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class QuaternionD : ValueType
```

### Constructors

#### QuaternionD(Double, Double, Double, Double)

Initializes a new instance of QuaternionD.

##### Declaration

```
public QuaternionD(double x, double y, double z, double w)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | x   | The x-value of the quaternion. |
| System.Double | y   | The y-value of the quaternion. |
| System.Double | z   | The z-value of the quaternion. |
| System.Double | w   | The w-value of the quaternion. |

#### QuaternionD(Vector3D, Double)

Initializes a new instance of QuaternionD.

##### Declaration

```
public QuaternionD(Vector3D vectorPart, double scalarPart)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | vectorPart | The vector component of the quaternion. |
| System.Double | scalarPart | The rotation component of the quaternion. |

### Fields

#### Identity

##### Declaration

```
public static QuaternionD Identity
```

##### Field Value

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### W

Specifies the rotation component of the quaternion.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### X

Specifies the x-value of the vector component of the quaternion.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Y

Specifies the y-value of the vector component of the quaternion.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Z

Specifies the z-value of the vector component of the quaternion.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Double |     |

### Methods

#### Add(QuaternionD, QuaternionD)

Adds two Quaternions.

##### Declaration

```
public static QuaternionD Add(QuaternionD quaternion1, QuaternionD quaternion2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | QuaternionD to add. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | QuaternionD to add. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Add(ref QuaternionD, ref QuaternionD, out QuaternionD)

Adds two Quaternions.

##### Declaration

```
public static void Add(ref QuaternionD quaternion1, ref QuaternionD quaternion2, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion1 | QuaternionD to add. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | quaternion2 | QuaternionD to add. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] Result of adding the Quaternions. |

#### Concatenate(QuaternionD, QuaternionD)

Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.

##### Declaration

```
public static QuaternionD Concatenate(QuaternionD value1, QuaternionD value2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | value1 | The first QuaternionD rotation in the series. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | value2 | The second QuaternionD rotation in the series. |

##### Returns

| Type | Description |
| --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) |     |

#### Concatenate(ref QuaternionD, ref QuaternionD, out QuaternionD)

Concatenates two Quaternions; the result represents the value1 rotation followed by the value2 rotation.

##### Declaration

```
public static void Concatenate(ref QuaternionD value1, ref QuaternionD value2, out QuaternionD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | value1 | The first QuaternionD rotation in the series. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | value2 | The second QuaternionD rotation in the series. |
| [QuaternionD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.QuaternionD.html) | result | \[OutAttribute\] The QuaternionD rotation representing the concatenation of value1 followed by value2. |

#### Conjugate()

Transforms this QuaternionD into its conjugate.

##### Declaration

#### Conjugate(QuaternionD)

Returns the conjugate of a specified QuaternionD.

##### Declaration

```
public static QuaternionD Conjugate(QuaternionD value)
```
