---
title: "Class MyControllerSchemeDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyControllerSchemeDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyControllerSchemeDefinition"
---

# Class MyControllerSchemeDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyControllerSchemeDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyControllerSchemeDefinition : MyDefinitionBase
```

### Constructors

#### MyControllerSchemeDefinition()

##### Declaration

```
public MyControllerSchemeDefinition()
```

### Fields

#### Contexts

##### Declaration

```
public List<MyObjectBuilder_ControlBindingContext> Contexts
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_ControlBindingContext](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.MyObjectBuilder_ControlBindingContext.html)\> |     |

#### ControlScheme

##### Declaration

```
public ControlScheme ControlScheme
```

##### Field Value

| Type | Description |
| --- | --- |
| [ControlScheme](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.ControlScheme.html) |     |

#### IsDefault

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsJoystickScheme

##### Declaration

```
public bool IsJoystickScheme
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsSelectable

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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