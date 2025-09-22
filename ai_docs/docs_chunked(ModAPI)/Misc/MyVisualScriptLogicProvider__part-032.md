System.Single

finished

#### SetFactionScore(Int64, Int32)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Changes faction Score", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetFactionScore(long factionId, int score)
```

##### Parameters

Type

Name

Description

System.Int64

factionId

System.Int32

score

#### SetGPSColor(String, Color, Int64)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Sets color of GPS for specific player. If 'playerId' is less or equal to 0, GPS will be modified for local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGPSColor(string name, Color newColor, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

name

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

newColor

System.Int64

playerId

#### SetGPSHighlight(String, String, String, Color, Boolean, Int32, Int32, Color, Int64, String)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight for specific entity and creates/deletes GPS attached to it. For local player only.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGPSHighlight(string entityName, string GPSName, string GPSDescription, Color GPSColor, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, long playerId = -1L, string subPartNames = null)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

GPSName

System.String

GPSDescription

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

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

#### SetGPSHighlightForAll(String, String, String, Color, Boolean, Int32, Int32, Color, String)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight for specific entity and creates/deletes GPS attached to it. For all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGPSHighlightForAll(string entityName, string GPSName, string GPSDescription, Color GPSColor, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, string subPartNames = null)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

GPSName

System.String

GPSDescription

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

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

#### SetGPSHighlightNoSound(String, String, String, Color, Boolean, Int32, Int32, Color, Int64, String)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight for specific entity and creates/deletes GPS attached to it. For local player only.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGPSHighlightNoSound(string entityName, string GPSName, string GPSDescription, Color GPSColor, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, long playerId = -1L, string subPartNames = null)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

GPSName

System.String

GPSDescription

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

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

#### SetGPSHighlightNoSoundForAll(String, String, String, Color, Boolean, Int32, Int32, Color, String)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight for specific entity and creates/deletes GPS attached to it. For all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGPSHighlightNoSoundForAll(string entityName, string GPSName, string GPSDescription, Color GPSColor, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, string subPartNames = null)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

GPSName

System.String

GPSDescription

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

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

#### SetGridBlocksEnabled(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Enables/disables all functional blocks on the specified grid.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridBlocksEnabled(string gridName, bool enabled = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

enabled

#### SetGridBlocksShowInInventory(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets all terminal blocks of specified grid to be (not) shown in inventory screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridBlocksShowInInventory(string gridName, bool showInInventory = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

showInInventory

#### SetGridBlocksShowInTerminal(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets all terminal blocks of specified grid to be (not) shown in terminal screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetGridBlocksShowInTerminal(string gridName, bool showInTerminal = true)
```
