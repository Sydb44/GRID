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

#### CreateNPCFaction(String, String, String, String)

Creates new faction with faction type [None](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyFactionTypes.html#VRage_Game_MyFactionTypes_None)

##### Declaration

```
void CreateNPCFaction(string tag, string name, string desc, string privateInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | tag | Faction tag |
| System.String | name | Faction name |
| System.String | desc | Faction description |
| System.String | privateInfo | Faction private info |

#### DeclareWar(Int64, Int64)

Declare war

##### Declaration

```
void DeclareWar(long fromFactionId, long toFactionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | fromFactionId | Faction that declares war |
| System.Int64 | toFactionId | Faction that receive war declaration |

#### DemoteMember(Int64, Int64)

Demote faction member

##### Declaration

```
void DemoteMember(long factionId, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | Faction that has player |
| System.Int64 | playerId | Player IdentityId to demote |

#### EditFaction(Int64, String, String, String, String)

Edits faction

##### Declaration

```
void EditFaction(long factionId, string tag, string name, string desc, string privateInfo)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | FactionId that should be changed |
| System.String | tag | New faction tag |
| System.String | name | New faction name |
| System.String | desc | New faction description |
| System.String | privateInfo | New faction private info |

#### EditFaction(Int64, String, String, String, String, String, Vector3, Vector3)

Edits faction

##### Declaration

```
void EditFaction(long factionId, string tag, string name, string desc, string privateInfo, string icon, Vector3 factionColor, Vector3 factionIconColor)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId | FactionId that should be changed |
| System.String | tag | New faction tag |
| System.String | name | New faction name |
| System.String | desc | New faction description |
| System.String | privateInfo | New faction private info |
| System.String | icon | Faction icon image |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | factionColor | Faction color (background of icon) |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | factionIconColor | Faction icon color |

#### FactionNameExists(String, IMyFaction)

Gets if faction with provided tag exists

##### Declaration

```
bool FactionNameExists(string name, IMyFaction doNotCheck = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name | Name to check |
| [IMyFaction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html) | doNotCheck | Faction to ignore |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if faction with that tag exists, and it is not ignored |

#### FactionTagExists(String, IMyFaction)

Gets if faction with provided tag exists

##### Declaration

```
bool FactionTagExists(string tag, IMyFaction doNotCheck = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | tag | Tag to check |
| [IMyFaction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyFaction.html) | doNotCheck | Faction to ignore |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if faction with that tag exists, and it is not ignored |

#### GetObjectBuilder()

Gets object builder

##### Declaration

```
MyObjectBuilder_FactionCollection GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_FactionCollection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_FactionCollection.html) | Object builder |

#### GetRelationBetweenFactions(Int64, Int64)

Gets relation between 2 factions

##### Declaration

```
MyRelationsBetweenFactions GetRelationBetweenFactions(long factionId1, long factionId2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId1 | Faction id |
| System.Int64 | factionId2 | Faction id |

##### Returns

| Type | Description |
| --- | --- |
| [MyRelationsBetweenFactions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyRelationsBetweenFactions.html) | Relation enum |

#### GetReputationBetweenFactions(Int64, Int64)

Gets reputation between 2 factions

##### Declaration

```
int GetReputationBetweenFactions(long factionId1, long factionId2)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | factionId1 | Faction id |
| System.Int64 | factionId2 | Faction id |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Reputation |

#### GetReputationBetweenPlayerAndFaction(Int64, Int64)

Gets reputation between identity and faction

##### Declaration

```
int GetReputationBetweenPlayerAndFaction(long identityId, long factionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | identityId | Player IdentityId |
| System.Int64 | factionId | Faction id |
