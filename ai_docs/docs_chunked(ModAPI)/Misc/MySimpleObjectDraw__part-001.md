---
title: "Class MySimpleObjectDraw"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MySimpleObjectDraw.html"
category: "Misc"
namespace: "VRage.Game"
class: "MySimpleObjectDraw"
---

# Class MySimpleObjectDraw | Space Engineers ModAPI

##### Inheritance

System.Object

MySimpleObjectDraw

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public static class MySimpleObjectDraw : Object
```

### Fields

#### ATTACHED\_WIREFRAME\_MAX\_GRID\_SIZE

##### Declaration

```
public static float ATTACHED_WIREFRAME_MAX_GRID_SIZE
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ATTACHED\_WIREFRAME\_MIN\_GRID\_SIZE

##### Declaration

```
public static float ATTACHED_WIREFRAME_MIN_GRID_SIZE
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### DrawAttachedTransparentBox(ref MatrixD, ref BoundingBoxD, ref Color, UInt32, ref MatrixD, MySimpleObjectRasterizer, Int32, Single, Nullable<MyStringId>, Nullable<MyStringId>, Boolean)

##### Declaration

```
public static void DrawAttachedTransparentBox(ref MatrixD worldMatrix, ref BoundingBoxD localbox, ref Color color, uint renderObjectID, ref MatrixD worldToLocal, MySimpleObjectRasterizer rasterization, int wireDivideRatio, float lineWidth = 0.001F, Nullable<MyStringId> faceMaterial = null, Nullable<MyStringId> lineMaterial = null, bool onlyFrontFaces = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localbox |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.UInt32 | renderObjectID |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldToLocal |     |
| [MySimpleObjectRasterizer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MySimpleObjectRasterizer.html) | rasterization |     |
| System.Int32 | wireDivideRatio |     |
| System.Single | lineWidth |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |
| System.Boolean | onlyFrontFaces |     |

#### DrawAttachedTransparentBox(ref MatrixD, ref BoundingBoxD, ref Color, UInt32, ref MatrixD, MySimpleObjectRasterizer, Vector3I, Single, Nullable<MyStringId>, Nullable<MyStringId>, Boolean, MyBillboard.BlendTypeEnum)

##### Declaration

```
public static void DrawAttachedTransparentBox(ref MatrixD worldMatrix, ref BoundingBoxD localbox, ref Color color, uint renderObjectID, ref MatrixD worldToLocal, MySimpleObjectRasterizer rasterization, Vector3I wireDivideRatio, float lineWidth = 0.001F, Nullable<MyStringId> faceMaterial = null, Nullable<MyStringId> lineMaterial = null, bool onlyFrontFaces = false, MyBillboard.BlendTypeEnum blendType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localbox |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.UInt32 | renderObjectID |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldToLocal |     |
| [MySimpleObjectRasterizer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MySimpleObjectRasterizer.html) | rasterization |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | wireDivideRatio |     |
| System.Single | lineWidth |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |
| System.Boolean | onlyFrontFaces |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |

#### DrawLine(Vector3D, Vector3D, Nullable<MyStringId>, ref Vector4, Single, MyBillboard.BlendTypeEnum)

##### Declaration

```
public static void DrawLine(Vector3D start, Vector3D end, Nullable<MyStringId> material, ref Vector4 color, float thickness, MyBillboard.BlendTypeEnum blendtype)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | start |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | end |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| System.Single | thickness |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendtype |     |

#### DrawTransparentBox(ref MatrixD, ref BoundingBoxD, ref Color, MySimpleObjectRasterizer, Int32, Single, Nullable<MyStringId>, Nullable<MyStringId>, Boolean, Int32, MyBillboard.BlendTypeEnum, Single, List<MyBillboard>)

##### Declaration

```
public static void DrawTransparentBox(ref MatrixD worldMatrix, ref BoundingBoxD localbox, ref Color color, MySimpleObjectRasterizer rasterization, int wireDivideRatio, float lineWidth = 0.001F, Nullable<MyStringId> faceMaterial = null, Nullable<MyStringId> lineMaterial = null, bool onlyFrontFaces = false, int customViewProjection = -1, MyBillboard.BlendTypeEnum blendType, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```
