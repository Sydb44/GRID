---
title: "Interface IMyComponentAggregate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IMyComponentAggregate.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "IMyComponentAggregate"
---

# Interface IMyComponentAggregate | Space Engineers ModAPI

When creating a new aggregate component type, derive from this interface so that you can use extension methods AddComponent and RemoveComponent

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyComponentAggregate
```

### Properties

#### ChildList

##### Declaration

```
MyAggregateComponentList ChildList { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyAggregateComponentList](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyAggregateComponentList.html) |     |

#### ContainerBase

##### Declaration

```
IMyComponentContainer ContainerBase { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.Game.Components.Interfaces.IMyComponentContainer |     |

### Methods

#### AfterComponentAdd(MyComponentBase)

##### Declaration

```
void AfterComponentAdd(MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

#### BeforeComponentRemove(MyComponentBase)

##### Declaration

```
void BeforeComponentRemove(MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

### Extension Methods