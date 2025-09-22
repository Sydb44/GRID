Type

Name

Description

System.String

entityName

System.Boolean

ambushModeOn

#### DroneSetCollisionAvoidance(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("AI", "Enables/disables collision avoidance for specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneSetCollisionAvoidance(string entityName, bool collisionAvoidance = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

collisionAvoidance

#### DroneSetPlayerPriority(String, Int32)

##### Declaration

```
[VisualScriptingMiscData("AI", "Sets player targeting priority of specific drone. (All player controlled entities will be considered a target if priority is greater than 0)", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneSetPlayerPriority(string entityName, int priority)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Int32

priority

#### DroneSetPrioritizationStyle(String, TargetPrioritization)

##### Declaration

```
[VisualScriptingMiscData("AI", "Sets target prioritization for specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneSetPrioritizationStyle(string entityName, TargetPrioritization style)
```

##### Parameters

Type

Name

Description

System.String

entityName

VRage.Game.ObjectBuilders.AI.TargetPrioritization

style

#### DroneSetRetreatPosition(String, Vector3D)

##### Declaration

```
[VisualScriptingMiscData("AI", "Sets origin point of specific drone. (Once non-kamikaze drone has no weapons, it will retreat to that point.)", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneSetRetreatPosition(string entityName, Vector3D position)
```

##### Parameters

Type

Name

Description

System.String

entityName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

#### DroneSetRotateToTarget(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("AI", "Enables/disables if drone should rotate toward it's target.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneSetRotateToTarget(string entityName, bool rotateToTarget = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

rotateToTarget

#### DroneSetSpeedLimit(String, Single)

##### Declaration

```
[VisualScriptingMiscData("AI", "Sets maximum speed limit of specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneSetSpeedLimit(string entityName, float speedLimit = 100F)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Single

speedLimit

#### DroneSetTarget(String, MyEntity)

##### Declaration

```
[VisualScriptingMiscData("AI", "Sets current target of drone to specific entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneSetTarget(string entityName, MyEntity target)
```

##### Parameters

Type

Name

Description

System.String

entityName

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

target

#### DroneTargetAdd(String, MyEntity, Int32)

##### Declaration

```
[VisualScriptingMiscData("AI", "Adds specific entity into targets of specific drone. Priority specifies order in which targets will be dealt with (higher is more important).", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneTargetAdd(string entityName, MyEntity target, int priority = 1)
```

##### Parameters

Type

Name

Description

System.String

entityName

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

target

System.Int32

priority

#### DroneTargetClear(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Clears all targets of specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneTargetClear(string entityName)
```

##### Parameters

Type

Name

Description

System.String

entityName

#### DroneTargetLoseCurrent(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Sets current target of specific drone to none.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneTargetLoseCurrent(string entityName)
```

##### Parameters

Type

Name

Description

System.String

entityName

#### DroneTargetRemove(String, MyEntity)

##### Declaration

```
[VisualScriptingMiscData("AI", "Removes specific entity from drone's targets", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneTargetRemove(string entityName, MyEntity target)
```

##### Parameters

Type

Name

Description

System.String

entityName

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

target

#### DroneWaypointAdd(String, MyEntity)

##### Declaration

```
[VisualScriptingMiscData("AI", "Adds specific waypoint to specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneWaypointAdd(string entityName, MyEntity waypoint)
```

##### Parameters

Type

Name

Description

System.String

entityName

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

waypoint

#### DroneWaypointClear(String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Deletes all waypoints of specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneWaypointClear(string entityName)
```

##### Parameters

Type

Name

Description

System.String

entityName

#### DroneWaypointSetCycling(String, Boolean)

##### Declaration

```
[VisualScriptingMiscData("AI", "Enables/disables waypoint cycling for specific drone.", -10510688)]
[VisualScriptingMember(true, false)]
public static void DroneWaypointSetCycling(string entityName, bool cycleWaypoints = true)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

cycleWaypoints
