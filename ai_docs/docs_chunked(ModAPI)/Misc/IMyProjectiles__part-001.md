---
title: "Interface IMyProjectiles"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyProjectiles.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "IMyProjectiles"
---

# Interface IMyProjectiles | Space Engineers ModAPI

Interface for controlling projectile behavior (mods interface)

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyProjectiles
```

### Methods

#### Add(MyDefinitionBase, MyDefinitionBase, Vector3D, Vector3, Vector3, MyEntity, MyEntity, MyEntity, MyEntity\[\], Boolean, UInt64)

Adds new projectile

##### Declaration

```
void Add(MyDefinitionBase weaponDefinition, MyDefinitionBase ammoDefinition, Vector3D origin, Vector3 initialVelocity, Vector3 directionNormalized, MyEntity owningEntity, MyEntity owningEntityAbsolute, MyEntity weapon, MyEntity[] ignoredEntities, bool supressHitIndicator = false, ulong owningPlayer = 0UL)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | weaponDefinition | Definition of weapon. Should be MyWeaponDefinition |
| [MyDefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionBase.html) | ammoDefinition | Definition of ammo. Should be MyAmmoDefinition |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | origin | Spawn position |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | initialVelocity | Speed of object that fired projectile |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) | directionNormalized | Direction of bullet |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | owningEntity | Rifle, block, ... |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | owningEntityAbsolute | Character, main ship cockpit. Used only to record damage statistics in single player |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) | weapon | Shooter entity (rifle, block) |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html)\[\] | ignoredEntities |     |
| System.Boolean | supressHitIndicator | When true, hit indicator won't show |
| System.UInt64 | owningPlayer | Player that owns this projectile. Adds hit indication for that player on hit, and using that id in safezone access checks |

#### add\_OnProjectileAdded(OnProjectileAddedRemoved)

##### Declaration

```
void add_OnProjectileAdded(OnProjectileAddedRemoved value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [OnProjectileAddedRemoved](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.OnProjectileAddedRemoved.html) | value |     |

#### add\_OnProjectileRemoving(OnProjectileAddedRemoved)

##### Declaration

```
void add_OnProjectileRemoving(OnProjectileAddedRemoved value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [OnProjectileAddedRemoved](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.OnProjectileAddedRemoved.html) | value |     |

#### AddHitDetector(IMyProjectileDetector)

Adds projectile detector. It allows to detect projectiles flying though it, and can cause them hit it Example: Safezone, ship shields

##### Declaration

```
void AddHitDetector(IMyProjectileDetector detector)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyProjectileDetector](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyProjectileDetector.html) | detector | Detector logic |

#### AddOnHitInterceptor(Int32, HitInterceptor)

Call function when projectile hits something

##### Declaration

```
void AddOnHitInterceptor(int priority, HitInterceptor interceptor)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | priority | Calls are ordered by priority. Functions with lower priority are called earlier |
| [HitInterceptor](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.HitInterceptor.html) | interceptor | Function that should be called on projectile hit |

#### GetAllProjectileCount()

Gets amount of projectiles currently existing

##### Declaration

```
int GetAllProjectileCount()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### GetProjectile(Int32)

Gets projectile info

##### Declaration

```
MyProjectileInfo GetProjectile(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | index of the info |

##### Returns

| Type | Description |
| --- | --- |
| [MyProjectileInfo](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileInfo.html) |     |

#### GetSurfaceAndMaterial(IMyEntity, ref LineD, ref Vector3D, UInt32, out MySurfaceImpactEnum, out MyStringHash)

##### Declaration

```
void GetSurfaceAndMaterial(IMyEntity entity, ref LineD line, ref Vector3D hitPosition, uint shapeKey, out MySurfaceImpactEnum surfaceImpact, out MyStringHash materialType)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html) | entity | Entity that was hitted |
| [LineD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.LineD.html) | line | Part of bullet trajectory |
| [Vector3D](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3D.html) | hitPosition | World position of hit |
| System.UInt32 | shapeKey | Should be taken from [HitShapeKey](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyProjectileHitInfo.html#Sandbox_ModAPI_MyProjectileHitInfo_HitShapeKey) |
| [MySurfaceImpactEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MySurfaceImpactEnum.html) | surfaceImpact | Returns surface, that bullet hitted |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) | materialType | Returns material, that bullet hitted |
