---
title: "Interface IMyGridJumpDriveSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGridJumpDriveSystem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyGridJumpDriveSystem"
---

# Interface IMyGridJumpDriveSystem | Space Engineers ModAPI

Interface for MyGridJumpDriveSystem in IMyCubeGrid

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGridJumpDriveSystem
```

### Properties

#### IsJumping

True if the grid is in the animation to jump

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Jumped

True when the grid finally teleports

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### AbortJump(Int32)

Ends the jump for the provided reason 0 = None, 1 = Static, 2 = Locked, 3 = ShortDistance, 4 = AlreadyJumping, 5 = NoLocation, 6 = Other

##### Declaration

```
void AbortJump(int reason = 0)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | reason |     |

#### FindSuitableJumpLocation(Vector3D)

Gets a safe position at the desired location (not overlapping stuff)

##### Declaration

```
Nullable<Vector3D> FindSuitableJumpLocation(Vector3D desiredLocation)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | desiredLocation |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### GetJumpDriveDirection()

Gets the direction vector the jump will occur (includes magnitude)

##### Declaration

```
Nullable<Vector3D> GetJumpDriveDirection()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### GetJumpDriveDirectionNormalized()

Gets the normalized direction the jump will occur

##### Declaration

```
Nullable<Vector3D> GetJumpDriveDirectionNormalized()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### GetJumpDriveTarget()

Gets the target position the jump is attempting to reach

##### Declaration

```
Nullable<Vector3D> GetJumpDriveTarget()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### GetMaxJumpDistance(Int64)

Gets the maximum possible jump distance with the current loadout

##### Declaration

```
double GetMaxJumpDistance(long userId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | userId | IdentityId, that using using jump drive |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### GetMinJumpDistance(Int64)

Gets the minimum possible jump distance with the current loadout

##### Declaration

```
double GetMinJumpDistance(long userId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | userId | IdentityId, that using using jump drive |

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### GetRemainingJumpTime()

Gets the time until the jump finally occurs

##### Declaration

```
Nullable<float> GetRemainingJumpTime()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Single\> |     |

#### IsJumpValid(Int64)

True if the grid could jump (does not check obstacles)

##### Declaration

```
bool IsJumpValid(long userId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | userId | IdentityId, that using using jump drive |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Jump(Vector3D, Int64, Single)

Makes the grid begin the jumping sequence (Call on server only!)

##### Declaration

```
void Jump(Vector3D jumpTarget, long userId, float jumpDriveDelay = 10F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | jumpTarget | World coordinates of place where you jumping |
| System.Int64 | userId | IdentityId, that using using jump drive |
| System.Single | jumpDriveDelay | Delay in seconds before jump |

#### PerformJump(Vector3D)

Performs a jump without the delay or animation (Call on server only!)

##### Declaration

```
void PerformJump(Vector3D jumpTarget)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | jumpTarget |     |

#### RequestJump(String, Vector3D, Int64, Nullable<BoundingBoxD>, Single, Nullable<Int64>)

Requests the pilot or local player to jump (Prompts the pilot with the jump UI, they can cancel the jump or say yes)

##### Declaration

```
void RequestJump(string destinationName, Vector3D destination, long userId, Nullable<BoundingBoxD> shipBox = null, float jumpDriveDelay = 10F, Nullable<long> driveEntityId = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | destinationName | Name of place where you jumping |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | destination | World coordinates of place where you jumping |
| System.Int64 | userId | IdentityId, that using using jump drive |
| System.Nullable<[BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html)\> | shipBox | Bounding box of ship in world coordinates that would be used in gravity check |
| System.Single | jumpDriveDelay | Delay in seconds before jump |
| System.Nullable<System.Int64\> | driveEntityId | Optional EntityId of the jump drive that requested the jump. It will be used for visual and sound effects. |
