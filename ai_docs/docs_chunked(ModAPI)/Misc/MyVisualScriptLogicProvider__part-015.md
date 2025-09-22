Type

Name

Description

System.String

entityName

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

##### Returns

Type

Description

System.Int32

#### GetEntityInventoryItemAmountPrecise(String, MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets amount of specific items in inventory of entity.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetEntityInventoryItemAmountPrecise(string entityName, MyDefinitionId itemId)
```

##### Parameters

Type

Name

Description

System.String

entityName

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId

##### Returns

Type

Description

System.Single

#### GetEntityInventoryItemAtSlot(String, out MyDefinitionId, out Single, Int32, Int32)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Returns true if entity has item in specific inventory on specific slot. Also return definition id of that item and its amount.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool GetEntityInventoryItemAtSlot(string entityName, out MyDefinitionId itemId, out float amount, int slot = 0, int inventoryId = 0)
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

System.Int32

slot

System.Int32

inventoryId

##### Returns

Type

Description

System.Boolean

#### GetEntityName(Int64)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets name of specific entity defined by id.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetEntityName(long entityId)
```

##### Parameters

Type

Name

Description

System.Int64

entityId

##### Returns

Type

Description

System.String

#### GetEntityPosition(String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets position of specific entity.", -10510688)]
[VisualScriptingMember(false, false)]
public static Vector3D GetEntityPosition(string entityName)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetEntitySpeed(String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets linear velocity of specific entity.", -10510688)]
[VisualScriptingMember(false, false)]
public static Vector3D GetEntitySpeed(string entityName)
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

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetEntityVectors(String, out Vector3D, out Vector3D, out Vector3D)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Breaks and returns world matrix of specific entity.", -10510688)]
[VisualScriptingMember(false, false)]
public static void GetEntityVectors(string entityName, out Vector3D position, out Vector3D forward, out Vector3D up)
```

##### Parameters

Type

Name

Description

System.String

entityName

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

forward

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

up

#### GetEntityWorldMatrix(MyEntity)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets world matrix of specific entity.", -10510688)]
[VisualScriptingMember(false, false)]
public static MatrixD GetEntityWorldMatrix(MyEntity entity)
```

##### Parameters

Type

Name

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

entity

##### Returns

Type

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

#### GetFactionMembers(String)

##### Declaration

```
[VisualScriptingMiscData("Factions", "Returns list of all members (of theirs ids) of specific faction.", -10510688)]
[VisualScriptingMember(false, false)]
public static List<long> GetFactionMembers(string factionTag = "")
```

##### Parameters

Type

Name

Description

System.String

factionTag

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### GetFriendlyName(MyGuiScreenBase)

##### Declaration

```
[VisualScriptingMiscData("GUI", "Gets friendly name of the specific screen.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetFriendlyName(this MyGuiScreenBase screen)
```

##### Parameters

Type

Name

Description

Sandbox.Graphics.GUI.MyGuiScreenBase

screen

##### Returns

Type

Description

System.String

#### GetGameplayElapsedTime(String)

##### Declaration

```
[VisualScriptingMiscData("Timers", "Return elapsed time in milliseconds for given timer.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetGameplayElapsedTime(string key)
```

##### Parameters

Type

Name

Description

System.String

key

##### Returns

Type

Description

System.Int32

#### GetGameplayElapsedTimeToString(String, String)

##### Declaration

```
[VisualScriptingMiscData("Timers", "Return elapsed time in milliseconds for given timer. Format according to https://docs.microsoft.com/cs-cz/dotnet/api/system.timespan.tostring", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetGameplayElapsedTimeToString(string key, string format)
```

##### Parameters

Type

Name

Description

System.String

key

System.String

format

##### Returns

Type

Description

System.String

#### GetGameVolume()

##### Declaration

```
[VisualScriptingMiscData("Audio", "Get game volume.", -10510688)]
[VisualScriptingMember(false, false)]
public static float GetGameVolume()
```
