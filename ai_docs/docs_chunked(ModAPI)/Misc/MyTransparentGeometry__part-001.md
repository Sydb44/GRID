---
title: "Class MyTransparentGeometry"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyTransparentGeometry.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyTransparentGeometry"
---

# Class MyTransparentGeometry | Space Engineers ModAPI

##### Inheritance

System.Object

MyTransparentGeometry

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyTransparentGeometry : Object
```

### Constructors

#### MyTransparentGeometry()

##### Declaration

```
public MyTransparentGeometry()
```

### Properties

#### Camera

##### Declaration

```
public static MatrixD Camera { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### CameraView

##### Declaration

```
public static MatrixD CameraView { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

#### HasCamera

##### Declaration

```
public static bool HasCamera { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AddAttachedQuad(MyStringId, ref MyQuadD, Vector4, ref Vector3D, UInt32, MyBillboard.BlendTypeEnum, List<MyBillboard>)

##### Declaration

```
public static bool AddAttachedQuad(MyStringId material, ref MyQuadD quad, Vector4 color, ref Vector3D vctPos, uint renderObjectID, MyBillboard.BlendTypeEnum blendType, List<MyBillboard> persistentBillboards = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | material |     |
| [MyQuadD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyQuadD.html) | quad |     |
| [Vector4](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4.html) | color |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | vctPos |     |
| System.UInt32 | renderObjectID |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AddBillboard(MyBillboard, Boolean)

##### Declaration

```
public static void AddBillboard(MyBillboard billboard, bool isPersistent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRageRender.MyBillboard | billboard | Billboard to render |
| System.Boolean | isPersistent | When true - billboard will continue rendering until [RemovePersistentBillboard(MyBillboard, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyTransparentGeometry.html#VRage_Game_MyTransparentGeometry_RemovePersistentBillboard_VRageRender_MyBillboard_System_Boolean_) or [RemovePersistentBillboards(IEnumerable<MyBillboard>, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyTransparentGeometry.html#VRage_Game_MyTransparentGeometry_RemovePersistentBillboards_System_Collections_Generic_IEnumerable_VRageRender_MyBillboard__System_Boolean_) is called |

#### AddBillboardOriented(MyStringId, Vector4, Vector3D, Vector3, Vector3, Single, Int32, MyBillboard.BlendTypeEnum, List<MyBillboard>)

##### Declaration

```
public static void AddBillboardOriented(MyStringId material, Vector4 color, Vector3D origin, Vector3 leftVector, Vector3 upVector, float radius, int customProjection, MyBillboard.BlendTypeEnum blendType, List<MyBillboard> persistentBillboards = null)
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
| System.Int32 | customProjection |     |
| VRageRender.MyBillboard.BlendTypeEnum | blendType |     |
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddBillboardOriented(MyStringId, Vector4, Vector3D, Vector3, Vector3, Single, Single, List<MyBillboard>)

##### Declaration

```
public static void AddBillboardOriented(MyStringId material, Vector4 color, Vector3D origin, Vector3 leftVector, Vector3 upVector, float width, float height, List<MyBillboard> persistentBillboards = null)
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
| System.Collections.Generic.List<VRageRender.MyBillboard\> | persistentBillboards |     |

#### AddBillboardOriented(MyStringId, Vector4, Vector3D, Vector3, Vector3, Single, Single, Vector2, MyBillboard.BlendTypeEnum, Int32, Single, List<MyBillboard>)
