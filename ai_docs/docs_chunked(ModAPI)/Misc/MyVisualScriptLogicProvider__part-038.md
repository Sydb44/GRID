Description

System.String

boardId

System.String

columnId

System.Int64

playerId

#### SkinBlock(String, String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Sets skin of specific block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SkinBlock(string blockName, string skin)
```

##### Parameters

Type

Name

Description

System.String

blockName

System.String

skin

#### SkipCutscene(Int64)

##### Declaration

```
[VisualScriptingMiscData("Cutscenes", "Skips current cutscene. If 'playerId' is -1, apply for all players, otherwise only for specific player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SkipCutscene(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### SkipCutsceneLocal(Int64)

##### Declaration

```
public static void SkipCutsceneLocal(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### SortByColumn(String, String, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Set row ranking used for sorting.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SortByColumn(string boardId, string columnId, bool ascending, long playerId = -1L)
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

ascending

System.Int64

playerId

#### SortByRanking(String, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Set row ranking used for sorting.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SortByRanking(string boardId, bool ascending, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.Boolean

ascending

System.Int64

playerId

#### SpawnBot(String, Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Spawn", "Spawns the bot at the specified position.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SpawnBot(string subtypeName, Vector3D position)
```

##### Parameters

Type

Name

Description

System.String

subtypeName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### SpawnBot(String, Vector3D, Vector3D, Vector3D, String)

##### Declaration

```
[VisualScriptingMiscData("Spawn", "Spawns the bot at the specified position, orientation and specific data.", -10510688)]
[VisualScriptingMember(true, false)]
public static long SpawnBot(string subtypeName, Vector3D position, Vector3D direction, Vector3D up, string name)
```

##### Parameters

Type

Name

Description

System.String

subtypeName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

direction

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

up

System.String

name

##### Returns

Type

Description

System.Int64

#### SpawnGroup(String, Vector3D, Vector3D, Vector3D, Int64, String)

##### Declaration

```
[VisualScriptingMiscData("Spawn", "Spawns the group of prefabs at the specified position.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SpawnGroup(string subtypeId, Vector3D position, Vector3D direction, Vector3D up, long ownerId = 0L, string newGridName = null)
```

##### Parameters

Type

Name

Description

System.String

subtypeId

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

direction

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

up

System.Int64

ownerId

System.String

newGridName

#### SpawnItem(MyDefinitionId, Vector3D, String, Single)

##### Declaration

```
[VisualScriptingMiscData("Spawn", "Spawns the item at the specified position.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SpawnItem(MyDefinitionId itemId, Vector3D position, string inheritsVelocityFrom = "", float amount = 1F)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.String

inheritsVelocityFrom

System.Single

amount

#### SpawnLocalBlueprint(String, Vector3D, Vector3D, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Spawn", "Spawns local blueprint at the specified position.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SpawnLocalBlueprint(string name, Vector3D position, Vector3D direction = null, string newGridName = null, long ownerId = 0L)
```

##### Parameters

Type

Name

Description

System.String

name

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

direction

System.String

newGridName

System.Int64

ownerId

#### SpawnLocalBlueprintInGravity(String, Vector3D, Single, Single, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Spawn", "Spawns local blueprint at the specified position and aligned to gravity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void SpawnLocalBlueprintInGravity(string name, Vector3D position, float rotationAngle = 0F, float gravityOffset = 0F, string newGridName = null, long ownerId = 0L)
```

##### Parameters

Type

Name

Description

System.String

name

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Single

rotationAngle

System.Single

gravityOffset

System.String

newGridName

System.Int64

ownerId
