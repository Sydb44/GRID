##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsAirTight

##### Declaration

```
public Nullable<bool> IsAirTight
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Boolean\> |     |

#### IsCubePressurized

##### Declaration

```
public Dictionary<Vector3I, Dictionary<Vector3I, MyCubeBlockDefinition.MyCubePressurizationMark>> IsCubePressurized
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html), System.Collections.Generic.Dictionary<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html), [MyCubeBlockDefinition.MyCubePressurizationMark](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MyCubePressurizationMark.html)\>> |     |

#### IsStandAlone

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxIntegrity

##### Declaration

```
public float MaxIntegrity
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxIntegrityRatio

##### Declaration

```
public float MaxIntegrityRatio
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MechanicalTopInitialPlacementOffset

##### Declaration

```
public Nullable<Vector3> MechanicalTopInitialPlacementOffset
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### ModelOffset

##### Declaration

```
public Vector3 ModelOffset
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### MountPoints

##### Declaration

```
public MyCubeBlockDefinition.MountPoint[] MountPoints
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\] |     |

#### OwnershipIntegrityRatio

##### Declaration

```
public float OwnershipIntegrityRatio
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PCU

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### PCU\_CONSTRUCTION\_STAGE\_COST

##### Declaration

```
public static readonly int PCU_CONSTRUCTION_STAGE_COST
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### PhysicsOption

##### Declaration

```
public MyPhysicsOption PhysicsOption
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyPhysicsOption](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyPhysicsOption.html) |     |

#### PlaceDecals

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PrimarySound

##### Declaration

```
public MySoundPair PrimarySound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### SilenceableByShipSoundSystem

##### Declaration

```
public bool SilenceableByShipSoundSystem
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Size

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

#### Skeleton

##### Declaration

```
public List<BoneInfo> Skeleton
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[BoneInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.BoneInfo.html)\> |     |

#### TagDefinition

##### Declaration

```
public MyCubeBlockTagDefinition TagDefinition
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeBlockTagDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockTagDefinition.html) |     |

#### TieredUpdateTimes

##### Declaration

```
public List<uint> TieredUpdateTimes
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<System.UInt32\> |     |

#### UniqueVersion

##### Declaration

```
public MyCubeBlockDefinition UniqueVersion
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html) |     |

#### UseModelIntersection

##### Declaration

```
public bool UseModelIntersection
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UseNeighbourOxygenRooms

Flag used by GridGasSystem to determine if this block should exclude from creating pressurize room. If true, this block cannot be pressurize room itself. This is only valid for blocks which are bigger than 1x1x1, because otherwise they are excluded automatically.

##### Declaration

```
public bool UseNeighbourOxygenRooms
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### UsesDeformation

##### Declaration

```
public bool UsesDeformation
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Variants

##### Declaration

```
public List<MyCubeBlockDefinition> Variants
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)\> |     |

#### VoxelPlacement

Defines how much block can penetrate voxel.

##### Declaration

```
public Nullable<VoxelPlacementOverride> VoxelPlacement
```
