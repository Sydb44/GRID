##### Declaration

```
public static bool TryGetContainerDefinition(MyObjectBuilderType type, MyStringHash subtypeName, out MyContainerDefinition definition)
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

#### TryGetEntityComponentTypes(Int64, out List<Type>)

This will retrieve component types in the entity container. This method allocates, use only for debugging etc.

##### Declaration

```
public static bool TryGetEntityComponentTypes(long entityId, out List<Type> components)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Collections.Generic.List<System.Type\> | components |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if success |

#### TryRemoveComponent(Int64, Type)

##### Declaration

```
public static bool TryRemoveComponent(long entityId, Type componentType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Type | componentType |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |