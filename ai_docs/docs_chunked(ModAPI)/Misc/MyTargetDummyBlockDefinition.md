---
title: "Class MyTargetDummyBlockDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyTargetDummyBlockDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyTargetDummyBlockDefinition"
---

# Class MyTargetDummyBlockDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyTargetDummyBlockDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyTargetDummyBlockDefinition : MyFunctionalBlockDefinition
```

### Constructors

#### MyTargetDummyBlockDefinition()

##### Declaration

```
public MyTargetDummyBlockDefinition()
```

### Fields

#### ConstructionItem

##### Declaration

```
public MyDefinitionId ConstructionItem
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### ConstructionItemAmount

##### Declaration

```
public int ConstructionItemAmount
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### DestructionEffectMultiplier

##### Declaration

```
public float DestructionEffectMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DestructionEffectName

##### Declaration

```
public string DestructionEffectName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DestructionSound

##### Declaration

```
public MySoundPair DestructionSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

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

#### MaxFillFactor

##### Declaration

```
public float MaxFillFactor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxRegenerationTimeInS

##### Declaration

```
public float MaxRegenerationTimeInS
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinFillFactor

##### Declaration

```
public float MinFillFactor
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinRegenerationTimeInS

##### Declaration

```
public float MinRegenerationTimeInS
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RegenerationEffectMultiplier

##### Declaration

```
public float RegenerationEffectMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RegenerationEffectName

##### Declaration

```
public string RegenerationEffectName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### RegenerationSound

##### Declaration

```
public MySoundPair RegenerationSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### SubpartDefinitions

##### Declaration

```
public Dictionary<string, MyTargetDummyBlockDefinition.MyDummySubpartDescription> SubpartDefinitions
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, [MyTargetDummyBlockDefinition.MyDummySubpartDescription](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyTargetDummyBlockDefinition.MyDummySubpartDescription.html)\> |     |

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