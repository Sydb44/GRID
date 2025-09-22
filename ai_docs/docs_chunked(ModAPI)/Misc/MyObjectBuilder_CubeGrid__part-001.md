---
title: "Class MyObjectBuilder\\_CubeGrid"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeGrid.html"
category: "Misc"
namespace: "VRage.Game"
class: "MyObjectBuilder_CubeGrid"
---

# Class MyObjectBuilder\_CubeGrid | Space Engineers ModAPI

##### Inheritance

System.Object

MyObjectBuilder\_CubeGrid

##### Inherited Members

###### **Namespace**: [VRage.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class MyObjectBuilder_CubeGrid : MyObjectBuilder_EntityBase
```

### Constructors

#### MyObjectBuilder\_CubeGrid()

##### Declaration

```
public MyObjectBuilder_CubeGrid()
```

### Fields

#### AngularVelocity

##### Declaration

```
[Serialize]
public SerializableVector3 AngularVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector3 |     |

#### BlockGroups

##### Declaration

```
public List<MyObjectBuilder_BlockGroup> BlockGroups
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_BlockGroup](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_BlockGroup.html)\> |     |

#### ConveyorLines

##### Declaration

```
[Serialize]
public List<MyObjectBuilder_ConveyorLine> ConveyorLines
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_ConveyorLine](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_ConveyorLine.html)\> |     |

#### CreatePhysics

##### Declaration

```
public bool CreatePhysics
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CubeBlocks

##### Declaration

```
[DynamicItem]
public List<MyObjectBuilder_CubeBlock> CubeBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)\> |     |

#### DampenersEnabled

##### Declaration

```
public bool DampenersEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DestructibleBlocks

##### Declaration

```
public bool DestructibleBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DisplayName

##### Declaration

```
[Serialize]
public string DisplayName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Editable

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GridGeneralDamageModifier

##### Declaration

```
public float GridGeneralDamageModifier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GridPresenceTier

##### Declaration

```
public MyUpdateTiersGridPresence GridPresenceTier
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyUpdateTiersGridPresence](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersGridPresence.html) |     |

#### GridSizeEnum

##### Declaration

```
public MyCubeSize GridSizeEnum
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeSize](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyCubeSize.html) |     |

#### Handbrake

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Immune

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsNpcSpawnedGrid

##### Declaration

```
public bool IsNpcSpawnedGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPowered

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRespawnGrid

##### Declaration

```
public bool IsRespawnGrid
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsStatic

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsUnsupportedStation

##### Declaration

```
public bool IsUnsupportedStation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### JumpDriveDirection

##### Declaration

```
[Serialize]
public Nullable<Vector3D> JumpDriveDirection
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### JumpRemainingTime

##### Declaration

```
[Serialize]
public Nullable<float> JumpRemainingTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### LinearVelocity

##### Declaration

```
[Serialize]
public SerializableVector3 LinearVelocity
```

##### Field Value

| Type | Description |
| --- | --- |
| VRage.SerializableVector3 |     |

#### LocalCoordSys

##### Declaration

```
public long LocalCoordSys
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### NPCGridClaimElapsed

##### Declaration

```
[Serialize]
public Nullable<int> NPCGridClaimElapsed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int32\> |     |

#### OxygenAmount

##### Declaration

```
[Serialize]
public float[] OxygenAmount
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single\[\] |     |

#### OxygenRooms

##### Declaration

```
[Serialize]
public OxygenRoom[] OxygenRooms
```

##### Field Value

| Type | Description |
| --- | --- |
| [OxygenRoom](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.OxygenRoom.html)\[\] |     |

#### PlanetSpawnHeightRatio

##### Declaration

```
public float PlanetSpawnHeightRatio
```
