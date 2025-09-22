---
title: "Class MyCharacterRagdollComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyCharacterRagdollComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities.Character.Components"
class: "MyCharacterRagdollComponent"
---

# Class MyCharacterRagdollComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterRagdollComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities.Character.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
public class MyCharacterRagdollComponent : MyUpdatingEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent
```

### Constructors

#### MyCharacterRagdollComponent()

##### Declaration

```
public MyCharacterRagdollComponent()
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

#### Distance

##### Declaration

```
public float Distance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsRagdollActivated

##### Declaration

```
public bool IsRagdollActivated { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRagdollMoving

##### Declaration

```
public bool IsRagdollMoving { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RagdollMapper

##### Declaration

```
public MyRagdollMapper RagdollMapper { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| Sandbox.Engine.Physics.MyRagdollMapper |     |

### Methods

#### InitRagdoll()

Loads Ragdoll data

##### Declaration

```
public bool InitRagdoll()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### UpdateBeforeSimulation100()

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

#### UpdateSimulate()

##### Declaration

```
public override void UpdateSimulate()
```

##### Overrides

### Extension Methods