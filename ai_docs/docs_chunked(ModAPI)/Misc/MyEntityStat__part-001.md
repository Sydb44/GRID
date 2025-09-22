---
title: "Class MyEntityStat"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEntityStat"
---

# Class MyEntityStat | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityStat

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyFactoryTag]
public class MyEntityStat : Object
```

### Constructors

#### MyEntityStat()

##### Declaration

### Fields

#### m\_currentValue

##### Declaration

```
protected float m_currentValue
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_defaultValue

##### Declaration

```
protected float m_defaultValue
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_maxValue

##### Declaration

```
protected float m_maxValue
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_minValue

##### Declaration

```
protected float m_minValue
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### StatDefinition

##### Declaration

```
public MyEntityStatDefinition StatDefinition
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyEntityStatDefinition](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyEntityStatDefinition.html) |     |

### Properties

#### CurrentRatio

##### Declaration

```
public float CurrentRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### DefaultValue

##### Declaration

```
public float DefaultValue { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxValue

##### Declaration

```
public float MaxValue { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MinValue

##### Declaration

```
public float MinValue { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### ShouldSync

##### Declaration

```
public bool ShouldSync { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### StatId

##### Declaration

```
public MyStringHash StatId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### StatRegenLeft

##### Declaration

```
public float StatRegenLeft { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Value

##### Declaration

```
public float Value { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### add\_OnStatChanged(MyEntityStat.StatChangedDelegate)

##### Declaration

```
public void add_OnStatChanged(MyEntityStat.StatChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityStat.StatChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.StatChangedDelegate.html) | value |     |

#### AddEffect(Single, Single, Single, Single, Single)

##### Declaration

```
public int AddEffect(float amount, float interval, float duration = -1F, float minRegenRatio = 0F, float maxRegenRatio = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | amount |     |
| System.Single | interval |     |
| System.Single | duration |     |
| System.Single | minRegenRatio |     |
| System.Single | maxRegenRatio |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### AddEffect(MyObjectBuilder\_EntityStatRegenEffect)

##### Declaration

```
public int AddEffect(MyObjectBuilder_EntityStatRegenEffect objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_EntityStatRegenEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_EntityStatRegenEffect.html) | objectBuilder |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ApplyRegenAmountMultiplier(Single, Single)

##### Declaration

```
public void ApplyRegenAmountMultiplier(float amountMultiplier = 1F, float duration = 2F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | amountMultiplier |     |
| System.Single | duration |     |

#### CalculateRegenLeftForLongestEffect()

##### Declaration

```
public float CalculateRegenLeftForLongestEffect()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### ClearEffects()

##### Declaration

```
public void ClearEffects()
```

#### Decrease(Single, Object)

##### Declaration

```
public void Decrease(float amount, object statChangeData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | amount |     |
| System.Object | statChangeData |     |

#### GetEffect(Int32)

##### Declaration

```
public MyEntityStatRegenEffect GetEffect(int id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| [MyEntityStatRegenEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStatRegenEffect.html) |     |

#### GetEffects()

##### Declaration

```
public DictionaryReader<int, MyEntityStatRegenEffect> GetEffects()
```

##### Returns

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.Int32, [MyEntityStatRegenEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStatRegenEffect.html)\> |     |
