---
title: "Interface IMyGravityProvider"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyGravityProvider.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "IMyGravityProvider"
---

# Interface IMyGravityProvider | Space Engineers ModAPI

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyGravityProvider
```

### Properties

#### IsWorking

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### GetGravityMultiplier(Vector3D)

##### Declaration

```
float GetGravityMultiplier(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetProxyAABB(out BoundingBoxD)

##### Declaration

```
void GetProxyAABB(out BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |

#### GetWorldGravity(Vector3D)

##### Declaration

```
Vector3 GetWorldGravity(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

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