---
title: "Class MyAmmoDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyAmmoDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyAmmoDefinition"
---

# Class MyAmmoDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyAmmoDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public abstract class MyAmmoDefinition : MyDefinitionBase
```

### Constructors

#### MyAmmoDefinition()

##### Declaration

```
protected MyAmmoDefinition()
```

### Fields

#### AmmoType

##### Declaration

```
public MyAmmoType AmmoType
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyAmmoType](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyAmmoType.html) |     |

#### BackkickForce

##### Declaration

```
public float BackkickForce
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DeathMessage

##### Declaration

```
public Nullable<MyStringHash> DeathMessage
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Nullable<[MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html)\> |     |

#### DesiredSpeed

##### Declaration

```
public float DesiredSpeed
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EndOfLifeEffect

##### Declaration

```
public string EndOfLifeEffect
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### EndOfLifeSound

##### Declaration

```
public MySoundPair EndOfLifeSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### ExplosiveDamageMultiplier

##### Declaration

```
public float ExplosiveDamageMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### IsExplosive

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### MaxTrajectory

##### Declaration

```
public float MaxTrajectory
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PhysicalMaterial

##### Declaration

```
public MyStringHash PhysicalMaterial
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### SpeedVar

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### GetDamageForMechanicalObjects()

##### Declaration

```
public abstract float GetDamageForMechanicalObjects()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

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