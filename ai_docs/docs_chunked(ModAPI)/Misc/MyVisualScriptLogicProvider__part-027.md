System.String

typeRestriction

#### RemoveFromEntityInventory(String, MyDefinitionId, Single)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Removes item defined by id in specific quantity from inventory of entity.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveFromEntityInventory(string entityName, MyDefinitionId itemId = null, float amount = 1F)
```

##### Parameters

Type

Name

Description

System.String

entityName

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

System.Single

amount

#### RemoveFromPlayersInventory(Int64, MyDefinitionId, Int32)

##### Declaration

```
[VisualScriptingMiscData("Player", "Removes the specified item from the player's inventory.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveFromPlayersInventory(long playerId = 0L, MyDefinitionId itemId = null, int amount = 1)
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

#### RemoveGPS(String, Int64)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Removes GPS from specific player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveGPS(string name, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.String

name

System.Int64

playerId

#### RemoveGPSForAll(String)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Removes GPS from all players.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveGPSForAll(string name)
```

##### Parameters

Type

Name

Description

System.String

name

#### RemoveGPSFromEntity(String, String, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Removes specific GPS from specific entity for local player only. ('GPSDescription' is not used. Cant remove due to backward compatibility.)", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveGPSFromEntity(string entityName, string GPSName, string GPSDescription, long playerId = -1L)
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

System.Int64

playerId

#### RemoveGPSFromEntityForAll(String, String, String)

##### Declaration

```
[VisualScriptingMiscData("GPS and Highlights", "Removes specific GPS from specific entity for all players. ('GPSDescription' is not used. Cant remove due to backward compatibility.)", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveGPSFromEntityForAll(string entityName, string GPSName, string GPSDescription)
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

#### RemoveGridFromTargetList(String, String)

##### Declaration

```
[VisualScriptingMiscData("AI", "Removes specific grid from drone's targets.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveGridFromTargetList(string gridName, string targetGridname)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.String

targetGridname

#### RemoveNotification(Int32, Int64)

##### Declaration

```
[VisualScriptingMiscData("Notifications", "Removes the specific notification referenced by its id from the specific player. If 'playerId' is equal to 0, apply on local player, if -1, apply to all.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveNotification(int messageId, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

messageId

System.Int64

playerId

#### RemoveNotificationLocal(Int32, Int64)

##### Declaration

```
public static void RemoveNotificationLocal(int messageId, long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int32

messageId

System.Int64

playerId

#### RemoveQuestlogDetails(Int64)

##### Declaration

```
[VisualScriptingMiscData("Questlog", "Removes details of the quest for the specified player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveQuestlogDetails(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### RemoveQuestlogDetailsLocal(Int64)

##### Declaration

```
public static void RemoveQuestlogDetailsLocal(long playerId = -1L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

#### RemoveRow(String, String, Int64)

##### Declaration

```
[VisualScriptingMiscData("Board screen", "Add row to board screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveRow(string boardId, string rowId, long playerId = -1L)
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

#### RemoveSoundEmitter(String)

##### Declaration

```
[VisualScriptingMiscData("Audio", "Removes specific sound emitter.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveSoundEmitter([Nullable] string emitterId)
```

##### Parameters

Type

Name

Description

System.String

emitterId

#### RemoveSoundEmitterLocal(String)

##### Declaration

```
public static void RemoveSoundEmitterLocal(string emitterId)
```

##### Parameters

Type

Name

Description

System.String

emitterId

#### RemoveTrigger(String)

##### Declaration

```
[VisualScriptingMiscData("Triggers", "Remove area trigger with the specified name.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveTrigger(string triggerName)
```

##### Parameters

Type

Name

Description

System.String

triggerName

#### RemoveUIString(Int64, Int64)

##### Declaration

```
[VisualScriptingMiscData("UIString", "Remove UI string with specific id. PlayerId -1 stands for all players, 0 for local player.", -10510688)]
[VisualScriptingMember(true, false)]
public static void RemoveUIString(long id, long playerId = -1L)
```
