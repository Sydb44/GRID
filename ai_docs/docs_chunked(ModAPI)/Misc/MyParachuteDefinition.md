---
title: "Class MyParachuteDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyParachuteDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyParachuteDefinition"
---

# Class MyParachuteDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyParachuteDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyParachuteDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyParachuteDefinition()

##### Declaration

```
public MyParachuteDefinition()
```

### Fields

#### DragCoefficient

##### Declaration

```
public float DragCoefficient
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaterialDefinitionId

##### Declaration

```
public MyDefinitionId MaterialDefinitionId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### MaterialDeployCost

##### Declaration

```
public int MaterialDeployCost
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MinimumAtmosphereLevel

##### Declaration

```
public float MinimumAtmosphereLevel
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OpeningSequence

##### Declaration

```
public MyObjectBuilder_ParachuteDefinition.Opening[] OpeningSequence
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ParachuteDefinition.Opening](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_ParachuteDefinition.Opening.html)\[\] |     |

#### ParachuteSubpartName

##### Declaration

```
public string ParachuteSubpartName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

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

#### RadiusMultiplier

##### Declaration

```
public float RadiusMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ReefAtmosphereLevel

##### Declaration

```
public float ReefAtmosphereLevel
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
public MyObjectBuilder_ParachuteDefinition.SubpartDefinition[] Subparts
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ParachuteDefinition.SubpartDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_ParachuteDefinition.SubpartDefinition.html)\[\] |     |

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