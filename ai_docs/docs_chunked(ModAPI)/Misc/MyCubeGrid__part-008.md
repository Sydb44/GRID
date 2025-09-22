Type

Name

Description

[MyOwnershipShareModeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyOwnershipShareModeEnum.html)

shareMode

System.Collections.Generic.Dictionary<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html), System.Collections.Generic.List<[MyCubeGrid.MySingleOwnershipRequest](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MySingleOwnershipRequest.html)\>>

requests

#### CheckAreaConnectivity(MyCubeGrid, ref MyCubeGrid.MyBlockBuildArea, List<Vector3UByte>, HashSet<Vector3UByte>)

##### Declaration

```
public static void CheckAreaConnectivity(MyCubeGrid grid, ref MyCubeGrid.MyBlockBuildArea area, List<Vector3UByte> validOffsets, HashSet<Vector3UByte> resultFailList)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

[MyCubeGrid.MyBlockBuildArea](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.MyBlockBuildArea.html)

area

System.Collections.Generic.List<[Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html)\>

validOffsets

System.Collections.Generic.HashSet<[Vector3UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3UByte.html)\>

resultFailList

#### CheckConnectivity(IMyGridConnectivityTest, MyCubeBlockDefinition, MyCubeBlockDefinition.MountPoint\[\], ref Quaternion, ref Vector3I)

Performs check whether cube block given by its definition, rotation and position is connected to some other block in a given grid.

##### Declaration

```
public static bool CheckConnectivity(IMyGridConnectivityTest grid, MyCubeBlockDefinition def, MyCubeBlockDefinition.MountPoint[] mountPoints, ref Quaternion rotation, ref Vector3I position)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.IMyGridConnectivityTest

grid

Grid in which the check is performed.

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

def

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

mountPoints

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

Rotation of the cube block within grid.

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

position

Position of the cube block within grid.

##### Returns

Type

Description

System.Boolean

True when there is a connectable neighbor connected by a mount point, otherwise false.

#### CheckConnectivitySmallBlockToLargeGrid(MyCubeGrid, MyCubeBlockDefinition, ref Quaternion, ref Vector3I)

Performs check whether small cube block given by its definition, rotation can be connected to large grid. Function checks whether a mount point on placed block exists in opposite direction than addNomal.

##### Declaration

```
public static bool CheckConnectivitySmallBlockToLargeGrid(MyCubeGrid grid, MyCubeBlockDefinition def, ref Quaternion rotation, ref Vector3I addNormal)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

Grid in which the check is performed.

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

def

Definition of small cube block for checking.

[Quaternion](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Quaternion.html)

rotation

Rotation of the small cube block.

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

addNormal

Grid hit normal.

##### Returns

Type

Description

System.Boolean

True when small block can be connected, otherwise false.

#### CheckMergeConnectivity(MyCubeGrid, MyCubeGrid, Vector3I)

##### Declaration

```
public static bool CheckMergeConnectivity(MyCubeGrid hitGrid, MyCubeGrid gridToMerge, Vector3I gridOffset)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

hitGrid

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

gridToMerge

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridOffset

##### Returns

Type

Description

System.Boolean

#### CheckMountPointsForSide(MyCubeBlockDefinition, MyCubeBlockDefinition.MountPoint\[\], ref MyBlockOrientation, ref Vector3I, ref Vector3I, MyCubeBlockDefinition, MyCubeBlockDefinition.MountPoint\[\], ref MyBlockOrientation, ref Vector3I)

Checkes whether blocks A and B have matching mount point on one of their sides. Each block is given by its definition, rotation and position in grid. Position has to be relative to same center. Also, normal relative to block A specifies wall which is used for checking.

##### Declaration

```
public static bool CheckMountPointsForSide(MyCubeBlockDefinition defA, MyCubeBlockDefinition.MountPoint[] mountPointsA, ref MyBlockOrientation orientationA, ref Vector3I positionA, ref Vector3I normalA, MyCubeBlockDefinition defB, MyCubeBlockDefinition.MountPoint[] mountPointsB, ref MyBlockOrientation orientationB, ref Vector3I positionB)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

defA

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

mountPointsA

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientationA

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

positionA

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

normalA

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

defB

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

mountPointsB

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientationB

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

positionB
