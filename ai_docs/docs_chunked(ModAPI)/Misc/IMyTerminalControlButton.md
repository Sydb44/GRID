---
title: "Interface IMyTerminalControlButton"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlButton.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalControlButton"
---

# Interface IMyTerminalControlButton | Space Engineers ModAPI

This is a control button. When a button is clicked an action is performed.

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalControlButton : IMyTerminalControl, IMyTerminalControlTitleTooltip
```

### Properties

#### Action

The action taken when a button is clicked

##### Declaration

```
Action<IMyTerminalBlock> Action { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html)\> |     |