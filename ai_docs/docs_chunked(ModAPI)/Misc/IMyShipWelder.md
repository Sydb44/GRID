---
title: "Interface IMyShipWelder"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyShipWelder.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyShipWelder"
---

# Interface IMyShipWelder | Space Engineers ModAPI

Describes ship welder interface (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyShipWelder : IMyShipToolBase, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### HelpOthers

Gets and sets whether this welder can help other welders

##### Declaration

```
bool HelpOthers { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

### Extension Methods