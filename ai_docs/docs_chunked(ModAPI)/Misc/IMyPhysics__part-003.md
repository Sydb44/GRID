
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

#### CreateMassCombined(ICollection<ModAPIMassElement>)

Calculates mass combined from other several masses

##### Declaration

```
ModAPIMass CreateMassCombined(ICollection<ModAPIMassElement> massElements)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.ICollection<[ModAPIMassElement](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMassElement.html)\> | massElements | Other masses |

##### Returns

| Type | Description |
| --- | --- |
| [ModAPIMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMass.html) | Combined mass |

#### CreateMassForBox(Vector3, Single)

Creates mass for cube

##### Declaration

```
ModAPIMass CreateMassForBox(Vector3 halfExtents, float mass)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | halfExtents | Cube halfExtents |
| System.Single | mass | Mass in kg |

##### Returns

| Type | Description |
| --- | --- |
| [ModAPIMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMass.html) | Calculated mass properties |

#### CreateMassForCapsule(Vector3, Vector3, Single, Single)

Creates mass for capsule

##### Declaration

```
ModAPIMass CreateMassForCapsule(Vector3 startAxis, Vector3 endAxis, float radius, float mass)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | startAxis | Local coordinates of capsule's first vertex |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | endAxis | Local coordinates of capsule's second vertex |
| System.Single | radius | Radius of capsule in meters |
| System.Single | mass | Mass in kg |

##### Returns

| Type | Description |
| --- | --- |
| [ModAPIMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMass.html) | Calculated mass properties |

#### CreateMassForCylinder(Vector3, Vector3, Single, Single)

Creates mass for cylinder

##### Declaration

```
ModAPIMass CreateMassForCylinder(Vector3 startAxis, Vector3 endAxis, float radius, float mass)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | startAxis | Local coordinates of cylinder's first vertex |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | endAxis | Local coordinates of cylinder's second vertex |
| System.Single | radius | Radius of cylinder in meters |
| System.Single | mass | Mass in kg |

##### Returns

| Type | Description |
| --- | --- |
| [ModAPIMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMass.html) | Calculated mass properties |

#### CreateMassForSphere(Single, Single)

Creates mass for sphere

##### Declaration

```
ModAPIMass CreateMassForSphere(float radius, float mass)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | radius | Radius of sphere in meters |
| System.Single | mass | Mass in kg |

##### Returns

| Type | Description |
| --- | --- |
| [ModAPIMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMass.html) | Calculated mass properties |

#### CreateModelPhysics(PhysicsSettings)

##### Declaration

```
void CreateModelPhysics(PhysicsSettings settings)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [PhysicsSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.PhysicsSettings.html) | settings | Physical settings, created with [CreateSettingsForPhysics(IMyEntity, MatrixD, Vector3, Single, Single, UInt16, RigidBodyFlag, Boolean, Nullable<ModAPIMass>)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForPhysics_VRage_ModAPI_IMyEntity_VRageMath_MatrixD_VRageMath_Vector3_System_Single_System_Single_System_UInt16_VRage_Game_Components_RigidBodyFlag_System_Boolean_System_Nullable_VRage_ModAPI_ModAPIMass__) or [CreateSettingsForDetector(IMyEntity, Action<IMyEntity, Boolean>, MatrixD, Vector3, RigidBodyFlag, UInt16, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyPhysics.html#VRage_Game_ModAPI_IMyPhysics_CreateSettingsForDetector_VRage_ModAPI_IMyEntity_System_Action_VRage_ModAPI_IMyEntity_System_Boolean__VRageMath_MatrixD_VRageMath_Vector3_VRage_Game_Components_RigidBodyFlag_System_UInt16_System_Boolean_) |
