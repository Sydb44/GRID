---
title: "Class MyCubeGridUpdateQueueExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGridUpdateQueueExtensions.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyCubeGridUpdateQueueExtensions"
---

# Class MyCubeGridUpdateQueueExtensions | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeGridUpdateQueueExtensions

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyCubeGridUpdateQueueExtensions : Object
```

### Methods

#### IsAfterSimulation(MyCubeGrid.UpdateQueue)

Whether a given update queue is executed after simulation.

##### Declaration

```
public static bool IsAfterSimulation(this MyCubeGrid.UpdateQueue queue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid.UpdateQueue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.UpdateQueue.html) | queue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsBeforeSimulation(MyCubeGrid.UpdateQueue)

Whether a given update queue is executed before simulation.

##### Declaration

```
public static bool IsBeforeSimulation(this MyCubeGrid.UpdateQueue queue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid.UpdateQueue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.UpdateQueue.html) | queue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsExecutedOnce(MyCubeGrid.UpdateQueue)

Whether a given update queue will be executed once.

##### Declaration

```
public static bool IsExecutedOnce(this MyCubeGrid.UpdateQueue queue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid.UpdateQueue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.UpdateQueue.html) | queue |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |