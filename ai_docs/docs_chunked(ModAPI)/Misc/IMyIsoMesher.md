---
title: "Interface IMyIsoMesher"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.IMyIsoMesher.html"
category: "Misc"
namespace: "VRage.Voxels"
class: "IMyIsoMesher"
---

# Interface IMyIsoMesher | Space Engineers ModAPI

###### **Namespace**: [VRage.Voxels](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyIsoMesher
```

### Properties

#### InvalidatedRangeInflate

##### Declaration

```
int InvalidatedRangeInflate { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### Precalc(IMyStorage, Int32, Vector3I, Vector3I, MyStorageDataTypeFlags, MyVoxelRequestFlags)

##### Declaration

```
MyIsoMesh Precalc(IMyStorage storage, int lod, Vector3I lodVoxelMin, Vector3I lodVoxelMax, MyStorageDataTypeFlags properties, MyVoxelRequestFlags flags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Voxels.IMyStorage | storage |     |
| System.Int32 | lod |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | lodVoxelMin |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | lodVoxelMax |     |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | properties |     |
| [MyVoxelRequestFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyVoxelRequestFlags.html) | flags |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyIsoMesh](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyIsoMesh.html) |     |