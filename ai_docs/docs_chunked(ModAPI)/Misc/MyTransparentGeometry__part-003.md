
##### Declaration

```
public static void AddBillboards(IEnumerable<MyBillboard> billboards, bool isPersistent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<VRageRender.MyBillboard\> | billboards | Billboards to render |
| System.Boolean | isPersistent | When true - billboard will continue rendering until [RemovePersistentBillboard(MyBillboard, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyTransparentGeometry.html#VRage_Game_MyTransparentGeometry_RemovePersistentBillboard_VRageRender_MyBillboard_System_Boolean_) or [RemovePersistentBillboards(IEnumerable<MyBillboard>, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyTransparentGeometry.html#VRage_Game_MyTransparentGeometry_RemovePersistentBillboards_System_Collections_Generic_IEnumerable_VRageRender_MyBillboard__System_Boolean_) is called |

#### AddLineBillboard(MyStringId, Vector4, Vector3D, UInt32, ref MatrixD, Vector3, Single, Single, MyBillboard.BlendTypeEnum, Int32, Single, List<MyBillboard>)

##### Declaration

```
public static void AddLineBillboard(MyStringId material, Vector4 color, Vector3D origin, uint renderObjectID, ref MatrixD worldToLocal, Vector3 directionNormalized, float length, float thickness, MyBillboard.BlendTypeEnum blendType, int customViewProjection = -1, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| System.UInt32 | renderObjectID |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldToLocal |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | directionNormalized |     |
| System.Single | length |     |
| System.Single | thickness |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Int32 | customViewProjection |     |
| System.Single | intensity |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddLineBillboard(MyStringId, Vector4, Vector3D, Vector3, Single, Single, MyBillboard.BlendTypeEnum, Int32, Single, List<MyBillboard>)

##### Declaration

```
public static void AddLineBillboard(MyStringId material, Vector4 color, Vector3D origin, Vector3 directionNormalized, float length, float thickness, MyBillboard.BlendTypeEnum blendType, int customViewProjection = -1, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | directionNormalized |     |
| System.Single | length |     |
| System.Single | thickness |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Int32 | customViewProjection |     |
| System.Single | intensity |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddLocalLineBillboard(MyStringId, Vector4, Vector3D, UInt32, Vector3, Single, Single, MyBillboard.BlendTypeEnum, Int32, Single, List<MyBillboard>)

##### Declaration

```
public static void AddLocalLineBillboard(MyStringId material, Vector4 color, Vector3D origin, uint renderObjectID, Vector3 directionNormalized, float length, float thickness, MyBillboard.BlendTypeEnum blendType, int customViewProjection = -1, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| System.UInt32 | renderObjectID |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | directionNormalized |     |
| System.Single | length |     |
| System.Single | thickness |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Int32 | customViewProjection |     |
| System.Single | intensity |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddLocalPointBillboard(MyStringId, Vector4, Vector3D, UInt32, Single, Single, MyBillboard.BlendTypeEnum, Int32, Single, List<MyBillboard>)

##### Declaration

```
public static void AddLocalPointBillboard(MyStringId material, Vector4 color, Vector3D origin, uint renderObjectID, float radius, float angle, MyBillboard.BlendTypeEnum blendType, int customViewProjection = -1, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| System.UInt32 | renderObjectID |     |
| System.Single | radius |     |
| System.Single | angle |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Int32 | customViewProjection |     |
| System.Single | intensity |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |
