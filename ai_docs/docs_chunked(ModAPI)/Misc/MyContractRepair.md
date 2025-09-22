---
title: "Class MyContractRepair"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.MyContractRepair.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Contracts"
class: "MyContractRepair"
---

# Class MyContractRepair | Space Engineers ModAPI

##### Inheritance

System.Object

MyContractRepair

##### Implements

###### **Namespace**: [Sandbox.ModAPI.Contracts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyContractRepair : Object, IMyContractRepair, IMyContract
```

### Constructors

#### MyContractRepair(Int64, Int32, Int32, Int32, Int64)

##### Declaration

```
public MyContractRepair(long startBlockId, int moneyReward, int collateral, int duration, long gridId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | startBlockId |     |
| System.Int32 | moneyReward |     |
| System.Int32 | collateral |     |
| System.Int32 | duration |     |
| System.Int64 | gridId |     |

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

#### GridId

##### Declaration

```
public long GridId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

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

### Implements