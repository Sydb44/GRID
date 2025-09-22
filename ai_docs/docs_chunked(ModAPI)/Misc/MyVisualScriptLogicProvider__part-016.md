Description

System.String

#### GetGameVolume()

##### Declaration

```
[VisualScriptingMiscData("Audio", "Get game volume.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetGameVolume()
```

##### Returns

Type

Description

System.Single

#### GetGridCockpitId(String, out Boolean, out Boolean, Boolean)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns entity id of main cockpit or first cockpit found on grid. Also returns other info such as if cockpit is main or if any cockpit was found.", -10510688)]
[VisualScriptingMember(false, false)]
public static long GetGridCockpitId(string gridName, out bool isMainCockpit, out bool found, bool checkForEnabledShipControl = true)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Boolean

isMainCockpit

System.Boolean

found

System.Boolean

checkForEnabledShipControl

##### Returns

Type

Description

System.Int64

#### GetGridIdOfBlock(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Returns grid EntityId of grid that contains block with specific name. Returns 0 if name does not refer to a cube block. (If more entities have same name, only the first one created will be tested.)", -10510688)]
[VisualScriptingMember(false, false)]
public static long GetGridIdOfBlock(string entityName)
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

System.Int64

#### GetGridStatistics(String, out Single, out Single, out Int32)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns sums of current integrities, max integrities, block counts.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool GetGridStatistics(string gridName, out float currentIntegrity, out float maxIntegrity, out int blockCount)
```

##### Parameters

Type

Name

Description

System.String

gridName

System.Single

currentIntegrity

System.Single

maxIntegrity

System.Int32

blockCount

##### Returns

Type

Description

System.Boolean

#### GetIdListOfSpecificGridBlocks(String, MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns list of all blocks of type 'blockId' on specific grid.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<long> GetIdListOfSpecificGridBlocks(string gridName, MyDefinitionId blockId)
```

##### Parameters

Type

Name

Description

System.String

gridName

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

blockId

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### GetIdOfFirstSpecificGridBlock(String, MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns id of first block of type 'blockId' on specific grid.", -10510688)]
[VisualScriptingMember(false, false)]
public static long GetIdOfFirstSpecificGridBlock(string gridName, MyDefinitionId blockId)
```

##### Parameters

Type

Name

Description

System.String

gridName

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

blockId

##### Returns

Type

Description

System.Int64

#### GetInteractedEntityInventoryItemIndexAndControl(MyDefinitionId, out MyGuiControlBase, out Int32)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets whole inventory grid of interacted entity and find index of specific item in it. If no item was found, method will still return inventory grid and index will be set to last index in it (GetItemsCount() - 1). Works only when Terminal screen is opened and focused.", -10510688)]
[VisualScriptingMember(false, false)]
public static void GetInteractedEntityInventoryItemIndexAndControl(MyDefinitionId itemDefinition, out MyGuiControlBase control, out int index)
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

#### GetLandingGearInformation(String, out Boolean, out Boolean, out String, out String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Gets information about specific landing gear. Returns true if informations were obtained, false if no such Landing gear exists.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool GetLandingGearInformation(string entityName, out bool locked, out bool inConstraint, out string attachedType, out string attachedName)
```

##### Parameters

Type

Name

Description

System.String

entityName

System.Boolean

locked

System.Boolean

inConstraint

System.String

attachedType

System.String

attachedName

##### Returns

Type

Description

System.Boolean

#### GetLandingGearInformationFromEntity(MyEntity, out Boolean, out Boolean, out String, out String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Gets information about specific landing gear. Returns true if informations were obtained, false if entity is not a Landing gear.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool GetLandingGearInformationFromEntity(MyEntity entity, out bool locked, out bool inConstraint, out string attachedType, out string attachedName)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

System.Boolean

locked

System.Boolean

inConstraint

System.String

attachedType

System.String

attachedName

##### Returns

Type

Description

System.Boolean

#### GetLocalPlayerId()

##### Declaration

```
[VisualScriptingMiscData("Factions", "Gets id of local player. Works only on Lobby and clients. On Dedicated server returns 0.", -10510688)]
[VisualScriptingMember(false, false)]
public static long GetLocalPlayerId()
```

##### Returns

Type

Description

System.Int64

#### GetMatchIsRunningState()

##### Declaration

```
[VisualScriptingMiscData("Other", "Get information whether component handling the match is running or not. Running component will have the time advancing and states will be changing.", -10510688)]
[VisualScriptingMember(true, false)]
public static bool GetMatchIsRunningState()
```
