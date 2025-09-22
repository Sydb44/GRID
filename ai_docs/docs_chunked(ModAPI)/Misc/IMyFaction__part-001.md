---
title: "Interface IMyFaction"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyFaction"
---

# Interface IMyFaction | Space Engineers ModAPI

Describes faction (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyFaction
```

### Properties

#### AcceptHumans

Gets if faction accepts players

##### Declaration

```
bool AcceptHumans { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AutoAcceptMember

Gets if faction automatically accept new members

##### Declaration

```
bool AutoAcceptMember { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AutoAcceptPeace

Gets if faction automatically accept peace from other factions

##### Declaration

```
bool AutoAcceptPeace { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CustomColor

Gets faction icon background color

##### Declaration

```
Vector3 CustomColor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Description

Gets faction description

##### Declaration

```
string Description { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### FactionIcon

Gets faction icon

##### Declaration

```
Nullable<MyStringId> FactionIcon { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> |     |

#### FactionId

Gets faction id

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### FactionType

Gets faction type: Pirate, Miner ...

##### Declaration

```
MyFactionTypes FactionType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyFactionTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionTypes.html) |     |

#### FounderId

IdentityId of founder of faction

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### IconColor

Gets faction icon color

##### Declaration

```
Vector3 IconColor { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### JoinRequests

Gets all faction join requests.

##### Declaration

```
DictionaryReader<long, MyFactionMember> JoinRequests { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.Int64, [MyFactionMember](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionMember.html)\> |     |

#### Members

Gets all members (founder, leaders also) of faction.

##### Declaration

```
DictionaryReader<long, MyFactionMember> Members { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.Int64, [MyFactionMember](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionMember.html)\> |     |

#### Name

Gets faction name

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ObjectivePercentageCompleted

Gets or sets percentage of completed objective. Used in Uranium Heist scenario

##### Declaration

```
float ObjectivePercentageCompleted { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PrivateInfo

Gets faction private info

##### Declaration

```
string PrivateInfo { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Score

Gets or sets score of faction. Used in Uranium Heist scenario

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Tag

Gets faction tag

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### GetBalanceShortString()

Gets balance of an account associated with faction. Format is 'BALANCE CURRENCYSHORTNAME'.

##### Declaration

```
string GetBalanceShortString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String | Current balance of the account in form of formatted string. If Banking System does not exist method returns null. |

#### HasLastMember()

Returns if faction has last member

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if faction has last member |

#### IsEnemy(Int64)

Returns if player with provided playerId is enemy to faction

##### Declaration

```
bool IsEnemy(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | Player IdentityId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player is enemy to faction |

#### IsEveryoneNpc()

Returns if faction has no humans

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if faction has no humans |

#### IsFounder(Int64)

Returns if player with provided playerId is founder of faction

##### Declaration

```
bool IsFounder(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | Player IdentityId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player is founder of faction |
