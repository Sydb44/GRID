blocks3

System.Boolean

respectDeformationRatio

System.Single

detectionBlockHalfSize

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

invWorldGrid

#### GetBlocksIntersectingOBB(in BoundingBoxD, in MatrixD, List<MySlimBlock>)

##### Declaration

```
public void GetBlocksIntersectingOBB(in BoundingBoxD box, in MatrixD boxTransform, List<MySlimBlock> blocks)
```

##### Parameters

Type

Name

Description

[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)

box

[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)

boxTransform

System.Collections.Generic.List<Sandbox.Game.Entities.Cube.MySlimBlock\>

blocks

#### GetClosestCorner(Vector3I, Vector3)

Returns cube corner which is closest to position

##### Declaration

```
public Vector3 GetClosestCorner(Vector3I gridPos, Vector3 position)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

gridPos

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

position

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### GetConnectedGrids(GridLinkTypeEnum, Action<MyCubeGrid>)

Iterate over all grids connected to this grid

##### Declaration

```
public void GetConnectedGrids(GridLinkTypeEnum type, Action<MyCubeGrid> action)
```

##### Parameters

Type

Name

Description

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

type

Type of connection

System.Action<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

action

Action would be called per each connected grid

#### GetConnectedGrids(GridLinkTypeEnum, List<MyCubeGrid>)

Get all grids connected to this grid

##### Declaration

```
public List<MyCubeGrid> GetConnectedGrids(GridLinkTypeEnum type, List<MyCubeGrid> list = null)
```

##### Parameters

Type

Name

Description

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

type

Type of connection

System.Collections.Generic.List<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

list

Cache list, you can keep it null, then new List will be allocated

##### Returns

Type

Description

System.Collections.Generic.List<[MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html)\>

#### GetCubeBlock(Vector3I)

##### Declaration

```
public MySlimBlock GetCubeBlock(Vector3I pos)
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

Sandbox.Game.Entities.Cube.MySlimBlock

#### GetCubeParts(MyCubeBlockDefinition, Vector3I, Matrix, Single, List<String>, List<MatrixD>, List<Vector3>, List<Vector4UByte>, Boolean)

##### Declaration

```
public static void GetCubeParts(MyCubeBlockDefinition block, Vector3I inputPosition, Matrix rotation, float gridSize, List<string> outModels, List<MatrixD> outLocalMatrices, List<Vector3> outLocalNormals, List<Vector4UByte> outPatternOffsets, bool topologyCheck)
```

##### Parameters

Type

Name

Description

[MyCubeBlockDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyCubeBlockDefinition.html)

block

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

inputPosition

[Matrix](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Matrix.html)

rotation

System.Single

gridSize

System.Collections.Generic.List<System.String\>

outModels

System.Collections.Generic.List<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\>

outLocalMatrices

System.Collections.Generic.List<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\>

outLocalNormals

System.Collections.Generic.List<[Vector4UByte](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector4UByte.html)\>

outPatternOffsets

System.Boolean

topologyCheck

#### GetCurrentMass(out Single, out Single, GridLinkTypeEnum)

##### Declaration

```
public float GetCurrentMass(out float baseMass, out float physicalMass, GridLinkTypeEnum linking)
```

##### Parameters

Type

Name

Description

System.Single

baseMass

System.Single

physicalMass

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

linking

##### Returns

Type

Description

System.Single

#### GetCurrentMass(GridLinkTypeEnum)

##### Declaration

```
public float GetCurrentMass(GridLinkTypeEnum linking)
```

##### Parameters

Type

Name

Description

[GridLinkTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.GridLinkTypeEnum.html)

linking

##### Returns

Type

Description

System.Single

#### GetDebugUpdateInfo(List<MyCubeGrid.DebugUpdateRecord>)

Get a debug friendly list of all scheduled update methods in this grid.

##### Declaration

```
public void GetDebugUpdateInfo(List<MyCubeGrid.DebugUpdateRecord> gridDebugUpdateInfo)
```

##### Parameters

Type

Name

Description

System.Collections.Generic.List<[MyCubeGrid.DebugUpdateRecord](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.DebugUpdateRecord.html)\>

gridDebugUpdateInfo

#### GetExistingCubeForBoneDeformations(ref Vector3I, ref MyDamageInformation)

##### Declaration

```
public MySlimBlock GetExistingCubeForBoneDeformations(ref Vector3I cube, ref MyDamageInformation damageInfo)
```

##### Parameters

Type

Name

Description

[Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html)

cube

[MyDamageInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html)

damageInfo
