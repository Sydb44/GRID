entityName

System.String

GPSName

System.String

GPSDescription

[Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html)

GPSColor

#### AddGPSToEntity(String, String, String, Color, Int64)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Creates GPS and attach it to entity for local player only.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddGPSToEntity(string entityName, string GPSName, string GPSDescription, Color GPSColor, long playerId = -1L)
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

#### AddGPSToEntityForAll(String, String, String, Color)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Creates GPS and attach it to entity for all players", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddGPSToEntityForAll(string entityName, string GPSName, string GPSDescription, Color GPSColor)
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

#### AddGridToTargetList(String, String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Adds grid with specific name into drone's targets.", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddGridToTargetList(string gridName, string targetGridname)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.String

targetGridname

#### AddHaulingContract(Int64, Int32, Int32, Int32, Int64, out Int64)

##### Declaration

```
[VisualScriptingMiscData("Contract", "Create and add new Hauling contract. Returns true if contract creation was successful. Id of newly created contract is stored in out variable id. End block is contract block where package is to be delivered.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool AddHaulingContract(long startBlockId, int moneyReward, int collateral, int duration, long endBlockId, out long id)
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

endBlockId

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### AddMatchStateRemainingDuration(Single)

##### Declaration

```
[VisualScriptingMiscData("Other", "Get remaining time of the current match state. Time is in minutes. Positive value will lenghten the phase, negative will shorten it. If remaining duration becomes lower or equal to zero, next match phase will start", -10510688)]
[VisualScriptingMember(true, false)]
public static void AddMatchStateRemainingDuration(float time)
```

##### Parameters

Type

Name

Description

System.Single

time

#### AddNotification(String, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "Adds a new notification for the specific player and returns if of the notification. Returns -1 if no player corresponds to 'playerId'. For 'playerId' equal to 0 use local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static int AddNotification(string message, string font = "White", long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.String

message

System.String

font

System.Int64

playerId

##### Returns

Type

Description

System.Int32

#### AddNotificationLocal(String, String, Int32)

##### Declaration

```
public static void AddNotificationLocal(string message, string font, int notificationId)
```

##### Parameters

Type

Name

Description

System.String

message

System.String

font

System.Int32

notificationId

#### AddQuestlogDetail(String, Boolean, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Sets detail of the quest for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static int AddQuestlogDetail(string questDetailRow = "", bool completePrevious = true, bool useTyping = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

questDetailRow

System.Boolean

completePrevious

System.Boolean

useTyping

System.Int64

playerId

##### Returns

Type

Description

System.Int32

#### AddQuestlogDetailLocal(String, Boolean, Boolean, Int64)

##### Declaration

```
public static void AddQuestlogDetailLocal(string questDetailRow = "", bool completePrevious = true, bool useTyping = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

questDetailRow

System.Boolean

completePrevious

System.Boolean

useTyping

System.Int64

playerId

#### AddQuestlogObjective(String, Boolean, Boolean, Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Sets objective of the quest for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static int AddQuestlogObjective(string questDetailRow = "", bool completePrevious = true, bool useTyping = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

questDetailRow

System.Boolean

completePrevious

System.Boolean

useTyping

System.Int64

playerId

##### Returns

Type

Description

System.Int32

#### AddQuestlogObjectiveLocal(String, Boolean, Boolean, Int64)

##### Declaration

```
public static void AddQuestlogObjectiveLocal(string questDetailRow = "", bool completePrevious = true, bool useTyping = true, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

questDetailRow

System.Boolean

completePrevious

System.Boolean

useTyping

System.Int64

playerId

#### AddRepairContract(Int64, Int32, Int32, Int32, Int64, out Int64)

##### Declaration

```
[VisualScriptingMiscData("Contract", "Create and add new Repair contract. Returns true if contract creation was successful. Id of newly created contract is stored in out variable id.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool AddRepairContract(long startBlockId, int moneyReward, int collateral, int duration, long targetGridId, out long id)
```
