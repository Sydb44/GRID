---
title: "Interface IMySpectatorTools"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySpectatorTools.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMySpectatorTools"
---

# Interface IMySpectatorTools | Space Engineers ModAPI

ModAPI interface giving access to spector control

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMySpectatorTools
```

### Properties

#### TrackedSlots

Get tracked entities

##### Declaration

```
IReadOnlyList<MyLockEntityState> TrackedSlots { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IReadOnlyList<[MyLockEntityState](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyLockEntityState.html)\> |     |

### Methods

#### ClearTrackedSlot(Int32)

Removes tracking entity at slot

##### Declaration

```
void ClearTrackedSlot(int slotIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | slotIndex | Slot to remove |

#### GetMode()

Gets current camera work

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [MyCameraMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyCameraMode.html) | Mode of work |

#### GetTarget()

Gets current tracked entity

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | Entity |

#### LockHitEntity()

Lock entity that you look at

##### Declaration

#### NextPlayer()

Switching camera to next player

##### Declaration

#### PreviousPlayer()

Switching camera to previous player

##### Declaration

#### SaveTrackedSlot(Int32)

Save current camera and track settings at slot

##### Declaration

```
void SaveTrackedSlot(int slotIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | slotIndex | Index to save at |

#### SelectTrackedSlot(Int32)

Switch to selected

##### Declaration

```
void SelectTrackedSlot(int slotIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | slotIndex |     |

#### SetMode(MyCameraMode)

Set camera work mode

##### Declaration

```
void SetMode(MyCameraMode mode)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCameraMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyCameraMode.html) | mode | Mode of work |

#### SetTarget(IMyEntity)

Set tracked target

##### Declaration

```
void SetTarget(IMyEntity ent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ent | Entity to follow |