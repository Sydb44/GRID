---
title: "Interface IMyModAPINaturalGravityImplementation"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyModAPINaturalGravityImplementation"
---

# Interface IMyModAPINaturalGravityImplementation | Space Engineers ModAPI

Describes ModAPI implementation for natural gravity provider (any form, not only sphere)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyModAPINaturalGravityImplementation
```

### Methods

#### DoesTrajectoryIntersectNaturalGravity(RayD, Double)

Checks if the specified trajectory intersects any natural gravity wells.

##### Declaration

```
Nullable<double> DoesTrajectoryIntersectNaturalGravity(RayD trajectory, double raySize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | trajectory | Trajectory in world coordinates |
| System.Double | raySize | Size of the ray to test with. (Capsule test) |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> | Null if doesn't intersect, double if |

#### GetGravityLimit()

Gets distance between Position of gravity provider, and it's most distant point

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Distance in meters |

#### GetGravityMultiplier(Vector3D)

Get gravity scalar

##### Declaration

```
float GetGravityMultiplier(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | Gravity scalar, in meters per second |

#### GetProxyAABB(out BoundingBoxD)

Get bounding box around gravity provider

##### Declaration

```
void GetProxyAABB(out BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb | Bounding box in world coordinates |

#### GetWorldGravity(Vector3D)

Gets gravity vector

##### Declaration

```
Vector3 GetWorldGravity(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Gravity vector, in meters per second |

#### GetWorldGravityNormalized(Vector3D)

Gets gravity vector (normalized)

##### Declaration

```
Vector3 GetWorldGravityNormalized(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | World coordinates |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | Gravity vector, normalized |

#### IsPositionInRange(Vector3D)

Tests if the specified point is within the gravity of this entity.

##### Declaration

```
bool IsPositionInRange(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint | Point to test |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | **true** if in range; **false** if not |

#### OnPositionChanged(Vector3D)

Called when position of gravity provider is changed

##### Declaration

```
void OnPositionChanged(Vector3D position)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | New world position |