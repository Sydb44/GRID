##### Declaration

```
bool CanShoot(MyShootActionEnum action, long shooter, out MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action | The shooting action to test |
| System.Int64 | shooter | Id of shooting player |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status | Detailed status of the gun, telling why the gun couldn't perform the given shoot action |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DirectionToTarget(Vector3D)

Gets direction vector (normalized) between device and provided target vector. Used for character devices

##### Declaration

```
Vector3 DirectionToTarget(Vector3D target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | target | Target vector in world coordinates |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Normalized direction between device position and provided vector |

#### DrawHud(IMyCameraController, Int64)

When device is selected, this method is called in Draw thread. Example: welder shows info about what block it welds.

##### Declaration

```
void DrawHud(IMyCameraController camera, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | camera | Current camera |
| System.Int64 | playerId | Player that controls device |

#### DrawHud(IMyCameraController, Int64, Boolean)

When device is selected, this method is called in Draw thread.

##### Declaration

```
void DrawHud(IMyCameraController camera, long playerId, bool fullUpdate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html) | camera | Current camera |
| System.Int64 | playerId | Player that controls device |
| System.Boolean | fullUpdate | True when should update internal cache |

#### EndShoot(MyShootActionEnum)

Called when device stop shooting

##### Declaration

```
void EndShoot(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action | Type if shooting |

#### GetAmmunitionAmount()

Gets current ammunition left before reloading

##### Declaration

```
int GetAmmunitionAmount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Ammunition amount |

#### GetMagazineAmount()

Gets magazines amount

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Magazines amount |

#### GetMuzzlePosition()

Gets muzzle world position

##### Declaration

```
Vector3D GetMuzzlePosition()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | Position of muzzle in world coordinates |

#### GetShootDirection()

Direction where gun is shooting

##### Declaration

```
Vector3 GetShootDirection()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GetTotalAmmunitionAmount()

##### Declaration

```
int GetTotalAmmunitionAmount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | Total ammunition amount |

#### IsToolbarUsable()

Returns true if can be used with LMB/RMB like drills

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if can be used with LMB/RMB like drills |

#### OnControlAcquired(IMyCharacter)

Called when control over device acquired

##### Declaration

```
void OnControlAcquired(IMyCharacter owner)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) | owner | Controlling character |

#### OnControlReleased()

Called when control over device lost

##### Declaration

#### Shoot(MyShootActionEnum, Vector3, Nullable<Vector3D>, String)

Perform the shoot action according to the action parameter. This method should only be called when CanShoot returns true for the given action!

##### Declaration

```
void Shoot(MyShootActionEnum action, Vector3 direction, Nullable<Vector3D> overrideWeaponPos, string gunAction = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action | The shooting action to perform |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | direction | The prefered direction of shooting |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | overrideWeaponPos | Changes weapon position, world space. |
| System.String | gunAction | Always null |

#### ShootFailReactionLocal(MyShootActionEnum, MyGunStatusEnum)

Perform a fail reaction to during shooting that is shown only on client that controls character or ship, that has this device

##### Declaration

```
void ShootFailReactionLocal(MyShootActionEnum action, MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action | The shooting action, whose shooting failed |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status | Why the shooting failed |
