---
title: "Class MyContractSearch"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.MyContractSearch.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Contracts"
class: "MyContractSearch"
---

# Class MyContractSearch | Space Engineers ModAPI

##### Inheritance

System.Object

MyContractSearch

##### Implements

###### **Namespace**: [Sandbox.ModAPI.Contracts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyContractSearch : Object, IMyContractSearch, IMyContract
```

### Constructors

#### MyContractSearch(Int64, Int32, Int32, Int32, Int64, Double)

##### Declaration

```
public MyContractSearch(long startBlockId, int moneyReward, int collateral, int duration, long targetGridId, double searchRadius)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | startBlockId |     |
| System.Int32 | moneyReward |     |
| System.Int32 | collateral |     |
| System.Int32 | duration |     |
| System.Int64 | targetGridId |     |
| System.Double | searchRadius |     |

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

#### SearchRadius

##### Declaration

```
public double SearchRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### StartBlockId

##### Declaration

```
public long StartBlockId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### TargetGridId

##### Declaration

```
public long TargetGridId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Implements