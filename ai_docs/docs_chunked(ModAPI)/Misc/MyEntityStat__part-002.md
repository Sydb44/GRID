#### GetEffects()

##### Declaration

```
public DictionaryReader<int, MyEntityStatRegenEffect> GetEffects()
```

##### Returns

| Type | Description |
| --- | --- |
| [DictionaryReader](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.DictionaryReader-2.html)<System.Int32, [MyEntityStatRegenEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStatRegenEffect.html)\> |     |

#### GetEfficiencyMultiplier(Single, Single)

##### Declaration

```
public float GetEfficiencyMultiplier(float multiplier, float threshold)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | multiplier |     |
| System.Single | threshold |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Single |     |

#### GetObjectBuilder()

##### Declaration

```
public virtual MyObjectBuilder_EntityStat GetObjectBuilder()
```

##### Returns

| Type | Description |
| --- | --- |
| [MyObjectBuilder\_EntityStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.MyObjectBuilder_EntityStat.html) |     |

#### HasAnyEffect(IEnumerable<MyEntityStatRegenEffect>)

##### Declaration

```
public bool HasAnyEffect(IEnumerable<MyEntityStatRegenEffect> ignored = null)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Collections.Generic.IEnumerable<[MyEntityStatRegenEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStatRegenEffect.html)\> | ignored |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Increase(Single, Object)

##### Declaration

```
public void Increase(float amount, object statChangeData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | amount |     |
| System.Object | statChangeData |     |

#### Init(MyObjectBuilder\_Base)

##### Declaration

```
public virtual void Init(MyObjectBuilder_Base objectBuilder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_Base](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.MyObjectBuilder_Base.html) | objectBuilder |     |

#### remove\_OnStatChanged(MyEntityStat.StatChangedDelegate)

##### Declaration

```
public void remove_OnStatChanged(MyEntityStat.StatChangedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyEntityStat.StatChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.StatChangedDelegate.html) | value |     |

#### RemoveEffect(Int32)

##### Declaration

```
public bool RemoveEffect(int id)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | id  |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### ResetRegenAmountMultiplier()

##### Declaration

```
public void ResetRegenAmountMultiplier()
```

#### SetMaxValue(Single)

##### Declaration

```
public void SetMaxValue(float newMaxValue)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | newMaxValue |     |

#### ToString()

##### Declaration

```
public override string ToString()
```

##### Returns

| Type | Description |
| --- | --- |
| System.String |     |

#### TryGetEffect(Int32, out MyEntityStatRegenEffect)

##### Declaration

```
public bool TryGetEffect(int id, out MyEntityStatRegenEffect outEffect)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | id  |     |
| [MyEntityStatRegenEffect](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStatRegenEffect.html) | outEffect |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Update()

##### Declaration

```
public virtual void Update()
```

### Events

#### OnStatChanged

##### Declaration

```
public event MyEntityStat.StatChangedDelegate OnStatChanged
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyEntityStat.StatChangedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.Entities.MyEntityStat.StatChangedDelegate.html) |     |