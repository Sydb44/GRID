---
title: "Class RoomFullyPressurizedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.RoomFullyPressurizedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "RoomFullyPressurizedEvent"
---

# Class RoomFullyPressurizedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

RoomFullyPressurizedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class RoomFullyPressurizedEvent : MulticastDelegate
```

### Constructors

#### RoomFullyPressurizedEvent(Object, IntPtr)

##### Declaration

```
public RoomFullyPressurizedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, Int64, String, String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long entityId, long gridId, string entityName, string gridName, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | entityName |     |
| System.String | gridName |     |
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

#### Invoke(Int64, Int64, String, String)

##### Declaration

```
public virtual void Invoke(long entityId, long gridId, string entityName, string gridName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | entityName |     |
| System.String | gridName |     |