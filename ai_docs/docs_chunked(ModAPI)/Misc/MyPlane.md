---
title: "Class MyPlane"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyPlane.html"
category: "Misc"
namespace: "VRage.Utils"
class: "MyPlane"
---

# Class MyPlane | Space Engineers ModAPI

##### Inheritance

System.Object

MyPlane

###### **Namespace**: [VRage.Utils](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public sealed class MyPlane : ValueType
```

### Constructors

#### MyPlane(ref MyTriangle\_Vertices)

##### Declaration

```
public MyPlane(ref MyTriangle_Vertices triangle)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyTriangle\_Vertices | triangle |     |

#### MyPlane(Vector3, Vector3)

##### Declaration

```
public MyPlane(Vector3 point, Vector3 normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal |     |

#### MyPlane(ref Vector3, ref Vector3)

##### Declaration

```
public MyPlane(ref Vector3 point, ref Vector3 normal)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | point |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | normal |     |

### Fields

#### Normal

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Point

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

### Methods

#### GetPlaneDistance()

##### Declaration

```
public float GetPlaneDistance()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |