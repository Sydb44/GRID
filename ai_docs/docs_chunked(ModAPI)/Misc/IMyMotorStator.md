---
title: "Interface IMyMotorStator"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyMotorStator.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyMotorStator"
---

# Interface IMyMotorStator | Space Engineers ModAPI

Describes motor stator block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyMotorStator : IMyMotorBase, IMyMechanicalConnectionBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### Angle

Gets the current angle of the rotor in radians.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BrakingTorque

Gets or sets the torque applied when stopping the rotor top

##### Declaration

```
float BrakingTorque { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Displacement

Gets or sets the vertical displacement of the rotor top

##### Declaration

```
float Displacement { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### LowerLimitDeg

Gets or sets the lower angle limit of the rotor in degrees. Set to float.MinValue for no limit.

##### Declaration

```
float LowerLimitDeg { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### LowerLimitRad

Gets or sets the lower angle limit of the rotor in radians. Set to float.MinValue for no limit.

##### Declaration

```
float LowerLimitRad { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotorLock

Gets or sets rotor lock

##### Declaration

```
bool RotorLock { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TargetVelocityRad

Gets or sets the desired velocity of the rotor in radians/second

##### Declaration

```
float TargetVelocityRad { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### TargetVelocityRPM

Gets or sets the desired velocity of the rotor in RPM

##### Declaration

```
float TargetVelocityRPM { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Torque

Gets or sets the torque applied when moving the rotor top

##### Declaration

```
float Torque { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UpperLimitDeg

Gets or sets the upper angle limit of the rotor in degrees. Set to float.MaxValue for no limit.

##### Declaration

```
float UpperLimitDeg { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### UpperLimitRad

Gets or sets the upper angle limit of the rotor in radians. Set to float.MaxValue for no limit.

##### Declaration

```
float UpperLimitRad { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### RotateToAngle(MyRotationDirection, Single, Single)

Sets velocity and limits to rotate the rotor to the specified angle value

##### Declaration

```
void RotateToAngle(MyRotationDirection dir, float desiredAng, float velAbsRpm)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyRotationDirection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyRotationDirection.html) | dir | Rotation mode, [MyRotationDirection](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyRotationDirection.html) |
| System.Single | desiredAng | Angle in degrees, ranging from -360 to 360 |
| System.Single | velAbsRpm | Velocity magnitude in rotations per minute |

### Extension Methods