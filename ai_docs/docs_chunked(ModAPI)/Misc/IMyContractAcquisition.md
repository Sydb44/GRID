---
title: "Interface IMyContractAcquisition"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyContractAcquisition.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyContractAcquisition"
---

# Interface IMyContractAcquisition | Space Engineers ModAPI

Describes acquisition contract that player can take in contract block (mods interface)

##### Inherited Members

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyContractAcquisition : IMyContract
```

### Properties

#### EndBlockId

Gets id of block, that should receive goods

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

#### ItemAmount

Gets amount of items that should be delivered

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Int32 |     |

#### ItemTypeId

Gets id of item that should be delivered

##### Declaration

```
MyDefinitionId ItemTypeId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MyDefinitionId](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.MyDefinitionId.html) |     |