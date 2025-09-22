---
title: "Class MySphericalNaturalGravityComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySphericalNaturalGravityComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities"
class: "MySphericalNaturalGravityComponent"
---

# Class MySphericalNaturalGravityComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MySphericalNaturalGravityComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MySphericalNaturalGravityComponent : MyGravityProviderComponent, IMyEntityComponentBase, IMyComponentBase, IMyGravityProvider, IMySphericalNaturalGravityComponent, IMyNaturalGravityComponent
```

### Constructors

#### MySphericalNaturalGravityComponent(Double, Double, Double, Double)

##### Declaration

```
public MySphericalNaturalGravityComponent(double minRadius, double maxRadius, double falloff, double intensity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Double | minRadius |     |
| System.Double | maxRadius |     |
| System.Double | falloff |     |
| System.Double | intensity |     |

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
public override float GravityLimit { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### GravityLimitSq

##### Declaration

```
public float GravityLimitSq { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsWorking

##### Declaration

```
public override bool IsWorking { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### Position

##### Declaration

```
public Vector3D Position { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

### Methods

#### CalculateGravityLimit()

##### Declaration

```
public void CalculateGravityLimit()
```

#### DoesTrajectoryIntersectNaturalGravity(RayD, Double)

##### Declaration

```
public override Nullable<double> DoesTrajectoryIntersectNaturalGravity(RayD trajectory, double raySize)
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

##### Overrides

#### GetGravityMultiplier(Vector3D)

##### Declaration

```
public override float GetGravityMultiplier(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### GetProxyAABB(out BoundingBoxD)

##### Declaration

```
public override void GetProxyAABB(out BoundingBoxD aabb)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingBoxD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingBoxD.html) | aabb |     |

##### Overrides

#### GetWorldGravity(Vector3D)

##### Declaration

```
public override Vector3 GetWorldGravity(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

##### Overrides

#### GetWorldGravityNormalized(in Vector3D)

##### Declaration

```
public override Vector3 GetWorldGravityNormalized(in Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

##### Overrides

#### IsPositionInRange(Vector3D)

##### Declaration

```
public override bool IsPositionInRange(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

### Explicit Interface Implementations

#### IMyNaturalGravityComponent.Position

##### Declaration

```
Vector3D IMyNaturalGravityComponent.Position { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### IMySphericalNaturalGravityComponent.Falloff

##### Declaration

```
double IMySphericalNaturalGravityComponent.Falloff { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### IMySphericalNaturalGravityComponent.Intensity

##### Declaration

```
double IMySphericalNaturalGravityComponent.Intensity { get; set; }
```

##### Returns

| Type | Description |
| --- | --- |
| System.Double |     |

#### IMySphericalNaturalGravityComponent.MaxRadius
