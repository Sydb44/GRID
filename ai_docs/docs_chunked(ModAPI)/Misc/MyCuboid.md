---
title: "Class MyCuboid"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyCuboid.html"
category: "Misc"
namespace: "VRageMath"
class: "MyCuboid"
---

# Class MyCuboid | Space Engineers ModAPI

##### Inheritance

System.Object

MyCuboid

###### **Namespace**: [VRageMath](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.html)

###### **Assembly**: VRage.Math.dll

##### Syntax

```
public class MyCuboid : Object
```

### Constructors

#### MyCuboid()

##### Declaration

### Fields

#### Sides

##### Declaration

```
public MyCuboidSide[] Sides
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCuboidSide](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyCuboidSide.html)\[\] |     |

### Properties

#### UniqueLines

##### Declaration

```
public IEnumerable<Line> UniqueLines { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<[Line](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Line.html)\> |     |

#### Vertices

##### Declaration

```
public IEnumerable<Vector3> Vertices { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IEnumerable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

### Methods

#### CreateFromSizes(Single, Single, Single, Single, Single)

##### Declaration

```
public void CreateFromSizes(float width1, float depth1, float width2, float depth2, float length)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | width1 |     |
| System.Single | depth1 |     |
| System.Single | width2 |     |
| System.Single | depth2 |     |
| System.Single | length |     |

#### CreateFromVertices(Vector3\[\])

##### Declaration

```
public void CreateFromVertices(Vector3[] vertices)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\[\] | vertices |     |

#### CreateTransformed(ref Matrix)

##### Declaration

```
public MyCuboid CreateTransformed(ref Matrix worldMatrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html) | worldMatrix |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyCuboid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyCuboid.html) |     |

#### GetAABB()

##### Declaration

```
public BoundingBox GetAABB()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |

#### GetLocalAABB()

##### Declaration

```
public BoundingBox GetLocalAABB()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) |     |