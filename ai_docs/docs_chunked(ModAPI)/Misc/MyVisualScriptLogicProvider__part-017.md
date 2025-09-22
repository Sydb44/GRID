Description

System.Int64

#### GetMatchIsRunningState()

##### Declaration

```
[VisualScriptingMiscData("Other", "Get information whether component handling the match is running or not. Running component will have the time advancing and states will be changing.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool GetMatchIsRunningState()
```

##### Returns

Type

Description

System.Boolean

#### GetMatchState()

##### Declaration

```
[VisualScriptingMiscData("Other", "Get name of the current state of the match.", -10510688)]
[VisualScriptingMember(true, false)]
public static string GetMatchState()
```

##### Returns

Type

Description

System.String

#### GetMatchStateRemainingDuration()

##### Declaration

```
[VisualScriptingMiscData("Other", "Get remaining time of the current match state. Time is in minutes.", -10510688)]
[VisualScriptingMember(true, false)]
public static float GetMatchStateRemainingDuration()
```

##### Returns

Type

Description

System.Single

#### GetMergeBlockStatus(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Returns merge block status ( -1 - block don't exist, 2 - Locked, 1 - Constrained, 0 - Otherwise).", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetMergeBlockStatus(string mergeBlockName)
```

##### Parameters

Type

Name

Description

System.String

mergeBlockName

##### Returns

Type

Description

System.Int32

#### GetModsPath()

##### Declaration

```
[VisualScriptingMiscData("Misc", "Returns path to where mods are being stored.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetModsPath()
```

##### Returns

Type

Description

System.String

#### GetMusicVolume()

##### Declaration

```
[VisualScriptingMiscData("Audio", "Get music volume.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetMusicVolume()
```

##### Returns

Type

Description

System.Single

#### GetNearestPlanet(Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Returns name of a planet if point is close to a plane (in its natural gravity). Else returns 'Void'. !!!BEWARE 'Void' is just for English as this string is localized. For checking if there really is a planet or not use 'IsPlanetNearby(...)' function as output here might be inconsistent between localizations.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetNearestPlanet(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

##### Returns

Type

Description

System.String

#### GetNumberOfGridBlocks(String, String, String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Gets number of blocks of specified type on the specific grid.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetNumberOfGridBlocks(string entityName, string blockTypeId, string blockSubtypeId)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

blockTypeId

System.String

blockSubtypeId

##### Returns

Type

Description

System.Int32

#### GetOnlinePlayers()

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets online players.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<long> GetOnlinePlayers()
```

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### GetOpenedTerminal()

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets currently opened terminal screen. (only if it is focused)", -10510688)]
[VisualScriptingMember(false, false)]
public static MyGuiScreenTerminal GetOpenedTerminal()
```

##### Returns

Type

Description

Sandbox.Game.Gui.MyGuiScreenTerminal

#### GetOpenedToolbarConfig()

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets currently opened ToolbarConfig screen (G-Screen). (only if it is focused)", -10510688)]
[VisualScriptingMember(false, false)]
public static MyGuiScreenToolbarConfigBase GetOpenedToolbarConfig()
```

##### Returns

Type

Description

Sandbox.Game.Gui.MyGuiScreenToolbarConfigBase

#### GetOwner(String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Get owner of specific entity. 0 for nobody.", -10510688)]
[VisualScriptingMember(true, false)]
public static long GetOwner(string entityName)
```

##### Parameters

Type

Name

Description

System.String

entityName

##### Returns

Type

Description

System.Int64

#### GetOxygenLevelAtPlayersPosition(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets oxygen level at player's position.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetOxygenLevelAtPlayersPosition(long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

##### Returns

Type

Description

System.Single

#### GetPirateId()

##### Declaration

```
[VisualScriptingMiscData("Factions", "Gets id of pirate faction.", -10510688)]
[VisualScriptingMember(false, false)]
public static long GetPirateId()
```

##### Returns

Type

Description

System.Int64

#### GetPlayerControlledBlockData(out String, out Int64, out String, out Int64, out String, out Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets player's controlled cube block (grid).", -10510688)]
[VisualScriptingMember(false, false)]
public static bool GetPlayerControlledBlockData(out string controlType, out long blockId, out string blockName, out long gridId, out string gridName, out bool isRespawnShip, long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.String

controlType

System.Int64

blockId

System.String

blockName

System.Int64

gridId

System.String

gridName

System.Boolean

isRespawnShip

System.Int64

playerId

##### Returns

Type

Description

System.Boolean

#### GetPlayerRespawnPoints(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets the player's available respawn points", -10510688)]
[VisualScriptingMember(true, false)]
public static int GetPlayerRespawnPoints(long playerId)
```
