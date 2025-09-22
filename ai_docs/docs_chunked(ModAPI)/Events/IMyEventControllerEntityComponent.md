---
title: "Interface IMyEventControllerEntityComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyEventControllerEntityComponent.html"
category: "Events"
namespace: "Sandbox.ModAPI"
class: "IMyEventControllerEntityComponent"
---

# Interface IMyEventControllerEntityComponent | Space Engineers ModAPI

Describes entity component for event controller with custom UI

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyEventControllerEntityComponent
```

### Properties

#### EventDisplayName

Gets the display name of the event

##### Declaration

```
MyStringId EventDisplayName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### IsSelected

Gets whether the event is selected in the terminal panel UI

##### Declaration

```
bool IsSelected { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UniqueSelectionId

Gets the unique id of the event

##### Declaration

```
long UniqueSelectionId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### YesNoToolbarNoDescription

No description of the toolbar tooltip

##### Declaration

```
string YesNoToolbarNoDescription { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### YesNoToolbarYesDescription

Yes description of the toolbar tooltip

##### Declaration

```
string YesNoToolbarYesDescription { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### CreateTerminalInterfaceControls<T>()

Creates terminal user interface for the event

##### Declaration

```
void CreateTerminalInterfaceControls<T>()
    where T : IMyTerminalBlock
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | any class with IMyTerminalBlock interface |