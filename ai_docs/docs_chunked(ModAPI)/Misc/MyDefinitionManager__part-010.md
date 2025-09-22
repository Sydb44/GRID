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

[MyRespawnShipDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyRespawnShipDefinition.html)

#### GetRespawnShipDefinitions()

##### Declaration

```
public DictionaryReader<string, MyRespawnShipDefinition> GetRespawnShipDefinitions()
```

##### Returns

Type

Description

[DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.String, [MyRespawnShipDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyRespawnShipDefinition.html)\>

#### GetScenarioCategoryDefinitions()

##### Declaration

```
public ListReader<MyScenarioCategoryDefinition> GetScenarioCategoryDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyScenarioCategoryDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyScenarioCategoryDefinition.html)\>

#### GetScenarioDefinition(MyDefinitionId)

##### Declaration

```
public MyScenarioDefinition GetScenarioDefinition(MyDefinitionId id)
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

[MyScenarioDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyScenarioDefinition.html)

#### GetScenarioDefinitions()

##### Declaration

```
public ListReader<MyScenarioDefinition> GetScenarioDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyScenarioDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyScenarioDefinition.html)\>

#### GetSessionPreloadDefinitions()

Get the set of object builders that need additional data preloaded for session.

##### Declaration

```
public List<Tuple<MyObjectBuilder_Definitions, string>> GetSessionPreloadDefinitions()
```

##### Returns

Type

Description

System.Collections.Generic.List<System.Tuple<[MyObjectBuilder\_Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Definitions.html), System.String\>>

#### GetShipSoundsDefinition(MyDefinitionId)

##### Declaration

```
public MyShipSoundsDefinition GetShipSoundsDefinition(MyDefinitionId id)
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

[MyShipSoundsDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyShipSoundsDefinition.html)

#### GetSoundCategoryDefinitions()

##### Declaration

```
public ListReader<MySoundCategoryDefinition> GetSoundCategoryDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MySoundCategoryDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MySoundCategoryDefinition.html)\>

#### GetSoundDefinition(MyStringHash)

##### Declaration

```
public MyAudioDefinition GetSoundDefinition(MyStringHash subtypeId)
```

##### Parameters

Type

Name

Description

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

subtypeId

##### Returns

Type

Description

[MyAudioDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyAudioDefinition.html)

#### GetSoundDefinitions()

##### Declaration

```
public DictionaryValuesReader<MyDefinitionId, MyAudioDefinition> GetSoundDefinitions()
```

##### Returns

Type

Description

[DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyAudioDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyAudioDefinition.html)\>

#### GetSpawnGroupDefinition(Int32)

##### Declaration

```
public MySpawnGroupDefinition GetSpawnGroupDefinition(int index)
```

##### Parameters

Type

Name

Description

System.Int32

index

##### Returns

Type

Description

[MySpawnGroupDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MySpawnGroupDefinition.html)

#### GetSpawnGroupDefinitions()

##### Declaration

```
public ListReader<MySpawnGroupDefinition> GetSpawnGroupDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MySpawnGroupDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MySpawnGroupDefinition.html)\>

#### GetStoryCategoryDefinition(MyDefinitionId)

Get story category by id

##### Declaration

```
public MyStoryCategoryDefinition GetStoryCategoryDefinition(MyDefinitionId id)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

id

MyObjectBuilder\_StoryCategoryDefinition/Subtype

##### Returns

Type

Description

[MyStoryCategoryDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyStoryCategoryDefinition.html)

Definition or null

#### GetStoryDefinition(MyDefinitionId)

Get story by id

##### Declaration

```
public MyStoryDefinition GetStoryDefinition(MyDefinitionId id)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

id

MyObjectBuilder\_StoryDefinition/Subtype
