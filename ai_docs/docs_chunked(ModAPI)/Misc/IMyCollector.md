---
title: "Interface IMyCollector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyCollector.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyCollector"
---

# Interface IMyCollector | Space Engineers ModAPI

Describes collector block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyCollector : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### UseConveyorSystem

Gets or sets whether this collector block should push out items from it

##### Declaration

```
bool UseConveyorSystem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods