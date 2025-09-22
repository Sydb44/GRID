---
title: "Interface IMyWorkAreaTool"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyWorkAreaTool.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyWorkAreaTool"
---

  Interface IMyWorkAreaTool | Space Engineers ModAPI         

[Show / Hide Table of Contents](#sidetoggle)

# Interface IMyWorkAreaTool

Describes tool used by work area component

###### **Namespace**: [Sandbox.ModAPI](Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyWorkAreaTool
```

### Properties

#### IsBusy

Indicates if the tool is currently busy (welding, drilling, grinding in progress)

##### Declaration

```
bool IsBusy { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Events

#### BusyStatusChanged

Event invoked when busy status of the tool has changed

##### Declaration

```
event Action<bool> BusyStatusChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Boolean\> |     |

#### InventoryActionTriggered

Event invoked upon inventory action triggers (can't push from inventory of drill and grinder or empty inventory of welder)

##### Declaration

```
event Action InventoryActionTriggered
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action |     |

_☀_

_☾_