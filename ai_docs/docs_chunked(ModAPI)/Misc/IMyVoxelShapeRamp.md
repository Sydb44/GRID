---
title: "Interface IMyVoxelShapeRamp"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeRamp.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyVoxelShapeRamp"
---

# Interface IMyVoxelShapeRamp | Space Engineers ModAPI

Describes ramp voxel shape for filling or excavating

##### Inherited Members

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyVoxelShapeRamp : IMyVoxelShape
```

### Properties

#### Boundaries

##### Declaration

```
BoundingBoxD Boundaries { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |

#### RampNormal

normal of the sloped plane

##### Declaration

```
Vector3D RampNormal { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### RampNormalW

##### Declaration

```
double RampNormalW { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |