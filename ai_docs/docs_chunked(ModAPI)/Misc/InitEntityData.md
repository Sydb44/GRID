---
title: "Class MyEntities.InitEntityData"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.InitEntityData.html"
category: "Misc"
namespace: "Sandbox.Game.Entities.MyEntities"
class: "InitEntityData"
---

# Class MyEntities.InitEntityData | Space Engineers ModAPI

Holds data for asynchronous entity init

##### Inheritance

System.Object

ParallelTasks.WorkData

MyEntities.InitEntityData

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class InitEntityData : WorkData
```

### Constructors

#### InitEntityData(MyObjectBuilder\_EntityBase, Boolean, Action<MyEntity>, MyEntity, Boolean, MyEntity, Nullable<Vector3D>, Boolean)

##### Declaration

```
public InitEntityData(MyObjectBuilder_EntityBase objectBuilder, bool addToScene, Action<MyEntity> completionCallback, MyEntity entity, bool fadeIn, MyEntity relativeSpawner = null, Nullable<Vector3D> relativeOffset = null, bool checkPosition = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |
| System.Boolean | addToScene |     |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | completionCallback |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Boolean | fadeIn |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | relativeSpawner |     |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | relativeOffset |     |
| System.Boolean | checkPosition |     |

### Methods

#### CallInitEntity(Boolean)

##### Declaration

```
public (bool, MyEntity) CallInitEntity(bool tolerateBlacklistedPlanets = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | tolerateBlacklistedPlanets |     |

##### Returns

| Type | Description |
| --- | --- |
| System.ValueTuple<System.Boolean, [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> |     |

#### OnEntityInitialized()

##### Declaration

```
public void OnEntityInitialized()
```