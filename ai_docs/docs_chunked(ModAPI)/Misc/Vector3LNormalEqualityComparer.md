---
title: "Class Vector3LNormalEqualityComparer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3LNormalEqualityComparer.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3LNormalEqualityComparer"
---

# Class Vector3LNormalEqualityComparer | Space Engineers ModAPI

This can be used only to compare normal vectors of Vector3L, where X, Y and Z has values -1, 0 or 1

##### Inheritance

System.Object

Vector3LNormalEqualityComparer

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class Vector3LNormalEqualityComparer : Object, IEqualityComparer<Vector3L>
```

### Constructors

#### Vector3LNormalEqualityComparer()

##### Declaration

```
public Vector3LNormalEqualityComparer()
```

### Methods

#### Equals(Vector3L, Vector3L)

##### Declaration

```
public bool Equals(Vector3L x, Vector3L y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html) | x   |     |
| [Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html) | y   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode(Vector3L)

##### Declaration

```
public int GetHashCode(Vector3L x)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3L](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3L.html) | x   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |