```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### ClearNotifications(Int64)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "Clears all added notifications.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ClearNotifications(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### ClearToolbarSlot(Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("Toolbar", "Clears the toolbar slot for the player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ClearToolbarSlot(int slot, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

slot

System.Int64

playerId

#### ClearToolbarSlotLocal(Int32, Int64)

##### Declaration

```
public static void ClearToolbarSlotLocal(int slot, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

slot

System.Int64

playerId

#### CockpitGetPilotId(String, out Boolean)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Returns identity Id of player occupying cockpit or 0, if no one is in. ", -10510688)]
[VisualScriptingMember(false, false)]
public static long CockpitGetPilotId(string cockpitName, out bool occupied)
```

##### Parameters

Type

Name

Description

System.String

cockpitName

System.Boolean

occupied

##### Returns

Type

Description

System.Int64

#### CockpitInsertPilot(String, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Forces player into specific Cockpit.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CockpitInsertPilot(string cockpitName, bool keepOriginalPlayerPosition = true, long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.String

cockpitName

System.Boolean

keepOriginalPlayerPosition

System.Int64

playerId

#### CockpitRemovePilot(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Removes pilot from specific Cockpit.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CockpitRemovePilot(string cockpitName)
```

##### Parameters

Type

Name

Description

System.String

cockpitName

#### ColorAllGridBlocks(String, Color, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Colors all blocks of specific grid.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ColorAllGridBlocks(string gridName, Color color, bool playSound = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

System.Boolean

playSound

#### ColorAndSkinBlock(String, Color, String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Sets color and skin of specific block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ColorAndSkinBlock(string blockName, Color color, string skin)
```

##### Parameters

Type

Name

Description

System.String

blockName

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

System.String

skin

#### ColorBlock(String, Color)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Sets color of specific block.", -10510688)]
[VisualScriptingMember(true, false)]
public static void ColorBlock(string blockName, Color color)
```

##### Parameters

Type

Name

Description

System.String

blockName

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

color

#### CreateAreaTriggerOnEntity(String, Single, String)

##### Declaration

```
[VisualScriptingMiscData("Triggers", "Creates area trigger at the position of specified entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateAreaTriggerOnEntity(string entityName, float radius, string name)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Single

radius

System.String

name

#### CreateAreaTriggerOnPosition(Vector3D, Single, String)

##### Declaration

```
[VisualScriptingMiscData("Triggers", "Creates area trigger at the position.", -10510688)]
[VisualScriptingMember(true, false)]
public static long CreateAreaTriggerOnPosition(Vector3D position, float radius, string name)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Single

radius

System.String

name

##### Returns

Type

Description

System.Int64

#### CreateAreaTriggerRelativeToEntity(Vector3D, String, Single, String)

##### Declaration

```
[VisualScriptingMiscData("Triggers", "Creates area trigger at the relative position to the specified entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateAreaTriggerRelativeToEntity(Vector3D position, string entityName, float radius, string name)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.String

entityName

System.Single

radius

System.String

name

#### CreateBoardScreen(String, Single, Single, Single, Single, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Create board screen on specific coordinates. PlayerId -1 stands for all players, 0 for local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateBoardScreen(string boardId, float normalizedPosX, float normalizedPosY, float normalizedSizeX, float normalizedSizeY, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.Single

normalizedPosX

System.Single

normalizedPosY

System.Single

normalizedSizeX

System.Single

normalizedSizeY

System.Int64

playerId

#### CreateExplosion(Vector3D, Single, Int32)

##### Declaration

```
[VisualScriptingMiscData("Effects", "Creates explosion at specific point with specified radius, causing damage to everything in range.", -10510688)]
[VisualScriptingMember(true, false)]
public static void CreateExplosion(Vector3D position, float radius, int damage = 5000)
```
