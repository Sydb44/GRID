---
title: "Class MyCharacterStatComponent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.MyCharacterStatComponent.html"
category: "Components"
namespace: "Sandbox.Game.Components"
class: "MyCharacterStatComponent"
---

# Class MyCharacterStatComponent | Space Engineers ModAPI

##### Inheritance

System.Object

MyCharacterStatComponent

##### Implements

##### Inherited Members

###### **Namespace**: [Sandbox.Game.Components](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Components.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyComponentType]
[MyComponentBuilder]
public class MyCharacterStatComponent : MyEntityStatComponent, IMyEntityComponentBase, IMyComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent, IMyHazardReceiver
```

### Constructors

#### MyCharacterStatComponent()

##### Declaration

```
public MyCharacterStatComponent()
```

### Fields

#### FOOD\_ID

##### Declaration

```
public static MyStringHash FOOD_ID
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### HEALTH\_RATIO\_CRITICAL

##### Declaration

```
public static readonly float HEALTH_RATIO_CRITICAL
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HEALTH\_RATIO\_LOW

##### Declaration

```
public static readonly float HEALTH_RATIO_LOW
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### HealthId

##### Declaration

```
public static MyStringHash HealthId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### LastDamage

##### Declaration

```
public MyDamageInformation LastDamage
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyDamageInformation](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyDamageInformation.html) |     |

#### LastDamageSoundOverride

##### Declaration

```
public MySoundPair LastDamageSoundOverride
```

##### Field Value

| Type | Description |
| --- | --- |
| [MySoundPair](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MySoundPair.html) |     |

#### RADIATION\_ID

##### Declaration

```
public static MyStringHash RADIATION_ID
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### RADIATION\_IMMUNITY\_ID

##### Declaration

```
public static MyStringHash RADIATION_IMMUNITY_ID
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### SHOW\_CAUSE\_OF\_DEATH\_FADE\_START\_FRAMES

##### Declaration

```
public static readonly ulong SHOW_CAUSE_OF_DEATH_FADE_START_FRAMES
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

#### SHOW\_CAUSE\_OF\_DEATH\_FRAMES

##### Declaration

```
public static readonly ulong SHOW_CAUSE_OF_DEATH_FRAMES
```

##### Field Value

| Type | Description |
| --- | --- |
| System.UInt64 |     |

### Properties

#### Food

##### Declaration

```
public MyEntityStat Food { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html) |     |

#### FoodRatio

##### Declaration

```
public float FoodRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Health

##### Declaration

```
public MyEntityStat Health { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html) |     |

#### HealthRatio

##### Declaration

```
public float HealthRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Radiation

##### Declaration

```
public MyEntityStat Radiation { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html) |     |

#### RadiationImmunity

##### Declaration

```
public MyEntityStat RadiationImmunity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html) |     |

#### RadiationImmunityRatio

##### Declaration

```
public float RadiationImmunityRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RadiationRatio

##### Declaration

```
public float RadiationRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Consume(MyFixedPoint, MyConsumableItemDefinition)

##### Declaration

```
public void Consume(MyFixedPoint amount, MyConsumableItemDefinition definition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.MyFixedPoint | amount |     |
| [MyConsumableItemDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyConsumableItemDefinition.html) | definition |     |

#### Deserialize(MyObjectBuilder\_ComponentBase)

##### Declaration

```
public override void Deserialize(MyObjectBuilder_ComponentBase objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_ComponentBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentBase.html) | objectBuilder |     |
