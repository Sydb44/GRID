---
title: "Interface IMyTurretControlBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyTurretControlBlock.html"
category: "Weapons"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyTurretControlBlock"
---

# Interface IMyTurretControlBlock | Space Engineers ModAPI

Describes Turret Control block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTurretControlBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AIEnabled

Gets whether this block has AI enabled for turret

##### Declaration

```
bool AIEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### AngleDeviation

Gets or Sets angle deviation

##### Declaration

```
float AngleDeviation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### AzimuthRotor

Gets or Sets rotor for the azimuth angle

##### Declaration

```
IMyMotorStator AzimuthRotor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyMotorStator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyMotorStator.html) |     |

#### Camera

Gets or Sets camera for the block

##### Declaration

```
IMyCameraBlock Camera { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyCameraBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyCameraBlock.html) |     |

#### ElevationRotor

Gets or Sets rotor for the elevation angle

##### Declaration

```
IMyMotorStator ElevationRotor { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyMotorStator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyMotorStator.html) |     |

#### HasTarget

Gets whether the turret is locked onto a target

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsAimed

Gets whether this block is aimed at the target

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsSunTrackerEnabled

Gets or sets if turret control block should aim sun

##### Declaration

```
bool IsSunTrackerEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsUnderControl

Gets whether this block is locally or remotely controlled.

##### Declaration

```
bool IsUnderControl { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MoveIndicator

Gets movement indicator

##### Declaration

```
Vector3 MoveIndicator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### Range

Sets or Gets shooting range of the turret

##### Declaration

```
float Range { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RollIndicator

Gets roll indicator

##### Declaration

```
float RollIndicator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotationIndicator

Gets rotation indicator

##### Declaration

```
Vector2 RotationIndicator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### TargetCharacters

Gets or Sets if the turret should target characters.

##### Declaration

```
bool TargetCharacters { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetFriends

Gets or Sets if the turret should target friends.

##### Declaration

```
bool TargetFriends { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetLargeGrids

Gets or Sets if the turret should target large grids.

##### Declaration

```
bool TargetLargeGrids { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetMeteors

Gets or Sets if the turret should target meteors.

##### Declaration

```
bool TargetMeteors { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetMissiles

Gets or Sets if the turret should target missiles.

##### Declaration

```
bool TargetMissiles { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetNeutrals

Gets or Sets if the turret should target neutrals.

##### Declaration

```
bool TargetNeutrals { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetSmallGrids

Gets or Sets if the turret should target small grids.

##### Declaration

```
bool TargetSmallGrids { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetStations

Gets or Sets if the turret should target stations.

##### Declaration

```
bool TargetStations { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### VelocityMultiplierAzimuthRpm

Gets or Sets velocity multiplier for azimuth \[rpm\]

##### Declaration

```
float VelocityMultiplierAzimuthRpm { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### VelocityMultiplierElevationRpm

Gets or Sets velocity multiplier for elevation \[rpm\]

##### Declaration

```
float VelocityMultiplierElevationRpm { get; set; }
```
