---
title: "Class MyGuiBlockCategoryDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyGuiBlockCategoryDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyGuiBlockCategoryDefinition"
---

# Class MyGuiBlockCategoryDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyGuiBlockCategoryDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyGuiBlockCategoryDefinition : MyDefinitionBase
```

### Constructors

#### MyGuiBlockCategoryDefinition()

##### Declaration

```
public MyGuiBlockCategoryDefinition()
```

### Fields

#### IsAnimationCategory

##### Declaration

```
public bool IsAnimationCategory
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsBlockCategory

##### Declaration

```
public bool IsBlockCategory
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsShipCategory

##### Declaration

```
public bool IsShipCategory
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsToolCategory

##### Declaration

```
public bool IsToolCategory
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ItemIds

##### Declaration

```
public HashSet<string> ItemIds
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<System.String\> |     |

#### Name

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### SearchBlocks

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowAnimations

##### Declaration

```
public bool ShowAnimations
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShowInCreative

##### Declaration

```
public bool ShowInCreative
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StrictSearch

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ValidItems

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### CreateNewContentNotificator()

##### Declaration

```
public IMyNewContentNotificator CreateNewContentNotificator()
```

##### Returns

| Type | Description |
| --- | --- |
| VRage.Game.News.NewContentNotification.IMyNewContentNotificator |     |

#### HasItem(String)

##### Declaration

```
public bool HasItem(string itemId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | itemId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | ob  |     |

##### Overrides