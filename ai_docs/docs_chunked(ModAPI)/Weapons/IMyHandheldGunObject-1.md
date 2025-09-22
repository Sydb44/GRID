---
title: "Interface IMyHandheldGunObject<T>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.IMyHandheldGunObject-1.html"
category: "Weapons"
namespace: "Sandbox.Game.Entities"
class: "IMyHandheldGunObject-1"
---

# Interface IMyHandheldGunObject<T> | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public interface IMyHandheldGunObject<out T> : IMyGunObject<T> where T : MyDeviceBase
```

##### Type Parameters

| Name | Description |
| --- | --- |
| T   |     |

### Properties

#### CurrentAmmunition

##### Declaration

```
int CurrentAmmunition { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CurrentMagazineAmmunition

##### Declaration

```
int CurrentMagazineAmmunition { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### CurrentMagazineAmount

##### Declaration

```
int CurrentMagazineAmount { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ForceAnimationInsteadOfIK

##### Declaration

```
bool ForceAnimationInsteadOfIK { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsBlocking

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsRecoiling

##### Declaration

```
bool IsRecoiling { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### IsReloading

##### Declaration

```
bool IsReloading { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### NeedsReload

##### Declaration

```
bool NeedsReload { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### OwnerId

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### OwnerIdentityId

##### Declaration

```
long OwnerIdentityId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### PhysicalItemDefinition

##### Declaration

```
MyPhysicalItemDefinition PhysicalItemDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyPhysicalItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyPhysicalItemDefinition.html) |     |

#### PhysicalObject

##### Declaration

```
MyObjectBuilder_PhysicalGunObject PhysicalObject { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_PhysicalGunObject](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_PhysicalGunObject.html) |     |

#### Reloadable

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### CanDoubleClickToStick(MyShootActionEnum)

##### Declaration

```
bool CanDoubleClickToStick(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CanReload()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### DoubleClicked(MyShootActionEnum)

##### Declaration

```
void DoubleClicked(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

#### GetReloadDuration()

##### Declaration

```
float GetReloadDuration()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetShakeOnAction(MyShootActionEnum)

##### Declaration

```
bool GetShakeOnAction(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### PlayReloadSound()

##### Declaration

#### Reload()

##### Declaration

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldEndShootOnPause(MyShootActionEnum)

##### Declaration

```
bool ShouldEndShootOnPause(MyShootActionEnum action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyShootActionEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyShootActionEnum.html) | action |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |