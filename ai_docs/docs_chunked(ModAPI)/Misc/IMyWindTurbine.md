---
title: "Interface IMyWindTurbine"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.IMyWindTurbine.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Ingame"
class: "IMyWindTurbine"
---

# Interface IMyWindTurbine | Space Engineers ModAPI

Describes wind turbine block (program block interface)

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Ingame](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Ingame.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyWindTurbine : IMyPowerProducer, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

### Properties

#### Effectivity

Gets current total efficiency of wind turbine. Range of values: \[0 - 1\] (could be more than 1 during storms)

##### Declaration

```
float Effectivity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### PlacementEffectivity

Gets current efficiency of wind turbine based on nearby blocks. Range of values: \[0 - 1\]

##### Declaration

```
float PlacementEffectivity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

#### WindEffectivity

Gets wind efficiency multiplier. Range of values: 0 - is 0%, 1 - is 100%, could be more 100%

##### Declaration

```
float WindEffectivity { get; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Single |     |

### Extension Methods