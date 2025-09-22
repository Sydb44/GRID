```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId | contract id |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | True if contract was finished |

### Events

#### CustomActivateContract

Called when contract is activated.

##### Declaration

```
event MyContractActivateDelegate CustomActivateContract
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyContractActivateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractActivateDelegate.html) |     |

#### CustomCleanUp

Called when contract ended due to any reason. Use to clean up/remove anything.

##### Declaration

```
event MyContractChangeDelegate CustomCleanUp
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) |     |

#### CustomConditionFinished

Called after Condition has been successfully finished.

##### Declaration

```
event MyContractConditionDelegate CustomConditionFinished
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyContractConditionDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractConditionDelegate.html) |     |

#### CustomFail

Called when contract failed.

##### Declaration

```
event MyContractChangeDelegate CustomFail
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) |     |

#### CustomFailFor

Called when contract has failed. Has additional information associated with the contract.

##### Declaration

```
event MyContractFailedDelegate CustomFailFor
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyContractFailedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractFailedDelegate.html) |     |

#### CustomFinish

Called when contract was finished.

##### Declaration

```
event MyContractChangeDelegate CustomFinish
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) |     |

#### CustomFinishFor

Called when contract was finished. Has additional information associated with the contract.

##### Declaration

```
event MyContractFinishedDelegate CustomFinishFor
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyContractFinishedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractFinishedDelegate.html) |     |

#### CustomTimeRanOut

Called immediately just before contract failed.

##### Declaration

```
event MyContractChangeDelegate CustomTimeRanOut
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) |     |

#### CustomUpdate

Called every frame if marked for it by CustomNeedsUpdate.

##### Declaration

```
event MyContractUpdateDelegate CustomUpdate
```

##### Event Type

| Type | Description |
| --- | --- |
| [MyContractUpdateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractUpdateDelegate.html) |     |