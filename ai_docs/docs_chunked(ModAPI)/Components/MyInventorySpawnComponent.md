---
title: "Class MyInventorySpawnComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyInventorySpawnComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities.Character.Components"
class: "MyInventorySpawnComponent"
---

# Class MyInventorySpawnComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyInventorySpawnComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities.Character.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
public class MyInventorySpawnComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyCharacterComponent
```

### Constructors

#### MyInventorySpawnComponent()

##### Declaration

```
public MyInventorySpawnComponent()
```

### Properties

#### Character

##### Declaration

```
public MyCharacter Character { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Game.Entities.Character.MyCharacter |     |

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

### Methods

#### IsSerialized()

##### Declaration

```
public override bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### OnCharacterDead()

##### Declaration

```
public void OnCharacterDead()
```

### Implements

### Extension Methods