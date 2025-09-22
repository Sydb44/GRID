---
title: "Interface IMyParachute"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyParachute.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyParachute"
---

# Interface IMyParachute | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMyParachute : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### [](#properties)Properties

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_Atmosphere)Atmosphere

Atmospheric Density at the block. Returns 0.0f if not near a planet.

##### Declaration

```
float Atmosphere { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_AutoDeploy)AutoDeploy

Gets or sets if the parachute should automatically deploy.

##### Declaration

```
bool AutoDeploy { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_AutoDeployHeight)AutoDeployHeight

Gets or sets the altitude (in meters) that the parachute should auto deploy.

##### Declaration

```
float AutoDeployHeight { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_OpenRatio)OpenRatio

The current, accurate ratio of the door's current state where 0 is fully closed and 1 is fully open.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_Status)Status

Determines the current general status of the door.

##### Declaration

```
DoorStatus Status { get; }
```

##### Property Value

### [](#methods)Methods

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_CloseDoor)CloseDoor()

Closes the door. See [Status](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyParachute.html#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_Status) to get the current status.

##### Declaration

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_GetArtificialGravity)GetArtificialGravity()

Gets the detected artificial gravity vector and power at the current location.

##### Declaration

```
Vector3D GetArtificialGravity()
```

##### Returns

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_GetNaturalGravity)GetNaturalGravity()

Gets the detected natural gravity vector and power at the current location.

##### Declaration

```
Vector3D GetNaturalGravity()
```

##### Returns

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_GetTotalGravity)GetTotalGravity()

Gets the total accumulated gravity vector and power at the current location, taking both natural and artificial gravity into account.

##### Declaration

```
Vector3D GetTotalGravity()
```

##### Returns

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_GetVelocity)GetVelocity()

Determines the linear velocities in meters per second at the block position

##### Declaration

##### Returns

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_OpenDoor)OpenDoor()

Opens the door. See [Status](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyParachute.html#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_Status) to get the current status.

##### Declaration

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_ToggleDoor)ToggleDoor()

Toggles the open state of this door. See [Status](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyParachute.html#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_Status) to get the current status.

##### Declaration

#### [](#SpaceEngineers_Game_ModAPI_Ingame_IMyParachute_TryGetClosestPoint_System_Nullable_VRageMath_Vector3D___)TryGetClosestPoint(out Nullable<Vector3D>)

##### Declaration

```
bool TryGetClosestPoint(out Nullable<Vector3D> closestPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | closestPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#extensionmethods)Extension Methods