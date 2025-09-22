```
string LoadWorld { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ManualActionChatMessage)ManualActionChatMessage

Not used

##### Declaration

```
string ManualActionChatMessage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ManualActionDelay)ManualActionDelay

Not used

##### Declaration

```
int ManualActionDelay { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_MessageOfTheDay)MessageOfTheDay

Shows Gui Popup for players

##### Declaration

```
string MessageOfTheDay { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_MessageOfTheDayUrl)MessageOfTheDayUrl

Shows Gui Popup for players but in web browser

##### Declaration

```
string MessageOfTheDayUrl { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_NetworkParameters)NetworkParameters

Not used

##### Declaration

```
List<string> NetworkParameters { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_NetworkType)NetworkType

Not used

##### Declaration

```
string NetworkType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_PauseGameWhenEmpty)PauseGameWhenEmpty

Pause game when zero players on servers

##### Declaration

```
bool PauseGameWhenEmpty { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_Plugins)Plugins

Gets or sets server plugins. List contains file paths to dlls

##### Declaration

```
List<string> Plugins { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_PremadeCheckpointPath)PremadeCheckpointPath

##### Declaration

```
string PremadeCheckpointPath { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_RemoteApiEnabled)RemoteApiEnabled

Gets or sets if remote api enabled

##### Declaration

```
bool RemoteApiEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_RemoteApiIP)RemoteApiIP

Gets or sets remote API IP

##### Declaration

```
string RemoteApiIP { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_RemoteApiPort)RemoteApiPort

Gets or sets remote api port

##### Declaration

```
int RemoteApiPort { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_RemoteSecurityKey)RemoteSecurityKey

Gets or sets remote api password

##### Declaration

```
string RemoteSecurityKey { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_Reserved)Reserved

Gets or sets reserved players (player can join server even if it is full). SteamId and Xbox live ids

##### Declaration

```
List<ulong> Reserved { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.UInt64\> |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_RestartSave)RestartSave

Gets or sets if game should save on server stop

##### Declaration

```
bool RestartSave { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_SameMessageTimeout)SameMessageTimeout

Gets or sets the timeout for the same message, it cannot be sent again sooner than this (seconds)

##### Declaration

```
int SameMessageTimeout { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_SaveChatToLog)SaveChatToLog

Gets or sets if game should automatically add dependency mods in mods list

##### Declaration

```
bool SaveChatToLog { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ServerDescription)ServerDescription

Gets or sets server description

##### Declaration

```
string ServerDescription { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ServerName)ServerName

Gets or sets server name

##### Declaration

```
string ServerName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ServerPasswordHash)ServerPasswordHash

Gets or sets server password hash

##### Declaration

```
string ServerPasswordHash { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ServerPasswordSalt)ServerPasswordSalt

Gets or sets server password hash

##### Declaration

```
string ServerPasswordSalt { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ServerPort)ServerPort

Gets or sets server connection port 27016 - default

##### Declaration

```
int ServerPort { get; set; }
```
