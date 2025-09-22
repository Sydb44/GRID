Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

containerId

[MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html)

definition

##### Returns

Type

Description

System.Boolean

#### TryGetContainerDefinition(MyObjectBuilderType, MyStringHash, out MyContainerDefinition)

##### Declaration

```
public override bool TryGetContainerDefinition(MyObjectBuilderType type, MyStringHash subtypeName, out MyContainerDefinition definition)
```

##### Parameters

Type

Name

Description

[MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html)

type

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

subtypeName

[MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html)

definition

##### Returns

Type

Description

System.Boolean

##### Overrides

#### TryGetCubeBlockDefinition(MyDefinitionId, out MyCubeBlockDefinition)

##### Declaration

```
public bool TryGetCubeBlockDefinition(MyDefinitionId defId, out MyCubeBlockDefinition blockDefinition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

defId

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

##### Returns

Type

Description

System.Boolean

#### TryGetDefinition<T>(MyDefinitionId, out T)

##### Declaration

```
public bool TryGetDefinition<T>(MyDefinitionId defId, out T definition)
    where T : MyDefinitionBase
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

defId

T

definition

##### Returns

Type

Description

System.Boolean

##### Type Parameters

Name

Description

T

#### TryGetDefinitionGroup(String)

##### Declaration

```
public MyCubeBlockDefinitionGroup TryGetDefinitionGroup(string groupName)
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

#### TryGetDefinitionsByTypeId(MyObjectBuilderType, HashSet<MyDefinitionId>)

##### Declaration

```
public void TryGetDefinitionsByTypeId(MyObjectBuilderType typeId, HashSet<MyDefinitionId> definitions)
```

##### Parameters

Type

Name

Description

[MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html)

typeId

System.Collections.Generic.HashSet<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

definitions

#### TryGetEntityComponentDefinition(MyDefinitionId, out MyComponentDefinitionBase)

##### Declaration

```
public bool TryGetEntityComponentDefinition(MyDefinitionId componentId, out MyComponentDefinitionBase definition)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

componentId

[MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html)

definition

##### Returns

Type

Description

System.Boolean

#### TryGetFactionDefinition(String)

##### Declaration

```
public MyFactionDefinition TryGetFactionDefinition(string tag)
```

##### Parameters

Type

Name

Description

System.String

tag

##### Returns

Type

Description

[MyFactionDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyFactionDefinition.html)

#### TryGetHandItemDefinition(ref MyDefinitionId)

##### Declaration

```
public MyHandItemDefinition TryGetHandItemDefinition(ref MyDefinitionId id)
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

[MyHandItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyHandItemDefinition.html)

#### TryGetHandItemForPhysicalItem(MyDefinitionId)

##### Declaration

```
public MyHandItemDefinition TryGetHandItemForPhysicalItem(MyDefinitionId physicalItemId)
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

[MyHandItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyHandItemDefinition.html)

#### TryGetIngotBlueprintDefinition(MyDefinitionId, out MyBlueprintDefinitionBase)

##### Declaration

```
public bool TryGetIngotBlueprintDefinition(MyDefinitionId oreId, out MyBlueprintDefinitionBase ingotBlueprint)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

oreId

[MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html)

ingotBlueprint

##### Returns

Type

Description

System.Boolean

#### TryGetIngotBlueprintDefinition(MyObjectBuilder\_Base, out MyBlueprintDefinitionBase)

##### Declaration

```
public bool TryGetIngotBlueprintDefinition(MyObjectBuilder_Base oreBuilder, out MyBlueprintDefinitionBase ingotBlueprint)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html)

oreBuilder

[MyBlueprintDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html)

ingotBlueprint
