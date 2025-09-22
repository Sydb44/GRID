System.String

customToolTipMessage

#### HighlightGuiControl(String, String)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Highlights specific GUI element in specific screen.", -10510688)]
[VisualScriptingMember(true, false)]
public static void HighlightGuiControl(string controlName, string activeScreenName)
```

##### Parameters

Type

Name

Description

System.String

controlName

System.String

activeScreenName

#### Init()

##### Declaration

```
public static void Init()
```

#### InsertOffer(String, MyStoreItemData, out Int64)

##### Declaration

```
[VisualScriptingMiscData("Store", "Inserts offer to specified store.", -10510688)]
[VisualScriptingMember(true, false)]
public static MyStoreInsertResults InsertOffer(string storeEntityName, MyStoreItemData item, out long id)
```

##### Parameters

Type

Name

Description

System.String

storeEntityName

[MyStoreItemData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyStoreItemData.html)

item

System.Int64

id

##### Returns

Type

Description

[MyStoreInsertResults](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyStoreInsertResults.html)

#### InsertOrder(String, MyStoreItemData, out Int64)

##### Declaration

```
[VisualScriptingMiscData("Store", "Inserts order to specified store.", -10510688)]
[VisualScriptingMember(true, false)]
public static MyStoreInsertResults InsertOrder(string storeEntityName, MyStoreItemData item, out long id)
```

##### Parameters

Type

Name

Description

System.String

storeEntityName

[MyStoreItemData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyStoreItemData.html)

item

System.Int64

id

##### Returns

Type

Description

[MyStoreInsertResults](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyStoreInsertResults.html)

#### IsBlockEnabled(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Returns true if functional block exists and is enabled, otherwise false.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsBlockEnabled(string name)
```

##### Parameters

Type

Name

Description

System.String

name

##### Returns

Type

Description

System.Boolean

#### IsBlockFunctional(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Returns true if specific cube block exists and is in functional state, otherwise false.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsBlockFunctional(string name)
```

##### Parameters

Type

Name

Description

System.String

name

##### Returns

Type

Description

System.Boolean

#### IsBlockFunctionalById(Int64)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Returns true if specific cube block exists and is in functional state, otherwise false. Access block by Id", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsBlockFunctionalById(long id)
```

##### Parameters

Type

Name

Description

System.Int64

id

##### Returns

Type

Description

System.Boolean

#### IsBlockPositionAirtight(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "True if block is part of airtight room (Best used for AirVents).", -10510688)]
[VisualScriptingMember(true, false)]
public static bool IsBlockPositionAirtight(string blockName)
```

##### Parameters

Type

Name

Description

System.String

blockName

##### Returns

Type

Description

System.Boolean

#### IsBlockPowered(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Returns true if specific functional block exist and is powered, otherwise false. This does not relate to Enabled status, it indicates that there is power available for the block. ", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsBlockPowered(string name)
```

##### Parameters

Type

Name

Description

System.String

name

##### Returns

Type

Description

System.Boolean

#### IsBlockWorking(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Returns true if specific functional block exists and is working, otherwise false.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsBlockWorking(string name)
```

##### Parameters

Type

Name

Description

System.String

name

##### Returns

Type

Description

System.Boolean

#### IsConnectorLocked(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Returns true if specific connector is locked. False if unlocked of no such connector exists.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsConnectorLocked(string connectorName)
```

##### Parameters

Type

Name

Description

System.String

connectorName

##### Returns

Type

Description

System.Boolean

#### IsConveyorConnected(String, String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Generic", "Return true if 'secondBlock' is reachable from 'firstBlock'. (Can be only onle-way) ", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsConveyorConnected(string firstBlock, string secondBlock)
```

##### Parameters

Type

Name

Description

System.String

firstBlock

System.String

secondBlock

##### Returns

Type

Description

System.Boolean

#### IsCreative()

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Returns true if world is creative.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsCreative()
```

##### Returns

Type

Description

System.Boolean

#### IsDoorOpen(String)

##### Declaration

```
[VisualScriptingMiscData("Blocks Specific", "Returns true if specific doors are open false if closed or door does not exist.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsDoorOpen(string doorBlockName)
```

##### Parameters

Type

Name

Description

System.String

doorBlockName

##### Returns

Type

Description

System.Boolean

#### IsFlyable(String)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns true if the specified grid has at least one functional gyro, at least one controlling block (cockpit/remote) and thrusters in all directions.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool IsFlyable(string entityName)
```
