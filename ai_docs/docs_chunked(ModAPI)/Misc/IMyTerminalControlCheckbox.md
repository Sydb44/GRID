---
title: "Interface IMyTerminalControlCheckbox"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlCheckbox.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalControlCheckbox"
---

# Interface IMyTerminalControlCheckbox | Space Engineers ModAPI

This is a checkbox. A label appears and a box appears next to it

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalControlCheckbox : IMyTerminalControl, IMyTerminalValueControl<bool>, ITerminalProperty, IMyTerminalControlTitleTooltip
```

### Properties

#### OffText

The "off" label text

##### Declaration

```
MyStringId OffText { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### OnText

The "on" label text

##### Declaration

```
MyStringId OnText { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

### Extension Methods