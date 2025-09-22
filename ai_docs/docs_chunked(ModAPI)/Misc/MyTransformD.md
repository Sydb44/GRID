---
title: "Class MyTransformD"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransformD.html"
category: "Misc"
namespace: "VRageMath"
class: "MyTransformD"
---

# Class MyTransformD | Space Engineers ModAPI

##### Inheritance

System.Object

MyTransformD

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class MyTransformD : ValueType
```

### Constructors

#### MyTransformD(MatrixD)

##### Declaration

```
public MyTransformD(MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |

#### MyTransformD(ref MatrixD)

##### Declaration

```
public MyTransformD(ref MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |

#### MyTransformD(Vector3D)

##### Declaration

```
public MyTransformD(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |

#### MyTransformD(ref Vector3D)

##### Declaration

```
public MyTransformD(ref Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |

### Fields

#### Position

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Rotation

##### Declaration

```
[Serialize]
public Quaternion Rotation
```

##### Field Value

| Type | Description |
| --- | --- |
| [Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html) |     |

### Properties

#### TransformMatrix

##### Declaration

```
public MatrixD TransformMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

### Methods

#### Transform(ref MyTransformD, ref MyTransformD)

##### Declaration

```
public static MyTransformD Transform(ref MyTransformD t1, ref MyTransformD t2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTransformD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransformD.html) | t1  |     |
| [MyTransformD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransformD.html) | t2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyTransformD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransformD.html) |     |

#### Transform(ref MyTransformD, ref MyTransformD, out MyTransformD)

##### Declaration

```
public static void Transform(ref MyTransformD t1, ref MyTransformD t2, out MyTransformD result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTransformD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransformD.html) | t1  |     |
| [MyTransformD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransformD.html) | t2  |     |
| [MyTransformD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransformD.html) | result |     |

#### Transform(ref Vector3D, ref MyTransformD)

##### Declaration

```
public static Vector3D Transform(ref Vector3D v, ref MyTransformD t2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | v   |     |
| [MyTransformD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransformD.html) | t2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Transform(ref Vector3D, ref MyTransformD, out Vector3D)

##### Declaration

```
public static void Transform(ref Vector3D v, ref MyTransformD t2, out Vector3D result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | v   |     |
| [MyTransformD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransformD.html) | t2  |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | result |     |