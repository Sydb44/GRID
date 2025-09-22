---
title: "Class MyBlueprintDefinitionBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyBlueprintDefinitionBase"
---

# Class MyBlueprintDefinitionBase | Space Engineers ModAPI

##### Inheritance

System.Object

MyBlueprintDefinitionBase

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyBlueprintDefinitionBase : MyDefinitionBase
```

### Constructors

#### MyBlueprintDefinitionBase()

##### Declaration

```
protected MyBlueprintDefinitionBase()
```

### Fields

#### Atomic

Whether the the blueprint's outputs have to be produced as a whole at once (because you cannot divide some output items)

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### BaseProductionTimeInSeconds

Base production time in seconds, which is affected by speed increase of refinery or assembler.

##### Declaration

```
public float BaseProductionTimeInSeconds
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IgnoreEfficiencyMultiplier

##### Declaration

```
public bool IgnoreEfficiencyMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPrimary

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OutputVolume

Total volume of products created by one unit of blueprint. This is for production calculation purposes.

##### Declaration

```
public float OutputVolume
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Prerequisites

##### Declaration

```
public MyBlueprintDefinitionBase.Item[] Prerequisites
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBlueprintDefinitionBase.Item](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.Item.html)\[\] |     |

#### Priority

Priority for sorting inside production screen within tabs. Higher priority blueprints will show up before the others

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ProgressBarSoundCue

##### Declaration

```
public string ProgressBarSoundCue
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Results

##### Declaration

```
public MyBlueprintDefinitionBase.Item[] Results
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBlueprintDefinitionBase.Item](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.Item.html)\[\] |     |

### Properties

#### InputItemType

##### Declaration

```
public MyObjectBuilderType InputItemType { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html) |     |

#### PostprocessNeeded

Whether the Postprocess method still needs to be called.

##### Declaration

```
public bool PostprocessNeeded { get; protected set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetBlueprints(List<MyBlueprintDefinitionBase.ProductionInfo>)

Should return the number of added blueprints (to make building hierarchical blueprint production infos easier)

##### Declaration

```
public abstract int GetBlueprints(List<MyBlueprintDefinitionBase.ProductionInfo> blueprints)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyBlueprintDefinitionBase.ProductionInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintDefinitionBase.ProductionInfo.html)\> | blueprints |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides