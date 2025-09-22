System.Int64

playerId

#### SetHighlightForAll(String, Boolean, Int32, Int32, Color, String)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Enables/disables highlight of specific object for all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetHighlightForAll(string entityName, bool enabled = true, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, string subPartNames = null)
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

#### SetHighlightForProjection(String, Boolean, Int32, Int32, Color, Int64)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Sets projection highlight for the specific projector block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetHighlightForProjection(string projectorName, bool enabled = true, int thickness = 5, int pulseTimeInFrames = 120, Color color = null, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

projectorName

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

#### SetHighlightLocal(String, Int32, Int32, Color, Int64, String)

##### Declaration

```
public static void SetHighlightLocal(string entityName, int thickness = 10, int pulseTimeInFrames = 120, Color color = null, long playerId = -1L, string subPartNames = null)
```

##### Parameters

Type

Name

Description

System.String

entityName

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

#### SetHudState(Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Set state of HUD to specific state. 0 - minimal hud.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetHudState(int state = 0, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

state

System.Int64

playerId

#### SetLandingGearLock(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Sets lock state of specific Landing gear.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetLandingGearLock(string entityName, bool locked = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

locked

#### SetLigtingBlockColor(String, Color)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Sets color of specific Lighting block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetLigtingBlockColor(string lightBlockName, Color color)
```

##### Parameters

Type

Name

Description

System.String

lightBlockName

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

#### SetLigtingBlockIntensity(String, Single)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Sets intensity of specific Lighting block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetLigtingBlockIntensity(string lightBlockName, float intensity)
```

##### Parameters

Type

Name

Description

System.String

lightBlockName

System.Single

intensity

#### SetLigtingBlockRadius(String, Single)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Sets radius of specific Lighting block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetLigtingBlockRadius(string lightBlockName, float radius)
```

##### Parameters

Type

Name

Description

System.String

lightBlockName

System.Single

radius

#### SetMatchIsRunningState(Boolean)

##### Declaration

```
[VisualScriptingMiscData("Other", "Sets whether match component should be runing or not. When component is running, remaining time of the state will be ticking out and states will be changing. If component is not running, it will be effectively paused until running again.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetMatchIsRunningState(bool isRunning)
```

##### Parameters

Type

Name

Description

System.Boolean

isRunning

#### SetMatchStateRemainingDuration(Single)

##### Declaration

```
[VisualScriptingMiscData("Other", "Set remaining time of the current match state. Time is in minutes. If the value is lower or equal to zero, next match phase will start.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetMatchStateRemainingDuration(float time)
```

##### Parameters

Type

Name

Description

System.Single

time

#### SetMissionOutcome(String)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Sets the state of the mission. Necessary for transitions between missions in the scenario.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetMissionOutcome(string outcome = "Mission Complete")
```

##### Parameters

Type

Name

Description

System.String

outcome

#### SetName(Int64, String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets name of specific entity defined by id.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetName(long entityId, string name)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

System.String

name

#### SetPage(MyGuiControlTabControl, Int32)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Changes selected page of TabControl element to specific page.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetPage(this MyGuiControlTabControl pageControl, int pageNumber)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiControlTabControl

pageControl

System.Int32

pageNumber
