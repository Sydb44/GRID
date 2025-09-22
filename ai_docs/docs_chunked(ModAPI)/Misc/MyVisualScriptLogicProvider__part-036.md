Description

System.Int32

lineId

System.Boolean

completed

System.Int64

playerId

#### SetQuestlogDetailCompletedLocal(Int32, Boolean, Int64)

##### Declaration

```
public static void SetQuestlogDetailCompletedLocal(int lineId = 0, bool completed = true, long playerId = -1L)
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

#### SetQuestlogLocal(Boolean, String, Int64)

##### Declaration

```
public static void SetQuestlogLocal(bool visible = true, string questName = "", long playerId = -1L)
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

#### SetQuestlogPage(Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Obsolete. Does not do anything.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetQuestlogPage(int value = 0, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

value

System.Int64

playerId

#### SetQuestlogTitle(String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Sets title of the quest for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetQuestlogTitle(string questName = "", long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

questName

System.Int64

playerId

#### SetQuestlogTitleLocal(String, Int64)

##### Declaration

```
public static void SetQuestlogTitleLocal(string questName = "", long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

questName

System.Int64

playerId

#### SetQuestlogVisible(Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Sets visible of the quest for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetQuestlogVisible(bool value = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

value

System.Int64

playerId

#### SetQuestlogVisibleLocal(Boolean, Int64)

##### Declaration

```
public static void SetQuestlogVisibleLocal(bool value = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

value

System.Int64

playerId

#### SetRelationBetweenFactions(String, String, Int32)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Set reputation between two factions. Reputation will be automatically clamped to allwed range.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetRelationBetweenFactions(string tagA, string tagB, int reputation)
```

##### Parameters

Type

Name

Description

System.String

tagA

System.String

tagB

System.Int32

reputation

#### SetRelationBetweenPlayerAndFaction(Int64, String, Int32)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Set reputation between player and faction. Reputation will be automatically clamped to allwed range.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetRelationBetweenPlayerAndFaction(long playerId, string tagB, int reputation)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.String

tagB

System.Int32

reputation

#### SetRowRanking(String, String, Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Set row ranking used for sorting.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetRowRanking(string boardId, string rowId, int ranking, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.String

rowId

System.Int32

ranking

System.Int64

playerId

#### SetScenarioWinTypeForAnalytics(String)

##### Declaration

```
[VisualScriptingMiscData("Other", "Set type of scenario win for analytics", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetScenarioWinTypeForAnalytics(string winType)
```

##### Parameters

Type

Name

Description

System.String

winType

#### SetTextPanelColors(String, Color, Color)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Sets colors of specific Text panel.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetTextPanelColors(string panelName, Color fontColor, Color backgroundColor)
```

##### Parameters

Type

Name

Description

System.String

panelName

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

fontColor

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

backgroundColor

#### SetTextPanelDescription(String, String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Sets description of specific Text panel.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetTextPanelDescription(string panelName, string description, bool publicDescription = true)
```

##### Parameters

Type

Name

Description

System.String

panelName

System.String

description

System.Boolean

publicDescription

#### SetTextPanelTitle(String, String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Sets title of specific Text panel.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetTextPanelTitle(string panelName, string title, bool publicTitle = true)
```

##### Parameters

Type

Name

Description

System.String

panelName

System.String

title

System.Boolean

publicTitle

#### SetToolbarPage(Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("Toolbar", "Sets the specified page for the toolbar.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetToolbarPage(int page, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

page

System.Int64

playerId

#### SetToolbarPageLocal(Int32, Int64)

##### Declaration

```
public static void SetToolbarPageLocal(int page, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

page

System.Int64

playerId
