---
title: "Interface IMyLandingGear"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyLandingGear.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyLandingGear"
---

# Interface IMyLandingGear | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMyLandingGear : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AutoLock

Toggles the autolock of the landing gear.

##### Declaration

```
bool AutoLock { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsBreakable

Gets if the landing gear lock can be broken with force.

##### Declaration

```
bool IsBreakable { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsLocked

Gets whether the landing gear is currently locked.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsParkingEnabled

##### Declaration

```
bool IsParkingEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LockMode

Is this block triggered by the parking signal?

##### Declaration

```
LandingGearMode LockMode { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [LandingGearMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.LandingGearMode.html) |     |

### Methods

#### Lock()

Locks the landing gear.

##### Declaration

#### ResetAutoLock()

Resets autolock timer

##### Declaration

#### ToggleLock()

Toggles the landing gear lock.

##### Declaration

#### Unlock()

Unlocks the landing gear.

##### Declaration

### Extension Methods