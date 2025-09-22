Type

Description

System.Boolean

#### IMyShipController.LastPilot

##### Declaration

```
IMyCharacter IMyShipController.LastPilot { get; }
```

##### Returns

Type

Description

[IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html)

#### IMyShipController.Pilot

##### Declaration

```
IMyCharacter IMyShipController.Pilot { get; }
```

##### Returns

Type

Description

[IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html)

#### IMyShipController.CanControlShip

##### Declaration

```
bool IMyShipController.CanControlShip { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.CenterOfMass

##### Declaration

```
Vector3D IMyShipController.CenterOfMass { get; }
```

##### Returns

Type

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

#### IMyShipController.ControlThrusters

##### Declaration

```
bool IMyShipController.ControlThrusters { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.ControlWheels

##### Declaration

```
bool IMyShipController.ControlWheels { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.DampenersOverride

##### Declaration

```
bool IMyShipController.DampenersOverride { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.GetShipSpeed()

##### Declaration

```
double IMyShipController.GetShipSpeed()
```

##### Returns

Type

Description

System.Double

#### IMyShipController.GetShipVelocities()

##### Declaration

```
MyShipVelocities IMyShipController.GetShipVelocities()
```

##### Returns

Type

Description

[MyShipVelocities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipVelocities.html)

#### IMyShipController.HandBrake

##### Declaration

```
bool IMyShipController.HandBrake { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.HasWheels

##### Declaration

```
bool IMyShipController.HasWheels { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.IsMainCockpit

##### Declaration

```
bool IMyShipController.IsMainCockpit { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.IsUnderControl

##### Declaration

```
bool IMyShipController.IsUnderControl { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.MoveIndicator

##### Declaration

```
Vector3 IMyShipController.MoveIndicator { get; }
```

##### Returns

Type

Description

[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)

#### IMyShipController.RollIndicator

##### Declaration

```
float IMyShipController.RollIndicator { get; }
```

##### Returns

Type

Description

System.Single

#### IMyShipController.RotationIndicator

##### Declaration

```
Vector2 IMyShipController.RotationIndicator { get; }
```

##### Returns

Type

Description

[Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html)

#### IMyShipController.ShowHorizonIndicator

##### Declaration

```
bool IMyShipController.ShowHorizonIndicator { get; set; }
```

##### Returns

Type

Description

System.Boolean

#### IMyShipController.TryGetPlanetElevation(MyPlanetElevation, out Double)

##### Declaration

```
bool IMyShipController.TryGetPlanetElevation(MyPlanetElevation detail, out double elevation)
```

##### Parameters

Type

Name

Description

[MyPlanetElevation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyPlanetElevation.html)

detail

System.Double

elevation

##### Returns

Type

Description

System.Boolean

#### IMyShipController.TryGetPlanetPosition(out Vector3D)

##### Declaration

```
bool IMyShipController.TryGetPlanetPosition(out Vector3D position)
```

##### Parameters

Type

Name

Description

[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)

position

##### Returns

Type

Description

System.Boolean

#### IMyControllableEntity.ControllerInfo

##### Declaration

```
IMyControllerInfo IMyControllableEntity.ControllerInfo { get; }
```

##### Returns

Type

Description

[IMyControllerInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyControllerInfo.html)

#### IMyControllableEntity.Crouch()

##### Declaration

```
void IMyControllableEntity.Crouch()
```

#### IMyControllableEntity.Die()

##### Declaration

```
void IMyControllableEntity.Die()
```

#### IMyControllableEntity.Down()

##### Declaration

```
void IMyControllableEntity.Down()
```

#### IMyControllableEntity.DrawHud(IMyCameraController, Int64)

##### Declaration

```
void IMyControllableEntity.DrawHud(IMyCameraController camera, long playerId)
```

##### Parameters

Type

Name

Description

[IMyCameraController](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.Interfaces.IMyCameraController.html)

camera

System.Int64

playerId

#### IMyControllableEntity.EnabledDamping

##### Declaration

```
bool IMyControllableEntity.EnabledDamping { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyControllableEntity.EnabledHelmet

##### Declaration

```
bool IMyControllableEntity.EnabledHelmet { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyControllableEntity.EnabledLeadingGears

##### Declaration

```
bool IMyControllableEntity.EnabledLeadingGears { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyControllableEntity.EnabledLights

##### Declaration

```
bool IMyControllableEntity.EnabledLights { get; }
```

##### Returns

Type

Description

System.Boolean

#### IMyControllableEntity.EnabledReactors

##### Declaration

```
bool IMyControllableEntity.EnabledReactors { get; }
```

##### Returns

Type

Description

System.Boolean
