---
title: "Class GridJumpedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.GridJumpedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "GridJumpedEvent"
---

# Class GridJumpedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

GridJumpedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class GridJumpedEvent : MulticastDelegate
```

### Constructors

#### GridJumpedEvent(Object, IntPtr)

##### Declaration

```
public GridJumpedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, String, Int64, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long playerId, string gridName, long gridId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.String | gridName |     |
| System.Int64 | gridId |     |
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

#### Invoke(Int64, String, Int64)

##### Declaration

```
public virtual void Invoke(long playerId, string gridName, long gridId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.String | gridName |     |
| System.Int64 | gridId |     |