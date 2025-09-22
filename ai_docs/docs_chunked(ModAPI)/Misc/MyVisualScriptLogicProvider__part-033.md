System.Boolean

showInInventory

#### SetGridBlocksShowInTerminal(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets all terminal blocks of specified grid to be (not) shown in terminal screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridBlocksShowInTerminal(string gridName, bool showInTerminal = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

showInTerminal

#### SetGridBlocksShowOnHUD(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets all terminal blocks of specified grid to be (not) shown on HUD.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridBlocksShowOnHUD(string gridName, bool showOnHUD = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

showOnHUD

#### SetGridDestructible(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Un/Marks the specific grid as destructible. Such grid cannot be destroyed, but can be grinded", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridDestructible(string entityName, bool destructible = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

destructible

#### SetGridEditable(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Un/Marks the specific grid as editable.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridEditable(string entityName, bool editable = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

editable

#### SetGridGeneralDamageModifier(String, Single)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets grid general damage modifier that multiplies all damage received by that grid.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridGeneralDamageModifier(string gridName, float modifier = 1F)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Single

modifier

#### SetGridImmune(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Un/Marks the specific grid as immune. Such grid cannot be destroyed or grinded.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridImmune(string entityName, bool immune = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

immune

#### SetGridLandingGearsLock(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets state of Landing gears for whole grid.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridLandingGearsLock(string gridName, bool gearLock = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

gearLock

#### SetGridPowerState(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets grid's power state.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridPowerState(string gridName, bool enabled)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

enabled

#### SetGridPowerStateByPlayer(String, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets grid's power state by the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridPowerStateByPlayer(string gridName, bool enabled, long playerId)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

enabled

System.Int64

playerId

#### SetGridReactors(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Turns reactors of specific grid on/off.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridReactors(string gridName, bool turnOn = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

turnOn

#### SetGridStatic(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets the specific grid as static/dynamic.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridStatic(string gridName, bool isStatic = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

isStatic

#### SetGridWeaponStatus(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Enables/disables all weapons(MyUserControllableGun) on the specific grid.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridWeaponStatus(string gridName, bool enabled = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

enabled

#### SetHighlight(String, Boolean, Int32, Int32, Color, Int64, String)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight of specific object for local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetHighlight([Nullable] string entityName, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, long playerId = -1L, [Nullable] string subPartNames = null)
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

#### SetHighlight(MyHighlightData, Int64)

##### Declaration

```
public static void SetHighlight(MyHighlightData highlightData, long playerId)
```

##### Parameters

Type

Name

Description

VRage.Game.ObjectBuilders.Gui.MyHighlightData

highlightData

System.Int64

playerId

#### SetHighlightForAll(String, Boolean, Int32, Int32, Color, String)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight of specific object for all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetHighlightForAll(string entityName, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, string subPartNames = null)
```
