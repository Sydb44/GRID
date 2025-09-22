---
title: "Interface IUserCustomizableTerminalAction"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IUserCustomizableTerminalAction.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IUserCustomizableTerminalAction"
---

# Interface IUserCustomizableTerminalAction | Space Engineers ModAPI

Describes terminal action that allows capturing custom arguments and setting toolbar icon title

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IUserCustomizableTerminalAction
```

### Properties

#### Parameters

##### Declaration

```
IList<TerminalActionParameter> Parameters { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.IList<[TerminalActionParameter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.TerminalActionParameter.html)\> |     |

### Methods

#### FetchAllBlocks(List<IMyTerminalBlock>)

Gets all blocks the action is associated with

##### Declaration

```
void FetchAllBlocks(List<IMyTerminalBlock> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html)\> | result |     |

#### GetBlock()

Gets the block the action is associated with

##### Declaration

```
IMyTerminalBlock GetBlock()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) |     |

#### SetCustomIconTitle(String)

Sets custom title for toolbar icon

##### Declaration

```
void SetCustomIconTitle(string title)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | title | Text for the toolbar icon |