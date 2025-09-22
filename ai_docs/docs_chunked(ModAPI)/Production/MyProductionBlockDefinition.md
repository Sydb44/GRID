---
title: "Class MyProductionBlockDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyProductionBlockDefinition.html"
category: "Production"
namespace: "Sandbox.Definitions"
class: "MyProductionBlockDefinition"
---

# Class MyProductionBlockDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyProductionBlockDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyProductionBlockDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyProductionBlockDefinition()

##### Declaration

```
public MyProductionBlockDefinition()
```

### Fields

#### AllowSelfPulling

##### Declaration

```
public bool AllowSelfPulling
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### BlueprintClasses

##### Declaration

```
public List<MyBlueprintClassDefinition> BlueprintClasses
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyBlueprintClassDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintClassDefinition.html)\> |     |

#### IgnoredBlueprintClassesIcons

##### Declaration

```
public List<string> IgnoredBlueprintClassesIcons
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.String\> |     |

#### InputInventoryConstraint

##### Declaration

```
public MyInventoryConstraint InputInventoryConstraint
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

#### OperationalPowerConsumption

##### Declaration

```
public float OperationalPowerConsumption
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### OutputInventoryConstraint

##### Declaration

```
public MyInventoryConstraint OutputInventoryConstraint
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyInventoryConstraint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventoryConstraint.html) |     |

#### ResourceSinkGroup

##### Declaration

```
public MyStringHash ResourceSinkGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### StandbyPowerConsumption

##### Declaration

```
public float StandbyPowerConsumption
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### BlueprintClassCanBeUsed(MyBlueprintClassDefinition)

##### Declaration

```
protected virtual bool BlueprintClassCanBeUsed(MyBlueprintClassDefinition blueprintClass)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyBlueprintClassDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintClassDefinition.html) | blueprintClass |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetInputClasses()

##### Declaration

```
protected virtual List<MyBlueprintClassDefinition> GetInputClasses()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyBlueprintClassDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintClassDefinition.html)\> |     |

#### GetOutputClasses()

##### Declaration

```
protected virtual List<MyBlueprintClassDefinition> GetOutputClasses()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyBlueprintClassDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlueprintClassDefinition.html)\> |     |

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
protected virtual void InitializeLegacyBlueprintClasses(MyObjectBuilder_ProductionBlockDefinition ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ProductionBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ProductionBlockDefinition.html) | ob  |     |

#### LoadPostProcess()

##### Declaration

```
public void LoadPostProcess()
```