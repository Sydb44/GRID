---
title: "Interface IMyGunObject<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyGunObject-1.html"
category: "Weapons"
namespace: "VRage.Game.ModAPI"
class: "IMyGunObject-1"
---

# Interface IMyGunObject<T> | Space Engineers ModAPI

This can be hand held weapon (including welders and drills) as well as weapons on ship (including ship drills).

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyGunObject<out T>
    where T : MyDeviceBase
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Properties

#### BackkickForcePerSecond

Gets force in Newtons.

##### Declaration

```
float BackkickForcePerSecond { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DefinitionId

Gets block definition id

##### Declaration

```
MyDefinitionId DefinitionId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### EnabledInWorldRules

##### Declaration

```
bool EnabledInWorldRules { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### GunBase

Gets class that extends from [MyDeviceBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDeviceBase.html). It could be MyToolBase, MyGunBase or even custom logic. Keep in mind, that some functions works differently for tools, gun or custom logic.

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| T   |     |

#### IsShooting

Should return true when the weapon is shooting projectiles and other classes should react accordingly (i.e.apply backkick force etc.)

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsSkinnable

Gets if character weapon/tool is skinnable

##### Declaration

```
bool IsSkinnable { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsTargetLockingCapable

Gets if device can lock targets. (Warfare 2 feature)

##### Declaration

```
bool IsTargetLockingCapable { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaximumShotLength

Zero means that the gun should not update shoot direction at all

##### Declaration

```
float MaximumShotLength { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single | Minimal time interval in milliseconds between two direction updates |

#### NeedsShootDirectionWhileAiming

Whether this gun needs the shoot direction at all times. Guns that do not will have their direction

##### Declaration

```
bool NeedsShootDirectionWhileAiming { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShakeAmount

Gets shake amount of grid, when

##### Declaration

```
float ShakeAmount { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ShootDirectionUpdateTime

Zero means that the gun should not update shoot direction at all

##### Declaration

```
int ShootDirectionUpdateTime { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 | Minimal time interval in milliseconds between two direction updates |

### Methods

#### BeginFailReaction(MyShootActionEnum, MyGunStatusEnum)

Perform a fail reaction to begin shoot that is shown on all clients (e.g. fail sound, etc.)

##### Declaration

```
void BeginFailReaction(MyShootActionEnum action, MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action | The shooting action, whose begin shoot failed |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status | Why the begin shoot failed |

#### BeginFailReactionLocal(MyShootActionEnum, MyGunStatusEnum)

Perform a fail reaction to begin shoot that is shown only on client that controls character or ship, that has this device

##### Declaration

```
void BeginFailReactionLocal(MyShootActionEnum action, MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action | The shooting action, whose begin shoot failed |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status | Why the begin shoot failed |

#### BeginShoot(MyShootActionEnum)

Called when device start shooting

##### Declaration

```
void BeginShoot(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action | Type if shooting |

#### CanShoot(MyShootActionEnum, Int64, out MyGunStatusEnum)

Should return true if and only if the gun would be able to shoot using the given shoot action. This method should not do any side-effects such as play sounds or create particle FX.

##### Declaration

```
bool CanShoot(MyShootActionEnum action, long shooter, out MyGunStatusEnum status)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action | The shooting action to test |
| System.Int64 | shooter | Id of shooting player |
| [MyGunStatusEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyGunStatusEnum.html) | status | Detailed status of the gun, telling why the gun couldn't perform the given shoot action |
