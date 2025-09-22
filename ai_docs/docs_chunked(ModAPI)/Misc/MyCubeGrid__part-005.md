Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridPosition

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

boneOffset

#### AnnounceRemoveSplit(List<MySlimBlock>)

##### Declaration

```
public void AnnounceRemoveSplit(List<MySlimBlock> blocks)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks

#### ApplyDestructionDeformation(MySlimBlock, Single, Nullable<MyHitInfo>, Int64)

##### Declaration

```
public void ApplyDestructionDeformation(MySlimBlock block, float damage = 1F, Nullable<MyHitInfo> hitInfo = null, long attackerId = 0L)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Single

damage

System.Nullable<[MyHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyHitInfo.html)\>

hitInfo

System.Int64

attackerId

#### ApplyLastControls()

##### Declaration

```
public override void ApplyLastControls()
```

##### Overrides

#### BeforeDelete()

##### Declaration

```
protected override void BeforeDelete()
```

##### Overrides

#### BreakGridGroupLink(GridLinkTypeEnum, Int64, MyCubeGrid, MyCubeGrid)

##### Declaration

```
public static bool BreakGridGroupLink(GridLinkTypeEnum type, long linkId, MyCubeGrid parent, MyCubeGrid child)
```

##### Parameters

Type

Name

Description

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

type

System.Int64

linkId

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

parent

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

child

##### Returns

Type

Description

System.Boolean

#### BuildBlockRequestInternal(MyCubeGrid.MyBlockVisuals, MyCubeGrid.MyBlockLocation, MyObjectBuilder\_CubeBlock, Int64, Boolean, Int64, UInt64, Boolean)

##### Declaration

```
public void BuildBlockRequestInternal(MyCubeGrid.MyBlockVisuals visuals, MyCubeGrid.MyBlockLocation location, MyObjectBuilder_CubeBlock blockObjectBuilder, long builderEntityId, bool instantBuild, long ownerId, ulong sender, bool isProjection = false)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.MyBlockVisuals](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockVisuals.html)

visuals

[MyCubeGrid.MyBlockLocation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockLocation.html)

location

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

blockObjectBuilder

System.Int64

builderEntityId

System.Boolean

instantBuild

System.Int64

ownerId

System.UInt64

sender

System.Boolean

isProjection

#### BuildBlocks(ref MyCubeGrid.MyBlockBuildArea, Int64, Int64)

Network friendly alternative for building block

##### Declaration

```
public void BuildBlocks(ref MyCubeGrid.MyBlockBuildArea area, long builderEntityId, long ownerId)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.MyBlockBuildArea](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockBuildArea.html)

area

System.Int64

builderEntityId

System.Int64

ownerId

#### BuildBlocks(Vector3, MyStringHash, HashSet<MyCubeGrid.MyBlockLocation>, Int64, Int64)

Builds many same blocks, used when building lines or planes.

##### Declaration

```
public void BuildBlocks(Vector3 colorMaskHsv, MyStringHash skinId, HashSet<MyCubeGrid.MyBlockLocation> locations, long builderEntityId, long ownerId)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

colorMaskHsv

[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)

skinId

System.Collections.Generic.HashSet<[MyCubeGrid.MyBlockLocation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockLocation.html)\>

locations

System.Int64

builderEntityId

System.Int64

ownerId

#### BuildBlocksClient(MyCubeGrid.MyBlockVisuals, HashSet<MyCubeGrid.MyBlockLocation>, Int64, Boolean, Int64)

##### Declaration

```
[Event(null, 3936)]
[Reliable]
[Broadcast]
public void BuildBlocksClient(MyCubeGrid.MyBlockVisuals visuals, HashSet<MyCubeGrid.MyBlockLocation> locations, long builderEntityId, bool instantBuild, long ownerId)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.MyBlockVisuals](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockVisuals.html)

visuals

System.Collections.Generic.HashSet<[MyCubeGrid.MyBlockLocation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockLocation.html)\>

locations

System.Int64

builderEntityId

System.Boolean

instantBuild

System.Int64

ownerId

#### BuildBlocksFailedNotify()

##### Declaration

```
[Event(null, 3929)]
[Reliable]
[Client]
public void BuildBlocksFailedNotify()
```

#### BuildBlockSucess(MyCubeGrid.MyBlockVisuals, MyCubeGrid.MyBlockLocation, MyObjectBuilder\_CubeBlock, Int64, Boolean, Int64)

##### Declaration

```
[Event(null, 3808)]
[Reliable]
[Broadcast]
public void BuildBlockSucess(MyCubeGrid.MyBlockVisuals visuals, MyCubeGrid.MyBlockLocation location, [DynamicObjectBuilder(false)] MyObjectBuilder_CubeBlock blockObjectBuilder, long builderEntityId, bool instantBuild, long ownerId)
```

##### Parameters

Type

Name

Description

[MyCubeGrid.MyBlockVisuals](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockVisuals.html)

visuals

[MyCubeGrid.MyBlockLocation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockLocation.html)

location

[MyObjectBuilder\_CubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_CubeBlock.html)

blockObjectBuilder

System.Int64

builderEntityId

System.Boolean

instantBuild

System.Int64

ownerId
