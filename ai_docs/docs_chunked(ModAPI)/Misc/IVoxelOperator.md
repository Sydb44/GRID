---
title: "Interface IVoxelOperator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IVoxelOperator.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "IVoxelOperator"
---

# Interface IVoxelOperator | Space Engineers ModAPI

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IVoxelOperator
```

### Properties

#### Flags

Mode of work

##### Declaration

```
VoxelOperatorFlags Flags { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [VoxelOperatorFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.VoxelOperatorFlags.html) |     |

### Methods

#### Op(ref Vector3I, MyStorageDataTypeEnum, ref Byte)

This function is called per each voxel

##### Declaration

```
void Op(ref Vector3I position, MyStorageDataTypeEnum dataType, ref byte inOutContent)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | position | Position of voxel |
| [MyStorageDataTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeEnum.html) | dataType | Type of content |
| System.Byte | inOutContent | Reference to data. You can change it, and it would apply changes |