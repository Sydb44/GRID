---
title: "Interface IMySession"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMySession"
---

# Interface IMySession | Space Engineers ModAPI

ModAPI giving access to MySession functions and properties for modders

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMySession
```

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_IMySession_AssemblerEfficiencyMultiplier)AssemblerEfficiencyMultiplier

Gets game session global assembler efficiency multiplier

##### Declaration

```
float AssemblerEfficiencyMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_AssemblerSpeedMultiplier)AssemblerSpeedMultiplier

Gets game session global assembler speed multiplier

##### Declaration

```
float AssemblerSpeedMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_AutoHealing)AutoHealing

Gets if game settings allows auto healing

##### Declaration

```
bool AutoHealing { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_AutoSaveInMinutes)AutoSaveInMinutes

Gets auto save game setting

##### Declaration

```
uint AutoSaveInMinutes { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt32 |     |

#### [](#VRage_Game_ModAPI_IMySession_BlocksInventorySizeMultiplier)BlocksInventorySizeMultiplier

Gets game session global block inventory size multiplier

##### Declaration

```
float BlocksInventorySizeMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_Camera)Camera

Gets current camera

##### Declaration

```
IMyCamera Camera { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_CameraController)CameraController

Gets current camera controller

##### Declaration

```
IMyCameraController CameraController { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_CameraTargetDistance)CameraTargetDistance

Gets or sets the third person camera distance.

##### Declaration

```
double CameraTargetDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRage_Game_ModAPI_IMySession_CargoShipsEnabled)CargoShipsEnabled

Gets if game settings allows auto healing

##### Declaration

```
bool CargoShipsEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_CharactersInventoryMultiplier)CharactersInventoryMultiplier

Gets game session global characters inventory size multiplier

##### Declaration

```
float CharactersInventoryMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_IMySession_ClientCanSave)ClientCanSave

##### Declaration

```
bool ClientCanSave { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_Config)Config

Obtaining values from config is slow and can allocate memory! Do it only when necessary.

##### Declaration

```
IMyConfig Config { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_ControlledObject)ControlledObject

##### Declaration

```
IMyControllableEntity ControlledObject { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_CreativeMode)CreativeMode

Gets whether current create game is in creative mode

##### Declaration

```
bool CreativeMode { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_CurrentPath)CurrentPath

Gets current game save path

##### Declaration

```
string CurrentPath { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMySession_DamageSystem)DamageSystem

Gets ModAPI interface providing control over damage system

##### Declaration

```
IMyDamageSystem DamageSystem { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_Description)Description

Gets or sets current game description (used in MOTD)

##### Declaration

```
string Description { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### [](#VRage_Game_ModAPI_IMySession_ElapsedPlayTime)ElapsedPlayTime

Gets time elapsed since the start of current session

##### Declaration

```
TimeSpan ElapsedPlayTime { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.TimeSpan |     |

#### [](#VRage_Game_ModAPI_IMySession_EnableCopyPaste)EnableCopyPaste

Get whether current player can copy/paste grids.

##### Declaration

```
bool EnableCopyPaste { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_IMySession_EnvironmentHostility)EnvironmentHostility

Gets current game environment hostility setting

##### Declaration

```
MyEnvironmentHostilityEnum EnvironmentHostility { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_Factions)Factions

Gets ModAPI interface providing control over faction

##### Declaration

```
IMyFactionCollection Factions { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_IMySession_GameDateTime)GameDateTime

Gets and sets game date time, that is a sum of 2081 Jan 1 at 0:00:00 and [ElapsedPlayTime](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_ElapsedPlayTime) Note using setter, would change [ElapsedPlayTime](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMySession.html#VRage_Game_ModAPI_IMySession_ElapsedPlayTime) as well
