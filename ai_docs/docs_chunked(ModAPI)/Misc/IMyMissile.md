---
title: "Interface IMyMissile"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissile.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyMissile"
---

# Interface IMyMissile | Space Engineers ModAPI

Describes missile entity (mods interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyMissile : IMyEntity, IMyEntity, IMyDestroyableObject
```

### [](#properties)Properties

#### [](#Sandbox_ModAPI_IMyMissile_AmmoDefinition)AmmoDefinition

Gets MyAmmoDefinition of missile

##### Declaration

```
MyDefinitionBase AmmoDefinition { get; }
```

##### Property Value

#### [](#Sandbox_ModAPI_IMyMissile_AmmoMagazineDefinition)AmmoMagazineDefinition

Gets MyAmmoMagazineDefinition of missile

##### Declaration

```
MyDefinitionBase AmmoMagazineDefinition { get; }
```

##### Property Value

#### [](#Sandbox_ModAPI_IMyMissile_CollidedEntity)CollidedEntity

Gets collided entity, on missile hit. You should get this value only on [OnMissileCollided](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissiles.html#Sandbox_ModAPI_IMyMissiles_OnMissileCollided) event

##### Declaration

```
MyEntity CollidedEntity { get; }
```

##### Property Value

#### [](#Sandbox_ModAPI_IMyMissile_CollisionNormal)CollisionNormal

Gets collision normal, on missile hit. You should get this value only on [OnMissileCollided](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissiles.html#Sandbox_ModAPI_IMyMissiles_OnMissileCollided) event

##### Declaration

```
Vector3 CollisionNormal { get; }
```

##### Property Value

#### [](#Sandbox_ModAPI_IMyMissile_CollisionPoint)CollisionPoint

Gets collision point, on missile hit. You should get this value only on [OnMissileCollided](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissiles.html#Sandbox_ModAPI_IMyMissiles_OnMissileCollided) event

##### Declaration

```
Nullable<Vector3D> CollisionPoint { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html)\> |     |

#### [](#Sandbox_ModAPI_IMyMissile_ExplosionDamage)ExplosionDamage

Gets or sets explosion damage for missile

##### Declaration

```
float ExplosionDamage { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_IMyMissile_ExplosionType)ExplosionType

Gets or sets explosion type of missile (changes effect of explosion)

##### Declaration

```
MyExplosionTypeEnum ExplosionType { get; set; }
```

##### Property Value

#### [](#Sandbox_ModAPI_IMyMissile_HealthPool)HealthPool

Gets or sets health of missile. While it is more than 0, it is damaging blocks that it collide with, each time subtracting amount of damage dealt. When left health is less or equal 0, missile explodes (if it hitted anything and [ShouldExplode](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyMissile.html#Sandbox_ModAPI_IMyMissile_ShouldExplode) is true).

##### Declaration

```
float HealthPool { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_IMyMissile_LauncherId)LauncherId

Character EntityId or block EntityId that shoots

##### Declaration

```
long LauncherId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#Sandbox_ModAPI_IMyMissile_LinearVelocity)LinearVelocity

Gets or sets velocity of missile

##### Declaration

```
Vector3 LinearVelocity { get; set; }
```

##### Property Value

#### [](#Sandbox_ModAPI_IMyMissile_MaxTrajectory)MaxTrajectory

Gets or sets max travel trajectory

##### Declaration

```
float MaxTrajectory { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_IMyMissile_Origin)Origin

Get or sets initial position of missile

##### Declaration

```
Vector3D Origin { get; set; }
```

##### Property Value

#### [](#Sandbox_ModAPI_IMyMissile_Owner)Owner

Character EntityId or block EntityId that shoots

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### [](#Sandbox_ModAPI_IMyMissile_ParticleEffect)ParticleEffect

Gets or sets missile trail particle effect

##### Declaration

```
MyParticleEffect ParticleEffect { get; set; }
```

##### Property Value

#### [](#Sandbox_ModAPI_IMyMissile_ShouldExplode)ShouldExplode

Gets or sets if missile should explode on hit

##### Declaration

```
bool ShouldExplode { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_IMyMissile_WeaponDefinition)WeaponDefinition

Gets MyWeaponDefinition of missile

##### Declaration

```
MyDefinitionBase WeaponDefinition { get; }
```

##### Property Value

### [](#methods)Methods

#### [](#Sandbox_ModAPI_IMyMissile_Destroy)Destroy()

Can't be called in Missiles.OnMissileMoved, MissileCollided

##### Declaration

#### [](#Sandbox_ModAPI_IMyMissile_IsCharacterIdFriendly_System_Int64_)IsCharacterIdFriendly(Int64)

Returns whether player is friendly to missile

##### Declaration

```
bool IsCharacterIdFriendly(long charId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | charId | Player identityId |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | If player is friendly |