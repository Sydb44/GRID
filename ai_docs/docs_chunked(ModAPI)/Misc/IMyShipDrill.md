---
title: "Interface IMyShipDrill"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyShipDrill.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyShipDrill"
---

# Interface IMyShipDrill | Space Engineers ModAPI

Describes ship drill block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyShipDrill : IMyShipToolBase, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### [](#properties)Properties

#### [](#Sandbox_ModAPI_Ingame_IMyShipDrill_TerrainClearingMode)TerrainClearingMode

Voxel removal mode for drilling via Enabled state (but not for mouse activation)

##### Declaration

```
bool TerrainClearingMode { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#extensionmethods)Extension Methods