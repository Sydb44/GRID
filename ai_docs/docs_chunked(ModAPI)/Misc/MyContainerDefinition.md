---
title: "Class MyContainerDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyContainerDefinition"
---

# Class MyContainerDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyContainerDefinition

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyContainerDefinition : MyDefinitionBase
```

### Constructors

#### MyContainerDefinition()

##### Declaration

```
public MyContainerDefinition()
```

### Fields

#### DefaultComponents

##### Declaration

```
public List<MyContainerDefinition.DefaultComponent> DefaultComponents
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyContainerDefinition.DefaultComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyContainerDefinition.DefaultComponent.html)\> |     |

#### Flags

##### Declaration

```
public Nullable<EntityFlags> Flags
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html)\> |     |

### Methods

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

##### Overrides

#### HasDefaultComponent(String)

This will search through definitions to find if Default Components contains the searched component either as BuilderType, InstanceType, or ComponentType

##### Declaration

```
public bool HasDefaultComponent(string component)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | component | Name of the type to search for in defined default components |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if is defined component with the matching BuilderType, InstanceType or ComponentType |

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides