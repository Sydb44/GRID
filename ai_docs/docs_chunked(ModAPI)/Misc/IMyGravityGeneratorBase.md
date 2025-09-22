---
title: "Interface IMyGravityGeneratorBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyGravityGeneratorBase.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyGravityGeneratorBase"
---

# Interface IMyGravityGeneratorBase | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMyGravityGeneratorBase : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### Gravity

Gets the gravity acceleration

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GravityAcceleration

Gets or sets the gravity acceleration in m/s^2.

##### Declaration

```
float GravityAcceleration { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods