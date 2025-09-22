| Type | Name | Description |
| --- | --- | --- |
| System.Action | action | Action to execute |

#### PinAndExecute(Action<IMyStorage>)

Pins the voxel storage to prevent closing, then executes specified action. Unpins when action completes.

##### Declaration

```
void PinAndExecute(Action<IMyStorage> action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<[IMyStorage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html)\> | action | Action to execute |

#### ReadRange(MyStorageData, MyStorageDataTypeFlags, Int32, Vector3I, Vector3I)

Reads range of content and/or materials from specified LOD. If you want to write data back later, you must read LOD0 as that is the only writable one.

##### Declaration

```
void ReadRange(MyStorageData target, MyStorageDataTypeFlags dataToRead, int lodIndex, Vector3I lodVoxelRangeMin, Vector3I lodVoxelRangeMax)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageData.html) | target | Source from where to read data |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | dataToRead | Content to read |
| System.Int32 | lodIndex | Level of detail. 0 - most detailed |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | lodVoxelRangeMin | From (Inclusive) |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | lodVoxelRangeMax | To (Inclusive) |

#### ReadRange(MyStorageData, MyStorageDataTypeFlags, Int32, Vector3I, Vector3I, ref MyVoxelRequestFlags)

Reads range of content and/or materials from specified LOD. If you want to write data back later, you must read LOD0 as that is the only writable one.

##### Declaration

```
void ReadRange(MyStorageData target, MyStorageDataTypeFlags dataToRead, int lodIndex, Vector3I lodVoxelRangeMin, Vector3I lodVoxelRangeMax, ref MyVoxelRequestFlags requestFlags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageData.html) | target |     |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | dataToRead |     |
| System.Int32 | lodIndex |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | lodVoxelRangeMin |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | lodVoxelRangeMax |     |
| [MyVoxelRequestFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyVoxelRequestFlags.html) | requestFlags |     |

#### Reset(MyStorageDataTypeFlags)

Resets the data specified by flags to values from data provider, or default if no provider is assigned.

##### Declaration

```
void Reset(MyStorageDataTypeFlags dataToReset)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | dataToReset | Content that should be read from disk |

#### Save(out Byte\[\])

Gets compressed voxel data

##### Declaration

```
void Save(out byte[] outCompressedData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | outCompressedData |     |

#### WriteRange(MyStorageData, MyStorageDataTypeFlags, Vector3I, Vector3I, Boolean, Boolean)

Writes range of content and/or materials from cache to storage. Note that this can only write to LOD0 (higher LODs must be computed based on that).

##### Declaration

```
void WriteRange(MyStorageData source, MyStorageDataTypeFlags dataToWrite, Vector3I voxelRangeMin, Vector3I voxelRangeMax, bool notify = true, bool skipCache = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyStorageData](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageData.html) | source |     |
| [MyStorageDataTypeFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Voxels.MyStorageDataTypeFlags.html) | dataToWrite |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelRangeMin | From (Inclusive) |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | voxelRangeMax | To (Inclusive) |
| System.Boolean | notify | Notify that range changed |
| System.Boolean | skipCache | Skips cache |