Description

System.Boolean

#### IsPlayerDead(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Checks if player is dead.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsPlayerDead(long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

##### Returns

Type

Description

System.Boolean

#### IsPlayerInCockpit(Int64, String, String)

##### Declaration

```
[VisualScriptingMiscData("Player", "Checks if player is in cockpit.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsPlayerInCockpit(long playerId = 0L, string gridName = null, string cockpitName = null)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.String

gridName

System.String

cockpitName

##### Returns

Type

Description

System.Boolean

#### IsPlayerInRemote(Int64, String, String)

##### Declaration

```
[VisualScriptingMiscData("Player", "Checks if player is controlling something over remote.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsPlayerInRemote(long playerId = 0L, string gridName = null, string remoteName = null)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.String

gridName

System.String

remoteName

##### Returns

Type

Description

System.Boolean

#### IsPlayerInWeapon(Int64, String, String)

##### Declaration

```
[VisualScriptingMiscData("Player", "Checks if player is controlling weapon.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsPlayerInWeapon(long playerId = 0L, string gridName = null, string weaponName = null)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

System.String

gridName

System.String

weaponName

##### Returns

Type

Description

System.Boolean

#### IsPlayersJetpackEnabled(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Checks if player's jetpack is enabled.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsPlayersJetpackEnabled(long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

##### Returns

Type

Description

System.Boolean

#### IsSavingEnabled()

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Allows all players to save", -10510688)]
public static bool IsSavingEnabled()
```

##### Returns

Type

Description

System.Boolean

#### IsSurvival()

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Returns true if world is survival.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsSurvival()
```

##### Returns

Type

Description

System.Boolean

#### IsUnderGround(Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Returns true if position is underground", -10510688)]
[VisualScriptingMember(true, false)]
public static bool IsUnderGround(Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

##### Returns

Type

Description

System.Boolean

#### JoinResult(JoinResult)

##### Declaration

```
[VisualScriptingMember(false, false)]
[VisualScriptingMiscData("Other", "Enum constants", -10510688)]
public static JoinResult JoinResult(JoinResult value)
```

##### Parameters

Type

Name

Description

VRage.Network.JoinResult

value

##### Returns

Type

Description

VRage.Network.JoinResult

#### KickPlayer(UInt64, Boolean, Boolean)

##### Declaration

```
[VisualScriptingMember(true, false)]
[VisualScriptingMiscData("Gameplay", "Kick player.", -10510688)]
public static void KickPlayer(ulong steamId, bool kick = true, bool add = true)
```

##### Parameters

Type

Name

Description

System.UInt64

steamId

System.Boolean

kick

System.Boolean

add

#### KickPlayerFromFaction(Int64)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Kicks specific player from faction he is in.", -10510688)]
[VisualScriptingMember(true, false)]
public static void KickPlayerFromFaction(long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### LoadEntityBool(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads boolean from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool LoadEntityBool(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Boolean

#### LoadEntityBoolList(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads boolean list from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<bool> LoadEntityBoolList(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Collections.Generic.List<System.Boolean\>

#### LoadEntityFloat(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads float from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static float LoadEntityFloat(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Single

#### LoadEntityFloatList(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads float from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<float> LoadEntityFloatList(string entityName, string key)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

key

##### Returns

Type

Description

System.Collections.Generic.List<System.Single\>

#### LoadEntityInteger(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity Storage", "Loads integer from the entity storage.", -10510688)]
[VisualScriptingMember(false, false)]
public static int LoadEntityInteger(string entityName, string key)
```
