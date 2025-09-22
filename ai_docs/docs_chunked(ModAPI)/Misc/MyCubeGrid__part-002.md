##### Declaration

```
public const int OnUnLockToolbarPosition = 1
```

##### Field Value

Type

Description

System.Int32

#### Projector

##### Declaration

```
public MyProjectorBase Projector
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Blocks.MyProjectorBase

#### WorkPriority

##### Declaration

```
public static WorkPriority WorkPriority
```

##### Field Value

Type

Description

ParallelTasks.WorkPriority

#### XSymmetryOdd

##### Declaration

##### Field Value

Type

Description

System.Boolean

#### XSymmetryPlane

##### Declaration

```
public Nullable<Vector3I> XSymmetryPlane
```

##### Field Value

Type

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### YSymmetryOdd

##### Declaration

##### Field Value

Type

Description

System.Boolean

#### YSymmetryPlane

##### Declaration

```
public Nullable<Vector3I> YSymmetryPlane
```

##### Field Value

Type

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### ZSymmetryOdd

##### Declaration

##### Field Value

Type

Description

System.Boolean

#### ZSymmetryPlane

##### Declaration

```
public Nullable<Vector3I> ZSymmetryPlane
```

##### Field Value

Type

Description

System.Nullable<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

### Properties

#### AllowPrediction

##### Declaration

```
public bool AllowPrediction { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### BigOwners

players that have the maximum number of functional blocks in cube grid

##### Declaration

```
public List<long> BigOwners { get; }
```

##### Property Value

Type

Description

System.Collections.Generic.List<System.Int64\>

#### BlocksCount

##### Declaration

```
public int BlocksCount { get; }
```

##### Property Value

Type

Description

System.Int32

#### BlocksDestructionEnabled

##### Declaration

```
public bool BlocksDestructionEnabled { get; }
```

##### Property Value

Type

Description

System.Boolean

#### BlocksForDraw

##### Declaration

```
public ConcurrentCachingHashSet<MyCubeBlock> BlocksForDraw { get; }
```

##### Property Value

Type

Description

[ConcurrentCachingHashSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ConcurrentCachingHashSet-1.html)<[MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html)\>

#### BlocksPCU

##### Declaration

```
public int BlocksPCU { get; set; }
```

##### Property Value

Type

Description

System.Int32

#### ClosestParentId

##### Declaration

```
public long ClosestParentId { get; set; }
```

##### Property Value

Type

Description

System.Int64

#### ConveyorSystem

##### Declaration

```
public IMyGridConveyorSystem ConveyorSystem { get; }
```

##### Property Value

Type

Description

[IMyGridConveyorSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyGridConveyorSystem.html)

#### CubeBlocks

##### Declaration

```
public HashSet<MySlimBlock> CubeBlocks { get; }
```

##### Property Value

Type

Description

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Cube.MySlimBlock\>

#### DampenersEnabled

##### Declaration

```
public bool DampenersEnabled { get; }
```

##### Property Value

Type

Description

System.Boolean

#### Decoys

##### Declaration

```
public HashSetReader<MyDecoy> Decoys { get; }
```

##### Property Value

Type

Description

[HashSetReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.HashSetReader-1.html)<Sandbox.Game.Entities.Blocks.MyDecoy\>

#### DestructibleBlocks

##### Declaration

```
public bool DestructibleBlocks { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### DirtyBlocks

##### Declaration

```
public ConcurrentCachingHashSet<Vector3I> DirtyBlocks { get; }
```

##### Property Value

Type

Description

[ConcurrentCachingHashSet](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.ConcurrentCachingHashSet-1.html)<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

#### Editable

##### Declaration

```
public bool Editable { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### EntityThrustComponent

##### Declaration

```
public MyEntityThrustComponent EntityThrustComponent { get; }
```

##### Property Value

Type

Description

Sandbox.Game.GameSystems.MyEntityThrustComponent

#### ForceDisablePrediction

##### Declaration

```
public bool ForceDisablePrediction { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### GameLogic

##### Declaration

```
public override MyGameLogicComponent GameLogic { get; set; }
```

##### Property Value

Type

Description

[MyGameLogicComponent](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyGameLogicComponent.html)

##### Overrides

#### GetAmmoDefinition

##### Declaration

```
public MyDefinitionBase GetAmmoDefinition { get; }
```

##### Property Value

Type

Description

[MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html)

#### GridCounter

##### Declaration

```
public static int GridCounter { get; }
```

##### Property Value

Type

Description

System.Int32

#### GridPresenceTier

##### Declaration

```
public MyUpdateTiersGridPresence GridPresenceTier { get; set; }
```

##### Property Value

Type

Description

[MyUpdateTiersGridPresence](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyUpdateTiersGridPresence.html)

#### GridScale

##### Declaration

```
public float GridScale { get; }
```

##### Property Value

Type

Description

System.Single

#### GridSize

##### Declaration

```
public float GridSize { get; }
```
