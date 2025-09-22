System.Int32

durationS

#### SetColumnVisibility(String, String, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Set column visible state.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetColumnVisibility(string boardId, string columnId, bool visible, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.String

columnId

System.Boolean

visible

System.Int64

playerId

#### SetCustomLoadingScreenImage(String)

##### Declaration

```
[VisualScriptingMiscData("Misc", "Sets custom image for a loading screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetCustomLoadingScreenImage(string imagePath)
```

##### Parameters

Type

Name

Description

System.String

imagePath

#### SetCustomLoadingScreenText(String)

##### Declaration

```
[VisualScriptingMiscData("Misc", "Sets custom loading text for a loading screen", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetCustomLoadingScreenText(string text)
```

##### Parameters

Type

Name

Description

System.String

text

#### SetCustomSkybox(String)

##### Declaration

```
[VisualScriptingMiscData("Misc", "Sets custom skybox for the current game.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetCustomSkybox(string skyboxPath)
```

##### Parameters

Type

Name

Description

System.String

skyboxPath

#### SetDampenersEnabled(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Turns dampeners of specific entity on/off.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetDampenersEnabled(string entityName, bool state)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

state

#### SetDisabledByExperimental(MyGuiControlBase)

##### Declaration

```
public static void SetDisabledByExperimental(this MyGuiControlBase control)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiControlBase

control

#### SetDroneBehaviourAdvanced(String, String, Boolean, Boolean, List<MyEntity>, Boolean, List<MyEntity>)

##### Declaration

```
[VisualScriptingMiscData("AI", "Adds specific drone behavior from preset to a drone. (Extended parameters)", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetDroneBehaviourAdvanced(string entityName, string presetName = "Default", bool activate = true, bool assignToPirates = true, List<MyEntity> waypoints = null, bool cycleWaypoints = false, List<MyEntity> targets = null)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

presetName

System.Boolean

activate

System.Boolean

assignToPirates

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

waypoints

System.Boolean

cycleWaypoints

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

targets

#### SetDroneBehaviourBasic(String, String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Adds specific drone behavior from preset to a drone. (Reduced parameters)", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetDroneBehaviourBasic(string entityName, string presetName = "Default")
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

presetName

#### SetDroneBehaviourFull(String, String, Boolean, Boolean, List<MyEntity>, Boolean, List<MyEntity>, Int32, Single, TargetPrioritization)

##### Declaration

```
[VisualScriptingMiscData("AI", "Adds specific drone behavior from preset to a drone. (Full parameters)", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetDroneBehaviourFull(string entityName, string presetName = "Default", bool activate = true, bool assignToPirates = true, List<MyEntity> waypoints = null, bool cycleWaypoints = false, List<MyEntity> targets = null, int playerPriority = 10, float maxPlayerDistance = 10000F, TargetPrioritization prioritizationStyle)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

presetName

System.Boolean

activate

System.Boolean

assignToPirates

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

waypoints

System.Boolean

cycleWaypoints

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

targets

System.Int32

playerPriority

System.Single

maxPlayerDistance

VRage.Game.ObjectBuilders.AI.TargetPrioritization

prioritizationStyle

#### SetEnabledByExperimental(MyGuiControlBase)

##### Declaration

```
public static void SetEnabledByExperimental(this MyGuiControlBase control)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiControlBase

control

#### SetEntityPosition(String, Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Sets world position of specific entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetEntityPosition(string entityName, Vector3D position)
```

##### Parameters

Type

Name

Description

System.String

entityName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### SetFactionObjectivePercentageCompleted(Int64, Single)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Changes escape pod finished percentage in scoreCounter.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetFactionObjectivePercentageCompleted(long factionId, float finished)
```

##### Parameters

Type

Name

Description

System.Int64

factionId

System.Single

finished

#### SetFactionScore(Int64, Int32)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Changes faction Score", -10510688)]
[VisualScriptingMember(true, false)]
public static void SetFactionScore(long factionId, int score)
```
