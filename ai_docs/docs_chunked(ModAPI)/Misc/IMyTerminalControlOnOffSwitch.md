---
title: "Interface IMyTerminalControlOnOffSwitch"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlOnOffSwitch.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalControlOnOffSwitch"
---

# Interface IMyTerminalControlOnOffSwitch | Space Engineers ModAPI

This is an on / off switch or toggle button. It gives two options that a user can toggled between.

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalControlOnOffSwitch : IMyTerminalControl, IMyTerminalValueControl<bool>, ITerminalProperty, IMyTerminalControlTitleTooltip
```

### Properties

#### OffText

The label for the "off" switch

##### Declaration

```
MyStringId OffText { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### OnText

The label for the "on" switch

##### Declaration

```
MyStringId OnText { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

### Extension Methods