---
title: "Interface IMyUserControllableGun"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyUserControllableGun.html"
category: "Weapons"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyUserControllableGun"
---

# Interface IMyUserControllableGun | Space Engineers ModAPI

Describes gun block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyUserControllableGun : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### IsShooting

Gets whether block is shooting

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Shoot

Represents terminal gui toggle element "Shoot". Not same as [IsShooting](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyUserControllableGun.html#Sandbox_ModAPI_Ingame_IMyUserControllableGun_IsShooting)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### ShootOnce()

Triggers a single shot.

##### Declaration

### Extension Methods