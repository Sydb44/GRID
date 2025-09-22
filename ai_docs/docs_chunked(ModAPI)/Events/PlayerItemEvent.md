---
title: "Class PlayerItemEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.PlayerItemEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "PlayerItemEvent"
---

# Class PlayerItemEvent | Space Engineers ModAPI

##### Inheritance

System.Object

PlayerItemEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class PlayerItemEvent : MulticastDelegate
```

### Constructors

#### PlayerItemEvent(Object, IntPtr)

##### Declaration

```
public PlayerItemEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(String, String, Int64, Int32, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(string itemTypeName, string itemSubTypeName, long playerId, int amount, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | itemTypeName |     |
| System.String | itemSubTypeName |     |
| System.Int64 | playerId |     |
| System.Int32 | amount |     |
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

#### Invoke(String, String, Int64, Int32)

##### Declaration

```
public virtual void Invoke(string itemTypeName, string itemSubTypeName, long playerId, int amount)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.String | itemTypeName |     |
| System.String | itemSubTypeName |     |
| System.Int64 | playerId |     |
| System.Int32 | amount |     |