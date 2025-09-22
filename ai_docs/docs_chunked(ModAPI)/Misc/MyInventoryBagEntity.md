---
title: "Class MyInventoryBagEntity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyInventoryBagEntity.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyInventoryBagEntity"
---

# Class MyInventoryBagEntity | Space Engineers ModAPI

Inventory bag spawned when character died, container breaks, or when entity from other inventory cannot be spawned then bag spawned with the item in its inventory.

##### Inheritance

System.Object

MyInventoryBagEntity

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityType]
[MyEntityType]
public class MyInventoryBagEntity : MyEntity, IMyInventoryBag, IMyEntity, IMyEntity
```

### Constructors

#### MyInventoryBagEntity()

##### Declaration

```
public MyInventoryBagEntity()
```

### Fields

#### OwnerIdentityId

##### Declaration

```
public long OwnerIdentityId
```

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

### Methods

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

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateAfterSimulation100()

##### Declaration

```
public override void UpdateAfterSimulation100()
```

##### Overrides

#### UpdateOnceBeforeFrame()

##### Declaration

```
public override void UpdateOnceBeforeFrame()
```

##### Overrides

### Implements

### Extension Methods