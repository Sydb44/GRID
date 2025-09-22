```
Nullable<ulong> WorkshopId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.UInt64\> |     |

#### [](#VRage_Game_ModAPI_IMySession_WorldBoundaries)WorldBoundaries

Gets world boundaries. Not letting character leaving them

##### Declaration

```
BoundingBoxD WorldBoundaries { get; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_IMySession_BeforeStartComponents)BeforeStartComponents()

Triggers BeforeStart for each game session component, resets game timer.

##### Declaration

```
void BeforeStartComponents()
```

#### [](#VRage_Game_ModAPI_IMySession_Draw)Draw()

Calls Draw on all game session components

##### Declaration

#### [](#VRage_Game_ModAPI_IMySession_GameOver)GameOver()

Does nothing

##### Declaration

#### [](#VRage_Game_ModAPI_IMySession_GameOver_System_Nullable_VRage_Utils_MyStringId__)GameOver(Nullable<MyStringId>)

Does nothing

##### Declaration

```
void GameOver(Nullable<MyStringId> customMessage)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html)\> | customMessage |     |

#### [](#VRage_Game_ModAPI_IMySession_GetCheckpoint_System_String_)GetCheckpoint(String)

Gets current game save. Game is saved in several files. This function returns object builder for file: Sandbox.sbc

##### Declaration

```
MyObjectBuilder_Checkpoint GetCheckpoint(string saveName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | saveName | Name of save |

##### Returns

##### See Also

#### [](#VRage_Game_ModAPI_IMySession_GetComponentByInterfaceType__1)GetComponentByInterfaceType<T>()

Gets session component of interface type T

##### Declaration

```
MySessionComponentBase GetComponentByInterfaceType<T>()
```

##### Returns

##### Type Parameters

| Name | Description |
| --- | --- |
| T   | interface type of the session component |

#### [](#VRage_Game_ModAPI_IMySession_GetSector)GetSector()

Gets current game save. Game is saved in several files. This function returns object builder for file: SANDBOX\_0\_0\_0\_.sbs

##### Declaration

```
MyObjectBuilder_Sector GetSector()
```

##### Returns

##### See Also

#### [](#VRage_Game_ModAPI_IMySession_GetUserPromoteLevel_System_UInt64_)GetUserPromoteLevel(UInt64)

Gets a remote player's promote level.

##### Declaration

```
MyPromoteLevel GetUserPromoteLevel(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steamId |

##### Returns

#### [](#VRage_Game_ModAPI_IMySession_GetVoxelMapsArray)GetVoxelMapsArray()

##### Declaration

```
Dictionary<string, byte[]> GetVoxelMapsArray()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Byte\[\]> |     |

#### [](#VRage_Game_ModAPI_IMySession_GetWorld)GetWorld()

Gets information what receives client when connecting to server

##### Declaration

```
MyObjectBuilder_World GetWorld()
```

##### Returns

#### [](#VRage_Game_ModAPI_IMySession_IsPausable)IsPausable()

Get whether game is pauseable (not multiplayer)

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if game is pauseable |

#### [](#VRage_Game_ModAPI_IMySession_IsUserAdmin_System_UInt64_)IsUserAdmin(UInt64)

Checks if a given player is an admin (or higher).

##### Declaration

```
bool IsUserAdmin(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_IsUserIgnorePCULimit_System_UInt64_)IsUserIgnorePCULimit(UInt64)

Gets whether user can ignore pcu and block limits

##### Declaration

```
bool IsUserIgnorePCULimit(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steamId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player can ignore pcu and block limits |

#### [](#VRage_Game_ModAPI_IMySession_IsUserIgnoreSafeZones_System_UInt64_)IsUserIgnoreSafeZones(UInt64)

Gets whether user can ignore safezone settings

##### Declaration

```
bool IsUserIgnoreSafeZones(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steamId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player can ignore safezone settings |

#### [](#VRage_Game_ModAPI_IMySession_IsUserInvulnerable_System_UInt64_)IsUserInvulnerable(UInt64)

Gets whether user is invulnerable

##### Declaration

```
bool IsUserInvulnerable(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steamId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player is invulnerable |

#### [](#VRage_Game_ModAPI_IMySession_IsUserKeepOriginalOwnershipOnPaste_System_UInt64_)IsUserKeepOriginalOwnershipOnPaste(UInt64)

Gets whether user can keep original BuiltBy of blocks when pasting grid

##### Declaration

```
bool IsUserKeepOriginalOwnershipOnPaste(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId | Player steamId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if player can keep original BuiltBy of blocks when pasting grid |

#### [](#VRage_Game_ModAPI_IMySession_IsUserPromoted_System_UInt64_)IsUserPromoted(UInt64)

##### Declaration

```
bool IsUserPromoted(ulong steamId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_IsUserShowAllPlayers_System_UInt64_)IsUserShowAllPlayers(UInt64)

Gets whether user can see all players
