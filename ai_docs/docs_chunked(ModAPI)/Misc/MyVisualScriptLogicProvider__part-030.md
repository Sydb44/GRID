System.Single

alpha

#### SetAlphaHighlightForAll(String, Boolean, Int32, Int32, Color, String, Single)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight of specific object for all players. You can set alpha of color too.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetAlphaHighlightForAll(string entityName, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, string subPartNames = null, float alpha = 1F)
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

System.String

subPartNames

System.Single

alpha

#### SetBlockCustomName(String, String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Sets custom name of specific terminal block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetBlockCustomName(string blockName, string newName)
```

##### Parameters

Type

Name

Description

System.String

blockName

System.String

newName

#### SetBlockEnabled(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Enables/disables functional block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetBlockEnabled(string blockName, bool enabled = true)
```

##### Parameters

Type

Name

Description

System.String

blockName

System.Boolean

enabled

#### SetBlockGeneralDamageModifier(String, Single)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Sets damage multiplier for specific block. (Value above 1 increase damage taken by the block, values in range <0;1> decrease damage taken. )", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetBlockGeneralDamageModifier(string blockName, float modifier = 1F)
```

##### Parameters

Type

Name

Description

System.String

blockName

System.Single

modifier

#### SetBlockHealth(String, Single, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Sets block integrity to specific value in range <0;1>. 'damageChange' says if the change is treated as damage or repair (Build integrity won't change in case of damage). 'changeOwner' is id of the one who causes the change.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetBlockHealth(string entityName, float integrity = 1F, bool damageChange = true, long changeOwner = 0L)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Single

integrity

System.Boolean

damageChange

System.Int64

changeOwner

#### SetBlockShowInInventory(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Sets whether or not terminal block should be shown in inventory terminal screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetBlockShowInInventory(string blockName, bool showInInventory = true)
```

##### Parameters

Type

Name

Description

System.String

blockName

System.Boolean

showInInventory

#### SetBlockShowInTerminal(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Sets whether or not terminal block should be shown in terminal screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetBlockShowInTerminal(string blockName, bool showInTerminal = true)
```

##### Parameters

Type

Name

Description

System.String

blockName

System.Boolean

showInTerminal

#### SetBlockShowOnHUD(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Sets whether or not terminal block should be seen in HUD.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetBlockShowOnHUD(string blockName, bool showOnHUD = true)
```

##### Parameters

Type

Name

Description

System.String

blockName

System.Boolean

showOnHUD

#### SetCampaignLevelOutcome(String)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "[Obsolete, use SetMissionOutcome] Sets the state of campaign. Necessary for transitions between missions in campaign.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetCampaignLevelOutcome(string outcome)
```

##### Parameters

Type

Name

Description

System.String

outcome

#### SetCell(String, String, String, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Set cell text in the board screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetCell(string boardId, string rowId, string columnId, string text, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.String

rowId

System.String

columnId

System.String

text

System.Int64

playerId

#### SetChatMaxMessageCount(Int32)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "[Obsolete] Sets maximum count of messages in chat. [Has no effect anymore as whole history is being kept. Number of shown messages is dependant on number of rows they cover.]", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetChatMaxMessageCount(int count = 10)
```

##### Parameters

Type

Name

Description

System.Int32

count

#### SetChatMessageDuration(Int32)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "Sets for how long chat messages should be shown before fading out.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetChatMessageDuration(int durationS = 10)
```

##### Parameters

Type

Name

Description

System.Int32

durationS

#### SetColumnVisibility(String, String, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Set column visible state.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetColumnVisibility(string boardId, string columnId, bool visible, long playerId = -1L)
```
