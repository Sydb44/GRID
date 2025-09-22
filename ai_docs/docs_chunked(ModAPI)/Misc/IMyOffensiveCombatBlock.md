---
title: "Interface IMyOffensiveCombatBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyOffensiveCombatBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyOffensiveCombatBlock"
---

# Interface IMyOffensiveCombatBlock | Space Engineers ModAPI

Describes offensive combat block interface

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyOffensiveCombatBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### LastScan

Gets how many milliseconds was from last scan, or -1 if block hasn't scanned yet

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### SearchEnemyComponent

Gets SearchEnemyComponent

##### Declaration

```
IMySearchEnemyComponent SearchEnemyComponent { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMySearchEnemyComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMySearchEnemyComponent.html) |     |

#### SelectedAttackPattern

Gets or sets current attack pattern

##### Declaration

```
long SelectedAttackPattern { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### TargetPriority

Gets or sets current target priority

##### Declaration

```
OffensiveCombatTargetPriority TargetPriority { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [OffensiveCombatTargetPriority](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.OffensiveCombatTargetPriority.html) |     |

#### UpdateTargetInterval

Gets or sets scan interval in seconds

##### Declaration

```
int UpdateTargetInterval { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### GetAttackPatternIds<T>(T)

Gets all attack pattern ids

##### Declaration

```
T GetAttackPatternIds<T>(T idsList)
    where T : ICollection<long>
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| T   | idsList | Collection where attack pattern ids would be added |

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### TryGetSelectedAttackPattern(out IMyAttackPatternComponent)

Gets current attack pattern

##### Declaration

```
bool TryGetSelectedAttackPattern(out IMyAttackPatternComponent attackPatternComponent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyAttackPatternComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAttackPatternComponent.html) | attackPatternComponent | Attack pattern component |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if block has active attack pattern |

#### TryGetSelectedAttackPattern(Int64, out IMyAttackPatternComponent)

Gets current attack pattern

##### Declaration

```
bool TryGetSelectedAttackPattern(long patternId, out IMyAttackPatternComponent attackPatternComponent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | patternId | Id of pattern |
| [IMyAttackPatternComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAttackPatternComponent.html) | attackPatternComponent | Attack pattern component |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if block has active attack pattern |

### Extension Methods