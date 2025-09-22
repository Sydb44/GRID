| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ServerPort)ServerPort

Gets or sets server connection port 27016 - default

##### Declaration

```
int ServerPort { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_SessionSettings)SessionSettings

Gets or sets (but that doesn't change anything) session settings

##### Declaration

```
MyObjectBuilder_SessionSettings SessionSettings { get; set; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_SpamMessagesTime)SpamMessagesTime

Gets or sets the time threshold for spam. If elapsed time between messages is less they are considered spam (seconds)

##### Declaration

```
float SpamMessagesTime { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_SpamMessagesTimeout)SpamMessagesTimeout

If player is considered a spammer based on SpamMessagesTime they cannot send any messages for the duration of this timeout (seconds)

##### Declaration

```
int SpamMessagesTimeout { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_SteamPort)SteamPort

Gets or sets steam port

##### Declaration

```
int SteamPort { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_VerboseNetworkLogging)VerboseNetworkLogging

Not used

##### Declaration

```
bool VerboseNetworkLogging { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_WatcherInterval)WatcherInterval

Not used

##### Declaration

```
float WatcherInterval { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_WatcherSimulationSpeedMinimum)WatcherSimulationSpeedMinimum

Not used

##### Declaration

```
float WatcherSimulationSpeedMinimum { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_WorldName)WorldName

Gets or sets world name. Doesn't change world name in client find server gui when setted.

##### Declaration

```
string WorldName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_GenerateRemoteSecurityKey)GenerateRemoteSecurityKey()

Gets remote api password

##### Declaration

```
void GenerateRemoteSecurityKey()
```

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_GetFilePath)GetFilePath()

Gets where settings file is located

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.String | File path |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_Load_System_String_)Load(String)

Load settings from file

##### Declaration

```
void Load(string path = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_Save_System_String_)Save(String)

Saves game.

##### Declaration

```
void Save(string path = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | path | When not null will save to provided folder |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_SetPassword_System_String_)SetPassword(String)

Used to set new password for server

##### Declaration

```
void SetPassword(string password)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | password |     |