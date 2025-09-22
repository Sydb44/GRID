---
title: "Interface IMyAirVent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyAirVent.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyAirVent"
---

# Interface IMyAirVent | Space Engineers ModAPI

Describes Air Vent block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMyAirVent : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### CanPressurize

Gets whether this vent can pressurize. If so room is airtight.

##### Declaration

```
bool CanPressurize { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Depressurize

Gets whether this vent is in depressurize state

##### Declaration

```
bool Depressurize { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsDepressurizing

Gets whether this vet is depressurizing

##### Declaration

```
bool IsDepressurizing { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PressurizationEnabled

Gets whether this vent has pressurization enabled.

##### Declaration

```
bool PressurizationEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Status

Gets the current air vent status

##### Declaration

```
VentStatus Status { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [VentStatus](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.VentStatus.html) |     |

### Methods

#### GetOxygenLevel()

Gets Oxygen level in room

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Oxygen fill level as float (0.5 = 50%) |

#### IsPressurized()

Gets whether this vent can be pressurized

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if containing room is airtight |

### Extension Methods