---
title: "Class MyEntityComponentContainer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyEntityComponentContainer.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyEntityComponentContainer"
---

# Class MyEntityComponentContainer | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityComponentContainer

##### Inherited Members

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyEntityComponentContainer : MyComponentContainer, IMyEntityComponentContainer, IMyComponentContainer
```

### Constructors

#### MyEntityComponentContainer(IMyEntity)

##### Declaration

```
public MyEntityComponentContainer(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |

### Properties

#### Entity

##### Declaration

```
public IMyEntity Entity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

### Methods

#### Init(MyContainerDefinition)

##### Declaration

```
public override void Init(MyContainerDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html) | definition |     |

##### Overrides

#### OnComponentAdded(Type, MyComponentBase)

##### Declaration

```
protected override void OnComponentAdded(Type t, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | t   |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

##### Overrides

#### OnComponentRemoved(Type, MyComponentBase)

##### Declaration

```
protected override void OnComponentRemoved(Type t, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | t   |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

##### Overrides

### Events

#### ComponentAdded

##### Declaration

```
public event Action<Type, IMyEntityComponentBase> ComponentAdded
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Type, VRage.Game.Components.Interfaces.IMyEntityComponentBase\> |     |

#### ComponentRemoved

##### Declaration

```
public event Action<Type, IMyEntityComponentBase> ComponentRemoved
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Type, VRage.Game.Components.Interfaces.IMyEntityComponentBase\> |     |