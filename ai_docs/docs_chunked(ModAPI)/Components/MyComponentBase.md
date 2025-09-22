---
title: "Class MyComponentBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyComponentBase"
---

# Class MyComponentBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyComponentBase

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public abstract class MyComponentBase : Object, IMyComponentBase
```

### Constructors

#### MyComponentBase()

##### Declaration

```
protected MyComponentBase()
```

### Properties

#### ContainerBase

This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.

##### Declaration

```
public IMyComponentContainer ContainerBase { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Components.Interfaces.IMyComponentContainer |     |

#### RemoveExistingComponentOnNewInsert

##### Declaration

```
public bool RemoveExistingComponentOnNewInsert { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public virtual void Deserialize(MyObjectBuilder_ComponentBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | builder |     |

#### GetAs<T>()

##### Declaration

```
public virtual T GetAs<T>()
    where T : class
```

##### Returns

| Type | Description |
| --- | --- |
| T   |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### Init(MyComponentDefinitionBase)

##### Declaration

```
public virtual void Init(MyComponentDefinitionBase definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | definition |     |

#### IsSerialized()

Tells the component container serializer whether this component should be saved

##### Declaration

```
public virtual bool IsSerialized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OnAddedToContainer()

Gets called after the container of this component changes

##### Declaration

```
public virtual void OnAddedToContainer()
```

#### OnAddedToScene()

CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!

##### Declaration

```
public virtual void OnAddedToScene()
```

#### OnBeforeRemovedFromContainer()

Gets called before the removal of this component from a container

##### Declaration

```
public virtual void OnBeforeRemovedFromContainer()
```

#### OnRemovedFromScene()

CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!

##### Declaration

```
public virtual void OnRemovedFromScene()
```

#### Serialize(Boolean)

##### Declaration

```
public virtual MyObjectBuilder_ComponentBase Serialize(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

#### SetContainer(IMyComponentContainer)

Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.

##### Declaration

```
public virtual void SetContainer(IMyComponentContainer container)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Components.Interfaces.IMyComponentContainer | container | The new container of the component |