
| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | Start of ray. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  | End of ray. |
| [IHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IHitInfo.html) | hitInfo | Hit info |
| System.Int32 | raycastFilterLayer | Collision layer |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if hit; false if no hit |

#### CastRay(Vector3D, Vector3D, out IHitInfo, UInt32, Boolean)

Cast a ray and return first entity. Must not be called from parallel thread!!!

##### Declaration

```
bool CastRay(Vector3D from, Vector3D to, out IHitInfo hitInfo, uint raycastCollisionFilter, bool ignoreConvexShape)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | Start of ray. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  | End of ray. |
| [IHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IHitInfo.html) | hitInfo | Hit info |
| System.UInt32 | raycastCollisionFilter | Collision layer |
| System.Boolean | ignoreConvexShape | Convex radius - allowed to penetrate space, around collision model |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if hit; false if no hit |

#### CastRayParallel(ref Vector3D, ref Vector3D, List<IHitInfo>, Int32, Action<List<IHitInfo>>)

Cast a ray and returns all matching entities. May be called from parallel thread.

##### Declaration

```
void CastRayParallel(ref Vector3D from, ref Vector3D to, List<IHitInfo> toList, int raycastCollisionFilter, Action<List<IHitInfo>> callback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | Start of ray. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  | End of ray. |
| System.Collections.Generic.List<[IHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IHitInfo.html)\> | toList | List of hits |
| System.Int32 | raycastCollisionFilter | Collision layer |
| System.Action<System.Collections.Generic.List<[IHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IHitInfo.html)\>> | callback | Callback were results are returned to when query is done |

#### CastRayParallel(ref Vector3D, ref Vector3D, Int32, Action<IHitInfo>)

Cast a ray and return first entity. May be called from parallel thread.

##### Declaration

```
void CastRayParallel(ref Vector3D from, ref Vector3D to, int raycastCollisionFilter, Action<IHitInfo> callback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from | Start of ray. |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  | End of ray. |
| System.Int32 | raycastCollisionFilter | Collision layer |
| System.Action<[IHitInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IHitInfo.html)\> | callback | Callback were results are returned to when query is done |

#### CreateBoxPhysics(PhysicsSettings, Vector3, Single)

##### Declaration

```
void CreateBoxPhysics(PhysicsSettings settings, Vector3 halfExtends, float convexRadius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PhysicsSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.PhysicsSettings.html) | settings | Physical settings, created with [CreateSettingsForPhysics(IMyEntity, MatrixD, Vector3, Single, Single, UInt16, RigidBodyFlag, Boolean, Nullable<ModAPIMass>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForPhysics_VRage_ModAPI_IMyEntity_VRageMath_MatrixD_VRageMath_Vector3_System_Single_System_Single_System_UInt16_VRage_Game_Components_RigidBodyFlag_System_Boolean_System_Nullable_VRage_ModAPI_ModAPIMass__) or [CreateSettingsForDetector(IMyEntity, Action<IMyEntity, Boolean>, MatrixD, Vector3, RigidBodyFlag, UInt16, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForDetector_VRage_ModAPI_IMyEntity_System_Action_VRage_ModAPI_IMyEntity_System_Boolean__VRageMath_MatrixD_VRageMath_Vector3_VRage_Game_Components_RigidBodyFlag_System_UInt16_System_Boolean_) |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | halfExtends | Half extends of box |
| System.Single | convexRadius | Convex radius in meters |

#### CreateCapsulePhysics(PhysicsSettings, Vector3, Vector3, Single)

##### Declaration

```
void CreateCapsulePhysics(PhysicsSettings settings, Vector3 vertexA, Vector3 vertexB, float radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PhysicsSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.PhysicsSettings.html) | settings | Physical settings, created with [CreateSettingsForPhysics(IMyEntity, MatrixD, Vector3, Single, Single, UInt16, RigidBodyFlag, Boolean, Nullable<ModAPIMass>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForPhysics_VRage_ModAPI_IMyEntity_VRageMath_MatrixD_VRageMath_Vector3_System_Single_System_Single_System_UInt16_VRage_Game_Components_RigidBodyFlag_System_Boolean_System_Nullable_VRage_ModAPI_ModAPIMass__) or [CreateSettingsForDetector(IMyEntity, Action<IMyEntity, Boolean>, MatrixD, Vector3, RigidBodyFlag, UInt16, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForDetector_VRage_ModAPI_IMyEntity_System_Action_VRage_ModAPI_IMyEntity_System_Boolean__VRageMath_MatrixD_VRageMath_Vector3_VRage_Game_Components_RigidBodyFlag_System_UInt16_System_Boolean_) |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vertexA | Local coordinates of capsule's first vertex |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | vertexB | Local coordinates of capsule's second vertex |
| System.Single | radius | Radius of capsule in meters |
