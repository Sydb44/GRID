```
protected bool IsMainCockpitFree()
```

##### Returns

Type

Description

System.Boolean

#### IsShipToolSelected()

##### Declaration

```
public bool IsShipToolSelected()
```

##### Returns

Type

Description

System.Boolean

#### IsShooting()

##### Declaration

##### Returns

Type

Description

System.Boolean

#### IsShooting(MyShootActionEnum)

##### Declaration

```
protected bool IsShooting(MyShootActionEnum action)
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

#### IsTargetLockingEnabled()

##### Declaration

```
public bool IsTargetLockingEnabled()
```

##### Returns

Type

Description

System.Boolean

#### Jump(Vector3)

##### Declaration

```
public void Jump(Vector3 moveIndicator)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

moveIndicator

#### MoveAndRotate()

##### Declaration

```
public void MoveAndRotate()
```

#### MoveAndRotate(Vector3, Vector2, Single)

##### Declaration

```
public void MoveAndRotate(Vector3 moveIndicator, Vector2 rotationIndicator, float rollIndicator)
```

##### Parameters

Type

Name

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

moveIndicator

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

rotationIndicator

System.Single

rollIndicator

#### MoveAndRotateStopped()

##### Declaration

```
public void MoveAndRotateStopped()
```

#### OnAddedToScene(Object)

##### Declaration

```
public override void OnAddedToScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.OnAddedToScene(System.Object)

#### OnBeginShoot(MyShootActionEnum)

##### Declaration

```
public void OnBeginShoot(MyShootActionEnum action)
```

##### Parameters

Type

Name

Description

[MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html)

action

#### OnControlAcquired(MyEntityController)

##### Declaration

```
protected void OnControlAcquired(MyEntityController controller)
```

##### Parameters

Type

Name

Description

Sandbox.Game.World.MyEntityController

controller

#### OnControlAcquired\_UpdateCamera()

##### Declaration

```
protected virtual void OnControlAcquired_UpdateCamera()
```

#### OnControlledEntity\_Used()

##### Declaration

```
protected virtual void OnControlledEntity_Used()
```

#### OnControlReleased(MyEntityController)

##### Declaration

```
protected virtual void OnControlReleased(MyEntityController controller)
```

##### Parameters

Type

Name

Description

Sandbox.Game.World.MyEntityController

controller

#### OnControlReleased\_UpdateCamera()

##### Declaration

```
protected virtual void OnControlReleased_UpdateCamera()
```

#### OnEndShoot(MyShootActionEnum)

##### Declaration

```
public void OnEndShoot(MyShootActionEnum action)
```

##### Parameters

Type

Name

Description

[MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html)

action

#### OnRegisteredToGridSystems()

##### Declaration

```
public override void OnRegisteredToGridSystems()
```

##### Overrides

#### OnRemovedFromScene(Object)

##### Declaration

```
public override void OnRemovedFromScene(object source)
```

##### Parameters

Type

Name

Description

System.Object

source

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.OnRemovedFromScene(System.Object)

#### OnUnregisteredFromGridSystems()

##### Declaration

```
public override void OnUnregisteredFromGridSystems()
```

##### Overrides

#### PickUp()

##### Declaration

#### PickUpContinues()

##### Declaration

```
public void PickUpContinues()
```

#### PickUpFinished()

##### Declaration

```
public void PickUpFinished()
```

#### PlayUseSound(Boolean)

##### Declaration

```
public void PlayUseSound(bool getIn)
```

##### Parameters

Type

Name

Description

System.Boolean

getIn

#### RaiseControlledEntityUsed()

##### Declaration

```
public void RaiseControlledEntityUsed()
```

#### RefreshControlNotifications()

##### Declaration

```
public void RefreshControlNotifications()
```

#### RemoveControlNotifications()

##### Declaration

```
public void RemoveControlNotifications()
```

#### RemoveControlSystem(MyGroupControlSystem)

##### Declaration

```
public void RemoveControlSystem(MyGroupControlSystem controlSystem)
```

##### Parameters

Type

Name

Description

Sandbox.Game.GameSystems.MyGroupControlSystem

controlSystem

#### RemoveLocal()

##### Declaration

```
protected virtual void RemoveLocal()
```

#### RemoveUsers(Boolean)

##### Declaration

```
public void RemoveUsers(bool local)
```

##### Parameters

Type

Name

Description

System.Boolean

local

#### SetLockedTarget(IMyCharacter)

##### Declaration

```
public void SetLockedTarget(IMyCharacter target)
```

##### Parameters

Type

Name

Description

[IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html)

target

#### SetLockedTarget(IMyCubeGrid)

##### Declaration

```
public virtual void SetLockedTarget(IMyCubeGrid target)
```

##### Parameters

Type

Name

Description

[IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html)

target

#### SetNetState(MyGridClientState)

##### Declaration

```
public void SetNetState(MyGridClientState netState)
```

##### Parameters

Type

Name

Description

Sandbox.Game.Replication.ClientStates.MyGridClientState

netState

#### SetWeaponSystem(MyGridWeaponSystem)

##### Declaration

```
public void SetWeaponSystem(MyGridWeaponSystem weaponSystem)
```

##### Parameters

Type

Name

Description

Sandbox.Game.GameSystems.MyGridWeaponSystem

weaponSystem
