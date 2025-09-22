---
title: "Class MyDetectedEntityInfoHelper"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyDetectedEntityInfoHelper.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyDetectedEntityInfoHelper"
---

# Class MyDetectedEntityInfoHelper | Space Engineers ModAPI

Provides an easy method to create a MyDetectedEntityInfo struct from the detected entity and sensor owner ID

##### Inheritance

System.Object

MyDetectedEntityInfoHelper

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyDetectedEntityInfoHelper : Object
```

### Methods

#### Create(MyEntity, Int64, Nullable<Vector3D>, Nullable<MyPhysics.HitInfo>)

##### Declaration

```
public static MyDetectedEntityInfo Create(MyEntity entity, long sensorOwner, Nullable<Vector3D> hitPosition = null, Nullable<MyPhysics.HitInfo> hitInfo = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | entity |     |
| System.Int64 | sensorOwner |     |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> | hitPosition |     |
| System.Nullable<Sandbox.Engine.Physics.MyPhysics.HitInfo\> | hitInfo |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyDetectedEntityInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.MyDetectedEntityInfo.html) |     |