---
title: "Interface IMyPlayerCollection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayerCollection.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyPlayerCollection"
---

# Interface IMyPlayerCollection | Space Engineers ModAPI

ModAPI interface giving control on players

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyPlayerCollection
```

### Properties

#### Count

Gets amount of players online

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Methods

#### ExtendControl(IMyControllableEntity, IMyEntity)

Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity

##### Declaration

```
void ExtendControl(IMyControllableEntity entityWithControl, IMyEntity entityGettingControl)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html) | entityWithControl | Entity that already control. Example: cockpit |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entityGettingControl | Entity that would get control. Example: grid |

#### GetAllIdentites(List<IMyIdentity>, Func<IMyIdentity, Boolean>)

Get all registered identities: players that at least once visited server, bots, and online players

##### Declaration

```
void GetAllIdentites(List<IMyIdentity> identities, Func<IMyIdentity, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyIdentity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyIdentity.html)\> | identities | List that would receive results |
| System.Func<[IMyIdentity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyIdentity.html), System.Boolean\> | collect | When null, or returns true, list would add identity |

#### GetPlayerControllingEntity(IMyEntity)

Gets player that controls entity

##### Declaration

```
IMyPlayer GetPlayerControllingEntity(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity to test |

##### Returns

| Type | Description |
| --- | --- |
| [IMyPlayer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayer.html) | Player that controls `entity` |

#### GetPlayers(List<IMyPlayer>, Func<IMyPlayer, Boolean>)

Gets list of currently connected players

##### Declaration

```
void GetPlayers(List<IMyPlayer> players, Func<IMyPlayer, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyPlayer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayer.html)\> | players | List, that would receive connected players |
| System.Func<[IMyPlayer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayer.html), System.Boolean\> | collect | When null, or returns true, `players` would receive player |

#### HasExtendedControl(IMyControllableEntity, IMyEntity)

Gets whether player controls both entities

##### Declaration

```
bool HasExtendedControl(IMyControllableEntity firstEntity, IMyEntity secondEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html) | firstEntity | First entity |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | secondEntity | Second entity |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True, if both entities under control of one player |

#### ReduceControl(IMyControllableEntity, IMyEntity)

Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity

##### Declaration

```
void ReduceControl(IMyControllableEntity entityWhichKeepsControl, IMyEntity entityWhichLoosesControl)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html) | entityWhichKeepsControl | Entity that would keep control. Example: cockpit |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entityWhichLoosesControl | Entity that would loose control. Example: grid |

#### RemoveControlledEntity(IMyEntity)

Removes control from entity

##### Declaration

```
void RemoveControlledEntity(IMyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that should loose control |
