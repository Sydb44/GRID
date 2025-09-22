---
title: "Class MyOxygenGeneratorDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyOxygenGeneratorDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyOxygenGeneratorDefinition"
---

# Class MyOxygenGeneratorDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyOxygenGeneratorDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyOxygenGeneratorDefinition : MyProductionBlockDefinition
```

### Constructors

#### MyOxygenGeneratorDefinition()

##### Declaration

```
public MyOxygenGeneratorDefinition()
```

### Fields

#### CanRefillBottles

##### Declaration

```
public bool CanRefillBottles
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GenerateSound

##### Declaration

```
public MySoundPair GenerateSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### IceConsumptionPerSecond

##### Declaration

```
public float IceConsumptionPerSecond
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IdleSound

##### Declaration

```
public MySoundPair IdleSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### OxygenGasId

##### Declaration

```
public static readonly MyDefinitionId OxygenGasId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### ProducedGases

##### Declaration

```
public List<MyOxygenGeneratorDefinition.MyGasGeneratorResourceInfo> ProducedGases
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyOxygenGeneratorDefinition.MyGasGeneratorResourceInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyOxygenGeneratorDefinition.MyGasGeneratorResourceInfo.html)\> |     |

#### ResourceSourceGroup

##### Declaration

```
public MyStringHash ResourceSourceGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

### Properties

#### FuelPullAmountFromConveyorInMinutes

##### Declaration

```
public float FuelPullAmountFromConveyorInMinutes { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### InventoryFillFactorMax

##### Declaration

```
public float InventoryFillFactorMax { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### InventoryFillFactorMin

##### Declaration

```
public float InventoryFillFactorMin { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsOxygenOnly

##### Declaration

```
public bool IsOxygenOnly { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

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