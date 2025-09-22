---
title: "Interface IMyGasTank"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGasTank.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyGasTank"
---

# Interface IMyGasTank | Space Engineers ModAPI

Describes gas tank block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyGasTank : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AutoRefillBottles

Gets or sets whether storage bottles will be filled automatically when placed within this tank.

##### Declaration

```
bool AutoRefillBottles { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Capacity

Gets the gas capacity of this tank.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### FilledRatio

Gets the current fill level of this tank as a value between 0 (empty) and 1 (full).

##### Declaration

```
double FilledRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### Stockpile

Gets or sets the stockpiling option for this gas tank. When stockpile is on, the tank will only allow itself to be filled, it will not release any gas.

##### Declaration

```
bool Stockpile { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### RefillBottles()

Refills any stored storage bottles.

##### Declaration

### Extension Methods