---
title: "Class MyTargetLockingBlockComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyTargetLockingBlockComponent"
---

# Class MyTargetLockingBlockComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyTargetLockingBlockComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[StaticEventOwner]
[MyComponentType]
[MyComponentBuilder]
public class MyTargetLockingBlockComponent : MyEventProxyEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyTargetLockingComponent, IMyDistanceToLockedTarget
```

### Constructors

#### MyTargetLockingBlockComponent()

##### Declaration

```
public MyTargetLockingBlockComponent()
```

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
public MyTargetLockingBlockComponentDefinition Definition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTargetLockingBlockComponentDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyTargetLockingBlockComponentDefinition.html) |     |

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

#### Update()

##### Declaration

### Events

#### DistanceToLockedTargetChanged

##### Declaration

```
public event Action<IMyDistanceToLockedTarget, float, float> DistanceToLockedTargetChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyDistanceToLockedTarget](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyDistanceToLockedTarget.html), System.Single, System.Single\> |     |

### Implements

### Extension Methods