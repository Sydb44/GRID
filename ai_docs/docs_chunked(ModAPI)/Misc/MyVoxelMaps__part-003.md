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

##### Declaration

```
IMyVoxelMap IMyVoxelMaps.CreateVoxelMapFromStorageName(string storageName, string prefabVoxelMapName, Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName |     |
| System.String | prefabVoxelMapName |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelMap](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelMap.html) |     |

#### IMyVoxelMaps.CutOutShape(IMyVoxelBase, IMyVoxelShape)

##### Declaration

```
void IMyVoxelMaps.CutOutShape(IMyVoxelBase voxelMap, IMyVoxelShape voxelShape)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [IMyVoxelShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html) | voxelShape |     |

#### IMyVoxelMaps.Exist(IMyVoxelBase)

##### Declaration

```
bool IMyVoxelMaps.Exist(IMyVoxelBase voxelMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyVoxelMaps.FillInShape(IMyVoxelBase, IMyVoxelShape, Byte)

##### Declaration

```
void IMyVoxelMaps.FillInShape(IMyVoxelBase voxelMap, IMyVoxelShape voxelShape, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [IMyVoxelShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html) | voxelShape |     |
| System.Byte | materialIdx |     |

#### IMyVoxelMaps.GetBoxVoxelHand()

##### Declaration

```
IMyVoxelShapeBox IMyVoxelMaps.GetBoxVoxelHand()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelShapeBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeBox.html) |     |

#### IMyVoxelMaps.GetCapsuleVoxelHand()

##### Declaration

```
IMyVoxelShapeCapsule IMyVoxelMaps.GetCapsuleVoxelHand()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelShapeCapsule](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeCapsule.html) |     |

#### IMyVoxelMaps.GetInstances(List<IMyVoxelBase>, Func<IMyVoxelBase, Boolean>)

##### Declaration

```
void IMyVoxelMaps.GetInstances(List<IMyVoxelBase> voxelMaps, Func<IMyVoxelBase, bool> collect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html)\> | voxelMaps |     |
| System.Func<[IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html), System.Boolean\> | collect |     |

#### IMyVoxelMaps.GetOverlappingWithSphere(ref BoundingSphereD)

##### Declaration

```
IMyVoxelBase IMyVoxelMaps.GetOverlappingWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) |     |

#### IMyVoxelMaps.GetRampVoxelHand()

##### Declaration

```
IMyVoxelShapeRamp IMyVoxelMaps.GetRampVoxelHand()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelShapeRamp](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeRamp.html) |     |

#### IMyVoxelMaps.GetSphereVoxelHand()

##### Declaration

```
IMyVoxelShapeSphere IMyVoxelMaps.GetSphereVoxelHand()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelShapeSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeSphere.html) |     |

#### IMyVoxelMaps.GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD, IMyVoxelBase)

##### Declaration

```
IMyVoxelBase IMyVoxelMaps.GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD boundingBox, IMyVoxelBase ignoreVoxelMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox |     |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | ignoreVoxelMap |     |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) |     |

#### IMyVoxelMaps.MakeCrater(IMyVoxelBase, BoundingSphereD, Vector3, Byte)

##### Declaration

```
void IMyVoxelMaps.MakeCrater(IMyVoxelBase voxelMap, BoundingSphereD sphere, Vector3 direction, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | direction |     |
| System.Byte | materialIdx |     |
