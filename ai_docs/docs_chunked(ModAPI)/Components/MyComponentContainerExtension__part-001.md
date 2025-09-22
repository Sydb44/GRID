---
title: "Class MyComponentContainerExtension"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyComponentContainerExtension.html"
category: "Components"
namespace: "Sandbox.Game.Entities"
class: "MyComponentContainerExtension"
---

# Class MyComponentContainerExtension | Space Engineers ModAPI

TODO: This should be later ideally some factory rather than just an extension on the MyComponentContainer

##### Inheritance

System.Object

MyComponentContainerExtension

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyComponentContainerExtension : Object
```

### Methods

#### FindComponentBuilder(MyContainerDefinition.DefaultComponent, MyObjectBuilder\_ComponentContainer)

##### Declaration

```
public static MyObjectBuilder_ComponentBase FindComponentBuilder(MyContainerDefinition.DefaultComponent component, MyObjectBuilder_ComponentContainer builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContainerDefinition.DefaultComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.DefaultComponent.html) | component |     |
| [MyObjectBuilder\_ComponentContainer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentContainer.html) | builder |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) |     |

#### InitComponents(IMyComponentContainer, MyObjectBuilderType, MyStringHash, MyObjectBuilder\_ComponentContainer)

Tries to retrieve entity definition of the entity owning this container, check if the definition has some DefaultComponents, tries to retrieve these components definitions, create these components instances and add them

TODO: This should be ideally a behavior of the MyEntityComponentContainer when it is initialized (deserialized).. or by the factory, for now, this is an extension method

##### Declaration

```
public static void InitComponents(this IMyComponentContainer container, MyObjectBuilderType type, MyStringHash subtypeName, MyObjectBuilder_ComponentContainer builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Components.Interfaces.IMyComponentContainer | container |     |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeName |     |
| [MyObjectBuilder\_ComponentContainer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentContainer.html) | builder |     |

#### TryAddComponent(Int64, String, String)

This will try to parse strings to types and create an instance of the component type. Don't use this in retail code, use for debug, modding etc.

##### Declaration

```
public static bool TryAddComponent(long entityId, string instanceTypeStr, string componentTypeStr)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId | Id of entity which should get the component |
| System.String | instanceTypeStr | Type of the component instance, no the base type |
| System.String | componentTypeStr | The base type of the component to be added |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true on success |

#### TryAddComponent(Int64, MyDefinitionId)

This will look for the component definition and if found, it will create its instance and add to the entity with the give id

##### Declaration

```
public static bool TryAddComponent(long entityId, MyDefinitionId componentDefinitionId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | componentDefinitionId |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true on success |

#### TryGetComponentDefinition(MyObjectBuilderType, MyStringHash, out MyComponentDefinitionBase)

##### Declaration

```
public static bool TryGetComponentDefinition(MyObjectBuilderType type, MyStringHash subtypeName, out MyComponentDefinitionBase componentDefinition)
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
public static bool TryGetContainerDefinition(MyObjectBuilderType type, MyStringHash subtypeName, out MyContainerDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) | type |     |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | subtypeName |     |
| [MyContainerDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html) | definition |     |
