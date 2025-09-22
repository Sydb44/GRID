---
title: "Class MyVoxelMaps"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelMaps.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyVoxelMaps"
---

# Class MyVoxelMaps | Space Engineers ModAPI

##### Inheritance

System.Object

MyVoxelMaps

##### Implements

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyVoxelMaps : Object, IMyVoxelMaps
```

### Constructors

#### MyVoxelMaps()

##### Declaration

### Properties

#### Instances

##### Declaration

```
public DictionaryValuesReader<long, MyVoxelBase> Instances { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [DictionaryValuesReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryValuesReader-2.html)<System.Int64, [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\> |     |

### Methods

#### Add(MyVoxelBase)

##### Declaration

```
public void Add(MyVoxelBase voxelMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) | voxelMap |     |

#### Clear()

##### Declaration

#### DebugDraw(MyVoxelDebugDrawMode)

##### Declaration

```
public void DebugDraw(MyVoxelDebugDrawMode drawMode)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Voxels.MyVoxelDebugDrawMode | drawMode |     |

#### Exist(MyVoxelBase)

##### Declaration

```
public bool Exist(MyVoxelBase voxelMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) | voxelMap |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetAllOverlappingWithSphere(ref BoundingSphereD)

##### Declaration

```
public List<MyVoxelBase> GetAllOverlappingWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\> |     |

#### GetAllOverlappingWithSphere(ref BoundingSphereD, List<MyVoxelBase>)

##### Declaration

```
public void GetAllOverlappingWithSphere(ref BoundingSphereD sphere, List<MyVoxelBase> voxels)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| System.Collections.Generic.List<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\> | voxels |     |

#### GetCacheStats(out Int32, out Int32)

##### Declaration

```
public void GetCacheStats(out int cachedChuncks, out int pendingCachedChuncks)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | cachedChuncks |     |
| System.Int32 | pendingCachedChuncks |     |

#### GetOverlappingWithSphere(ref BoundingSphereD)

##### Declaration

```
public MyVoxelBase GetOverlappingWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) |     |

#### GetVoxelMapsArray(Boolean)

##### Declaration

```
public Dictionary<string, byte[]> GetVoxelMapsArray(bool includeChanged)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | includeChanged |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Byte\[\]> |     |

#### GetVoxelMapsData(Boolean, Boolean, Dictionary<String, IMyStorage>)

##### Declaration

```
public Dictionary<string, byte[]> GetVoxelMapsData(bool includeChanged, bool compressed, Dictionary<string, IMyStorage> voxelStorageNameCache = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | includeChanged |     |
| System.Boolean | compressed |     |
| System.Collections.Generic.Dictionary<System.String, VRage.Game.Voxels.IMyStorage\> | voxelStorageNameCache |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<System.String, System.Byte\[\]> |     |

#### GetVoxelMapsWhoseBoundingBoxesIntersectBox(ref BoundingBoxD, MyVoxelBase, List<MyVoxelBase>)

##### Declaration

```
public bool GetVoxelMapsWhoseBoundingBoxesIntersectBox(ref BoundingBoxD boundingBox, MyVoxelBase ignoreVoxelMap, List<MyVoxelBase> voxelList)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |
| [MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html) | ignoreVoxelMap |     |
| System.Collections.Generic.List<[MyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyVoxelBase.html)\> | voxelList |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD, MyVoxelBase)

Return reference to voxel map that intersects the box. If not voxel map found, null is returned.
