---
title: "Interface IMyFactionCollection"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFactionCollection.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyFactionCollection"
---

# Interface IMyFactionCollection | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyFactionCollection
```

### Properties

#### Factions

Gets new dictionary with all factions. As keys used factionId

##### Declaration

```
Dictionary<long, IMyFaction> Factions { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.Int64, [IMyFaction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html)\> |     |

### Methods

#### AcceptJoin(Int64, Int64)

Accepts faction join request

##### Declaration

```
void AcceptJoin(long factionId, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction that accepts join |
| System.Int64 | playerId | Player id |

#### AcceptPeace(Int64, Int64)

Accepts peace

##### Declaration

```
void AcceptPeace(long fromFactionId, long toFactionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | fromFactionId | Faction that sent peace request |
| System.Int64 | toFactionId | Faction that received peace request |

#### AddNewNPCToFaction(Int64)

Adds new NPC to faction. Name example: "SPRT NPC3340"

##### Declaration

```
void AddNewNPCToFaction(long factionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction Id |

#### AddNewNPCToFaction(Int64, String)

Adds new NPC to faction

##### Declaration

```
void AddNewNPCToFaction(long factionId, string npcName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction Id |
| System.String | npcName | Name of NPC |

#### AddPlayerToFaction(Int64, Int64)

##### Declaration

```
void AddPlayerToFaction(long playerId, long factionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.Int64 | factionId |     |

#### AreFactionsEnemies(Int64, Int64)

Gets if factions are enemies to each other

##### Declaration

```
bool AreFactionsEnemies(long factionId1, long factionId2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId1 | Faction id 1 |
| System.Int64 | factionId2 | Faction id 2 |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CancelJoinRequest(Int64, Int64)

Cancels player faction join request

##### Declaration

```
void CancelJoinRequest(long factionId, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction to join |
| System.Int64 | playerId | Player that sent join request |

#### CancelPeaceRequest(Int64, Int64)

Cancel peace request from one faction to another

##### Declaration

```
void CancelPeaceRequest(long fromFactionId, long toFactionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | fromFactionId | From faction |
| System.Int64 | toFactionId | To faction |

#### ChangeAutoAccept(Int64, Int64, Boolean, Boolean)

Changes AutoAccept for faction

##### Declaration

```
void ChangeAutoAccept(long factionId, long playerId, bool autoAcceptMember, bool autoAcceptPeace)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction Id |
| System.Int64 | playerId | Player IdentityId |
| System.Boolean | autoAcceptMember | New value of faction [AutoAcceptMember](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html#VRage_Game_ModAPI_IMyFaction_AutoAcceptMember) |
| System.Boolean | autoAcceptPeace | New value of faction [AutoAcceptPeace](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html#VRage_Game_ModAPI_IMyFaction_AutoAcceptPeace) |

#### CreateFaction(Int64, String, String, String, String)

##### Declaration

```
void CreateFaction(long founderId, string tag, string name, string desc, string privateInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | founderId | IdentityId of faction founder |
| System.String | tag | Faction tag |
| System.String | name | Faction name |
| System.String | desc | Faction description |
| System.String | privateInfo | Faction private info |

#### CreateFaction(Int64, String, String, String, String, MyFactionTypes)

##### Declaration

```
void CreateFaction(long founderId, string tag, string name, string desc, string privateInfo, MyFactionTypes type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | founderId | IdentityId of faction founder |
| System.String | tag | Faction tag |
| System.String | name | Faction name |
| System.String | desc | Faction description |
| System.String | privateInfo | Faction private info |
| [MyFactionTypes](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionTypes.html) | type | Faction type |

#### CreateFactionNew(Int64, String, String, String, String, String)

Creates new faction

##### Declaration

```
void CreateFactionNew(long founderId, string tag, string name, string desc, string privateInfo, string type)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | founderId | IdentityId of faction founder |
| System.String | tag | Faction tag |
| System.String | name | Faction name |
| System.String | desc | Faction description |
| System.String | privateInfo | Faction private info |
| System.String | type | Faction type (FactionTypes\_Economy.sbc Id/Subtype), not null. You can use MyFactionTypes.?.ToString() |
