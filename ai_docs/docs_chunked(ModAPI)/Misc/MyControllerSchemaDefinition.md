---
title: "Class MyControllerSchemaDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyControllerSchemaDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyControllerSchemaDefinition"
---

# Class MyControllerSchemaDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyControllerSchemaDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyControllerSchemaDefinition : MyDefinitionBase
```

### Constructors

#### MyControllerSchemaDefinition()

##### Declaration

```
public MyControllerSchemaDefinition()
```

### Fields

#### CompatibleDevices

##### Declaration

```
public List<int> CompatibleDevices
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.Int32\> |     |

#### Schemas

##### Declaration

```
public Dictionary<string, List<MyControllerSchemaDefinition.ControlGroup>> Schemas
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<[MyControllerSchemaDefinition.ControlGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyControllerSchemaDefinition.ControlGroup.html)\>> |     |

### Methods

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