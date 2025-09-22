---
title: "Class MyObjectBuilder\\_CubeBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_CubeBlock"
---

# Class MyObjectBuilder\_CubeBlock | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_CubeBlock

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_CubeBlock : MyObjectBuilder_Base
```

### Constructors

#### MyObjectBuilder\_CubeBlock()

##### Declaration

```
public MyObjectBuilder_CubeBlock()
```

### Fields

#### BlockGeneralDamageModifier

##### Declaration

```
[Serialize]
public float BlockGeneralDamageModifier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BlockOrientation

##### Declaration

```
public SerializableBlockOrientation BlockOrientation
```

##### Field Value

| Type | Description |
| --- | --- |
| [SerializableBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.SerializableBlockOrientation.html) |     |

#### BuildPercent

##### Declaration

```
[Serialize]
public float BuildPercent
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BuiltBy

##### Declaration

```
[Serialize]
public long BuiltBy
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### ColorMaskHSV

##### Declaration

```
public SerializableVector3 ColorMaskHSV
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector3 |     |

#### ComponentContainer

##### Declaration

```
[Serialize]
public MyObjectBuilder_ComponentContainer ComponentContainer
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ComponentContainer](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentContainer.html) |     |

#### ConstructionInventory

##### Declaration

```
[NoSerialize]
public MyObjectBuilder_Inventory ConstructionInventory
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_Inventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_Inventory.html) |     |

#### ConstructionStockpile

##### Declaration

```
[Serialize]
public MyObjectBuilder_ConstructionStockpile ConstructionStockpile
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_ConstructionStockpile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ConstructionStockpile.html) |     |

#### DeformationRatio

##### Declaration

```
[NoSerialize]
public float DeformationRatio
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EntityId

##### Declaration

```
[Serialize]
public long EntityId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### IntegrityPercent

##### Declaration

```
[Serialize]
public float IntegrityPercent
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Min

##### Declaration

```
[Serialize]
public SerializableVector3I Min
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector3I |     |

#### MultiBlockDefinition

##### Declaration

```
[Serialize]
public Nullable<SerializableDefinitionId> MultiBlockDefinition
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html)\> |     |

#### MultiBlockId

##### Declaration

```
[Serialize]
public int MultiBlockId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MultiBlockIndex

##### Declaration

```
[Serialize]
public int MultiBlockIndex
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Name

##### Declaration

```
[Serialize]
public string Name
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Owner

##### Declaration

```
[Serialize]
public long Owner
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### ShareMode

##### Declaration

```
public MyOwnershipShareModeEnum ShareMode
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html) |     |

#### SkinSubtypeId

##### Declaration

```
[Serialize]
public string SkinSubtypeId
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### SubBlocks

##### Declaration

```
[Serialize]
public MyObjectBuilder_CubeBlock.MySubBlockId[] SubBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_CubeBlock.MySubBlockId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.MySubBlockId.html)\[\] |     |

### Properties

#### Orientation

##### Declaration

```
[NoSerialize]
public SerializableQuaternion Orientation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| VRage.SerializableQuaternion |     |

### Methods

#### Remap(IMyRemapHelper)

##### Declaration

```
public virtual void Remap(IMyRemapHelper remapHelper)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html) | remapHelper |     |

#### SetupForGridPaste()

##### Declaration

```
public virtual void SetupForGridPaste()
```

#### SetupForProjector()

##### Declaration

```
public virtual void SetupForProjector()
```
