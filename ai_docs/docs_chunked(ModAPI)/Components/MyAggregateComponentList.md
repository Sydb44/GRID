---
title: "Class MyAggregateComponentList"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyAggregateComponentList.html"
category: "Components"
namespace: "VRage.Game.Components"
class: "MyAggregateComponentList"
---

# Class MyAggregateComponentList | Space Engineers ModAPI

##### Inheritance

System.Object

MyAggregateComponentList

###### **Namespace**: [VRage.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyAggregateComponentList : Object
```

### Constructors

#### MyAggregateComponentList()

##### Declaration

```
public MyAggregateComponentList()
```

### Properties

#### Reader

##### Declaration

```
public ListReader<MyComponentBase> Reader { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html)\> |     |

### Methods

#### AddComponent(MyComponentBase)

##### Declaration

```
public void AddComponent(MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

#### Contains(MyComponentBase)

##### Declaration

```
public bool Contains(MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetComponentIndex(MyComponentBase)

##### Declaration

```
public int GetComponentIndex(MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RemoveComponent(MyComponentBase)

##### Declaration

```
public bool RemoveComponent(MyComponentBase component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyComponentBase.html) | component |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RemoveComponentAt(Int32)

##### Declaration

```
public void RemoveComponentAt(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index |     |