---
title: "Interface IMyCockpit"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyCockpit.html"
category: "Flight"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyCockpit"
---

# Interface IMyCockpit | Space Engineers ModAPI

Describes cockpit block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyCockpit : IMyShipController, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyTextSurfaceProvider
```

### [](#properties)Properties

#### [](#Sandbox_ModAPI_Ingame_IMyCockpit_OxygenCapacity)OxygenCapacity

Gets the maximum oxygen capacity of this cockpit.

##### Declaration

```
float OxygenCapacity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### [](#Sandbox_ModAPI_Ingame_IMyCockpit_OxygenFilledRatio)OxygenFilledRatio

Gets the current oxygen level of this cockpit, as a value between 0 (empty) and 1 (full).

##### Declaration

```
float OxygenFilledRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### [](#extensionmethods)Extension Methods