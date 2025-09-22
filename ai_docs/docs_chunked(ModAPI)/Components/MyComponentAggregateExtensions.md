---
title: "Class MyComponentAggregateExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentAggregateExtensions.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyComponentAggregateExtensions"
---

# Class MyComponentAggregateExtensions | Space Engineers ModAPI

##### Inheritance

System.Object

MyComponentAggregateExtensions

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public static class MyComponentAggregateExtensions : Object
```

### Methods

#### AddComponent(IMyComponentAggregate, MyComponentBase)

##### Declaration

```
public static void AddComponent(this IMyComponentAggregate aggregate, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyComponentAggregate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IMyComponentAggregate.html) | aggregate |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

#### AttachComponent(IMyComponentAggregate, MyComponentBase)

Adds to list but doesn't change ownership

##### Declaration

```
public static void AttachComponent(this IMyComponentAggregate aggregate, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyComponentAggregate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IMyComponentAggregate.html) | aggregate |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

#### DetachComponent(IMyComponentAggregate, MyComponentBase)

Removes from list, but doesn't change ownership

##### Declaration

```
public static void DetachComponent(this IMyComponentAggregate aggregate, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyComponentAggregate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IMyComponentAggregate.html) | aggregate |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

#### GetComponentsFlattened(IMyComponentAggregate, List<MyComponentBase>)

##### Declaration

```
public static void GetComponentsFlattened(this IMyComponentAggregate aggregate, List<MyComponentBase> output)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyComponentAggregate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IMyComponentAggregate.html) | aggregate |     |
| System.Collections.Generic.List<[MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html)\> | output |     |

#### RemoveComponent(IMyComponentAggregate, MyComponentBase)

##### Declaration

```
public static bool RemoveComponent(this IMyComponentAggregate aggregate, MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyComponentAggregate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IMyComponentAggregate.html) | aggregate |     |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |