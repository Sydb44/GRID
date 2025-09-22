---
title: "Class MyEntities"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntities.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEntities"
---

# Class MyEntities | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntities

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[StaticEventOwner]
public static class MyEntities : Object
```

### Fields

#### CloseAllowed

##### Declaration

```
public static bool CloseAllowed
```

##### Field Value

Type

Description

System.Boolean

#### DetectorsHidden

##### Declaration

```
public static bool DetectorsHidden
```

##### Field Value

Type

Description

System.Boolean

#### DetectorsSelectable

##### Declaration

```
public static bool DetectorsSelectable
```

##### Field Value

Type

Description

System.Boolean

#### EntityCloseLock

##### Declaration

```
public static FastResourceLock EntityCloseLock
```

##### Field Value

Type

Description

VRage.FastResourceLock

#### EntityMarkForCloseLock

##### Declaration

```
public static FastResourceLock EntityMarkForCloseLock
```

##### Field Value

Type

Description

VRage.FastResourceLock

#### IgnoreMemoryLimits

##### Declaration

```
public static bool IgnoreMemoryLimits
```

##### Field Value

Type

Description

System.Boolean

#### IsClosingAll

##### Declaration

```
public static bool IsClosingAll
```

##### Field Value

Type

Description

System.Boolean

#### m\_entityNameDictionary

##### Declaration

```
public static ConcurrentDictionary<string, MyEntity> m_entityNameDictionary
```

##### Field Value

Type

Description

System.Collections.Concurrent.ConcurrentDictionary<System.String, [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

#### Orchestrator

##### Declaration

```
public static IMyUpdateOrchestrator Orchestrator
```

##### Field Value

Type

Description

[IMyUpdateOrchestrator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyUpdateOrchestrator.html)

#### ParticleEffectsHidden

##### Declaration

```
public static bool ParticleEffectsHidden
```

##### Field Value

Type

Description

System.Boolean

#### ParticleEffectsSelectable

##### Declaration

```
public static bool ParticleEffectsSelectable
```

##### Field Value

Type

Description

System.Boolean

#### SafeAreasHidden

##### Declaration

```
public static bool SafeAreasHidden
```

##### Field Value

Type

Description

System.Boolean

#### SafeAreasSelectable

##### Declaration

```
public static bool SafeAreasSelectable
```

##### Field Value

Type

Description

System.Boolean

#### UnloadDataLock

##### Declaration

```
public static FastResourceLock UnloadDataLock
```

##### Field Value

Type

Description

VRage.FastResourceLock

#### UpdateInProgress

##### Declaration

```
public static bool UpdateInProgress
```

##### Field Value

Type

Description

System.Boolean

### Properties

#### IsAsyncUpdateInProgress

##### Declaration

```
public static bool IsAsyncUpdateInProgress { get; }
```

##### Property Value

Type

Description

System.Boolean

#### IsLoaded

##### Declaration

```
public static bool IsLoaded { get; }
```

##### Property Value

Type

Description

System.Boolean

#### MemoryLimitAddFailure

##### Declaration

```
public static bool MemoryLimitAddFailure { get; }
```

##### Property Value

Type

Description

System.Boolean

### Methods

#### Add(MyEntity, Boolean)

##### Declaration

```
public static void Add(MyEntity entity, bool insertIntoScene = true)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

System.Boolean

insertIntoScene

#### AddRenderObjectToMap(UInt32, IMyEntity)

##### Declaration

```
public static void AddRenderObjectToMap(uint id, IMyEntity entity)
```

##### Parameters

Type

Name

Description

System.UInt32

id

[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

entity

#### CallAsync(Action)

##### Declaration

```
public static void CallAsync(Action doneHandler)
```

##### Parameters

Type

Name

Description

System.Action

doneHandler

#### CallAsync(MyEntity, Action<MyEntity>)

##### Declaration

```
public static void CallAsync(MyEntity entity, Action<MyEntity> doneHandler)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

doneHandler

#### Close(MyEntity)

##### Declaration

```
public static void Close(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

#### CloseAll()

##### Declaration

```
public static void CloseAll()
```

#### CreateAsync(MyObjectBuilder\_EntityBase, Boolean, Action<MyEntity>)

Creates object asynchronously and adds it into scene. DoneHandler is invoked from update thread when the object is added into scene.

##### Declaration

```
public static void CreateAsync(MyObjectBuilder_EntityBase objectBuilder, bool addToScene, Action<MyEntity> doneHandler = null)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

System.Boolean

addToScene

System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

doneHandler

#### CreateEntity(MyDefinitionId, Boolean, Boolean, Nullable<Vector3>, Nullable<Vector3>, Nullable<Vector3>)
