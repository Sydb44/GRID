---
title: "Interface IMyBeacon"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyBeacon.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyBeacon"
---

# Interface IMyBeacon | Space Engineers ModAPI

Beacon block interface (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyBeacon : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### HudText

Gets or sets the text to display on the HUD when the beacon is on.

##### Declaration

```
string HudText { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.String |     |

#### Radius

Broadcasting range (read-only)

##### Declaration

```
float Radius { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods