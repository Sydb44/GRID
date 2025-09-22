---
title: "Interface IMyCameraBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyCameraBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyCameraBlock"
---

# Interface IMyCameraBlock | Space Engineers ModAPI

Describes Camera block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyCameraBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### AvailableScanRange

Gets the maximum distance that this camera can scan, based on the time since the last scan.

##### Declaration

```
double AvailableScanRange { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### EnableRaycast

Gets or Sets whether the raycast is enabled. When this is true, the available raycast distance will count up, and power usage is increased.

##### Declaration

```
bool EnableRaycast { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsActive

Gets whether this camera is currently in use by at least one player.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RaycastConeLimit

Gets the maximum positive angle you can apply for pitch and yaw.

##### Declaration

```
float RaycastConeLimit { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RaycastDistanceLimit

Gets the maximum distance you can request a raycast. -1 means infinite.

##### Declaration

```
double RaycastDistanceLimit { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### RaycastTimeMultiplier

Gets the raycast time multiplier that converts time in milliseconds to available raycast distance in meters.

##### Declaration

```
float RaycastTimeMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### CanScan(Double)

Checks if the camera can scan the given distance.

##### Declaration

```
bool CanScan(double distance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance | distance in meters |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if camera can scan |

#### CanScan(Double, Vector3D)

Checks if the camera can scan to the given direction and distance (in camera local space).

##### Declaration

```
bool CanScan(double distance, Vector3D direction)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance | distance in meters |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | direction | direction to the target |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if camera can scan |

#### CanScan(Vector3D)

Checks if the camera can scan to the given target

##### Declaration

```
bool CanScan(Vector3D target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | target | target position |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | true if camera can scan |

#### Raycast(Double, Single, Single)

Does a raycast in the direction the camera is facing.

##### Declaration

```
MyDetectedEntityInfo Raycast(double distance, float pitch = 0F, float yaw = 0F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance | distance in meters |
| System.Single | pitch | pitch in degrees |
| System.Single | yaw | yaw in degrees |

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) | Empty if distance or angle are out of bounds. |

#### Raycast(Double, Vector3D)

Does a raycast in the given direction (in camera local space).

##### Declaration

```
MyDetectedEntityInfo Raycast(double distance, Vector3D targetDirection)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance | distance in meters |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | targetDirection | direction of the target |

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) | Empty if distance or angle are out of bounds. |

#### Raycast(Vector3D)

Does a raycast to the specific target point.

##### Declaration

```
MyDetectedEntityInfo Raycast(Vector3D targetPos)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | targetPos | target position |

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) | Empty if distance or angle are out of bounds. |

#### TimeUntilScan(Double)

Calculates time until scan

##### Declaration

```
int TimeUntilScan(double distance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | distance | distance in meters |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | number of milliseconds until the camera can do a raycast of the given distance |

### Extension Methods