---
title: "Class Capsule"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Capsule.html"
category: "Misc"
namespace: "VRageMath"
class: "Capsule"
---

# Class Capsule | Space Engineers ModAPI

##### Inheritance

System.Object

Capsule

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public sealed class Capsule : ValueType
```

### Constructors

#### Capsule(Vector3, Vector3, Single)

##### Declaration

```
public Capsule(Vector3 p0, Vector3 p1, float radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p0  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p1  |     |
| System.Single | radius |     |

### Fields

#### P0

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### P1

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Radius

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Intersect(Line, ref Vector3, ref Vector3, ref Vector3, ref Vector3)

##### Declaration

```
public bool Intersect(Line line, ref Vector3 p1, ref Vector3 p2, ref Vector3 n1, ref Vector3 n2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html) | line |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p1  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p2  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | n1  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | n2  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Intersect(Ray, ref Vector3, ref Vector3, ref Vector3, ref Vector3)

##### Declaration

```
public bool Intersect(Ray ray, ref Vector3 p1, ref Vector3 p2, ref Vector3 n1, ref Vector3 n2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Ray](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Ray.html) | ray |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p1  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | p2  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | n1  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | n2  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |