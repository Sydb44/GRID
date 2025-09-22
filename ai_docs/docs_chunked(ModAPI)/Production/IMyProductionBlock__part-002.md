##### Declaration

```
void InsertQueueItem(int idx, MyDefinitionId blueprint, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx | Index of the item |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | blueprint | A MyDefinitionId that names the blueprint |
| VRage.MyFixedPoint | amount | Amount of items |

#### MoveQueueItemRequest(UInt32, Int32)

Moves an item in the queue to a target position in the queue.

##### Declaration

```
void MoveQueueItemRequest(uint queueItemId, int targetIdx)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt32 | queueItemId | Finds item by queue item id |
| System.Int32 | targetIdx | Target position in queue |

#### RemoveQueueItem(Int32, Decimal)

Removes an item from the queue

##### Declaration

```
void RemoveQueueItem(int idx, Decimal amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx | Index of the item |
| System.Decimal | amount | Amount to remove |

#### RemoveQueueItem(Int32, Double)

Removes an item from the queue

##### Declaration

```
void RemoveQueueItem(int idx, double amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx | Index of the item |
| System.Double | amount | Amount to remove |

#### RemoveQueueItem(Int32, MyFixedPoint)

Removes an item from the queue

##### Declaration

```
void RemoveQueueItem(int idx, MyFixedPoint amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | idx | Index of the item |
| VRage.MyFixedPoint | amount | Amount to remove |

### Extension Methods