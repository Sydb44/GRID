blockObjectBuilder

System.Int64

builderEntityId

System.Boolean

instantBuild

System.Int64

ownerId

#### BuildGeneratedBlock(MyCubeGrid.MyBlockLocation, Vector3, MyStringHash)

##### Declaration

```
public MySlimBlock BuildGeneratedBlock(MyCubeGrid.MyBlockLocation location, Vector3 colorMaskHsv, MyStringHash skinId)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.MyBlockLocation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockLocation.html)

location

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

colorMaskHsv

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

skinId

##### Returns

Type

Description

Sandbox.Game.Entities.Cube.MySlimBlock

#### CalculateMergeTransform(MyCubeGrid, Vector3I)

##### Declaration

```
public MatrixI CalculateMergeTransform(MyCubeGrid gridToMerge, Vector3I gridOffset)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

gridToMerge

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridOffset

##### Returns

Type

Description

[MatrixI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixI.html)

#### CanAddCube(Vector3I, Nullable<MyBlockOrientation>, MyCubeBlockDefinition, Boolean)

##### Declaration

```
public bool CanAddCube(Vector3I pos, Nullable<MyBlockOrientation> orientation, MyCubeBlockDefinition definition, bool ignoreSame = false)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

pos

System.Nullable<[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)\>

orientation

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

definition

System.Boolean

ignoreSame

##### Returns

Type

Description

System.Boolean

#### CanAddCubes(Vector3I, Vector3I)

##### Declaration

```
public bool CanAddCubes(Vector3I min, Vector3I max)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

##### Returns

Type

Description

System.Boolean

#### CanBeTeleported(MyGridJumpDriveSystem, out MyGridJumpDriveSystem.MyJumpFailReason)

##### Declaration

```
public bool CanBeTeleported(MyGridJumpDriveSystem jumpingSystem, out MyGridJumpDriveSystem.MyJumpFailReason reason)
```

##### Parameters

Type

Name

Description

Sandbox.Game.GameSystems.MyGridJumpDriveSystem

jumpingSystem

Sandbox.Game.GameSystems.MyGridJumpDriveSystem.MyJumpFailReason

reason

##### Returns

Type

Description

System.Boolean

#### CancelPendingTransferRequestsServerSide(Guid, Int64, Int64)

##### Declaration

```
[Event(null, 10747)]
[Reliable]
[Server]
public static void CancelPendingTransferRequestsServerSide(Guid requestBatchGuid, long gridId, long ownerId)
```

##### Parameters

Type

Name

Description

System.Guid

requestBatchGuid

System.Int64

gridId

System.Int64

ownerId

#### CanHavePhysics()

Returns true when grid have at least one block which has physics (e.g. interior lights have no physics)

##### Declaration

```
public bool CanHavePhysics()
```

##### Returns

Type

Description

System.Boolean

#### CanHavePhysics(List<MySlimBlock>, Int32, Int32)

Returns true when grid have at least one block which has physics (lights has no physics)

##### Declaration

```
public static bool CanHavePhysics(List<MySlimBlock> blocks, int offset, int count)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks

System.Int32

offset

System.Int32

count

##### Returns

Type

Description

System.Boolean

#### CanMergeCubes(MyCubeGrid, Vector3I)

##### Declaration

```
public bool CanMergeCubes(MyCubeGrid gridToMerge, Vector3I gridOffset)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

gridToMerge

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridOffset

##### Returns

Type

Description

System.Boolean

#### CanPasteGrid()

##### Declaration

```
public static bool CanPasteGrid()
```

##### Returns

Type

Description

System.Boolean

#### CanPlaceBlock(Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, UInt64, Nullable<Int32>, Boolean, Boolean)

##### Declaration

```
public bool CanPlaceBlock(Vector3I min, Vector3I max, MyBlockOrientation orientation, MyCubeBlockDefinition definition, ulong placingPlayer = 0UL, Nullable<int> ignoreMultiblockId = null, bool ignoreFracturedPieces = false, bool isProjection = false)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

min

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

max

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientation

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

definition

System.UInt64

placingPlayer

System.Nullable<System.Int32\>

ignoreMultiblockId

System.Boolean

ignoreFracturedPieces

System.Boolean

isProjection

##### Returns

Type

Description

System.Boolean

#### CanPlaceBlock(Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, ref MyGridPlacementSettings, UInt64, Nullable<Int32>, Boolean, Boolean)
