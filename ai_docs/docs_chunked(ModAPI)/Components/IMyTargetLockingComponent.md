---
title: "Interface IMyTargetLockingComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.IMyTargetLockingComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "IMyTargetLockingComponent"
---

# Interface IMyTargetLockingComponent | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyTargetLockingComponent
```

### Properties

#### IsTargetLocked

##### Declaration

```
bool IsTargetLocked { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Target

##### Declaration

```
MyCubeGrid Target { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) |     |

#### TargetData

##### Declaration

```
MyCharacter.MyTargetData TargetData { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter.MyTargetData |     |

#### TargetEntity

##### Declaration

```
MyEntity TargetEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |