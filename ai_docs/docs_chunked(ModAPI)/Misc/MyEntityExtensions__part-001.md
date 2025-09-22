---
title: "Class MyEntityExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityExtensions.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEntityExtensions"
---

# Class MyEntityExtensions | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityExtensions

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyEntityExtensions : Object
```

### Methods

#### AddNodeToWeldingGroups(MyEntity)

##### Declaration

```
public static void AddNodeToWeldingGroups(this MyEntity thisEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |

#### AddToGamePruningStructure(MyEntity)

##### Declaration

```
public static void AddToGamePruningStructure(this MyEntity thisEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |

#### CreateDefaultSyncEntity(MyEntity)

##### Declaration

```
public static MySyncComponentBase CreateDefaultSyncEntity(this MyEntity thisEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |

##### Returns

| Type | Description |
| --- | --- |
| [MySyncComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MySyncComponentBase.html) |     |

#### EntityFactoryCreateObjectBuilder(MyEntity)

##### Declaration

```
public static MyObjectBuilder_EntityBase EntityFactoryCreateObjectBuilder(this MyEntity thisEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

#### GetInventory(MyEntity, Int32)

Search for inventory component with maching index.

##### Declaration

```
public static MyInventory GetInventory(this MyEntity thisEntity, int index = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |
| System.Int32 | index |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html) |     |

#### GetPhysicsBody(MyEntity)

##### Declaration

```
public static MyPhysicsBody GetPhysicsBody(this MyEntity thisEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Engine.Physics.MyPhysicsBody |     |

#### GetWeldingGroupNodes(MyEntity, List<MyEntity>)

##### Declaration

```
public static void GetWeldingGroupNodes(this MyEntity thisEntity, List<MyEntity> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result |     |

#### ProceduralWorldGeneratorTrackEntity(MyEntity)

##### Declaration

```
public static void ProceduralWorldGeneratorTrackEntity(this MyEntity thisEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |

#### RemoveFromGamePruningStructure(MyEntity)

##### Declaration

```
public static void RemoveFromGamePruningStructure(this MyEntity thisEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |

#### RemoveNodeFromWeldingGroups(MyEntity)

##### Declaration

```
public static void RemoveNodeFromWeldingGroups(this MyEntity thisEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |

#### TryGetInventory(MyEntity, out MyInventory)

##### Declaration

```
public static bool TryGetInventory(this MyEntity thisEntity, out MyInventory inventory)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |
| [MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html) | inventory |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryGetInventory(MyEntity, out MyInventoryBase)

##### Declaration

```
public static bool TryGetInventory(this MyEntity thisEntity, out MyInventoryBase inventoryBase)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | thisEntity |     |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventoryBase |     |
