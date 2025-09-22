```

##### Parameters

Type

Name

Description

Sandbox.Game.GameSystems.MyGridWeaponSystem

weaponSystem

#### Shoot(MyShootActionEnum)

##### Declaration

```
public void Shoot(MyShootActionEnum action)
```

##### Parameters

Type

Name

Description

[MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html)

action

#### ShouldEndShootingOnPause(MyShootActionEnum)

##### Declaration

```
public bool ShouldEndShootingOnPause(MyShootActionEnum action)
```

##### Parameters

Type

Name

Description

[MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html)

action

##### Returns

Type

Description

System.Boolean

#### ShouldSit()

##### Declaration

```
protected virtual bool ShouldSit()
```

##### Returns

Type

Description

System.Boolean

#### ShowInventory()

##### Declaration

```
public virtual void ShowInventory()
```

#### ShowRemoteAccessMenu()

##### Declaration

```
public virtual void ShowRemoteAccessMenu()
```

#### ShowTerminal()

##### Declaration

```
public virtual void ShowTerminal()
```

#### Sprint(Boolean)

##### Declaration

```
public void Sprint(bool enabled)
```

##### Parameters

Type

Name

Description

System.Boolean

enabled

#### StartLoopSound()

##### Declaration

```
protected virtual void StartLoopSound()
```

#### StopLoopSound()

##### Declaration

```
protected virtual void StopLoopSound()
```

#### SwitchBroadcasting()

##### Declaration

```
public void SwitchBroadcasting()
```

#### SwitchDamping()

##### Declaration

```
public void SwitchDamping()
```

#### SwitchHandbrake()

##### Declaration

```
public void SwitchHandbrake()
```

#### SwitchLandingGears()

##### Declaration

```
public void SwitchLandingGears()
```

#### SwitchLights()

##### Declaration

```
public void SwitchLights()
```

#### SwitchParkedStatus()

##### Declaration

```
public void SwitchParkedStatus()
```

#### SwitchReactors()

##### Declaration

```
public void SwitchReactors()
```

#### SwitchReactorsLocal()

##### Declaration

```
public void SwitchReactorsLocal()
```

#### SwitchThrusts()

##### Declaration

```
public virtual void SwitchThrusts()
```

#### SwitchToWeapon(MyToolbarItemWeapon)

##### Declaration

```
public void SwitchToWeapon(MyToolbarItemWeapon weapon)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Screens.Helpers.MyToolbarItemWeapon

weapon

#### SwitchToWeapon(MyDefinitionId)

##### Declaration

```
public void SwitchToWeapon(MyDefinitionId weapon)
```

##### Parameters

Type

Name

Description

[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)

weapon

#### SwitchWalk()

##### Declaration

#### sync\_ControlledEntity\_Used()

##### Declaration

```
[Event(null, 2562)]
[Reliable]
[Server]
[Broadcast]
protected void sync_ControlledEntity_Used()
```

#### TryEnableBrakes(Boolean)

Tries to set the brakes. May fail if this is not the main cockpit.

##### Declaration

```
public bool TryEnableBrakes(bool enable)
```

##### Parameters

Type

Name

Description

System.Boolean

enable

Should the brakes be enabled, or not?

##### Returns

Type

Description

System.Boolean

True if the brakes were enabled, false otherwise.

#### Up()

##### Declaration

#### UpdateAfterSimulation()

##### Declaration

```
public override void UpdateAfterSimulation()
```

##### Overrides

#### UpdateAfterSimulation10()

##### Declaration

```
public override void UpdateAfterSimulation10()
```

##### Overrides

#### UpdateBeforeSimulation100()

##### Declaration

```
public override void UpdateBeforeSimulation100()
```

##### Overrides

#### UpdateCameraAfterChange(Boolean)

##### Declaration

```
protected virtual void UpdateCameraAfterChange(bool resetHeadLocalAngle = true)
```

##### Parameters

Type

Name

Description

System.Boolean

resetHeadLocalAngle

#### UpdateControls()

##### Declaration

```
public void UpdateControls()
```

#### UpdateSoundState()

##### Declaration

```
protected virtual void UpdateSoundState()
```

#### UpdateVisual()

##### Declaration

```
public override void UpdateVisual()
```

##### Overrides

#### UpdatingStopped()

##### Declaration

```
public override void UpdatingStopped()
```

##### Overrides

#### Use()

##### Declaration

#### UseContinues()

##### Declaration

```
public void UseContinues()
```

#### UseFinished()

##### Declaration

```
public void UseFinished()
```

#### WheelJump(Boolean)

##### Declaration

```
public void WheelJump(bool controlPressed)
```

##### Parameters

Type

Name

Description

System.Boolean

controlPressed

#### WheelJumpFromOtherBlock(Boolean)

##### Declaration

```
public void WheelJumpFromOtherBlock(bool controlPressed)
```

##### Parameters

Type

Name

Description

System.Boolean

controlPressed

#### Zoom(Boolean)

##### Declaration

```
public void Zoom(bool newKeyPress)
```

##### Parameters

Type

Name

Description

System.Boolean

newKeyPress

### Explicit Interface Implementations

#### IMyControllableEntity.CanSwitchAmmoMagazine()

##### Declaration

```
bool IMyControllableEntity.CanSwitchAmmoMagazine()
```

##### Returns

Type

Description

System.Boolean

#### IMyControllableEntity.EnabledBroadcasting

##### Declaration

```
bool IMyControllableEntity.EnabledBroadcasting { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyControllableEntity.SwitchAmmoMagazine()

##### Declaration

```
void IMyControllableEntity.SwitchAmmoMagazine()
```

#### IMyShipController.HasFirstPersonCamera

##### Declaration

```
bool IMyShipController.HasFirstPersonCamera { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.IsShooting

##### Declaration

```
bool IMyShipController.IsShooting { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.LastPilot

##### Declaration

```
IMyCharacter IMyShipController.LastPilot { get; }
```
