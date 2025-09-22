---
title: "Class ButtonPanelEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ButtonPanelEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "ButtonPanelEvent"
---

# Class ButtonPanelEvent | Space Engineers ModAPI

##### Inheritance

System.Object

ButtonPanelEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class ButtonPanelEvent : MulticastDelegate
```

### Constructors

#### ButtonPanelEvent(Object, IntPtr)

##### Declaration

```
public ButtonPanelEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, Int32, Int64, Int64, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string name, int button, long playerId, long blockId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.Int32 | button |     |
| System.Int64 | playerId |     |
| System.Int64 | blockId |     |
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

#### Invoke(String, Int32, Int64, Int64)

##### Declaration

```
public virtual void Invoke(string name, int button, long playerId, long blockId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | name |     |
| System.Int32 | button |     |
| System.Int64 | playerId |     |
| System.Int64 | blockId |     |