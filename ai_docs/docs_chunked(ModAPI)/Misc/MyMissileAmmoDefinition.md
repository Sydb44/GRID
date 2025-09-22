---
title: "Class MyMissileAmmoDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyMissileAmmoDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyMissileAmmoDefinition"
---

# Class MyMissileAmmoDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyMissileAmmoDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyMissileAmmoDefinition : MyAmmoDefinition
```

### Constructors

#### MyMissileAmmoDefinition()

##### Declaration

```
public MyMissileAmmoDefinition()
```

### Fields

#### ExplosionFlags

##### Declaration

```
public Nullable<MyExplosionFlags> ExplosionFlags
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyExplosionFlags](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.MyExplosionFlags.html)\> |     |

#### MINIMAL\_EXPLOSION\_RADIUS

##### Declaration

```
public const float MINIMAL_EXPLOSION_RADIUS = 0.6F
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileAcceleration

##### Declaration

```
public float MissileAcceleration
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileExplosionDamage

##### Declaration

```
public float MissileExplosionDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileExplosionRadius

##### Declaration

```
public float MissileExplosionRadius
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileGravityEnabled

##### Declaration

```
public bool MissileGravityEnabled
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MissileHealthPool

##### Declaration

```
public float MissileHealthPool
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileInitialSpeed

##### Declaration

```
public float MissileInitialSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileMass

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileMaxRicochetAngle

##### Declaration

```
public float MissileMaxRicochetAngle
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileMaxRicochetProbability

##### Declaration

```
public float MissileMaxRicochetProbability
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileMinRicochetAngle

##### Declaration

```
public float MissileMinRicochetAngle
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileMinRicochetProbability

##### Declaration

```
public float MissileMinRicochetProbability
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileModelName

##### Declaration

```
public string MissileModelName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### MissileRicochetDamage

##### Declaration

```
public float MissileRicochetDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MissileSkipAcceleration

##### Declaration

```
public bool MissileSkipAcceleration
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MissileTrailEffect

##### Declaration

```
public string MissileTrailEffect
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

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