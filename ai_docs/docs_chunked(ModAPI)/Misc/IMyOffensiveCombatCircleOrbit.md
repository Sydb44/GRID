---
title: "Interface IMyOffensiveCombatCircleOrbit"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyOffensiveCombatCircleOrbit"
---

# Interface IMyOffensiveCombatCircleOrbit | Space Engineers ModAPI

Describes entity component for AttackPattern of offensive combat block

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyOffensiveCombatCircleOrbit : IMyAttackPatternComponent
```

### Properties

#### CircleDistance

Gets or sets circle/orbit distance

##### Declaration

```
float CircleDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single | Circle/Orbit distance in meters |

#### CircleInPGravity

Gets if grid should circle instead of orbiting in gravity

##### Declaration

```
bool CircleInPGravity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Facing

Gets which side grid should face target

##### Declaration

```
Base6Directions.DirectionFlags Facing { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Base6Directions.DirectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.DirectionFlags.html) |     |

#### IsOrbiting

Gets if ship currently circling or orbiting

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |