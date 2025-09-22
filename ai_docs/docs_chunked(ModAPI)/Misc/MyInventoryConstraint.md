---
title: "Class MyInventoryConstraint"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventoryConstraint.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyInventoryConstraint"
---

# Class MyInventoryConstraint | Space Engineers ModAPI

##### Inheritance

System.Object

MyInventoryConstraint

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyInventoryConstraint : Object
```

### Constructors

#### MyInventoryConstraint(String, String, Boolean)

##### Declaration

```
public MyInventoryConstraint(string description, string icon = null, bool whitelist = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | description |     |
| System.String | icon |     |
| System.Boolean | whitelist |     |

#### MyInventoryConstraint(MyStringId, String, Boolean)

##### Declaration

```
public MyInventoryConstraint(MyStringId description, string icon = null, bool whitelist = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) | description |     |
| System.String | icon |     |
| System.Boolean | whitelist |     |

### Fields

#### Description

##### Declaration

```
public readonly string Description
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Icon

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### m\_useDefaultIcon

##### Declaration

```
public bool m_useDefaultIcon
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### ConstrainedIds

##### Declaration

```
public HashSetReader<MyDefinitionId> ConstrainedIds { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [HashSetReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> |     |

#### ConstrainedTypes

##### Declaration

```
public HashSetReader<MyObjectBuilderType> ConstrainedTypes { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [HashSetReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html)<[MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html)\> |     |

#### IsWhitelist

##### Declaration

```
public bool IsWhitelist { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### Add(MyDefinitionId)

##### Declaration

```
public MyInventoryConstraint Add(MyDefinitionId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyInventoryConstraint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventoryConstraint.html) |     |

#### AddObjectBuilderType(MyObjectBuilderType)

##### Declaration

```
public MyInventoryConstraint AddObjectBuilderType(MyObjectBuilderType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyInventoryConstraint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventoryConstraint.html) |     |

#### Check(MyDefinitionId)

##### Declaration

```
public bool Check(MyDefinitionId checkedId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | checkedId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Clear()

##### Declaration

#### Remove(MyDefinitionId)

##### Declaration

```
public MyInventoryConstraint Remove(MyDefinitionId id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyInventoryConstraint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventoryConstraint.html) |     |

#### RemoveObjectBuilderType(MyObjectBuilderType)

##### Declaration

```
public MyInventoryConstraint RemoveObjectBuilderType(MyObjectBuilderType type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyInventoryConstraint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventoryConstraint.html) |     |

#### UpdateIcon()

##### Declaration