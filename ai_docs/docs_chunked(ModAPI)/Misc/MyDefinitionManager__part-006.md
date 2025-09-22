##### Declaration

```
public ListReader<MyEdgesDefinition> GetEdgesDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyEdgesDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEdgesDefinition.html)\>

#### GetEmoteDefinitions()

##### Declaration

```
public IEnumerable<MyEmoteDefinition> GetEmoteDefinitions()
```

##### Returns

Type

Description

System.Collections.Generic.IEnumerable<[MyEmoteDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEmoteDefinition.html)\>

#### GetEntityComponentDefinition(MyDefinitionId)

##### Declaration

```
public MyComponentDefinitionBase GetEntityComponentDefinition(MyDefinitionId componentId)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

componentId

##### Returns

Type

Description

[MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html)

#### GetEntityComponentDefinitions()

##### Declaration

```
public ListReader<MyComponentDefinitionBase> GetEntityComponentDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html)\>

#### GetEntityComponentDefinitions<T>()

##### Declaration

```
public ListReader<T> GetEntityComponentDefinitions<T>()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<T>

##### Type Parameters

Name

Description

T

#### GetEnvironmentItemClassDefinitions()

##### Declaration

```
public ListReader<MyEnvironmentItemsDefinition> GetEnvironmentItemClassDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyEnvironmentItemsDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentItemsDefinition.html)\>

#### GetEnvironmentItemDefinition(MyDefinitionId)

##### Declaration

```
public MyEnvironmentItemDefinition GetEnvironmentItemDefinition(MyDefinitionId id)
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

[MyEnvironmentItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentItemDefinition.html)

#### GetEnvironmentItemDefinitions()

##### Declaration

```
public ListReader<MyEnvironmentItemDefinition> GetEnvironmentItemDefinitions()
```

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyEnvironmentItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEnvironmentItemDefinition.html)\>

#### GetEnvironmentItemsDefinitions(Int32)

##### Declaration

```
public ListReader<MyDefinitionId> GetEnvironmentItemsDefinitions(int channel)
```

##### Parameters

Type

Name

Description

System.Int32

channel

##### Returns

Type

Description

[ListReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ListReader-1.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

#### GetEventDefinition(MyDefinitionId)

##### Declaration

```
public MyGlobalEventDefinition GetEventDefinition(MyDefinitionId id)
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

[MyGlobalEventDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyGlobalEventDefinition.html)

#### GetFactionName(String)

##### Declaration

```
public MyFactionNameDefinition GetFactionName(string subtype)
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

[MyFactionNameDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyFactionNameDefinition.html)

#### GetFactionNameDefinitions()

##### Declaration

```
public DictionaryReader<MyDefinitionId, MyFactionNameDefinition> GetFactionNameDefinitions()
```

##### Returns

Type

Description

[DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html), [MyFactionNameDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyFactionNameDefinition.html)\>

#### GetFactionsFromDefinition()

Gets all factions from definition.

##### Declaration

```
public List<MyFactionDefinition> GetFactionsFromDefinition()
```

##### Returns

Type

Description

System.Collections.Generic.List<[MyFactionDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyFactionDefinition.html)\>

List of factions.

#### GetFirstRespawnShip()

##### Declaration

```
public string GetFirstRespawnShip()
```

##### Returns

Type

Description

System.String

#### GetGridCreator(MyStringHash)

##### Declaration

```
public MyGridCreateToolDefinition GetGridCreator(MyStringHash name)
```

##### Parameters

Type

Name

Description

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

name

##### Returns

Type

Description

[MyGridCreateToolDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyGridCreateToolDefinition.html)
