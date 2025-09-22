Type

Name

Description

Sandbox.Graphics.GUI.MyGuiScreenBase

screen

System.String

controlName

##### Returns

Type

Description

Sandbox.Graphics.GUI.MyGuiControlBase

#### GetCountOfSpecificGridBlocks(String, MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("Grid", "Returns count of all blocks of type 'blockId' on specific grid.", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetCountOfSpecificGridBlocks(string gridName, MyDefinitionId blockId)
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

System.Int32

#### GetCurrentSessionPath()

##### Declaration

```
[VisualScriptingMiscData("Gameplay", "Gets path of the session (game/mission) currently being played.", -10510688)]
[VisualScriptingMember(false, false)]
public static string GetCurrentSessionPath()
```

##### Returns

Type

Description

System.String

#### GetDampenersEnabled(String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Returns true if entity has dampeners enabled, false otherwise.", -10510688)]
[VisualScriptingMember(false, false)]
public static bool GetDampenersEnabled(string entityName)
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

#### GetDataFromDefinition(MyDefinitionId, out String, out String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets typeId and subtypeId out of DefinitionId.", -10510688)]
[VisualScriptingMember(false, false)]
public static void GetDataFromDefinition(MyDefinitionId definitionId, out string typeId, out string subtypeId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

definitionId

System.String

typeId

System.String

subtypeId

#### GetDefinitionId(String, String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets DefinitionId from typeId and subtypeId", -10510688)]
[VisualScriptingMember(false, false)]
public static MyDefinitionId GetDefinitionId(string typeId, string subtypeId)
```

##### Parameters

Type

Name

Description

System.String

typeId

System.String

subtypeId

##### Returns

Type

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

#### GetEntitiesInSphere(Vector3D, Single)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Returns List of ids of entities in defined sphere", -10510688)]
[VisualScriptingMember(false, false)]
public static List<long> GetEntitiesInSphere(Vector3D position, float radius)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

System.Single

radius

##### Returns

Type

Description

System.Collections.Generic.List<System.Int64\>

#### GetEntityById(Int64)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets specific entity by id.", -10510688)]
[VisualScriptingMember(false, false)]
public static MyEntity GetEntityById(long id)
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

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetEntityByName(String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets specific entity by name. If there are more entities by same name, the first one created will be taken.", -10510688)]
[VisualScriptingMember(false, false)]
public static MyEntity GetEntityByName(string name)
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

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### GetEntityDirection(String, Base6Directions.Direction)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets vector in world coordination system representing entity's direction (e.g. Direction.Forward will return real forward vector of entity in world coordination system.)", -10510688)]
[VisualScriptingMember(false, false)]
public static Vector3D GetEntityDirection(string entityName, Base6Directions.Direction direction)
```

##### Parameters

Type

Name

Description

System.String

entityName

[Base6Directions.Direction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Base6Directions.Direction.html)

direction

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GetEntityIdFromEntity(MyEntity)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets entity id from specific entity.", -10510688)]
[VisualScriptingMember(false, false)]
public static long GetEntityIdFromEntity(MyEntity entity)
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

System.Int64

#### GetEntityIdFromName(String)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Returns entity id of specific entity ", -10510688)]
[VisualScriptingMember(false, false)]
public static long GetEntityIdFromName(string name)
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

System.Int64

#### GetEntityInventoryItemAmount(String, MyDefinitionId)

##### Declaration

```
[VisualScriptingMiscData("Entity", "Gets amount of specific items in inventory of entity. (rounded)", -10510688)]
[VisualScriptingMember(false, false)]
public static int GetEntityInventoryItemAmount(string entityName, MyDefinitionId itemId)
```

##### Parameters

Type

Name

Description

System.String

entityName

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

itemId
