Description

System.Single

gridSize

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridCoords

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GridIntegerToWorld(Vector3D)

##### Declaration

```
public Vector3D GridIntegerToWorld(Vector3D gridCoords)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

gridCoords

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GridIntegerToWorld(Vector3I)

##### Declaration

```
public Vector3D GridIntegerToWorld(Vector3I gridCoords)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridCoords

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### GunShooting()

##### Declaration

```
public void GunShooting()
```

#### HandleRemovalOfOwnershipTransferRequests()

##### Declaration

```
public static void HandleRemovalOfOwnershipTransferRequests()
```

#### HasMainCockpit()

##### Declaration

```
public bool HasMainCockpit()
```

##### Returns

Type

Description

System.Boolean

#### HasMainRemoteControl()

##### Declaration

```
public bool HasMainRemoteControl()
```

##### Returns

Type

Description

System.Boolean

#### HasStandAloneBlocks()

Returns true when grid have at least one stand alone block

##### Declaration

```
public bool HasStandAloneBlocks()
```

##### Returns

Type

Description

System.Boolean

#### HasStandAloneBlocks(List<MySlimBlock>, Int32, Int32)

Returns true when grid have at least one stand alone block

##### Declaration

```
public static bool HasStandAloneBlocks(List<MySlimBlock> blocks, int offset, int count)
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

#### HierarchyUpdated(MyCubeGrid)

##### Declaration

```
public void HierarchyUpdated(MyCubeGrid root)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

root

#### Init(MyObjectBuilder\_EntityBase)

##### Declaration

```
public override void Init(MyObjectBuilder_EntityBase objectBuilder)
```

##### Parameters

Type

Name

Description

[MyObjectBuilder\_EntityBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_EntityBase.html)

objectBuilder

##### Overrides

#### InvokeDepressurizeEffect(Vector3I, Vector3I)

##### Declaration

```
public void InvokeDepressurizeEffect(Vector3I from, Vector3I to)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

from

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

to

#### IsAabbInsideVoxel(MatrixD, BoundingBoxD, MyGridPlacementSettings)

Checks if aabb is in voxel. If settings provided it will return false if penetration settings allow for it.

##### Declaration

```
public static bool IsAabbInsideVoxel(MatrixD worldMatrix, BoundingBoxD localAabb, MyGridPlacementSettings settings)
```

##### Parameters

Type

Name

Description

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

worldMatrix

World matrix of the aabb.

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

localAabb

Local aabb

VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings

settings

Game settings

##### Returns

Type

Description

System.Boolean

#### IsConnectedTo(MyCubeGrid, GridLinkTypeEnum)

Checks if 2 grids are connected

##### Declaration

```
public bool IsConnectedTo(MyCubeGrid testGrid, GridLinkTypeEnum type)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

testGrid

Grid to test

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

type

Type of connection

##### Returns

Type

Description

System.Boolean

#### IsDirty()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### IsGizmoDrawingEnabled()

##### Declaration

```
public bool IsGizmoDrawingEnabled()
```

##### Returns

Type

Description

System.Boolean

#### IsGridInCompleteState(MyCubeGrid)

##### Declaration

```
public static bool IsGridInCompleteState(MyCubeGrid grid)
```

##### Parameters

Type

Name

Description

[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)

grid

##### Returns

Type

Description

System.Boolean

#### IsInSameLogicalGroupAs(IMyCubeGrid)

##### Declaration

```
public bool IsInSameLogicalGroupAs(IMyCubeGrid other)
```

##### Parameters

Type

Name

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

other

##### Returns

Type

Description

System.Boolean

#### IsInVoxels(MySlimBlock, Boolean, Boolean)

##### Declaration

```
public static bool IsInVoxels(MySlimBlock block, bool checkForPhysics = true, bool isVolumetric = false)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Entities.Cube.MySlimBlock

block

System.Boolean

checkForPhysics

System.Boolean

isVolumetric

##### Returns

Type

Description

System.Boolean

#### IsMainCockpit(MyTerminalBlock)
