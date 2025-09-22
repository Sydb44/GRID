---
title: "Class MyContractCustom"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.MyContractCustom.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Contracts"
class: "MyContractCustom"
---

# Class MyContractCustom | Space Engineers ModAPI

##### Inheritance

System.Object

MyContractCustom

##### Implements

###### **Namespace**: [Sandbox.ModAPI.Contracts](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Contracts.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
public class MyContractCustom : Object, IMyContractCustom, IMyContract
```

### Constructors

#### MyContractCustom(MyDefinitionId, Int64, Int32, Int32, Int32, String, String, Int32, Int32, Nullable<Int64>)

##### Declaration

```
public MyContractCustom(MyDefinitionId definitionId, long startBlockId, int moneyReward, int collateral, int duration, string name, string description, int reputationReward, int failReputationPrice, Nullable<long> endBlockId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) | definitionId |     |
| System.Int64 | startBlockId |     |
| System.Int32 | moneyReward |     |
| System.Int32 | collateral |     |
| System.Int32 | duration |     |
| System.String | name |     |
| System.String | description |     |
| System.Int32 | reputationReward |     |
| System.Int32 | failReputationPrice |     |
| System.Nullable<System.Int64\> | endBlockId |     |

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

#### DefinitionId

##### Declaration

```
public MyDefinitionId DefinitionId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### Description

##### Declaration

```
public string Description { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Duration

##### Declaration

```
public int Duration { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### EndBlockId

##### Declaration

```
public Nullable<long> EndBlockId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### FailReputationPrice

##### Declaration

```
public int FailReputationPrice { get; }
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

#### Name

##### Declaration

```
public string Name { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

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

#### ReputationReward

##### Declaration

```
public int ReputationReward { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

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