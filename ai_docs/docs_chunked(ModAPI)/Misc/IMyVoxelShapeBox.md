---
title: "Interface IMyVoxelShapeBox"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeBox.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyVoxelShapeBox"
---

# Interface IMyVoxelShapeBox | Space Engineers ModAPI

Describes box voxel shape for filling or excavating

##### Inherited Members

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyVoxelShapeBox : IMyVoxelShape
```

### Properties

#### Boundaries

Boundaries are in local space, you need to use transform property to rotate/translate shape

##### Declaration

```
BoundingBoxD Boundaries { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) |     |