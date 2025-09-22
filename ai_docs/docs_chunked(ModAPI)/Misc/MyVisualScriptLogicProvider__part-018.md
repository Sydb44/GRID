Description

System.Boolean

#### GetPlayerRespawnPoints(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets the player's available respawn points", -10510688)]
[VisualScriptingMember(true, false)]
public static int GetPlayerRespawnPoints(long playerId)
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

System.Int32

#### GetPlayers()

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets online and local players.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<long> GetPlayers()
```

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### GetPlayersCount()

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets online and local players count.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetPlayersCount()
```

##### Returns

Type

Description

System.Int32

#### GetPlayersEnergyLevel(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets energy level of player's suit.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetPlayersEnergyLevel(long playerId = 0L)
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

System.Single

#### GetPlayersEntityId(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets players entity ID.", -10510688)]
[VisualScriptingMember(false, false)]
public static long GetPlayersEntityId(long playerId = 0L)
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

System.Int64

#### GetPlayersEntityName(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets players entity name.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetPlayersEntityName(long playerId = 0L)
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

System.String

#### GetPlayersFactionName(Int64)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Gets name of faction, specific player is in.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetPlayersFactionName(long playerId = 0L)
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

System.String

#### GetPlayersFactionTag(Int64)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Gets tag of faction, specific player is in.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetPlayersFactionTag(long playerId = 0L)
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

System.String

#### GetPlayersHealth(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets player's health.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetPlayersHealth(long playerId = 0L)
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

System.Single

#### GetPlayersHelmetStatus(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets player's helmet status.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool GetPlayersHelmetStatus(long playerId = 0L)
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

#### GetPlayersHydrogenLevel(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets hydrogen level of player's suit.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetPlayersHydrogenLevel(long playerId = 0L)
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

System.Single

#### GetPlayersInventoryItemAmount(Int64, MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets player's inventory item amount.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetPlayersInventoryItemAmount(long playerId = 0L, MyDefinitionId itemId = null)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

##### Returns

Type

Description

System.Int32

#### GetPlayersInventoryItemAmountPrecise(Int64, MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets player's inventory item amount (precise).", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetPlayersInventoryItemAmountPrecise(long playerId = 0L, MyDefinitionId itemId = null)
```

##### Parameters

Type

Name

Description

System.Int64

playerId

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

##### Returns

Type

Description

System.Single

#### GetPlayersInventoryItemIndexAndControl(MyDefinitionId, out MyGuiControlBase, out Int32)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets whole inventory grid of player and find index of specific item in it. If no item was found, method will still return inventory grid and index will be set to last index in it (GetItemsCount() - 1). Works only when Terminal screen is opened and focused.", -10510688)]
[VisualScriptingMember(false, false)]
public static void GetPlayersInventoryItemIndexAndControl(MyDefinitionId itemDefinition, out MyGuiControlBase control, out int index)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemDefinition

Sandbox.Graphics.GUI.MyGuiControlBase

control

System.Int32

index

#### GetPlayersName(Int64)

##### Declaration

```
[VisualScriptingMiscData("Player", "Gets player's name.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetPlayersName(long playerId = 0L)
```

##### Parameters

Type

Name

Description

System.Int64

playerId
