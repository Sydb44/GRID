---
title: "Interface IMyVoxelMaps"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelMaps.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyVoxelMaps"
---

# Interface IMyVoxelMaps | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyVoxelMaps
```

### Properties

#### VoxelMaterialCount

##### Declaration

```
int VoxelMaterialCount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Clear()

Resets all voxels over whole world

##### Declaration

#### CreatePredefinedVoxelMap(String, String, MatrixD, Boolean)

Creates an voxel map with some additional options.

##### Declaration

```
IMyVoxelMap CreatePredefinedVoxelMap(string storageName, string voxelMaterial, MatrixD matrix, bool useVoxelOffset)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName | SubtypeId of a VoxelMap Definition |
| System.String | voxelMaterial | If provided with a Voxel Material SubtypeId, the entire voxel map will be converted to that material. Otherwise, if this value is Empty or Null, the default materials for the voxel map will be used. |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix | World Matrix used for positioning voxel map |
| System.Boolean | useVoxelOffset | If set to true, the voxel will be placed using the center of the voxel bounding box, instead of using PositionLeftBottomCorner |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelMap](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelMap.html) | A voxel map (eg: asteroid) as IMyVoxelMap |

#### CreateProceduralVoxelMap(Int32, Single, MatrixD)

##### Declaration

```
IMyVoxelMap CreateProceduralVoxelMap(int seed, float radius, MatrixD matrix)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | seed |     |
| System.Single | radius |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelMap](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelMap.html) |     |

#### CreateStorage(Byte\[\])

Creates storage from GZipped bytes.

##### Declaration

```
IMyStorage CreateStorage(byte[] data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | data | Voxels data |

##### Returns

| Type | Description |
| --- | --- |
| [IMyStorage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html) | Created storage |

#### CreateStorage(Vector3I)

Creates voxels storage

##### Declaration

```
IMyStorage CreateStorage(Vector3I size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | size | Size of storage in voxel coordinates |

##### Returns

| Type | Description |
| --- | --- |
| [IMyStorage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html) | Created storage |

#### CreateVoxelMap(String, IMyStorage, Vector3D, Int64)

Creates voxels map

##### Declaration

```
IMyVoxelMap CreateVoxelMap(string storageName, IMyStorage storage, Vector3D position, long voxelMapId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName | Name of storage |
| [IMyStorage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html) | storage | Voxels storage |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | World coordinates |
| System.Int64 | voxelMapId | Id of voxel map |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelMap](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelMap.html) | Voxels map |

#### CreateVoxelMapFromStorageName(String, String, Vector3D)

Adds a prefab voxel to the game world.

##### Declaration

```
IMyVoxelMap CreateVoxelMapFromStorageName(string storageName, string prefabVoxelMapName, Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName | The name of which the voxel storage will be called within the world. |
| System.String | prefabVoxelMapName | The prefab voxel to add. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | The Min corner position of the voxel within the world. |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelMap](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelMap.html) | The newly added voxel map. Returns null if the prefabVoxelMapName does not exist. |

#### CutOutShape(IMyVoxelBase, IMyVoxelShape)

Will cut out given shape

##### Declaration

```
void CutOutShape(IMyVoxelBase voxelMap, IMyVoxelShape voxelShape)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [IMyVoxelShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html) | voxelShape |     |

#### Exist(IMyVoxelBase)

Returns if voxel registered

##### Declaration

```
bool Exist(IMyVoxelBase voxelMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap | Voxel map |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if registered |
