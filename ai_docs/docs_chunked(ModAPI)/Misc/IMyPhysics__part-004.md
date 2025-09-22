#### CreateModelPhysics(PhysicsSettings)

##### Declaration

```
void CreateModelPhysics(PhysicsSettings settings)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PhysicsSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.PhysicsSettings.html) | settings | Physical settings, created with [CreateSettingsForPhysics(IMyEntity, MatrixD, Vector3, Single, Single, UInt16, RigidBodyFlag, Boolean, Nullable<ModAPIMass>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForPhysics_VRage_ModAPI_IMyEntity_VRageMath_MatrixD_VRageMath_Vector3_System_Single_System_Single_System_UInt16_VRage_Game_Components_RigidBodyFlag_System_Boolean_System_Nullable_VRage_ModAPI_ModAPIMass__) or [CreateSettingsForDetector(IMyEntity, Action<IMyEntity, Boolean>, MatrixD, Vector3, RigidBodyFlag, UInt16, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForDetector_VRage_ModAPI_IMyEntity_System_Action_VRage_ModAPI_IMyEntity_System_Boolean__VRageMath_MatrixD_VRageMath_Vector3_VRage_Game_Components_RigidBodyFlag_System_UInt16_System_Boolean_) |

#### CreateSettingsForDetector(IMyEntity, Action<IMyEntity, Boolean>, MatrixD, Vector3, RigidBodyFlag, UInt16, Boolean)

Used to create physical detectors. They don't have physical collisions, instead they provide trigger callbacks when Entities collide with their shape

##### Declaration

```
PhysicsSettings CreateSettingsForDetector(IMyEntity entity, Action<IMyEntity, bool> detectorColliderCallback, MatrixD worldMatrix, Vector3 localCenter, RigidBodyFlag rigidBodyFlags, ushort collisionLayer = 15, bool isPhantom = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |
| System.Action<[IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html), System.Boolean\> | detectorColliderCallback |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | localCenter |     |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) | rigidBodyFlags |     |
| System.UInt16 | collisionLayer |     |
| System.Boolean | isPhantom |     |

##### Returns

| Type | Description |
| --- | --- |
| [PhysicsSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.PhysicsSettings.html) |     |

#### CreateSettingsForPhysics(IMyEntity, MatrixD, Vector3, Single, Single, UInt16, RigidBodyFlag, Boolean, Nullable<ModAPIMass>)

Used for create physics with collisions

##### Declaration

```
PhysicsSettings CreateSettingsForPhysics(IMyEntity entity, MatrixD worldMatrix, Vector3 localCenter, float linearDamping = 0F, float angularDamping = 0F, ushort collisionLayer = 15, RigidBodyFlag rigidBodyFlags, bool isPhantom = false, Nullable<ModAPIMass> mass = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity |     |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | worldMatrix |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | localCenter |     |
| System.Single | linearDamping |     |
| System.Single | angularDamping |     |
| System.UInt16 | collisionLayer |     |
| [RigidBodyFlag](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.RigidBodyFlag.html) | rigidBodyFlags |     |
| System.Boolean | isPhantom |     |
| System.Nullable<[ModAPIMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMass.html)\> | mass |     |

##### Returns

| Type | Description |
| --- | --- |
| [PhysicsSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.PhysicsSettings.html) |     |

#### CreateSpherePhysics(PhysicsSettings, Single)

##### Declaration

```
void CreateSpherePhysics(PhysicsSettings settings, float radius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PhysicsSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.PhysicsSettings.html) | settings | Physical settings, created with [CreateSettingsForPhysics(IMyEntity, MatrixD, Vector3, Single, Single, UInt16, RigidBodyFlag, Boolean, Nullable<ModAPIMass>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForPhysics_VRage_ModAPI_IMyEntity_VRageMath_MatrixD_VRageMath_Vector3_System_Single_System_Single_System_UInt16_VRage_Game_Components_RigidBodyFlag_System_Boolean_System_Nullable_VRage_ModAPI_ModAPIMass__) or [CreateSettingsForDetector(IMyEntity, Action<IMyEntity, Boolean>, MatrixD, Vector3, RigidBodyFlag, UInt16, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForDetector_VRage_ModAPI_IMyEntity_System_Action_VRage_ModAPI_IMyEntity_System_Boolean__VRageMath_MatrixD_VRageMath_Vector3_VRage_Game_Components_RigidBodyFlag_System_UInt16_System_Boolean_) |
| System.Single | radius | Radius of sphere |

#### EnsurePhysicsSpace(BoundingBoxD)

Ensure aabb is inside only one subspace. If no, reorder. Must not be called from parallel thread!!!

##### Declaration

```
void EnsurePhysicsSpace(BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb | World bounding box |
