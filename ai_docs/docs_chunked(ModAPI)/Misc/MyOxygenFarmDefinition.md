---
title: "Class MyOxygenFarmDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyOxygenFarmDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyOxygenFarmDefinition"
---

# Class MyOxygenFarmDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyOxygenFarmDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyOxygenFarmDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyOxygenFarmDefinition()

##### Declaration

```
public MyOxygenFarmDefinition()
```

### Fields

#### IsTwoSided

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxGasOutput

##### Declaration

```
public float MaxGasOutput
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OperationalPowerConsumption

##### Declaration

```
public float OperationalPowerConsumption
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PanelOffset

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PanelOrientation

##### Declaration

```
public Vector3 PanelOrientation
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### ProducedGas

##### Declaration

```
public MyDefinitionId ProducedGas
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### ResourceSinkGroup

##### Declaration

```
public MyStringHash ResourceSinkGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### ResourceSourceGroup

##### Declaration

```
public MyStringHash ResourceSourceGroup
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