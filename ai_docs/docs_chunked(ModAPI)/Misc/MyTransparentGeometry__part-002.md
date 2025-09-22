
| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | leftVector |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | upVector |     |
| System.Single | width |     |
| System.Single | height |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddBillboardOriented(MyStringId, Vector4, Vector3D, Vector3, Vector3, Single, Single, Vector2, MyBillboard.BlendTypeEnum, Int32, Single, List<MyBillboard>)

##### Declaration

```
public static void AddBillboardOriented(MyStringId material, Vector4 color, Vector3D origin, Vector3 leftVector, Vector3 upVector, float width, float height, Vector2 uvOffset, MyBillboard.BlendTypeEnum blendType, int customViewProjection = -1, float reflection = 0F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | leftVector |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | upVector |     |
| System.Single | width |     |
| System.Single | height |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | uvOffset |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Int32 | customViewProjection |     |
| System.Single | reflection |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddBillboardOriented(MyStringId, Vector4, Vector3D, Vector3, Vector3, Single, MyBillboard.BlendTypeEnum, Int32, Single, List<MyBillboard>)

##### Declaration

```
public static void AddBillboardOriented(MyStringId material, Vector4 color, Vector3D origin, Vector3 leftVector, Vector3 upVector, float radius, MyBillboard.BlendTypeEnum blendType, int customViewProjection = -1, float reflection = 0F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | leftVector |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | upVector |     |
| System.Single | radius |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Int32 | customViewProjection |     |
| System.Single | reflection |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddBillboardOrientedCull(Vector3, MyStringId, Vector4, Vector3, Vector3, Vector3, Single, Int32, Single, List<MyBillboard>)

##### Declaration

```
public static void AddBillboardOrientedCull(Vector3 cameraPos, MyStringId material, Vector4 color, Vector3 origin, Vector3 leftVector, Vector3 upVector, float radius, int customViewProjection = -1, float reflection = 0F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | cameraPos |     |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | origin |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | leftVector |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | upVector |     |
| System.Single | radius |     |
| System.Int32 | customViewProjection |     |
| System.Single | reflection |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddBillboards(IEnumerable<MyBillboard>, Boolean)

##### Declaration

```
public static void AddBillboards(IEnumerable<MyBillboard> billboards, bool isPersistent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<VRageRender.MyBillboard\> | billboards | Billboards to render |
| System.Boolean | isPersistent | When true - billboard will continue rendering until [RemovePersistentBillboard(MyBillboard, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyTransparentGeometry.html#VRage_Game_MyTransparentGeometry_RemovePersistentBillboard_VRageRender_MyBillboard_System_Boolean_) or [RemovePersistentBillboards(IEnumerable<MyBillboard>, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyTransparentGeometry.html#VRage_Game_MyTransparentGeometry_RemovePersistentBillboards_System_Collections_Generic_IEnumerable_VRageRender_MyBillboard__System_Boolean_) is called |
