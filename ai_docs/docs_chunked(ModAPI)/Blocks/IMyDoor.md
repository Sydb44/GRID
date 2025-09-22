---
title: "Interface IMyDoor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyDoor.html"
category: "Blocks"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyDoor"
---

# Interface IMyDoor | Space Engineers ModAPI

Describes door block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyDoor : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### Open

Indicates whether door is opened or closed. True when door is opened.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OpenRatio

The current, accurate ratio of the door's current state where 0 is fully closed and 1 is fully open.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Status

Determines the current general status of the door.

##### Declaration

```
DoorStatus Status { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DoorStatus](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.DoorStatus.html) |     |

### Methods

#### CloseDoor()

Closes the door. See [Status](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyDoor.html#Sandbox_ModAPI_Ingame_IMyDoor_Status) to get the current status.

##### Declaration

#### OpenDoor()

Opens the door. See [Status](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyDoor.html#Sandbox_ModAPI_Ingame_IMyDoor_Status) to get the current status.

##### Declaration

#### ToggleDoor()

Toggles the open state of this door. See [Status](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyDoor.html#Sandbox_ModAPI_Ingame_IMyDoor_Status) to get the current status.

##### Declaration

### Extension Methods