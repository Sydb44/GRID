---
title: "Interface IMyTargetingCapableBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTargetingCapableBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyTargetingCapableBlock"
---

# Interface IMyTargetingCapableBlock | Space Engineers ModAPI

Describes block that can target (cockpits and turrets) (mods interface)

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTargetingCapableBlock
```

### Methods

#### CanActiveToolShoot()

Get whether toolbar selected tool can shoot

##### Declaration

```
bool CanActiveToolShoot()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether can shoot |

##### Remarks

#### GetActiveToolPosition()

Gets average position

##### Declaration

```
Vector3D GetActiveToolPosition()
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

##### Remarks

#### GetWorldMatrix()

Gets barrel or block world matrix

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| [MatrixD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.MatrixD.html) | Barrel or block world matrix |

#### IsShipToolSelected()

Get whether toolbar selected item is ship tool (drill, grinder, welder)

##### Declaration

```
bool IsShipToolSelected()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether tool is selected |

##### Remarks

#### IsTargetLockingEnabled()

Gets if target locking is enabled

##### Declaration

```
bool IsTargetLockingEnabled()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if enabled |

#### SetLockedTarget(IMyCharacter)

Sets locked target grid

##### Declaration

```
void SetLockedTarget(IMyCharacter target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCharacter](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCharacter.html) | target | Target grid |

##### Remarks

#### SetLockedTarget(IMyCubeGrid)

Sets locked target grid

##### Declaration

```
void SetLockedTarget(IMyCubeGrid target)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyCubeGrid.html) | target | Target grid |

##### Remarks