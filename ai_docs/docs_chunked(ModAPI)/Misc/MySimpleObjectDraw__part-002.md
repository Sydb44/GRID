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

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localbox |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
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

#### DrawTransparentBox(ref MatrixD, ref BoundingBoxD, ref Color, ref Color, MySimpleObjectRasterizer, Int32, Single, Nullable<MyStringId>, Nullable<MyStringId>, Boolean, Int32, MyBillboard.BlendTypeEnum, Single, List<MyBillboard>)

##### Declaration

```
public static void DrawTransparentBox(ref MatrixD worldMatrix, ref BoundingBoxD localbox, ref Color color, ref Color frontFaceColor, MySimpleObjectRasterizer rasterization, int wireDivideRatio, float lineWidth = 0.001F, Nullable<MyStringId> faceMaterial = null, Nullable<MyStringId> lineMaterial = null, bool onlyFrontFaces = false, int customViewProjection = -1, MyBillboard.BlendTypeEnum blendType, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localbox |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | frontFaceColor |     |
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

#### DrawTransparentBox(ref MatrixD, ref BoundingBoxD, ref Color, ref Color, MySimpleObjectRasterizer, Vector3I, Single, Nullable<MyStringId>, Nullable<MyStringId>, Boolean, Int32, MyBillboard.BlendTypeEnum, Single, List<MyBillboard>)

DrawTransparentBox

##### Declaration

```
public static void DrawTransparentBox(ref MatrixD worldMatrix, ref BoundingBoxD localbox, ref Color color, ref Color frontFaceColor, MySimpleObjectRasterizer rasterization, Vector3I wireDivideRatio, float lineWidth = 0.001F, Nullable<MyStringId> faceMaterial = null, Nullable<MyStringId> lineMaterial = null, bool onlyFrontFaces = false, int customViewProjection = -1, MyBillboard.BlendTypeEnum blendType, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
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
