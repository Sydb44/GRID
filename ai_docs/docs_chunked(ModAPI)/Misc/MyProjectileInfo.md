---
title: "Class MyProjectileInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileInfo.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "MyProjectileInfo"
---

# Class MyProjectileInfo | Space Engineers ModAPI

Implements read-only info about existing projectile

##### Inheritance

System.Object

MyProjectileInfo

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class MyProjectileInfo : ValueType
```

### Constructors

#### MyProjectileInfo(Int32, Vector3D, Vector3D, Vector3D, Vector3D, Single, MyDefinitionBase, MyDefinitionBase, IMyEntity, IMyEntity, UInt64)

Implements projectile info constructor

##### Declaration

```
public MyProjectileInfo(int index, Vector3D position, Vector3D origin, Vector3D velocity, Vector3D cachedGravity, float maxTrajectory, MyDefinitionBase projectileAmmoDefinition, MyDefinitionBase weaponDefinition, IMyEntity ownerEntity, IMyEntity ownerEntityAbsolute, ulong owningPlayer)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | index |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | position | position |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin | origin |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | velocity | velocity |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | cachedGravity | gravity vector |
| System.Single | maxTrajectory | max trajectory |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | projectileAmmoDefinition | projectile ammo definition |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | weaponDefinition | weapon definition |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ownerEntity | owner entity |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | ownerEntityAbsolute | top owner in case of grid hierarchy |
| System.UInt64 | owningPlayer | player owner |

### Properties

#### CachedGravity

Cached gravity, in position of bullet. (May be inaccurate)

##### Declaration

```
public Vector3D CachedGravity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### Index

Index of position in array. May be changed

##### Declaration

```
public int Index { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MaxTrajectory

Max travel distance

##### Declaration

```
public float MaxTrajectory { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Origin

Shoot position (World coordinates)

##### Declaration

```
public Vector3D Origin { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### OwnerEntity

Rifle, block ...

##### Declaration

```
public IMyEntity OwnerEntity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### OwnerEntityAbsolute

character, main ship cockpit,

##### Declaration

```
public IMyEntity OwnerEntityAbsolute { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) |     |

#### OwningPlayer

Player SteamId or zero

##### Declaration

```
public ulong OwningPlayer { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### Position

World position

##### Declaration

```
public Vector3D Position { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### ProjectileAmmoDefinition

Gets Projectile Ammo Definition of type MyProjectileAmmoDefinition

##### Declaration

```
public MyDefinitionBase ProjectileAmmoDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) |     |

#### Velocity

Current velocity

##### Declaration

```
public Vector3D Velocity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) |     |

#### WeaponDefinition

Gets Weapon Definition of type MyWeaponDefinition

##### Declaration

```
public MyDefinitionBase WeaponDefinition { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) |     |