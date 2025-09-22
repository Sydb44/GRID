---
title: "Class MyRenderDataBuilder"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyRenderDataBuilder.html"
category: "Misc"
namespace: "VRage.Voxels"
class: "MyRenderDataBuilder"
---

# Class MyRenderDataBuilder | Space Engineers ModAPI

##### Inheritance

System.Object

MyRenderDataBuilder

###### **Namespace**: [VRage.Voxels](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public class MyRenderDataBuilder : Object
```

### Constructors

#### MyRenderDataBuilder()

##### Declaration

```
public MyRenderDataBuilder()
```

### Properties

#### Instance

Current thread's static instance.

##### Declaration

```
public static MyRenderDataBuilder Instance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyRenderDataBuilder](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyRenderDataBuilder.html) |     |

### Methods

#### Build(VrVoxelMesh, out MyVoxelRenderCellData, IMyVoxelRenderDataProcessorProvider)

Build render cell data from a native mesh.

##### Declaration

```
public void Build(VrVoxelMesh mesh, out MyVoxelRenderCellData data, IMyVoxelRenderDataProcessorProvider dataProcessorProvider)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Voxels.VrVoxelMesh | mesh |     |
| VRageRender.Voxels.MyVoxelRenderCellData | data |     |
| VRageRender.Voxels.IMyVoxelRenderDataProcessorProvider | dataProcessorProvider |     |