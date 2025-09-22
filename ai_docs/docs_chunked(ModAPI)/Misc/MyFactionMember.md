---
title: "Class MyFactionMember"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionMember.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyFactionMember"
---

# Class MyFactionMember | Space Engineers ModAPI

##### Inheritance

System.Object

MyFactionMember

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public sealed class MyFactionMember : ValueType
```

### Constructors

#### MyFactionMember(Int64, Boolean, Boolean)

##### Declaration

```
public MyFactionMember(long id, bool isLeader, bool isFounder = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | id  |     |
| System.Boolean | isLeader |     |
| System.Boolean | isFounder |     |

### Fields

#### Comparer

##### Declaration

```
public static readonly MyFactionMember.FactionComparerType Comparer
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyFactionMember.FactionComparerType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionMember.FactionComparerType.html) |     |

#### IsFounder

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsLeader

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PlayerId

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Operators

#### Implicit(MyFactionMember to MyObjectBuilder\_FactionMember)

##### Declaration

```
public static implicit operator MyObjectBuilder_FactionMember(MyFactionMember v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyFactionMember](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionMember.html) | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_FactionMember](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FactionMember.html) |     |

#### Implicit(MyObjectBuilder\_FactionMember to MyFactionMember)

##### Declaration

```
public static implicit operator MyFactionMember(MyObjectBuilder_FactionMember v)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_FactionMember](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FactionMember.html) | v   |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyFactionMember](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionMember.html) |     |