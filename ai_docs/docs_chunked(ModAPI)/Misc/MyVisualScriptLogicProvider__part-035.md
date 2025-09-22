Type

Name

Description

Sandbox.Graphics.GUI.MyGuiControlTabControl

pageControl

System.Int32

pageNumber

#### SetPlayerGeneralDamageModifier(Int64, Single)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets player's damage modifier.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayerGeneralDamageModifier(long playerId = 0L, float modifier = 1F)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Single

modifier

#### SetPlayerInputBlacklistState(String, Int64, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets player's input black list. Enables/Disables specified control of the character.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayerInputBlacklistState(string controlStringId, long playerId = -1L, bool enabled = false)
```

##### Parameters

Type

Name

Description

System.String

controlStringId

System.Int64

playerId

System.Boolean

enabled

#### SetPlayersColorInHSV(Int64, Vector3)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets player's color (HSV).", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayersColorInHSV(long playerId = 0L, Vector3 colorHSV = null)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

colorHSV

#### SetPlayersColorInRGB(Int64, Color)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets player's color (RGB).", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayersColorInRGB(long playerId = 0L, Color colorRBG = null)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

colorRBG

#### SetPlayersEnergyLevel(Int64, Single)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets energy level of the player's suit.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayersEnergyLevel(long playerId = 0L, float value = 1F)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Single

value

#### SetPlayersFaction(Int64, String)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Forces join player into a faction specified by tag. Returns false if faction does not exist, true otherwise. If player was in any faction before, he will be removed from that faction.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool SetPlayersFaction(long playerId = 0L, string factionTag = "")
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.String

factionTag

##### Returns

Type

Description

System.Boolean

#### SetPlayersHealth(Int64, Single)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets player's health.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayersHealth(long playerId = 0L, float value = 100F)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Single

value

#### SetPlayersHelmetStatus(Int64, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets player's helmet status.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayersHelmetStatus(long playerId = 0L, bool status = true)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Boolean

status

#### SetPlayersHydrogenLevel(Int64, Single)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets hydrogen level of the player's suit.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayersHydrogenLevel(long playerId = 0L, float value = 1F)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Single

value

#### SetPlayersOxygenLevel(Int64, Single)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets oxygen level of the player's suit.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayersOxygenLevel(long playerId = 0L, float value = 1F)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Single

value

#### SetPlayersPosition(Int64, Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets player's position.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayersPosition(long playerId = 0L, Vector3D position = null)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### SetPlayersSpeed(Vector3D, Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Sets player's speed (linear velocity).", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPlayersSpeed(Vector3D speed = null, long playerId = 0L)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

speed

System.Int64

playerId

#### SetQuestlog(Boolean, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Sets title and visibility of the quest for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetQuestlog(bool visible = true, string questName = "", long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

visible

System.String

questName

System.Int64

playerId

#### SetQuestlogDetailCompleted(Int32, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Sets completed of the quest detail for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetQuestlogDetailCompleted(int lineId = 0, bool completed = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

lineId

System.Boolean

completed

System.Int64

playerId
