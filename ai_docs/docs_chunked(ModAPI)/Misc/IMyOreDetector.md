---
title: "Interface IMyOreDetector"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyOreDetector.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyOreDetector"
---

# Interface IMyOreDetector | Space Engineers ModAPI

Describes ore detector block (PB scripting interface)(mods interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyOreDetector : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### BroadcastUsingAntennas

Gets or sets whether block should use antennas to broadcast ore deposits

##### Declaration

```
bool BroadcastUsingAntennas { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Boolean |     |

#### Range

Gets ore detection range in meters

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods