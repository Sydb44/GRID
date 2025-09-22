---
title: "Class MyVoxelBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyVoxelBase"
---

# Class MyVoxelBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyVoxelBase

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyVoxelBase : MyEntity, IMyVoxelDrawable, IMyVoxelBase, IMyEntity, IMyEntity, IMyDecalProxy, IMyEventProxy, IMyEventOwner
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyVoxelBase__ctor)MyVoxelBase()

##### Declaration

### [](#fields)Fields

#### [](#Sandbox_Game_Entities_MyVoxelBase_BoulderInfo)BoulderInfo

##### Declaration

```
public Nullable<MyBoulderInformation> BoulderInfo
```

##### Field Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_CreateStorageCopyOnWrite)CreateStorageCopyOnWrite

##### Declaration

```
public bool CreateStorageCopyOnWrite
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_IsSeedOpen)IsSeedOpen

##### Declaration

```
public Nullable<bool> IsSeedOpen
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_m_storageMax)m\_storageMax

##### Declaration

```
protected Vector3I m_storageMax
```

##### Field Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_m_storageMin)m\_storageMin

##### Declaration

```
protected Vector3I m_storageMin
```

##### Field Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_m_tempStorage)m\_tempStorage

##### Declaration

```
protected static MyStorageData m_tempStorage
```

##### Field Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_VoxelMapPruningProxyId)VoxelMapPruningProxyId

##### Declaration

```
public int VoxelMapPruningProxyId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_MyVoxelBase_AsteroidName)AsteroidName

##### Declaration

```
public string AsteroidName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_BeforeContentChanged)BeforeContentChanged

##### Declaration

```
public bool BeforeContentChanged { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_ContentChanged)ContentChanged

##### Declaration

```
public bool ContentChanged { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_CreatedByUser)CreatedByUser

##### Declaration

```
public bool CreatedByUser { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_DelayRigidBodyCreation)DelayRigidBodyCreation

##### Declaration

```
public bool DelayRigidBodyCreation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_IsGlobalEncounterAsteroid)IsGlobalEncounterAsteroid

##### Declaration

```
public bool IsGlobalEncounterAsteroid { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_m_storage)m\_storage

##### Declaration

```
protected IMyStorage m_storage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Voxels.IMyStorage |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_Orientation)Orientation

##### Declaration

```
public Matrix Orientation { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_PositionLeftBottomCorner)PositionLeftBottomCorner

Position of left/bottom corner of this voxel map, in world space (not relative to sector)

##### Declaration

```
public virtual Vector3D PositionLeftBottomCorner { get; set; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_RootVoxel)RootVoxel

Gets root voxel, for asteroids and planets itself. For MyVoxelPhysics, should return owning planet.

##### Declaration

```
public abstract MyVoxelBase RootVoxel { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_ScaleGroup)ScaleGroup

##### Declaration

```
public virtual MyClipmapScaleEnum ScaleGroup { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_Size)Size

Size of voxel map (in voxels)

##### Declaration

```
public Vector3I Size { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_SizeInMetres)SizeInMetres

Size of voxel map (in metres)

##### Declaration

```
public Vector3 SizeInMetres { get; protected set; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_SizeInMetresHalf)SizeInMetresHalf

##### Declaration

```
public Vector3 SizeInMetresHalf { get; protected set; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_SizeMinusOne)SizeMinusOne

##### Declaration

```
public Vector3I SizeMinusOne { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_Storage)Storage

##### Declaration

```
public virtual IMyStorage Storage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Voxels.IMyStorage |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_StorageMax)StorageMax

##### Declaration

```
public Vector3I StorageMax { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_StorageMin)StorageMin

##### Declaration

```
public Vector3I StorageMin { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyVoxelBase_StorageName)StorageName
