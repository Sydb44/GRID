
##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | sphereRadius |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | spherePos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyVoxelBase_FindOutsidePosition_VRageMath_Vector3D_System_Single_)FindOutsidePosition(Vector3D, Single)

Find a storage local position that is outside of voxel content within a given radius.

##### Declaration

```
public virtual Vector3D FindOutsidePosition(Vector3D localPosition, float radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | localPosition |     |
| System.Single | radius |     |

##### Returns

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetContainedVoxelCoords_VRageMath_BoundingBoxD__VRageMath_Vector3I__VRageMath_Vector3I__)GetContainedVoxelCoords(ref BoundingBoxD, out Vector3I, out Vector3I)

##### Declaration

```
public bool GetContainedVoxelCoords(ref BoundingBoxD worldAabb, out Vector3I min, out Vector3I max)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetFilledStorageBounds_VRageMath_Vector3I__VRageMath_Vector3I__)GetFilledStorageBounds(out Vector3I, out Vector3I)

##### Declaration

```
public void GetFilledStorageBounds(out Vector3I min, out Vector3I max)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetIntersectionWithLine_VRageMath_LineD__System_Nullable_VRage_Game_Models_MyIntersectionResultLineTriangleEx___VRage_Game_Components_IntersectionFlags_)GetIntersectionWithLine(ref LineD, out Nullable<MyIntersectionResultLineTriangleEx>, IntersectionFlags)

##### Declaration

```
public override bool GetIntersectionWithLine(ref LineD worldLine, out Nullable<MyIntersectionResultLineTriangleEx> t, IntersectionFlags flags)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | worldLine |     |
| System.Nullable<VRage.Game.Models.MyIntersectionResultLineTriangleEx\> | t   |     |
| [IntersectionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.IntersectionFlags.html) | flags |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetIntersectionWithLine_VRageMath_LineD__System_Nullable_VRageMath_Vector3D___System_Boolean_VRage_Game_Components_IntersectionFlags_)GetIntersectionWithLine(ref LineD, out Nullable<Vector3D>, Boolean, IntersectionFlags)

##### Declaration

```
public override bool GetIntersectionWithLine(ref LineD worldLine, out Nullable<Vector3D> v, bool useCollisionModel = true, IntersectionFlags flags)
```

##### Parameters

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetMaterialAt_VRageMath_Vector3D__)GetMaterialAt(ref Vector3D)

##### Declaration

```
public MyVoxelMaterialDefinition GetMaterialAt(ref Vector3D worldPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPosition |     |

##### Returns

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetMaterialsInShape_Sandbox_Engine_Voxels_MyShape_System_Int32_)GetMaterialsInShape(MyShape, Int32)

##### Declaration

```
public HashSet<byte> GetMaterialsInShape(MyShape shape, int lod = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Engine.Voxels.MyShape | shape |     |
| System.Int32 | lod |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.Generic.HashSet<System.Byte\> |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetObjectBuilder_System_Boolean_)GetObjectBuilder(Boolean)

##### Declaration

```
public override MyObjectBuilder_EntityBase GetObjectBuilder(bool copy = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | copy |     |

##### Returns

##### Overrides

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetOrePriority)GetOrePriority()

##### Declaration

```
public virtual int GetOrePriority()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetVoxelContentInBoundingBox_Fast_VRageMath_BoundingBoxD_VRageMath_MatrixD_System_Boolean_System_Single_)GetVoxelContentInBoundingBox\_Fast(BoundingBoxD, MatrixD, Boolean, Single)

Calculates amount of volume of a bounding box in voxels.

##### Declaration

```
public MyTuple<float, float> GetVoxelContentInBoundingBox_Fast(BoundingBoxD localAabb, MatrixD worldMatrix, bool stopIfFindAtLeastOneContent = false, float threshold = 0.1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | localAabb | Local bounding box to query for. |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix | World matrix of the bounding box. |
| System.Boolean | stopIfFindAtLeastOneContent |     |
| System.Single | threshold | Wipes out TOO small voxels |

##### Returns

| Type | Description |
| --- | --- |
| VRage.MyTuple<System.Single, System.Single\> | Pair of floats where 1st value is Volume amount and 2nd value is ratio of Volume amount to Whole volume. |

#### [](#Sandbox_Game_Entities_MyVoxelBase_GetVoxelRangeTypeInBoundingBox_VRageMath_BoundingBoxD_)GetVoxelRangeTypeInBoundingBox(BoundingBoxD)

##### Declaration

```
public MyVoxelContentConstitution GetVoxelRangeTypeInBoundingBox(BoundingBoxD worldAabb)
```
