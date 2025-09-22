---
title: "Interface IMyNaturalGravityComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyNaturalGravityComponent.html"
category: "Components"
namespace: "VRage.Game.ModAPI"
class: "IMyNaturalGravityComponent"
---

# Interface IMyNaturalGravityComponent | Space Engineers ModAPI

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyNaturalGravityComponent
```

### Properties

#### GravityLimit

Gets distance between Position of gravity provider, and it's most distant point

##### Declaration

```
float GravityLimit { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsWorking

Gets whither block is working or not

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Position

##### Declaration

```
Vector3D Position { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

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