---
title: "Class MyGameLogicComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyGameLogicComponent"
---

# Class MyGameLogicComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyGameLogicComponent

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyGameLogicComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyGameLogicComponent
```

### Constructors

#### MyGameLogicComponent()

##### Declaration

```
protected MyGameLogicComponent()
```

### Properties

#### Closed

##### Declaration

```
public bool Closed { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### EntityUpdate

##### Declaration

```
public bool EntityUpdate { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MarkedForClose

##### Declaration

```
public bool MarkedForClose { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ModContext

Returns the mod context this gamelogic belongs to. This can be passed to methods to read content from the mod's directory.

##### Declaration

```
public IMyModContext ModContext { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyModContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModContext.html) |     |

#### NeedsUpdate

##### Declaration

```
public MyEntityUpdateEnum NeedsUpdate { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntityUpdateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyEntityUpdateEnum.html) |     |

### Methods

#### Close()

##### Declaration

```
public virtual void Close()
```

#### GetObjectBuilder(Boolean)

##### Declaration

```
public virtual MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) |     |

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public virtual void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

#### MarkForClose()

##### Declaration

```
public virtual void MarkForClose()
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

#### UpdateAfterSimulation100()

##### Declaration

```
public virtual void UpdateAfterSimulation100()
```

#### UpdateBeforeSimulation()

##### Declaration

```
public virtual void UpdateBeforeSimulation()
```

#### UpdateBeforeSimulation10()

##### Declaration

```
public virtual void UpdateBeforeSimulation10()
```

#### UpdateBeforeSimulation100()

##### Declaration

```
public virtual void UpdateBeforeSimulation100()
```

#### UpdateOnceBeforeFrame()

##### Declaration

```
public virtual void UpdateOnceBeforeFrame()
```

#### UpdatingStopped()

##### Declaration

```
public virtual void UpdatingStopped()
```

### Extension Methods