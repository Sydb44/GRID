---
title: "Class MyVoxelMaterialDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyVoxelMaterialDefinition.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyVoxelMaterialDefinition"
---

# Class MyVoxelMaterialDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyVoxelMaterialDefinition

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyVoxelMaterialDefinition : MyDefinitionBase
```

### Constructors

#### MyVoxelMaterialDefinition()

##### Declaration

```
public MyVoxelMaterialDefinition()
```

### Fields

#### AsteroidGeneratorSpawnProbabilityMultiplier

##### Declaration

```
public int AsteroidGeneratorSpawnProbabilityMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### BareVariant

##### Declaration

```
public string BareVariant
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CanBeHarvested

##### Declaration

```
public bool CanBeHarvested
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ColorKey

##### Declaration

```
public Nullable<Vector3> ColorKey
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### DamagedMaterial

##### Declaration

```
public MyStringHash DamagedMaterial
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### Friction

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsRare

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LandingEffect

##### Declaration

```
public string LandingEffect
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### MaterialTypeName

##### Declaration

```
public string MaterialTypeName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### MaxVersion

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MinedOre

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### MinedOreRatio

##### Declaration

```
public float MinedOreRatio
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinVersion

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### RenderParams

##### Declaration

```
public MyRenderVoxelMaterialData RenderParams
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.MyRenderVoxelMaterialData |     |

#### Restitution

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SpawnsFromMeteorites

##### Declaration

```
public bool SpawnsFromMeteorites
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SpawnsInAsteroids

##### Declaration

```
public bool SpawnsInAsteroids
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### VoxelHandPreview

##### Declaration

```
public string VoxelHandPreview
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

### Properties

#### HasDamageMaterial

##### Declaration

```
public bool HasDamageMaterial { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Icon

##### Declaration

```
public string Icon { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Index

Value generated at runtime to ensure correctness. Do not serialize or deserialize. This is what the old cast to int used to result into, but now numbers depend on order in XML file. TODO Serialize to XML and ensure upon loading that these values are starting from 0 and continuous.

##### Declaration

```
public byte Index { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Byte |     |

#### MaterialTypeNameHash

##### Declaration

```
public MyStringHash MaterialTypeNameHash { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### MaterialTypeNameId

##### Declaration

```
public MyStringId MaterialTypeNameId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

### Methods

#### AssignIndex()

##### Declaration

```
public bool AssignIndex()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetObjectBuilder()

##### Declaration

```
public override MyObjectBuilder_DefinitionBase GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) |     |

##### Overrides

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase ob)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | ob  |     |

##### Overrides

#### ResetIndexing()

##### Declaration

```
public static void ResetIndexing()
```

#### UpdateVoxelMaterial()

##### Declaration

```
public void UpdateVoxelMaterial()
```