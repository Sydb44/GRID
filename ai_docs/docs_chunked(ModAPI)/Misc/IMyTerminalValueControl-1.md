---
title: "Interface IMyTerminalValueControl<TValue>"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalValueControl-1.html"
category: "Misc"
namespace: "Sandbox.ModAPI.Interfaces.Terminal"
class: "IMyTerminalValueControl-1"
---

# Interface IMyTerminalValueControl<TValue> | Space Engineers ModAPI

This is a value control interface that a few controls implement. When a value changes, the Setter action is performed. When a value is queried the Getter action is performed.

##### Inherited Members

###### **Namespace**: [Sandbox.ModAPI.Interfaces.Terminal](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public interface IMyTerminalValueControl<TValue> : ITerminalProperty
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue |     |

### Properties

#### Getter

This is triggered when the value of the control is required.

##### Declaration

```
Func<IMyTerminalBlock, TValue> Getter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Func<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), TValue> |     |

#### Setter

This is triggered when the value of the control is set by the user. Depending on the control, this may be called a lot.

##### Declaration

```
Action<IMyTerminalBlock, TValue> Setter { get; set; }
```

##### Property Value

| Type | Description |
| --- | --- |
| System.Action<[IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html), TValue> |     |

### Extension Methods