Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Boolean

updatePhysics

#### RemoveBlocksBuiltByIDs(List<Int64>)

Remove all blocks from the grid built by specific player

##### Declaration

```
[Event(null, 3693)]
[Reliable]
[ServerInvoked]
[Broadcast]
public void RemoveBlocksBuiltByIDs(List<long> identityIDs)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<System.Int64\>

identityIDs

#### RemoveBlockWithId(MySlimBlock, Boolean)

##### Declaration

```
public void RemoveBlockWithId(MySlimBlock block, bool updatePhysics = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Boolean

updatePhysics

#### RemoveBlockWithId(Vector3I, Boolean)

##### Declaration

```
public void RemoveBlockWithId(Vector3I position, bool updatePhysics = false)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

System.Boolean

updatePhysics

#### RemoveContainerDropComponent(Int64)

##### Declaration

```
[Event(null, 11541)]
[Reliable]
[ServerInvoked]
[Broadcast]
public void RemoveContainerDropComponent(long blockId)
```

##### Parameters

Type

Name

Description

System.Int64

blockId

#### RemoveDestroyedBlock(MySlimBlock, Int64)

Removes destroyed block, applies damage and deformation to close blocks Won't update physics!

##### Declaration

```
public void RemoveDestroyedBlock(MySlimBlock block, long attackerId = 0L)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Int64

attackerId

#### RemoveNPCBlocks()

##### Declaration

```
public void RemoveNPCBlocks()
```

#### RemoveSplit(MyCubeGrid, List<MySlimBlock>, Int32, Int32, Boolean)

##### Declaration

```
public static void RemoveSplit(MyCubeGrid originalGrid, List<MySlimBlock> blocks, int offset, int count, bool sync = true)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

originalGrid

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks

System.Int32

offset

System.Int32

count

System.Boolean

sync

#### RequestConversionToShip(Action)

##### Declaration

```
public void RequestConversionToShip(Action result)
```

##### Parameters

Type

Name

Description

System.Action

result

#### RequestConversionToStation()

##### Declaration

```
public void RequestConversionToStation()
```

#### RequestFillStockpile(Vector3I, MyInventory)

##### Declaration

```
public void RequestFillStockpile(Vector3I blockPosition, MyInventory fromInventory)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

blockPosition

[MyInventory](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyInventory.html)

fromInventory

#### RequestJump(Vector3D, Int64, Single, Nullable<Int64>)

##### Declaration

```
public void RequestJump(Vector3D jumpTarget, long userId, float jumpDriveDelay = 10F, Nullable<long> driveEntityId = null)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

jumpTarget

System.Int64

userId

System.Single

jumpDriveDelay

System.Nullable<System.Int64\>

driveEntityId

#### ResetBlockSkeleton(MySlimBlock, Boolean)

##### Declaration

```
public void ResetBlockSkeleton(MySlimBlock block, bool updateSync = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Boolean

updateSync

#### ResetControls()

##### Declaration

```
public override void ResetControls()
```

##### Overrides

#### ResetInfoGizmos()

##### Declaration

```
public static void ResetInfoGizmos()
```

#### Schedule(MyCubeGrid.UpdateQueue, Action, Int32, Boolean)

Remove a scheduled update.

##### Declaration

```
public void Schedule(MyCubeGrid.UpdateQueue queue, Action callback, int priority = 2147483647, bool parallel = false)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.UpdateQueue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.UpdateQueue.html)

queue

System.Action

callback

System.Int32

priority

System.Boolean

parallel

#### SendAbortJump()

##### Declaration

```
public void SendAbortJump()
```

#### SendGridCloseRequest()

Use only for cut request

##### Declaration

```
public void SendGridCloseRequest()
```

#### SendHudNotificationAfterPaste()

##### Declaration

```
[Event(null, 9731)]
[Reliable]
[Client]
public static void SendHudNotificationAfterPaste()
```

#### SendIntegrityChanged(MySlimBlock, MyIntegrityChangeEnum, Int64)

##### Declaration

```
public void SendIntegrityChanged(MySlimBlock mySlimBlock, MyIntegrityChangeEnum integrityChangeType, long toolOwner)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

mySlimBlock

[MyIntegrityChangeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyIntegrityChangeEnum.html)

integrityChangeType

System.Int64

toolOwner

#### SendReflectorState(MyMultipleEnabledEnum)

##### Declaration

```
public void SendReflectorState(MyMultipleEnabledEnum value)
```

##### Parameters

Type

Name

Description

VRage.MyMultipleEnabledEnum

value

#### SendRemovedBlocks()

##### Declaration

```
public void SendRemovedBlocks()
```

#### SendRemovedBlocksWithIds()

##### Declaration

```
public void SendRemovedBlocksWithIds()
```

#### SendStockpileChanged(MySlimBlock, List<MyStockpileItem>)

##### Declaration

```
public void SendStockpileChanged(MySlimBlock mySlimBlock, List<MyStockpileItem> list)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

mySlimBlock

System.Collections.Generic.List<[MyStockpileItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyStockpileItem.html)\>

list
