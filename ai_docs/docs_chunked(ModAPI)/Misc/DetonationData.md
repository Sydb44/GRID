---
title: "Class DetonationData"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.DetonationData.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "DetonationData"
---

# Class DetonationData | Space Engineers ModAPI

##### Inheritance

System.Object

DetonationData

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class DetonationData : Object
```

### Constructors

#### DetonationData()

##### Declaration

### Fields

#### CachedExplosiveMass

##### Declaration

```
public float CachedExplosiveMass
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CachedExplosives

##### Declaration

```
public List<MyCubeBlock.StoredExplosive> CachedExplosives
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.List<[MyCubeBlock.StoredExplosive](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.StoredExplosive.html)\> |     |

#### CachedExplosiveVolume

##### Declaration

```
public float CachedExplosiveVolume
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DamageThreshold

##### Declaration

```
public float DamageThreshold
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DetonateChance

##### Declaration

```
public float DetonateChance
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionAmmoVolumeMax

##### Declaration

```
public float ExplosionAmmoVolumeMax
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionAmmoVolumeMin

##### Declaration

```
public float ExplosionAmmoVolumeMin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionDamageMax

##### Declaration

```
public float ExplosionDamageMax
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionDamagePerLiter

##### Declaration

```
public float ExplosionDamagePerLiter
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionRadiusMax

##### Declaration

```
public float ExplosionRadiusMax
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ExplosionRadiusMin

##### Declaration

```
public float ExplosionRadiusMin
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HasDetonated

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Methods

#### CacheItem(MyInventoryBase, MyPhysicalInventoryItem, MyFixedPoint)

##### Declaration

```
public void CacheItem(MyInventoryBase inventoryBase, MyPhysicalInventoryItem item, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyInventoryBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyInventoryBase.html) | inventoryBase |     |
| [MyPhysicalInventoryItem](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyPhysicalInventoryItem.html) | item |     |
| VRage.MyFixedPoint | amount |     |

#### CalculateAmmoExplosionEffects(Single, Single)

##### Declaration

```
public string CalculateAmmoExplosionEffects(float ammoMass, float ammoVolume)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | ammoMass |     |
| System.Single | ammoVolume |     |

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### CalculateStoredExplosiveDamage(List<MyCubeBlock.StoredExplosive>)

##### Declaration

```
public float CalculateStoredExplosiveDamage(List<MyCubeBlock.StoredExplosive> storedExplosives)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.List<[MyCubeBlock.StoredExplosive](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyCubeBlock.StoredExplosive.html)\> | storedExplosives |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### CalculateStoredExplosiveRadius(Single)

##### Declaration

```
public float CalculateStoredExplosiveRadius(float explosivesVolume)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | explosivesVolume |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### CalculateTemporaryContainerExplosiveRadius(Single)

##### Declaration

```
public float CalculateTemporaryContainerExplosiveRadius(float explosivesVolume)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | explosivesVolume |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### Clear()

##### Declaration

#### Init(MyGameDefinition, Single, Single)

##### Declaration

```
public void Init(MyGameDefinition gameDef, float cbDefDamageThreshold, float cbDefDetonateChance)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyGameDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Definitions.MyGameDefinition.html) | gameDef |     |
| System.Single | cbDefDamageThreshold |     |
| System.Single | cbDefDetonateChance |     |