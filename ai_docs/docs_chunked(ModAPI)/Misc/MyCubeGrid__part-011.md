splitBlocks

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MyDisconnectHelper.Group\>

groups

[MyCubeGrid.MyTestDisconnectsReason](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyTestDisconnectsReason.html)

reason

System.Boolean

sync

#### CreateSplits\_Implementation(List<Vector3I>, List<MyDisconnectHelper.Group>)

##### Declaration

```
[Event(null, 1798)]
[Reliable]
[Broadcast]
public void CreateSplits_Implementation(List<Vector3I> blocks, List<MyDisconnectHelper.Group> groups)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)\>

blocks

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MyDisconnectHelper.Group\>

groups

#### CubeExists(Vector3I)

##### Declaration

```
public bool CubeExists(Vector3I pos)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

##### Returns

Type

Description

System.Boolean

#### DebugFormatMethodName(MethodInfo)

##### Declaration

```
public static string DebugFormatMethodName(MethodInfo method)
```

##### Parameters

Type

Name

Description

System.Reflection.MethodInfo

method

##### Returns

Type

Description

System.String

#### DepressurizeEffect(Vector3I, Vector3I)

##### Declaration

```
[Event(null, 11346)]
[Reliable]
[ServerInvoked]
[Broadcast]
public void DepressurizeEffect(Vector3I from, Vector3I to)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

from

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

to

#### DepressurizeEffect\_Implementation(Vector3I, Vector3I)

##### Declaration

```
public void DepressurizeEffect_Implementation(Vector3I from, Vector3I to)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

from

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

to

#### DeSchedule(MyCubeGrid.UpdateQueue, Action)

Schedule an update.

##### Declaration

```
public void DeSchedule(MyCubeGrid.UpdateQueue queue, Action callback)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.UpdateQueue](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.UpdateQueue.html)

queue

System.Action

callback

#### DeserializeControls(BitStream, Boolean)

##### Declaration

```
public override void DeserializeControls(BitStream stream, bool outOfOrder)
```

##### Parameters

Type

Name

Description

VRage.Library.Collections.BitStream

stream

System.Boolean

outOfOrder

##### Overrides

#### DetectDisconnectsAfterFrame()

##### Declaration

```
public void DetectDisconnectsAfterFrame()
```

#### DetectMerge(MySlimBlock, MyCubeGrid, List<MyEntity>, Boolean)

Tries to merge this grid with any other grid Merges grids only when both are static Returns the merged grid (which does not necessarily have to be this grid)

##### Declaration

```
public MyCubeGrid DetectMerge(MySlimBlock block, MyCubeGrid ignore = null, List<MyEntity> nearEntities = null, bool newGrid = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

ignore

System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\>

nearEntities

System.Boolean

newGrid

##### Returns

Type

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

#### DismountAllCockpits()

##### Declaration

```
public void DismountAllCockpits()
```

#### DoDamage(Single, MyHitInfo, Nullable<Vector3>, Int64)

##### Declaration

```
public void DoDamage(float damage, MyHitInfo hitInfo, Nullable<Vector3> localPos = null, long attackerId = 0L)
```

##### Parameters

Type

Name

Description

System.Single

damage

[MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html)

hitInfo

System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

localPos

System.Int64

attackerId

#### EnqueueDestroyedBlock(Vector3I)

##### Declaration

```
public void EnqueueDestroyedBlock(Vector3I position)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

#### EnqueueDestructionDeformationBlock(Vector3I)

##### Declaration

```
public void EnqueueDestructionDeformationBlock(Vector3I position)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

#### EnqueueRemovedBlock(Vector3I)

##### Declaration

```
public void EnqueueRemovedBlock(Vector3I position)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

#### EnqueueRemovedBlockWithId(Vector3I, Nullable<UInt16>)

Server method, adds removed block with compound id into queue

##### Declaration

```
public void EnqueueRemovedBlockWithId(Vector3I position, Nullable<ushort> compoundId = null)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

System.Nullable<System.UInt16\>

compoundId

#### ExportObject(MyCubeGrid, Boolean, Boolean)

##### Declaration

```
public static void ExportObject(MyCubeGrid baseGrid, bool convertModelsFromSBC, bool exportObjAndSBC = false)
```
