---
title: "Class MyFloatingObject"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyFloatingObject.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyFloatingObject"
---

# Class MyFloatingObject | Space Engineers ModAPI

##### Inheritance

System.Object

MyFloatingObject

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
public class MyFloatingObject : MyEntity, IMyUseObject, IMyUsableEntity, IMyFloatingObject, IMyDestroyableObject, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyParallelUpdateable, IMyEntity, IMyEntity
```

### Constructors

#### MyFloatingObject()

##### Declaration

```
public MyFloatingObject()
```

### Fields

#### Amount

##### Declaration

```
public Sync<MyFixedPoint, SyncDirection.FromServer> Amount
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Sync.Sync<VRage.MyFixedPoint, VRage.Sync.SyncDirection.FromServer\> |     |

#### ClosestDistanceToAnyPlayerSquared

##### Declaration

```
public float ClosestDistanceToAnyPlayerSquared
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CreationTime

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### InventoryFullVoice

##### Declaration

```
public static IMySourceVoice InventoryFullVoice
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Audio.IMySourceVoice |     |

#### Item

##### Declaration

```
public MyPhysicalInventoryItem Item
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) |     |

#### NUMBER\_OF\_FRAMES\_INSIDE\_VOXEL\_TO\_REMOVE

##### Declaration

```
public const int NUMBER_OF_FRAMES_INSIDE_VOXEL_TO_REMOVE = 5
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### NumberOfFramesInsideVoxel

##### Declaration

```
public int NumberOfFramesInsideVoxel
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ScrapBuilder

##### Declaration

```
public static MyObjectBuilder_Ore ScrapBuilder
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Ore](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Ore.html) |     |

#### SyncWaitCounter

##### Declaration

```
public long SyncWaitCounter
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### TakeItemVoice

##### Declaration

```
public static IMySourceVoice TakeItemVoice
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.Audio.IMySourceVoice |     |

#### VoxelMaterial

##### Declaration

```
public MyVoxelMaterialDefinition VoxelMaterial
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html) |     |

### Properties

#### GeneratedGravity

##### Declaration

```
public Vector3 GeneratedGravity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Integrity

##### Declaration

```
public float Integrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ItemDefinition

##### Declaration

```
public MyPhysicalItemDefinition ItemDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPhysicalItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalItemDefinition.html) |     |

#### Physics

##### Declaration

```
public MyPhysicsBody Physics { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Engine.Physics.MyPhysicsBody |     |

#### ShouldUpdateTooltips

##### Declaration

```
public bool ShouldUpdateTooltips { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SyncType

##### Declaration

```
public SyncType SyncType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Sync.SyncType |     |

#### UpdateFlags

##### Declaration

```
public MyParallelUpdateFlags UpdateFlags { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyParallelUpdateFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyParallelUpdateFlags.html) |     |

#### UseDamageSystem

##### Declaration

```
public bool UseDamageSystem { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### WasRemovedFromWorld

##### Declaration

```
public bool WasRemovedFromWorld { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

#### DoDamage(Single, MyStringHash, Boolean, Int64, Nullable<MyStringHash>)

##### Declaration

```
public bool DoDamage(float damage, MyStringHash damageType, bool sync, long attackerId, Nullable<MyStringHash> extraInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageType |     |
| System.Boolean | sync |     |
| System.Int64 | attackerId |     |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | extraInfo |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |
