---
title: "Interface IMyTerminalControlSlider"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalControlSlider"
---

# Interface IMyTerminalControlSlider | Space Engineers ModAPI

This is a value slider. A slider can be moved by a user and a value selected.

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalControlSlider : IMyTerminalControl, IMyTerminalValueControl<float>, ITerminalProperty, IMyTerminalControlTitleTooltip
```

### Properties

#### Writer

This is triggered when a slider value is modified. Appending to the string builder allows you to modify the text that is displayed along side the slider when it updates.

##### Declaration

```
Action<IMyTerminalBlock, StringBuilder> Writer { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Text.StringBuilder\> |     |

### Methods

#### SetDualLogLimits(Func<IMyTerminalBlock, Single>, Func<IMyTerminalBlock, Single>, Single)

Allows you to set the upper and lower limits of the slider with delegates, interpolating on a logarithmic scale at both ends

##### Declaration

```
void SetDualLogLimits(Func<IMyTerminalBlock, float> minGetter, Func<IMyTerminalBlock, float> maxGetter, float centerBand)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Single\> | minGetter |     |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Single\> | maxGetter |     |
| System.Single | centerBand |     |

#### SetDualLogLimits(Single, Single, Single)

Allows you to set the upper and lower limits of the slider, interpolating on a logarithmic scale at both ends

##### Declaration

```
void SetDualLogLimits(float absMin, float absMax, float centerBand)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | absMin |     |
| System.Single | absMax |     |
| System.Single | centerBand |     |

#### SetLimits(Func<IMyTerminalBlock, Single>, Func<IMyTerminalBlock, Single>)

Allows you to set the upper and lower limits of the slider with delegates

##### Declaration

```
void SetLimits(Func<IMyTerminalBlock, float> minGetter, Func<IMyTerminalBlock, float> maxGetter)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Single\> | minGetter |     |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Single\> | maxGetter |     |

#### SetLimits(Single, Single)

Allows you to set the upper and lower limits of the slider

##### Declaration

```
void SetLimits(float min, float max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | min | Minimum value |
| System.Single | max | Maximum value |

#### SetLogLimits(Func<IMyTerminalBlock, Single>, Func<IMyTerminalBlock, Single>)

Allows you to set the upper and lower limits of the slider with delegates, interpolating on a logarithmic scale

##### Declaration

```
void SetLogLimits(Func<IMyTerminalBlock, float> minGetter, Func<IMyTerminalBlock, float> maxGetter)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Single\> | minGetter |     |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), System.Single\> | maxGetter |     |

#### SetLogLimits(Single, Single)

Allows you to set the upper and lower limits of the slider, interpolating on a logarithmic scale

##### Declaration

```
void SetLogLimits(float min, float max)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | min |     |
| System.Single | max |     |

### Extension Methods