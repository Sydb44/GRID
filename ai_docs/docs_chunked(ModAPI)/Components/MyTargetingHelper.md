---
title: "Class MyTargetingHelper"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyTargetingHelper.html"
category: "Components"
namespace: "Sandbox.Game.EntityComponents"
class: "MyTargetingHelper"
---

# Class MyTargetingHelper | Space Engineers ModAPI

##### Inheritance

System.Object

MyTargetingHelper

###### **Namespace**: [Sandbox.Game.EntityComponents](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyTargetingHelper : Object
```

### Fields

#### m\_instance

##### Declaration

```
public static MyTargetingHelper m_instance
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyTargetingHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyTargetingHelper.html) |     |

### Properties

#### Instance

##### Declaration

```
public static MyTargetingHelper Instance { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyTargetingHelper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.EntityComponents.MyTargetingHelper.html) |     |

### Methods

#### GetLockingPosition(MyEntity)

##### Declaration

```
public Vector3D GetLockingPosition(MyEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### IsVisible(MyCubeGrid, MyEntity, List<MyPhysics.HitInfo>, out MyEntity)

##### Declaration

```
public bool IsVisible(MyCubeGrid myGrid, MyEntity target, List<MyPhysics.HitInfo> hits, out MyEntity visibleBy)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeGrid](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeGrid.html) | myGrid |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | target |     |
| System.Collections.Generic.List<Sandbox.Engine.Physics.MyPhysics.HitInfo\> | hits |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | visibleBy |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PrefetchVoxels(Vector3D, Vector3D)

##### Declaration

```
public bool PrefetchVoxels(Vector3D from, Vector3D to)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | from |     |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | to  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### RaycastCheck(MyCubeBlock, MyEntity, Double, Action<MyEntity, List<MyPhysics.HitInfo>>)

##### Declaration

```
public bool RaycastCheck(MyCubeBlock myCockpit, MyEntity entity, double maxDistanceSquared, Action<MyEntity, List<MyPhysics.HitInfo>> callback)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyCubeBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.html) | myCockpit |     |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Double | maxDistanceSquared |     |
| System.Action<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html), System.Collections.Generic.List<Sandbox.Engine.Physics.MyPhysics.HitInfo\>> | callback |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |