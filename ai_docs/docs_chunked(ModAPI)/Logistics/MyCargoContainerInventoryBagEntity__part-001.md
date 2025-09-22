---
title: "Class MyCargoContainerInventoryBagEntity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCargoContainerInventoryBagEntity.html"
category: "Logistics"
namespace: "Sandbox.Game.Entities"
class: "MyCargoContainerInventoryBagEntity"
---

# Class MyCargoContainerInventoryBagEntity | Space Engineers ModAPI

Inventory bag spawned when character died, container breaks, or when entity from other inventory cannot be spawned then bag spawned with the item in its inventory.

##### Inheritance

System.Object

MyCargoContainerInventoryBagEntity

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
public class MyCargoContainerInventoryBagEntity : MyEntity, IMyInventoryBag, IMyDestroyableObject, IMySyncedEntity, IMyParallelUpdateable, IMyEntity, IMyEntity, IMyEventProxy, IMyEventOwner
```

### Constructors

#### MyCargoContainerInventoryBagEntity()

##### Declaration

```
public MyCargoContainerInventoryBagEntity()
```

### Fields

#### CreationTime

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

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
public float Integrity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

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

#### GetPhysicsShape(Single, Single, out HkMassProperties)

##### Declaration

```
protected virtual HkShape GetPhysicsShape(float mass, float scale, out HkMassProperties massProperties)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | mass |     |
| System.Single | scale |     |
| Havok.HkMassProperties | massProperties |     |

##### Returns

| Type | Description |
| --- | --- |
| Havok.HkShape |     |

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Overrides

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

##### Overrides

#### OnDestroy()

##### Declaration

#### OnInventoryComponentAdded(MyInventoryBase)

##### Declaration

```
protected override void OnInventoryComponentAdded(MyInventoryBase inventory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventory |     |

##### Overrides

#### OnInventoryComponentRemoved(MyInventoryBase)

##### Declaration

```
protected override void OnInventoryComponentRemoved(MyInventoryBase inventory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventory |     |

##### Overrides

#### OnReplicationEnded()

##### Declaration

```
public override void OnReplicationEnded()
```

##### Overrides

#### OnReplicationStarted()

##### Declaration

```
public override void OnReplicationStarted()
```

##### Overrides

#### SendCloseRequest()

##### Declaration

```
public void SendCloseRequest()
```

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```
