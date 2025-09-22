---
title: "Interface IMyOffensiveCombatStayAtRange"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyOffensiveCombatStayAtRange.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyOffensiveCombatStayAtRange"
---

# Interface IMyOffensiveCombatStayAtRange | Space Engineers ModAPI

Describes entity component for AttackPattern of offensive combat block

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyOffensiveCombatStayAtRange : IMyAttackPatternComponent
```

### Properties

#### EvasiveManeuverDistance

Gets evasive maneuver distance in meters

##### Declaration

```
float EvasiveManeuverDistance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EvasiveManeuvers

Gets or sets if evasive maneuvers are enabled

##### Declaration

```
bool EvasiveManeuvers { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### FacingPriority

Gets or sets facing priority

##### Declaration

```
Base6Directions.DirectionFlags FacingPriority { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.DirectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.DirectionFlags.html) |     |

#### MaximalDistance

Get or sets maximal stay at range distance in meters

##### Declaration

```
float MaximalDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinimalDistance

Get or sets minimal stay at range distance in meters

##### Declaration

```
float MinimalDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |