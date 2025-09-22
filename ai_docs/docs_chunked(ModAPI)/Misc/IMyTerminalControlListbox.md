---
title: "Interface IMyTerminalControlListbox"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlListbox.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalControlListbox"
---

# Interface IMyTerminalControlListbox | Space Engineers ModAPI

This is a list box. It contains a list of items that a user can select.

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalControlListbox : IMyTerminalControl, IMyTerminalControlTitleTooltip
```

### [](#properties)Properties

#### [](#Sandbox_ModAPI_Interfaces_Terminal_IMyTerminalControlListbox_ItemSelected)ItemSelected

This is triggered when an item is selected. Can contain more than one item if Multiselect is true.

##### Declaration

```
Action<IMyTerminalBlock, List<MyTerminalControlListBoxItem>> ItemSelected { set; }
```

##### Property Value

#### [](#Sandbox_ModAPI_Interfaces_Terminal_IMyTerminalControlListbox_ListContent)ListContent

This is triggered when you need to populate the list with list items. The first list is the items in the list box, and the second list is the selected items in the list.

##### Declaration

```
Action<IMyTerminalBlock, List<MyTerminalControlListBoxItem>, List<MyTerminalControlListBoxItem>> ListContent { set; }
```

##### Property Value

#### [](#Sandbox_ModAPI_Interfaces_Terminal_IMyTerminalControlListbox_Multiselect)Multiselect

This allows you to enable/disable multiple item selection

##### Declaration

```
bool Multiselect { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_Interfaces_Terminal_IMyTerminalControlListbox_VisibleRowsCount)VisibleRowsCount

This allows you to set how many rows are visible in the list box.

##### Declaration

```
int VisibleRowsCount { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |