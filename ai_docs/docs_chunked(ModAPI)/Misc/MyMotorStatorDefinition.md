---
title: "Class MyMotorStatorDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyMotorStatorDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyMotorStatorDefinition"
---

# Class MyMotorStatorDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyMotorStatorDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyMotorStatorDefinition : MyMechanicalConnectionBlockBaseDefinition
```

### Constructors

#### MyMotorStatorDefinition()

##### Declaration

```
public MyMotorStatorDefinition()
```

### Fields

#### ForbiddenTopPartSubtypes

##### Declaration

```
public List<MyStringHash> ForbiddenTopPartSubtypes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> |     |

#### MaxAngleDeg

##### Declaration

```
public Nullable<float> MaxAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### MaxForceMagnitude

##### Declaration

```
public float MaxForceMagnitude
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinAngleDeg

##### Declaration

```
public Nullable<float> MinAngleDeg
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### RequiredPowerInput

##### Declaration

```
public float RequiredPowerInput
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

#### RotorDisplacementInModel

##### Declaration

```
public float RotorDisplacementInModel
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotorDisplacementMax

##### Declaration

```
public float RotorDisplacementMax
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotorDisplacementMaxSmall

##### Declaration

```
public float RotorDisplacementMaxSmall
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotorDisplacementMin

##### Declaration

```
public float RotorDisplacementMin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotorDisplacementMinSmall

##### Declaration

```
public float RotorDisplacementMinSmall
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotorType

##### Declaration

```
public MyRotorType RotorType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyRotorType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Common.ObjectBuilders.Definitions.MyRotorType.html) |     |

#### UnsafeTorqueThreshold

##### Declaration

```
public float UnsafeTorqueThreshold
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

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