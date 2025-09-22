##### Declaration

```
public ListReader<MyPhysicalItemDefinition> GetConsumableDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyPhysicalItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalItemDefinition.html)\>

#### GetContainerDefinition(MyDefinitionId)

##### Declaration

```
public MyContainerDefinition GetContainerDefinition(MyDefinitionId containerId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

containerId

##### Returns

Type

Description

[MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html)

#### GetContainerTypeDefinition(String)

##### Declaration

```
public MyContainerTypeDefinition GetContainerTypeDefinition(string containerName)
```

##### Parameters

Type

Name

Description

System.String

containerName

##### Returns

Type

Description

[MyContainerTypeDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContainerTypeDefinition.html)

#### GetContainerTypeDefinition(MyDefinitionId)

##### Declaration

```
public MyContainerTypeDefinition GetContainerTypeDefinition(MyDefinitionId id)
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

[MyContainerTypeDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContainerTypeDefinition.html)

#### GetContractType(String)

##### Declaration

```
public MyContractTypeDefinition GetContractType(string subtype)
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

[MyContractTypeDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContractTypeDefinition.html)

#### GetContractTypeDefinitions()

##### Declaration

```
public DictionaryReader<MyDefinitionId, MyContractTypeDefinition> GetContractTypeDefinitions()
```

##### Returns

Type

Description

[DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyContractTypeDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContractTypeDefinition.html)\>

#### GetControllerScheme(String)

##### Declaration

```
public MyControllerSchemeDefinition GetControllerScheme(string subtype = "General")
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

[MyControllerSchemeDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyControllerSchemeDefinition.html)

#### GetControllerSchemesAll()

##### Declaration

```
public ListReader<MyControllerSchemeDefinition> GetControllerSchemesAll()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyControllerSchemeDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyControllerSchemeDefinition.html)\>

#### GetControllerSchemesSelectable()

##### Declaration

```
public List<MyControllerSchemeDefinition> GetControllerSchemesSelectable()
```

##### Returns

Type

Description

System.Collections.Generic.List<[MyControllerSchemeDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyControllerSchemeDefinition.html)\>

#### GetCubeBlockDefinition(MyDefinitionId)

##### Declaration

```
public MyCubeBlockDefinition GetCubeBlockDefinition(MyDefinitionId id)
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

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

#### GetCubeBlockDefinition(MyObjectBuilder\_CubeBlock)

##### Declaration

```
public MyCubeBlockDefinition GetCubeBlockDefinition(MyObjectBuilder_CubeBlock builder)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

builder

##### Returns

Type

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

#### GetCubeBlockScreenPosition(MyCubeBlockDefinitionGroup)

##### Declaration

```
public Vector2I GetCubeBlockScreenPosition(MyCubeBlockDefinitionGroup blockDefinitionGroup)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinitionGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinitionGroup.html)

blockDefinitionGroup

##### Returns

Type

Description

[Vector2I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2I.html)

#### GetCubeSize(MyCubeSize)

##### Declaration

```
public float GetCubeSize(MyCubeSize gridSize)
```

##### Parameters

Type

Name

Description

[MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html)

gridSize

##### Returns

Type

Description

System.Single

#### GetCubeSizeOriginal(MyCubeSize)

##### Declaration

```
public float GetCubeSizeOriginal(MyCubeSize gridSize)
```

##### Parameters

Type

Name

Description

[MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html)

gridSize

##### Returns

Type

Description

System.Single
