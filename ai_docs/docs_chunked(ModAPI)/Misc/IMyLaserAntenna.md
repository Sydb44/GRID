---
title: "Interface IMyLaserAntenna"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyLaserAntenna.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyLaserAntenna"
---

# Interface IMyLaserAntenna | Space Engineers ModAPI

Laser antenna block interface

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyLaserAntenna : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### IsOutsideLimits

Target is outside movement limits of antenna

##### Declaration

```
bool IsOutsideLimits { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsPermanent

Gets or sets whether connection is permanent

##### Declaration

```
bool IsPermanent { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Range

Gets or sets the max range of the laser set in terminal

##### Declaration

```
float Range { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RequireLoS

Determines whether this particular antenna requires line of sight to function.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Status

Gets the current status of this antenna.

##### Declaration

```
MyLaserAntennaStatus Status { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyLaserAntennaStatus](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyLaserAntennaStatus.html) |     |

#### TargetCoords

Gets target coordinates

##### Declaration

```
Vector3D TargetCoords { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### Connect()

Connect to target defined by SetTargetCoords

##### Declaration

#### SetTargetCoords(String)

Sets coordinates of target

##### Declaration

```
void SetTargetCoords(string coords)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | coords | GPS coordinates string |

### Extension Methods