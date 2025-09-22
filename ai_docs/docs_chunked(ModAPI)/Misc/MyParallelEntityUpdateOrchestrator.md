---
title: "Class MyParallelEntityUpdateOrchestrator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyParallelEntityUpdateOrchestrator"
---

# Class MyParallelEntityUpdateOrchestrator | Space Engineers ModAPI

##### Inheritance

System.Object

MyParallelEntityUpdateOrchestrator

##### Implements

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyParallelEntityUpdateOrchestrator : Object, IMyUpdateOrchestrator
```

### Constructors

#### MyParallelEntityUpdateOrchestrator()

##### Declaration

```
public MyParallelEntityUpdateOrchestrator()
```

### Fields

#### ForceSerialUpdate

Global switch to force serial execution.

##### Declaration

```
public static bool ForceSerialUpdate
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### STATS\_SPLIT\_CHARACTER

##### Declaration

```
public static readonly string STATS_SPLIT_CHARACTER
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### WorkerPriority

Priority of the worker threads where work is scheduled.

##### Declaration

```
public static WorkPriority WorkerPriority
```

##### Field Value

| Type | Description |
| --- | --- |
| ParallelTasks.WorkPriority |     |

### Properties

#### ParallelUpdateInProgress

##### Declaration

```
public static bool ParallelUpdateInProgress { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StatsFilter

##### Declaration

```
public string StatsFilter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### StatsViewDirFilter

##### Declaration

```
public bool StatsViewDirFilter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AddEntity(MyEntity)

##### Declaration

```
public void AddEntity(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### ClearStats()

##### Declaration

#### DebugDraw()

##### Declaration

#### DispatchAfterSimulation()

##### Declaration

```
public void DispatchAfterSimulation()
```

#### DispatchBeforeSimulation()

##### Declaration

```
public void DispatchBeforeSimulation()
```

#### DispatchOnceBeforeFrame()

##### Declaration

```
public void DispatchOnceBeforeFrame()
```

#### DispatchSimulate()

##### Declaration

```
public void DispatchSimulate()
```

#### DispatchUpdatingStopped()

##### Declaration

```
public void DispatchUpdatingStopped()
```

#### EntityFlagsChanged(MyEntity)

##### Declaration

```
public void EntityFlagsChanged(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

#### GetStats()

##### Declaration

```
public StringBuilder GetStats()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

#### InvokeLater(Action, String)

Schedule a callback to be invoked in the update thread at a later time.

##### Declaration

```
public void InvokeLater(Action action, string debugName = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action |     |
| System.String | debugName |     |

##### Remarks

#### ProcessInvokeLater()

Process all queued invoke later callbacks.

##### Declaration

```
public void ProcessInvokeLater()
```

#### RemoveEntity(MyEntity, Boolean)

##### Declaration

```
public void RemoveEntity(MyEntity entity, bool immediate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Boolean | immediate |     |

#### Unload()

##### Declaration

### Implements