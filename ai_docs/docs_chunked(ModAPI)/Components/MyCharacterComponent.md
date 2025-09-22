---
title: "Class MyCharacterComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.MyCharacterComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities.Character.Components"
class: "MyCharacterComponent"
---

# Class MyCharacterComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities.Character.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.Character.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyCharacterComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyCharacterComponent
```

### Constructors

#### MyCharacterComponent()

##### Declaration

```
protected MyCharacterComponent()
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

#### NeedsUpdateAfterSimulation

This set's flag for update. Set it after add to container!

##### Declaration

```
public bool NeedsUpdateAfterSimulation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateAfterSimulation10

This set's flag for update. Set it after add to container!

##### Declaration

```
public bool NeedsUpdateAfterSimulation10 { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateAfterSimulationParallel

This set's flag for update. Set it after add to container!

##### Declaration

```
public bool NeedsUpdateAfterSimulationParallel { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateBeforeSimulation

This set's flag for update. Set it after add to container!

##### Declaration

```
public bool NeedsUpdateBeforeSimulation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateBeforeSimulation100

This set's flag for update. Set it after add to container!

##### Declaration

```
public bool NeedsUpdateBeforeSimulation100 { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateBeforeSimulationParallel

This set's flag for update. Set it after add to container!

##### Declaration

```
public bool NeedsUpdateBeforeSimulationParallel { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateSimulation

This set's flag for update. Set it after add to container!

##### Declaration

```
public bool NeedsUpdateSimulation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### OnCharacterDead()

##### Declaration

```
public virtual void OnCharacterDead()
```

#### Simulate()

##### Declaration

```
public virtual void Simulate()
```

#### UpdateAfterSimulation()

##### Declaration

```
public virtual void UpdateAfterSimulation()
```

#### UpdateAfterSimulation10()

##### Declaration

```
public virtual void UpdateAfterSimulation10()
```

#### UpdateAfterSimulationParallel()

##### Declaration

```
public virtual void UpdateAfterSimulationParallel()
```

#### UpdateBeforeSimulation()

##### Declaration

```
public virtual void UpdateBeforeSimulation()
```

#### UpdateBeforeSimulation100()

##### Declaration

```
public virtual void UpdateBeforeSimulation100()
```

#### UpdateBeforeSimulationParallel()

##### Declaration

```
public virtual void UpdateBeforeSimulationParallel()
```

### Implements

### Extension Methods