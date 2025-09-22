Type

Name

Description

[MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html)

oreBuilder

[MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html)

ingotBlueprint

##### Returns

Type

Description

System.Boolean

#### TryGetPhysicalItemDefinition(MyDefinitionId)

##### Declaration

```
public MyPhysicalItemDefinition TryGetPhysicalItemDefinition(MyDefinitionId id)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

id

##### Returns

Type

Description

[MyPhysicalItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalItemDefinition.html)

#### TryGetPhysicalItemDefinition(MyDefinitionId, out MyPhysicalItemDefinition)

##### Declaration

```
public bool TryGetPhysicalItemDefinition(MyDefinitionId id, out MyPhysicalItemDefinition definition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

id

[MyPhysicalItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalItemDefinition.html)

definition

##### Returns

Type

Description

System.Boolean

#### TryGetSpawnGroupDefinition(String, out MySpawnGroupDefinition)

##### Declaration

```
public bool TryGetSpawnGroupDefinition(string spawnGroupSubtypeName, out MySpawnGroupDefinition spawnGroupDefinition)
```

##### Parameters

Type

Name

Description

System.String

spawnGroupSubtypeName

[MySpawnGroupDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MySpawnGroupDefinition.html)

spawnGroupDefinition

##### Returns

Type

Description

System.Boolean

#### TryGetVoxelMapStorageDefinition(String, out MyVoxelMapStorageDefinition)

##### Declaration

```
public bool TryGetVoxelMapStorageDefinition(string name, out MyVoxelMapStorageDefinition definition)
```

##### Parameters

Type

Name

Description

System.String

name

[MyVoxelMapStorageDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyVoxelMapStorageDefinition.html)

definition

##### Returns

Type

Description

System.Boolean

#### TryGetVoxelMaterialDefinition(String, out MyVoxelMaterialDefinition)

##### Declaration

```
public bool TryGetVoxelMaterialDefinition(string name, out MyVoxelMaterialDefinition definition)
```

##### Parameters

Type

Name

Description

System.String

name

[MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html)

definition

##### Returns

Type

Description

System.Boolean

#### TryGetWeaponDefinition(MyDefinitionId, out MyWeaponDefinition)

##### Declaration

```
public bool TryGetWeaponDefinition(MyDefinitionId defId, out MyWeaponDefinition definition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

defId

[MyWeaponDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyWeaponDefinition.html)

definition

##### Returns

Type

Description

System.Boolean

#### UnloadData(Boolean)

##### Declaration

```
public void UnloadData(bool clearPreloaded = false)
```

##### Parameters

Type

Name

Description

System.Boolean

clearPreloaded

### Events

#### SBCLoaded

##### Declaration

```
public event Action<string> SBCLoaded
```

##### Event Type

Type

Description

System.Action<System.String\>