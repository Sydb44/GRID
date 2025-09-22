---
title: "Class MyProjectileAmmoDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyProjectileAmmoDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyProjectileAmmoDefinition"
---

# Class MyProjectileAmmoDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyProjectileAmmoDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyProjectileAmmoDefinition : MyAmmoDefinition
```

### Constructors

#### MyProjectileAmmoDefinition()

##### Declaration

```
public MyProjectileAmmoDefinition()
```

### Fields

#### HeadShot

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ProjectileCount

Number of pellets (shotgun)

##### Declaration

```
public int ProjectileCount
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ProjectileExplosionDamage

##### Declaration

```
public float ProjectileExplosionDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProjectileExplosionRadius

##### Declaration

```
public float ProjectileExplosionRadius
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProjectileHeadShotDamage

##### Declaration

```
public float ProjectileHeadShotDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProjectileHealthDamage

##### Declaration

```
public float ProjectileHealthDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProjectileHitImpulse

##### Declaration

```
public float ProjectileHitImpulse
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProjectileMassDamage

##### Declaration

```
public float ProjectileMassDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProjectileOnHitEffectName

##### Declaration

```
public string ProjectileOnHitEffectName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ProjectileTrailColor

##### Declaration

```
public Vector3 ProjectileTrailColor
```

##### Field Value

| Type | Description |
| --- | --- |
| [Vector3](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRageMath.Vector3.html) |     |

#### ProjectileTrailMaterial

##### Declaration

```
public string ProjectileTrailMaterial
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ProjectileTrailProbability

##### Declaration

```
public float ProjectileTrailProbability
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ProjectileTrailScale

##### Declaration

```
public float ProjectileTrailScale
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Properties

#### ProjectileTrailMaterialId

##### Declaration

```
public MyStringId ProjectileTrailMaterialId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringId.html) |     |

### Methods

#### GetDamageForMechanicalObjects()

##### Declaration

```
public override float GetDamageForMechanicalObjects()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

##### Overrides

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides