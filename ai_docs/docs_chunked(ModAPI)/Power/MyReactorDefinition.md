---
title: "Class MyReactorDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyReactorDefinition.html"
category: "Power"
namespace: "Sandbox.Definitions"
class: "MyReactorDefinition"
---

# Class MyReactorDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyReactorDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyReactorDefinition : MyFueledPowerProducerDefinition
```

### Constructors

#### MyReactorDefinition()

##### Declaration

```
public MyReactorDefinition()
```

### Fields

#### FuelInfos

##### Declaration

```
public MyReactorDefinition.FuelInfo[] FuelInfos
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyReactorDefinition.FuelInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyReactorDefinition.FuelInfo.html)\[\] |     |

#### InventoryConstraint

##### Declaration

```
public MyInventoryConstraint InventoryConstraint
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyInventoryConstraint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventoryConstraint.html) |     |

#### InventoryMaxVolume

##### Declaration

```
public float InventoryMaxVolume
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### InventorySize

##### Declaration

```
public Vector3 InventorySize
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

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