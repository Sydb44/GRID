```
public static void LocalPositionToWorldPosition(Vector3D referenceVoxelMapPosition, ref Vector3 localPosition, out Vector3D worldPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_VertexCellToLocalAABB_System_Int32_VRageMath_Vector3I__VRageMath_BoundingBoxD__)VertexCellToLocalAABB(Int32, ref Vector3I, out BoundingBoxD)

##### Declaration

```
public static void VertexCellToLocalAABB(int lod, ref Vector3I vertexCell, out BoundingBoxD localAABB)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_VertexCellToLocalPosition_System_Int32_VRageMath_Vector3I__VRageMath_Vector3__)VertexCellToLocalPosition(Int32, ref Vector3I, out Vector3)

##### Declaration

```
public static void VertexCellToLocalPosition(int lod, ref Vector3I vertexCell, out Vector3 localPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vertexCell |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | localPosition |     |

#### [](#VRage_Voxels_MyVoxelCoordSystems_VoxelCoordToGeometryCellCoord_VRageMath_Vector3I__VRageMath_Vector3I__)VoxelCoordToGeometryCellCoord(ref Vector3I, out Vector3I)

##### Declaration

```
public static void VoxelCoordToGeometryCellCoord(ref Vector3I voxelCoord, out Vector3I geometryCellCoord)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_VoxelCoordToLocalPosition_VRageMath_Vector3I__VRageMath_Vector3__)VoxelCoordToLocalPosition(ref Vector3I, out Vector3)

##### Declaration

```
public static void VoxelCoordToLocalPosition(ref Vector3I voxelCoord, out Vector3 localPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_VoxelCoordToWorldAABB_VRageMath_Vector3D_VRageMath_Vector3I__VRageMath_BoundingBoxD__)VoxelCoordToWorldAABB(Vector3D, ref Vector3I, out BoundingBoxD)

##### Declaration

```
public static void VoxelCoordToWorldAABB(Vector3D referenceVoxelMapPosition, ref Vector3I voxelCoord, out BoundingBoxD worldAABB)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_VoxelCoordToWorldPosition_VRageMath_MatrixD_VRageMath_Vector3D_VRageMath_Vector3_VRageMath_Vector3I__VRageMath_Vector3D__)VoxelCoordToWorldPosition(MatrixD, Vector3D, Vector3, ref Vector3I, out Vector3D)

##### Declaration

```
public static void VoxelCoordToWorldPosition(MatrixD matrix, Vector3D referenceVoxelMapPosition, Vector3 halfsize, ref Vector3I voxelCoord, out Vector3D worldPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_VoxelCoordToWorldPosition_VRageMath_Vector3D_VRageMath_Vector3I__VRageMath_Vector3D__)VoxelCoordToWorldPosition(Vector3D, ref Vector3I, out Vector3D)

##### Declaration

```
public static void VoxelCoordToWorldPosition(Vector3D referenceVoxelMapPosition, ref Vector3I voxelCoord, out Vector3D worldPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_WorldPositionToGeometryCellCoord_VRageMath_Vector3D_VRageMath_Vector3D__VRageMath_Vector3I__)WorldPositionToGeometryCellCoord(Vector3D, ref Vector3D, out Vector3I)

##### Declaration

```
public static void WorldPositionToGeometryCellCoord(Vector3D referenceVoxelMapPosition, ref Vector3D worldPosition, out Vector3I geometryCellCoord)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_WorldPositionToLocalPosition_VRageMath_MatrixD_VRageMath_Vector3D_VRageMath_Vector3_VRageMath_Vector3D__VRageMath_Vector3__)WorldPositionToLocalPosition(MatrixD, Vector3D, Vector3, ref Vector3D, out Vector3)

##### Declaration

```
public static void WorldPositionToLocalPosition(MatrixD matrix, Vector3D referenceVoxelMapPosition, Vector3 halfSize, ref Vector3D worldPosition, out Vector3 localPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_WorldPositionToLocalPosition_VRageMath_Vector3D_VRageMath_MatrixD_VRageMath_MatrixD_VRageMath_Vector3_VRageMath_Vector3__)WorldPositionToLocalPosition(Vector3D, MatrixD, MatrixD, Vector3, out Vector3)

##### Declaration

```
public static void WorldPositionToLocalPosition(Vector3D worldPosition, MatrixD worldMatrix, MatrixD worldMatrixInv, Vector3 halfSize, out Vector3 localPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_WorldPositionToLocalPosition_VRageMath_Vector3D_VRageMath_Vector3D__VRageMath_Vector3__)WorldPositionToLocalPosition(Vector3D, ref Vector3D, out Vector3)

##### Declaration

```
public static void WorldPositionToLocalPosition(Vector3D referenceVoxelMapPosition, ref Vector3D worldPosition, out Vector3 localPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_WorldPositionToVoxelCoord_VRageMath_MatrixD_VRageMath_Vector3D_VRageMath_Vector3_VRageMath_Vector3D__VRageMath_Vector3I__)WorldPositionToVoxelCoord(MatrixD, Vector3D, Vector3, ref Vector3D, out Vector3I)

##### Declaration

```
public static void WorldPositionToVoxelCoord(MatrixD matrix, Vector3D referenceVoxelMapPosition, Vector3 halfsize, ref Vector3D worldPosition, out Vector3I voxelCoord)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_WorldPositionToVoxelCoord_VRageMath_Vector3D_VRageMath_Vector3D__VRageMath_Vector3I__)WorldPositionToVoxelCoord(Vector3D, ref Vector3D, out Vector3I)

##### Declaration

```
public static void WorldPositionToVoxelCoord(Vector3D referenceVoxelMapPosition, ref Vector3D worldPosition, out Vector3I voxelCoord)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_WorldPositionToVoxelCoord_VRageMath_Vector3D__VRageMath_MatrixD_VRageMath_MatrixD_VRageMath_Vector3_VRageMath_Vector3I__)WorldPositionToVoxelCoord(ref Vector3D, MatrixD, MatrixD, Vector3, out Vector3I)

##### Declaration

```
public static void WorldPositionToVoxelCoord(ref Vector3D worldPosition, MatrixD worldMatrix, MatrixD worldMatrixInv, Vector3 halfSize, out Vector3I voxelCoord)
```

##### Parameters