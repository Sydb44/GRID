---
title: "Class RespawnShipSpawnedEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.RespawnShipSpawnedEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "RespawnShipSpawnedEvent"
---

# Class RespawnShipSpawnedEvent | Space Engineers ModAPI

##### Inheritance

System.Object

RespawnShipSpawnedEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class RespawnShipSpawnedEvent : MulticastDelegate
```

### Constructors

#### RespawnShipSpawnedEvent(Object, IntPtr)

##### Declaration

```
public RespawnShipSpawnedEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(Int64, Int64, String, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long shipEntityId, long playerId, string respawnShipPrefabName, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | shipEntityId |     |
| System.Int64 | playerId |     |
| System.String | respawnShipPrefabName |     |
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

#### Invoke(Int64, Int64, String)

##### Declaration

```
public virtual void Invoke(long shipEntityId, long playerId, string respawnShipPrefabName)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | shipEntityId |     |
| System.Int64 | playerId |     |
| System.String | respawnShipPrefabName |     |