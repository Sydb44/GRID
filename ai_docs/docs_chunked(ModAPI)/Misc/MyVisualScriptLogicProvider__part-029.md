System.Int64

playerId

#### ScreenColorFadingStart(Single, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Fades/shows screen over period of time.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ScreenColorFadingStart(float time = 1F, bool toOpaque = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Single

time

System.Boolean

toOpaque

System.Int64

playerId

#### ScreenColorFadingStartSwitch(Single, Int64)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Switches screen fade state. Screen will un/fade over specified time.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ScreenColorFadingStartSwitch(float time = 1F, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Single

time

System.Int64

playerId

#### SendChatMessage(String, String, Int64, String)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "Sends a scripted chat message under name 'author' to all players (if playerId equal to 0), or to one specific player. In case of singleplayer, message will shown to local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SendChatMessage(string message, string author = "", long playerId = 0L, string font = "Blue")
```

##### Parameters

Type

Name

Description

System.String

message

System.String

author

System.Int64

playerId

System.String

font

#### SendChatMessageColored(String, Color, String, Int64, String)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "Sends a scripted chat message under name 'author' to all players (if playerId equal to 0), or to one specific player. In case of singleplayer, message will shown to local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SendChatMessageColored(string message, Color color, string author = "", long playerId = 0L, string font = "White")
```

##### Parameters

Type

Name

Description

System.String

message

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

System.String

author

System.Int64

playerId

System.String

font

#### SessionClose(Int32, Boolean, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Closes active session after the specific time (in ms).", -10510688)]
[VisualScriptingMember(true, false)]
public static void SessionClose(int fadeTimeMs = 10000, bool showCredits = true, bool closeSession = true)
```

##### Parameters

Type

Name

Description

System.Int32

fadeTimeMs

System.Boolean

showCredits

System.Boolean

closeSession

#### SessionExitGameDialog(String, String)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Displays player the dialog to exit game to main menu (for non-campaign) or continue next campaign mission (for campaign).", -10510688)]
[VisualScriptingMember(true, false)]
public static void SessionExitGameDialog(string caption, string message)
```

##### Parameters

Type

Name

Description

System.String

caption

System.String

message

#### SessionReloadDialog(String, String, String)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Displays reload dialog with specific caption and message to load save defined by path.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SessionReloadDialog(string caption, string message, string savePath = null)
```

##### Parameters

Type

Name

Description

System.String

caption

System.String

message

System.String

savePath

#### SessionReloadLastCheckpoint(Int32, String, Single, String)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Reloads last checkpoint while displaying message on screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SessionReloadLastCheckpoint(int fadeTimeMs = 10000, string message = null, float textScale = 1F, string font = "Blue")
```

##### Parameters

Type

Name

Description

System.Int32

fadeTimeMs

System.String

message

System.Single

textScale

System.String

font

#### SetAllQuestlogDetailsCompleted(Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Sets completed on all quest details for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetAllQuestlogDetailsCompleted(bool completed = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

completed

System.Int64

playerId

#### SetAllQuestlogDetailsCompletedLocal(Boolean, Int64)

##### Declaration

```
public static void SetAllQuestlogDetailsCompletedLocal(bool completed = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

completed

System.Int64

playerId

#### SetAlphaHighlight(String, Boolean, Int32, Int32, Color, Int64, String, Single)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight of specific object for local player. You can set alpha of color too.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetAlphaHighlight(string entityName, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, long playerId = -1L, string subPartNames = null, float alpha = 1F)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

enabled

System.Int32

thickness

System.Int32

pulseTimeInFrames

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

System.Int64

playerId

System.String

subPartNames

System.Single

alpha

#### SetAlphaHighlightForAll(String, Boolean, Int32, Int32, Color, String, Single)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight of specific object for all players. You can set alpha of color too.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetAlphaHighlightForAll(string entityName, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, string subPartNames = null, float alpha = 1F)
```
