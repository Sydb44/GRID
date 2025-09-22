---
title: "Class GridLinkTypeEnum"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "GridLinkTypeEnum"
---

# Class GridLinkTypeEnum | Space Engineers ModAPI

Defines different link types for grid groups.

##### Inheritance

System.Object

GridLinkTypeEnum

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class GridLinkTypeEnum : Enum
```

### Fields

#### Electrical

Connections by rotor, piston, suspension and connectors if they transfer energy.

##### Declaration

```
public const GridLinkTypeEnum Electrical
```

##### Field Value

| Type | Description |
| --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) |     |

#### Logical

Terminal connections. i.e. rotors, pistons, wheels. Includes Mechanical connections.

##### Declaration

```
public const GridLinkTypeEnum Logical
```

##### Field Value

| Type | Description |
| --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) |     |

#### Mechanical

Connections by rotor, piston, suspension.

##### Declaration

```
public const GridLinkTypeEnum Mechanical
```

##### Field Value

| Type | Description |
| --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) |     |

#### NoContactDamage

Connections which lock physics, but do not connect terminals. Landing gear only.

##### Declaration

```
public const GridLinkTypeEnum NoContactDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) |     |

#### Physical

Connections which lock physics. i.e. connectors. Includes Logical and Mechanical connections.

##### Declaration

```
public const GridLinkTypeEnum Physical
```

##### Field Value

| Type | Description |
| --- | --- |
| [GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html) |     |

#### value\_\_

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |