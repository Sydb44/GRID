---
title: "Interface IMyBatteryBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBatteryBlock.html"
category: "Power"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyBatteryBlock"
---

# Interface IMyBatteryBlock | Space Engineers ModAPI

Describes battery block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyBatteryBlock : IMyPowerProducer, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### ChargeMode

Gets or sets charge mode

##### Declaration

```
ChargeMode ChargeMode { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ChargeMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.ChargeMode.html) |     |

#### CurrentInput

Gets current power input

##### Declaration

```
float CurrentInput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CurrentStoredPower

Gets current stored power

##### Declaration

```
float CurrentStoredPower { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HasCapacityRemaining

Gets whether this battery block has any remaining capacity

##### Declaration

```
bool HasCapacityRemaining { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsCharging

Gets whether this battery block is charging

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxInput

Gets current maximum power input

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxStoredPower

Gets maximum stored power

##### Declaration

```
float MaxStoredPower { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OnlyDischarge

Obsolete

##### Declaration

```
bool OnlyDischarge { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnlyRecharge

Obsolete

##### Declaration

```
bool OnlyRecharge { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SemiautoEnabled

Obsolete

##### Declaration

```
bool SemiautoEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods