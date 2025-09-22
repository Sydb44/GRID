Gets ModAPI interface providing control over faction

##### Declaration

```
IMyFactionCollection Factions { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_GameDateTime)GameDateTime

Gets and sets game date time, that is a sum of 2081 Jan 1 at 0:00:00 and [ElapsedPlayTime](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_ElapsedPlayTime) Note using setter, would change [ElapsedPlayTime](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_ElapsedPlayTime) as well

##### Declaration

```
DateTime GameDateTime { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.DateTime |     |

#### [](#VRage_Game_ModAPI_IMySession_GameplayFrameCounter)GameplayFrameCounter

Gets current game amounts of ticks passed from start. Only gets updated when the game is not paused

##### Declaration

```
int GameplayFrameCounter { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMySession_GPS)GPS

Gets ModAPI interface providing control over gps coordinates

##### Declaration

```
IMyGpsCollection GPS { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_GrinderSpeedMultiplier)GrinderSpeedMultiplier

Gets game session global grinder speed multiplier

##### Declaration

```
float GrinderSpeedMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_HackSpeedMultiplier)HackSpeedMultiplier

Gets game session global hacking speed multiplier

##### Declaration

```
float HackSpeedMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_HasAdminPrivileges)HasAdminPrivileges

##### Declaration

```
bool HasAdminPrivileges { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_HasCreativeRights)HasCreativeRights

Checks if the local player is an admin or is promoted to space master (or higher).

##### Declaration

```
bool HasCreativeRights { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_InventoryMultiplier)InventoryMultiplier

Not used

##### Declaration

```
float InventoryMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_IsCameraAwaitingEntity)IsCameraAwaitingEntity

Not used

##### Declaration

```
bool IsCameraAwaitingEntity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_IsCameraControlledObject)IsCameraControlledObject

Gets if the current camera is the current controlled object (not spectator)

##### Declaration

```
bool IsCameraControlledObject { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_IsCameraUserControlledSpectator)IsCameraUserControlledSpectator

Gets if the current camera is the user controlled spectator

##### Declaration

```
bool IsCameraUserControlledSpectator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_IsServer)IsServer

Gets whether this game instance is server. (Not if game is multiplayer)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_LocalHumanPlayer)LocalHumanPlayer

Gets player that playing on this game window. Always null, when called on dedicated server instance, and not null in any other cases

##### Declaration

```
IMyPlayer LocalHumanPlayer { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_MaxBackupSaves)MaxBackupSaves

Gets maximum backups allowed in game settings

##### Declaration

```
short MaxBackupSaves { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int16 |     |

#### [](#VRage_Game_ModAPI_IMySession_MaxFloatingObjects)MaxFloatingObjects

Gets maximum floating objects allowed in game settings

##### Declaration

```
short MaxFloatingObjects { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int16 |     |

#### [](#VRage_Game_ModAPI_IMySession_MaxPlayers)MaxPlayers

Gets maximum players allowed in game settings

##### Declaration

```
short MaxPlayers { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int16 |     |

#### [](#VRage_Game_ModAPI_IMySession_Mods)Mods

Gets or sets mods added to current game

##### Declaration

```
List<MyObjectBuilder_Checkpoint.ModItem> Mods { get; set; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_MultiplayerAlive)MultiplayerAlive

Gets or sets whether there is connection with server. When it is false, a warning would appear.

##### Declaration

```
bool MultiplayerAlive { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_MultiplayerDirect)MultiplayerDirect

##### Declaration

```
bool MultiplayerDirect { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_MultiplayerLastMsg)MultiplayerLastMsg

Gets or sets time in seconds, from last message from server

##### Declaration

```
double MultiplayerLastMsg { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRage_Game_ModAPI_IMySession_Name)Name

Gets or sets name of the game

##### Declaration

```
string Name { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |
