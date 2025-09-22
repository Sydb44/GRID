---
title: "Interface IMyParallelUpdateable"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyParallelUpdateable.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "IMyParallelUpdateable"
---

# Interface IMyParallelUpdateable | Space Engineers ModAPI

Interface that must be implemented by any entity that supports parallel updates.

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyParallelUpdateable : IMyEntity, IMyEntity
```

### Properties

#### UpdateFlags

##### Declaration

```
MyParallelUpdateFlags UpdateFlags { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyParallelUpdateFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyParallelUpdateFlags.html) |     |

### Methods

#### UpdateAfterSimulationParallel()

##### Declaration

```
void UpdateAfterSimulationParallel()
```

#### UpdateBeforeSimulationParallel()

##### Declaration

```
void UpdateBeforeSimulationParallel()
```