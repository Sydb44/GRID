rotationAngle

System.Single

gravityOffset

System.String

newGridName

System.Int64

ownerId

#### SpawnPlayer(MatrixD, Vector3D, Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Spawns player on the specified position.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SpawnPlayer(MatrixD worldMatrix, Vector3D velocity = null, long playerId = 0L)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

velocity

System.Int64

playerId

#### SpawnPrefab(String, Vector3D, Vector3D, Vector3D, Int64, String, String, SpawningOptions)

##### Declaration

```
[VisualScriptingMiscData("Spawn", "Spawns the prefab at the specified position.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SpawnPrefab(string prefabName, Vector3D position, Vector3D direction, Vector3D up, long ownerId = 0L, string beaconName = null, string entityName = null, SpawningOptions spawningOptions)
```

##### Parameters

Type

Name

Description

System.String

prefabName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

direction

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

up

System.Int64

ownerId

System.String

beaconName

System.String

entityName

[SpawningOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.SpawningOptions.html)

spawningOptions

#### SpawnPrefabInGravity(String, Vector3D, Vector3D, Int64, String, String, Single, Single, SpawningOptions)

##### Declaration

```
[VisualScriptingMiscData("Spawn", "Spawns the prefab at the specified position aligned to gravity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SpawnPrefabInGravity(string prefabName, Vector3D position, Vector3D direction, long ownerId = 0L, string beaconName = null, string entityName = null, float gravityOffset = 0F, float gravityRotation = 0F, SpawningOptions spawningOptions)
```

##### Parameters

Type

Name

Description

System.String

prefabName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

direction

System.Int64

ownerId

System.String

beaconName

System.String

entityName

System.Single

gravityOffset

System.Single

gravityRotation

[SpawningOptions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.SpawningOptions.html)

spawningOptions

#### StartCutscene(String, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Cutscenes", "Starts specific cutscene. If 'playerId' is -1, apply for all players, otherwise only for specific player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void StartCutscene(string cutsceneName, bool registerEvents = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

cutsceneName

System.Boolean

registerEvents

System.Int64

playerId

#### StartCutsceneLocal(String, Boolean, Int64)

##### Declaration

```
public static void StartCutsceneLocal(string cutsceneName, bool registerEvents = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

cutsceneName

System.Boolean

registerEvents

System.Int64

playerId

#### StartGameplayTimer(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Timers", "Start a timer with a specified key.", -10510688)]
[VisualScriptingMember(true, false)]
public static void StartGameplayTimer(string key, bool reset)
```

##### Parameters

Type

Name

Description

System.String

key

System.Boolean

reset

#### StartStateMachine(String, Int64)

##### Declaration

```
[VisualScriptingMiscData("State Machines", "Starts the specified state machine.", -10510688)]
[VisualScriptingMember(true, false)]
public static void StartStateMachine(string stateMachineName, long ownerId = 0L)
```

##### Parameters

Type

Name

Description

System.String

stateMachineName

System.Int64

ownerId

#### StartTimerBlock(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Calls 'Start' action on specific functional block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void StartTimerBlock(string blockName)
```

##### Parameters

Type

Name

Description

System.String

blockName

#### StopDedicatedServer()

##### Declaration

```
[VisualScriptingMember(true, false)]
[VisualScriptingMiscData("Gameplay", "Stop dedicated server (autorestart if enabled).", -10510688)]
public static void StopDedicatedServer()
```

#### StopGameplayTimer(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Timers", "Stop timer running.", -10510688)]
[VisualScriptingMember(true, false)]
public static void StopGameplayTimer(string key, bool reset = false)
```

##### Parameters

Type

Name

Description

System.String

key

System.Boolean

reset

#### StopSound(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Stops sound played by specific emitter.", -10510688)]
[VisualScriptingMember(true, false)]
public static void StopSound([Nullable] string emitterId, bool forced = false)
```

##### Parameters

Type

Name

Description

System.String

emitterId

System.Boolean

forced

#### StopSoundLocal(String, Boolean)

##### Declaration

```
public static void StopSoundLocal(string emitterId, bool forced = false)
```

##### Parameters

Type

Name

Description

System.String

emitterId

System.Boolean

forced

#### StopTimerBlock(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Calls 'Stop' action on specific functional block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void StopTimerBlock(string blockName)
```
