---
title: "Class MyGuiModHelpers"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyGuiModHelpers.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "MyGuiModHelpers"
---

# Class MyGuiModHelpers | Space Engineers ModAPI

##### Inheritance

System.Object

MyGuiModHelpers

##### Implements

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyGuiModHelpers : Object, IMyGui
```

### Constructors

#### MyGuiModHelpers()

##### Declaration

### Properties

#### ActiveGamePlayScreen

##### Declaration

```
public string ActiveGamePlayScreen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ChatEntryVisible

##### Declaration

```
public bool ChatEntryVisible { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetCurrentScreen

##### Declaration

```
public MyTerminalPageEnum GetCurrentScreen { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTerminalPageEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyTerminalPageEnum.html) |     |

#### InteractedEntity

##### Declaration

```
public IMyEntity InteractedEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### IsCursorVisible

##### Declaration

```
public bool IsCursorVisible { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ChangeInteractedEntity(IMyEntity, Boolean)

##### Declaration

```
public void ChangeInteractedEntity(IMyEntity interactedEntity, bool isRemote)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | interactedEntity |     |
| System.Boolean | isRemote |     |

#### ShowTerminalPage(MyTerminalPageEnum, IMyCharacter, IMyEntity, Boolean)

##### Declaration

```
public void ShowTerminalPage(MyTerminalPageEnum page, IMyCharacter user, IMyEntity interactedEntity = null, bool isRemote = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyTerminalPageEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyTerminalPageEnum.html) | page |     |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) | user |     |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | interactedEntity |     |
| System.Boolean | isRemote |     |

### Events

#### GuiControlCreated

##### Declaration

```
public event Action<object> GuiControlCreated
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Object\> |     |

#### GuiControlRemoved

##### Declaration

```
public event Action<object> GuiControlRemoved
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Object\> |     |

### Implements