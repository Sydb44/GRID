---
title: "Interface ITerminalAction"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.ITerminalAction.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces"
class: "ITerminalAction"
---

# Interface ITerminalAction | Space Engineers ModAPI

Describes terminal action interface

###### **Namespace**: [Sandbox.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface ITerminalAction
```

### Properties

#### Icon

Gets the icon of the action

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Id

Gets the id of the action

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Name

Gets the name of the action

##### Declaration

```
StringBuilder Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Text.StringBuilder |     |

### Methods

#### Apply(IMyCubeBlock)

Applies action on the block

##### Declaration

```
void Apply(IMyCubeBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block instance |

#### Apply(IMyCubeBlock, ListReader<TerminalActionParameter>)

Applies action on the block with specific action parameters

##### Declaration

```
void Apply(IMyCubeBlock block, ListReader<TerminalActionParameter> terminalActionParameters)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[TerminalActionParameter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TerminalActionParameter.html)\> | terminalActionParameters | action parameters |

#### IsEnabled(IMyCubeBlock)

Checks if action is enabled for specific block

##### Declaration

```
bool IsEnabled(IMyCubeBlock block)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if enabled |

#### WriteValue(IMyCubeBlock, StringBuilder)

Writes value for the action

##### Declaration

```
void WriteValue(IMyCubeBlock block, StringBuilder appendTo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeBlock.html) | block | block |
| System.Text.StringBuilder | appendTo | content |