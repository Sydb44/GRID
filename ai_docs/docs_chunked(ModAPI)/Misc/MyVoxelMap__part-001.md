---
title: "Class MyVoxelMap"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelMap.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyVoxelMap"
---

# Class MyVoxelMap | Space Engineers ModAPI

##### Inheritance

System.Object

MyVoxelMap

##### Implements

##### Inherited Members

[MyVoxelBase.IMyDecalProxy.AddDecals(MyHitInfo, MyStringHash, Vector3, Object, IMyDecalHandler, MyStringHash, MyStringHash, Boolean, MyDecalFlags, Int32, List<UInt32>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html#Sandbox_Game_Entities_MyVoxelBase_VRage_Game_ModAPI_Interfaces_IMyDecalProxy_AddDecals_VRage_Game_ModAPI_MyHitInfo__VRage_Utils_MyStringHash_VRageMath_Vector3_System_Object_VRage_Game_ModAPI_Interfaces_IMyDecalHandler_VRage_Utils_MyStringHash_VRage_Utils_MyStringHash_System_Boolean_VRageRender_MyDecalFlags_System_Int32_System_Collections_Generic_List_System_UInt32__)

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
public class MyVoxelMap : MyVoxelBase, IMyVoxelDrawable, IMyDecalProxy, IMyEventProxy, IMyEventOwner, IMyVoxelMap, IMyVoxelBase, IMyEntity, IMyEntity
```

### Constructors

#### MyVoxelMap()

##### Declaration

### Properties

#### IsStaticForCluster

##### Declaration

```
public bool IsStaticForCluster { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RootVoxel

##### Declaration

```
public override MyVoxelBase RootVoxel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

##### Overrides

#### Storage

##### Declaration

```
public override IMyStorage Storage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Voxels.IMyStorage |     |

##### Overrides

### Methods

#### BeforeDelete()

##### Declaration

```
protected override void BeforeDelete()
```

##### Overrides

#### GetFriendlyName()

##### Declaration

```
public override string GetFriendlyName()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### GetIntersectionWithAABB(ref BoundingBoxD)

##### Declaration

```
public override bool GetIntersectionWithAABB(ref BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### GetIntersectionWithSphere(ref BoundingSphereD)

##### Declaration

```
public override bool GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### GetNewStorageName(String, Int64)

##### Declaration

```
public static string GetNewStorageName(string storageName, long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName |     |
| System.Int64 | entityId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

##### Overrides

#### GetOrePriority()

##### Declaration

```
public override int GetOrePriority()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

##### Overrides

#### Init(String, IMyStorage, MatrixD, Boolean)

##### Declaration

```
public override void Init(string storageName, IMyStorage storage, MatrixD worldMatrix, bool useVoxelOffset = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName |     |
| VRage.Game.Voxels.IMyStorage | storage |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| System.Boolean | useVoxelOffset |     |

##### Overrides

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | builder |     |

##### Overrides

#### Init(MyObjectBuilder\_EntityBase, IMyStorage)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase builder, IMyStorage storage)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | builder |     |
| VRage.Game.Voxels.IMyStorage | storage |     |

##### Overrides

#### InitVoxelMap(MatrixD, Vector3I, Boolean)

##### Declaration

```
protected override void InitVoxelMap(MatrixD worldMatrix, Vector3I size, bool useOffset = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | size |     |
| System.Boolean | useOffset |     |
