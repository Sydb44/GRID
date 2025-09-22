---
title: "Class SingleKeyPlayerEvent"
url: "https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.SingleKeyPlayerEvent.html"
category: "Events"
namespace: "Sandbox.Game"
class: "SingleKeyPlayerEvent"
---

# Class SingleKeyPlayerEvent | Space Engineers ModAPI

##### Inheritance

System.Object

SingleKeyPlayerEvent

###### **Namespace**: [Sandbox.Game](https://keensoftwarehouse.github.io/SpaceEngineersModAPI/api/Sandbox.Game.html)

###### **Assembly**: Sandbox.Game.dll

##### Syntax

```
[VisualScriptingEvent]
public sealed class SingleKeyPlayerEvent : MulticastDelegate
```

### [](#constructors)Constructors

#### [](#Sandbox_Game_SingleKeyPlayerEvent__ctor_System_Object_System_IntPtr_)SingleKeyPlayerEvent(Object, IntPtr)

##### Declaration

```
public SingleKeyPlayerEvent(object object, IntPtr method)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Object | object |     |
| System.IntPtr | method |     |

### [](#methods)Methods

#### [](#Sandbox_Game_SingleKeyPlayerEvent_BeginInvoke_System_Int64_System_AsyncCallback_System_Object_)BeginInvoke(Int64, AsyncCallback, Object)

##### Declaration

```
public virtual IAsyncResult BeginInvoke(long playerId, AsyncCallback callback, object object)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |
| System.AsyncCallback | callback |     |
| System.Object | object |     |

##### Returns

| Type | Description |
| --- | --- |
| System.IAsyncResult |     |

#### [](#Sandbox_Game_SingleKeyPlayerEvent_EndInvoke_System_IAsyncResult_)EndInvoke(IAsyncResult)

##### Declaration

```
public virtual void EndInvoke(IAsyncResult result)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.IAsyncResult | result |     |

#### [](#Sandbox_Game_SingleKeyPlayerEvent_Invoke_System_Int64_)Invoke(Int64)

##### Declaration

```
public virtual void Invoke(long playerId)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int64 | playerId |     |