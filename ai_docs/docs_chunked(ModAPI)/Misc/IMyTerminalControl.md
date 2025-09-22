---
title: "Interface IMyTerminalControl"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalControl"
---

# Interface IMyTerminalControl | Space Engineers ModAPI

This is the base terminal control interface. All controls implement this.

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalControl
```

### Properties

#### Enabled

Allows you to set if the control is enabled

##### Declaration

```
Func<IMyTerminalBlock, bool> Enabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Boolean\> |     |

#### Id

Identifier of control

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### SupportsMultipleBlocks

Allows you to set if the control is visible when the block is selected as a group

##### Declaration

```
bool SupportsMultipleBlocks { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Visible

Allows you to set if the control is visible

##### Declaration

```
Func<IMyTerminalBlock, bool> Visible { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Boolean\> |     |

### Methods

#### RedrawControl()

Recreates the control GUI. This allows you to update the Title of some controls.

##### Declaration

#### UpdateVisual()

This updates a control that is currently displayed, allowing you to refresh it's state

##### Declaration