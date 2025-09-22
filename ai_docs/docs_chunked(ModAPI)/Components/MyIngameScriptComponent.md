---
title: "Class MyIngameScriptComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyIngameScriptComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyIngameScriptComponent"
---

# Class MyIngameScriptComponent | Space Engineers ModAPI

A component to control the execution of a programmable block script based on its configured update frequency.

##### Inheritance

System.Object

MyIngameScriptComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityComponentDescriptor]
public class MyIngameScriptComponent : MyGameLogicComponent, IMyEntityComponentBase, IMyComponentBase, IMyGameLogicComponent
```

### Constructors

#### MyIngameScriptComponent()

##### Declaration

```
public MyIngameScriptComponent()
```

### Properties

#### UpdateFrequency

The update frequency with which to run the script.

##### Declaration

```
public UpdateFrequency UpdateFrequency { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [UpdateFrequency](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.UpdateFrequency.html) |     |

### Methods

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html) | objectBuilder |     |

##### Overrides

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateBeforeSimulation()

##### Declaration

```
public override void UpdateBeforeSimulation()
```

##### Overrides

#### UpdateBeforeSimulation10()

##### Declaration

```
public override void UpdateBeforeSimulation10()
```

##### Overrides

#### UpdateBeforeSimulation100()

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

### Extension Methods