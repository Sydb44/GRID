---
title: "Interface IMyOffensiveCombatIntercept"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyOffensiveCombatIntercept.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyOffensiveCombatIntercept"
---

# Interface IMyOffensiveCombatIntercept | Space Engineers ModAPI

Describes entity component for AttackPattern of offensive combat block

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyOffensiveCombatIntercept : IMyAttackPatternComponent
```

### Properties

#### GuidanceType

Gets intercept logic type

##### Declaration

```
GuidanceType GuidanceType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [GuidanceType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.GuidanceType.html) |     |

#### ShouldOverrideCollisionAvoidance

Gets if should override collision avoidance

##### Declaration

```
bool ShouldOverrideCollisionAvoidance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |