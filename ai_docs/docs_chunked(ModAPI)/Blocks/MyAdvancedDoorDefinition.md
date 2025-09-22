---
title: "Class MyAdvancedDoorDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyAdvancedDoorDefinition.html"
category: "Blocks"
namespace: "Sandbox.Definitions"
class: "MyAdvancedDoorDefinition"
---

# Class MyAdvancedDoorDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyAdvancedDoorDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyAdvancedDoorDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyAdvancedDoorDefinition()

##### Declaration

```
public MyAdvancedDoorDefinition()
```

### Fields

#### OpeningSequence

##### Declaration

```
public MyObjectBuilder_AdvancedDoorDefinition.Opening[] OpeningSequence
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AdvancedDoorDefinition.Opening](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AdvancedDoorDefinition.Opening.html)\[\] |     |

#### PowerConsumptionIdle

##### Declaration

```
public float PowerConsumptionIdle
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PowerConsumptionMoving

##### Declaration

```
public float PowerConsumptionMoving
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ResourceSinkGroup

##### Declaration

```
public MyStringHash ResourceSinkGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### Subparts

##### Declaration

```
public MyObjectBuilder_AdvancedDoorDefinition.SubpartDefinition[] Subparts
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_AdvancedDoorDefinition.SubpartDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_AdvancedDoorDefinition.SubpartDefinition.html)\[\] |     |

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