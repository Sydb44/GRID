---
title: "Class MyDefinitionManager"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyDefinitionManager.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyDefinitionManager"
---

# Class MyDefinitionManager | Space Engineers ModAPI

##### Inheritance

System.Object

MyDefinitionManager

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[PreloadRequired]
public class MyDefinitionManager : MyDefinitionManagerBase
```

### Properties

#### Characters

##### Declaration

```
public DictionaryValuesReader<string, MyCharacterDefinition> Characters { get; }
```

##### Property Value

Type

Description

[DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<System.String, [MyCharacterDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCharacterDefinition.html)\>

#### EnvironmentDefinition

##### Declaration

```
public MyEnvironmentDefinition EnvironmentDefinition { get; }
```

##### Property Value

Type

Description

[MyEnvironmentDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentDefinition.html)

#### GetShipSoundSystemDefinition

##### Declaration

```
public MyShipSoundSystemDefinition GetShipSoundSystemDefinition { get; }
```

##### Property Value

Type

Description

[MyShipSoundSystemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyShipSoundSystemDefinition.html)

#### Loading

##### Declaration

```
public bool Loading { get; }
```

##### Property Value

Type

Description

System.Boolean

#### Static

##### Declaration

```
public static MyDefinitionManager Static { get; }
```

##### Property Value

Type

Description

[MyDefinitionManager](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyDefinitionManager.html)

#### VoxelMaterialCount

##### Declaration

```
public int VoxelMaterialCount { get; }
```

##### Property Value

Type

Description

System.Int32

#### VoxelMaterialRareCount

##### Declaration

```
public int VoxelMaterialRareCount { get; }
```

##### Property Value

Type

Description

System.Int32

### Methods

#### AddMissingWheelModelDefinition(String)

##### Declaration

```
public void AddMissingWheelModelDefinition(string wheelType)
```

##### Parameters

Type

Name

Description

System.String

wheelType

#### GetAllDefinitions()

##### Declaration

```
public DictionaryValuesReader<MyDefinitionId, MyDefinitionBase> GetAllDefinitions()
```

##### Returns

Type

Description

[DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html)\>

#### GetAllSessionPreloadObjectBuilders()

Load and return all object builders needed for a session.

##### Declaration

```
public List<Tuple<MyObjectBuilder_Definitions, string>> GetAllSessionPreloadObjectBuilders()
```

##### Returns

Type

Description

System.Collections.Generic.List<System.Tuple<[MyObjectBuilder\_Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Definitions.html), System.String\>>

#### GetAllStoriesDefinition(MyDefinitionId)

Get all stories

##### Declaration

```
public DictionaryReader<MyDefinitionId, MyStoryDefinition> GetAllStoriesDefinition(MyDefinitionId categoryDefinition)
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

[DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyStoryDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyStoryDefinition.html)\>

Dictionary of all story definitions

#### GetAllStoryCategoriesDefinition(MyDefinitionId)

Get all story categories id

##### Declaration

```
public DictionaryReader<MyDefinitionId, MyStoryCategoryDefinition> GetAllStoryCategoriesDefinition(MyDefinitionId categoryDefinition)
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

[DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyStoryCategoryDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyStoryCategoryDefinition.html)\>

Dictionary of story definitions or empty list

#### GetAmmoDefinition(MyDefinitionId)

##### Declaration

```
public MyAmmoDefinition GetAmmoDefinition(MyDefinitionId id)
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

[MyAmmoDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyAmmoDefinition.html)

#### GetAmmoMagazineDefinition(MyDefinitionId)

##### Declaration

```
public MyAmmoMagazineDefinition GetAmmoMagazineDefinition(MyDefinitionId id)
```
