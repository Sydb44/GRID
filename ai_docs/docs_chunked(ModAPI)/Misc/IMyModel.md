---
title: "Interface IMyModel"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModel.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyModel"
---

# Interface IMyModel | Space Engineers ModAPI

Describes 3D model (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyModel
```

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_IMyModel_AssetName)AssetName

File path of the model

##### Declaration

```
string AssetName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyModel_BoneMapping)BoneMapping

##### Declaration

```
Vector3I[] BoneMapping { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMyModel_BoundingBox)BoundingBox

Gets bounding box

##### Declaration

```
BoundingBox BoundingBox { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMyModel_BoundingBoxSize)BoundingBoxSize

Gets bounding box size

##### Declaration

```
Vector3 BoundingBoxSize { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMyModel_BoundingBoxSizeHalf)BoundingBoxSizeHalf

Gets bounding box size

##### Declaration

```
Vector3 BoundingBoxSizeHalf { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMyModel_BoundingSphere)BoundingSphere

Gets bounding sphere

##### Declaration

```
BoundingSphere BoundingSphere { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMyModel_DataVersion)DataVersion

Get version of model

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyModel_PatternScale)PatternScale

Used in texturing of armor blocks. Default is 1

##### Declaration

```
float PatternScale { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMyModel_ScaleFactor)ScaleFactor

Scale of model. Default 1. Greater number - bigger model

##### Declaration

```
float ScaleFactor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMyModel_UniqueId)UniqueId

Gets id of model

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_IMyModel_GetDrawTechnique_System_Int32_)GetDrawTechnique(Int32)

Gets VRageRender.Import.MyMeshDrawTechnique by triangle index

##### Declaration

```
MyMeshDrawTechnique GetDrawTechnique(int triangleIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | triangleIndex | Index of triangle |

##### Returns

| Type | Description |
| --- | --- |
| VRageRender.Import.MyMeshDrawTechnique | Draw technique |

#### [](#VRage_Game_ModAPI_IMyModel_GetDummies_System_Collections_Generic_IDictionary_System_String_VRage_Game_ModAPI_IMyModelDummy__)GetDummies(IDictionary<String, IMyModelDummy>)

Gets the dummies from the model

##### Declaration

```
int GetDummies(IDictionary<string, IMyModelDummy> dummies)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IDictionary<System.String, [IMyModelDummy](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModelDummy.html)\> | dummies | Dictionary of dummies, can be null to just return count |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Number of dummies in model |

#### [](#VRage_Game_ModAPI_IMyModel_GetTriangle_System_Int32_)GetTriangle(Int32)

Gets the vertex indices that complete a triangle at the index

##### Declaration

```
IMyTriangleVertexIndices GetTriangle(int triangleIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | triangleIndex | Index of triangle |

##### Returns

#### [](#VRage_Game_ModAPI_IMyModel_GetTrianglesCount)GetTrianglesCount()

Gets amount of triangles

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Amount of triangles |

#### [](#VRage_Game_ModAPI_IMyModel_GetVertex_System_Int32_)GetVertex(Int32)

Gets the vertex

##### Declaration

```
Vector3 GetVertex(int vertexIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | vertexIndex |     |

##### Returns

#### [](#VRage_Game_ModAPI_IMyModel_GetVertex_System_Int32_System_Int32_System_Int32_VRageMath_Vector3__VRageMath_Vector3__VRageMath_Vector3__)GetVertex(Int32, Int32, Int32, out Vector3, out Vector3, out Vector3)

Gets a set of three vertices

##### Declaration

```
void GetVertex(int vertexIndex1, int vertexIndex2, int vertexIndex3, out Vector3 v1, out Vector3 v2, out Vector3 v3)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | vertexIndex1 | Vertex index 1 |
| System.Int32 | vertexIndex2 | Vertex index 2 |
| System.Int32 | vertexIndex3 | Vertex index 3 |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v1  | Vertex value at index 1 |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v2  | Vertex value at index 2 |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | v3  | Vertex value at index 3 |

#### [](#VRage_Game_ModAPI_IMyModel_GetVerticesCount)GetVerticesCount()

Gets amount of vertices

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Amount of vertices |