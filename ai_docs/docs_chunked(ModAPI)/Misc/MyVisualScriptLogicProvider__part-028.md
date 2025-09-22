System.String

triggerName

#### RemoveUIString(Int64, Int64)

##### Declaration

```
[VisualScriptingMiscData("UIString", "Remove UI string with specific id. PlayerId -1 stands for all players, 0 for local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveUIString(long id, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

id

System.Int64

playerId

#### RemoveWeather(Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Remove a weather based on position", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveWeather(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### RenameEntity(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Renames specific entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RenameEntity(string oldName, string newName = null)
```

##### Parameters

Type

Name

Description

System.String

oldName

System.String

newName

#### ReplaceQuestlogDetail(Int32, String, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Replaces detail of the quest for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ReplaceQuestlogDetail(int id = 0, string newDetail = "", bool useTyping = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

id

System.String

newDetail

System.Boolean

useTyping

System.Int64

playerId

#### ReplaceQuestlogDetailLocal(Int32, String, Boolean, Int64)

##### Declaration

```
public static void ReplaceQuestlogDetailLocal(int id = 0, string newDetail = "", bool useTyping = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

id

System.String

newDetail

System.Boolean

useTyping

System.Int64

playerId

#### ReportMatchEndToAnalytics(String, Int32)

##### Declaration

```
[VisualScriptingMiscData("Other", "Report match result and time to analytics", -10510688)]
[VisualScriptingMember(true, false)]
public static void ReportMatchEndToAnalytics(string result, int matchTime)
```

##### Parameters

Type

Name

Description

System.String

result

System.Int32

matchTime

#### RequestVicinityCache(Int64)

##### Declaration

```
[VisualScriptingMiscData("Cutscenes", "Preload entity on clients to prevent streaming and popping", -10510688)]
[VisualScriptingMember(true, false)]
public static void RequestVicinityCache(long entityId)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

#### RequestVicinityCacheLocal(Int64)

##### Declaration

```
public static void RequestVicinityCacheLocal(long entityId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

#### ResearchListAddItem(MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Adds specific item into research.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ResearchListAddItem(MyDefinitionId itemId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

#### ResearchListClear()

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Clears required research list for all.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ResearchListClear()
```

#### ResearchListRemoveItem(MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Removes specific item from research.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ResearchListRemoveItem(MyDefinitionId itemId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

#### ResearchListWhitelist(Boolean)

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "[OBSOLETE] Enables/disables research whitelist mode.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ResearchListWhitelist(bool whitelist)
```

##### Parameters

Type

Name

Description

System.Boolean

whitelist

#### SaveSession()

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Saves the game.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool SaveSession()
```

##### Returns

Type

Description

System.Boolean

#### SaveSessionAs(String)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Saves the game under specific name.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool SaveSessionAs(string saveName)
```

##### Parameters

Type

Name

Description

System.String

saveName

##### Returns

Type

Description

System.Boolean

#### ScreenColorFadingMinimalizeHUD(Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Sets if screen fade should minimize HUD.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ScreenColorFadingMinimalizeHUD(bool minimalize = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

minimalize

System.Int64

playerId

#### ScreenColorFadingSetColor(Color, Int64)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Sets target color for screen fading.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ScreenColorFadingSetColor(Color color = null, long playerId = -1L)
```

##### Parameters

Type

Name

Description

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

System.Int64

playerId

#### ScreenColorFadingStart(Single, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Fades/shows screen over period of time.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ScreenColorFadingStart(float time = 1F, bool toOpaque = true, long playerId = -1L)
```
