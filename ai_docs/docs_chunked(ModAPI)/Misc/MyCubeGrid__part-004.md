```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### LocalCoordSystem

Local coord system under which this cube exists. (its id)

##### Declaration

```
public long LocalCoordSystem { get; set; }
```

##### Property Value

Type

Description

System.Int64

#### LockedByCount

##### Declaration

```
public int LockedByCount { get; }
```

##### Property Value

Type

Description

System.Int32

#### MarkedAsTrash

##### Declaration

```
public bool MarkedAsTrash { get; }
```

##### Property Value

Type

Description

System.Boolean

#### Mass

##### Declaration

```
public float Mass { get; }
```

##### Property Value

Type

Description

System.Single

#### Max

##### Declaration

```
public Vector3I Max { get; }
```

##### Property Value

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### MaxShootRange

##### Declaration

```
public float MaxShootRange { get; }
```

##### Property Value

Type

Description

System.Single

#### Min

##### Declaration

```
public Vector3I Min { get; }
```

##### Property Value

Type

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

#### NaturalGravity

##### Declaration

```
public Vector3 NaturalGravity { get; }
```

##### Property Value

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### NumberOfGridColors

Return how many colors are on grid

##### Declaration

```
public int NumberOfGridColors { get; }
```

##### Property Value

Type

Description

System.Int32

#### OccupiedBlocks

##### Declaration

```
public HashSetReader<MyCockpit> OccupiedBlocks { get; }
```

##### Property Value

Type

Description

[HashSetReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html)<[MyCockpit](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCockpit.html)\>

#### Physics

##### Declaration

```
public MyGridPhysics Physics { get; set; }
```

##### Property Value

Type

Description

Sandbox.Game.Entities.Cube.MyGridPhysics

#### PlayerPresenceTier

##### Declaration

```
public MyUpdateTiersPlayerPresence PlayerPresenceTier { get; set; }
```

##### Property Value

Type

Description

[MyUpdateTiersPlayerPresence](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersPlayerPresence.html)

#### RenderData

##### Declaration

```
public MyCubeGridRenderData RenderData { get; }
```

##### Property Value

Type

Description

Sandbox.Game.Entities.Cube.MyCubeGridRenderData

#### RvoAgentId

##### Declaration

```
public int RvoAgentId { get; set; }
```

##### Property Value

Type

Description

System.Int32

#### ShapeCount

##### Declaration

```
public int ShapeCount { get; }
```

##### Property Value

Type

Description

System.Int32

#### ShootOrigin

##### Declaration

```
public Vector3D ShootOrigin { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### ShowAiInfo

##### Declaration

```
public static bool ShowAiInfo { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### ShowAntennaGizmos

##### Declaration

```
public static bool ShowAntennaGizmos { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### ShowCenterOfMass

##### Declaration

```
public static bool ShowCenterOfMass { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### ShowGravityGizmos

##### Declaration

```
public static bool ShowGravityGizmos { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### ShowGridPivot

##### Declaration

```
public static bool ShowGridPivot { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### ShowSenzorGizmos

##### Declaration

```
public static bool ShowSenzorGizmos { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### SmallOwners

players that have at least one block in cube grid

##### Declaration

```
public List<long> SmallOwners { get; }
```

##### Property Value

Type

Description

System.Collections.Generic.List<System.Int64\>

#### Speed

##### Declaration

```
public float Speed { get; }
```

##### Property Value

Type

Description

System.Single

#### SyncType

##### Declaration

```
public SyncType SyncType { get; set; }
```

##### Property Value

Type

Description

VRage.Sync.SyncType

#### TrashHighlightCounter

##### Declaration

```
public int TrashHighlightCounter { get; }
```

##### Property Value

Type

Description

System.Int32

#### UnsafeBlocks

##### Declaration

```
public HashSetReader<MyCubeBlock> UnsafeBlocks { get; }
```

##### Property Value

Type

Description

[HashSetReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html)<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### UpdateFlags

##### Declaration

```
public MyParallelUpdateFlags UpdateFlags { get; }
```

##### Property Value

Type

Description

[MyParallelUpdateFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyParallelUpdateFlags.html)

#### UsesTargetingList

##### Declaration

```
public bool UsesTargetingList { get; }
```

##### Property Value

Type

Description

System.Boolean

### Methods

#### ActivatePhysics()

##### Declaration

```
public void ActivatePhysics()
```

#### AddDirtyBone(Vector3I, Vector3I)

##### Declaration

```
public void AddDirtyBone(Vector3I gridPosition, Vector3I boneOffset)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridPosition

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

boneOffset
