```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId | contract id |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> | Definition Id of the contract |

#### GetContractState(Int64)

Gets Contract State

##### Declaration

```
MyCustomContractStateEnum GetContractState(long contractId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId | contract id |

##### Returns

| Type | Description |
| --- | --- |
| [MyCustomContractStateEnum](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyCustomContractStateEnum.html) | state of the contract |

#### IsContractActive(Int64)

Checks if specified contract is in active state

##### Declaration

```
bool IsContractActive(long contractId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId | contract id |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if contract is active |

#### remove\_CustomActivateContract(MyContractActivateDelegate)

##### Declaration

```
void remove_CustomActivateContract(MyContractActivateDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractActivateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractActivateDelegate.html) | value |     |

#### remove\_CustomCleanUp(MyContractChangeDelegate)

##### Declaration

```
void remove_CustomCleanUp(MyContractChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) | value |     |

#### remove\_CustomConditionFinished(MyContractConditionDelegate)

##### Declaration

```
void remove_CustomConditionFinished(MyContractConditionDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractConditionDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractConditionDelegate.html) | value |     |

#### remove\_CustomFail(MyContractChangeDelegate)

##### Declaration

```
void remove_CustomFail(MyContractChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) | value |     |

#### remove\_CustomFailFor(MyContractFailedDelegate)

##### Declaration

```
void remove_CustomFailFor(MyContractFailedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractFailedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractFailedDelegate.html) | value |     |

#### remove\_CustomFinish(MyContractChangeDelegate)

##### Declaration

```
void remove_CustomFinish(MyContractChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) | value |     |

#### remove\_CustomFinishFor(MyContractFinishedDelegate)

##### Declaration

```
void remove_CustomFinishFor(MyContractFinishedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractFinishedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractFinishedDelegate.html) | value |     |

#### remove\_CustomTimeRanOut(MyContractChangeDelegate)

##### Declaration

```
void remove_CustomTimeRanOut(MyContractChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) | value |     |

#### remove\_CustomUpdate(MyContractUpdateDelegate)

##### Declaration

```
void remove_CustomUpdate(MyContractUpdateDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractUpdateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractUpdateDelegate.html) | value |     |

#### RemoveContract(Int64)

Removes the contract

##### Declaration

```
bool RemoveContract(long contractId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId | contract id |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if contract was removed |

#### TryAbandonCustomContract(Int64, Int64)

Tries to abandon the contract

##### Declaration

```
bool TryAbandonCustomContract(long contractId, long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId | contract id |
| System.Int64 | playerId | player id who has the contract |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if contract was abandoned |

#### TryFailCustomContract(Int64)

Tries to set the contract to fail state

##### Declaration

```
bool TryFailCustomContract(long contractId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId | contract id |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if contract was failed |

#### TryFinishCustomContract(Int64)

Tries to set the contract to finish state

##### Declaration

```
bool TryFinishCustomContract(long contractId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId | contract id |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if contract was finished |
