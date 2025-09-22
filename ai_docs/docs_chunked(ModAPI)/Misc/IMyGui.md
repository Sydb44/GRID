---
title: "Interface IMyGui"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGui.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGui"
---

# Interface IMyGui | Space Engineers ModAPI

ModAPI interface giving access to GUI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

### Properties

#### ActiveGamePlayScreen

Gets the name of the currently open GUI screen.

##### Declaration

```
string ActiveGamePlayScreen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ChatEntryVisible

Checks if the chat entry box is visible.

##### Declaration

```
bool ChatEntryVisible { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCurrentScreen

Gets an enum describing the currently open GUI screen.

##### Declaration

```
MyTerminalPageEnum GetCurrentScreen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTerminalPageEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyTerminalPageEnum.html) |     |

#### InteractedEntity

Gets the entity the player is currently interacting with.

##### Declaration

```
IMyEntity InteractedEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IsCursorVisible

Checks if the cursor is visible.

##### Declaration

```
bool IsCursorVisible { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ChangeInteractedEntity(IMyEntity, Boolean)

Switches the entity the terminal is activated for.

##### Declaration

```
void ChangeInteractedEntity(IMyEntity interactedEntity, bool isRemote)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | interactedEntity | The entity the terminal page will be shown for. null for player. |
| System.Boolean | isRemote | If terminal refers to a remote entity (over antenna). |

#### ShowTerminalPage(MyTerminalPageEnum, IMyCharacter, IMyEntity, Boolean)

Shows the terminal and opens a specific tab.

##### Declaration

```
void ShowTerminalPage(MyTerminalPageEnum page, IMyCharacter user, IMyEntity interactedEntity = null, bool isRemote = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTerminalPageEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyTerminalPageEnum.html) | page | Tab to open. |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) | user | The user that will interact with the terminal. |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | interactedEntity | The entity the terminal page will be shown for. null for player. |
| System.Boolean | isRemote | If terminal refers to a remote entity (over antenna). |

### Events

#### GuiControlCreated

Event triggered on gui control created.

##### Declaration

```
event Action<object> GuiControlCreated
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Object\> |     |

#### GuiControlRemoved

Event triggered on gui control removed.

##### Declaration

```
event Action<object> GuiControlRemoved
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Object\> |     |