---
title: "Class MyCubeBlockDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyCubeBlockDefinition"
---

# Class MyCubeBlockDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyCubeBlockDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyCubeBlockDefinition : MyPhysicalModelDefinition
```

### Constructors

#### MyCubeBlockDefinition()

##### Declaration

```
public MyCubeBlockDefinition()
```

### Fields

#### ActionSound

##### Declaration

```
public MySoundPair ActionSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### AimingOffset

##### Declaration

```
public Nullable<Vector3> AimingOffset
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### AllowInteractionThroughBlock

##### Declaration

```
public bool AllowInteractionThroughBlock
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AmmoExplosionEffect

##### Declaration

```
public string AmmoExplosionEffect
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### AmmoExplosionSound

##### Declaration

```
public string AmmoExplosionSound
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### AutorotateMode

##### Declaration

```
public MyAutorotateMode AutorotateMode
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyAutorotateMode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyAutorotateMode.html) |     |

#### BlockPairName

##### Declaration

```
public string BlockPairName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### BlockStages

Array of block stages. Stage represents other block definition which have different UV mapping, mirrored model, etc (stone rounded corner...). Stages can be cycled when building cubes.

##### Declaration

```
public MyDefinitionId[] BlockStages
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\[\] |     |

#### BlockTopology

##### Declaration

```
public MyBlockTopology BlockTopology
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBlockTopology](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyBlockTopology.html) |     |

#### BlockVariantsGroup

##### Declaration

```
public MyBlockVariantGroup BlockVariantsGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyBlockVariantGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyBlockVariantGroup.html) |     |

#### Bones

##### Declaration

```
public Dictionary<Vector3I, Vector3> Bones
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html), [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### BuildMaterial

Build material - always lower case (for walls - "stone", "wood").

##### Declaration

```
public string BuildMaterial
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### BuildProgressModels

Models used when building. They are sorted in ascending order according to their percentage.

##### Declaration

```
public MyCubeBlockDefinition.BuildProgressModel[] BuildProgressModels
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition.BuildProgressModel](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.BuildProgressModel.html)\[\] |     |

#### BuildProgressToPlaceGeneratedBlocks

Value of build progress when generated blocks start to generate.

##### Declaration

```
public float BuildProgressToPlaceGeneratedBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BuildType

Building type - always lower case (wall, ...).

##### Declaration

```
public MyStringId BuildType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

#### Color

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Color](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Color.html) |     |

#### Components

Index 0 is first component on stack, the one which is build first and destroyed last.

##### Declaration

```
public MyCubeBlockDefinition.Component[] Components
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition.Component](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.Component.html)\[\] |     |

#### CriticalGroup

##### Declaration

```
public ushort CriticalGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt16 |     |

#### CriticalIntegrityRatio

##### Declaration

```
public float CriticalIntegrityRatio
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CubeDefinition

##### Declaration

```
public MyCubeDefinition CubeDefinition
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeDefinition.html) |     |
