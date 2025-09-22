---
title: "Interface IMyCameraController"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Interfaces"
class: "IMyCameraController"
---

# Interface IMyCameraController | Space Engineers ModAPI

Interface to control game camera (not block) (mods interface)

###### **Namespace**: [VRage.Game.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyCameraController
```

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_AllowCubeBuilding)AllowCubeBuilding

Gets if player block building enabled

##### Declaration

```
bool AllowCubeBuilding { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_EnableFirstPersonView)EnableFirstPersonView

Gets or set if player can use first person view

##### Declaration

```
bool EnableFirstPersonView { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_Entity)Entity

Gets Entity to which it is attached

##### Declaration

##### Property Value

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_ForceFirstPersonCamera)ForceFirstPersonCamera

Gets or sets if player can use only first person view

##### Declaration

```
bool ForceFirstPersonCamera { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_IsInFirstPersonView)IsInFirstPersonView

Gets or sets if the current camera view is first person.

##### Declaration

```
bool IsInFirstPersonView { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_ControlCamera_VRage_Game_Utils_MyCamera_)ControlCamera(MyCamera)

Change camera properties now. Communication: from controller to camera.

##### Declaration

```
void ControlCamera(MyCamera currentCamera)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Utils.MyCamera | currentCamera |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_GetOverridingFocusMatrix)GetOverridingFocusMatrix()

Transformation that should be used for target selection while focusing

##### Declaration

```
Nullable<MatrixD> GetOverridingFocusMatrix()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html)\> |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_HandlePickUp)HandlePickUp()

Does nothing.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Always returns false |

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_HandleUse)HandleUse()

Used to send "use" commands to camera controller

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Return value indicates if the camera controller handled the use button. If not, it should fall to ControlledObject |

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_OnAssumeControl_VRage_Game_ModAPI_Interfaces_IMyCameraController_)OnAssumeControl(IMyCameraController)

Called when it is setted as new main camera controller

##### Declaration

```
void OnAssumeControl(IMyCameraController previousCameraController)
```

##### Parameters

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_OnReleaseControl_VRage_Game_ModAPI_Interfaces_IMyCameraController_)OnReleaseControl(IMyCameraController)

Called when new camera controller setted, and this was main camera controller

##### Declaration

```
void OnReleaseControl(IMyCameraController newCameraController)
```

##### Parameters

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_Rotate_VRageMath_Vector2_System_Single_)Rotate(Vector2, Single)

Rotate camera controller.

##### Declaration

```
void Rotate(Vector2 rotationIndicator, float rollIndicator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | rotationIndicator |     |
| System.Single | rollIndicator |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyCameraController_RotateStopped)RotateStopped()

Rotation of camera controller stopped.

##### Declaration