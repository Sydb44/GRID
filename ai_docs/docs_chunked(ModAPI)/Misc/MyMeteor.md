---
title: "Class MyMeteor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyMeteor.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyMeteor"
---

# Class MyMeteor | Space Engineers ModAPI

##### Inheritance

System.Object

MyMeteor

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
public class MyMeteor : MyEntity, IMyMeteor, IMyDestroyableObject, IMyDecalProxy, IMyEntity, IMyEntity, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyMeteor()

##### Declaration

### Properties

#### Integrity

##### Declaration

```
public float Integrity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsCCDForProjectiles

##### Declaration

```
public override bool IsCCDForProjectiles { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### UseDamageSystem

##### Declaration

```
public bool UseDamageSystem { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### DoDamage(Single, MyStringHash, Boolean, Nullable<MyHitInfo>, Int64, Int64, Boolean, Nullable<MyStringHash>)

##### Declaration

```
public bool DoDamage(float damage, MyStringHash damageType, bool sync, Nullable<MyHitInfo> hitInfo, long attackerId, long realHitEntityId = 0L, bool shouldDetonateAmmo = true, Nullable<MyStringHash> extraInfo = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | damage |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | damageType |     |
| System.Boolean | sync |     |
| System.Nullable<[MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html)\> | hitInfo |     |
| System.Int64 | attackerId |     |
| System.Int64 | realHitEntityId |     |
| System.Boolean | shouldDetonateAmmo |     |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> | extraInfo |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### OnDestroy()

##### Declaration

#### Spawn(ref MyPhysicalInventoryItem, Vector3D, Vector3)

##### Declaration

```
public static MyEntity Spawn(ref MyPhysicalInventoryItem item, Vector3D position, Vector3 speed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | speed |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### SpawnRandom(Vector3D, Vector3)

##### Declaration

```
public static MyEntity SpawnRandom(Vector3D position, Vector3 direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | direction |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

### Explicit Interface Implementations

#### IMyDecalProxy.AddDecals(ref MyHitInfo, MyStringHash, Vector3, Object, IMyDecalHandler, MyStringHash, MyStringHash, Boolean, MyDecalFlags, Int32, List<UInt32>)

##### Declaration

```
void IMyDecalProxy.AddDecals(ref MyHitInfo hitInfo, MyStringHash source, Vector3 forwardDirection, object customdata, IMyDecalHandler decalHandler, MyStringHash physicalMaterial, MyStringHash voxelMaterial, bool isTrail, MyDecalFlags flags, int aliveUntil, List<uint> ids)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html) | hitInfo |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | source |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | forwardDirection |     |
| System.Object | customdata |     |
| [IMyDecalHandler](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyDecalHandler.html) | decalHandler |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | physicalMaterial |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | voxelMaterial |     |
| System.Boolean | isTrail |     |
| VRageRender.MyDecalFlags | flags |     |
| System.Int32 | aliveUntil |     |
| System.Collections.Generic.List<System.UInt32\> | ids |     |

### Implements

### Extension Methods