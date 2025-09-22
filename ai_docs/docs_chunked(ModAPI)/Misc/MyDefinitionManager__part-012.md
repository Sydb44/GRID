##### Declaration

```
public DictionaryValuesReader<string, MyVoxelMaterialDefinition> GetVoxelMaterialDefinitions()
```

##### Returns

Type

Description

[DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<System.String, [MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html)\>

#### GetWeaponDefinition(MyDefinitionId)

##### Declaration

```
public MyWeaponDefinition GetWeaponDefinition(MyDefinitionId id)
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

[MyWeaponDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyWeaponDefinition.html)

#### GetWeaponDefinitions()

##### Declaration

```
public ListReader<MyPhysicalItemDefinition> GetWeaponDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyPhysicalItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalItemDefinition.html)\>

#### GetWeatherDefinitions()

##### Declaration

```
public ListReader<MyWeatherEffectDefinition> GetWeatherDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyWeatherEffectDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyWeatherEffectDefinition.html)\>

#### GetWeatherEffect(String)

##### Declaration

```
public MyWeatherEffectDefinition GetWeatherEffect(string subtype)
```

##### Parameters

Type

Name

Description

System.String

subtype

##### Returns

Type

Description

[MyWeatherEffectDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyWeatherEffectDefinition.html)

#### GetWheelModelDefinitions()

##### Declaration

```
public DictionaryReader<string, MyWheelModelsDefinition> GetWheelModelDefinitions()
```

##### Returns

Type

Description

[DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.String, [MyWheelModelsDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyWheelModelsDefinition.html)\>

#### HandItemExistsFor(MyDefinitionId)

##### Declaration

```
public bool HandItemExistsFor(MyDefinitionId physicalItemId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

physicalItemId

##### Returns

Type

Description

System.Boolean

#### HasBlueprint(MyDefinitionId)

##### Declaration

```
public bool HasBlueprint(MyDefinitionId blueprintId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

blueprintId

##### Returns

Type

Description

System.Boolean

#### HasDefaultTargetingGroup(MyObjectBuilderType, MyStringHash)

##### Declaration

```
public bool HasDefaultTargetingGroup(MyObjectBuilderType type, MyStringHash hash)
```

##### Parameters

Type

Name

Description

[MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html)

type

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

hash

##### Returns

Type

Description

System.Boolean

#### HasRespawnShip(String)

##### Declaration

```
public bool HasRespawnShip(string id)
```

##### Parameters

Type

Name

Description

System.String

id

##### Returns

Type

Description

System.Boolean

#### InitVoxelMaterials()

##### Declaration

```
public void InitVoxelMaterials()
```

#### IsComponentBlock(MyDefinitionId)

##### Declaration

```
public bool IsComponentBlock(MyDefinitionId blockDefinitionId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

blockDefinitionId

##### Returns

Type

Description

System.Boolean

#### ItemIdFromWeaponId(MyDefinitionId)

##### Declaration

```
public Nullable<MyDefinitionId> ItemIdFromWeaponId(MyDefinitionId weaponDefinition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

weaponDefinition

##### Returns

Type

Description

System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

#### LoadData(List<MyObjectBuilder\_Checkpoint.ModItem>)

##### Declaration

```
public void LoadData(List<MyObjectBuilder_Checkpoint.ModItem> mods)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyObjectBuilder\_Checkpoint.ModItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Checkpoint.ModItem.html)\>

mods

#### LoadScenarios()

##### Declaration

```
public void LoadScenarios()
```

#### PreloadDefinitions()

##### Declaration

```
public void PreloadDefinitions()
```

#### RegisterFactionDefinition(MyFactionDefinition)

##### Declaration

```
public void RegisterFactionDefinition(MyFactionDefinition definition)
```

##### Parameters

Type

Name

Description

[MyFactionDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyFactionDefinition.html)

definition

#### ReloadDecalMaterials()

##### Declaration

```
public void ReloadDecalMaterials()
```

#### ReloadHandItems()

##### Declaration

```
public void ReloadHandItems()
```

#### ReloadParticles()

##### Declaration

```
public void ReloadParticles()
```
