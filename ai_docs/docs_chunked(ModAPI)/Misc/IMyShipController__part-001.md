---
title: "Interface IMyShipController"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyShipController.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyShipController"
---

# Interface IMyShipController | Space Engineers ModAPI

Describes ship controller block (cockpit/remote control/cryopod) (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyShipController : IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### CanControlShip

Determines whether this specific ship controller is capable of controlling the ship it's installed on.

##### Declaration

```
bool CanControlShip { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CenterOfMass

Center of mass in world coordinates

##### Declaration

```
Vector3D CenterOfMass { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### ControlThrusters

Gets or sets whether thrusters are being controlled by this controller.

##### Declaration

```
bool ControlThrusters { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ControlWheels

Gets or sets whether wheels are being controlled by this controller.

##### Declaration

```
bool ControlWheels { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DampenersOverride

Gets or sets whether dampeners are currently enabled.

##### Declaration

```
bool DampenersOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HandBrake

Gets or sets the current state of the handbrake.

##### Declaration

```
bool HandBrake { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### HasWheels

Determines whether there are any wheels on this ship.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsMainCockpit

Gets or sets if this controller is the main one for current ship Setter checks if there is any other main cockpit on the ship before proceeding

##### Declaration

```
bool IsMainCockpit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsUnderControl

Indicates whether a block is locally or remotely controlled.

##### Declaration

```
bool IsUnderControl { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MoveIndicator

Directional input from user/autopilot. Values can be very large with high controller sensitivity

##### Declaration

```
Vector3 MoveIndicator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### RollIndicator

Roll input from user/autopilot. Values can be very large with high controller sensitivity

##### Declaration

```
float RollIndicator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RotationIndicator

Pitch, yaw input from user/autopilot. Values can be very large with high controller sensitivity

##### Declaration

```
Vector2 RotationIndicator { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector2](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector2.html) |     |

#### ShowHorizonIndicator

Gets or sets whether the horizon indicator should be displayed for this block.

##### Declaration

```
bool ShowHorizonIndicator { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### CalculateShipMass()

Gets information about the current mass of the ship.

##### Declaration

```
MyShipMass CalculateShipMass()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyShipMass](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipMass.html) | Ship mass information |

#### GetArtificialGravity()

Gets the detected artificial gravity vector and power at the current location.

##### Declaration

```
Vector3D GetArtificialGravity()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | Artificial gravity vector |

#### GetNaturalGravity()

Gets the detected natural gravity vector and power at the current location.

##### Declaration

```
Vector3D GetNaturalGravity()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | Natural gravity vector |

#### GetShipSpeed()

Gets the basic ship speed in meters per second, for when you just need to know how fast you're going.

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Double | Ship speed in meters per second |

#### GetShipVelocities()

Determines the linear velocities in meters per second and angular velocities in radians per second. Provides a more accurate representation of the directions and axis speeds.

##### Declaration

```
MyShipVelocities GetShipVelocities()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyShipVelocities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyShipVelocities.html) |     |

#### GetTotalGravity()

Gets the total accumulated gravity vector and power at the current location, taking both natural and artificial gravity into account.

##### Declaration

```
Vector3D GetTotalGravity()
```
