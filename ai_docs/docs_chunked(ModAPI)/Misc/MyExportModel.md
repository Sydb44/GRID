---
title: "Class MyExportModel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyExportModel.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyExportModel"
---

# Class MyExportModel | Space Engineers ModAPI

##### Inheritance

System.Object

MyExportModel

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyExportModel : Object
```

### Constructors

#### MyExportModel(MyModel)

##### Declaration

```
public MyExportModel(MyModel model)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Models.MyModel | model |     |

### Properties

#### PatternScale

##### Declaration

```
public float PatternScale { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetMaterials()

##### Declaration

```
public List<MyExportModel.Material> GetMaterials()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyExportModel.Material](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyExportModel.Material.html)\> |     |

#### GetTexCoords()

##### Declaration

```
public HalfVector2[] GetTexCoords()
```

##### Returns

| Type | Description |
| --- | --- |
| VRageMath.PackedVector.HalfVector2\[\] |     |

#### GetTriangle(Int32)

##### Declaration

```
public MyTriangleVertexIndices GetTriangle(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.Game.Models.MyTriangleVertexIndices |     |

#### GetTrianglesCount()

##### Declaration

```
public int GetTrianglesCount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetVertex(Int32)

##### Declaration

```
public Vector3 GetVertex(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GetVerticesCount()

##### Declaration

```
public int GetVerticesCount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |