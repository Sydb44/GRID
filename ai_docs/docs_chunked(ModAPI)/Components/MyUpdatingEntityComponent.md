---
title: "Class MyUpdatingEntityComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyUpdatingEntityComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyUpdatingEntityComponent"
---

# Class MyUpdatingEntityComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyUpdatingEntityComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyUpdatingEntityComponent : MyEventProxyEntityComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent
```

### Constructors

#### MyUpdatingEntityComponent()

##### Declaration

```
protected MyUpdatingEntityComponent()
```

### Properties

#### NeedsUpdate

##### Declaration

```
public MyEntityUpdateEnum NeedsUpdate { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntityUpdateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyEntityUpdateEnum.html) |     |

#### NeedsUpdateAfterSimulation

##### Declaration

```
public bool NeedsUpdateAfterSimulation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateAfterSimulation10

##### Declaration

```
public bool NeedsUpdateAfterSimulation10 { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateAfterSimulation100

##### Declaration

```
public bool NeedsUpdateAfterSimulation100 { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateBeforeSimulation

##### Declaration

```
public bool NeedsUpdateBeforeSimulation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateBeforeSimulation100

##### Declaration

```
public bool NeedsUpdateBeforeSimulation100 { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsUpdateChanged

##### Declaration

```
public Action<IMyUpdatingEntityComponent, MyEntityUpdateEnum> NeedsUpdateChanged { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<VRage.Game.Entity.EntityComponents.Interfaces.IMyUpdatingEntityComponent, [MyEntityUpdateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyEntityUpdateEnum.html)\> |     |

#### NeedsUpdateSimulation

##### Declaration

```
public bool NeedsUpdateSimulation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ParentEntity

##### Declaration

```
public IMyEntity ParentEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### UpdateParallel

##### Declaration

```
public bool UpdateParallel { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UpdateParallelChanged

##### Declaration

```
public Action<IMyUpdatingEntityComponent, bool> UpdateParallelChanged { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<VRage.Game.Entity.EntityComponents.Interfaces.IMyUpdatingEntityComponent, System.Boolean\> |     |

#### UpdatingType

##### Declaration

```
public MyUpdateOrder UpdatingType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyUpdateOrder](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyUpdateOrder.html) |     |

### Methods

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

#### UpdateAfterSimulation100()

##### Declaration

```
public virtual void UpdateAfterSimulation100()
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

#### UpdateOnceBeforeFrame()

##### Declaration

```
public virtual void UpdateOnceBeforeFrame()
```

#### UpdateSimulate()

##### Declaration

```
public virtual void UpdateSimulate()
```

### Extension Methods