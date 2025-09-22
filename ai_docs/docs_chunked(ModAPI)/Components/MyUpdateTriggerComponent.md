---
title: "Class MyUpdateTriggerComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyUpdateTriggerComponent.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyUpdateTriggerComponent"
---

# Class MyUpdateTriggerComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyUpdateTriggerComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentBuilder]
public class MyUpdateTriggerComponent : MyTriggerComponent, IMyEntityComponentBase, IMyComponentBase
```

### Constructors

#### MyUpdateTriggerComponent()

##### Declaration

```
public MyUpdateTriggerComponent()
```

#### MyUpdateTriggerComponent(Int32)

##### Declaration

```
public MyUpdateTriggerComponent(int triggerSize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | triggerSize |     |

### Properties

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

#### Size

##### Declaration

```
public int Size { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

##### Overrides

#### Dispose()

##### Declaration

```
public override void Dispose()
```

##### Overrides

#### OnAddedToScene()

##### Declaration

```
public override void OnAddedToScene()
```

##### Overrides

#### OnBeforeRemovedFromContainer()

##### Declaration

```
public override void OnBeforeRemovedFromContainer()
```

##### Overrides

#### QueryEvaluator(MyEntity)

##### Declaration

```
protected override bool QueryEvaluator(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### Serialize(Boolean)

##### Declaration

```
public override MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

##### Overrides

#### UpdateInternal()

##### Declaration

```
protected override void UpdateInternal()
```

##### Overrides

### Extension Methods