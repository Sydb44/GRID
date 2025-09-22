---
title: "Class MyRefineryDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyRefineryDefinition.html"
category: "Production"
namespace: "Sandbox.Definitions"
class: "MyRefineryDefinition"
---

# Class MyRefineryDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyRefineryDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyRefineryDefinition : MyProductionBlockDefinition
```

### Constructors

#### MyRefineryDefinition()

##### Declaration

```
public MyRefineryDefinition()
```

### Fields

#### MaterialEfficiency

Percentage of material kept after refining process. Value is in range from 0 to 1, where 0.7 means that 30% of material is lost and 70% is kept.

##### Declaration

```
public float MaterialEfficiency
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OreAmountPerPullRequest

##### Declaration

```
public Nullable<MyFixedPoint> OreAmountPerPullRequest
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<VRage.MyFixedPoint\> |     |

#### RefineSpeed

Speed of refining ore in kg per hour.

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

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

#### BlueprintClassCanBeUsed(MyBlueprintClassDefinition)

##### Declaration

```
protected override bool BlueprintClassCanBeUsed(MyBlueprintClassDefinition blueprintClass)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBlueprintClassDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintClassDefinition.html) | blueprintClass |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

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

#### InitializeLegacyBlueprintClasses(MyObjectBuilder\_ProductionBlockDefinition)

##### Declaration

```
protected override void InitializeLegacyBlueprintClasses(MyObjectBuilder_ProductionBlockDefinition ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ProductionBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ProductionBlockDefinition.html) | ob  |     |

##### Overrides