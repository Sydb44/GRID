---
title: "Class ShipDrillCollectedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.ShipDrillCollectedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "ShipDrillCollectedEvent"
---

# Class ShipDrillCollectedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

ShipDrillCollectedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class ShipDrillCollectedEvent : MulticastDelegate
```

### Constructors

#### ShipDrillCollectedEvent(Object, IntPtr)

##### Declaration

```
public ShipDrillCollectedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, Int64, String, Int64, String, String, Single, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string entityName, long entityId, string gridName, long gridId, string typeId, string subtypeId, float amount, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |
| System.Int64 | entityId |     |
| System.String | gridName |     |
| System.Int64 | gridId |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.Single | amount |     |
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

#### Invoke(String, Int64, String, Int64, String, String, Single)

##### Declaration

```
public virtual void Invoke(string entityName, long entityId, string gridName, long gridId, string typeId, string subtypeId, float amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | entityName |     |
| System.Int64 | entityId |     |
| System.String | gridName |     |
| System.Int64 | gridId |     |
| System.String | typeId |     |
| System.String | subtypeId |     |
| System.Single | amount |     |