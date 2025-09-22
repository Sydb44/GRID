Description

System.String

entityName

System.String

key

System.Collections.Generic.List<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

value

#### SunRotationEnabled(Boolean)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Enables/disable sun rotation.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SunRotationEnabled(bool enabled)
```

##### Parameters

Type

Name

Description

System.Boolean

enabled

#### SunRotationGetCurrentTime()

##### Declaration

```
[VisualScriptingMiscData("Environment", "Gets current time of day.", -10510688)]
[VisualScriptingMember(false, false)]
public static float SunRotationGetCurrentTime()
```

##### Returns

Type

Description

System.Single

#### SunRotationGetDayLength()

##### Declaration

```
[VisualScriptingMiscData("Environment", "Gets length of day.", -10510688)]
[VisualScriptingMember(false, false)]
public static float SunRotationGetDayLength()
```

##### Returns

Type

Description

System.Single

#### SunRotationSetDayLength(Single)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Sets length of day.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SunRotationSetDayLength(float length)
```

##### Parameters

Type

Name

Description

System.Single

length

#### SunRotationSetTime(Single)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Sets time of day.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SunRotationSetTime(float time)
```

##### Parameters

Type

Name

Description

System.Single

time

#### SwitchToolbarToSlot(Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("Toolbar", "Switches the specified toolbar slot for the player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SwitchToolbarToSlot(int slot, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

slot

System.Int64

playerId

#### SwitchToolbarToSlotLocal(Int32, Int64)

##### Declaration

```
public static void SwitchToolbarToSlotLocal(int slot, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

slot

System.Int64

playerId

#### TakeScreenshot(String, String)

##### Declaration

```
[VisualScriptingMiscData("Misc", "Takes a screenshot and saves it to specific destination.", -10510688)]
[VisualScriptingMember(true, false)]
public static void TakeScreenshot(string destination, string name)
```

##### Parameters

Type

Name

Description

System.String

destination

System.String

name

#### TargetingSetWhitelist(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("AI", "Sets whitelist targeting mode. If true, entities in whitelist will be considered a target, if false, entities not in whitelist will be considered a target.", -10510688)]
[VisualScriptingMember(true, false)]
public static void TargetingSetWhitelist(string gridName, bool whitelistMode = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

whitelistMode

#### ToggleAbilityToSprint(Int64, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Player", "Toggles the players ability to sprint", -10510688)]
[VisualScriptingMember(true, false)]
public static void ToggleAbilityToSprint(long playerId = 0L, bool canSprint = true)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Boolean

canSprint

#### ToggleAbilityToSprintSync(Int64, Boolean)

##### Declaration

```
[Event(null, 7116)]
[Reliable]
[ServerInvoked]
[Broadcast]
public static void ToggleAbilityToSprintSync(long playerId = 0L, bool canSprint = true)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Boolean

canSprint

#### TogglePlayersBroadcastEnabling(Int64, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Player", "Toggle player's ability to toggle broadcasting. Server still can change player's broadcasting state.", -10510688)]
[VisualScriptingMember(true, false)]
public static void TogglePlayersBroadcastEnabling(long playerId = 0L, bool enabled = true)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Boolean

enabled

#### TogglePlayersBroadcasting(Int64, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Player", "Toggle broadcasting for the player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void TogglePlayersBroadcasting(long playerId = 0L, bool enabled = true)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.Boolean

enabled

#### ToolbarConfigGroupsDefualtBehavior()

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Sets group mode of toolbar config screen (G-screen) to Default.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ToolbarConfigGroupsDefualtBehavior()
```

#### ToolbarConfigGroupsHideAll()

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Sets group mode of toolbar config screen (G-screen) to Hide all.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ToolbarConfigGroupsHideAll()
```

#### ToolbarConfigGroupsHideBlockGroups()

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Sets group mode of toolbar config screen (G-screen) to Hide block groups.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ToolbarConfigGroupsHideBlockGroups()
```

#### ToolbarConfigGroupsHideEmpty()

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Sets group mode of toolbar config screen (G-screen) to Hide empty groups.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ToolbarConfigGroupsHideEmpty()
```

#### TriggerTimerBlock(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Calls 'TriggerNow' action on specific functional block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void TriggerTimerBlock(string blockName)
```

##### Parameters

Type

Name

Description

System.String

blockName
