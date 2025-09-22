---
title: "Interface IMyPowerProducer"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyPowerProducer.html"
category: "Power"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyPowerProducer"
---

# Interface IMyPowerProducer | Space Engineers ModAPI

Describes power producer block (PB scripting interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyPowerProducer : IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### CurrentOutput

Gets current output in Megawatts

##### Declaration

```
float CurrentOutput { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### CurrentOutputRatio

Gets ratio of current output

##### Declaration

```
float CurrentOutputRatio { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### MaxOutput

Gets maximum output in Megawatts

##### Declaration

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods