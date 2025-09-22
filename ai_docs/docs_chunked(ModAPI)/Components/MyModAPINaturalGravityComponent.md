---
title: "Class MyModAPINaturalGravityComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyModAPINaturalGravityComponent.html"
category: "Components"
namespace: "Sandbox.Game.Entities"
class: "MyModAPINaturalGravityComponent"
---

# Class MyModAPINaturalGravityComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyModAPINaturalGravityComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyModAPINaturalGravityComponent : MyGravityProviderComponent, IMyEntityComponentBase, IMyComponentBase, IMyGravityProvider, IMyModAPINaturalGravityComponent, IMyNaturalGravityComponent
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent__ctor_VRage_Game_ModAPI_IMyModAPINaturalGravityImplementation_)MyModAPINaturalGravityComponent(IMyModAPINaturalGravityImplementation)

##### Declaration

```
public MyModAPINaturalGravityComponent(IMyModAPINaturalGravityImplementation implementation)
```

##### Parameters

### [](#properties)Properties

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_ComponentTypeDebugString)ComponentTypeDebugString

##### Declaration

```
public override string ComponentTypeDebugString { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_GravityLimit)GravityLimit

##### Declaration

```
public override float GravityLimit { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_Implementation)Implementation

##### Declaration

```
public IMyModAPINaturalGravityImplementation Implementation { get; }
```

##### Property Value

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_IsWorking)IsWorking

##### Declaration

```
public override bool IsWorking { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_Position)Position

##### Declaration

```
public Vector3D Position { get; set; }
```

##### Property Value

### [](#methods)Methods

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_DoesTrajectoryIntersectNaturalGravity_VRageMath_RayD_System_Double_)DoesTrajectoryIntersectNaturalGravity(RayD, Double)

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

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_GetGravityLimit)GetGravityLimit()

##### Declaration

```
public float GetGravityLimit()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_GetGravityMultiplier_VRageMath_Vector3D_)GetGravityMultiplier(Vector3D)

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

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_GetProxyAABB_VRageMath_BoundingBoxD__)GetProxyAABB(out BoundingBoxD)

##### Declaration

```
public override void GetProxyAABB(out BoundingBoxD aabb)
```

##### Parameters

##### Overrides

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_GetWorldGravity_VRageMath_Vector3D_)GetWorldGravity(Vector3D)

##### Declaration

```
public override Vector3 GetWorldGravity(Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

##### Overrides

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_GetWorldGravityNormalized_VRageMath_Vector3D__)GetWorldGravityNormalized(in Vector3D)

##### Declaration

```
public override Vector3 GetWorldGravityNormalized(in Vector3D worldPoint)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | worldPoint |     |

##### Returns

##### Overrides

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_IsPositionInRange_VRageMath_Vector3D_)IsPositionInRange(Vector3D)

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

#### [](#Sandbox_Game_Entities_MyModAPINaturalGravityComponent_OnAddedToContainer)OnAddedToContainer()

##### Declaration

```
public override void OnAddedToContainer()
```

##### Overrides

### [](#implements)Implements

### [](#extensionmethods)Extension Methods