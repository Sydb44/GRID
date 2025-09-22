---
title: "Interface IMyContractSystem"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyContractSystem.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyContractSystem"
---

# Interface IMyContractSystem | Space Engineers ModAPI

Describes contract system (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyContractSystem
```

### Properties

#### CustomCanActivateContract

Gets or sets function that is triggered when player trying to take contract First argument - ContractId, Second - IdentityId

##### Declaration

```
Func<long, long, MyActivationCustomResults> CustomCanActivateContract { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<System.Int64, System.Int64, [MyActivationCustomResults](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyActivationCustomResults.html)\> |     |

#### CustomFinishCondition

The operation of finishing Condition itself Returns whether it succeeded or not

##### Declaration

```
Func<long, long, bool> CustomFinishCondition { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<System.Int64, System.Int64, System.Boolean\> |     |

#### CustomNeedsUpdate

Gets or sets function that is triggered each 100 frames per each contract.

##### Declaration

```
Func<long, bool> CustomNeedsUpdate { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<System.Int64, System.Boolean\> |     |

### Methods

#### add\_CustomActivateContract(MyContractActivateDelegate)

##### Declaration

```
void add_CustomActivateContract(MyContractActivateDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractActivateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractActivateDelegate.html) | value |     |

#### add\_CustomCleanUp(MyContractChangeDelegate)

##### Declaration

```
void add_CustomCleanUp(MyContractChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) | value |     |

#### add\_CustomConditionFinished(MyContractConditionDelegate)

##### Declaration

```
void add_CustomConditionFinished(MyContractConditionDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractConditionDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractConditionDelegate.html) | value |     |

#### add\_CustomFail(MyContractChangeDelegate)

##### Declaration

```
void add_CustomFail(MyContractChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) | value |     |

#### add\_CustomFailFor(MyContractFailedDelegate)

##### Declaration

```
void add_CustomFailFor(MyContractFailedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractFailedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractFailedDelegate.html) | value |     |

#### add\_CustomFinish(MyContractChangeDelegate)

##### Declaration

```
void add_CustomFinish(MyContractChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) | value |     |

#### add\_CustomFinishFor(MyContractFinishedDelegate)

##### Declaration

```
void add_CustomFinishFor(MyContractFinishedDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractFinishedDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractFinishedDelegate.html) | value |     |

#### add\_CustomTimeRanOut(MyContractChangeDelegate)

##### Declaration

```
void add_CustomTimeRanOut(MyContractChangeDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractChangeDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractChangeDelegate.html) | value |     |

#### add\_CustomUpdate(MyContractUpdateDelegate)

##### Declaration

```
void add_CustomUpdate(MyContractUpdateDelegate value)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyContractUpdateDelegate](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyContractUpdateDelegate.html) | value |     |

#### AddContract(IMyContract)

Adds the contract

##### Declaration

```
MyAddContractResultWrapper AddContract(IMyContract contract)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyContract](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyContract.html) | contract | contract id |

##### Returns

| Type | Description |
| --- | --- |
| [MyAddContractResultWrapper](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.MyAddContractResultWrapper.html) | information about new contract |

#### GetContractDefinitionId(Int64)

Gets Contracts Definition Id

##### Declaration

```
Nullable<MyDefinitionId> GetContractDefinitionId(long contractId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | contractId | contract id |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<[MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html)\> | Definition Id of the contract |
