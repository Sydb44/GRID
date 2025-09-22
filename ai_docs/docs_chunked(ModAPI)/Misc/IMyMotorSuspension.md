---
title: "Interface IMyMotorSuspension"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyMotorSuspension.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyMotorSuspension"
---

# Interface IMyMotorSuspension | Space Engineers ModAPI

Describes wheel suspension (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyMotorSuspension : IMyMotorBase, IMyMechanicalConnectionBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AirShockEnabled

Enables or disables AirShock function.

##### Declaration

```
bool AirShockEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Brake

Gets or sets if brakes are applied to the wheel. This is not a brake override.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Damping

Obsolete

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Friction

Gets or sets whether suspension friction \[0..100\]%

##### Declaration

```
float Friction { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Height

Gets or sets whether suspension height in meters. Limited with block definition settings

##### Declaration

```
float Height { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### InvertPropulsion

Gets or sets whether suspension propulsion is inverted

##### Declaration

```
bool InvertPropulsion { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### InvertSteer

Gets or sets whether suspension steering is inverted

##### Declaration

```
bool InvertSteer { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsParkingEnabled

Gets or sets whether suspension reacts on parking break

##### Declaration

```
bool IsParkingEnabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxSteerAngle

Gets or sets max steering angle in radians.

##### Declaration

```
float MaxSteerAngle { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Power

Gets or sets whether suspension power \[0..100\]%

##### Declaration

```
float Power { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Propulsion

Gets or sets whether suspension has enabled propulsion

##### Declaration

```
bool Propulsion { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PropulsionOverride

Propulsion override proportion, value from -1 to 1.

##### Declaration

```
float PropulsionOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SteerAngle

Gets suspension current steering angle

##### Declaration

```
float SteerAngle { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Steering

Gets or sets whether suspension can steer

##### Declaration

```
bool Steering { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### SteeringOverride

Steering override proportion, value from -1 to 1.

##### Declaration

```
float SteeringOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SteerReturnSpeed

Obsolete

##### Declaration

```
float SteerReturnSpeed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SteerSpeed

Obsolete

##### Declaration

```
float SteerSpeed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Strength

Gets or sets whether suspension strength \[0..100\]%

##### Declaration

```
float Strength { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### SuspensionTravel

Obsolete

##### Declaration

```
float SuspensionTravel { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods