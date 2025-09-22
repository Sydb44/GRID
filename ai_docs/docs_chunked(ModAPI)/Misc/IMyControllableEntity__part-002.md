
##### Declaration

```
void DrawHud(IMyCameraController camera, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | camera | Current camera |
| System.Int64 | playerId | IdentityId |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_GetHeadMatrix_System_Boolean_System_Boolean_System_Boolean_System_Boolean_)GetHeadMatrix(Boolean, Boolean, Boolean, Boolean)

Gets head of character that controls this

##### Declaration

```
MatrixD GetHeadMatrix(bool includeY, bool includeX = true, bool forceHeadAnim = false, bool forceHeadBone = false)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | includeY | Should include Y axis rotation |
| System.Boolean | includeX | Should include X axis rotation |
| System.Boolean | forceHeadAnim | When true - use very accurate head position |
| System.Boolean | forceHeadBone |     |

##### Returns

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_Jump_VRageMath_Vector3_)Jump(Vector3)

Character jump. Only [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) has implementation for this method.

##### Declaration

```
void Jump(Vector3 moveindicator = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | moveindicator |     |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_MoveAndRotate_VRageMath_Vector3_VRageMath_Vector2_System_Single_)MoveAndRotate(Vector3, Vector2, Single)

##### Declaration

```
void MoveAndRotate(Vector3 moveIndicator, Vector2 rotationIndicator, float rollIndicator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | moveIndicator | User input W/A/S/D Space/C |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | rotationIndicator | User mouse input |
| System.Single | rollIndicator | User input Q/E |

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_MoveAndRotateStopped)MoveAndRotateStopped()

Should be called when input is finished

##### Declaration

```
void MoveAndRotateStopped()
```

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_PickUp)PickUp()

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_PickUpContinues)PickUpContinues()

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_ShowInventory)ShowInventory()

Shows inventory gui of controlled Entity

##### Declaration

Shows remote access menu

##### Declaration

```
void ShowRemoteAccessMenu()
```

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_ShowTerminal)ShowTerminal()

Shows terminal gui

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_SwitchDamping)SwitchDamping()

Switches damping state

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_SwitchHandbrake)SwitchHandbrake()

Switches handbrake state

##### Declaration

##### Remarks

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_SwitchHelmet)SwitchHelmet()

Switches helmet open/closed state

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_SwitchLandingGears)SwitchLandingGears()

Switches landing gears state

##### Declaration

```
void SwitchLandingGears()
```

##### Remarks

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_SwitchLights)SwitchLights()

Switches lights state

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_SwitchReactors)SwitchReactors()

Switches reactors state

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_SwitchReactorsLocal)SwitchReactorsLocal()

Switches handbrake state

##### Declaration

```
void SwitchReactorsLocal()
```

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_SwitchThrusts)SwitchThrusts()

Turns on jetpack on character

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_SwitchWalk)SwitchWalk()

Switch between walk / run mode. Only [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) has implementation for this method.

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_Up)Up()

Move direction : up. Only [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) has implementation for this method.

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_Use)Use()

##### Declaration

#### [](#VRage_Game_ModAPI_Interfaces_IMyControllableEntity_UseContinues)UseContinues()

##### Declaration