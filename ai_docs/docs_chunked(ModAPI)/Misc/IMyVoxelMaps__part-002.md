```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap | Voxel map |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if registered |

#### FillInShape(IMyVoxelBase, IMyVoxelShape, Byte)

Will fill given material with given shape

##### Declaration

```
void FillInShape(IMyVoxelBase voxelMap, IMyVoxelShape voxelShape, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [IMyVoxelShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html) | voxelShape |     |
| System.Byte | materialIdx |     |

#### GetBoxVoxelHand()

##### Declaration

```
IMyVoxelShapeBox GetBoxVoxelHand()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelShapeBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeBox.html) | Box voxel hand |

#### GetCapsuleVoxelHand()

##### Declaration

```
IMyVoxelShapeCapsule GetCapsuleVoxelHand()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelShapeCapsule](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeCapsule.html) | Capsule voxel hand |

#### GetInstances(List<IMyVoxelBase>, Func<IMyVoxelBase, Boolean>)

##### Declaration

```
void GetInstances(List<IMyVoxelBase> outInstances, Func<IMyVoxelBase, bool> collect = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html)\> | outInstances | List, that would receive results |
| System.Func<[IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html), System.Boolean\> | collect | When function is null or returns true, item would be added to list |

#### GetOverlappingWithSphere(ref BoundingSphereD)

Get first found [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) that intersects with sphere

##### Declaration

```
IMyVoxelBase GetOverlappingWithSphere(ref BoundingSphereD sphere)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | Sphere to intersect |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | Null or first found [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) |

#### GetRampVoxelHand()

##### Declaration

```
IMyVoxelShapeRamp GetRampVoxelHand()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelShapeRamp](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeRamp.html) | Ramp voxel hand |

#### GetSphereVoxelHand()

##### Declaration

```
IMyVoxelShapeSphere GetSphereVoxelHand()
```

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelShapeSphere](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShapeSphere.html) | Sphere voxel hand |

#### GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD, IMyVoxelBase)

Get first found [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) that intersects with bounding box, ordered by distance to box center

##### Declaration

```
IMyVoxelBase GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD boundingBox, IMyVoxelBase ignoreVoxelMap)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | boundingBox | Box to intersect |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | ignoreVoxelMap | Can't be return value |

##### Returns

| Type | Description |
| --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) |

#### MakeCrater(IMyVoxelBase, BoundingSphereD, Vector3, Byte)

##### Declaration

```
void MakeCrater(IMyVoxelBase voxelMap, BoundingSphereD sphere, Vector3 direction, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | direction |     |
| System.Byte | materialIdx |     |

#### PaintInShape(IMyVoxelBase, IMyVoxelShape, Byte)

Will paint given material with given shape

##### Declaration

```
void PaintInShape(IMyVoxelBase voxelMap, IMyVoxelShape voxelShape, byte materialIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [IMyVoxelShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html) | voxelShape |     |
| System.Byte | materialIdx |     |

#### RevertShape(IMyVoxelBase, IMyVoxelShape)

##### Declaration

```
void RevertShape(IMyVoxelBase voxelMap, IMyVoxelShape voxelShape)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html) | voxelMap |     |
| [IMyVoxelShape](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyVoxelShape.html) | voxelShape |     |
