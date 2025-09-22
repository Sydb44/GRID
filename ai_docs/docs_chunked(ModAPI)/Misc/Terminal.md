---
title: "Namespace Sandbox.ModAPI.Interfaces.Terminal"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces"
class: "Terminal"
---

# Namespace Sandbox.ModAPI.Interfaces.Terminal | Space Engineers ModAPI

### Interfaces

#### [IMyTerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction.html)

This is an interface wrapper for terminal actions that appear on a toolbar. An instance of this interface is created via MyAPIGateway.TerminalControls.CreateAction. Once created, you may modify various fields to control how the action behaves.

#### [IMyTerminalControl](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl.html)

This is the base terminal control interface. All controls implement this.

#### [IMyTerminalControlButton](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlButton.html)

This is a control button. When a button is clicked an action is performed.

#### [IMyTerminalControlCheckbox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlCheckbox.html)

This is a checkbox. A label appears and a box appears next to it

#### [IMyTerminalControlColor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlColor.html)

This is a color control. This terminal controls allows you to select colors.

#### [IMyTerminalControlCombobox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlCombobox.html)

This is a combobox control. It is a field that gives a drop down list that contains options that you can select.

#### [IMyTerminalControlLabel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlLabel.html)

This is a simple label control.

#### [IMyTerminalControlListbox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlListbox.html)

This is a list box. It contains a list of items that a user can select.

#### [IMyTerminalControlOnOffSwitch](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlOnOffSwitch.html)

This is an on / off switch or toggle button. It gives two options that a user can toggled between.

#### [IMyTerminalControlProperty<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlProperty-1.html)

This is a control property. This is use to set properties on a block that can be referenced in the ProgrammableBlock.

#### [IMyTerminalControlSeparator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSeparator.html)

This is a simple line separator used to separate controls in a visible manner.

#### [IMyTerminalControlSlider](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider.html)

This is a value slider. A slider can be moved by a user and a value selected.

#### [IMyTerminalControlTextbox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlTextbox.html)

This is a textbox where a user can enter values into.

#### [IMyTerminalControlTitleTooltip](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlTitleTooltip.html)

This is a base interface for other interfaces. Almost all controls implement this, and allows you to set the label (Title) of the control and also the tooltip that appears when hovering over the control.

#### [IMyTerminalValueControl<TValue>](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalValueControl-1.html)

This is a value control interface that a few controls implement. When a value changes, the Setter action is performed. When a value is queried the Getter action is performed.