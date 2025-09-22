---
title: "Interface IMyWarhead"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyWarhead.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyWarhead"
---

# Interface IMyWarhead | Space Engineers ModAPI

Describes Warhead block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyWarhead : IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### DetonationTime

Gets actual detonation time \[s\]

##### Declaration

```
float DetonationTime { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsArmed

Gets or sets whether this warhead block is armed

##### Declaration

```
bool IsArmed { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsCountingDown

Gets whether this warhead block is counting down

##### Declaration

```
bool IsCountingDown { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Detonate()

Detonates the warhead

##### Declaration

#### StartCountdown()

Start the countdown

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if countdown was started, false if countdown can not start (block not functional) or countdown already running |

#### StopCountdown()

Stops the countdown

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if countdown was stopped, false if countdown can not stop (block not functional) or countdown is not running |

### Extension Methods