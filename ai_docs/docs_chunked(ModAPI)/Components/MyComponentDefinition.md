---
title: "Class MyComponentDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyComponentDefinition.html"
category: "Components"
namespace: "Sandbox.Definitions"
class: "MyComponentDefinition"
---

# Class MyComponentDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyComponentDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyComponentDefinition : MyPhysicalItemDefinition
```

### Constructors

#### MyComponentDefinition()

##### Declaration

```
public MyComponentDefinition()
```

### Fields

#### DeconstructionEfficiency

##### Declaration

```
public float DeconstructionEfficiency
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DropProbability

Chance that the damaged component will be dropped when damage is inflicted to a component stack. Percentage given as value from 0 to 1.

##### Declaration

```
public float DropProbability
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxIntegrity

HP of the component. Used when calculating overall HP of block from its components.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

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