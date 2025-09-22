soundName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### PlaySingleSoundAtPositionLocal(String, Vector3D)

##### Declaration

```
public static void PlaySingleSoundAtPositionLocal(string soundName, Vector3D position)
```

##### Parameters

Type

Name

Description

System.String

soundName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### PlaySound(String, String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Plays sound on specific emitter. If 'playIn2D' is true, sound will be forced 2D.", -10510688)]
[VisualScriptingMember(true, false)]
public static void PlaySound([Nullable] string emitterId, string soundName, bool playIn2D = false)
```

##### Parameters

Type

Name

Description

System.String

emitterId

System.String

soundName

System.Boolean

playIn2D

#### PlaySoundAmbient(String)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Play ambient 2D sound.", -10510688)]
[VisualScriptingMember(true, false)]
public static void PlaySoundAmbient(string soundName)
```

##### Parameters

Type

Name

Description

System.String

soundName

#### PlaySoundAmbientLocal(String)

##### Declaration

```
public static void PlaySoundAmbientLocal(string soundName)
```

##### Parameters

Type

Name

Description

System.String

soundName

#### PlaySoundLocal(String, String, Boolean)

##### Declaration

```
public static void PlaySoundLocal([Nullable] string emitterId, string soundName, bool playIn2D = false)
```

##### Parameters

Type

Name

Description

System.String

emitterId

System.String

soundName

System.Boolean

playIn2D

#### ReloadToolbarDefaults(Int64)

##### Declaration

```
[VisualScriptingMiscData("Toolbar", "Reloads default settings for the toolbar", -10510688)]
[VisualScriptingMember(true, false)]
public static void ReloadToolbarDefaults(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### ReloadToolbarDefaultsLocal(Int64)

##### Declaration

```
public static void ReloadToolbarDefaultsLocal(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### RemoveAllTriggersFromEntity(String)

##### Declaration

```
[VisualScriptingMiscData("Triggers", "Removes all area triggers from the specified entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveAllTriggersFromEntity(string entityName)
```

##### Parameters

Type

Name

Description

System.String

entityName

#### RemoveBoardScreen(String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Remove board screen with specific id. PlayerId -1 stands for all players, 0 for local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveBoardScreen(string boardId, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.Int64

playerId

#### RemoveColumn(String, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Remove column from board screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveColumn(string boardId, string columnId, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.String

columnId

System.Int64

playerId

#### RemoveContract(Int64)

##### Declaration

```
[VisualScriptingMiscData("Contract", "Remove inactive contract. Does not work if contract has already been accepted.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool RemoveContract(long id)
```

##### Parameters

Type

Name

Description

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### RemoveEntities(Vector3D, Double, Boolean, Boolean, String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Removes entities in designated area.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveEntities(Vector3D position, double radius, bool removePlanets = true, bool removeGroup = true, string typeRestriction = null)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Double

radius

System.Boolean

removePlanets

System.Boolean

removeGroup

System.String

typeRestriction

#### RemoveEntity(Int64, Boolean, String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Removes specific entity from world.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveEntity(long entityId, bool removeGroup = true, string typeRestriction = null)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

System.Boolean

removeGroup

System.String

typeRestriction

#### RemoveEntity(String, Boolean, String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Removes specific entity from world.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveEntity(string entityName, bool removeGroup = true, string typeRestriction = null)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

removeGroup

System.String

typeRestriction

#### RemoveEntity(MyEntity, Boolean, String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Removes specific entity from world.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveEntity(MyEntity entity, bool removeGroup = true, string typeRestriction = null)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

System.Boolean

removeGroup

System.String

typeRestriction

#### RemoveFromEntityInventory(String, MyDefinitionId, Single)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Removes item defined by id in specific quantity from inventory of entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveFromEntityInventory(string entityName, MyDefinitionId itemId = null, float amount = 1F)
```
