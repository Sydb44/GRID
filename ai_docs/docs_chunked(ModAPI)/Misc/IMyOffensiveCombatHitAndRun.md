---
title: "Interface IMyOffensiveCombatHitAndRun"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyOffensiveCombatHitAndRun"
---

# Interface IMyOffensiveCombatHitAndRun | Space Engineers ModAPI

Describes entity component for AttackPattern of offensive combat block

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyOffensiveCombatHitAndRun : IMyAttackPatternComponent
```

### Properties

#### BreakOffDistance

Gets or sets break off distance (in meters)

##### Declaration

```
float BreakOffDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsMovingAwayFromTarget

Gets if grid is moving away from target

##### Declaration

```
bool IsMovingAwayFromTarget { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsMovingToTarget

Gets if grid is moving to target

##### Declaration

```
bool IsMovingToTarget { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RetreatAngle

Gets or sets retreat angle (in degrees)

##### Declaration

```
float RetreatAngle { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RetreatDistance

Gets or sets max distance that grid can run away from target

##### Declaration

```
float RetreatDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RetreatTimeout

Gets or sets max time that grid can run away from target

##### Declaration

```
float RetreatTimeout { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetSelectedWeapons(List<Int64>)

Gets weapons that should be used to damage to attack enemy May return also modded guns EntityId.

##### Declaration

```
void GetSelectedWeapons(List<long> blockEntityIds)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.Int64\> | blockEntityIds | List where all Ids would be added |

#### IsWeaponSelected(Int64)

Gets if weapon is selected

##### Declaration

```
bool IsWeaponSelected(long blockEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | blockEntityId | True if block is selected |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SetSelectedWeapons(List<Int64>)

Sets weapons EntityIds that can would be used to damage to attack enemy Modded gun are allowed, but you need override [BlockValidation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyOffensiveCombatHitAndRun.html#Sandbox_ModAPI_IMyOffensiveCombatHitAndRun_BlockValidation) and [SetShooting](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyOffensiveCombatHitAndRun.html#Sandbox_ModAPI_IMyOffensiveCombatHitAndRun_SetShooting)

##### Declaration

```
void SetSelectedWeapons(List<long> blockEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<System.Int64\> | blockEntityId |     |