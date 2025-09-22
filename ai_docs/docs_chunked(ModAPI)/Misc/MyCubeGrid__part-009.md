defB

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

mountPointsB

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientationB

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

positionB

##### Returns

Type

Description

System.Boolean

#### CheckMountPointsForSide(List<MyCubeBlockDefinition.MountPoint>, ref MyBlockOrientation, ref Vector3I, MyDefinitionId, ref Vector3I, List<MyCubeBlockDefinition.MountPoint>, ref MyBlockOrientation, ref Vector3I, MyDefinitionId)

Checkes whether blocks A and B have matching mount point on one of their sides. Each block is given by its definition, rotation and position in grid. Position has to be relative to same center. Also, normal relative to block A specifies wall which is used for checking.

##### Declaration

```
public static bool CheckMountPointsForSide(List<MyCubeBlockDefinition.MountPoint> transormedA, ref MyBlockOrientation orientationA, ref Vector3I positionA, MyDefinitionId idA, ref Vector3I normalA, List<MyCubeBlockDefinition.MountPoint> transormedB, ref MyBlockOrientation orientationB, ref Vector3I positionB, MyDefinitionId idB)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\>

transormedA

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientationA

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

positionA

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

idA

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

normalA

System.Collections.Generic.List<[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\>

transormedB

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

orientationB

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

positionB

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

idB

##### Returns

Type

Description

System.Boolean

#### CheckNeighborMountPoints(Vector3, Vector3, MyCubeBlockDefinition.MountPoint, ref Vector3I, MyCubeBlockDefinition, Vector3I, MyCubeBlockDefinition, MyCubeBlockDefinition.MountPoint\[\], MyBlockOrientation, List<MyCubeBlockDefinition.MountPoint>)

##### Declaration

```
public static bool CheckNeighborMountPoints(Vector3 currentMin, Vector3 currentMax, MyCubeBlockDefinition.MountPoint thisMountPoint, ref Vector3I thisMountPointTransformedNormal, MyCubeBlockDefinition thisDefinition, Vector3I neighborPosition, MyCubeBlockDefinition neighborDefinition, MyCubeBlockDefinition.MountPoint[] neighborMountPoints, MyBlockOrientation neighborOrientation, List<MyCubeBlockDefinition.MountPoint> otherMountPoints)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

currentMin

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

currentMax

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)

thisMountPoint

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

thisMountPointTransformedNormal

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

thisDefinition

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

neighborPosition

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

neighborDefinition

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

neighborMountPoints

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

neighborOrientation

System.Collections.Generic.List<[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\>

otherMountPoints

##### Returns

Type

Description

System.Boolean

#### CheckNeighborMountPointsForCompound(Vector3, Vector3, MyCubeBlockDefinition.MountPoint, ref Vector3I, MyCubeBlockDefinition, Vector3I, MyCubeBlockDefinition, MyCubeBlockDefinition.MountPoint\[\], MyBlockOrientation, List<MyCubeBlockDefinition.MountPoint>)

##### Declaration

```
public static bool CheckNeighborMountPointsForCompound(Vector3 currentMin, Vector3 currentMax, MyCubeBlockDefinition.MountPoint thisMountPoint, ref Vector3I thisMountPointTransformedNormal, MyCubeBlockDefinition thisDefinition, Vector3I neighborPosition, MyCubeBlockDefinition neighborDefinition, MyCubeBlockDefinition.MountPoint[] neighborMountPoints, MyBlockOrientation neighborOrientation, List<MyCubeBlockDefinition.MountPoint> otherMountPoints)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

currentMin

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

currentMax

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)

thisMountPoint

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

thisMountPointTransformedNormal

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

thisDefinition

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

neighborPosition

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

neighborDefinition

[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\[\]

neighborMountPoints

[MyBlockOrientation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MyBlockOrientation.html)

neighborOrientation

System.Collections.Generic.List<[MyCubeBlockDefinition.MountPoint](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.MountPoint.html)\>

otherMountPoints
