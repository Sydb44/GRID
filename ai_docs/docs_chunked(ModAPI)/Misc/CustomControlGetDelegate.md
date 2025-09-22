---
title: "Class CustomControlGetDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.CustomControlGetDelegate.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "CustomControlGetDelegate"
---

# Class CustomControlGetDelegate | Space Engineers ModAPI

Allows you to modify the terminal control list before it is displayed to the user. Modifying controls will change which controls are displayed.

##### Inheritance

System.Object

CustomControlGetDelegate

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class CustomControlGetDelegate : MulticastDelegate
```

### Constructors

#### CustomControlGetDelegate(Object, IntPtr)

##### Declaration

```
public CustomControlGetDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(IMyTerminalBlock, List<IMyTerminalControl>, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(IMyTerminalBlock block, List<IMyTerminalControl> controls, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html) | block |     |
| System.Collections.Generic.List<[IMyTerminalControl](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl.html)\> | controls |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### Invoke(IMyTerminalBlock, List<IMyTerminalControl>)

##### Declaration

```
public virtual void Invoke(IMyTerminalBlock block, List<IMyTerminalControl> controls)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html) | block |     |
| System.Collections.Generic.List<[IMyTerminalControl](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl.html)\> | controls |     |