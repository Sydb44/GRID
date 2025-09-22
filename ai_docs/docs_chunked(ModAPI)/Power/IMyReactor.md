---
title: "Interface IMyReactor"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyReactor.html"
category: "Power"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyReactor"
---

# Interface IMyReactor | Space Engineers ModAPI

Describes reactor block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyReactor : IMyPowerProducer, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### UseConveyorSystem

Gets or sets whether this reactor block should pull items from conveyor system

##### Declaration

```
bool UseConveyorSystem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods