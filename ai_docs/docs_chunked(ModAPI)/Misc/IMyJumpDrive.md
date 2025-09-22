---
title: "Interface IMyJumpDrive"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyJumpDrive.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyJumpDrive"
---

# Interface IMyJumpDrive | Space Engineers ModAPI

Describes jump drive block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyJumpDrive : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### CurrentStoredPower

Gets block stored power

##### Declaration

```
float CurrentStoredPower { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JumpDistanceMeters

Gets or sets jump drive distance in meters.

##### Declaration

```
float JumpDistanceMeters { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### JumpDistanceRatio

Gets or sets jump drive distance ratio, value from 0 to 1.

##### Declaration

```
float JumpDistanceRatio { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxJumpDistanceMeters

Gets maximum jump drive distance.

##### Declaration

```
float MaxJumpDistanceMeters { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxStoredPower

Gets block max stored power

##### Declaration

```
float MaxStoredPower { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinJumpDistanceMeters

Gets minimum jump drive distance.

##### Declaration

```
float MinJumpDistanceMeters { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Recharge

Turns on/off recharging

##### Declaration

```
bool Recharge { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Status

Gets block status

##### Declaration

```
MyJumpDriveStatus Status { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyJumpDriveStatus](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyJumpDriveStatus.html) |     |

### Extension Methods