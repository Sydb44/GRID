---
title: "Class MyUpgradableBlockComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyUpgradableBlockComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities"
class: "MyUpgradableBlockComponent"
---

# Class MyUpgradableBlockComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyUpgradableBlockComponent

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyUpgradableBlockComponent : Object
```

### Constructors

#### MyUpgradableBlockComponent(MyCubeBlock)

##### Declaration

```
public MyUpgradableBlockComponent(MyCubeBlock parent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | parent |     |

### Properties

#### ConnectionPositions

##### Declaration

```
public HashSet<ConveyorLinePosition> ConnectionPositions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<Sandbox.Game.GameSystems.Conveyors.ConveyorLinePosition\> |     |

### Methods

#### Refresh(MyCubeBlock)

##### Declaration

```
public void Refresh(MyCubeBlock parent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | parent |     |