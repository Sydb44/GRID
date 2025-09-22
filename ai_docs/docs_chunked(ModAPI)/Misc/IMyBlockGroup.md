---
title: "Interface IMyBlockGroup"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBlockGroup.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyBlockGroup"
---

# Interface IMyBlockGroup | Space Engineers ModAPI

Describes terminal block group (PB scripting interface)

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyBlockGroup
```

### Properties

#### Name

Gets name of terminal blocks group

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### GetBlocks(List<IMyTerminalBlock>, Func<IMyTerminalBlock, Boolean>)

Get terminal blocks which assigned to this group

##### Declaration

```
void GetBlocks(List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html)\> | blocks | buffer array |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html), System.Boolean\> | collect | if function returns true, block would be added to `blocks` |

#### GetBlocksOfType<T>(List<T>, Func<T, Boolean>)

Get terminal blocks which assigned to this group, and matching type

##### Declaration

```
void GetBlocksOfType<T>(List<T> blocks, Func<T, bool> collect = null)
    where T : class
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<T> | blocks | Buffer array that would receive results. It is cleared before call. Can be null |
| System.Func<T, System.Boolean\> | collect | if function returns true, block would be added to `blocks` |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Block must be assignable from T |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.NullReferenceException | If function `collect` returns true, and `blocks` is null |

#### GetBlocksOfType<T>(List<IMyTerminalBlock>, Func<IMyTerminalBlock, Boolean>)

Get terminal blocks which assigned to this group, and matching type

##### Declaration

```
void GetBlocksOfType<T>(List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null)
    where T : class
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html)\> | blocks | buffer array |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html), System.Boolean\> | collect | if function returns true, block would be added to `blocks` |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | Block must be assignable from T |

##### Exceptions

| Type | Condition |
| --- | --- |
| System.NullReferenceException | If function `collect` returns true, and `blocks` is null |