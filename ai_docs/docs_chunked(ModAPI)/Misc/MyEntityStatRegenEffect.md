---
title: "Class MyEntityStatRegenEffect"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStatRegenEffect.html"
category: "Misc"
namespace: "Sandbox.Game.Entities"
class: "MyEntityStatRegenEffect"
---

# Class MyEntityStatRegenEffect | Space Engineers ModAPI

##### Inheritance

System.Object

MyEntityStatRegenEffect

###### **Namespace**: [Sandbox.Game.Entities](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyEntityStatEffectType]
public class MyEntityStatRegenEffect : Object
```

### Constructors

#### MyEntityStatRegenEffect()

##### Declaration

```
public MyEntityStatRegenEffect()
```

### Fields

#### m\_amount

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_duration

##### Declaration

```
protected float m_duration
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_interval

##### Declaration

```
protected float m_interval
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_lastRegenTime

##### Declaration

```
protected int m_lastRegenTime
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### m\_maxRegenRatio

##### Declaration

```
protected float m_maxRegenRatio
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### m\_minRegenRatio

##### Declaration

```
protected float m_minRegenRatio
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### RemoveWhenReachedMaxRegenRatio

##### Declaration

```
public bool RemoveWhenReachedMaxRegenRatio
```

##### Field Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Properties

#### AliveTime

##### Declaration

```
public int AliveTime { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Amount

##### Declaration

```
public float Amount { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### AmountLeftOverDuration

##### Declaration

```
public float AmountLeftOverDuration { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### BirthTime

##### Declaration

```
public int BirthTime { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### DeathTime

##### Declaration

```
public int DeathTime { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Duration

##### Declaration

```
public float Duration { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### Enabled

##### Declaration

```
public bool Enabled { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Interval

##### Declaration

```
public float Interval { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### LastRegenTime

##### Declaration

```
public int LastRegenTime { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### TicksLeft

##### Declaration

```
public int TicksLeft { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

### Methods

#### CalculateTicksBetweenTimes(Int32, Int32)

##### Declaration

```
public int CalculateTicksBetweenTimes(int startTime, int endTime)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | startTime |     |
| System.Int32 | endTime |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Closing()

##### Declaration

```
public virtual void Closing()
```

#### GetMaxRegenRatio()

##### Declaration

```
public float GetMaxRegenRatio()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetObjectBuilder()

##### Declaration

```
public virtual MyObjectBuilder_EntityStatRegenEffect GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityStatRegenEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_EntityStatRegenEffect.html) |     |

#### Init(MyObjectBuilder\_Base, MyEntityStat)

##### Declaration

```
public virtual void Init(MyObjectBuilder_Base objectBuilder, MyEntityStat parentStat)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | objectBuilder |     |
| [MyEntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.html) | parentStat |     |

#### ResetRegenTime()

##### Declaration

```
public void ResetRegenTime()
```

#### SetAmountAndInterval(Single, Single, Boolean)

##### Declaration

```
public void SetAmountAndInterval(float amount, float interval, bool increaseByRemaining)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | amount |     |
| System.Single | interval |     |
| System.Boolean | increaseByRemaining |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### Update(Single)

##### Declaration

```
public virtual void Update(float regenAmountMultiplier = 1F)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | regenAmountMultiplier |     |