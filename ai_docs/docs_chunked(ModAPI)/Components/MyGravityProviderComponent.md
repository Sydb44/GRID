---
title: "Class MyGravityProviderComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyGravityProviderComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities"
class: "MyGravityProviderComponent"
---

# Class MyGravityProviderComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyGravityProviderComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public abstract class MyGravityProviderComponent : MyEntityComponentBase, IMyEntityComponentBase, IMyComponentBase, IMyGravityProvider
```

### Constructors

#### MyGravityProviderComponent()

##### Declaration

```
protected MyGravityProviderComponent()
```

### Properties

#### ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### GravityLimit

##### Declaration

```
public abstract float GravityLimit { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsWorking

##### Declaration

```
public abstract bool IsWorking { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### DoesTrajectoryIntersectNaturalGravity(RayD, Double)

##### Declaration

```
public abstract Nullable<double> DoesTrajectoryIntersectNaturalGravity(RayD trajectory, double raySize)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [RayD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.RayD.html) | trajectory |     |
| System.Double | raySize |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<System.Double\> |     |

#### GetGravityMultiplier(Vector3D)

##### Declaration

```
public abstract float GetGravityMultiplier(Vector3D worldPoint)
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
public abstract void GetProxyAABB(out BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |

#### GetWorldGravity(Vector3D)

##### Declaration

```
public abstract Vector3 GetWorldGravity(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### GetWorldGravityNormalized(in Vector3D)

##### Declaration

```
public abstract Vector3 GetWorldGravityNormalized(in Vector3D worldPoint)
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

##### Declaration

```
public abstract bool IsPositionInRange(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Implements

### Extension Methods