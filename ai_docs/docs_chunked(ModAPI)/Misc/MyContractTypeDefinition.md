---
title: "Class MyContractTypeDefinition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.MyContractTypeDefinition.html"
category: "Misc"
namespace: "Sandbox.Definitions"
class: "MyContractTypeDefinition"
---

# Class MyContractTypeDefinition | Space Engineers ModAPI

##### Inheritance

System.Object

MyContractTypeDefinition

##### Inherited Members

###### **Namespace**: [Sandbox.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Definitions.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[MyDefinitionType]
public class MyContractTypeDefinition : MyDefinitionBase
```

### Constructors

#### MyContractTypeDefinition()

##### Declaration

```
public MyContractTypeDefinition()
```

### Properties

#### ChancesPerFactionType

##### Declaration

```
public Dictionary<SerializableDefinitionId, float> ChancesPerFactionType { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Collections.Generic.Dictionary<[SerializableDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ObjectBuilders.SerializableDefinitionId.html), System.Single\> |     |

#### DescriptionName

##### Declaration

```
public string DescriptionName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### DurationMultiplier

##### Declaration

```
public double DurationMultiplier { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### FailReputationPrice

##### Declaration

```
public int FailReputationPrice { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MaxStartingDeposit

##### Declaration

```
public long MaxStartingDeposit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### MinimumMoney

##### Declaration

```
public long MinimumMoney { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### MinimumReputation

##### Declaration

```
public int MinimumReputation { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### MinStartingDeposit

##### Declaration

```
public long MinStartingDeposit { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### MoneyReputationCoeficient

##### Declaration

```
public long MoneyReputationCoeficient { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### TitleName

##### Declaration

```
public string TitleName { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

### Methods

#### Init(MyObjectBuilder\_DefinitionBase)

##### Declaration

```
protected override void Init(MyObjectBuilder_DefinitionBase builder)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [MyObjectBuilder\_DefinitionBase](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyObjectBuilder_DefinitionBase.html) | builder |     |

##### Overrides