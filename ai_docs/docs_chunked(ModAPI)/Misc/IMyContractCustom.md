---
title: "Interface IMyContractCustom"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyContractCustom.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyContractCustom"
---

# Interface IMyContractCustom | Space Engineers ModAPI

Describes custom contract (mods interface)

##### Inherited Members

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyContractCustom : IMyContract
```

### Properties

#### DefinitionId

Definition id of contract.

##### Declaration

```
MyDefinitionId DefinitionId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |

#### Description

Description of contract

##### Declaration

```
string Description { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### EndBlockId

[EntityId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.ModAPI.IMyEntity.html#VRage_ModAPI_IMyEntity_EntityId) of block that should finish contract

##### Declaration

```
Nullable<long> EndBlockId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Nullable<System.Int64\> |     |

#### FailReputationPrice

Amount of reputation you lose on contract failure

##### Declaration

```
int FailReputationPrice { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### Name

Name of contract

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### ReputationReward

Amount of reputation gained on contract success

##### Declaration

```
int ReputationReward { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |