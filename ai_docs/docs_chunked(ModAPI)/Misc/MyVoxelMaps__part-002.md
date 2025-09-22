| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) | ignoreVoxelMap |     |
| System.Collections.Generic.List<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\> | voxelList |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD, MyVoxelBase)

Return reference to voxel map that intersects the box. If not voxel map found, null is returned.

##### Declaration

```
public MyVoxelBase GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD boundingBox, MyVoxelBase ignoreVoxelMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) | ignoreVoxelMap |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

#### RemoveVoxelMap(MyVoxelBase)

##### Declaration

```
public void RemoveVoxelMap(MyVoxelBase voxelMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) | voxelMap |     |

#### TryGetVoxelBaseById(Int64)

##### Declaration

```
public MyVoxelBase TryGetVoxelBaseById(long id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

#### TryGetVoxelMapByName(String)

##### Declaration

```
public MyVoxelBase TryGetVoxelMapByName(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

#### TryGetVoxelMapByNameStart(String)

##### Declaration

```
public MyVoxelBase TryGetVoxelMapByNameStart(string name)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

### Explicit Interface Implementations

#### IMyVoxelMaps.Clear()

##### Declaration

```
void IMyVoxelMaps.Clear()
```

#### IMyVoxelMaps.CreatePredefinedVoxelMap(String, String, MatrixD, Boolean)

##### Declaration

```
IMyVoxelMap IMyVoxelMaps.CreatePredefinedVoxelMap(string storageName, string voxelMaterial, MatrixD matrix, bool useVoxelOffset)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName |     |
| System.String | voxelMaterial |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | matrix |     |
| System.Boolean | useVoxelOffset |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelMap](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelMap.html) |     |

#### IMyVoxelMaps.CreateProceduralVoxelMap(Int32, Single, MatrixD)

##### Declaration

```
IMyVoxelMap IMyVoxelMaps.CreateProceduralVoxelMap(int seed, float radius, MatrixD matrix)
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

#### IMyVoxelMaps.CreateStorage(Byte\[\])

##### Declaration

```
IMyStorage IMyVoxelMaps.CreateStorage(byte[] data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Byte\[\] | data |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyStorage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html) |     |

#### IMyVoxelMaps.CreateStorage(Vector3I)

##### Declaration

```
IMyStorage IMyVoxelMaps.CreateStorage(Vector3I size)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | size |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyStorage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html) |     |

#### IMyVoxelMaps.CreateVoxelMap(String, IMyStorage, Vector3D, Int64)

##### Declaration

```
IMyVoxelMap IMyVoxelMaps.CreateVoxelMap(string storageName, IMyStorage storage, Vector3D position, long voxelMapId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName |     |
| [IMyStorage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html) | storage |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |
| System.Int64 | voxelMapId |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelMap](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelMap.html) |     |

#### IMyVoxelMaps.CreateVoxelMapFromStorageName(String, String, Vector3D)
