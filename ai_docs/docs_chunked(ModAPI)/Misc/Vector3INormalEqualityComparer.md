---
title: "Class Vector3INormalEqualityComparer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3INormalEqualityComparer.html"
category: "Misc"
namespace: "VRageMath"
class: "Vector3INormalEqualityComparer"
---

# Class Vector3INormalEqualityComparer | Space Engineers ModAPI

This can be used only to compare normal vectors of Vector3I, where X, Y and Z has values -1, 0 or 1

##### Inheritance

System.Object

Vector3INormalEqualityComparer

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class Vector3INormalEqualityComparer : Object, IEqualityComparer<Vector3I>
```

### Constructors

#### Vector3INormalEqualityComparer()

##### Declaration

```
public Vector3INormalEqualityComparer()
```

### Methods

#### Equals(Vector3I, Vector3I)

##### Declaration

```
public bool Equals(Vector3I x, Vector3I y)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | x   |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | y   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetHashCode(Vector3I)

##### Declaration

```
public int GetHashCode(Vector3I x)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | x   |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |