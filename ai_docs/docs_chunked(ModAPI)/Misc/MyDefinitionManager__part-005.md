Description

[MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html)

gridSize

##### Returns

Type

Description

System.Single

#### GetDebrisDefinitions()

##### Declaration

```
public ListReader<MyDebrisDefinition> GetDebrisDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyDebrisDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyDebrisDefinition.html)\>

#### GetDebugScreenSearchCache()

##### Declaration

```
public DictionaryValuesReader<MyDefinitionId, MyDebugScreenSearchCacheDefinition> GetDebugScreenSearchCache()
```

##### Returns

Type

Description

[DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyDebugScreenSearchCacheDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyDebugScreenSearchCacheDefinition.html)\>

#### GetDefaultFactions()

Gets default factions.

##### Declaration

```
public List<MyFactionDefinition> GetDefaultFactions()
```

##### Returns

Type

Description

System.Collections.Generic.List<[MyFactionDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyFactionDefinition.html)\>

List of default factions.

#### GetDefaultVoxelMaterialDefinition()

##### Declaration

```
public MyVoxelMaterialDefinition GetDefaultVoxelMaterialDefinition()
```

##### Returns

Type

Description

[MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html)

#### GetDefinedEntityComponents(ref List<MyDefinitionId>)

##### Declaration

```
public void GetDefinedEntityComponents(ref List<MyDefinitionId> definedComponents)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

definedComponents

#### GetDefinedEntityContainers(ref List<MyDefinitionId>)

##### Declaration

```
public void GetDefinedEntityContainers(ref List<MyDefinitionId> definedContainers)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

definedContainers

#### GetDefinition(MyDefinitionId)

##### Declaration

```
public MyDefinitionBase GetDefinition(MyDefinitionId id)
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

[MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html)

#### GetDefinitionGroup(String)

##### Declaration

```
public MyCubeBlockDefinitionGroup GetDefinitionGroup(string groupName)
```

##### Parameters

Type

Name

Description

System.String

groupName

##### Returns

Type

Description

[MyCubeBlockDefinitionGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinitionGroup.html)

#### GetDefinitionPairNames()

##### Declaration

```
public DictionaryKeysReader<string, MyCubeBlockDefinitionGroup> GetDefinitionPairNames()
```

##### Returns

Type

Description

[DictionaryKeysReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryKeysReader-2.html)<System.String, [MyCubeBlockDefinitionGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinitionGroup.html)\>

#### GetDefinitionPairs()

##### Declaration

```
public Dictionary<string, MyCubeBlockDefinitionGroup> GetDefinitionPairs()
```

##### Returns

Type

Description

System.Collections.Generic.Dictionary<System.String, [MyCubeBlockDefinitionGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinitionGroup.html)\>

#### GetDefinitionsOfType<T>()

##### Declaration

```
public ListReader<T> GetDefinitionsOfType<T>()
    where T : MyDefinitionBase
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<T>

##### Type Parameters

Name

Description

T

#### GetDropContainerDefinition(String)

##### Declaration

```
public MyDropContainerDefinition GetDropContainerDefinition(string id)
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

[MyDropContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyDropContainerDefinition.html)

#### GetDropContainerDefinitions()

##### Declaration

```
public DictionaryReader<string, MyDropContainerDefinition> GetDropContainerDefinitions()
```

##### Returns

Type

Description

[DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.String, [MyDropContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyDropContainerDefinition.html)\>

#### GetEdgesDefinition(MyDefinitionId)

##### Declaration

```
public MyEdgesDefinition GetEdgesDefinition(MyDefinitionId id)
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

[MyEdgesDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEdgesDefinition.html)

#### GetEdgesDefinitions()

##### Declaration

```
public ListReader<MyEdgesDefinition> GetEdgesDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyEdgesDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEdgesDefinition.html)\>
