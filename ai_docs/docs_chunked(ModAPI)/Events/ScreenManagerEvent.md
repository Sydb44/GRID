---
title: "Class ScreenManagerEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ScreenManagerEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "ScreenManagerEvent"
---

# Class ScreenManagerEvent | Space Engineers ModAPI

##### Inheritance

System.Object

ScreenManagerEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class ScreenManagerEvent : MulticastDelegate
```

### Constructors

#### ScreenManagerEvent(Object, IntPtr)

##### Declaration

```
public ScreenManagerEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(MyGuiScreenBase, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(MyGuiScreenBase screen, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Graphics.GUI.MyGuiScreenBase | screen |     |
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

#### Invoke(MyGuiScreenBase)

##### Declaration

```
public virtual void Invoke(MyGuiScreenBase screen)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Sandbox.Graphics.GUI.MyGuiScreenBase | screen |     |