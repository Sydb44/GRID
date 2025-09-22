System.String

entityName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.String

waypointName

#### AutopilotClearWaypoints(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Clears all waypoints of specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AutopilotClearWaypoints(string entityName)
```

##### Parameters

Type

Name

Description

System.String

entityName

#### AutopilotEnabled(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("AI", "Enables/disables autopilot of specific drone", -10510688)]
[VisualScriptingMember(true, false)]
public static void AutopilotEnabled(string entityName, bool enabled = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

enabled

#### AutopilotGetCurrentWaypoint(String, out String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Gets position of curret waypoint of specific drone. If current waypoint exists, returns it position and 'waypointName' will be name of the waypoint. If waypoint does not exists, return current position and 'waypointName' will be empty string.", -10510688)]
[VisualScriptingMember(false, false)]
public static Vector3D AutopilotGetCurrentWaypoint(string entityName, out string waypointName)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

waypointName

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### AutopilotGoToPosition(String, Vector3D, String, Single, Boolean, Boolean)

##### Declaration

```
[VisualScriptingMiscData("AI", "Enables drone's autopilot, sets it to one-way go to waypoint and adds that one waypoint. All previous waypoints will be cleared.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AutopilotGoToPosition(string entityName, Vector3D position, string waypointName = "Waypoint", float speedLimit = 120F, bool collisionAvoidance = true, bool precisionMode = false)
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

System.Single

speedLimit

System.Boolean

collisionAvoidance

System.Boolean

precisionMode

#### AutopilotSetWaypoints(String, List<Vector3D>, String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Adds list of waypoints to specific drone. All waypoints will be called 'waypointName' followed by space and number. (given by order, starts with 1)", -10510688)]
[VisualScriptingMember(true, false)]
public static void AutopilotSetWaypoints(string entityName, List<Vector3D> positions, string waypointName = "Waypoint")
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Collections.Generic.List<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\>

positions

System.String

waypointName

#### AutopilotSkipCurrentWaypoint(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Orders drone to immediately skip current waypoint and go directly to the next one.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AutopilotSkipCurrentWaypoint(string entityName)
```

##### Parameters

Type

Name

Description

System.String

entityName

#### CancelStoreItem(String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Store", "Cancels listed item in specified store.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool CancelStoreItem(string storeEntityName, long id)
```

##### Parameters

Type

Name

Description

System.String

storeEntityName

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### ChangeDoorState(Int64, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Sets specific doors to open/close state. (Doors, SlidingDoors, AirtightDoors)", -10510688)]
[VisualScriptingMember(true, false)]
public static void ChangeDoorState(long doorId, bool open = true)
```

##### Parameters

Type

Name

Description

System.Int64

doorId

System.Boolean

open

#### ChangeDoorState(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Sets specific doors to open/close state. (Doors, SlidingDoors, AirtightDoors)", -10510688)]
[VisualScriptingMember(true, false)]
public static void ChangeDoorState(string doorBlockName, bool open = true)
```

##### Parameters

Type

Name

Description

System.String

doorBlockName

System.Boolean

open

#### ChangeOwner(String, Int64, Boolean, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Changes ownership of a specific block (if entity is block) or ownership of all functional blocks (if entity is grid) to specific player and modify its/theirs share settings.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool ChangeOwner(string entityName, long playerId = 0L, bool factionShare = false, bool allShare = false)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Int64

playerId

System.Boolean

factionShare

System.Boolean

allShare

##### Returns

Type

Description

System.Boolean

#### ClearAllToolbarSlots(Int64)

##### Declaration

```
[VisualScriptingMiscData("Toolbar", "Clears all toolbar slots for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ClearAllToolbarSlots(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### ClearAllToolbarSlotsLocal(Int64)

##### Declaration

```
public static void ClearAllToolbarSlotsLocal(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### ClearNotificationLocal(Int64)

##### Declaration

```
public static void ClearNotificationLocal(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId
