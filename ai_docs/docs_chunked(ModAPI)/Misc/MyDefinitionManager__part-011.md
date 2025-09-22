##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

id

MyObjectBuilder\_StoryDefinition/Subtype

##### Returns

Type

Description

[MyStoryDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyStoryDefinition.html)

Definition or null

#### GetStoryDefinitions(MyDefinitionId)

Get stories by category id

##### Declaration

```
public ListReader<MyStoryDefinition> GetStoryDefinitions(MyDefinitionId categoryDefinition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

categoryDefinition

MyObjectBuilder\_StoryCategoryDefinition/Subtype

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyStoryDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyStoryDefinition.html)\>

List of story definitions or empty list

#### GetTagDefinition(String)

Get blocks tag defenition

##### Declaration

```
public MyCubeBlockTagDefinition GetTagDefinition(string blockTypeKey)
```

##### Parameters

Type

Name

Description

System.String

blockTypeKey

SubtypeId of Tag

##### Returns

Type

Description

[MyCubeBlockTagDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockTagDefinition.html)

Tag definition

#### GetTargetingGroupDefinitions(List<MyTargetingGroupDefinition>)

##### Declaration

```
public List<MyTargetingGroupDefinition> GetTargetingGroupDefinitions(List<MyTargetingGroupDefinition> list = null)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyTargetingGroupDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyTargetingGroupDefinition.html)\>

list

##### Returns

Type

Description

System.Collections.Generic.List<[MyTargetingGroupDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyTargetingGroupDefinition.html)\>

#### GetTransparentMaterialDefinitions()

##### Declaration

```
public ListReader<MyTransparentMaterialDefinition> GetTransparentMaterialDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyTransparentMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyTransparentMaterialDefinition.html)\>

#### GetVoxelHandDefinitions()

##### Declaration

```
public ListReader<MyVoxelHandDefinition> GetVoxelHandDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyVoxelHandDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyVoxelHandDefinition.html)\>

#### GetVoxelMapStorageDefinitions()

##### Declaration

```
public ListReader<MyVoxelMapStorageDefinition> GetVoxelMapStorageDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyVoxelMapStorageDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyVoxelMapStorageDefinition.html)\>

#### GetVoxelMapStorageDefinitionsForProceduralAdditions()

##### Declaration

```
public ListReader<MyVoxelMapStorageDefinition> GetVoxelMapStorageDefinitionsForProceduralAdditions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyVoxelMapStorageDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyVoxelMapStorageDefinition.html)\>

#### GetVoxelMapStorageDefinitionsForProceduralPrimaryAdditions()

##### Declaration

```
public ListReader<MyVoxelMapStorageDefinition> GetVoxelMapStorageDefinitionsForProceduralPrimaryAdditions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyVoxelMapStorageDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyVoxelMapStorageDefinition.html)\>

#### GetVoxelMapStorageDefinitionsForProceduralRemovals()

##### Declaration

```
public ListReader<MyVoxelMapStorageDefinition> GetVoxelMapStorageDefinitionsForProceduralRemovals()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyVoxelMapStorageDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyVoxelMapStorageDefinition.html)\>

#### GetVoxelMaterialDefinition(Byte)

##### Declaration

```
public MyVoxelMaterialDefinition GetVoxelMaterialDefinition(byte materialIndex)
```

##### Parameters

Type

Name

Description

System.Byte

materialIndex

##### Returns

Type

Description

[MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html)

#### GetVoxelMaterialDefinition(String)

##### Declaration

```
public MyVoxelMaterialDefinition GetVoxelMaterialDefinition(string name)
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

[MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html)

#### GetVoxelMaterialDefinitions()

##### Declaration

```
public DictionaryValuesReader<string, MyVoxelMaterialDefinition> GetVoxelMaterialDefinitions()
```

##### Returns

Type

Description

[DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<System.String, [MyVoxelMaterialDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html)\>
