
##### Declaration

```
public bool TryAdd(TKey key, TValue value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |
| TValue | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryGetValue(TKey, out TValue)

##### Declaration

```
public bool TryGetValue(TKey key, out TValue value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |
| TValue | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryRemove(TKey, out TValue)

##### Declaration

```
public bool TryRemove(TKey key, out TValue value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |
| TValue | value |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### TryRemoveConditionally<TCondition>(TKey, out TValue, TCondition)

##### Declaration

```
public bool TryRemoveConditionally<TCondition>(TKey key, out TValue value, TCondition condition)
    where TCondition : IMyCondition<TValue>
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TKey | key |     |
| TValue | value |     |
| TCondition | condition |     |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Type Parameters

| Name | Description |
| --- | --- |
| TCondition |     |

#### WithExclusiveLock(Action<MyConcurrentDictionary<TKey, TValue>>)

##### Declaration

```
public void WithExclusiveLock(Action<MyConcurrentDictionary<TKey, TValue>> action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Action<[MyConcurrentDictionary](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Collections.MyConcurrentDictionary-2.html)<TKey, TValue>> | action |     |