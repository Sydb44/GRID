```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Type | obType |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDefinitionPostprocessor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyDefinitionPostprocessor.html) |     |

#### GetSubtypes<T>()

##### Declaration

```
public HashSet<Type> GetSubtypes<T>()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<System.Type\> |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

#### RegisterTypesFromAssembly(Assembly)

##### Declaration

```
public static void RegisterTypesFromAssembly(Assembly assembly)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Reflection.Assembly | assembly |     |

#### TryGetComponentDefinition(MyObjectBuilderType, MyStringHash, out MyComponentDefinitionBase)

##### Declaration

```
public abstract bool TryGetComponentDefinition(MyObjectBuilderType type, MyStringHash subtypeName, out MyComponentDefinitionBase componentDefinition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeName |     |
| [MyComponentDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyComponentDefinitionBase.html) | componentDefinition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryGetContainerDefinition(MyObjectBuilderType, MyStringHash, out MyContainerDefinition)

##### Declaration

```
public abstract bool TryGetContainerDefinition(MyObjectBuilderType type, MyStringHash subtypeName, out MyContainerDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeName |     |
| [MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html) | definition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryGetDefinition<T>(MyStringHash, out T)

##### Declaration

```
public bool TryGetDefinition<T>(MyStringHash subtypeId, out T def)
    where T : MyDefinitionBase
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeId |     |
| T   | def |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |