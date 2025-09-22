| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localbox |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | frontFaceColor |     |
| [MySimpleObjectRasterizer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MySimpleObjectRasterizer.html) | rasterization |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | wireDivideRatio |     |
| System.Single | lineWidth |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |
| System.Boolean | onlyFrontFaces |     |
| System.Int32 | customViewProjection |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Single | intensity |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### DrawTransparentBox(ref MatrixD, ref BoundingBoxD, ref Color, ref Color, ref Color, ref Color, ref Color, ref Color, ref Color, MySimpleObjectRasterizer, Int32, Single, Nullable<MyStringId>, Nullable<MyStringId>, Boolean, Int32, MyBillboard.BlendTypeEnum, Single, List<MyBillboard>)

##### Declaration

```
public static void DrawTransparentBox(ref MatrixD worldMatrix, ref BoundingBoxD localbox, ref Color faceX_P, ref Color faceY_P, ref Color faceZ_P, ref Color faceX_N, ref Color faceY_N, ref Color faceZ_N, ref Color wire, MySimpleObjectRasterizer rasterization, int wireDivideRatio, float lineWidth = 0.001F, Nullable<MyStringId> faceMaterial = null, Nullable<MyStringId> lineMaterial = null, bool onlyFrontFaces = false, int customViewProjection = -1, MyBillboard.BlendTypeEnum blendType, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localbox |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceX\_P |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceY\_P |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceZ\_P |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceX\_N |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceY\_N |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceZ\_N |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | wire |     |
| [MySimpleObjectRasterizer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MySimpleObjectRasterizer.html) | rasterization |     |
| System.Int32 | wireDivideRatio |     |
| System.Single | lineWidth |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |
| System.Boolean | onlyFrontFaces |     |
| System.Int32 | customViewProjection |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Single | intensity |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### DrawTransparentBox(ref MatrixD, ref BoundingBoxD, ref Color, ref Color, ref Color, ref Color, ref Color, ref Color, ref Color, MySimpleObjectRasterizer, Vector3I, Single, Nullable<MyStringId>, Nullable<MyStringId>, Boolean, Int32, MyBillboard.BlendTypeEnum, Single, List<MyBillboard>)

Definitely not thread safe due to use shared temporary\_faces to avoid reinitializations

##### Declaration

```
public static void DrawTransparentBox(ref MatrixD worldMatrix, ref BoundingBoxD localbox, ref Color faceX_P, ref Color faceY_P, ref Color faceZ_P, ref Color faceX_N, ref Color faceY_N, ref Color faceZ_N, ref Color wire, MySimpleObjectRasterizer rasterization, Vector3I wireDivideRatio, float lineWidth = 0.001F, Nullable<MyStringId> faceMaterial = null, Nullable<MyStringId> lineMaterial = null, bool onlyFrontFaces = false, int customViewProjection = -1, MyBillboard.BlendTypeEnum blendType, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localbox |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceX\_P |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceY\_P |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceZ\_P |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceX\_N |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceY\_N |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | faceZ\_N |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | wire |     |
| [MySimpleObjectRasterizer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MySimpleObjectRasterizer.html) | rasterization |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | wireDivideRatio |     |
| System.Single | lineWidth |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |
| System.Boolean | onlyFrontFaces |     |
| System.Int32 | customViewProjection |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Single | intensity |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |
