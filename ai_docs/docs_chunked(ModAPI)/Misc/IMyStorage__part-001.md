---
title: "Interface IMyStorage"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html"
category: "Misc"
namespace: "VRage.ModAPI"
class: "IMyStorage"
---

# Interface IMyStorage | Space Engineers ModAPI

ModAPI interface giving access to voxel functions

###### **Namespace**: [VRage.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyStorage
```

### Properties

#### Closed

Returns true if voxel storage was closed

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DeleteSupported

Returns if deletion is supported

##### Declaration

```
bool DeleteSupported { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MarkedForClose

Returns true if the voxel storage is marked for a pending close

##### Declaration

```
bool MarkedForClose { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Size

The size of the voxel storage, in voxel coordinates

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) |     |

### Methods

#### DeleteRange(MyStorageDataTypeFlags, Vector3I, Vector3I, Boolean)

Deletes content in cache and storage

##### Declaration

```
void DeleteRange(MyStorageDataTypeFlags dataToWrite, Vector3I voxelRangeMin, Vector3I voxelRangeMax, bool notify)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | dataToWrite | Content to delete |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelRangeMin | From (Inclusive) |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelRangeMax | To (Inclusive) |
| System.Boolean | notify | Notify that range changed |

#### ExecuteOperationFast<TVoxelOperator>(ref TVoxelOperator, MyStorageDataTypeFlags, ref Vector3I, ref Vector3I, Boolean)

Performs in-place voxel operation

##### Declaration

```
void ExecuteOperationFast<TVoxelOperator>(ref TVoxelOperator voxelOperator, MyStorageDataTypeFlags dataToWrite, ref Vector3I voxelRangeMin, ref Vector3I voxelRangeMax, bool notifyRangeChanged)
    where TVoxelOperator : struct, IVoxelOperator, ValueType
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TVoxelOperator | voxelOperator | Function to be called over voxels |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | dataToWrite | Content to operate with |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelRangeMin | From (Inclusive) |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelRangeMax | To (Inclusive) |
| System.Boolean | notifyRangeChanged | Notify that range changed |

##### Type Parameters

| Name | Description |
| --- | --- |
| TVoxelOperator | Function to be called over voxels |

#### Intersect(ref BoundingBox, Boolean)

Returns the intersection with the storage region

##### Declaration

```
ContainmentType Intersect(ref BoundingBox box, bool lazy)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box | Position in local coordinates |
| System.Boolean | lazy | When true, you get less detailed results |

##### Returns

| Type | Description |
| --- | --- |
| [ContainmentType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.ContainmentType.html) | Containment type |

#### Intersect(ref LineD)

Returns true if the specific line intersects the storage region

##### Declaration

```
bool Intersect(ref LineD line)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line | Line in local coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if line intersects |

#### NotifyRangeChanged(ref Vector3I, ref Vector3I, MyStorageDataTypeFlags)

Notify that range changed

##### Declaration

```
void NotifyRangeChanged(ref Vector3I voxelRangeMin, ref Vector3I voxelRangeMax, MyStorageDataTypeFlags dataChanged)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelRangeMin | From (Inclusive) |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelRangeMax | To (Inclusive) |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | dataChanged | Content that changed |

#### OverwriteAllMaterials(Byte)

Replaces all materials in range with the specific material

##### Declaration

```
void OverwriteAllMaterials(byte materialIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte | materialIndex |     |

#### PinAndExecute(Action)

Pins the voxel storage to prevent closing, then executes specified action. Unpins when action completes.

##### Declaration

```
void PinAndExecute(Action action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | Action to execute |

#### PinAndExecute(Action<IMyStorage>)

Pins the voxel storage to prevent closing, then executes specified action. Unpins when action completes.

##### Declaration

```
void PinAndExecute(Action<IMyStorage> action)
```
