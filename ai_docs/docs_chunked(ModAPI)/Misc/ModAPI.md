---
title: "Namespace VRage.ModAPI"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.html"
category: "Misc"
namespace: "VRage"
class: "ModAPI"
---

# Namespace VRage.ModAPI | Space Engineers ModAPI

### Classes

#### [EntityFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.EntityFlags.html)

Entity flags.

#### [ModAPIMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMass.html)

ModAPI struct, that is available for modders. Copy of Havok.HkMassProperties. Created with IMyPhysics.CreateMassCombined, IMyPhysics.CreateMassForBox, IMyPhysics.CreateMassForCapsule, IMyPhysics.CreateMassForCylinder, IMyPhysics.CreateMassForSphere.

#### [ModAPIMassElement](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.ModAPIMassElement.html)

ModAPI struct, that is available for modders. Copy of Havok.HkMassElement.

#### [MyAPIGatewayShortcuts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.html)

Links to modapi actions. Delegates are set inside MyAPIGateway. VRAGE TODO: This is probably a temporary class helping us to remove sandbox.

#### [MyAPIGatewayShortcuts.GetLocalPlayerPositionCallback](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.GetLocalPlayerPositionCallback.html)

#### [MyAPIGatewayShortcuts.GetMainCameraCallback](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.GetMainCameraCallback.html)

#### [MyAPIGatewayShortcuts.GetWorldBoundariesCallback](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyAPIGatewayShortcuts.GetWorldBoundariesCallback.html)

#### [MyEntityUpdateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyEntityUpdateEnum.html)

#### [MyTerminalControlComboBoxItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyTerminalControlComboBoxItem.html)

Implements Combo Box Item pair

#### [MyTerminalControlListBoxItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.MyTerminalControlListBoxItem.html)

This is a list box item in a list box terminal control

#### [PhysicsSettings](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.PhysicsSettings.html)

Implements Physics Settings

#### [VoxelOperatorFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.VoxelOperatorFlags.html)

### Interfaces

#### [IMyCamera](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyCamera.html)

Describes camera (mods interface)

#### [IMyEntities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntities.html)

Provides API, that granting access to enitities (mods interface)

#### [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html)

#### [IMyGridConveyorSystem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyGridConveyorSystem.html)

ModAPI interface giving access to grid-group conveyor system

#### [IMyHudStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyHudStat.html)

#### [IMyRemapHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyRemapHelper.html)

ModAPI interface giving access to changing id and names of entities

#### [IMyStorage](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html)

ModAPI interface giving access to voxel functions

#### [IMyVoxelBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyVoxelBase.html)

Describes

#### [IVoxelOperator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IVoxelOperator.html)

Interface, that is used in [ExecuteOperationFast<TVoxelOperator>(ref TVoxelOperator, MyStorageDataTypeFlags, ref Vector3I, ref Vector3I, Boolean)](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyStorage.html#VRage_ModAPI_IMyStorage_ExecuteOperationFast__1___0__VRage_Voxels_MyStorageDataTypeFlags_VRageMath_Vector3I__VRageMath_Vector3I__System_Boolean_)