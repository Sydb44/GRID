---
title: "Interface IMyVoxelShape"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyVoxelShape"
---

# Interface IMyVoxelShape | Space Engineers ModAPI

Describes voxel shape for filling or excavating

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyVoxelShape
```

### Properties

#### Transform

World matrix of voxel shape

##### Declaration

```
MatrixD Transform { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) |     |

### Methods

#### GetIntersectionVolume(ref Vector3D)

Gets volume of intersection of shape and voxel

##### Declaration

```
float GetIntersectionVolume(ref Vector3D voxelPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | voxelPosition | Left bottom point of voxel |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Normalized volume of intersection |

#### GetWorldBoundary()

Gets current world boundaries

##### Declaration

```
BoundingBoxD GetWorldBoundary()
```

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### PeekWorldBoundary(ref Vector3D)

Peeks world boundaries at given position

##### Declaration

```
BoundingBoxD PeekWorldBoundary(ref Vector3D targetPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | targetPosition |     |

##### Returns

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |