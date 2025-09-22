#### IMyControllableEntity.OnBeginShoot(MyShootActionEnum)

##### Declaration

```
void IMyControllableEntity.OnBeginShoot(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

#### IMyControllableEntity.OnEndShoot(MyShootActionEnum)

##### Declaration

```
void IMyControllableEntity.OnEndShoot(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

#### IMyControllableEntity.PickUpFinished()

##### Declaration

```
void IMyControllableEntity.PickUpFinished()
```

#### IMyControllableEntity.RelativeDampeningEntity

##### Declaration

```
MyEntity IMyControllableEntity.RelativeDampeningEntity { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### IMyControllableEntity.ShouldEndShootingOnPause(MyShootActionEnum)

##### Declaration

```
bool IMyControllableEntity.ShouldEndShootingOnPause(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyControllableEntity.Sprint(Boolean)

##### Declaration

```
void IMyControllableEntity.Sprint(bool enabled)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | enabled |     |

#### IMyControllableEntity.SwitchAmmoMagazine()

##### Declaration

```
void IMyControllableEntity.SwitchAmmoMagazine()
```

#### IMyControllableEntity.SwitchBroadcasting()

##### Declaration

```
void IMyControllableEntity.SwitchBroadcasting()
```

#### IMyControllableEntity.SwitchToWeapon(MyToolbarItemWeapon)

##### Declaration

```
void IMyControllableEntity.SwitchToWeapon(MyToolbarItemWeapon weapon)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Game.Screens.Helpers.MyToolbarItemWeapon | weapon |     |

#### IMyControllableEntity.SwitchToWeapon(MyDefinitionId)

##### Declaration

```
void IMyControllableEntity.SwitchToWeapon(MyDefinitionId weaponDefinition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | weaponDefinition |     |

#### IMyControllableEntity.Toolbar

##### Declaration

```
MyToolbar IMyControllableEntity.Toolbar { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| Sandbox.Game.Screens.Helpers.MyToolbar |     |

#### IMyControllableEntity.ToolbarType

##### Declaration

```
MyToolbarType IMyControllableEntity.ToolbarType { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| [MyToolbarType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyToolbarType.html) |     |

#### IMyControllableEntity.UseFinished()

##### Declaration

```
void IMyControllableEntity.UseFinished()
```

#### IMyCameraController.AllowCubeBuilding

##### Declaration

```
bool IMyCameraController.AllowCubeBuilding { get; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.ControlCamera(MyCamera)

##### Declaration

```
void IMyCameraController.ControlCamera(MyCamera currentCamera)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Game.Utils.MyCamera | currentCamera |     |

#### IMyCameraController.EnableFirstPersonView

##### Declaration

```
bool IMyCameraController.EnableFirstPersonView { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.ForceFirstPersonCamera

##### Declaration

```
bool IMyCameraController.ForceFirstPersonCamera { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.HandlePickUp()

##### Declaration

```
bool IMyCameraController.HandlePickUp()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.HandleUse()

##### Declaration

```
bool IMyCameraController.HandleUse()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.IsInFirstPersonView

##### Declaration

```
bool IMyCameraController.IsInFirstPersonView { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IMyCameraController.OnAssumeControl(IMyCameraController)

##### Declaration

```
void IMyCameraController.OnAssumeControl(IMyCameraController previousCameraController)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | previousCameraController |     |

#### IMyCameraController.OnReleaseControl(IMyCameraController)

##### Declaration

```
void IMyCameraController.OnReleaseControl(IMyCameraController newCameraController)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | newCameraController |     |

#### IMyCameraController.Rotate(Vector2, Single)

##### Declaration

```
void IMyCameraController.Rotate(Vector2 rotationIndicator, float rollIndicator)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) | rotationIndicator |     |
| System.Single | rollIndicator |     |
