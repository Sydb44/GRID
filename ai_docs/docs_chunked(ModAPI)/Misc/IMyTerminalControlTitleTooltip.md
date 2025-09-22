---
title: "Interface IMyTerminalControlTitleTooltip"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlTitleTooltip.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalControlTitleTooltip"
---

# Interface IMyTerminalControlTitleTooltip | Space Engineers ModAPI

This is a base interface for other interfaces. Almost all controls implement this, and allows you to set the label (Title) of the control and also the tooltip that appears when hovering over the control.

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalControlTitleTooltip
```

### Properties

#### Title

Allows you to get or set the Label that appears on the control

##### Declaration

```
MyStringId Title { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### Tooltip

Allows you to get or set the tooltip that appears when you hover over the control

##### Declaration

```
MyStringId Tooltip { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |