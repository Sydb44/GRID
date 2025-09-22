Type

Name

Description

System.String

entityName

System.Boolean

cycleWaypoints

#### EnableBlock(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Enables functional block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void EnableBlock(string blockName)
```

##### Parameters

Type

Name

Description

System.String

blockName

#### EnableCustomRespawn(Boolean, Int64)

##### Declaration

```
[VisualScriptingMember(true, false)]
[VisualScriptingMiscData("Gameplay", "Enable custom respawn. Needed for PlayerRequestsRespawn to work properly.", -10510688)]
public static void EnableCustomRespawn(bool enable = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

enable

System.Int64

playerId

#### EnableHighlight(Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Enables highlight of the questlog for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void EnableHighlight(bool enable = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

enable

System.Int64

playerId

#### EnableHighlightLocal(Boolean, Int64)

##### Declaration

```
public static void EnableHighlightLocal(bool enable = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Boolean

enable

System.Int64

playerId

#### EnableSaving(Boolean)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Allows all players to save", -10510688)]
[VisualScriptingMember(true, false)]
public static void EnableSaving(bool enable)
```

##### Parameters

Type

Name

Description

System.Boolean

enable

#### EnableSavingLocal(Boolean)

##### Declaration

```
public static void EnableSavingLocal(bool enable)
```

##### Parameters

Type

Name

Description

System.Boolean

enable

#### EnableTerminal(Boolean)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Enables terminal screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void EnableTerminal(bool flag)
```

##### Parameters

Type

Name

Description

System.Boolean

flag

#### EnableToolbarConfig(Boolean)

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Enables/disables toolbar config screen (G-screen).", -10510688)]
[VisualScriptingMember(true, false)]
public static void EnableToolbarConfig(bool flag)
```

##### Parameters

Type

Name

Description

System.Boolean

flag

#### EndCutscene(Int64)

##### Declaration

```
[VisualScriptingMiscData("Cutscenes", "Ends current cutscene. If 'playerId' is -1, apply for all players, otherwise only for specific player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void EndCutscene(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### EndCutsceneLocal(Int64)

##### Declaration

```
public static void EndCutsceneLocal(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### EntityExists(String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Returns true if specific entity is present in the world.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool EntityExists(string entityName)
```

##### Parameters

Type

Name

Description

System.String

entityName

##### Returns

Type

Description

System.Boolean

#### FindFreePlace(Vector3D, out Vector3D, Single, Int32, Int32, Single)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Finds free place around the specified position.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool FindFreePlace(Vector3D position, out Vector3D newPosition, float radius, int maxTestCount = 20, int testsPerDistance = 5, float stepSize = 1F)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

newPosition

System.Single

radius

System.Int32

maxTestCount

System.Int32

testsPerDistance

System.Single

stepSize

##### Returns

Type

Description

System.Boolean

#### FinishMission(String, Int32)

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Finishes active mission (state Mission Complete) with fadeout (ms).", -10510688)]
[VisualScriptingMember(true, false)]
public static void FinishMission(string outcome = "Mission Complete", int fadeTimeMs = 5000)
```

##### Parameters

Type

Name

Description

System.String

outcome

System.Int32

fadeTimeMs

#### FogSetAll(Nullable<Single>, Nullable<Single>, Nullable<Vector3>, Nullable<Single>, Nullable<Single>)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Sets density, multiplier, color, skybox multiplier, and atmosphere multiplier of fog.", -10510688)]
[VisualScriptingMember(true, false)]
public static void FogSetAll(Nullable<float> density, Nullable<float> multiplier, Nullable<Vector3> color, Nullable<float> skyboxMultiplier, Nullable<float> atmoMultiplier)
```

##### Parameters

Type

Name

Description

System.Nullable<System.Single\>

density

System.Nullable<System.Single\>

multiplier

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

color

System.Nullable<System.Single\>

skyboxMultiplier

System.Nullable<System.Single\>

atmoMultiplier

#### FogSetAtmoMultiplier(Single)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Sets atmosphere multiplier of fog.", -10510688)]
[VisualScriptingMember(true, false)]
public static void FogSetAtmoMultiplier(float atmoMultiplier)
```

##### Parameters

Type

Name

Description

System.Single

atmoMultiplier

#### FogSetColor(Vector3)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Sets color of fog.", -10510688)]
[VisualScriptingMember(true, false)]
public static void FogSetColor(Vector3 color)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

color
