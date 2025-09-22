---
title: "Class MyTargetLockingComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyTargetLockingComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyTargetLockingComponent"
---

# Class MyTargetLockingComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyTargetLockingComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[StaticEventOwner]
[MyComponentType]
[MyComponentBuilder]
public class MyTargetLockingComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent, IMyTargetLockingComponent, IMyDistanceToLockedTarget
```

### Constructors

#### MyTargetLockingComponent()

##### Declaration

```
public MyTargetLockingComponent()
```

### Fields

#### LOST\_GRID\_RETRY\_ATTEMPTS

##### Declaration

```
public const int LOST_GRID_RETRY_ATTEMPTS = 30
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### Definition

##### Declaration

```
public MyTargetLockingComponentDefinition Definition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTargetLockingComponentDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyTargetLockingComponentDefinition.html) |     |

#### DistanceToLockedTarget

##### Declaration

```
public float DistanceToLockedTarget { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsLosingLock

##### Declaration

```
public bool IsLosingLock { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsTargetLocked

##### Declaration

```
public bool IsTargetLocked { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LockingProgressMilliseconds

##### Declaration

```
public float LockingProgressMilliseconds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### LockingProgressPercent

##### Declaration

```
public float LockingProgressPercent { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### LockingTimeRemainingMilliseconds

##### Declaration

```
public float LockingTimeRemainingMilliseconds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Target

##### Declaration

```
public MyCubeGrid Target { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### TargetData

##### Declaration

```
public MyCharacter.MyTargetData TargetData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter.MyTargetData |     |

#### TargetEntity

##### Declaration

```
public MyEntity TargetEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

### Methods

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

##### Overrides

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnControlledEntityChanged(IMyControllableEntity, IMyControllableEntity)

##### Declaration

```
public void OnControlledEntityChanged(IMyControllableEntity oldEntity, IMyControllableEntity newEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | oldEntity |     |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | newEntity |     |

#### OnLockAcquired()

##### Declaration

```
public void OnLockAcquired()
```

#### OnLockLost()

##### Declaration

#### OnTargetInfoChanged(SyncBase)

##### Declaration

```
public void OnTargetInfoChanged(SyncBase obj)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Sync.SyncBase | obj |     |

#### OnTargetRequest(MyEntity)

##### Declaration

```
public void OnTargetRequest(MyEntity target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | target |     |

#### ReleaseTargetLock()

##### Declaration

```
public void ReleaseTargetLock()
```

#### ReleaseTargetLockRequest()

##### Declaration

```
public void ReleaseTargetLockRequest()
```

#### RequestReleaseTargetLock()

##### Declaration

```
[Event(null, 401)]
[Reliable]
[Server]
public static void RequestReleaseTargetLock()
```

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

#### UpdateBeforeSimulation()

Should be called in UpdateBeforeSimulation1 We can let characters to have update 1 as there are only few of them in world
