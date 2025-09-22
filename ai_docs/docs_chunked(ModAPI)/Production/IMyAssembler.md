---
title: "Interface IMyAssembler"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAssembler.html"
category: "Production"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyAssembler"
---

# Interface IMyAssembler | Space Engineers ModAPI

Describes assembler block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyAssembler : IMyProductionBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### CooperativeMode

Gets or sets whether this assembler should cooperate with other assemblers by adopting parts of their work queue.

##### Declaration

```
bool CooperativeMode { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CurrentProgress

Gets the progress for the item currently in production.

##### Declaration

```
float CurrentProgress { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DisassembleEnabled

Gets whether this assembler has disassemble mode enabled

##### Declaration

```
bool DisassembleEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Mode

Gets or sets the current work mode of this assembly, whether it's assembling or disassembling.

##### Declaration

```
MyAssemblerMode Mode { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyAssemblerMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyAssemblerMode.html) |     |

#### Repeating

Gets or sets whether this assembler should be perpetually repeating its work queue.

##### Declaration

```
bool Repeating { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods