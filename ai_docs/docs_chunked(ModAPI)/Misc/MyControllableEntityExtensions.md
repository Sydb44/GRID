---
title: "Class MyControllableEntityExtensions"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyControllableEntityExtensions.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyControllableEntityExtensions"
---

# Class MyControllableEntityExtensions | Space Engineers ModAPI

##### Inheritance

System.Object

MyControllableEntityExtensions

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public static class MyControllableEntityExtensions : Object
```

### Methods

#### GetLinearVelocity(IMyControllableEntity, ref Vector3, Boolean)

##### Declaration

```
public static void GetLinearVelocity(this IMyControllableEntity controlledEntity, ref Vector3 velocityVector, bool useRemoteControlVelocity = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | controlledEntity |     |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | velocityVector |     |
| System.Boolean | useRemoteControlVelocity |     |

#### Physics(IMyControllableEntity)

##### Declaration

```
public static MyPhysicsComponentBase Physics(this IMyControllableEntity entity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | entity |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyPhysicsComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Components.MyPhysicsComponentBase.html) |     |

#### SwitchControl(IMyControllableEntity, IMyControllableEntity)

##### Declaration

```
public static void SwitchControl(this IMyControllableEntity entity, IMyControllableEntity newControlledEntity)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | entity |     |
| [IMyControllableEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyControllableEntity.html) | newControlledEntity |     |