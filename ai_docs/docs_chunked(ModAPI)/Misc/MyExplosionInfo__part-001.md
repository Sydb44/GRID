---
title: "Class MyExplosionInfo"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyExplosionInfo.html"
category: "Misc"
namespace: "Sandbox.Game"
class: "MyExplosionInfo"
---

# Class MyExplosionInfo | Space Engineers ModAPI

##### Inheritance

System.Object

MyExplosionInfo

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public sealed class MyExplosionInfo : ValueType
```

### Constructors

#### MyExplosionInfo(Single, Single, BoundingSphereD, MyExplosionTypeEnum, Boolean, Boolean, Boolean)

##### Declaration

```
public MyExplosionInfo(float playerDamage, float damage, BoundingSphereD explosionSphere, MyExplosionTypeEnum type, bool playSound, bool checkIntersection = true, bool shouldDetonateAmmo = true)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | playerDamage |     |
| System.Single | damage |     |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) | explosionSphere |     |
| [MyExplosionTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyExplosionTypeEnum.html) | type |     |
| System.Boolean | playSound |     |
| System.Boolean | checkIntersection |     |
| System.Boolean | shouldDetonateAmmo |     |

### Fields

#### CheckIntersections

##### Declaration

```
public bool CheckIntersections
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### CustomEffect

##### Declaration

```
public string CustomEffect
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### CustomSound

##### Declaration

```
public MySoundPair CustomSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### Damage

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Direction

##### Declaration

```
public Nullable<Vector3> Direction
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### DirectionNormal

##### Declaration

```
public Nullable<Vector3> DirectionNormal
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html)\> |     |

#### EffectHitAngle

##### Declaration

```
public MyObjectBuilder_MaterialPropertiesDefinition.EffectHitAngle EffectHitAngle
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_MaterialPropertiesDefinition.EffectHitAngle](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_MaterialPropertiesDefinition.EffectHitAngle.html) |     |

#### ExcludedEntity

##### Declaration

```
public MyEntity ExcludedEntity
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### ExplosionFlags

##### Declaration

```
public MyExplosionFlags ExplosionFlags
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyExplosionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyExplosionFlags.html) |     |

#### ExplosionSphere

##### Declaration

```
public BoundingSphereD ExplosionSphere
```

##### Field Value

| Type | Description |
| --- | --- |
| [BoundingSphereD](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.BoundingSphereD.html) |     |

#### ExplosionType

##### Declaration

```
public MyExplosionTypeEnum ExplosionType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyExplosionTypeEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.MyExplosionTypeEnum.html) |     |

#### HitEntity

##### Declaration

```
public MyEntity HitEntity
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### IgnoreFriendlyFireSetting

##### Declaration

```
public bool IgnoreFriendlyFireSetting
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### KeepAffectedBlocks

##### Declaration

```
public bool KeepAffectedBlocks
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### LifespanMiliseconds

##### Declaration

```
public int LifespanMiliseconds
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ObjectsRemoveDelayInMiliseconds

##### Declaration

```
public int ObjectsRemoveDelayInMiliseconds
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### OriginEntity

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### OwnerEntity

##### Declaration

```
public MyEntity OwnerEntity
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyEntity](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.Entity.MyEntity.html) |     |

#### ParticleScale

##### Declaration

```
public float ParticleScale
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PlayerDamage

##### Declaration

```
public float PlayerDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PlaySound

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ShouldDetonateAmmo

##### Declaration

```
public bool ShouldDetonateAmmo
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |
