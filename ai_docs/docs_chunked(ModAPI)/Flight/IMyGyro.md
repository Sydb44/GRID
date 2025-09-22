---
title: "Interface IMyGyro"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGyro.html"
category: "Flight"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyGyro"
---

# Interface IMyGyro | Space Engineers ModAPI

Describes gyroscope block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyGyro : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### GyroOverride

Gets or set whether this gyro has enabled override

##### Declaration

```
bool GyroOverride { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GyroPower

Get or set gyroscope power in

##### Declaration

```
float GyroPower { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Pitch

Gets or set the pitch angle

##### Declaration

```
float Pitch { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Roll

Gets or set the roll angle

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Yaw

Gets or sets the yaw angle

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods