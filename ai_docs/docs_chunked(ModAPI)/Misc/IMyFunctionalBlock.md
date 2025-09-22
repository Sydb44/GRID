---
title: "Interface IMyFunctionalBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyFunctionalBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyFunctionalBlock"
---

# Interface IMyFunctionalBlock | Space Engineers ModAPI

Describes functional block (block with Enabled/Disabled toggle) (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyFunctionalBlock : IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### Enabled

Represents terminal gui toggle. Gets or sets if block is Enabled

##### Declaration

```
bool Enabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### RequestEnable(Boolean)

Obsolete

##### Declaration

```
void RequestEnable(bool enable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enable |     |

### Extension Methods