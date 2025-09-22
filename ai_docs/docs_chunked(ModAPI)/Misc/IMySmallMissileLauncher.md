---
title: "Interface IMySmallMissileLauncher"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMySmallMissileLauncher.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMySmallMissileLauncher"
---

# Interface IMySmallMissileLauncher | Space Engineers ModAPI

Describes missile launcher block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySmallMissileLauncher : IMyUserControllableGun, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### UseConveyorSystem

Getter whether missile launcher can pull items from conveyor system

##### Declaration

```
bool UseConveyorSystem { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods