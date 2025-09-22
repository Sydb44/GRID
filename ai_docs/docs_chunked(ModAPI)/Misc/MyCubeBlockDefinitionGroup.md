---
title: "Class MyCubeBlockDefinitionGroup"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinitionGroup.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyCubeBlockDefinitionGroup"
---

# Class MyCubeBlockDefinitionGroup | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeBlockDefinitionGroup

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyCubeBlockDefinitionGroup : Object
```

### Properties

#### Any

##### Declaration

```
public MyCubeBlockDefinition Any { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) |     |

#### AnyPublic

##### Declaration

```
public MyCubeBlockDefinition AnyPublic { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) |     |

#### Item\[MyCubeSize\]

##### Declaration

```
public MyCubeBlockDefinition this[MyCubeSize size] { get; set; }
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html) | size |     |

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) |     |

#### Large

##### Declaration

```
public MyCubeBlockDefinition Large { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) |     |

#### SizeCount

##### Declaration

```
public int SizeCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Small

##### Declaration

```
public MyCubeBlockDefinition Small { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) |     |

### Methods

#### Contains(MyCubeBlockDefinition, Boolean)

##### Declaration

```
public bool Contains(MyCubeBlockDefinition defCnt, bool checkStages = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) | defCnt |     |
| System.Boolean | checkStages |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CreateNewContentNotificator(Boolean)

##### Declaration

```
public IMyNewContentNotificator CreateNewContentNotificator(bool addBlockVariants = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | addBlockVariants |     |

##### Returns

| Type | Description |
| --- | --- |
| VRage.Game.News.NewContentNotification.IMyNewContentNotificator |     |