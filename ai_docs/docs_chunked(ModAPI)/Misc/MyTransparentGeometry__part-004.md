
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

#### AddPointBillboard(MyStringId, Vector4, Vector3D, Single, Single, Int32, MyBillboard.BlendTypeEnum, List<MyBillboard>)

##### Declaration

```
public static void AddPointBillboard(MyStringId material, Vector4 color, Vector3D origin, float radius, float angle, int customViewProjection = -1, MyBillboard.BlendTypeEnum blendType, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| System.Single | radius |     |
| System.Single | angle |     |
| System.Int32 | customViewProjection |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddPointBillboard(MyStringId, Vector4, Vector3D, UInt32, ref MatrixD, Single, Single, Int32, MyBillboard.BlendTypeEnum, Single, List<MyBillboard>)

##### Declaration

```
public static void AddPointBillboard(MyStringId material, Vector4 color, Vector3D origin, uint renderObjectID, ref MatrixD worldToLocal, float radius, float angle, int customViewProjection = -1, MyBillboard.BlendTypeEnum blendType, float intensity = 1F, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| System.UInt32 | renderObjectID |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldToLocal |     |
| System.Single | radius |     |
| System.Single | angle |     |
| System.Int32 | customViewProjection |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Single | intensity |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddQuad(MyStringId, ref MyQuadD, Vector4, ref Vector3D, Int32, MyBillboard.BlendTypeEnum, List<MyBillboard>)

##### Declaration

```
public static bool AddQuad(MyStringId material, ref MyQuadD quad, Vector4 color, ref Vector3D vctPos, int customViewProjection = -1, MyBillboard.BlendTypeEnum blendType, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [MyQuadD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuadD.html) | quad |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | vctPos |     |
| System.Int32 | customViewProjection |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AddTriangleBillboard(Vector3D, Vector3D, Vector3D, Vector3, Vector3, Vector3, Vector2, Vector2, Vector2, MyStringId, UInt32, Vector3D, Vector4, MyBillboard.BlendTypeEnum)

##### Declaration

```
public static void AddTriangleBillboard(Vector3D p0, Vector3D p1, Vector3D p2, Vector3 n0, Vector3 n1, Vector3 n2, Vector2 uv0, Vector2 uv1, Vector2 uv2, MyStringId material, uint parentID, Vector3D worldPosition, Vector4 color, MyBillboard.BlendTypeEnum blendType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | p0  |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | p1  |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | p2  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | n0  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | n1  |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | n2  |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | uv0 |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | uv1 |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | uv2 |     |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| System.UInt32 | parentID |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
