---
title: "Interface IMyGridProgramWorldInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyGridProgramWorldInfo.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyGridProgramWorldInfo"
---

# Interface IMyGridProgramWorldInfo | Space Engineers ModAPI

Contains information about the world the programmable block is running in.

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyGridProgramWorldInfo
```

### Properties

#### InventoryMultiplier

A strange system-wide gravitic field is affecting cargo holds, changing how much they can carry in their inventory

##### Declaration

```
float InventoryMultiplier { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Remarks

#### LargeShipMaxAngularSpeed

A space/time shear is imposing an angular velocity limit on large grids

##### Declaration

```
float LargeShipMaxAngularSpeed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Remarks

#### LargeShipMaxSpeed

A space/time shear is imposing a velocity limit on large grids

##### Declaration

```
float LargeShipMaxSpeed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Remarks

#### PressurizationEnabled

A space/time anomaly is preventing any pressure from building up in any space

##### Declaration

```
bool PressurizationEnabled { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Remarks

#### SmallShipMaxAngularSpeed

A space/time shear is imposing an angular velocity limit on small grids.

##### Declaration

```
float SmallShipMaxAngularSpeed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Remarks

#### SmallShipMaxSpeed

A space/time shear is imposing a velocity limit on small grids.

##### Declaration

```
float SmallShipMaxSpeed { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Remarks