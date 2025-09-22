---
title: "Class CustomActionGetDelegate"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.CustomActionGetDelegate.html"
category: "Misc"
namespace: "Sandbox.ModAPI"
class: "CustomActionGetDelegate"
---

# Class CustomActionGetDelegate | Space Engineers ModAPI

Allows you to modify the actions associated with a block before it's displayed to user.

##### Inheritance

System.Object

CustomActionGetDelegate

###### **Namespace**: [Sandbox.ModAPI](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.html)

###### **Assembly**: Sandbox.Common.dll

##### Syntax

```
public sealed class CustomActionGetDelegate : MulticastDelegate
```

### Constructors

#### CustomActionGetDelegate(Object, IntPtr)

##### Declaration

```
public CustomActionGetDelegate(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(IMyTerminalBlock, List<IMyTerminalAction>, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(IMyTerminalBlock block, List<IMyTerminalAction> actions, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html) | block |     |
| System.Collections.Generic.List<[IMyTerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction.html)\> | actions |     |
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

#### Invoke(IMyTerminalBlock, List<IMyTerminalAction>)

##### Declaration

```
public virtual void Invoke(IMyTerminalBlock block, List<IMyTerminalAction> actions)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| [IMyTerminalBlock](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.IMyTerminalBlock.html) | block |     |
| System.Collections.Generic.List<[IMyTerminalAction](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction.html)\> | actions |     |