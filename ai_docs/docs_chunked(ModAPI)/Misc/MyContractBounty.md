---
title: "Class MyContractBounty"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.MyContractBounty.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Contracts"
class: "MyContractBounty"
---

# Class MyContractBounty | Space Engineers ModAPI

##### Inheritance

System.Object

MyContractBounty

##### Implements

###### **Namespace**: [Sandbox.ModAPI.Contracts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyContractBounty : Object, IMyContractBounty, IMyContract
```

### Constructors

#### MyContractBounty(Int64, Int32, Int32, Int32, Int64)

##### Declaration

```
public MyContractBounty(long startBlockId, int moneyReward, int collateral, int duration, long targetIdentityId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | startBlockId |     |
| System.Int32 | moneyReward |     |
| System.Int32 | collateral |     |
| System.Int32 | duration |     |
| System.Int64 | targetIdentityId |     |

### Properties

#### Collateral

##### Declaration

```
public int Collateral { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Duration

##### Declaration

```
public int Duration { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MoneyReward

##### Declaration

```
public int MoneyReward { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### OnContractAcquired

##### Declaration

```
public Action<long> OnContractAcquired { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<System.Int64\> |     |

#### OnContractFailed

##### Declaration

```
public Action OnContractFailed { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### OnContractSucceeded

##### Declaration

```
public Action OnContractSucceeded { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action |     |

#### StartBlockId

##### Declaration

```
public long StartBlockId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### TargetIdentityId

##### Declaration

```
public long TargetIdentityId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Implements