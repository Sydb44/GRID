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

System.String

#### GetPlayersOxygenLevel(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets oxygen level of player's suit.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetPlayersOxygenLevel(long playerId = 0L)
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

#### GetPlayersPosition(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets player's position.", -10510688)]
[VisualScriptingMember(false, false)]
public static Vector3D GetPlayersPosition(long playerId = 0L)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetPlayersSpeed(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets player's speed (linear velocity).", -10510688)]
[VisualScriptingMember(false, false)]
public static Vector3D GetPlayersSpeed(long playerId = 0L)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetQuestlogMaxPages()

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Obsolete. Returns -1.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetQuestlogMaxPages()
```

##### Returns

Type

Description

System.Int32

#### GetQuestlogPage()

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Obsolete. Returns -1.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetQuestlogPage()
```

##### Returns

Type

Description

System.Int32

#### GetQuestlogPageFromMessage(Int32)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Obsolete. Returns -1.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetQuestlogPageFromMessage(int id = 0)
```

##### Parameters

Type

Name

Description

System.Int32

id

##### Returns

Type

Description

System.Int32

#### GetRelationBetweenFactions(String, String)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Returns current reputation between two factions. Returns int.MinValue (-2147483648) if either of factions is not found.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetRelationBetweenFactions(string tagA, string tagB)
```

##### Parameters

Type

Name

Description

System.String

tagA

System.String

tagB

##### Returns

Type

Description

System.Int32

#### GetRelationBetweenPlayerAndFaction(Int64, String)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Returns current reputation between player and faction. Returns int.MinValue (-2147483648) if player or faction is not found.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetRelationBetweenPlayerAndFaction(long playerId, string tagB)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.String

tagB

##### Returns

Type

Description

System.Int32

#### GetSavesPath()

##### Declaration

```
[VisualScriptingMiscData("Misc", "Returns path to where game is being saved.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetSavesPath()
```

##### Returns

Type

Description

System.String

#### GetSimulationQuality()

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Returns simulation quality (0 normal, 1 low, 2 verylow) currect platform can handle", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetSimulationQuality()
```

##### Returns

Type

Description

System.Int32

#### GetSteamId(Int64)

##### Declaration

```
[VisualScriptingMember(false, false)]
[VisualScriptingMiscData("Gameplay", "Get Steam ID from player ID.", -10510688)]
public static ulong GetSteamId(long playerId)
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

System.UInt64

#### GetSunDirection()

##### Declaration

```
[VisualScriptingMiscData("Environment", "Gets current sun rotation.", -10510688)]
[VisualScriptingMember(false, false)]
public static Vector3 GetSunDirection()
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetTab(MyGuiControlTabControl, Int32)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets tab on specific index of specified TabControl element.", -10510688)]
[VisualScriptingMember(false, false)]
public static MyGuiControlTabPage GetTab(this MyGuiControlTabControl tabs, int key)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiControlTabControl

tabs

System.Int32

key

##### Returns

Type

Description

Sandbox.Graphics.GUI.MyGuiControlTabPage

#### GetTabs(MyGuiScreenTerminal)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets TabControl elements of specific terminal screen.", -10510688)]
[VisualScriptingMember(false, false)]
public static MyGuiControlTabControl GetTabs(this MyGuiScreenTerminal terminal)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Gui.MyGuiScreenTerminal

terminal

##### Returns

Type

Description

Sandbox.Graphics.GUI.MyGuiControlTabControl

#### GetTemperatureInPoint(Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Get temperature based on position", -10510688)]
[VisualScriptingMember(true, false)]
public static float GetTemperatureInPoint(Vector3D position)
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

System.Single

#### GetTimers()

##### Declaration

```
public static SerializableDictionary<string, (int, bool)> GetTimers()
```

##### Returns

Type

Description

VRage.Serialization.SerializableDictionary<System.String, System.ValueTuple<System.Int32, System.Boolean\>>
