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

#### DrawTransparentCapsule(ref MatrixD, Single, Single, ref Color, Int32, Nullable<MyStringId>, Int32, MyBillboard.BlendTypeEnum)

##### Declaration

```
public static void DrawTransparentCapsule(ref MatrixD worldMatrix, float radius, float height, ref Color color, int wireDivideRatio, Nullable<MyStringId> faceMaterial = null, int customViewProjectionMatrix = -1, MyBillboard.BlendTypeEnum blendType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| System.Single | radius |     |
| System.Single | height |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.Int32 | wireDivideRatio |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Int32 | customViewProjectionMatrix |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |

#### DrawTransparentCone(ref MatrixD, Single, Single, ref Color, Int32, Nullable<MyStringId>, Int32)

##### Declaration

```
public static void DrawTransparentCone(ref MatrixD worldMatrix, float radius, float height, ref Color color, int wireDivideRatio, Nullable<MyStringId> faceMaterial = null, int customViewProjectionMatrix = -1)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| System.Single | radius |     |
| System.Single | height |     |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) | color |     |
| System.Int32 | wireDivideRatio |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | faceMaterial |     |
| System.Int32 | customViewProjectionMatrix |     |

#### DrawTransparentCuboid(ref MatrixD, MyCuboid, ref Vector4, Boolean, Single, Nullable<MyStringId>)

##### Declaration

```
public static void DrawTransparentCuboid(ref MatrixD worldMatrix, MyCuboid cuboid, ref Vector4 vctColor, bool bWireFramed, float thickness, Nullable<MyStringId> lineMaterial = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [MyCuboid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyCuboid.html) | cuboid |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | vctColor |     |
| System.Boolean | bWireFramed |     |
| System.Single | thickness |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |

#### DrawTransparentCylinder(ref MatrixD, Single, Single, Single, ref Vector4, Boolean, Int32, Single, Nullable<MyStringId>)

##### Declaration

```
public static void DrawTransparentCylinder(ref MatrixD worldMatrix, float radius1, float radius2, float length, ref Vector4 vctColor, bool bWireFramed, int wireDivideRatio, float thickness, Nullable<MyStringId> lineMaterial = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| System.Single | radius1 |     |
| System.Single | radius2 |     |
| System.Single | length |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | vctColor |     |
| System.Boolean | bWireFramed |     |
| System.Int32 | wireDivideRatio |     |
| System.Single | thickness |     |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | lineMaterial |     |

#### DrawTransparentPyramid(ref Vector3D, ref MyQuad, ref Vector4, Int32, Single, Nullable<MyStringId>)

##### Declaration

```
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
