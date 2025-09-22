---
title: "Interface IMyPlayer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPlayer.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyPlayer"
---

# Interface IMyPlayer | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyPlayer
```

### Properties

#### BuildColorSlots

Gets or sets all the player's build color slots

##### Declaration

```
List<Vector3> BuildColorSlots { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### Character

Gets the Character entity for the player.

##### Declaration

```
IMyCharacter Character { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) |     |

#### Client

Gets network client for this player. Used for sending network messages between players and server

##### Declaration

```
IMyNetworkClient Client { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyNetworkClient](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyNetworkClient.html) |     |

#### Controller

Gets the EntityController for the player.

##### Declaration

```
IMyEntityController Controller { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntityController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyEntityController.html) |     |

#### DefaultBuildColorSlots

Gets the list of the default build colors.

##### Declaration

```
ListReader<Vector3> DefaultBuildColorSlots { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### DisplayName

Visible player name

##### Declaration

```
string DisplayName { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Grids

List of grids where the player owns at least one block.

##### Declaration

```
HashSet<long> Grids { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<System.Int64\> |     |

#### Identity

Gets the identity for the player

##### Declaration

```
IMyIdentity Identity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyIdentity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyIdentity.html) |     |

#### IdentityId

Unique id for the current player identity.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### IsAdmin

Gets if the player is an admin on the server.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsBot

Gets if the player is a bot (non-human)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPromoted

Gets if the player is promoted to Space Master.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PlayerID

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### PromoteLevel

Gets the player's promote level

##### Declaration

```
MyPromoteLevel PromoteLevel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPromoteLevel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyPromoteLevel.html) |     |

#### RespawnShip

Gets the entity id for the player's respawn ship(s).

##### Declaration

```
ListReader<long> RespawnShip { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<System.Int64\> |     |

#### SelectedBuildColor

Gets or sets the build color for the selected slot.

##### Declaration

```
Vector3 SelectedBuildColor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### SelectedBuildColorSlot

Gets or sets the selected slot for the build color.

##### Declaration

```
int SelectedBuildColorSlot { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### SteamUserId

Gets the Steam user id for the player.

##### Declaration

```
ulong SteamUserId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

### Methods

#### AddGrid(Int64)

Adds a grid to the player's Grids list.

##### Declaration

```
void AddGrid(long gridEntityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | gridEntityId | [EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) |

#### ChangeOrSwitchToColor(Vector3)

Switches to slot containing color, if present. Otherwise sets active slot to color.

##### Declaration

```
void ChangeOrSwitchToColor(Vector3 color)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | color | New current painting color |

#### GetBalanceShortString()

Gets balance of an account associated with player. Format is 'BALANCE CURRENCYSHORTNAME'.
