##### Declaration

```
public void ReloadHandItems()
```

#### ReloadParticles()

##### Declaration

```
public void ReloadParticles()
```

#### ReloadPrefabsFromFile(String)

##### Declaration

```
public void ReloadPrefabsFromFile(string filePath)
```

##### Parameters

Type

Name

Description

System.String

filePath

#### ReloadVoxelMaterials()

##### Declaration

```
public void ReloadVoxelMaterials()
```

#### Save(String)

##### Declaration

```
public void Save(string filePattern = "*.*")
```

##### Parameters

Type

Name

Description

System.String

filePattern

#### SaveHandItems()

##### Declaration

```
public void SaveHandItems()
```

#### SetEntityContainerDefinition(MyContainerDefinition)

##### Declaration

```
public void SetEntityContainerDefinition(MyContainerDefinition newDefinition)
```

##### Parameters

Type

Name

Description

[MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html)

newDefinition

#### SetShipSoundSystem()

##### Declaration

```
public void SetShipSoundSystem()
```

#### TryGetAnimationDefinition(String)

##### Declaration

```
public MyAnimationDefinition TryGetAnimationDefinition(string animationSubtypeName)
```

##### Parameters

Type

Name

Description

System.String

animationSubtypeName

##### Returns

Type

Description

VRage.Game.Definitions.Animation.MyAnimationDefinition

#### TryGetBlueprintDefinitionByResultId(MyDefinitionId)

##### Declaration

```
public MyBlueprintDefinitionBase TryGetBlueprintDefinitionByResultId(MyDefinitionId resultId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

resultId

##### Returns

Type

Description

[MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html)

#### TryGetBlueprintDefinitionByResultId(MyDefinitionId, out MyBlueprintDefinitionBase)

##### Declaration

```
public bool TryGetBlueprintDefinitionByResultId(MyDefinitionId resultId, out MyBlueprintDefinitionBase definition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

resultId

[MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html)

definition

##### Returns

Type

Description

System.Boolean

#### TryGetBotDefinition(MyDefinitionId, out MyBotDefinition)

##### Declaration

```
public bool TryGetBotDefinition(MyDefinitionId id, out MyBotDefinition botDefinition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

id

[MyBotDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBotDefinition.html)

botDefinition

##### Returns

Type

Description

System.Boolean

#### TryGetComponentBlockDefinition(MyDefinitionId)

##### Declaration

```
public MyCubeBlockDefinition TryGetComponentBlockDefinition(MyDefinitionId componentDefId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

componentDefId

##### Returns

Type

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

#### TryGetComponentBlueprintDefinition(MyDefinitionId, out MyBlueprintDefinitionBase)

##### Declaration

```
public bool TryGetComponentBlueprintDefinition(MyDefinitionId componentId, out MyBlueprintDefinitionBase componentBlueprint)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

componentId

[MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html)

componentBlueprint

##### Returns

Type

Description

System.Boolean

#### TryGetComponentDefinition(MyDefinitionId, out MyComponentDefinition)

##### Declaration

```
public bool TryGetComponentDefinition(MyDefinitionId id, out MyComponentDefinition definition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

id

[MyComponentDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyComponentDefinition.html)

definition

##### Returns

Type

Description

System.Boolean

#### TryGetComponentDefinition(MyObjectBuilderType, MyStringHash, out MyComponentDefinitionBase)

##### Declaration

```
public override bool TryGetComponentDefinition(MyObjectBuilderType type, MyStringHash subtypeName, out MyComponentDefinitionBase componentDefinition)
```

##### Parameters

Type

Name

Description

[MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html)

type

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

subtypeName

[MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html)

componentDefinition

##### Returns

Type

Description

System.Boolean

##### Overrides

#### TryGetContainerDefinition(MyDefinitionId, out MyContainerDefinition)

##### Declaration

```
public bool TryGetContainerDefinition(MyDefinitionId containerId, out MyContainerDefinition definition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

containerId

[MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html)

definition
