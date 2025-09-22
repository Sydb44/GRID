Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

##### Overrides

#### MaxShootRange

##### Declaration

```
public float MaxShootRange { get; }
```

##### Property Value

Type

Description

System.Single

#### NeedsPerFrameUpdate

##### Declaration

```
public bool NeedsPerFrameUpdate { get; }
```

##### Property Value

Type

Description

System.Boolean

#### OnLockedToolbar

##### Declaration

```
public MyToolbar OnLockedToolbar { get; }
```

##### Property Value

Type

Description

Sandbox.Game.Screens.Helpers.MyToolbar

#### Pilot

##### Declaration

```
public virtual MyCharacter Pilot { get; }
```

##### Property Value

Type

Description

Sandbox.Game.Entities.Character.MyCharacter

#### PlayDefaultUseSound

##### Declaration

```
public bool PlayDefaultUseSound { get; }
```

##### Property Value

Type

Description

System.Boolean

#### PreviousControlledEntity

##### Declaration

```
public virtual IMyControllableEntity PreviousControlledEntity { get; protected set; }
```

##### Property Value

Type

Description

[IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html)

#### PreviousController

##### Declaration

```
public IMyControllableEntity PreviousController { get; }
```

##### Property Value

Type

Description

[IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html)

#### PrimaryLookaround

##### Declaration

```
public bool PrimaryLookaround { get; }
```

##### Property Value

Type

Description

System.Boolean

#### Priority

##### Declaration

```
public virtual ControllerPriority Priority { get; }
```

##### Property Value

Type

Description

[ControllerPriority](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.ControllerPriority.html)

#### RaycasterHitBlock

##### Declaration

```
public MySlimBlock RaycasterHitBlock { get; }
```

##### Property Value

Type

Description

Sandbox.Game.Entities.Cube.MySlimBlock

#### RelativeDampeningDistance

##### Declaration

```
public float RelativeDampeningDistance { get; set; }
```

##### Property Value

Type

Description

System.Single

#### RelativeDampeningEntity

##### Declaration

```
public MyEntity RelativeDampeningEntity { get; set; }
```

##### Property Value

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

#### ShootOrigin

##### Declaration

```
public Vector3D ShootOrigin { get; }
```

##### Property Value

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### SingleWeaponMode

##### Declaration

```
public bool SingleWeaponMode { get; set; }
```

##### Property Value

Type

Description

System.Boolean

#### Toolbar

##### Declaration

```
public MyToolbar Toolbar { get; }
```

##### Property Value

Type

Description

Sandbox.Game.Screens.Helpers.MyToolbar

#### ToolbarType

##### Declaration

```
public virtual MyToolbarType ToolbarType { get; }
```

##### Property Value

Type

Description

[MyToolbarType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyToolbarType.html)

#### TopGrid

##### Declaration

```
public MyEntity TopGrid { get; }
```

##### Property Value

Type

Description

[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)

### Methods

#### AddControlSystem(MyGroupControlSystem)

##### Declaration

```
public void AddControlSystem(MyGroupControlSystem controlSystem)
```

##### Parameters

Type

Name

Description

Sandbox.Game.GameSystems.MyGroupControlSystem

controlSystem

#### BeginShoot(MyShootActionEnum)

##### Declaration

```
public void BeginShoot(MyShootActionEnum action)
```

##### Parameters

Type

Name

Description

[MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html)

action

#### BeginShootSync(MyShootActionEnum)

##### Declaration

```
public void BeginShootSync(MyShootActionEnum action)
```

##### Parameters

Type

Name

Description

[MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html)

action

#### CalculateShipMass()

##### Declaration

```
public MyShipMass CalculateShipMass()
```

##### Returns

Type

Description

[MyShipMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipMass.html)

#### CanActiveToolShoot()

##### Declaration

```
public bool CanActiveToolShoot()
```

##### Returns

Type

Description

System.Boolean

#### CanBeMainCockpit()

##### Declaration

```
protected virtual bool CanBeMainCockpit()
```

##### Returns

Type

Description

System.Boolean

#### CanHaveHorizon()

##### Declaration

```
protected virtual bool CanHaveHorizon()
```

##### Returns

Type

Description

System.Boolean

#### CanSwitchToWeapon(Nullable<MyDefinitionId>)

##### Declaration

```
public bool CanSwitchToWeapon(Nullable<MyDefinitionId> weapon)
```

##### Parameters

Type

Name

Description

System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\>

weapon

##### Returns

Type

Description

System.Boolean

#### ClearMovementControl()

##### Declaration

```
public void ClearMovementControl()
```

#### Closing()

##### Declaration

```
protected override void Closing()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.Closing()

#### ComponentStack\_IsFunctionalChanged()

##### Declaration

```
protected virtual void ComponentStack_IsFunctionalChanged()
```

#### CreateTerminalControls()

##### Declaration

```
protected override void CreateTerminalControls()
```

##### Overrides

Sandbox.Game.Entities.Cube.MyTerminalBlock.CreateTerminalControls()

#### Crouch()

##### Declaration
