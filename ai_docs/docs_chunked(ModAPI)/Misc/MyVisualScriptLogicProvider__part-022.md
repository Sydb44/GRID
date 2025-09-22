Description

System.Boolean

#### IsFlyable(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if the specified grid has at least one functional gyro, at least one controlling block (cockpit/remote) and thrusters in all directions.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsFlyable(string entityName)
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

#### IsGameControlPressed(String)

##### Declaration

```
[VisualScriptingMiscData("Input", "Checks if input control is currently pressed.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsGameControlPressed(string controlStringId)
```

##### Parameters

Type

Name

Description

System.String

controlStringId

##### Returns

Type

Description

System.Boolean

#### IsGameControlReleased(String)

##### Declaration

```
[VisualScriptingMiscData("Input", "Checks if input control is currently released.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsGameControlReleased(string controlStringId)
```

##### Parameters

Type

Name

Description

System.String

controlStringId

##### Returns

Type

Description

System.Boolean

#### IsGameLoaded()

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Returns true if session is fully loaded.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsGameLoaded()
```

##### Returns

Type

Description

System.Boolean

#### IsGameSaving()

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Provides information if game is currently being saved", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsGameSaving()
```

##### Returns

Type

Description

System.Boolean

#### IsGridDestructible(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if grid is marked as destructible.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsGridDestructible(string entityName)
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

#### IsGridEditable(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if the specific grid is marked as editable.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsGridEditable(string entityName)
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

#### IsGridImmune(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if grid is marked as destructible.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsGridImmune(string entityName)
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

#### IsGridLockedWithLandingGear(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if any Landing gear of specific grid is in locked state.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsGridLockedWithLandingGear(string gridName)
```

##### Parameters

Type

Name

Description

System.String

gridName

##### Returns

Type

Description

System.Boolean

#### IsLandingGearLocked(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Returns true if Landing gear is locked, false otherwise.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsLandingGearLocked(string entityName)
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

#### IsNewGameControlPressed(String)

##### Declaration

```
[VisualScriptingMiscData("Input", "Checks if input control has been pressed this frame.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsNewGameControlPressed(string controlStringId)
```

##### Parameters

Type

Name

Description

System.String

controlStringId

##### Returns

Type

Description

System.Boolean

#### IsNewGameControlReleased(String)

##### Declaration

```
[VisualScriptingMiscData("Input", "Checks if input control has been released this frame.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsNewGameControlReleased(string controlStringId)
```

##### Parameters

Type

Name

Description

System.String

controlStringId

##### Returns

Type

Description

System.Boolean

#### IsNewKeyPressed(MyKeys)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Returns true if specific key was pressed in this frame.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsNewKeyPressed(MyKeys key)
```

##### Parameters

Type

Name

Description

VRage.Input.MyKeys

key

##### Returns

Type

Description

System.Boolean

#### IsOnDarkSide(MyPlanet, Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Environment", "Returns true if position is on dark side of a planet.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsOnDarkSide(MyPlanet planet, Vector3D position)
```

##### Parameters

Type

Name

Description

[MyPlanet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyPlanet.html)

planet

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

##### Returns

Type

Description

System.Boolean

#### IsPlanetNearby(Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Returns true if point is in natural gravity close to planet(eg. if nearest planet exists).", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsPlanetNearby(Vector3D position)
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

#### IsPlayerDead(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Checks if player is dead.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsPlayerDead(long playerId = 0L)
```
