---
title: "Interface IMyShipMergeBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.IMyShipMergeBlock.html"
category: "Misc"
namespace: "SpaceEngineers.Game.ModAPI.Ingame"
class: "IMyShipMergeBlock"
---

# Interface IMyShipMergeBlock | Space Engineers ModAPI

##### Inherited Members

###### **Namespace**: [SpaceEngineers.Game.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.html)

###### **Assembly**: SpaceEngineers.Game.dll

##### Syntax

```
public interface IMyShipMergeBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### IsConnected

Gets if the merge block is locked to another one.

##### Declaration

```
bool IsConnected { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### State

State of the merge block

##### Declaration

```
MergeState State { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| [MergeState](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/SpaceEngineers.Game.ModAPI.Ingame.MergeState.html) |     |

### Extension Methods