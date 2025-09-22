---
title: "Interface IMyTerminalControlCombobox"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlCombobox.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalControlCombobox"
---

# Interface IMyTerminalControlCombobox | Space Engineers ModAPI

This is a combobox control. It is a field that gives a drop down list that contains options that you can select.

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalControlCombobox : IMyTerminalControl, IMyTerminalValueControl<long>, ITerminalProperty, IMyTerminalControlTitleTooltip
```

### Properties

#### ComboBoxContent

This allows you to set the content of the combo box itself.

##### Declaration

```
Action<List<MyTerminalControlComboBoxItem>> ComboBoxContent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<System.Collections.Generic.List<[MyTerminalControlComboBoxItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyTerminalControlComboBoxItem.html)\>> |     |

### Extension Methods