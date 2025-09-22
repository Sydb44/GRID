---
title: "Interface IMyAttackPatternComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyAttackPatternComponent.html"
category: "Components"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyAttackPatternComponent"
---

# Interface IMyAttackPatternComponent | Space Engineers ModAPI

Describes entity component for AttackPattern of offensive combat block

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyAttackPatternComponent
```

### Properties

#### AttackPatternId

Gets attack pattern id

##### Declaration

```
long AttackPatternId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### AttackPatternName

Gets attack pattern name

##### Declaration

```
MyStringId AttackPatternName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### AttackPatternTooltip

Gets attack pattern tooltip

##### Declaration

```
MyStringId AttackPatternTooltip { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### HasEnemy

Gets if attack pattern has enemy in range

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsSelected

Gets if attack pattern is selected

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |