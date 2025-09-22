---
title: "Class MyTurretControlBlockDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyTurretControlBlockDefinition.html"
category: "Weapons"
namespace: "Sandbox.Definitions"
class: "MyTurretControlBlockDefinition"
---

# Class MyTurretControlBlockDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyTurretControlBlockDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyTurretControlBlockDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyTurretControlBlockDefinition()

##### Declaration

```
public MyTurretControlBlockDefinition()
```

### Fields

#### MaxRangeMeters

##### Declaration

```
public float MaxRangeMeters
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PidGainDerivative

##### Declaration

```
public float PidGainDerivative
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PidGainFilter

##### Declaration

```
public float PidGainFilter
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PidGainIntegral

##### Declaration

```
public float PidGainIntegral
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PidGainProportional

##### Declaration

```
public float PidGainProportional
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PlayerInputDivider

##### Declaration

```
public float PlayerInputDivider
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PowerInputIdle

##### Declaration

```
public float PowerInputIdle
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