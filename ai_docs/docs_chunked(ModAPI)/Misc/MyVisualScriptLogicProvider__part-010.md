drawAlign

System.Int64

playerId

#### CustomRespawnRequest(Int64)

##### Declaration

```
public static void CustomRespawnRequest(long playerId)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### DamageBlock(String, Single, Int64)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Applies damage to specific block from specific player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DamageBlock(string entityName, float damage = 0F, long damageOwner = 0L)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Single

damage

System.Int64

damageOwner

#### DefinitionIdMatch(String, String, String, String)

##### Declaration

```
[VisualScriptingMiscData("Definitions", "Returns true if the type id and subtype id match.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool DefinitionIdMatch(string typeId, string subtypeId, string matchTypeId, string matchSubtypeId)
```

##### Parameters

Type

Name

Description

System.String

typeId

System.String

subtypeId

System.String

matchTypeId

System.String

matchSubtypeId

##### Returns

Type

Description

System.Boolean

#### DisableBlock(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Disables functional block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DisableBlock(string blockName)
```

##### Parameters

Type

Name

Description

System.String

blockName

#### DisconnectPlayer(UInt64)

##### Declaration

```
[VisualScriptingMember(true, false)]
[VisualScriptingMiscData("Gameplay", "Disconnect player.", -10510688)]
public static void DisconnectPlayer(ulong steamId)
```

##### Parameters

Type

Name

Description

System.UInt64

steamId

#### DisplayCongratulationScreen(Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "Display congratulation screen to playet/s. Use MessageId to select which message should be shown. If player id is 1-, show to all. If it is 0, show to local player. Else it will be used as player identity id.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DisplayCongratulationScreen(int congratulationMessageId, long playerId)
```

##### Parameters

Type

Name

Description

System.Int32

congratulationMessageId

System.Int64

playerId

#### DroneGetCurrentAIBehavior(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Gets AI behavior of specific drone. Returns empty string if drone lacks remote or AI behavior.", -10510688)]
[VisualScriptingMember(false, false)]
public static string DroneGetCurrentAIBehavior(string entityName)
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

System.String

#### DroneGetSpeedLimit(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Gets speed limit of specific drone.", -10510688)]
[VisualScriptingMember(false, false)]
public static float DroneGetSpeedLimit(string entityName)
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

System.Single

#### DroneGetTargetsCount(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Gets count of targets for specific drone. Returns -1 if drone lacks remote or AI behavior.", -10510688)]
[VisualScriptingMember(false, false)]
public static int DroneGetTargetsCount(string entityName)
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

System.Int32

#### DroneGetWaypointCount(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Gets number of waypoints for specific drone. Returns -1 if drone has no remote or AI behavior.", -10510688)]
[VisualScriptingMember(false, false)]
public static int DroneGetWaypointCount(string entityName)
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

System.Int32

#### DroneHasAI(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Returns true if specific drone has both remote and AI behavior, false otherwise.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool DroneHasAI(string entityName)
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

#### DroneIsInAmbushMode(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Returns true if drone is in ambush mode, false otherwise.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool DroneIsInAmbushMode(string entityName)
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

#### DroneIsOperational(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Returns true if specific drone has both working remoteand have operational AI behavior, false otherwise.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool DroneIsOperational(string entityName)
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

#### DroneProcessTargets(List<MyEntity>)

##### Declaration

```
public static List<DroneTarget> DroneProcessTargets(List<MyEntity> targets)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

targets

##### Returns

Type

Description

System.Collections.Generic.List<Sandbox.Game.GameSystems.DroneTarget\>

#### DroneSetAmbushMode(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("AI", "Activates/deactivates ambush mode for specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneSetAmbushMode(string entityName, bool ambushModeOn = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

ambushModeOn
