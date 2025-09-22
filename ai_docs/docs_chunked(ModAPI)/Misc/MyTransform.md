---
title: "Class MyTransform"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransform.html"
category: "Misc"
namespace: "VRageMath"
class: "MyTransform"
---

# Class MyTransform | Space Engineers ModAPI

##### Inheritance

System.Object

MyTransform

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class MyTransform : ValueType
```

### Constructors

#### MyTransform(Matrix)

##### Declaration

```
public MyTransform(Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix |     |

#### MyTransform(ref Matrix)

##### Declaration

```
public MyTransform(ref Matrix matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | matrix |     |

#### MyTransform(Vector3)

##### Declaration

```
public MyTransform(Vector3 position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | position |     |

#### MyTransform(ref Vector3)

##### Declaration

```
public MyTransform(ref Vector3 position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | position |     |

### Fields

#### Position

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

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
public Matrix TransformMatrix { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) |     |

### Methods

#### Transform(ref MyTransform, ref MyTransform)

##### Declaration

```
public static MyTransform Transform(ref MyTransform t1, ref MyTransform t2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTransform](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransform.html) | t1  |     |
| [MyTransform](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransform.html) | t2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyTransform](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransform.html) |     |

#### Transform(ref MyTransform, ref MyTransform, out MyTransform)

##### Declaration

```
public static void Transform(ref MyTransform t1, ref MyTransform t2, out MyTransform result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTransform](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransform.html) | t1  |     |
| [MyTransform](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransform.html) | t2  |     |
| [MyTransform](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransform.html) | result |     |

#### Transform(ref Vector3, ref MyTransform)

##### Declaration

```
public static Vector3 Transform(ref Vector3 v, ref MyTransform t2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v   |     |
| [MyTransform](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransform.html) | t2  |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Transform(ref Vector3, ref MyTransform, out Vector3)

##### Declaration

```
public static void Transform(ref Vector3 v, ref MyTransform t2, out Vector3 result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v   |     |
| [MyTransform](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyTransform.html) | t2  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | result |     |