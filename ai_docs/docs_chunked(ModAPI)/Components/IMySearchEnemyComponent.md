---
title: "Interface IMySearchEnemyComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMySearchEnemyComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMySearchEnemyComponent"
---

# Interface IMySearchEnemyComponent | Space Engineers ModAPI

Describes component that can find enemy grids and characters in range

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMySearchEnemyComponent
```

### Properties

#### FoundEnemyId

Gets found enemy (block or character)

##### Declaration

```
Nullable<long> FoundEnemyId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### SubsystemsToDestroy

Gets or set which grids with what subsystems should be targeted

##### Declaration

```
MyStringHash SubsystemsToDestroy { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### TargetingLockOptions

Gets or sets targeting lock option

##### Declaration

```
MyGridTargetingRelationFiltering TargetingLockOptions { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyGridTargetingRelationFiltering](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Ingame.MyGridTargetingRelationFiltering.html) |     |