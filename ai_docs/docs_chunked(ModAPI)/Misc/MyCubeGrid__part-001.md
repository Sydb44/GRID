---
title: "Class MyCubeGrid"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyCubeGrid"
---

# Class MyCubeGrid | Space Engineers ModAPI

Grid - small ship, large ship, station Cubes (armor, walls...) are merge and rendered by this entity Blocks (turret, thrusts...) are rendered as child entities

##### Inheritance

System.Object

MyCubeGrid

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[StaticEventOwner]
[MyEntityType]
public class MyCubeGrid : MyEntity, IMyGridConnectivityTest, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyShootOrigin, IMyParallelUpdateable, IMyCubeGrid, IMyEntity, IMyCubeGrid, IMyEntity
```

### Constructors

#### MyCubeGrid()

##### Declaration

### Fields

#### BeingCreatedInSplit

##### Declaration

```
public bool BeingCreatedInSplit
```

##### Field Value

Type

Description

System.Boolean

#### BlockCounter

##### Declaration

```
public readonly MyCubeGrid.BlockTypeCounter BlockCounter
```

##### Field Value

Type

Description

[MyCubeGrid.BlockTypeCounter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.BlockTypeCounter.html)

#### BlocksCounters

##### Declaration

```
public Dictionary<MyObjectBuilderType, int> BlocksCounters
```

##### Field Value

Type

Description

System.Collections.Generic.Dictionary<[MyObjectBuilderType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilderType.html), System.Int32\>

#### BlocksWaitingOnAttachUpdate

##### Declaration

```
public HashSet<MyMechanicalConnectionBlockBase> BlocksWaitingOnAttachUpdate
```

##### Field Value

Type

Description

System.Collections.Generic.HashSet<Sandbox.Game.Entities.Blocks.MyMechanicalConnectionBlockBase\>

#### CloseGrid

##### Declaration

##### Field Value

Type

Description

System.Boolean

#### ControlledFromTurret

##### Declaration

```
public bool ControlledFromTurret
```

##### Field Value

Type

Description

System.Boolean

#### CreatePhysics

##### Declaration

```
public bool CreatePhysics
```

##### Field Value

Type

Description

System.Boolean

#### DebugUpdateHistoryDuration

Number of gameplay frames to keep the update history for. Defaults to 120 frames.

##### Declaration

```
public static int DebugUpdateHistoryDuration
```

##### Field Value

Type

Description

System.Int32

#### GridGeneralDamageModifier

##### Declaration

```
public readonly Sync<float, SyncDirection.FromServer> GridGeneralDamageModifier
```

##### Field Value

Type

Description

VRage.Sync.Sync<System.Single, VRage.Sync.SyncDirection.FromServer\>

#### GridPresenceUpdate

##### Declaration

```
public Action<bool> GridPresenceUpdate
```

##### Field Value

Type

Description

System.Action<System.Boolean\>

#### HasMechanicalTopPenindingReattach

##### Declaration

```
public bool HasMechanicalTopPenindingReattach
```

##### Field Value

Type

Description

System.Boolean

#### HasShipSoundEvents

##### Declaration

```
public bool HasShipSoundEvents
```

##### Field Value

Type

Description

System.Boolean

##### Declaration

```
public Dictionary<long, int> IdentityAuthorshipBlockCount
```

##### Field Value

Type

Description

System.Collections.Generic.Dictionary<System.Int64, System.Int32\>

#### InternalInitFinished

##### Declaration

```
public bool InternalInitFinished
```

##### Field Value

Type

Description

System.Boolean

#### IsAccessibleForProgrammableBlock

##### Declaration

```
public bool IsAccessibleForProgrammableBlock
```

##### Field Value

Type

Description

System.Boolean

#### LastSelectedProductionBlockId

##### Declaration

```
public long LastSelectedProductionBlockId
```

##### Field Value

Type

Description

System.Int64

#### m\_occupiedBlocks

##### Declaration

```
public HashSet<MyCockpit> m_occupiedBlocks
```

##### Field Value

Type

Description

System.Collections.Generic.HashSet<[MyCockpit](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCockpit.html)\>

#### m\_playedTime

Grid play time with player. Used by respawn ship.

##### Declaration

##### Field Value

Type

Description

System.Int32

#### MainCockpit

##### Declaration

```
public MyTerminalBlock MainCockpit
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Cube.MyTerminalBlock

#### MainRemoteControl

##### Declaration

```
public MyTerminalBlock MainRemoteControl
```

##### Field Value

Type

Description

Sandbox.Game.Entities.Cube.MyTerminalBlock

#### MassSyncProperty

This is updated only when a player is sitting in the cockpit and autopilot is enabled.

##### Declaration

```
public readonly Sync<float, SyncDirection.FromServer> MassSyncProperty
```

##### Field Value

Type

Description

VRage.Sync.Sync<System.Single, VRage.Sync.SyncDirection.FromServer\>

#### NpcClaimSecondsRemaining

##### Declaration

```
public int NpcClaimSecondsRemaining
```

##### Field Value

Type

Description

System.Int32

#### NpcClaimSecondsRemainingUpdateRequestTime

##### Declaration

```
public long NpcClaimSecondsRemainingUpdateRequestTime
```

##### Field Value

Type

Description

System.Int64

#### NpcClaimSecondsRemainingUpdateTime

##### Declaration

```
public long NpcClaimSecondsRemainingUpdateTime
```

##### Field Value

Type

Description

System.Int64

#### NumberOfReactors

##### Declaration

```
public int NumberOfReactors
```

##### Field Value

Type

Description

System.Int32

#### OnLockToolbarPosition

##### Declaration

```
public const int OnLockToolbarPosition = 0
```

##### Field Value

Type

Description

System.Int32

#### OnUnLockToolbarPosition

##### Declaration

```
public const int OnUnLockToolbarPosition = 1
```

##### Field Value

Type

Description

System.Int32
