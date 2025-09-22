---
title: "Interface IMyTerminalAction"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalAction"
---

# Interface IMyTerminalAction | Space Engineers ModAPI

This is an interface wrapper for terminal actions that appear on a toolbar. An instance of this interface is created via MyAPIGateway.TerminalControls.CreateAction. Once created, you may modify various fields to control how the action behaves.

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalAction : ITerminalAction
```

### Properties

#### Action

This is the action taken when an action is performed.

##### Declaration

```
Action<IMyTerminalBlock> Action { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html)\> |     |

#### Enabled

Allows you to set if this action is enabled or disabled

##### Declaration

```
Func<IMyTerminalBlock, bool> Enabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Boolean\> |     |

#### Icon

Allows you to set the Icon of this action. It's a link to an icon texture.

##### Declaration

```
string Icon { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### InvalidToolbarTypes

Allows you to set which toolbar type this action is invalid for. Adding to this means this action may not be added to that toolbar type.

##### Declaration

```
List<MyToolbarType> InvalidToolbarTypes { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyToolbarType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyToolbarType.html)\> |     |

#### Name

Allows you to set the name of the Action

##### Declaration

```
StringBuilder Name { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

#### ValidForGroups

Allows you to set if this action is valid in groups

##### Declaration

```
bool ValidForGroups { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Writer

This allows you to set the "Icon Text" of an action (the text that appears under the icon in the toolbar)

##### Declaration

```
Action<IMyTerminalBlock, StringBuilder> Writer { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Text.StringBuilder\> |     |