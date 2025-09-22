---
title: "Interface IMyConfigDedicated"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyConfigDedicated.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyConfigDedicated"
---

# Interface IMyConfigDedicated | Space Engineers ModAPI

Describes dedicated server configuration (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyConfigDedicated
```

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_Administrators)Administrators

Gets or sets administrators It may contain ids in 2 different formats: First - steamId.ToString() Second - starts with `STEAM_0:`

##### Declaration

```
List<string> Administrators { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_AsteroidAmount)AsteroidAmount

Not used

##### Declaration

```
int AsteroidAmount { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_AutodetectDependencies)AutodetectDependencies

Gets or sets if game should automatically add dependency mods in mods list

##### Declaration

```
bool AutodetectDependencies { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_AutoRestartEnabled)AutoRestartEnabled

Gets or sets whether auto restart is enabled

##### Declaration

```
bool AutoRestartEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_AutoRestatTimeInMin)AutoRestatTimeInMin

Gets or sets auto restart time in minutes

##### Declaration

```
int AutoRestatTimeInMin { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_AutoUpdateBranchPassword)AutoUpdateBranchPassword

Gets or sets password of steam version branch

##### Declaration

```
string AutoUpdateBranchPassword { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_AutoUpdateCheckIntervalInMin)AutoUpdateCheckIntervalInMin

Gets or sets how often game checks if new version is available

##### Declaration

```
int AutoUpdateCheckIntervalInMin { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_AutoUpdateEnabled)AutoUpdateEnabled

Gets or sets if game auto update enabled

##### Declaration

```
bool AutoUpdateEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_AutoUpdateRestartDelayInMin)AutoUpdateRestartDelayInMin

Gets or sets time before restart after new update found

##### Declaration

```
int AutoUpdateRestartDelayInMin { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_AutoUpdateSteamBranch)AutoUpdateSteamBranch

Gets or sets name of steam version branch

##### Declaration

```
string AutoUpdateSteamBranch { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_Banned)Banned

Gets or sets Banned players. SteamId and Xbox live ids

##### Declaration

```
List<ulong> Banned { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.UInt64\> |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ChatAntiSpamEnabled)ChatAntiSpamEnabled

Gets or sets whether chat anti spam is enabled

##### Declaration

```
bool ChatAntiSpamEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ConsoleCompatibility)ConsoleCompatibility

Not used

##### Declaration

```
bool ConsoleCompatibility { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_CrossPlatform)CrossPlatform

##### Declaration

```
bool CrossPlatform { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_DedicatedId)DedicatedId

Id of a dedicated server

##### Declaration

```
long DedicatedId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_GroupID)GroupID

Steam group id, that blocking access to player not from this group.

##### Declaration

```
ulong GroupID { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_IgnoreLastSession)IgnoreLastSession

Setting that is used server start. When it is true, it should not load previous server launch world

##### Declaration

```
bool IgnoreLastSession { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_IP)IP

Gets or sets server IP

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_LoadWorld)LoadWorld

Gets current world load path or sets next server start load path

##### Declaration

```
string LoadWorld { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMyConfigDedicated_ManualActionChatMessage)ManualActionChatMessage

Not used
