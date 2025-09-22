##### Parameters

Type

Name

Description

System.String

categoryName

#### MusicSetMusicCategoryLocal(String)

##### Declaration

```
public static void MusicSetMusicCategoryLocal(string categoryName)
```

##### Parameters

Type

Name

Description

System.String

categoryName

#### NextCutsceneNode(Int64)

##### Declaration

```
[VisualScriptingMiscData("Cutscenes", "Goes to next node in current cutscene. If 'playerId' is -1, apply for all players, otherwise only for specific player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void NextCutsceneNode(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### NextCutsceneNodeLocal(Int64)

##### Declaration

```
public static void NextCutsceneNodeLocal(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### OpenFactionVictoryScreenAll(String, Single)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Open Player screen to all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void OpenFactionVictoryScreenAll(string factionTag, float timeInSec)
```

##### Parameters

Type

Name

Description

System.String

factionTag

System.Single

timeInSec

#### OpenFactionVictoryScreenAllBroadcast(String, Single)

##### Declaration

```
[Event(null, 6085)]
[Reliable]
[ServerInvoked]
[Broadcast]
public static void OpenFactionVictoryScreenAllBroadcast(string factionTag, float timeInSec)
```

##### Parameters

Type

Name

Description

System.String

factionTag

System.Single

timeInSec

#### OpenPlayerScreenAll()

##### Declaration

```
[VisualScriptingMiscData("GUI", "Open Player screen to all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void OpenPlayerScreenAll()
```

#### OpenPlayerScreenAllBroadcast()

##### Declaration

```
[Event(null, 6063)]
[Reliable]
[ServerInvoked]
[Broadcast]
public static void OpenPlayerScreenAllBroadcast()
```

#### OpenSteamOverlay(String, Int64)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Opens service overlay. If playerID is 0, open it for local player else open it for targeted player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void OpenSteamOverlay(string url, long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.String

url

System.Int64

playerId

#### OpenSteamOverlayLocal(String)

##### Declaration

```
public static void OpenSteamOverlayLocal(string url)
```

##### Parameters

Type

Name

Description

System.String

url

#### PlayerResearchClear(Int64)

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Resets research for the specific player. If 'playerId' equals -1, resets research for the local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void PlayerResearchClear(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### PlayerResearchClearAll()

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Resets research for all.", -10510688)]
[VisualScriptingMember(true, false)]
public static void PlayerResearchClearAll()
```

#### PlayerResearchLock(Int64, MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Locks the specific research for the specific player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void PlayerResearchLock(long playerId, MyDefinitionId itemId)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

#### PlayerResearchUnlock(Int64, MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("G-Screen", "Unlocks the specific research for the specific player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void PlayerResearchUnlock(long playerId, MyDefinitionId itemId)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

#### PlayHudSound(MyGuiSounds, Int64)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Plays specific 2D HUD sound.", -10510688)]
[VisualScriptingMember(true, false)]
public static void PlayHudSound(MyGuiSounds sound, long playerId = 0L)
```

##### Parameters

Type

Name

Description

VRage.Audio.MyGuiSounds

sound

System.Int64

playerId

#### PlayHudSoundLocal(MyGuiSounds, Int64)

##### Declaration

```
public static void PlayHudSoundLocal(MyGuiSounds sound, long playerId = 0L)
```

##### Parameters

Type

Name

Description

VRage.Audio.MyGuiSounds

sound

System.Int64

playerId

#### PlaySingleSoundAtEntity(String, String)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Plays single sound on emitter attached to specific entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void PlaySingleSoundAtEntity(string soundName, string entityName)
```

##### Parameters

Type

Name

Description

System.String

soundName

System.String

entityName

#### PlaySingleSoundAtEntityLocal(String, String)

##### Declaration

```
public static void PlaySingleSoundAtEntityLocal(string soundName, string entityName)
```

##### Parameters

Type

Name

Description

System.String

soundName

System.String

entityName

#### PlaySingleSoundAtPosition(String, Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Plays specific 3D sound at specific point.", -10510688)]
[VisualScriptingMember(true, false)]
public static void PlaySingleSoundAtPosition([Nullable] string soundName, Vector3D position)
```

##### Parameters

Type

Name

Description

System.String

soundName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### PlaySingleSoundAtPositionLocal(String, Vector3D)

##### Declaration

```
public static void PlaySingleSoundAtPositionLocal(string soundName, Vector3D position)
```
