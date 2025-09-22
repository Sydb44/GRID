---
title: "Interface IMyControllableEntity"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyControllableEntity.html"
category: "Misc"
namespace: "VRage.Game.ModAPI.Interfaces"
class: "IMyControllableEntity"
---

# Interface IMyControllableEntity | Space Engineers ModAPI

Describes that player can take under control (mods interface)

###### **Namespace**: [VRage.Game.ModAPI.Interfaces](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyControllableEntity
```

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_CanSwitchLandingGears)CanSwitchLandingGears

Gets if entity can switch landing gears

##### Declaration

```
bool CanSwitchLandingGears { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_ControllerInfo)ControllerInfo

Gets information about who controls this Entity

##### Declaration

```
IMyControllerInfo ControllerInfo { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_EnabledDamping)EnabledDamping

Gets if Damping enabled

##### Declaration

```
bool EnabledDamping { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_EnabledHelmet)EnabledHelmet

Gets if helmet is opened

##### Declaration

```
bool EnabledHelmet { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_EnabledLeadingGears)EnabledLeadingGears

Gets if at least one leading gear is enabled

##### Declaration

```
bool EnabledLeadingGears { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_EnabledLights)EnabledLights

Gets if lights are enabled

##### Declaration

```
bool EnabledLights { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_EnabledReactors)EnabledReactors

Gets if grid is powered

##### Declaration

```
bool EnabledReactors { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_EnabledThrusts)EnabledThrusts

Gets if thrusts are enabled

##### Declaration

```
bool EnabledThrusts { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_Entity)Entity

Gets information which entity is being controlled

##### Declaration

```
IMyEntity Entity { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_ForceFirstPersonCamera)ForceFirstPersonCamera

Gets or sets if camera should be first person

##### Declaration

```
bool ForceFirstPersonCamera { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_IsAutopilotControlled)IsAutopilotControlled

Gets whether the entity is controller by autopilot

##### Declaration

```
bool IsAutopilotControlled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_LastMotionIndicator)LastMotionIndicator

Gets last motion indicator. User input W/A/S/D Space/C

##### Declaration

```
Vector3 LastMotionIndicator { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_LastRotationIndicator)LastRotationIndicator

Gets last rotation indicator. Z used for RollIndicator

##### Declaration

```
Vector3 LastRotationIndicator { get; }
```

##### Property Value

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_PrimaryLookaround)PrimaryLookaround

When false, blocks 3rd view look around

##### Declaration

```
bool PrimaryLookaround { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_RelativeDampeningDistance)RelativeDampeningDistance

Allows you to set a custom max distance which relative dampening to another entity will remain active.

##### Declaration

```
float RelativeDampeningDistance { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_RelativeDampeningTarget)RelativeDampeningTarget

Allows you to get or set the relative dampening entity.

##### Declaration

```
IMyEntity RelativeDampeningTarget { get; set; }
```

##### Property Value

### [](#methods)Methods

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_Crouch)Crouch()

Only [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) has implementation for this method.

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_Die)Die()

Makes character dead.

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_Down)Down()

Move direction : down. Only [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) has implementation for this method.

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_DrawHud_VRage_Game_ModAPI_Interfaces_IMyCameraController_System_Int64_)DrawHud(IMyCameraController, Int64)

Updates hud logic, connected to entity

##### Declaration

```
void DrawHud(IMyCameraController camera, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | camera | Current camera |
| System.Int64 | playerId | IdentityId |
