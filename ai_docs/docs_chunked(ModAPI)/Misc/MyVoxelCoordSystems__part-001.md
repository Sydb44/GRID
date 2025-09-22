---
title: "Class MyVoxelCoordSystems"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyVoxelCoordSystems.html"
category: "Misc"
namespace: "VRage.Voxels"
class: "MyVoxelCoordSystems"
---

# Class MyVoxelCoordSystems | Space Engineers ModAPI

Functions for transforming to and from various coordinate systems in voxel maps and for computing bounding boxes of various types of cells. Note that local and world positions are (and should be) always in the min-corner!

##### Inheritance

System.Object

MyVoxelCoordSystems

###### **Namespace**: [VRage.Voxels](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.html)

###### **Assembly**: VRage.dll

##### Syntax

```
public static class MyVoxelCoordSystems : Object
```

### [](#methods)Methods

#### [](#VRage_Voxels_MyVoxelCoordSystems_FindBestOctreeSize_System_Single_)FindBestOctreeSize(Single)

##### Declaration

```
public static Vector3I FindBestOctreeSize(float radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | radius |     |

##### Returns

#### [](#VRage_Voxels_MyVoxelCoordSystems_GeometryCellCenterCoordToWorldPos_VRageMath_Vector3D_VRageMath_Vector3I__VRageMath_Vector3D__)GeometryCellCenterCoordToWorldPos(Vector3D, ref Vector3I, out Vector3D)

##### Declaration

```
public static void GeometryCellCenterCoordToWorldPos(Vector3D referenceVoxelMapPosition, ref Vector3I geometryCellCoord, out Vector3D worldPos)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_GeometryCellCoordToLocalAABB_VRageMath_Vector3I__VRageMath_BoundingBox__)GeometryCellCoordToLocalAABB(ref Vector3I, out BoundingBox)

##### Declaration

```
public static void GeometryCellCoordToLocalAABB(ref Vector3I geometryCellCoord, out BoundingBox localAABB)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_GeometryCellCoordToLocalPosition_VRage_Voxels_MyCellCoord__VRageMath_Vector3__)GeometryCellCoordToLocalPosition(ref MyCellCoord, out Vector3)

##### Declaration

```
public static void GeometryCellCoordToLocalPosition(ref MyCellCoord geometryCellCoord, out Vector3 localPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_GeometryCellCoordToLocalPosition_VRageMath_Vector3I__VRageMath_Vector3__)GeometryCellCoordToLocalPosition(ref Vector3I, out Vector3)

##### Declaration

```
public static void GeometryCellCoordToLocalPosition(ref Vector3I geometryCellCoord, out Vector3 localPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_GeometryCellCoordToWorldAABB_VRageMath_Vector3D_VRage_Voxels_MyCellCoord__VRageMath_BoundingBoxD__)GeometryCellCoordToWorldAABB(Vector3D, ref MyCellCoord, out BoundingBoxD)

##### Declaration

```
public static void GeometryCellCoordToWorldAABB(Vector3D referenceVoxelMapPosition, ref MyCellCoord geometryCellCoord, out BoundingBoxD worldAABB)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_GeometryCellCoordToWorldAABB_VRageMath_Vector3D_VRageMath_Vector3I__VRageMath_BoundingBoxD__)GeometryCellCoordToWorldAABB(Vector3D, ref Vector3I, out BoundingBoxD)

##### Declaration

```
public static void GeometryCellCoordToWorldAABB(Vector3D referenceVoxelMapPosition, ref Vector3I geometryCellCoord, out BoundingBoxD worldAABB)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_LocalPositionToGeometryCellCoord_VRageMath_Vector3__VRageMath_Vector3I__)LocalPositionToGeometryCellCoord(ref Vector3, out Vector3I)

##### Declaration

```
public static void LocalPositionToGeometryCellCoord(ref Vector3 localPosition, out Vector3I geometryCellCoord)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_LocalPositionToVertexCell_System_Int32_VRageMath_Vector3__VRageMath_Vector3I__)LocalPositionToVertexCell(Int32, ref Vector3, out Vector3I)

##### Declaration

```
public static void LocalPositionToVertexCell(int lod, ref Vector3 localPosition, out Vector3I vertexCell)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | lod |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | localPosition |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | vertexCell |     |

#### [](#VRage_Voxels_MyVoxelCoordSystems_LocalPositionToVoxelCoord_VRageMath_Vector3__VRageMath_Vector3D__)LocalPositionToVoxelCoord(ref Vector3, out Vector3D)

##### Declaration

```
public static void LocalPositionToVoxelCoord(ref Vector3 localPosition, out Vector3D voxelCoord)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_LocalPositionToVoxelCoord_VRageMath_Vector3__VRageMath_Vector3I__)LocalPositionToVoxelCoord(ref Vector3, out Vector3I)

##### Declaration

```
public static void LocalPositionToVoxelCoord(ref Vector3 localPosition, out Vector3I voxelCoord)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_LocalPositionToWorldPosition_VRageMath_MatrixD_VRageMath_Vector3D_VRageMath_Vector3_VRageMath_Vector3__VRageMath_Vector3D__)LocalPositionToWorldPosition(MatrixD, Vector3D, Vector3, ref Vector3, out Vector3D)

##### Declaration

```
public static void LocalPositionToWorldPosition(MatrixD matrix, Vector3D referenceVoxelMapPosition, Vector3 halfSize, ref Vector3 localPosition, out Vector3D worldPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_LocalPositionToWorldPosition_VRageMath_Vector3D_VRageMath_Vector3__VRageMath_Vector3D__)LocalPositionToWorldPosition(Vector3D, ref Vector3, out Vector3D)

##### Declaration

```
public static void LocalPositionToWorldPosition(Vector3D referenceVoxelMapPosition, ref Vector3 localPosition, out Vector3D worldPosition)
```

##### Parameters

#### [](#VRage_Voxels_MyVoxelCoordSystems_VertexCellToLocalAABB_System_Int32_VRageMath_Vector3I__VRageMath_BoundingBoxD__)VertexCellToLocalAABB(Int32, ref Vector3I, out BoundingBoxD)

##### Declaration

```
public static void VertexCellToLocalAABB(int lod, ref Vector3I vertexCell, out BoundingBoxD localAABB)
```
