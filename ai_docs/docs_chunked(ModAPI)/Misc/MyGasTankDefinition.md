---
title: "Class MyGasTankDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyGasTankDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyGasTankDefinition"
---

# Class MyGasTankDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyGasTankDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyGasTankDefinition : MyProductionBlockDefinition
```

### Constructors

#### MyGasTankDefinition()

##### Declaration

```
public MyGasTankDefinition()
```

### Fields

#### Capacity

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### EmptyDamagedSound

##### Declaration

```
public MySoundPair EmptyDamagedSound
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### EmptyDamageEffectName

##### Declaration

```
public string EmptyDamageEffectName
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### GasExplosionDamageMultiplier

##### Declaration

```
public float GasExplosionDamageMultiplier
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GasExplosionEffect

##### Declaration

```
public string GasExplosionEffect
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### GasExplosionMaxRadius

##### Declaration

```
public float GasExplosionMaxRadius
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GasExplosionNeededVolumeToReachMaxRadius

##### Declaration

```
public float GasExplosionNeededVolumeToReachMaxRadius
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### GasExplosionSound

##### Declaration

```
public string GasExplosionSound
```

##### Field Value

| Type | Description |
| --- | --- |
| System.String |     |

#### LeakPercent

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ResourceSourceGroup

##### Declaration

```
public MyStringHash ResourceSourceGroup
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### StoredGasId

##### Declaration

```
public MyDefinitionId StoredGasId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

### Methods

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