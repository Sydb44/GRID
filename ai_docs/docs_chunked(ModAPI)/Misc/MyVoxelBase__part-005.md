##### Overrides

#### [](#Sandbox_Game_Entities_MyVoxelBase_OnReplicationStarted)OnReplicationStarted()

##### Declaration

```
public override void OnReplicationStarted()
```

##### Overrides

#### [](#Sandbox_Game_Entities_MyVoxelBase_OverlapsSphereLocal_System_Single_VRageMath_Vector3D_)OverlapsSphereLocal(Single, Vector3D)

##### Declaration

```
protected bool OverlapsSphereLocal(float sphereRadius, Vector3D spherePos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | sphereRadius |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | spherePos |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_PerformCutOutSphereFast_VRageMath_Vector3D_System_Single_System_Boolean_)PerformCutOutSphereFast(Vector3D, Single, Boolean)

##### Declaration

```
[Event(null, 1156)]
[Reliable]
[Broadcast]
public void PerformCutOutSphereFast(Vector3D center, float radius, bool notify)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | center |     |
| System.Single | radius |     |
| System.Boolean | notify |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_remove_RangeChanged_Sandbox_Game_Entities_MyVoxelBase_StorageChanged_)remove\_RangeChanged(MyVoxelBase.StorageChanged)

##### Declaration

```
public void remove_RangeChanged(MyVoxelBase.StorageChanged value)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_RequestVoxelCutoutSphere_VRageMath_Vector3D_System_Single_System_Boolean_System_Boolean_)RequestVoxelCutoutSphere(Vector3D, Single, Boolean, Boolean)

##### Declaration

```
public void RequestVoxelCutoutSphere(Vector3D center, float radius, bool createDebris, bool damage)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | center |     |
| System.Single | radius |     |
| System.Boolean | createDebris |     |
| System.Boolean | damage |     |

#### [](#Sandbox_Game_Entities_MyVoxelBase_RequestVoxelOperationBox_VRageMath_BoundingBoxD_VRageMath_MatrixD_System_Byte_Sandbox_Game_Entities_MyVoxelBase_OperationType_)RequestVoxelOperationBox(BoundingBoxD, MatrixD, Byte, MyVoxelBase.OperationType)

##### Declaration

```
public void RequestVoxelOperationBox(BoundingBoxD box, MatrixD Transformation, byte material, MyVoxelBase.OperationType Type)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_RequestVoxelOperationCapsule_VRageMath_Vector3D_VRageMath_Vector3D_System_Single_VRageMath_MatrixD_System_Byte_Sandbox_Game_Entities_MyVoxelBase_OperationType_)RequestVoxelOperationCapsule(Vector3D, Vector3D, Single, MatrixD, Byte, MyVoxelBase.OperationType)

##### Declaration

```
public void RequestVoxelOperationCapsule(Vector3D A, Vector3D B, float radius, MatrixD Transformation, byte material, MyVoxelBase.OperationType Type)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_RequestVoxelOperationElipsoid_VRageMath_Vector3_VRageMath_MatrixD_System_Byte_Sandbox_Game_Entities_MyVoxelBase_OperationType_)RequestVoxelOperationElipsoid(Vector3, MatrixD, Byte, MyVoxelBase.OperationType)

##### Declaration

```
public void RequestVoxelOperationElipsoid(Vector3 radius, MatrixD Transformation, byte material, MyVoxelBase.OperationType Type)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_RequestVoxelOperationRamp_VRageMath_BoundingBoxD_VRageMath_Vector3D_System_Double_VRageMath_MatrixD_System_Byte_Sandbox_Game_Entities_MyVoxelBase_OperationType_)RequestVoxelOperationRamp(BoundingBoxD, Vector3D, Double, MatrixD, Byte, MyVoxelBase.OperationType)

##### Declaration

```
public void RequestVoxelOperationRamp(BoundingBoxD box, Vector3D rampNormal, double rampNormalW, MatrixD Transformation, byte material, MyVoxelBase.OperationType Type)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_RequestVoxelOperationSphere_VRageMath_Vector3D_System_Single_System_Byte_Sandbox_Game_Entities_MyVoxelBase_OperationType_)RequestVoxelOperationSphere(Vector3D, Single, Byte, MyVoxelBase.OperationType)

##### Declaration

```
public void RequestVoxelOperationSphere(Vector3D center, float radius, byte material, MyVoxelBase.OperationType Type)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_RevertVoxelAccess_VRageMath_Vector3I_VRage_Voxels_MyStorageDataTypeFlags_)RevertVoxelAccess(Vector3I, MyStorageDataTypeFlags)

##### Declaration

```
[Event(null, 1137)]
[Reliable]
[ServerInvoked]
[BroadcastExcept]
public void RevertVoxelAccess(Vector3I key, MyStorageDataTypeFlags flags)
```

##### Parameters

#### [](#Sandbox_Game_Entities_MyVoxelBase_WorldPositionChanged_System_Object_)WorldPositionChanged(Object)

##### Declaration

```
protected void WorldPositionChanged(object source)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | source |     |

### [](#events)Events

#### [](#Sandbox_Game_Entities_MyVoxelBase_RangeChanged)RangeChanged

##### Declaration

```
public event MyVoxelBase.StorageChanged RangeChanged
```

##### Event Type

### [](#eii)Explicit Interface Implementations

#### [](#Sandbox_Game_Entities_MyVoxelBase_VRage_Game_ModAPI_Interfaces_IMyDecalProxy_AddDecals_VRage_Game_ModAPI_MyHitInfo__VRage_Utils_MyStringHash_VRageMath_Vector3_System_Object_VRage_Game_ModAPI_Interfaces_IMyDecalHandler_VRage_Utils_MyStringHash_VRage_Utils_MyStringHash_System_Boolean_VRageRender_MyDecalFlags_System_Int32_System_Collections_Generic_List_System_UInt32__)IMyDecalProxy.AddDecals(ref MyHitInfo, MyStringHash, Vector3, Object, IMyDecalHandler, MyStringHash, MyStringHash, Boolean, MyDecalFlags, Int32, List<UInt32>)

##### Declaration

```
void IMyDecalProxy.AddDecals(ref MyHitInfo hitInfo, MyStringHash source, Vector3 forwardDirection, object customdata, IMyDecalHandler decalHandler, MyStringHash physicalMaterial, MyStringHash voxelMaterial, bool isTrail, MyDecalFlags flags, int aliveUntil, List<uint> decals)
```
