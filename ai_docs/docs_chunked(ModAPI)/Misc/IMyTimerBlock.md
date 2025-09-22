---
title: "Interface IMyTimerBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyTimerBlock.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyTimerBlock"
---

# Interface IMyTimerBlock | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMyTimerBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### IsCountingDown

Gets if the timer block is active and counting down

##### Declaration

```
bool IsCountingDown { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Silent

Gets or sets if the countdown is silent

##### Declaration

```
bool Silent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TriggerDelay

Gets or sets the countdown time, in seconds

##### Declaration

```
float TriggerDelay { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### StartCountdown()

Begin countdown

##### Declaration

#### StopCountdown()

Stops current countdown

##### Declaration

#### Trigger()

Trigger immediately, skips countdown

##### Declaration

### Extension Methods