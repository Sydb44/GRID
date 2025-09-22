---
title: "Class UpdateType"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "UpdateType"
---

# Class UpdateType | Space Engineers ModAPI

Enum describes what source triggered the script to run.

##### Inheritance

System.Object

UpdateType

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class UpdateType : Enum
```

### Fields

#### IGC

Script run by intergrid communication system.

##### Declaration

```
public const UpdateType IGC
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### Mod

Script run by a mod.

##### Declaration

```
public const UpdateType Mod
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### None

None

##### Declaration

```
public const UpdateType None
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### Once

Script is updating once before the tick.

##### Declaration

```
public const UpdateType Once
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### Script

Script run by another programmable block.

##### Declaration

```
public const UpdateType Script
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### Terminal

Script run by user in the terminal.

##### Declaration

```
public const UpdateType Terminal
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### Trigger

Script run by a block such as timer, sensor.

##### Declaration

```
public const UpdateType Trigger
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### Update1

Script is updating every tick.

##### Declaration

```
public const UpdateType Update1
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### Update10

Script is updating every 10th tick.

##### Declaration

```
public const UpdateType Update10
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### Update100

Script is updating every 100th tick.

##### Declaration

```
public const UpdateType Update100
```

##### Field Value

| Type | Description |
| --- | --- |
| [UpdateType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateType.html) |     |

#### value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |