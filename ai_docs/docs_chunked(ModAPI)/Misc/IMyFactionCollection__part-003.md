
##### Declaration

```
int GetReputationBetweenPlayerAndFaction(long identityId, long factionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Player IdentityId |
| System.Int64 | factionId | Faction id |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Reputation |

#### IsPeaceRequestStatePending(Int64, Int64)

##### Declaration

```
bool IsPeaceRequestStatePending(long myFactionId, long foreignFactionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | myFactionId |     |
| System.Int64 | foreignFactionId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPeaceRequestStateSent(Int64, Int64)

Gets if there is peace request sent

##### Declaration

```
bool IsPeaceRequestStateSent(long myFactionId, long foreignFactionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | myFactionId |     |
| System.Int64 | foreignFactionId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### KickMember(Int64, Int64)

Kicks member from faction

##### Declaration

```
void KickMember(long factionId, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction that has player |
| System.Int64 | playerId | Player IdentityId to kick |

#### KickPlayerFromFaction(Int64)

##### Declaration

```
void KickPlayerFromFaction(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |

#### MemberLeaves(Int64, Int64)

Forces member to leave

##### Declaration

```
void MemberLeaves(long factionId, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction that has player |
| System.Int64 | playerId | Player IdentityId to force leave |

#### PromoteMember(Int64, Int64)

Promotes faction member

##### Declaration

```
void PromoteMember(long factionId, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction that has player |
| System.Int64 | playerId | Player IdentityId to promote |

#### RemoveFaction(Int64)

Remove faction by id

##### Declaration

```
void RemoveFaction(long factionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction id |

#### SendJoinRequest(Int64, Int64)

Send faction join request

##### Declaration

```
void SendJoinRequest(long factionId, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction to join |
| System.Int64 | playerId | Player Identity Id |

#### SendPeaceRequest(Int64, Int64)

Send peace request from one faction to another

##### Declaration

```
void SendPeaceRequest(long fromFactionId, long toFactionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | fromFactionId | From faction |
| System.Int64 | toFactionId | To faction |

#### SetReputation(Int64, Int64, Int32)

Sets reputation between 2 factions Note: Faction 1 always has same reputation to Faction 2, as Faction 2 to Faction 1

##### Declaration

```
void SetReputation(long fromFactionId, long toFactionId, int reputation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | fromFactionId | Faction 1 |
| System.Int64 | toFactionId | Faction 2 |
| System.Int32 | reputation | Desired reputation |

#### SetReputationBetweenPlayerAndFaction(Int64, Int64, Int32)

Sets reputation between player and faction.

##### Declaration

```
void SetReputationBetweenPlayerAndFaction(long identityId, long factionId, int reputation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | IdentityId |
| System.Int64 | factionId | Faction Id |
| System.Int32 | reputation | Desired reputation |

#### TryGetFactionById(Int64)

Tries get faction by faction id

##### Declaration

```
IMyFaction TryGetFactionById(long factionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Id of faction |

##### Returns

| Type | Description |
| --- | --- |
| [IMyFaction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html) | Faction or null |

#### TryGetFactionByName(String)

Tries get faction with provided name

##### Declaration

```
IMyFaction TryGetFactionByName(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Name of faction |

##### Returns

| Type | Description |
| --- | --- |
| [IMyFaction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html) | Faction or null |

#### TryGetFactionByTag(String)

Tries get faction with provided tag

##### Declaration

```
IMyFaction TryGetFactionByTag(string tag)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | tag | Tag of faction |

##### Returns

| Type | Description |
| --- | --- |
| [IMyFaction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html) | Faction or null |

#### TryGetPlayerFaction(Int64)

Tries get faction that has member with provided id

##### Declaration

```
IMyFaction TryGetPlayerFaction(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId | IdentityId of player |

##### Returns

| Type | Description |
| --- | --- |
| [IMyFaction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html) | Faction or null |

### Events

#### FactionAutoAcceptChanged

##### Declaration

```
event Action<long, bool, bool> FactionAutoAcceptChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<System.Int64, System.Boolean, System.Boolean\> |     |
