---
title: "Class SingleKeyPlayerConnectRequestEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.SingleKeyPlayerConnectRequestEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "SingleKeyPlayerConnectRequestEvent"
---

# Class SingleKeyPlayerConnectRequestEvent | Space Engineers ModAPI

##### Inheritance

System.Object

SingleKeyPlayerConnectRequestEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class SingleKeyPlayerConnectRequestEvent : MulticastDelegate
```

### Constructors

#### SingleKeyPlayerConnectRequestEvent(Object, IntPtr)

##### Declaration

```
public SingleKeyPlayerConnectRequestEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### Methods

#### BeginInvoke(UInt64, ref JoinResult, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(ulong steamId, ref JoinResult result, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId |     |
| VRage.Network.JoinResult | result |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### EndInvoke(ref JoinResult, IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(ref JoinResult result, IAsyncResult __result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| VRage.Network.JoinResult | result |     |
| System.IAsyncResult | \_\_result |     |

#### Invoke(UInt64, ref JoinResult)

##### Declaration

```
public virtual void Invoke(ulong steamId, ref JoinResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.UInt64 | steamId |     |
| VRage.Network.JoinResult | result |     |