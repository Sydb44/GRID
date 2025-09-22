---
title: "Interface IMyShipToolBase"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyShipToolBase.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyShipToolBase"
---

# Interface IMyShipToolBase | Space Engineers ModAPI

Describes ship tool block (drill/grinder/welder) (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyShipToolBase : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### [](#properties)Properties

#### [](#Sandbox_ModAPI_Ingame_IMyShipToolBase_IsActivated)IsActivated

True if the tool is activated by mouse click or toggling via terminal.

##### Declaration

```
bool IsActivated { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### [](#Sandbox_ModAPI_Ingame_IMyShipToolBase_UseConveyorSystem)UseConveyorSystem

Gets or sets if block should push/pull items from conveyor system

##### Declaration

```
bool UseConveyorSystem { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### [](#extensionmethods)Extension Methods