---
title: "Interface IMyBasicMissionBlock"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBasicMissionBlock.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyBasicMissionBlock"
---

# Interface IMyBasicMissionBlock | Space Engineers ModAPI

Describes basic mission block interface

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyBasicMissionBlock : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### SelectedMissionId

Gets or sets the selected mission id. Each id of the mission is unique. You can find ids of the missions on the EntityComponents.sbc.

##### Declaration

```
long SelectedMissionId { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Int64 |     |

### Extension Methods