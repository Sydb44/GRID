---
title: "Interface IMyContract"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyContract.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyContract"
---

# Interface IMyContract | Space Engineers ModAPI

Describes contracts that player can take in contract block (mods interface)

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyContract
```

### Properties

#### Collateral

Gets money that player would loose if he won't complete contract

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Duration

Gets duration of contract in minutes

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MoneyReward

Gets reward for completion of this contract

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### OnContractAcquired

Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument

##### Declaration

```
Action<long> OnContractAcquired { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<System.Int64\> |     |

#### OnContractFailed

Gets or sets function that is triggered when contract is failed

##### Declaration

```
Action OnContractFailed { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnContractSucceeded

Gets or sets function that is triggered when contract is successfully completed

##### Declaration

```
Action OnContractSucceeded { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### StartBlockId

Gets id of block, that created contract

##### Declaration

```
long StartBlockId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |