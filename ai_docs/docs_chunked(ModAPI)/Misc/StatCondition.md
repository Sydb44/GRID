---
title: "Class StatCondition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.StatCondition.html"
category: "Misc"
namespace: "VRage.Game.ObjectBuilders.Definitions"
class: "StatCondition"
---

# Class StatCondition | Space Engineers ModAPI

##### Inheritance

System.Object

StatCondition

##### Inherited Members

###### **Namespace**: [VRage.Game.ObjectBuilders.Definitions](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
[MyObjectBuilderDefinition]
public class StatCondition : ConditionBase
```

### Constructors

#### StatCondition()

##### Declaration

### Fields

#### Operator

##### Declaration

```
public StatConditionOperator Operator
```

##### Field Value

| Type | Description |
| --- | --- |
| [StatConditionOperator](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ObjectBuilders.Definitions.StatConditionOperator.html) |     |

#### StatId

##### Declaration

```
public MyStringHash StatId
```

##### Field Value

| Type | Description |
| --- | --- |
| [MyStringHash](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Utils.MyStringHash.html) |     |

#### Value

##### Declaration

##### Field Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Methods

#### Eval()

##### Declaration

```
public override bool Eval()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean |     |

##### Overrides

#### SetStat(IMyHudStat)

##### Declaration

```
public void SetStat(IMyHudStat stat)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyHudStat](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyHudStat.html) | stat |     |

### Extension Methods