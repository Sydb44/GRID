---
title: "Class ToolbarItemChangedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ToolbarItemChangedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "ToolbarItemChangedEvent"
---

# Class ToolbarItemChangedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

ToolbarItemChangedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class ToolbarItemChangedEvent : MulticastDelegate
```

### Constructors

#### ToolbarItemChangedEvent(Object, IntPtr)

##### Declaration

```
public ToolbarItemChangedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, String, String, Int32, Int32, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long entityId, string typeId, string subtypeId, int page, int slot, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.Int32 | page |     |
| System.Int32 | slot |     |
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

#### Invoke(Int64, String, String, Int32, Int32)

##### Declaration

```
public virtual void Invoke(long entityId, string typeId, string subtypeId, int page, int slot)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.Int32 | page |     |
| System.Int32 | slot |     |