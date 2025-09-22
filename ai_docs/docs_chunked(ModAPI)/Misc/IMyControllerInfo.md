---
title: "Interface IMyControllerInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyControllerInfo.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyControllerInfo"
---

# Interface IMyControllerInfo | Space Engineers ModAPI

Describes interface that provides information about current control state for controllable entities such as turret, cockpit, character ...

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyControllerInfo
```

### Properties

#### Controller

Gets the controller for the entity

##### Declaration

```
IMyEntityController Controller { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntityController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyEntityController.html) |     |

#### ControllingIdentityId

Gets the controlling entity id (eg. IMyPlayer.IdentityId)

##### Declaration

```
long ControllingIdentityId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Methods

#### IsLocallyControlled()

Returns true if the local player is controlling the entity

##### Declaration

```
bool IsLocallyControlled()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsLocallyHumanControlled()

Returns true if the local human player is controlling the entity

##### Declaration

```
bool IsLocallyHumanControlled()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRemotelyControlled()

Returns true if the entity is remotely controlled

##### Declaration

```
bool IsRemotelyControlled()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Events

#### ControlAcquired

Called when the entity gains a controller

##### Declaration

```
event Action<IMyEntityController> ControlAcquired
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntityController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyEntityController.html)\> |     |

#### ControlReleased

Called when the entity loses a controller

##### Declaration

```
event Action<IMyEntityController> ControlReleased
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyEntityController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyEntityController.html)\> |     |