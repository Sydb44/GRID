---
title: "Interface IMyPistonBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyPistonBase.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyPistonBase"
---

# Interface IMyPistonBase | Space Engineers ModAPI

Describes piston block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyPistonBase : IMyMechanicalConnectionBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### [](#properties)Properties

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_CurrentPosition)CurrentPosition

Gets the current position of the piston head relative to the base.

##### Declaration

```
float CurrentPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_HighestPosition)HighestPosition

Gets the highest position the piston is capable of moving to.

##### Declaration

```
float HighestPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_LowestPosition)LowestPosition

Gets the lowest position the piston is capable of moving to.

##### Declaration

```
float LowestPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_MaxLimit)MaxLimit

Gets or sets the maximum position the piston can extend to. See [LowestPosition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyPistonBase.html#Sandbox_ModAPI_Ingame_IMyPistonBase_LowestPosition) and [HighestPosition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyPistonBase.html#Sandbox_ModAPI_Ingame_IMyPistonBase_HighestPosition) for the limits of this value.

##### Declaration

```
float MaxLimit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_MaxVelocity)MaxVelocity

Gets the maximum velocity this piston is capable of moving at.

##### Declaration

```
float MaxVelocity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_MinLimit)MinLimit

Gets or sets the minimum position the piston can retract to. See [LowestPosition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyPistonBase.html#Sandbox_ModAPI_Ingame_IMyPistonBase_LowestPosition) and [HighestPosition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyPistonBase.html#Sandbox_ModAPI_Ingame_IMyPistonBase_HighestPosition) for the limits of this value.

##### Declaration

```
float MinLimit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_NormalizedPosition)NormalizedPosition

Gets the current position normalized between MinLimit and MaxLimit

##### Declaration

```
float NormalizedPosition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_Status)Status

Gets the current status.

##### Declaration

```
PistonStatus Status { get; }
```

##### Property Value

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_Velocity)Velocity

Gets or sets the velocity of the piston as it extends or retracts. This value can be between negative and positive [MaxVelocity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyPistonBase.html#Sandbox_ModAPI_Ingame_IMyPistonBase_MaxVelocity).

##### Declaration

```
float Velocity { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#methods)Methods

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_Extend)Extend()

Extends the piston.

##### Declaration

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_MoveToPosition_System_Single_System_Single_)MoveToPosition(Single, Single)

Sets velocity and limits to move the piston to the specified extent value

##### Declaration

```
void MoveToPosition(float extent, float speed)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | extent | Desired position |
| System.Single | speed | Desired velocity magnitude |

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_Retract)Retract()

Retracts the piston.

##### Declaration

#### [](#Sandbox_ModAPI_Ingame_IMyPistonBase_Reverse)Reverse()

Reverses the direction of the piston.

##### Declaration

### [](#extensionmethods)Extension Methods