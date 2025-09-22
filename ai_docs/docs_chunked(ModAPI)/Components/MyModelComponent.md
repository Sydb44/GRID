---
title: "Class MyModelComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyModelComponent.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyModelComponent"
---

# Class MyModelComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyModelComponent

##### Inherited Members

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyModelComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_EntityComponents_MyModelComponent__ctor)MyModelComponent()

##### Declaration

```
public MyModelComponent()
```

### [](#fields)Fields

#### [](#Sandbox_Game_EntityComponents_MyModelComponent_ModelChanged)ModelChanged

##### Declaration

```
public static MyStringHash ModelChanged
```

##### Field Value

### [](#properties)Properties

#### [](#Sandbox_Game_EntityComponents_MyModelComponent_ComponentTypeDebugString)ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### [](#Sandbox_Game_EntityComponents_MyModelComponent_Definition)Definition

##### Declaration

```
public MyModelComponentDefinition Definition { get; }
```

##### Property Value

#### [](#Sandbox_Game_EntityComponents_MyModelComponent_Model)Model

##### Declaration

```
public MyModel Model { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Models.MyModel |     |

#### [](#Sandbox_Game_EntityComponents_MyModelComponent_ModelCollision)ModelCollision

##### Declaration

```
public MyModel ModelCollision { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Models.MyModel |     |

### [](#methods)Methods

#### [](#Sandbox_Game_EntityComponents_MyModelComponent_Init_VRage_Game_MyComponentDefinitionBase_)Init(MyComponentDefinitionBase)

##### Declaration

```
public override void Init(MyComponentDefinitionBase definition)
```

##### Parameters

##### Overrides

#### [](#Sandbox_Game_EntityComponents_MyModelComponent_InitEntity)InitEntity()

This calls Refresh Models on Entity, this should be later handled by Render Component and Physics Component after receiving the "ModelChanged" entity event

##### Declaration

#### [](#Sandbox_Game_EntityComponents_MyModelComponent_OnAddedToContainer)OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

### [](#extensionmethods)Extension Methods