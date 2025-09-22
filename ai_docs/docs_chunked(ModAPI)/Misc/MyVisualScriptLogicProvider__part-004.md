System.Int64

id

##### Returns

Type

Description

System.Boolean

#### AddColumn(String, String, Single, String, MyGuiDrawAlignEnum, MyGuiDrawAlignEnum, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Add column to board screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddColumn(string boardId, string columnId, float width, string headerText, MyGuiDrawAlignEnum headerDrawAlign, MyGuiDrawAlignEnum columnDrawAlign, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

boardId

System.String

columnId

System.Single

width

System.String

headerText

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

headerDrawAlign

[MyGuiDrawAlignEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyGuiDrawAlignEnum.html)

columnDrawAlign

System.Int64

playerId

#### AddEscortContract(Int64, Int32, Int32, Int32, Vector3D, Vector3D, Int64, out Int64)

##### Declaration

```
[VisualScriptingMiscData("Contract", "Create and add new Escort contract. Returns true if contract creation was successful. Id of newly created contract is stored in out variable id. Escort ship will start from 'start' flying towards the 'end'. Escorted ship will be owned by 'ownerIdentityId'", -10510688)]
[VisualScriptingMember(true, false)]
public static bool AddEscortContract(long startBlockId, int moneyReward, int collateral, int duration, Vector3D start, Vector3D end, long ownerIdentityId, out long id)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

start

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

end

System.Int64

ownerIdentityId

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### AddGPS(String, String, Vector3D, Color, Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Adds GPS for specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddGPS(string name, string description, Vector3D position, Color GPSColor, int disappearsInS = 0, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

name

System.String

description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

System.Int32

disappearsInS

System.Int64

playerId

#### AddGPSForAll(String, String, Vector3D, Color, Int32)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Adds GPS for all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddGPSForAll(string name, string description, Vector3D position, Color GPSColor, int disappearsInS = 0)
```

##### Parameters

Type

Name

Description

System.String

name

System.String

description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

System.Int32

disappearsInS

#### AddGPSObjective(String, String, Vector3D, Color, Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Adds GPS for specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddGPSObjective(string name, string description, Vector3D position, Color GPSColor, int disappearsInS = 0, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

name

System.String

description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

System.Int32

disappearsInS

System.Int64

playerId

#### AddGPSObjectiveForAll(String, String, Vector3D, Color, Int32)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Adds GPS for all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddGPSObjectiveForAll(string name, string description, Vector3D position, Color GPSColor, int disappearsInS = 0)
```

##### Parameters

Type

Name

Description

System.String

name

System.String

description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

System.Int32

disappearsInS

#### AddGPSObjectiveToEntity(String, String, String, Color, Int64)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Creates GPS and attach it to entity for local player only.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddGPSObjectiveToEntity(string entityName, string GPSName, string GPSDescription, Color GPSColor, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

GPSName

System.String

GPSDescription

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

System.Int64

playerId

#### AddGPSObjectiveToEntityForAll(String, String, String, Color)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Creates GPS and attach it to entity for all players", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddGPSObjectiveToEntityForAll(string entityName, string GPSName, string GPSDescription, Color GPSColor)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.String

GPSName

System.String

GPSDescription

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor
