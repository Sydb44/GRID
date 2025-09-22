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

#### AddTriangleBillboard(Vector3D, Vector3D, Vector3D, Vector3, Vector3, Vector3, Vector2, Vector2, Vector2, MyStringId, UInt32, Vector3D, MyBillboard.BlendTypeEnum)

##### Declaration

```
public static void AddTriangleBillboard(Vector3D p0, Vector3D p1, Vector3D p2, Vector3 n0, Vector3 n1, Vector3 n2, Vector2 uv0, Vector2 uv1, Vector2 uv2, MyStringId material, uint parentID, Vector3D worldPosition, MyBillboard.BlendTypeEnum blendType)
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
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |

#### ApplyActionOnPersistentBillboards(Action)

Used to update billboards. You can change any values of MyBillboard inside of this action call. Used to iterate over your own set of Billboards, instead of all, that currently drawing.

##### Declaration

```
public static void ApplyActionOnPersistentBillboards(Action action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | Action, which should be executed |

#### ApplyActionOnPersistentBillboards(Action<MyBillboard>)

##### Declaration

```
public static void ApplyActionOnPersistentBillboards(Action<MyBillboard> action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<VRageRender.MyBillboard\> | action | action, which should be executed |

#### CreateBillboard(MyBillboard, ref MyQuadD, MyStringId, ref Vector4, ref Vector3D, Int32, Single)

##### Declaration

```
public static void CreateBillboard(MyBillboard billboard, ref MyQuadD quad, MyStringId material, ref Vector4 color, ref Vector3D origin, int customViewProjection = -1, float reflection = 0F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.MyBillboard | billboard |     |
| [MyQuadD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuadD.html) | quad |     |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| System.Int32 | customViewProjection |     |
| System.Single | reflection |     |

#### CreateBillboard(MyBillboard, ref MyQuadD, MyStringId, ref Vector4, ref Vector3D, Vector2, Int32, Single)

##### Declaration

```
public static void CreateBillboard(MyBillboard billboard, ref MyQuadD quad, MyStringId material, ref Vector4 color, ref Vector3D origin, Vector2 uvOffset, int customViewProjection = -1, float reflectivity = 0F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.MyBillboard | billboard |     |
| [MyQuadD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuadD.html) | quad |     |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin |     |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | uvOffset |     |
| System.Int32 | customViewProjection |     |
| System.Single | reflectivity |     |
