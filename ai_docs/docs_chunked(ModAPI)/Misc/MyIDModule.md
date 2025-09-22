---
title: "Class MyIDModule"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyIDModule.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyIDModule"
---

# Class MyIDModule | Space Engineers ModAPI

This should be replaced by MyEntityOwnershipComponent

##### Inheritance

System.Object

MyIDModule

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyIDModule : Object
```

### Constructors

#### MyIDModule()

##### Declaration

#### MyIDModule(Int64, MyOwnershipShareModeEnum)

##### Declaration

```
public MyIDModule(long owner, MyOwnershipShareModeEnum shareMode)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | owner |     |
| [MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html) | shareMode |     |

### Properties

#### Owner

##### Declaration

```
public long Owner { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### ShareMode

##### Declaration

```
public MyOwnershipShareModeEnum ShareMode { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html) |     |

### Methods

#### GetRelationPlayerBlock(Int64, Int64, MyOwnershipShareModeEnum, MyRelationsBetweenPlayerAndBlock, MyRelationsBetweenFactions, MyRelationsBetweenPlayerAndBlock, MyRelationsBetweenPlayerAndBlock)

##### Declaration

```
public static MyRelationsBetweenPlayerAndBlock GetRelationPlayerBlock(long owner, long user, MyOwnershipShareModeEnum share, MyRelationsBetweenPlayerAndBlock noFactionResult, MyRelationsBetweenFactions defaultFactionRelations, MyRelationsBetweenPlayerAndBlock defaultShareWithAllRelations, MyRelationsBetweenPlayerAndBlock defaultNoUser)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | owner |     |
| System.Int64 | user |     |
| [MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html) | share |     |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | noFactionResult |     |
| [MyRelationsBetweenFactions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenFactions.html) | defaultFactionRelations |     |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | defaultShareWithAllRelations |     |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | defaultNoUser |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) |     |

#### GetRelationPlayerPlayer(Int64, Int64, MyRelationsBetweenFactions, MyRelationsBetweenPlayers, Boolean, Boolean)

##### Declaration

```
public static MyRelationsBetweenPlayers GetRelationPlayerPlayer(long owner, long user, MyRelationsBetweenFactions defaultFactionRelations, MyRelationsBetweenPlayers defaultNoFactionRelation, bool treatFriendsAsAllies = true, bool treatNobodyAsNeutral = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | owner |     |
| System.Int64 | user |     |
| [MyRelationsBetweenFactions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenFactions.html) | defaultFactionRelations |     |
| [MyRelationsBetweenPlayers](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyRelationsBetweenPlayers.html) | defaultNoFactionRelation |     |
| System.Boolean | treatFriendsAsAllies |     |
| System.Boolean | treatNobodyAsNeutral |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyRelationsBetweenPlayers](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyRelationsBetweenPlayers.html) |     |

#### GetUserRelationToOwner(Int64, MyRelationsBetweenPlayerAndBlock)

##### Declaration

```
public MyRelationsBetweenPlayerAndBlock GetUserRelationToOwner(long identityId, MyRelationsBetweenPlayerAndBlock defaultNoUser)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId |     |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) | defaultNoUser |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyRelationsBetweenPlayerAndBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenPlayerAndBlock.html) |     |