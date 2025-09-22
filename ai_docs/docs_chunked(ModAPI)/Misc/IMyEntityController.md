---
title: "Interface IMyEntityController"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyEntityController.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyEntityController"
---

# Interface IMyEntityController | Space Engineers ModAPI

Describes entity controller (mods interface) Allows to take controls

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyEntityController
```

### Properties

#### ControlledEntity

Get currently controlled entity

##### Declaration

```
IMyControllableEntity ControlledEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html) |     |

### Methods

#### TakeControl(IMyControllableEntity)

Taking control on entity.

##### Declaration

```
void TakeControl(IMyControllableEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html) | entity | Entity to control |

### Events

#### ControlledEntityChanged

Event triggered when currently controlled grid is changed

##### Declaration

```
event Action<IMyControllableEntity, IMyControllableEntity> ControlledEntityChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html), [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html)\> |     |