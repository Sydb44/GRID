##### Returns

| Type | Description |
| --- | --- |
| VRage.MyTuple<System.Single, System.Single\> | Pair of floats where 1st value is Volume amount and 2nd value is ratio of Volume amount to Whole volume. |

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetVoxelRangeTypeInBoundingBox_VRageMath_BoundingBoxD_)GetVoxelRangeTypeInBoundingBox(BoundingBoxD)

##### Declaration

```
public MyVoxelContentConstitution GetVoxelRangeTypeInBoundingBox(BoundingBoxD worldAabb)
```

##### Parameters

##### Returns

#### [](#Sandbox_Game_Entities_MyVoxelBase_Init_System_String_VRage_Game_Voxels_IMyStorage_VRageMath_MatrixD_System_Boolean_)Init(String, IMyStorage, MatrixD, Boolean)

##### Declaration

```
public virtual void Init(string storageName, IMyStorage storage, MatrixD worldMatrix, bool useVoxelOffset = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName |     |
| VRage.Game.Voxels.IMyStorage | storage |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| System.Boolean | useVoxelOffset |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_Init_System_String_VRage_Game_Voxels_IMyStorage_VRageMath_Vector3D_)Init(String, IMyStorage, Vector3D)

##### Declaration

```
public void Init(string storageName, IMyStorage storage, Vector3D positionMinCorner)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | storageName |     |
| VRage.Game.Voxels.IMyStorage | storage |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | positionMinCorner |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_Init_VRage_ObjectBuilders_MyObjectBuilder_EntityBase_VRage_Game_Voxels_IMyStorage_)Init(MyObjectBuilder\_EntityBase, IMyStorage)

##### Declaration

```
public abstract void Init(MyObjectBuilder_EntityBase builder, IMyStorage storage)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_InitVoxelMap_VRageMath_MatrixD_VRageMath_Vector3I_System_Boolean_)InitVoxelMap(MatrixD, Vector3I, Boolean)

##### Declaration

```
protected virtual void InitVoxelMap(MatrixD worldMatrix, Vector3I size, bool useOffset = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [Vector3I](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3I.html) | size |     |
| System.Boolean | useOffset |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_IntersectStorage_VRageMath_BoundingBox__System_Boolean_)IntersectStorage(ref BoundingBox, Boolean)

##### Declaration

```
public ContainmentType IntersectStorage(ref BoundingBox box, bool lazy = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBox](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBox.html) | box |     |
| System.Boolean | lazy |     |

##### Returns

#### [](#Sandbox_Game_Entities_MyVoxelBase_IsAnyAabbCornerInside_VRageMath_MatrixD__VRageMath_BoundingBoxD_)IsAnyAabbCornerInside(ref MatrixD, BoundingBoxD)

##### Declaration

```
public bool IsAnyAabbCornerInside(ref MatrixD aabbWorldTransform, BoundingBoxD aabb)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_IsAnyOfPointInside_VRageMath_Vector3D___)IsAnyOfPointInside(Vector3D\[\])

##### Declaration

```
public bool IsAnyOfPointInside(Vector3D[] worldPoints)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\[\] | worldPoints |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_IsBoxIntersectingBoundingBoxOfThisVoxelMap_VRageMath_BoundingBoxD__)IsBoxIntersectingBoundingBoxOfThisVoxelMap(ref BoundingBoxD)

##### Declaration

```
public bool IsBoxIntersectingBoundingBoxOfThisVoxelMap(ref BoundingBoxD boundingBox)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_IsForbiddenEntity_VRage_Game_Entity_MyEntity_)IsForbiddenEntity(MyEntity)

##### Declaration

```
public static bool IsForbiddenEntity(MyEntity entity)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_IsOverlapOverThreshold_VRageMath_BoundingBoxD_System_Single_)IsOverlapOverThreshold(BoundingBoxD, Single)

##### Declaration

```
public virtual bool IsOverlapOverThreshold(BoundingBoxD worldAabb, float thresholdPercentage = 0.9F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | worldAabb |     |
| System.Single | thresholdPercentage |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_OnRangeChanged_VRageMath_Vector3I_VRageMath_Vector3I_VRage_Voxels_MyStorageDataTypeFlags_)OnRangeChanged(Vector3I, Vector3I, MyStorageDataTypeFlags)

##### Declaration

```
protected void OnRangeChanged(Vector3I voxelRangeMin, Vector3I voxelRangeMax, MyStorageDataTypeFlags changedData)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_OnReplicationEnded)OnReplicationEnded()

##### Declaration

```
public override void OnReplicationEnded()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyVoxelBase_OnReplicationStarted)OnReplicationStarted()

##### Declaration

```
public override void OnReplicationStarted()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyVoxelBase_OverlapsSphereLocal_System_Single_VRageMath_Vector3D_)OverlapsSphereLocal(Single, Vector3D)
