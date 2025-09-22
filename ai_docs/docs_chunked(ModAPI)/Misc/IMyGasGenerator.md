---
title: "Interface IMyGasGenerator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGasGenerator.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyGasGenerator"
---

# Interface IMyGasGenerator | Space Engineers ModAPI

Describes Gas generator interface (H2/O2 block) (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyGasGenerator : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AutoRefill

Gets or sets bottles auto refill enabled

##### Declaration

```
bool AutoRefill { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsProducing

Is true when gas generator is currently producing a gas

##### Declaration

```
bool IsProducing { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseConveyorSystem

Gets or sets whether block can use conveyor system (pull ice and hydrogen/oxygen bottles)

##### Declaration

```
bool UseConveyorSystem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods