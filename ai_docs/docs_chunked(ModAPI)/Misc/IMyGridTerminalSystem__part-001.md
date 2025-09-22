---
title: "Interface IMyGridTerminalSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridTerminalSystem.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyGridTerminalSystem"
---

# Interface IMyGridTerminalSystem | Space Engineers ModAPI

Describes terminal system (PB scripting interface)

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyGridTerminalSystem
```

### Methods

#### CanAccess(IMyTerminalBlock, MyTerminalAccessScope)

Checks if the grid terminal system can still access the given [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html). A block is no longer accessible if it's destroyed, detached, it's ownership has changed or is otherwise disconnected from this grid terminal system.

##### Declaration

```
bool CanAccess(IMyTerminalBlock block, MyTerminalAccessScope scope)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html) | block | Block to test |
| [MyTerminalAccessScope](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyTerminalAccessScope.html) | scope | Type of access test |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanAccess(IMyCubeGrid, MyTerminalAccessScope)

Checks if the grid terminal system can still access the given [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeGrid.html). A grid is no longer accessible if it's destroyed, detached, it's ownership has changed or is otherwise disconnected from this grid terminal system.

##### Declaration

```
bool CanAccess(IMyCubeGrid grid, MyTerminalAccessScope scope)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.IMyCubeGrid.html) | grid | Grid to check |
| [MyTerminalAccessScope](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyTerminalAccessScope.html) | scope | Type of access check |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | False if grid is `null`, closed or you can't access that grid |

#### GetBlockGroups(List<IMyBlockGroup>, Func<IMyBlockGroup, Boolean>)

Fills the provided list with the block groups reachable by this grid terminal system.

##### Declaration

```
void GetBlockGroups(List<IMyBlockGroup> blockGroups, Func<IMyBlockGroup, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyBlockGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBlockGroup.html)\> | blockGroups |     |
| System.Func<[IMyBlockGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBlockGroup.html), System.Boolean\> | collect | Provide a filter method to determine if a given group should be added or not. |

#### GetBlockGroupWithName(String)

Returns the first block group found with the given name. Will return `null` if no block group with that name can be found.

##### Declaration

```
IMyBlockGroup GetBlockGroupWithName(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | The block group must contain the given name in their name. |

##### Returns

| Type | Description |
| --- | --- |
| [IMyBlockGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBlockGroup.html) | First found block group with `name` or `null` if no block group with that name can be found |

#### GetBlocks(List<IMyTerminalBlock>)

Fills the provided list with all the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.

##### Declaration

```
void GetBlocks(List<IMyTerminalBlock> blocks)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html)\> | blocks | A preallocated list to receive the blocks. |

#### GetBlocksOfType<T>(List<T>, Func<T, Boolean>)

Fills the provided list with the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.

##### Declaration

```
void GetBlocksOfType<T>(List<T> blocks, Func<T, bool> collect = null)
    where T : class
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<T> | blocks | A preallocated list to receive the blocks. |
| System.Func<T, System.Boolean\> | collect | Provide a filter method to determine if a given group should be added or not. |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | The type of blocks to retrieve. |

#### GetBlocksOfType<T>(List<IMyTerminalBlock>, Func<IMyTerminalBlock, Boolean>)

Fills the provided list with the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.

##### Declaration

```
void GetBlocksOfType<T>(List<IMyTerminalBlock> blocks, Func<IMyTerminalBlock, bool> collect = null)
    where T : class
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html)\> | blocks | A preallocated list to receive the blocks. |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyTerminalBlock.html), System.Boolean\> | collect | Provide a filter method to determine if a given group should be added or not. |
