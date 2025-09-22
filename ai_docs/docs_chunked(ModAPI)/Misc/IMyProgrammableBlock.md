---
title: "Interface IMyProgrammableBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyProgrammableBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyProgrammableBlock"
---

# Interface IMyProgrammableBlock | Space Engineers ModAPI

Describes programmable block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyProgrammableBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyTextSurfaceProvider
```

### Properties

#### IsRunning

Get whether this programmable block is currently running its program.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TerminalRunArgument

Get default terminal argument.

##### Declaration

```
string TerminalRunArgument { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### TryRun(String)

Attempts to run this programmable block using the given argument. An already running programmable block cannot be run again. This is equivalent to running `block.ApplyAction("Run", argumentsList);` This should be called from an ingame script. Do not use in mods.

##### Declaration

```
bool TryRun(string argument)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | argument |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | `true` if the action was applied, `false` otherwise |

### Extension Methods