---
title: "Interface IMyContractSearch"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.IMyContractSearch.html"
category: "Misc"
namespace: "VRage.Game.ModAPI"
class: "IMyContractSearch"
---

# Interface IMyContractSearch | Space Engineers ModAPI

Describes search contract that player can take in contract block (mods interface) Player have to completely repair grid for getting reward

##### Inherited Members

###### **Namespace**: [VRage.Game.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/VRage.Game.ModAPI.html)

###### **Assembly**: VRage.Game.dll

##### Syntax

```
public interface IMyContractSearch : IMyContract
```

### [](#properties)Properties

#### [](#VRage_Game_ModAPI_IMyContractSearch_SearchRadius)SearchRadius

Gets radius in which would be target grid

##### Declaration

```
double SearchRadius { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Double |     |

#### [](#VRage_Game_ModAPI_IMyContractSearch_TargetGridId)TargetGridId

Gets grid that should be found

##### Declaration

```
long TargetGridId { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |