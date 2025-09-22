System.Int64

playerId

#### AddRepairContract(Int64, Int32, Int32, Int32, Int64, out Int64)

##### Declaration

```
[VisualScriptingMiscData("Contract", "Create and add new Repair contract. Returns true if contract creation was successful. Id of newly created contract is stored in out variable id.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool AddRepairContract(long startBlockId, int moneyReward, int collateral, int duration, long targetGridId, out long id)
```

##### Parameters

Type

Name

Description

System.Int64

startBlockId

System.Int32

moneyReward

System.Int32

collateral

System.Int32

duration

System.Int64

targetGridId

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### AddRow(String, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Add row to board screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddRow(string boardId, string rowId, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.String

rowId

System.Int64

playerId

#### AddSearchContract(Int64, Int32, Int32, Int32, Int64, Double, out Int64)

##### Declaration

```
[VisualScriptingMiscData("Contract", "Create and add new Search contract. Returns true if contract creation was successful. Id of newly created contract is stored in out variable id. 'targetGridId' is id of grid that will be searched and 'searchRadius' is radius of sphere around searched grid where GPS will be randomly placed in", -10510688)]
[VisualScriptingMember(true, false)]
public static bool AddSearchContract(long startBlockId, int moneyReward, int collateral, int duration, long targetGridId, double searchRadius, out long id)
```

##### Parameters

Type

Name

Description

System.Int64

startBlockId

System.Int32

moneyReward

System.Int32

collateral

System.Int32

duration

System.Int64

targetGridId

System.Double

searchRadius

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### AddToInventory(String, MyDefinitionId, Int32)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Adds item defined by id in specific quantity into inventory of entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddToInventory(string entityname, MyDefinitionId itemId, int amount = 1)
```

##### Parameters

Type

Name

Description

System.String

entityname

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

System.Int32

amount

#### AddToInventoryFloat(String, MyDefinitionId, Single)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Adds item defined by id in specific quantity into inventory of entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddToInventoryFloat(string entityname, MyDefinitionId itemId, float amount = 1F)
```

##### Parameters

Type

Name

Description

System.String

entityname

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

System.Single

amount

#### AddToPlayersInventory(Int64, MyDefinitionId, Int32)

##### Declaration

```
[VisualScriptingMiscData("Player", "Adds the specified item to the player's inventory.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddToPlayersInventory(long playerId = 0L, MyDefinitionId itemId = null, int amount = 1)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

System.Int32

amount

#### AdvanceMatchState()

##### Declaration

```
[VisualScriptingMiscData("Other", "Immediately progress match into next phase. Returns name of new state.", -10510688)]
[VisualScriptingMember(true, false)]
public static string AdvanceMatchState()
```

##### Returns

Type

Description

System.String

#### AreEssentialGoodbotHintsDone()

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Returns true if all essential hints have been completed.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool AreEssentialGoodbotHintsDone()
```

##### Returns

Type

Description

System.Boolean

#### AreFactionsEnemies(String, String)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Returns true if specified two factions are enemies.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool AreFactionsEnemies(string firstFactionTag, string secondFactionTag)
```

##### Parameters

Type

Name

Description

System.String

firstFactionTag

System.String

secondFactionTag

##### Returns

Type

Description

System.Boolean

#### AutopilotActivate(String, FlightMode, Single, Boolean, Boolean)

##### Declaration

```
[VisualScriptingMiscData("AI", "Activates autopilot of specific drone and set all required parameters. Waypoints will not be cleared.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AutopilotActivate(string entityName, FlightMode mode, float speedLimit = 120F, bool collisionAvoidance = true, bool precisionMode = false)
```

##### Parameters

Type

Name

Description

System.String

entityName

[FlightMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.FlightMode.html)

mode

System.Single

speedLimit

System.Boolean

collisionAvoidance

System.Boolean

precisionMode

#### AutopilotAddWaypoint(String, Vector3D, String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Adds new waypoint for specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AutopilotAddWaypoint(string entityName, Vector3D position, string waypointName = "Waypoint")
```

##### Parameters

Type

Name

Description

System.String

entityName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.String

waypointName

#### AutopilotClearWaypoints(String)
