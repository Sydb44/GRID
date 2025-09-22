worldMatrix

Havok.HkBodyCollision

collison

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

wheelMatrix

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

definition

##### Returns

Type

Description

System.Boolean

#### TestPlacementForWheelWhenPlacingWheel(MyAttachableTopBlockBase, MatrixD, Vector3D, List<HkBodyCollision>)

##### Declaration

```
public static bool TestPlacementForWheelWhenPlacingWheel(MyAttachableTopBlockBase rotorBlock, MatrixD rotation, Vector3D wheelPosition, List<HkBodyCollision> m_tmpList)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Blocks.MyAttachableTopBlockBase

rotorBlock

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

rotation

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

wheelPosition

System.Collections.Generic.List<Havok.HkBodyCollision\>

m\_tmpList

##### Returns

Type

Description

System.Boolean

#### TestPlacementVoxelMapOverlap(MyVoxelBase, ref MyGridPlacementSettings, ref BoundingBoxD, ref MatrixD, Boolean)

##### Declaration

```
public static bool TestPlacementVoxelMapOverlap(MyVoxelBase voxelMap, ref MyGridPlacementSettings settings, ref BoundingBoxD localAabb, ref MatrixD worldMatrix, bool touchingStaticGrid = false)
```

##### Parameters

Type

Name

Description

[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)

voxelMap

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

settings

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

localAabb

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

System.Boolean

touchingStaticGrid

##### Returns

Type

Description

System.Boolean

#### TestVoxelPlacement(MyCubeBlockDefinition, MyGridPlacementSettings, Boolean, MatrixD, BoundingBoxD)

##### Declaration

```
public static bool TestVoxelPlacement(MyCubeBlockDefinition blockDefinition, MyGridPlacementSettings settingsCopy, bool dynamicBuildMode, MatrixD worldMatrix, BoundingBoxD localAabb)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

blockDefinition

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

settingsCopy

System.Boolean

dynamicBuildMode

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

localAabb

##### Returns

Type

Description

System.Boolean

#### ToggleHandbrakeRequest()

##### Declaration

```
[Event(null, 10122)]
[Reliable]
[Server]
public void ToggleHandbrakeRequest()
```

#### ToggleParkStateRequest()

##### Declaration

```
[Event(null, 10176)]
[Reliable]
[Server]
public void ToggleParkStateRequest()
```

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

Type

Description

System.String

##### Overrides

#### TransferBlockLimitsBuiltByID(Int64, MyBlockLimits, MyBlockLimits)

##### Declaration

```
public void TransferBlockLimitsBuiltByID(long author, MyBlockLimits oldLimits, MyBlockLimits newLimits)
```

##### Parameters

Type

Name

Description

System.Int64

author

Sandbox.Game.World.MyBlockLimits

oldLimits

Sandbox.Game.World.MyBlockLimits

newLimits

#### TransferBlocksBuiltByID(Int64, Int64)

Transfer all blocks built by a specific player to another player

##### Declaration

```
[Event(null, 3708)]
[Reliable]
[ServerInvoked]
[Broadcast]
public void TransferBlocksBuiltByID(long oldAuthor, long newAuthor)
```

##### Parameters

Type

Name

Description

System.Int64

oldAuthor

System.Int64

newAuthor

#### TransferBlocksBuiltByIDClient(Int64, Int64)

##### Declaration

```
public void TransferBlocksBuiltByIDClient(long oldAuthor, long newAuthor)
```

##### Parameters

Type

Name

Description

System.Int64

oldAuthor

System.Int64

newAuthor

#### TransformMountPoints(List<MyCubeBlockDefinition.MountPoint>, MyCubeBlockDefinition, MyCubeBlockDefinition.MountPoint\[\], ref MyBlockOrientation)

Fills passed lists with mount point data, which is transformed using orientation of the block.

##### Declaration

```
public static void TransformMountPoints(List<MyCubeBlockDefinition.MountPoint> outMountPoints, MyCubeBlockDefinition def, MyCubeBlockDefinition.MountPoint[] mountPoints, ref MyBlockOrientation orientation)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\>

outMountPoints

Output buffer.

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

def

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

mountPoints

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientation

#### TryGetCube(Vector3I, out MyCube)

##### Declaration

```
public bool TryGetCube(Vector3I position, out MyCube cube)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

[MyCube](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCube.html)

cube

##### Returns

Type

Description

System.Boolean

#### TryPasteGrid\_Implementation(MyCubeGrid.MyPasteGridParameters)
