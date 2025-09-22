---
title: "Interface IMySmallGatlingGun"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMySmallGatlingGun.html"
category: "Weapons"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMySmallGatlingGun"
---

# Interface IMySmallGatlingGun | Space Engineers ModAPI

Describes gatling gun (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySmallGatlingGun : IMyUserControllableGun, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### UseConveyorSystem

Getter whether gatling gun can pull items from conveyor system

##### Declaration

```
bool UseConveyorSystem { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods