---
title: "Class ConnectorStateChangedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ConnectorStateChangedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "ConnectorStateChangedEvent"
---

# Class ConnectorStateChangedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

ConnectorStateChangedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class ConnectorStateChangedEvent : MulticastDelegate
```

### Constructors

#### ConnectorStateChangedEvent(Object, IntPtr)

##### Declaration

```
public ConnectorStateChangedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, Int64, String, String, Int64, Int64, String, String, Boolean, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long entityId, long gridId, string entityName, string gridName, long otherEntityId, long otherGridId, string otherEntityName, string otherGridName, bool isConnected, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | entityName |     |
| System.String | gridName |     |
| System.Int64 | otherEntityId |     |
| System.Int64 | otherGridId |     |
| System.String | otherEntityName |     |
| System.String | otherGridName |     |
| System.Boolean | isConnected |     |
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

#### Invoke(Int64, Int64, String, String, Int64, Int64, String, String, Boolean)

##### Declaration

```
public virtual void Invoke(long entityId, long gridId, string entityName, string gridName, long otherEntityId, long otherGridId, string otherEntityName, string otherGridName, bool isConnected)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | entityId |     |
| System.Int64 | gridId |     |
| System.String | entityName |     |
| System.String | gridName |     |
| System.Int64 | otherEntityId |     |
| System.Int64 | otherGridId |     |
| System.String | otherEntityName |     |
| System.String | otherGridName |     |
| System.Boolean | isConnected |     |