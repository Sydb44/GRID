---
title: "Class RemoteControlChangedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.RemoteControlChangedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "RemoteControlChangedEvent"
---

# Class RemoteControlChangedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

RemoteControlChangedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class RemoteControlChangedEvent : MulticastDelegate
```

### Constructors

#### RemoteControlChangedEvent(Object, IntPtr)

##### Declaration

```
public RemoteControlChangedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Boolean, Int64, String, Int64, String, Int64, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(bool GotControlled, long playerId, string entityName, long entityId, string gridName, long gridId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | GotControlled |     |
| System.Int64 | playerId |     |
| System.String | entityName |     |
| System.Int64 | entityId |     |
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

#### Invoke(Boolean, Int64, String, Int64, String, Int64)

##### Declaration

```
public virtual void Invoke(bool GotControlled, long playerId, string entityName, long entityId, string gridName, long gridId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | GotControlled |     |
| System.Int64 | playerId |     |
| System.String | entityName |     |
| System.Int64 | entityId |     |
| System.String | gridName |     |
| System.Int64 | gridId |     |