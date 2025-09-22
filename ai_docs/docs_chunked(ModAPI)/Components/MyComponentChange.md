---
title: "Class MyComponentChange"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyComponentChange.html"
category: "Components"
namespace: "VRage.Game.Entity"
class: "MyComponentChange"
---

# Class MyComponentChange | Space Engineers ModAPI

##### Inheritance

System.Object

MyComponentChange

###### **Namespace**: [VRage.Game.Entity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyComponentChange : ValueType
```

### Fields

#### Amount

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Properties

#### ToAdd

##### Declaration

```
public MyDefinitionId ToAdd { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### ToRemove

##### Declaration

```
public MyDefinitionId ToRemove { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

### Methods

#### CreateAddition(MyDefinitionId, Int32)

##### Declaration

```
public static MyComponentChange CreateAddition(MyDefinitionId toAdd, int amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | toAdd |     |
| System.Int32 | amount |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyComponentChange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyComponentChange.html) |     |

#### CreateChange(MyDefinitionId, MyDefinitionId, Int32)

##### Declaration

```
public static MyComponentChange CreateChange(MyDefinitionId toRemove, MyDefinitionId toAdd, int amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | toRemove |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | toAdd |     |
| System.Int32 | amount |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyComponentChange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyComponentChange.html) |     |

#### CreateRemoval(MyDefinitionId, Int32)

##### Declaration

```
public static MyComponentChange CreateRemoval(MyDefinitionId toRemove, int amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | toRemove |     |
| System.Int32 | amount |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyComponentChange](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyComponentChange.html) |     |

#### IsAddition()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsChange()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRemoval()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |