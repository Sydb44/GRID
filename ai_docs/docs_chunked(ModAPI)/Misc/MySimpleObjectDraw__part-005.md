public static void DrawTransparentPyramid(ref Vector3D start, ref MyQuad backQuad, ref Vector4 vctColor, int divideRatio, float thickness, Nullable<MyStringId> lineMaterial = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | start |     |
| [MyQuad](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuad.html) | backQuad |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | vctColor |     |
| System.Int32 | divideRatio |     |
| System.Single | thickness |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |

#### DrawTransparentRamp(ref MatrixD, ref BoundingBoxD, ref Color, Nullable<MyStringId>, Boolean, Int32, MyBillboard.BlendTypeEnum)

##### Declaration

```
public static void DrawTransparentRamp(ref MatrixD worldMatrix, ref BoundingBoxD localbox, ref Color color, Nullable<MyStringId> faceMaterial = null, bool onlyFrontFaces = false, int customViewProjection = -1, MyBillboard.BlendTypeEnum blendType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localbox |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Boolean | onlyFrontFaces |     |
| System.Int32 | customViewProjection |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |

#### DrawTransparentRoundedCorner(ref MatrixD, ref BoundingBoxD, ref Color, Nullable<MyStringId>, Int32)

##### Declaration

```
public static void DrawTransparentRoundedCorner(ref MatrixD worldMatrix, ref BoundingBoxD localbox, ref Color color, Nullable<MyStringId> faceMaterial = null, int customViewProjection = -1)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localbox |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Int32 | customViewProjection |     |

#### DrawTransparentSphere(List<Vector3D>, Single, ref Color, MySimpleObjectRasterizer, Nullable<MyStringId>, Nullable<MyStringId>, Single, Int32, List<MyBillboard>, MyBillboard.BlendTypeEnum, Single)

##### Declaration

```
public static void DrawTransparentSphere(List<Vector3D> verticesBuffer, float radius, ref Color color, MySimpleObjectRasterizer rasterization, Nullable<MyStringId> faceMaterial = null, Nullable<MyStringId> lineMaterial = null, float lineThickness = -1F, int customViewProjectionMatrix = -1, List<MyBillboard> persistentBillboards = null, MyBillboard.BlendTypeEnum blendType, float intensity = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | verticesBuffer |     |
| System.Single | radius |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| [MySimpleObjectRasterizer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MySimpleObjectRasterizer.html) | rasterization |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |
| System.Single | lineThickness |     |
| System.Int32 | customViewProjectionMatrix |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Single | intensity |     |

#### DrawTransparentSphere(ref MatrixD, Single, ref Color, MySimpleObjectRasterizer, Int32, Nullable<MyStringId>, Nullable<MyStringId>, Single, Int32, List<MyBillboard>, MyBillboard.BlendTypeEnum, Single)

DrawTransparentSphere

##### Declaration

```
public static void DrawTransparentSphere(ref MatrixD worldMatrix, float radius, ref Color color, MySimpleObjectRasterizer rasterization, int wireDivideRatio, Nullable<MyStringId> faceMaterial = null, Nullable<MyStringId> lineMaterial = null, float lineThickness = -1F, int customViewProjectionMatrix = -1, List<MyBillboard> persistentBillboards = null, MyBillboard.BlendTypeEnum blendType, float intensity = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| System.Single | radius |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| [MySimpleObjectRasterizer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MySimpleObjectRasterizer.html) | rasterization |     |
| System.Int32 | wireDivideRatio |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |
| System.Single | lineThickness |     |
| System.Int32 | customViewProjectionMatrix |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Single | intensity |     |
