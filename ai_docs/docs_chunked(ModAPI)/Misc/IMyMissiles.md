---
title: "Interface IMyMissiles"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissiles.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyMissiles"
---

# Interface IMyMissiles | Space Engineers ModAPI

Interface for controlling missiles

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyMissiles
```

### Methods

#### add\_OnMissileMoved(MissileMoveDelegate)

##### Declaration

```
void add_OnMissileMoved(MissileMoveDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MissileMoveDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MissileMoveDelegate.html) | value |     |

#### GetAllMissilesInSphere(ref BoundingSphereD, List<MyEntity>)

Returns all missiles in sphere

##### Declaration

```
void GetAllMissilesInSphere(ref BoundingSphereD sphere, List<MyEntity> result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | sphere | Bounding sphere |
| System.Collections.Generic.List<[MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\> | result | List, that were results would be added |

#### Remove(Int64)

Removes missile with EntityId

##### Declaration

```
void Remove(long entityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId | Missile with this entityId should be removed |

#### remove\_OnMissileMoved(MissileMoveDelegate)

##### Declaration

```
void remove_OnMissileMoved(MissileMoveDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MissileMoveDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MissileMoveDelegate.html) | value |     |

### Events

#### OnMissileAdded

Called when missile was created

##### Declaration

```
event Action<IMyMissile> OnMissileAdded
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyMissile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissile.html)\> |     |

#### OnMissileCollided

Called when missile hits something. May be more than 1 call per missile.

##### Declaration

```
event Action<IMyMissile> OnMissileCollided
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyMissile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissile.html)\> |     |

#### OnMissileMoved

Called each frame after missile was moved

##### Declaration

```
event MissileMoveDelegate OnMissileMoved
```

##### Event Type

| Type | Description |
| --- | --- |
| [MissileMoveDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MissileMoveDelegate.html) |     |

#### OnMissileRemoved

Called when missile was removed

##### Declaration

```
event Action<IMyMissile> OnMissileRemoved
```

##### Event Type

| Type | Description |
| --- | --- |
| System.Action<[IMyMissile](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissile.html)\> |     |